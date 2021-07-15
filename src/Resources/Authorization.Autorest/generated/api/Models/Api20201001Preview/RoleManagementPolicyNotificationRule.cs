namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Extensions;

    /// <summary>The role management policy rule.</summary>
    public partial class RoleManagementPolicyNotificationRule :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRule,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRuleInternal,
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

        /// <summary>Backing field for <see cref="IsDefaultRecipientsEnabled" /> property.</summary>
        private bool? _isDefaultRecipientsEnabled;

        /// <summary>
        /// Its value determine if the notification need to be sent to the recipient type specified in policy rule.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public bool? IsDefaultRecipientsEnabled { get => this._isDefaultRecipientsEnabled; set => this._isDefaultRecipientsEnabled = value; }

        /// <summary>Backing field for <see cref="NotificationLevel" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.NotificationLevel? _notificationLevel;

        /// <summary>The notification level.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.NotificationLevel? NotificationLevel { get => this._notificationLevel; set => this._notificationLevel = value; }

        /// <summary>Backing field for <see cref="NotificationRecipient" /> property.</summary>
        private string[] _notificationRecipient;

        /// <summary>The list notification recipients.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string[] NotificationRecipient { get => this._notificationRecipient; set => this._notificationRecipient = value; }

        /// <summary>Backing field for <see cref="NotificationType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.NotificationDeliveryMechanism? _notificationType;

        /// <summary>The type of notification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.NotificationDeliveryMechanism? NotificationType { get => this._notificationType; set => this._notificationType = value; }

        /// <summary>Backing field for <see cref="RecipientType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RecipientType? _recipientType;

        /// <summary>The recipient type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RecipientType? RecipientType { get => this._recipientType; set => this._recipientType = value; }

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

        /// <summary>Creates an new <see cref="RoleManagementPolicyNotificationRule" /> instance.</summary>
        public RoleManagementPolicyNotificationRule()
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
    public partial interface IRoleManagementPolicyNotificationRule :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule
    {
        /// <summary>
        /// Its value determine if the notification need to be sent to the recipient type specified in policy rule.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Its value determine if the notification need to be sent to the recipient type specified in policy rule.",
        SerializedName = @"isDefaultRecipientsEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDefaultRecipientsEnabled { get; set; }
        /// <summary>The notification level.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The notification level.",
        SerializedName = @"notificationLevel",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.NotificationLevel) })]
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.NotificationLevel? NotificationLevel { get; set; }
        /// <summary>The list notification recipients.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list notification recipients.",
        SerializedName = @"notificationRecipients",
        PossibleTypes = new [] { typeof(string) })]
        string[] NotificationRecipient { get; set; }
        /// <summary>The type of notification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of notification.",
        SerializedName = @"notificationType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.NotificationDeliveryMechanism) })]
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.NotificationDeliveryMechanism? NotificationType { get; set; }
        /// <summary>The recipient type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recipient type.",
        SerializedName = @"recipientType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RecipientType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RecipientType? RecipientType { get; set; }

    }
    /// The role management policy rule.
    internal partial interface IRoleManagementPolicyNotificationRuleInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal
    {
        /// <summary>
        /// Its value determine if the notification need to be sent to the recipient type specified in policy rule.
        /// </summary>
        bool? IsDefaultRecipientsEnabled { get; set; }
        /// <summary>The notification level.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.NotificationLevel? NotificationLevel { get; set; }
        /// <summary>The list notification recipients.</summary>
        string[] NotificationRecipient { get; set; }
        /// <summary>The type of notification.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.NotificationDeliveryMechanism? NotificationType { get; set; }
        /// <summary>The recipient type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RecipientType? RecipientType { get; set; }

    }
}