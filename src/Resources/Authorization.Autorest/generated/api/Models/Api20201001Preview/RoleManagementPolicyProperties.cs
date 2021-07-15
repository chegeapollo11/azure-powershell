namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Extensions;

    /// <summary>Role management policy properties with scope.</summary>
    public partial class RoleManagementPolicyProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>The role management policy description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The role management policy display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="EffectiveRule" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule[] _effectiveRule;

        /// <summary>The readonly computed rule applied to the policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule[] EffectiveRule { get => this._effectiveRule; }

        /// <summary>Backing field for <see cref="IsOrganizationDefault" /> property.</summary>
        private bool? _isOrganizationDefault;

        /// <summary>The role management policy is default policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public bool? IsOrganizationDefault { get => this._isOrganizationDefault; set => this._isOrganizationDefault = value; }

        /// <summary>Backing field for <see cref="LastModifiedBy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPrincipal _lastModifiedBy;

        /// <summary>The name of the entity last modified it</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPrincipal LastModifiedBy { get => (this._lastModifiedBy = this._lastModifiedBy ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.Principal()); }

        /// <summary>The name of the principal made changes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string LastModifiedByDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPrincipalInternal)LastModifiedBy).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPrincipalInternal)LastModifiedBy).DisplayName = value ?? null; }

        /// <summary>Email of principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string LastModifiedByEmail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPrincipalInternal)LastModifiedBy).Email; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPrincipalInternal)LastModifiedBy).Email = value ?? null; }

        /// <summary>The id of the principal made changes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string LastModifiedById { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPrincipalInternal)LastModifiedBy).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPrincipalInternal)LastModifiedBy).Id = value ?? null; }

        /// <summary>Type of principal such as user , group etc</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string LastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPrincipalInternal)LastModifiedBy).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPrincipalInternal)LastModifiedBy).Type = value ?? null; }

        /// <summary>Backing field for <see cref="LastModifiedDateTime" /> property.</summary>
        private global::System.DateTime? _lastModifiedDateTime;

        /// <summary>The last modified date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public global::System.DateTime? LastModifiedDateTime { get => this._lastModifiedDateTime; }

        /// <summary>Internal Acessors for EffectiveRule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule[] Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal.EffectiveRule { get => this._effectiveRule; set { {_effectiveRule = value;} } }

        /// <summary>Internal Acessors for LastModifiedBy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPrincipal Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal.LastModifiedBy { get => (this._lastModifiedBy = this._lastModifiedBy ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.Principal()); set { {_lastModifiedBy = value;} } }

        /// <summary>Internal Acessors for LastModifiedDateTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal.LastModifiedDateTime { get => this._lastModifiedDateTime; set { {_lastModifiedDateTime = value;} } }

        /// <summary>Internal Acessors for PolicyProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyProperties Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal.PolicyProperty { get => (this._policyProperty = this._policyProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.PolicyProperties()); set { {_policyProperty = value;} } }

        /// <summary>Internal Acessors for PolicyPropertyScope</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyPropertiesScope Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal.PolicyPropertyScope { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyPropertiesInternal)PolicyProperty).Scope; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyPropertiesInternal)PolicyProperty).Scope = value; }

        /// <summary>Internal Acessors for Scope</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal.Scope { get => this._scope; set { {_scope = value;} } }

        /// <summary>Backing field for <see cref="PolicyProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyProperties _policyProperty;

        /// <summary>Additional properties of scope</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyProperties PolicyProperty { get => (this._policyProperty = this._policyProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.PolicyProperties()); }

        /// <summary>Backing field for <see cref="Rule" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule[] _rule;

        /// <summary>The rule applied to the policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule[] Rule { get => this._rule; set => this._rule = value; }

        /// <summary>Backing field for <see cref="Scope" /> property.</summary>
        private string _scope;

        /// <summary>The role management policy scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string Scope { get => this._scope; }

        /// <summary>Display name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ScopeDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyPropertiesInternal)PolicyProperty).ScopeDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyPropertiesInternal)PolicyProperty).ScopeDisplayName = value ?? null; }

        /// <summary>Scope id of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ScopeId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyPropertiesInternal)PolicyProperty).ScopeId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyPropertiesInternal)PolicyProperty).ScopeId = value ?? null; }

        /// <summary>Type of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ScopeType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyPropertiesInternal)PolicyProperty).ScopeType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyPropertiesInternal)PolicyProperty).ScopeType = value ?? null; }

        /// <summary>Creates an new <see cref="RoleManagementPolicyProperties" /> instance.</summary>
        public RoleManagementPolicyProperties()
        {

        }
    }
    /// Role management policy properties with scope.
    public partial interface IRoleManagementPolicyProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.IJsonSerializable
    {
        /// <summary>The role management policy description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The role management policy description.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The role management policy display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The role management policy display name.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The readonly computed rule applied to the policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The readonly computed rule applied to the policy.",
        SerializedName = @"effectiveRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule) })]
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule[] EffectiveRule { get;  }
        /// <summary>The role management policy is default policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The role management policy is default policy.",
        SerializedName = @"isOrganizationDefault",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsOrganizationDefault { get; set; }
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
        /// <summary>The last modified date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last modified date time.",
        SerializedName = @"lastModifiedDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastModifiedDateTime { get;  }
        /// <summary>The rule applied to the policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The rule applied to the policy.",
        SerializedName = @"rules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule) })]
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule[] Rule { get; set; }
        /// <summary>The role management policy scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The role management policy scope.",
        SerializedName = @"scope",
        PossibleTypes = new [] { typeof(string) })]
        string Scope { get;  }
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
    /// Role management policy properties with scope.
    internal partial interface IRoleManagementPolicyPropertiesInternal

    {
        /// <summary>The role management policy description.</summary>
        string Description { get; set; }
        /// <summary>The role management policy display name.</summary>
        string DisplayName { get; set; }
        /// <summary>The readonly computed rule applied to the policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule[] EffectiveRule { get; set; }
        /// <summary>The role management policy is default policy.</summary>
        bool? IsOrganizationDefault { get; set; }
        /// <summary>The name of the entity last modified it</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPrincipal LastModifiedBy { get; set; }
        /// <summary>The name of the principal made changes</summary>
        string LastModifiedByDisplayName { get; set; }
        /// <summary>Email of principal</summary>
        string LastModifiedByEmail { get; set; }
        /// <summary>The id of the principal made changes</summary>
        string LastModifiedById { get; set; }
        /// <summary>Type of principal such as user , group etc</summary>
        string LastModifiedByType { get; set; }
        /// <summary>The last modified date time.</summary>
        global::System.DateTime? LastModifiedDateTime { get; set; }
        /// <summary>Additional properties of scope</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyProperties PolicyProperty { get; set; }
        /// <summary>Details of the resource scope</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyPropertiesScope PolicyPropertyScope { get; set; }
        /// <summary>The rule applied to the policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule[] Rule { get; set; }
        /// <summary>The role management policy scope.</summary>
        string Scope { get; set; }
        /// <summary>Display name of the resource</summary>
        string ScopeDisplayName { get; set; }
        /// <summary>Scope id of the resource</summary>
        string ScopeId { get; set; }
        /// <summary>Type of the resource</summary>
        string ScopeType { get; set; }

    }
}