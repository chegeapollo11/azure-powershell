namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Extensions;

    /// <summary>The role management policy rule.</summary>
    public partial class RoleManagementPolicyApprovalRule :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyApprovalRule,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyApprovalRuleInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule __roleManagementPolicyRule = new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleManagementPolicyRule();

        /// <summary>The id of the rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)__roleManagementPolicyRule).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)__roleManagementPolicyRule).Id = value ?? null; }

        /// <summary>Internal Acessors for Setting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IApprovalSettings Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyApprovalRuleInternal.Setting { get => (this._setting = this._setting ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.ApprovalSettings()); set { {_setting = value;} } }

        /// <summary>The type of rule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RoleManagementPolicyRuleType RuleType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)__roleManagementPolicyRule).RuleType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)__roleManagementPolicyRule).RuleType = value ; }

        /// <summary>Backing field for <see cref="Setting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IApprovalSettings _setting;

        /// <summary>The approval setting</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IApprovalSettings Setting { get => (this._setting = this._setting ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.ApprovalSettings()); set => this._setting = value; }

        /// <summary>The type of rule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.ApprovalMode? SettingApprovalMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IApprovalSettingsInternal)Setting).ApprovalMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IApprovalSettingsInternal)Setting).ApprovalMode = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.ApprovalMode)""); }

        /// <summary>The approval stages of the request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IApprovalStage[] SettingApprovalStage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IApprovalSettingsInternal)Setting).ApprovalStage; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IApprovalSettingsInternal)Setting).ApprovalStage = value ?? null /* arrayOf */; }

        /// <summary>Determine whether approval is required or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public bool? SettingIsApprovalRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IApprovalSettingsInternal)Setting).IsApprovalRequired; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IApprovalSettingsInternal)Setting).IsApprovalRequired = value ?? default(bool); }

        /// <summary>Determine whether approval is required for assignment extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public bool? SettingIsApprovalRequiredForExtension { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IApprovalSettingsInternal)Setting).IsApprovalRequiredForExtension; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IApprovalSettingsInternal)Setting).IsApprovalRequiredForExtension = value ?? default(bool); }

        /// <summary>Determine whether requestor justification required.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public bool? SettingIsRequestorJustificationRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IApprovalSettingsInternal)Setting).IsRequestorJustificationRequired; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IApprovalSettingsInternal)Setting).IsRequestorJustificationRequired = value ?? default(bool); }

        /// <summary>The target of the current rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleTarget Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)__roleManagementPolicyRule).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)__roleManagementPolicyRule).Target = value ?? null /* model class */; }

        /// <summary>The caller of the setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inherited)]
        public string TargetCaller { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)__roleManagementPolicyRule).TargetCaller; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)__roleManagementPolicyRule).TargetCaller = value ?? null; }

        /// <summary>The list of enforced settings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inherited)]
        public string[] TargetEnforcedSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)__roleManagementPolicyRule).TargetEnforcedSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)__roleManagementPolicyRule).TargetEnforcedSetting = value ?? null /* arrayOf */; }

        /// <summary>The list of inheritable settings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inherited)]
        public string[] TargetInheritableSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)__roleManagementPolicyRule).TargetInheritableSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)__roleManagementPolicyRule).TargetInheritableSetting = value ?? null /* arrayOf */; }

        /// <summary>The assignment level to which it is applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inherited)]
        public string TargetLevel { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)__roleManagementPolicyRule).TargetLevel; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)__roleManagementPolicyRule).TargetLevel = value ?? null; }

        /// <summary>The list of target objects.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inherited)]
        public string[] TargetObject { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)__roleManagementPolicyRule).TargetObject; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)__roleManagementPolicyRule).TargetObject = value ?? null /* arrayOf */; }

        /// <summary>The type of operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inherited)]
        public string[] TargetOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)__roleManagementPolicyRule).TargetOperation; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)__roleManagementPolicyRule).TargetOperation = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="RoleManagementPolicyApprovalRule" /> instance.</summary>
        public RoleManagementPolicyApprovalRule()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__roleManagementPolicyRule), __roleManagementPolicyRule);
            await eventListener.AssertObjectIsValid(nameof(__roleManagementPolicyRule), __roleManagementPolicyRule);
        }
    }
    /// The role management policy rule.
    public partial interface IRoleManagementPolicyApprovalRule :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule
    {
        /// <summary>The type of rule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of rule",
        SerializedName = @"approvalMode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.ApprovalMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.ApprovalMode? SettingApprovalMode { get; set; }
        /// <summary>The approval stages of the request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The approval stages of the request.",
        SerializedName = @"approvalStages",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IApprovalStage) })]
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IApprovalStage[] SettingApprovalStage { get; set; }
        /// <summary>Determine whether approval is required or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Determine whether approval is required or not.",
        SerializedName = @"isApprovalRequired",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SettingIsApprovalRequired { get; set; }
        /// <summary>Determine whether approval is required for assignment extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Determine whether approval is required for assignment extension.",
        SerializedName = @"isApprovalRequiredForExtension",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SettingIsApprovalRequiredForExtension { get; set; }
        /// <summary>Determine whether requestor justification required.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Determine whether requestor justification required.",
        SerializedName = @"isRequestorJustificationRequired",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SettingIsRequestorJustificationRequired { get; set; }

    }
    /// The role management policy rule.
    internal partial interface IRoleManagementPolicyApprovalRuleInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal
    {
        /// <summary>The approval setting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IApprovalSettings Setting { get; set; }
        /// <summary>The type of rule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.ApprovalMode? SettingApprovalMode { get; set; }
        /// <summary>The approval stages of the request.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IApprovalStage[] SettingApprovalStage { get; set; }
        /// <summary>Determine whether approval is required or not.</summary>
        bool? SettingIsApprovalRequired { get; set; }
        /// <summary>Determine whether approval is required for assignment extension.</summary>
        bool? SettingIsApprovalRequiredForExtension { get; set; }
        /// <summary>Determine whether requestor justification required.</summary>
        bool? SettingIsRequestorJustificationRequired { get; set; }

    }
}