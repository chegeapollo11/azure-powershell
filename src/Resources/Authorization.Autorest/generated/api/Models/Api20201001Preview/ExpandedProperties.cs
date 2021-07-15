namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Extensions;

    public partial class ExpandedProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal
    {

        /// <summary>Internal Acessors for Principal</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesPrincipal Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal.Principal { get => (this._principal = this._principal ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.ExpandedPropertiesPrincipal()); set { {_principal = value;} } }

        /// <summary>Internal Acessors for RoleDefinition</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesRoleDefinition Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal.RoleDefinition { get => (this._roleDefinition = this._roleDefinition ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.ExpandedPropertiesRoleDefinition()); set { {_roleDefinition = value;} } }

        /// <summary>Internal Acessors for Scope</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesScope Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal.Scope { get => (this._scope = this._scope ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.ExpandedPropertiesScope()); set { {_scope = value;} } }

        /// <summary>Backing field for <see cref="Principal" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesPrincipal _principal;

        /// <summary>Details of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesPrincipal Principal { get => (this._principal = this._principal ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.ExpandedPropertiesPrincipal()); set => this._principal = value; }

        /// <summary>Display name of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string PrincipalDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesPrincipalInternal)Principal).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesPrincipalInternal)Principal).DisplayName = value ?? null; }

        /// <summary>Email id of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string PrincipalEmail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesPrincipalInternal)Principal).Email; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesPrincipalInternal)Principal).Email = value ?? null; }

        /// <summary>Id of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string PrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesPrincipalInternal)Principal).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesPrincipalInternal)Principal).Id = value ?? null; }

        /// <summary>Type of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string PrincipalType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesPrincipalInternal)Principal).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesPrincipalInternal)Principal).Type = value ?? null; }

        /// <summary>Backing field for <see cref="RoleDefinition" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesRoleDefinition _roleDefinition;

        /// <summary>Details of role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesRoleDefinition RoleDefinition { get => (this._roleDefinition = this._roleDefinition ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.ExpandedPropertiesRoleDefinition()); set => this._roleDefinition = value; }

        /// <summary>Display name of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string RoleDefinitionDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesRoleDefinitionInternal)RoleDefinition).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesRoleDefinitionInternal)RoleDefinition).DisplayName = value ?? null; }

        /// <summary>Id of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string RoleDefinitionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesRoleDefinitionInternal)RoleDefinition).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesRoleDefinitionInternal)RoleDefinition).Id = value ?? null; }

        /// <summary>Type of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string RoleDefinitionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesRoleDefinitionInternal)RoleDefinition).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesRoleDefinitionInternal)RoleDefinition).Type = value ?? null; }

        /// <summary>Backing field for <see cref="Scope" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesScope _scope;

        /// <summary>Details of the resource scope</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesScope Scope { get => (this._scope = this._scope ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.ExpandedPropertiesScope()); set => this._scope = value; }

        /// <summary>Display name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ScopeDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesScopeInternal)Scope).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesScopeInternal)Scope).DisplayName = value ?? null; }

        /// <summary>Scope id of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ScopeId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesScopeInternal)Scope).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesScopeInternal)Scope).Id = value ?? null; }

        /// <summary>Type of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ScopeType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesScopeInternal)Scope).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesScopeInternal)Scope).Type = value ?? null; }

        /// <summary>Creates an new <see cref="ExpandedProperties" /> instance.</summary>
        public ExpandedProperties()
        {

        }
    }
    public partial interface IExpandedProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.IJsonSerializable
    {
        /// <summary>Display name of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of the principal",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalDisplayName { get; set; }
        /// <summary>Email id of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Email id of the principal",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalEmail { get; set; }
        /// <summary>Id of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the principal",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get; set; }
        /// <summary>Type of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the principal",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalType { get; set; }
        /// <summary>Display name of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of the role definition",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string RoleDefinitionDisplayName { get; set; }
        /// <summary>Id of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the role definition",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string RoleDefinitionId { get; set; }
        /// <summary>Type of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the role definition",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string RoleDefinitionType { get; set; }
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
    internal partial interface IExpandedPropertiesInternal

    {
        /// <summary>Details of the principal</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesPrincipal Principal { get; set; }
        /// <summary>Display name of the principal</summary>
        string PrincipalDisplayName { get; set; }
        /// <summary>Email id of the principal</summary>
        string PrincipalEmail { get; set; }
        /// <summary>Id of the principal</summary>
        string PrincipalId { get; set; }
        /// <summary>Type of the principal</summary>
        string PrincipalType { get; set; }
        /// <summary>Details of role definition</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesRoleDefinition RoleDefinition { get; set; }
        /// <summary>Display name of the role definition</summary>
        string RoleDefinitionDisplayName { get; set; }
        /// <summary>Id of the role definition</summary>
        string RoleDefinitionId { get; set; }
        /// <summary>Type of the role definition</summary>
        string RoleDefinitionType { get; set; }
        /// <summary>Details of the resource scope</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesScope Scope { get; set; }
        /// <summary>Display name of the resource</summary>
        string ScopeDisplayName { get; set; }
        /// <summary>Scope id of the resource</summary>
        string ScopeId { get; set; }
        /// <summary>Type of the resource</summary>
        string ScopeType { get; set; }

    }
}