namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Extensions;

    public partial class PolicyProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyPropertiesInternal
    {

        /// <summary>Internal Acessors for Scope</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyPropertiesScope Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyPropertiesInternal.Scope { get => (this._scope = this._scope ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.PolicyPropertiesScope()); set { {_scope = value;} } }

        /// <summary>Backing field for <see cref="Scope" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyPropertiesScope _scope;

        /// <summary>Details of the resource scope</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyPropertiesScope Scope { get => (this._scope = this._scope ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.PolicyPropertiesScope()); }

        /// <summary>Display name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ScopeDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyPropertiesScopeInternal)Scope).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyPropertiesScopeInternal)Scope).DisplayName = value ?? null; }

        /// <summary>Scope id of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ScopeId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyPropertiesScopeInternal)Scope).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyPropertiesScopeInternal)Scope).Id = value ?? null; }

        /// <summary>Type of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ScopeType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyPropertiesScopeInternal)Scope).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyPropertiesScopeInternal)Scope).Type = value ?? null; }

        /// <summary>Creates an new <see cref="PolicyProperties" /> instance.</summary>
        public PolicyProperties()
        {

        }
    }
    public partial interface IPolicyProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.IJsonSerializable
    {
        /// <summary>Display name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of the resource",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string ScopeDisplayName { get; set; }
        /// <summary>Scope id of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Scope id of the resource",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string ScopeId { get; set; }
        /// <summary>Type of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the resource",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string ScopeType { get; set; }

    }
    internal partial interface IPolicyPropertiesInternal

    {
        /// <summary>Details of the resource scope</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyPropertiesScope Scope { get; set; }
        /// <summary>Display name of the resource</summary>
        string ScopeDisplayName { get; set; }
        /// <summary>Scope id of the resource</summary>
        string ScopeId { get; set; }
        /// <summary>Type of the resource</summary>
        string ScopeType { get; set; }

    }
}