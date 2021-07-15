namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.PowerShell;

    /// <summary>The role management policy rule.</summary>
    [System.ComponentModel.TypeConverter(typeof(RoleManagementPolicyNotificationRuleTypeConverter))]
    public partial class RoleManagementPolicyNotificationRule
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleManagementPolicyNotificationRule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRule"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRule DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RoleManagementPolicyNotificationRule(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleManagementPolicyNotificationRule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRule"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRule DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RoleManagementPolicyNotificationRule(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RoleManagementPolicyNotificationRule" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRule FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleManagementPolicyNotificationRule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RoleManagementPolicyNotificationRule(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRuleInternal)this).NotificationType = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.NotificationDeliveryMechanism?) content.GetValueForProperty("NotificationType",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRuleInternal)this).NotificationType, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.NotificationDeliveryMechanism.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRuleInternal)this).NotificationLevel = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.NotificationLevel?) content.GetValueForProperty("NotificationLevel",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRuleInternal)this).NotificationLevel, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.NotificationLevel.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRuleInternal)this).RecipientType = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RecipientType?) content.GetValueForProperty("RecipientType",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRuleInternal)this).RecipientType, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RecipientType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRuleInternal)this).NotificationRecipient = (string[]) content.GetValueForProperty("NotificationRecipient",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRuleInternal)this).NotificationRecipient, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRuleInternal)this).IsDefaultRecipientsEnabled = (bool?) content.GetValueForProperty("IsDefaultRecipientsEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRuleInternal)this).IsDefaultRecipientsEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).TargetCaller = (string) content.GetValueForProperty("TargetCaller",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).TargetCaller, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).TargetOperation = (string[]) content.GetValueForProperty("TargetOperation",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).TargetOperation, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).TargetLevel = (string) content.GetValueForProperty("TargetLevel",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).TargetLevel, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).TargetObject = (string[]) content.GetValueForProperty("TargetObject",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).TargetObject, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).TargetInheritableSetting = (string[]) content.GetValueForProperty("TargetInheritableSetting",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).TargetInheritableSetting, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).TargetEnforcedSetting = (string[]) content.GetValueForProperty("TargetEnforcedSetting",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).TargetEnforcedSetting, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).Target = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleTarget) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).Target, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleManagementPolicyRuleTargetTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).RuleType = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RoleManagementPolicyRuleType) content.GetValueForProperty("RuleType",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).RuleType, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RoleManagementPolicyRuleType.CreateFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleManagementPolicyNotificationRule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RoleManagementPolicyNotificationRule(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRuleInternal)this).NotificationType = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.NotificationDeliveryMechanism?) content.GetValueForProperty("NotificationType",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRuleInternal)this).NotificationType, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.NotificationDeliveryMechanism.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRuleInternal)this).NotificationLevel = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.NotificationLevel?) content.GetValueForProperty("NotificationLevel",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRuleInternal)this).NotificationLevel, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.NotificationLevel.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRuleInternal)this).RecipientType = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RecipientType?) content.GetValueForProperty("RecipientType",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRuleInternal)this).RecipientType, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RecipientType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRuleInternal)this).NotificationRecipient = (string[]) content.GetValueForProperty("NotificationRecipient",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRuleInternal)this).NotificationRecipient, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRuleInternal)this).IsDefaultRecipientsEnabled = (bool?) content.GetValueForProperty("IsDefaultRecipientsEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyNotificationRuleInternal)this).IsDefaultRecipientsEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).TargetCaller = (string) content.GetValueForProperty("TargetCaller",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).TargetCaller, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).TargetOperation = (string[]) content.GetValueForProperty("TargetOperation",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).TargetOperation, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).TargetLevel = (string) content.GetValueForProperty("TargetLevel",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).TargetLevel, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).TargetObject = (string[]) content.GetValueForProperty("TargetObject",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).TargetObject, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).TargetInheritableSetting = (string[]) content.GetValueForProperty("TargetInheritableSetting",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).TargetInheritableSetting, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).TargetEnforcedSetting = (string[]) content.GetValueForProperty("TargetEnforcedSetting",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).TargetEnforcedSetting, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).Target = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleTarget) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).Target, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleManagementPolicyRuleTargetTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).RuleType = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RoleManagementPolicyRuleType) content.GetValueForProperty("RuleType",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleInternal)this).RuleType, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RoleManagementPolicyRuleType.CreateFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The role management policy rule.
    [System.ComponentModel.TypeConverter(typeof(RoleManagementPolicyNotificationRuleTypeConverter))]
    public partial interface IRoleManagementPolicyNotificationRule

    {

    }
}