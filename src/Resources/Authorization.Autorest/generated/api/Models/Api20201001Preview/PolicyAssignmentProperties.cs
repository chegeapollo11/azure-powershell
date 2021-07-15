namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Extensions;

    public partial class PolicyAssignmentProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesInternal
    {

        /// <summary>The name of the principal made changes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string LastModifiedByDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesPolicyInternal)Policy).LastModifiedByDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesPolicyInternal)Policy).LastModifiedByDisplayName = value ?? null; }

        /// <summary>Email of principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string LastModifiedByEmail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesPolicyInternal)Policy).LastModifiedByEmail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesPolicyInternal)Policy).LastModifiedByEmail = value ?? null; }

        /// <summary>The id of the principal made changes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string LastModifiedById { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesPolicyInternal)Policy).LastModifiedById; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesPolicyInternal)Policy).LastModifiedById = value ?? null; }

        /// <summary>Type of principal such as user , group etc</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string LastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesPolicyInternal)Policy).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesPolicyInternal)Policy).LastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Policy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesPolicy Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesInternal.Policy { get => (this._policy = this._policy ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.PolicyAssignmentPropertiesPolicy()); set { {_policy = value;} } }

        /// <summary>Internal Acessors for PolicyLastModifiedBy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPrincipal Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesInternal.PolicyLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesPolicyInternal)Policy).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesPolicyInternal)Policy).LastModifiedBy = value; }

        /// <summary>Internal Acessors for RoleDefinition</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesRoleDefinition Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesInternal.RoleDefinition { get => (this._roleDefinition = this._roleDefinition ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.PolicyAssignmentPropertiesRoleDefinition()); set { {_roleDefinition = value;} } }

        /// <summary>Internal Acessors for Scope</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesScope Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesInternal.Scope { get => (this._scope = this._scope ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.PolicyAssignmentPropertiesScope()); set { {_scope = value;} } }

        /// <summary>Backing field for <see cref="Policy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesPolicy _policy;

        /// <summary>Details of the policy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesPolicy Policy { get => (this._policy = this._policy ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.PolicyAssignmentPropertiesPolicy()); set => this._policy = value; }

        /// <summary>Id of the policy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string PolicyId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesPolicyInternal)Policy).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesPolicyInternal)Policy).Id = value ?? null; }

        /// <summary>The last modified date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public global::System.DateTime? PolicyLastModifiedDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesPolicyInternal)Policy).LastModifiedDateTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesPolicyInternal)Policy).LastModifiedDateTime = value ?? default(global::System.DateTime); }

        /// <summary>Backing field for <see cref="RoleDefinition" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesRoleDefinition _roleDefinition;

        /// <summary>Details of role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesRoleDefinition RoleDefinition { get => (this._roleDefinition = this._roleDefinition ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.PolicyAssignmentPropertiesRoleDefinition()); set => this._roleDefinition = value; }

        /// <summary>Display name of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string RoleDefinitionDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesRoleDefinitionInternal)RoleDefinition).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesRoleDefinitionInternal)RoleDefinition).DisplayName = value ?? null; }

        /// <summary>Id of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string RoleDefinitionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesRoleDefinitionInternal)RoleDefinition).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesRoleDefinitionInternal)RoleDefinition).Id = value ?? null; }

        /// <summary>Type of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string RoleDefinitionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesRoleDefinitionInternal)RoleDefinition).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesRoleDefinitionInternal)RoleDefinition).Type = value ?? null; }

        /// <summary>Backing field for <see cref="Scope" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesScope _scope;

        /// <summary>Details of the resource scope</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesScope Scope { get => (this._scope = this._scope ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.PolicyAssignmentPropertiesScope()); set => this._scope = value; }

        /// <summary>Display name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ScopeDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesScopeInternal)Scope).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesScopeInternal)Scope).DisplayName = value ?? null; }

        /// <summary>Scope id of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ScopeId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesScopeInternal)Scope).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesScopeInternal)Scope).Id = value ?? null; }

        /// <summary>Type of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ScopeType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesScopeInternal)Scope).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesScopeInternal)Scope).Type = value ?? null; }

        /// <summary>Creates an new <see cref="PolicyAssignmentProperties" /> instance.</summary>
        public PolicyAssignmentProperties()
        {

        }
    }
    public partial interface IPolicyAssignmentProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.IJsonSerializable
    {
        /// <summary>The name of the principal made changes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the principal made changes",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string LastModifiedByDisplayName { get; set; }
        /// <summary>Email of principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Email of principal",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        string LastModifiedByEmail { get; set; }
        /// <summary>The id of the principal made changes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The id of the principal made changes",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string LastModifiedById { get; set; }
        /// <summary>Type of principal such as user , group etc</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of principal such as user , group etc",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string LastModifiedByType { get; set; }
        /// <summary>Id of the policy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the policy",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string PolicyId { get; set; }
        /// <summary>The last modified date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The last modified date time.",
        SerializedName = @"lastModifiedDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? PolicyLastModifiedDateTime { get; set; }
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
    internal partial interface IPolicyAssignmentPropertiesInternal

    {
        /// <summary>The name of the principal made changes</summary>
        string LastModifiedByDisplayName { get; set; }
        /// <summary>Email of principal</summary>
        string LastModifiedByEmail { get; set; }
        /// <summary>The id of the principal made changes</summary>
        string LastModifiedById { get; set; }
        /// <summary>Type of principal such as user , group etc</summary>
        string LastModifiedByType { get; set; }
        /// <summary>Details of the policy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesPolicy Policy { get; set; }
        /// <summary>Id of the policy</summary>
        string PolicyId { get; set; }
        /// <summary>The name of the entity last modified it</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPrincipal PolicyLastModifiedBy { get; set; }
        /// <summary>The last modified date time.</summary>
        global::System.DateTime? PolicyLastModifiedDateTime { get; set; }
        /// <summary>Details of role definition</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesRoleDefinition RoleDefinition { get; set; }
        /// <summary>Display name of the role definition</summary>
        string RoleDefinitionDisplayName { get; set; }
        /// <summary>Id of the role definition</summary>
        string RoleDefinitionId { get; set; }
        /// <summary>Type of the role definition</summary>
        string RoleDefinitionType { get; set; }
        /// <summary>Details of the resource scope</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesScope Scope { get; set; }
        /// <summary>Display name of the resource</summary>
        string ScopeDisplayName { get; set; }
        /// <summary>Scope id of the resource</summary>
        string ScopeId { get; set; }
        /// <summary>Type of the resource</summary>
        string ScopeType { get; set; }

    }
}