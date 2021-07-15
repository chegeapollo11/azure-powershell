namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Extensions;

    /// <summary>The role management policy rule.</summary>
    public partial class RoleManagementPolicyRule :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The id of the rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for Target</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleTarget Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal.Target { get => (this._target = this._target ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleManagementPolicyRuleTarget()); set { {_target = value;} } }

        /// <summary>Backing field for <see cref="RuleType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RoleManagementPolicyRuleType _ruleType;

        /// <summary>The type of rule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RoleManagementPolicyRuleType RuleType { get => this._ruleType; set => this._ruleType = value; }

        /// <summary>Backing field for <see cref="Target" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleTarget _target;

        /// <summary>The target of the current rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleTarget Target { get => (this._target = this._target ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleManagementPolicyRuleTarget()); set => this._target = value; }

        /// <summary>The caller of the setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string TargetCaller { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleTargetInternal)Target).Caller; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleTargetInternal)Target).Caller = value ?? null; }

        /// <summary>The list of enforced settings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string[] TargetEnforcedSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleTargetInternal)Target).EnforcedSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleTargetInternal)Target).EnforcedSetting = value ?? null /* arrayOf */; }

        /// <summary>The list of inheritable settings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string[] TargetInheritableSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleTargetInternal)Target).InheritableSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleTargetInternal)Target).InheritableSetting = value ?? null /* arrayOf */; }

        /// <summary>The assignment level to which it is applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string TargetLevel { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleTargetInternal)Target).Level; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleTargetInternal)Target).Level = value ?? null; }

        /// <summary>The list of target objects.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string[] TargetObject { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleTargetInternal)Target).TargetObject; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleTargetInternal)Target).TargetObject = value ?? null /* arrayOf */; }

        /// <summary>The type of operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string[] TargetOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleTargetInternal)Target).Operation; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleTargetInternal)Target).Operation = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="RoleManagementPolicyRule" /> instance.</summary>
        public RoleManagementPolicyRule()
        {

        }
    }
    /// The role management policy rule.
    public partial interface IRoleManagementPolicyRule :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.IJsonSerializable
    {
        /// <summary>The id of the rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The id of the rule.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The type of rule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The type of rule",
        SerializedName = @"ruleType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RoleManagementPolicyRuleType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RoleManagementPolicyRuleType RuleType { get; set; }
        /// <summary>The caller of the setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The caller of the setting.",
        SerializedName = @"caller",
        PossibleTypes = new [] { typeof(string) })]
        string TargetCaller { get; set; }
        /// <summary>The list of enforced settings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of enforced settings.",
        SerializedName = @"enforcedSettings",
        PossibleTypes = new [] { typeof(string) })]
        string[] TargetEnforcedSetting { get; set; }
        /// <summary>The list of inheritable settings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of inheritable settings.",
        SerializedName = @"inheritableSettings",
        PossibleTypes = new [] { typeof(string) })]
        string[] TargetInheritableSetting { get; set; }
        /// <summary>The assignment level to which it is applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The assignment level to which it is applied.",
        SerializedName = @"level",
        PossibleTypes = new [] { typeof(string) })]
        string TargetLevel { get; set; }
        /// <summary>The list of target objects.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of target objects.",
        SerializedName = @"targetObjects",
        PossibleTypes = new [] { typeof(string) })]
        string[] TargetObject { get; set; }
        /// <summary>The type of operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of operation.",
        SerializedName = @"operations",
        PossibleTypes = new [] { typeof(string) })]
        string[] TargetOperation { get; set; }

    }
    /// The role management policy rule.
    internal partial interface IRoleManagementPolicyRuleInternal

    {
        /// <summary>The id of the rule.</summary>
        string Id { get; set; }
        /// <summary>The type of rule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RoleManagementPolicyRuleType RuleType { get; set; }
        /// <summary>The target of the current rule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleTarget Target { get; set; }
        /// <summary>The caller of the setting.</summary>
        string TargetCaller { get; set; }
        /// <summary>The list of enforced settings.</summary>
        string[] TargetEnforcedSetting { get; set; }
        /// <summary>The list of inheritable settings.</summary>
        string[] TargetInheritableSetting { get; set; }
        /// <summary>The assignment level to which it is applied.</summary>
        string TargetLevel { get; set; }
        /// <summary>The list of target objects.</summary>
        string[] TargetObject { get; set; }
        /// <summary>The type of operation.</summary>
        string[] TargetOperation { get; set; }

    }
}