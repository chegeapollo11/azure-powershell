// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Extensions;

    /// <summary>Azure API management (APIM) configuration linked to the app.</summary>
    public partial class ApiManagementConfig :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IApiManagementConfig,
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IApiManagementConfigInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>APIM-Api Identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Creates an new <see cref="ApiManagementConfig" /> instance.</summary>
        public ApiManagementConfig()
        {

        }
    }
    /// Azure API management (APIM) configuration linked to the app.
    public partial interface IApiManagementConfig :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IJsonSerializable
    {
        /// <summary>APIM-Api Identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"APIM-Api Identifier.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

    }
    /// Azure API management (APIM) configuration linked to the app.
    internal partial interface IApiManagementConfigInternal

    {
        /// <summary>APIM-Api Identifier.</summary>
        string Id { get; set; }

    }
}