﻿# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.SYNOPSIS
Generate new WAD config file from given template and storage account name
#>
function New-WADConfigFromTemplate ($inputPath, $outputPath, $storageAccountName)
{
    (Get-Content $inputPath).replace('[StorageAccountName]', $storageAccountName) | Set-Content $outputPath;
}

<#
.SYNOPSIS
Test the basic usage of the Set/Get/Remove virtual machine diagnostics extension command
#>
function Test-DiagnosticsExtensionBasic
{
    $rgname = Get-ComputeTestResourceName
    $loc = Get-ComputeVMLocation

    try
    {
        # Setup
        $vm = Create-VirtualMachine -rgname $rgname -loc $loc
        $vmname = $vm.Name

        # This is the storage name defined in config file
        $storagename = 'stoinconfig' + $rgname
        $storagetype = 'Standard_GRS'
        New-AzStorageAccount -ResourceGroupName $rgname -Name $storagename -Location $loc -Type $storagetype

        # If diagnostics extension already exist, remove it
        $extension = Get-AzVMDiagnosticsExtension -ResourceGroupName $rgname -VMName $vmname
        if ($extension) {
            Remove-AzVMDiagnosticsExtension -ResourceGroupName $rgname -VMName $vmname
            $extension = Get-AzVMDiagnosticsExtension -ResourceGroupName $rgname -VMName $vmname
            Assert-Null $extension
        }

        $configTemplate = Join-Path $ConfigFilesPath "DiagnosticsExtensionConfig.xml";
        $configFilePath = Join-Path $ConfigFilesPath "config-$rgname.xml";

        New-WADConfigFromTemplate $configTemplate $configFilePath $storagename;

        # Test Set and Get command. It should use the storage account defined in configuration file
        Set-AzVMDiagnosticsExtension -ResourceGroupName $rgname -VMName $vmname -DiagnosticsConfigurationPath $configFilePath
        $extension = Get-AzVMDiagnosticsExtension -ResourceGroupName $rgname -VMName $vmname

        Assert-NotNull $extension
        Assert-AreEqual $extension.Publisher 'Microsoft.Azure.Diagnostics'
        Assert-AreEqual $extension.ExtensionType 'IaaSDiagnostics'
        Assert-AreEqual $extension.Name 'Microsoft.Insights.VMDiagnosticsSettings'
        $settings = $extension.PublicSettings | ConvertFrom-Json
        Assert-AreEqual $settings.storageAccount $storagename

        # Test Remove command.
        Remove-AzVMDiagnosticsExtension -ResourceGroupName $rgname -VMName $vmname
        $extension = Get-AzVMDiagnosticsExtension -ResourceGroupName $rgname -VMName $vmname
        Assert-Null $extension
    }
    finally
    {
        # Cleanup
        Clean-ResourceGroup $rgname

        if (Test-Path $configFilePath)
        {
            Remove-Item $configFilePath;
        }
    }
}

<#
.SYNOPSIS
Test specifying storage account name in command line.
The diagnostic extension should use this name instead of the one defined in config file.
#>
function Test-DiagnosticsExtensionSepcifyStorageAccountName
{
    $rgname = Get-ComputeTestResourceName
    $loc = Get-ComputeVMLocation

    try
    {
        # Setup
        $vm = Create-VirtualMachine -rgname $rgname -loc $loc
        $vmname = $vm.Name

        # This storage name will be used in command line directly when set diagnostics extension
        $storagename = 'stoincmd' + $rgname
        $storagetype = 'Standard_GRS'
        New-AzStorageAccount -ResourceGroupName $rgname -Name $storagename -Location $loc -Type $storagetype

        # If diagnostics extension already exist, remove it
        $extension = Get-AzVMDiagnosticsExtension -ResourceGroupName $rgname -VMName $vmname
        if ($extension) {
            Remove-AzVMDiagnosticsExtension -ResourceGroupName $rgname -VMName $vmname
            $extension = Get-AzVMDiagnosticsExtension -ResourceGroupName $rgname -VMName $vmname
            Assert-Null $extension
        }

        Set-AzVMDiagnosticsExtension -ResourceGroupName $rgname -VMName $vmname -DiagnosticsConfigurationPath (Join-Path $ConfigFilesPath "DiagnosticsExtensionConfig.xml") -StorageAccountName $storagename
        $extension = Get-AzVMDiagnosticsExtension -ResourceGroupName $rgname -VMName $vmname

        Assert-NotNull $extension
        Assert-AreEqual $extension.Publisher 'Microsoft.Azure.Diagnostics'
        Assert-AreEqual $extension.ExtensionType 'IaaSDiagnostics'
        Assert-AreEqual $extension.Name 'Microsoft.Insights.VMDiagnosticsSettings'
        $settings = $extension.PublicSettings | ConvertFrom-Json
        Assert-AreEqual $settings.storageAccount $storagename
    }
    finally
    {
        # Cleanup
        Clean-ResourceGroup $rgname
    }
}

<#
.SYNOPSIS
Test the case if we can't list the storage account key, the command should fail.
#>
function Test-DiagnosticsExtensionCantListSepcifyStorageAccountKey
{
    $rgname = Get-ComputeTestResourceName
    $loc = Get-ComputeVMLocation

    try
    {
        # Setup
        $vm = Create-VirtualMachine -rgname $rgname -loc $loc
        $vmname = $vm.Name

        # If diagnostics extension already exist, remove it
        $extension = Get-AzVMDiagnosticsExtension -ResourceGroupName $rgname -VMName $vmname
        if ($extension) {
            Remove-AzVMDiagnosticsExtension -ResourceGroupName $rgname -VMName $vmname
            $extension = Get-AzVMDiagnosticsExtension -ResourceGroupName $rgname -VMName $vmname
            Assert-Null $extension
        }

        # Get a random storage account name, which we can't list the key
        $storagename = 'notexiststorage'
        Assert-ThrowsContains `
            { Set-AzVMDiagnosticsExtension -ResourceGroupName $rgname -VMName $vmname -DiagnosticsConfigurationPath (Join-Path $ConfigFilesPath "DiagnosticsExtensionConfig.xml") -StorageAccountName $storagename } `
            'Storage account key'
    }
    finally
    {
        # Cleanup
        Clean-ResourceGroup $rgname
    }
}

<#
.SYNOPSIS
Test that we support config file in json format
#>
function Test-DiagnosticsExtensionSupportJsonConfig
{
    $rgname = Get-ComputeTestResourceName
    $loc = Get-ComputeVMLocation

    try
    {
        # Setup
        $vm = Create-VirtualMachine -rgname $rgname -loc $loc
        $vmname = $vm.Name
        $storagename = $vmname + "storage"
        $storagetype = 'Standard_GRS'
        New-AzStorageAccount -ResourceGroupName $rgname -Name $storagename -Location $loc -Type $storagetype

        # If diagnostics extension already exist, remove it
        $extension = Get-AzVMDiagnosticsExtension -ResourceGroupName $rgname -VMName $vmname
        if ($extension) {
            Remove-AzVMDiagnosticsExtension -ResourceGroupName $rgname -VMName $vmname
            $extension = Get-AzVMDiagnosticsExtension -ResourceGroupName $rgname -VMName $vmname
            Assert-Null $extension
        }

        Set-AzVMDiagnosticsExtension -ResourceGroupName $rgname -VMName $vmname -DiagnosticsConfigurationPath (Join-Path $ConfigFilesPath "DiagnosticsExtensionConfig.json") -StorageAccountName $storagename
        $extension = Get-AzVMDiagnosticsExtension -ResourceGroupName $rgname -VMName $vmname

        Assert-NotNull $extension
        $settings = $extension.PublicSettings | ConvertFrom-Json
        Assert-AreEqual $settings.storageAccount $storagename
    }
    finally
    {
        # Cleanup
        Clean-ResourceGroup $rgname
    }
}

<#
.SYNOPSIS
Test the basic usage of the Add/Remove VMSS diagnostics extension command
#>
function Test-VmssDiagnosticsExtension
{
    $rgname = Get-ComputeTestResourceName
    $loc = 'eastus'

    try
    {
        # Common
        New-AzResourceGroup -Name $rgname -Location $loc -Force;

        # Create VMSS

        # SRP
        $stoname = 'sto' + $rgname;
        $stotype = 'Standard_GRS';
        New-AzStorageAccount -ResourceGroupName $rgname -Name $stoname -Location $loc -Type $stotype;
        $stoaccount = Get-AzStorageAccount -ResourceGroupName $rgname -Name $stoname;

        # NRP
        $subnet = New-AzVirtualNetworkSubnetConfig -Name ('subnet' + $rgname) -AddressPrefix "10.0.0.0/24";
        $vnet = New-AzVirtualNetwork -Force -Name ('vnet' + $rgname) -ResourceGroupName $rgname -Location $loc -AddressPrefix "10.0.0.0/16" -Subnet $subnet;
        $vnet = Get-AzVirtualNetwork -Name ('vnet' + $rgname) -ResourceGroupName $rgname;
        $subnetId = $vnet.Subnets[0].Id;

        # New VMSS Parameters
        $vmssName = 'vmss' + $rgname;
        $vmssType = 'Microsoft.Compute/virtualMachineScaleSets';

        $adminUsername = 'Foo12';
        $adminPassword = Get-PasswordForVM;
        $stnd = "Standard";

        $imgRef = Get-DefaultCRPImage -loc $loc;
        $vhdContainer = "https://" + $stoname + ".blob.core.windows.net/" + $vmssName;

        $extname = 'diagextest';
        $diagExtPublisher = 'Microsoft.Azure.Diagnostics';
        $diagExtType = 'IaaSDiagnostics';

        # This storage name will be used in command line directly when set diagnostics extension
        $storagename = 'stoinconfig' + $rgname;
        $storagetype = 'Standard_GRS';
        New-AzStorageAccount -ResourceGroupName $rgname -Name $storagename -Location $loc -Type $storagetype;

        $ipCfg = New-AzVmssIPConfig -Name 'test' -SubnetId $subnetId;
        $vmss = New-AzVmssConfig -Location $loc -SkuCapacity 2 -SkuName 'Standard_A1_v2' -UpgradePolicyMode 'automatic' -NetworkInterfaceConfiguration $netCfg -SecurityType $stnd `
            | Add-AzVmssNetworkInterfaceConfiguration -Name 'test' -Primary $true -IPConfiguration $ipCfg `
            | Set-AzVmssOSProfile -ComputerNamePrefix 'test' -AdminUsername $adminUsername -AdminPassword $adminPassword `
            | Set-AzVmssStorageProfile -Name 'test' -OsDiskCreateOption 'FromImage' -OsDiskCaching 'None' `
            -ImageReferenceOffer $imgRef.Offer -ImageReferenceSku $imgRef.Skus -ImageReferenceVersion $imgRef.Version `
            -ImageReferencePublisher $imgRef.PublisherName -VhdContainer $vhdContainer;

        # Full parameter test
        $version = '1.5';
        $publicSettingTemplate = Join-Path $ConfigFilesPath "DiagnosticsExtensionPublicConfig.json";
        $privateSettingTemplate = Join-Path $ConfigFilesPath "DiagnosticsExtensionPrivateConfig.json";

        $publicSettingFilePath = Join-Path $ConfigFilesPath "publicconfig-$rgname.json";
        $privateSettingFilePath = Join-Path $ConfigFilesPath "privateconfig-$rgname.json";

        New-WADConfigFromTemplate $publicSettingTemplate $publicSettingFilePath $storagename
        New-WADConfigFromTemplate $privateSettingTemplate $privateSettingFilePath $storagename

        $vmss = Add-AzVmssDiagnosticsExtension -VirtualMachineScaleSet $vmss -Name $extname -SettingFilePath $publicSettingFilePath `
            -ProtectedSettingFilePath $privateSettingFilePath -TypeHandlerVersion $version -AutoUpgradeMinorVersion $false -Force;

        $vmssDiagExtensions = $vmss.VirtualMachineProfile.ExtensionProfile.Extensions | Where-Object {$_.Publisher -eq $diagExtPublisher -and $_.Type -eq $diagExtType};
        Assert-AreEqual 1 $vmssDiagExtensions.Count;
        $vmssDiagExtension = $vmssDiagExtensions | Select-Object -first 1;

        Assert-AreEqual $extname $vmssDiagExtension.Name;
        Assert-AreEqual $version $vmssDiagExtension.TypeHandlerVersion;
        Assert-AreEqual $false $vmssDiagExtension.AutoUpgradeMinorVersion;

        # Storage account key should be filled up by the cmdlet.
        $storageAccountKey = $vmssDiagExtension.ProtectedSettings['storageAccountKey'];
        Assert-NotNull $storageAccountKey;
        Assert-AreNotEqual '' $storageAccountKey;

        # Remove without specifying extension name, diagnostic extension is expected to be removed.
        $vmss = Remove-AzVmssDiagnosticsExtension -VirtualMachineScaleSet $vmss;
        $vmssDiagExtensions = $vmss.VirtualMachineProfile.ExtensionProfile.Extensions | Where-Object {$_.Publisher -eq $diagExtPublisher -and $_.Type -eq $diagExtType};

        Assert-Null $vmssDiagExtensions;

        $vmss = $vmss | Add-AzVmssDiagnosticsExtension -Name $extname -SettingFilePath $publicSettingFilePath `
            | New-AzVmss -ResourceGroupName $rgname -Name $vmssName;

        $vmss = Get-AzVmss -ResourceGroupName $rgname -VMScaleSetName $vmssName;

        $vmssDiagExtensions = $vmss.VirtualMachineProfile.ExtensionProfile.Extensions | Where-Object {$_.Publisher -eq $diagExtPublisher -and $_.Type -eq $diagExtType};
        Assert-AreEqual 1 $vmssDiagExtensions.Count;

        $vmssDiagExtension = $vmssDiagExtensions | Select-Object -first 1;
        Assert-AreEqual $extname $vmssDiagExtension.Name;
        
        $settings = $vmssDiagExtension.Settings;
        Assert-AreEqual $storagename $settings.storageAccount.Value;

        $vmss = Remove-AzVmssDiagnosticsExtension -VirtualMachineScaleSet $vmss -Name $extname;
        $vmssDiagExtensions = $vmss.VirtualMachineProfile.ExtensionProfile.Extensions | Where-Object {$_.Publisher -eq $diagExtPublisher -and $_.Type -eq $diagExtType};
        Assert-Null $vmssDiagExtensions;

        Update-AzVmss -ResourceGroupName $rgname -Name $vmssName -VirtualMachineScaleSet $vmss;

        $vmss = Get-AzVmss -ResourceGroupName $rgname -VMScaleSetName $vmssName;
        $vmssDiagExtensions = $vmss.VirtualMachineProfile.ExtensionProfile.Extensions | Where-Object {$_.Publisher -eq $diagExtPublisher -and $_.Type -eq $diagExtType};

        Assert-Null $vmssDiagExtensions;
    }
    finally
    {
        # Cleanup
        Clean-ResourceGroup $rgname

        if (Test-Path $publicSettingFilePath)
        {
            Remove-Item $publicSettingFilePath;
        }

        if (Test-Path $privateSettingFilePath)
        {
            Remove-Item $privateSettingFilePath;
        }
    }
}
