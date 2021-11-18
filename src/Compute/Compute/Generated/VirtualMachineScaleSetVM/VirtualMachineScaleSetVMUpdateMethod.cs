//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Microsoft.Azure.Commands.Compute.Common;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsData.Update, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VmssVM", DefaultParameterSetName = "DefaultParameter", SupportsShouldProcess = true)]
    [OutputType(typeof(PSVirtualMachineScaleSetVM))]
    public partial class UpdateAzureRmVmssVM : ComputeAutomationBaseCmdlet
    {
        protected const string DefaultParameterSetName = "DefaultParameter",
                               ResourceIdParameterSet = "ResourceIdParameter",
                               ObjectParameterSet = "ObjectParameter";
        private InstanceViewTypes UserDataExpand = InstanceViewTypes.UserData;

        public override void ExecuteCmdlet()
        {

            base.ExecuteCmdlet();
            ExecuteClientAction(() =>
            {
                if (ShouldProcess(this.VMScaleSetName, VerbsData.Update))
                {
                    string resourceGroupName;
                    string vmScaleSetName;
                    string instanceId;
                    switch (this.ParameterSetName)
                    {
                        case ResourceIdParameterSet:
                            resourceGroupName = GetResourceGroupName(this.ResourceId);
                            vmScaleSetName = GetResourceName(this.ResourceId, "Microsoft.Compute/virtualMachineScaleSets", "virtualMachines");
                            instanceId = GetInstanceId(this.ResourceId, "Microsoft.Compute/virtualMachineScaleSets", "virtualMachines");
                            break;
                        case ObjectParameterSet:
                            resourceGroupName = GetResourceGroupName(this.VirtualMachineScaleSetVM.Id);
                            vmScaleSetName = GetResourceName(this.VirtualMachineScaleSetVM.Id, "Microsoft.Compute/virtualMachineScaleSets", "virtualMachines");
                            instanceId = GetInstanceId(this.VirtualMachineScaleSetVM.Id, "Microsoft.Compute/virtualMachineScaleSets", "virtualMachines");
                            break;
                        default:
                            resourceGroupName = this.ResourceGroupName;
                            vmScaleSetName = this.VMScaleSetName;
                            instanceId = this.InstanceId;
                            break;
                    }
                    VirtualMachineScaleSetVM parameters = new VirtualMachineScaleSetVM();
                    ComputeAutomationAutoMapperProfile.Mapper.Map<PSVirtualMachineScaleSetVM, VirtualMachineScaleSetVM>(this.VirtualMachineScaleSetVM, parameters);

                    if (this.IsParameterBound(c => c.UserData))
                    {
                        parameters = VirtualMachineScaleSetVMsClient.Get(resourceGroupName, vmScaleSetName, instanceId, UserDataExpand);
                    }
                    else if (this.ParameterSetName != ObjectParameterSet)
                    {
                        parameters = VirtualMachineScaleSetVMsClient.Get(resourceGroupName, vmScaleSetName, instanceId);
                    }

                    if (this.DataDisk != null)
                    {
                        if (parameters.StorageProfile == null)
                        {
                            parameters.StorageProfile = new StorageProfile();
                        }

                        if (parameters.StorageProfile.DataDisks == null)
                        {
                            parameters.StorageProfile.DataDisks = new List<DataDisk>();
                        }

                        foreach (var d in this.DataDisk)
                        {
                            parameters.StorageProfile.DataDisks.Add(d);
                        }
                    }

                    if (this.IsParameterBound(c => c.ProtectFromScaleIn))
                    {
                        if (parameters.ProtectionPolicy == null)
                        {
                            parameters.ProtectionPolicy = new VirtualMachineScaleSetVMProtectionPolicy();
                        }

                        parameters.ProtectionPolicy.ProtectFromScaleIn = this.ProtectFromScaleIn;
                    }

                    if (this.IsParameterBound(c => c.ProtectFromScaleSetAction))
                    {
                        if (parameters.ProtectionPolicy == null)
                        {
                            parameters.ProtectionPolicy = new VirtualMachineScaleSetVMProtectionPolicy();
                        }

                        parameters.ProtectionPolicy.ProtectFromScaleSetActions = this.ProtectFromScaleSetAction;
                    }

                    if (this.IsParameterBound(c => c.UserData))
                    {
                        if (!ValidateBase64EncodedString.ValidateStringIsBase64Encoded(this.UserData))
                        {
                            this.UserData = ValidateBase64EncodedString.EncodeStringToBase64(this.UserData);
                            this.WriteInformation(ValidateBase64EncodedString.UserDataEncodeNotification + this.UserData, new string[] { "PSHOST" });
                        }
                        parameters.UserData = this.UserData;
                    }

                    var result = VirtualMachineScaleSetVMsClient.Update(resourceGroupName, vmScaleSetName, instanceId, parameters);
                    var psObject = new PSVirtualMachineScaleSetVM();
                    ComputeAutomationAutoMapperProfile.Mapper.Map<VirtualMachineScaleSetVM, PSVirtualMachineScaleSetVM>(result, psObject);
                    WriteObject(psObject);
                }
            });
        }

        [Parameter(
            ParameterSetName = DefaultParameterSetName,
            Position = 0,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [ResourceGroupCompleter]
        public string ResourceGroupName { get; set; }

        [Parameter(
            ParameterSetName = DefaultParameterSetName,
            Position = 1,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [ResourceNameCompleter("Microsoft.Compute/virtualMachineScaleSets", "ResourceGroupName")]
        [Alias("Name")]
        public string VMScaleSetName { get; set; }

        [Parameter(
            ParameterSetName = DefaultParameterSetName,
            Position = 2,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public string InstanceId { get; set; }

        [Parameter(
            ValueFromPipeline = true)]
        public Compute.Models.PSVirtualMachineDataDisk[] DataDisk { get; set; }

        [Parameter()]
        public bool ProtectFromScaleIn { get; set; }

        [Parameter()]
        public bool ProtectFromScaleSetAction { get; set; }

        [Parameter(
            ParameterSetName = ResourceIdParameterSet,
            Position = 0,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public string ResourceId { get; set; }

        [Parameter(
            ParameterSetName = ObjectParameterSet,
            Position = 0,
            Mandatory = true,
            ValueFromPipeline = true)]
        [ValidateNotNullOrEmpty]
        public PSVirtualMachineScaleSetVM VirtualMachineScaleSetVM { get; set; }

        [Parameter(Mandatory = false, 
            HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }
        
        [Parameter(
            Mandatory = false,
            ParameterSetName = "DefaultParameter",
            HelpMessage = "UserData for the Vmss Vm, which will be Base64 encoded. Customer should not pass any secrets in here.",
            ValueFromPipeline = true)]
        [Parameter(
            Mandatory = false,
            ParameterSetName = "ResourceIdParameter",
            HelpMessage = "UserData for the Vmss Vm, which will be Base64 encoded. Customer should not pass any secrets in here.",
            ValueFromPipeline = true)]
        public string UserData { get; set; }
    }
}
