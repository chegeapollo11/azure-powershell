namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Extensions;

    /// <summary>The role management policy rule.</summary>
    public partial class RoleManagementPolicyAuthenticationContextRule :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAuthenticationContextRule,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAuthenticationContextRuleInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule __roleManagementPolicyRule = new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleManagementPolicyRule();

        /// <summary>Backing field for <see cref="ClaimValue" /> property.</summary>
        private string _claimValue;

        /// <summary>The claim value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string ClaimValue { get => this._claimValue; set => this._claimValue = value; }

        /// <summary>The id of the rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)__roleManagementPolicyRule).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)__roleManagementPolicyRule).Id = value ?? null; }

        /// <summary>Backing field for <see cref="IsEnabled" /> property.</summary>
        private bool? _isEnabled;

        /// <summary>The value indicating if rule is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public bool? IsEnabled { get => this._isEnabled; set => this._isEnabled = value; }

        /// <summary>The type of rule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RoleManagementPolicyRuleType RuleType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)__roleManagementPolicyRule).RuleType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)__roleManagementPolicyRule).RuleType = value ; }

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

        /// <summary>
        /// Creates an new <see cref="RoleManagementPolicyAuthenticationContextRule" /> instance.
        /// </summary>
        public RoleManagementPolicyAuthenticationContextRule()
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
    public partial interface IRoleManagementPolicyAuthenticationContextRule :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule
    {
        /// <summary>The claim value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The claim value.",
        SerializedName = @"claimValue",
        PossibleTypes = new [] { typeof(string) })]
        string ClaimValue { get; set; }
        /// <summary>The value indicating if rule is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value indicating if rule is enabled.",
        SerializedName = @"isEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsEnabled { get; set; }

    }
    /// The role management policy rule.
    internal partial interface IRoleManagementPolicyAuthenticationContextRuleInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal
    {
        /// <summary>The claim value.</summary>
        string ClaimValue { get; set; }
        /// <summary>The value indicating if rule is enabled.</summary>
        bool? IsEnabled { get; set; }

    }
}