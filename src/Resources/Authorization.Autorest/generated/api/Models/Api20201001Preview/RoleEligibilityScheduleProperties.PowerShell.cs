namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.PowerShell;

    /// <summary>Role eligibility schedule properties with scope.</summary>
    [System.ComponentModel.TypeConverter(typeof(RoleEligibilitySchedulePropertiesTypeConverter))]
    public partial class RoleEligibilityScheduleProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleEligibilityScheduleProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RoleEligibilityScheduleProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleEligibilityScheduleProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RoleEligibilityScheduleProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RoleEligibilityScheduleProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleEligibilityScheduleProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RoleEligibilityScheduleProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedProperty = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedProperties) content.GetValueForProperty("ExpandedProperty",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedProperty, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.ExpandedPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).Scope = (string) content.GetValueForProperty("Scope",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).Scope, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).RoleDefinitionId = (string) content.GetValueForProperty("RoleDefinitionId",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).RoleDefinitionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).PrincipalId = (string) content.GetValueForProperty("PrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).PrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).PrincipalType = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.PrincipalType?) content.GetValueForProperty("PrincipalType",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).PrincipalType, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.PrincipalType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).RoleEligibilityScheduleRequestId = (string) content.GetValueForProperty("RoleEligibilityScheduleRequestId",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).RoleEligibilityScheduleRequestId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).MemberType = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.MemberType?) content.GetValueForProperty("MemberType",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).MemberType, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.MemberType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Status?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Status.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).StartDateTime = (global::System.DateTime?) content.GetValueForProperty("StartDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).StartDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).EndDateTime = (global::System.DateTime?) content.GetValueForProperty("EndDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).EndDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).Condition = (string) content.GetValueForProperty("Condition",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).Condition, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ConditionVersion = (string) content.GetValueForProperty("ConditionVersion",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ConditionVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).CreatedOn = (global::System.DateTime?) content.GetValueForProperty("CreatedOn",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).CreatedOn, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).UpdatedOn = (global::System.DateTime?) content.GetValueForProperty("UpdatedOn",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).UpdatedOn, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedPropertyScope = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesScope) content.GetValueForProperty("ExpandedPropertyScope",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedPropertyScope, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.ExpandedPropertiesScopeTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedPropertyRoleDefinition = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesRoleDefinition) content.GetValueForProperty("ExpandedPropertyRoleDefinition",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedPropertyRoleDefinition, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.ExpandedPropertiesRoleDefinitionTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedPropertyPrincipal = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesPrincipal) content.GetValueForProperty("ExpandedPropertyPrincipal",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedPropertyPrincipal, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.ExpandedPropertiesPrincipalTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ScopeId = (string) content.GetValueForProperty("ScopeId",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ScopeId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ScopeDisplayName = (string) content.GetValueForProperty("ScopeDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ScopeDisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ScopeType = (string) content.GetValueForProperty("ScopeType",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ScopeType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedPropertiesRoleDefinitionId = (string) content.GetValueForProperty("ExpandedPropertiesRoleDefinitionId",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedPropertiesRoleDefinitionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).RoleDefinitionDisplayName = (string) content.GetValueForProperty("RoleDefinitionDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).RoleDefinitionDisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).RoleDefinitionType = (string) content.GetValueForProperty("RoleDefinitionType",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).RoleDefinitionType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedPropertiesPrincipalId = (string) content.GetValueForProperty("ExpandedPropertiesPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedPropertiesPrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).PrincipalDisplayName = (string) content.GetValueForProperty("PrincipalDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).PrincipalDisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).PrincipalEmail = (string) content.GetValueForProperty("PrincipalEmail",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).PrincipalEmail, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedPropertiesPrincipalType = (string) content.GetValueForProperty("ExpandedPropertiesPrincipalType",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedPropertiesPrincipalType, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleEligibilityScheduleProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RoleEligibilityScheduleProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedProperty = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedProperties) content.GetValueForProperty("ExpandedProperty",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedProperty, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.ExpandedPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).Scope = (string) content.GetValueForProperty("Scope",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).Scope, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).RoleDefinitionId = (string) content.GetValueForProperty("RoleDefinitionId",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).RoleDefinitionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).PrincipalId = (string) content.GetValueForProperty("PrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).PrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).PrincipalType = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.PrincipalType?) content.GetValueForProperty("PrincipalType",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).PrincipalType, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.PrincipalType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).RoleEligibilityScheduleRequestId = (string) content.GetValueForProperty("RoleEligibilityScheduleRequestId",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).RoleEligibilityScheduleRequestId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).MemberType = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.MemberType?) content.GetValueForProperty("MemberType",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).MemberType, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.MemberType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Status?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Status.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).StartDateTime = (global::System.DateTime?) content.GetValueForProperty("StartDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).StartDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).EndDateTime = (global::System.DateTime?) content.GetValueForProperty("EndDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).EndDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).Condition = (string) content.GetValueForProperty("Condition",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).Condition, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ConditionVersion = (string) content.GetValueForProperty("ConditionVersion",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ConditionVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).CreatedOn = (global::System.DateTime?) content.GetValueForProperty("CreatedOn",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).CreatedOn, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).UpdatedOn = (global::System.DateTime?) content.GetValueForProperty("UpdatedOn",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).UpdatedOn, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedPropertyScope = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesScope) content.GetValueForProperty("ExpandedPropertyScope",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedPropertyScope, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.ExpandedPropertiesScopeTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedPropertyRoleDefinition = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesRoleDefinition) content.GetValueForProperty("ExpandedPropertyRoleDefinition",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedPropertyRoleDefinition, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.ExpandedPropertiesRoleDefinitionTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedPropertyPrincipal = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesPrincipal) content.GetValueForProperty("ExpandedPropertyPrincipal",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedPropertyPrincipal, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.ExpandedPropertiesPrincipalTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ScopeId = (string) content.GetValueForProperty("ScopeId",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ScopeId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ScopeDisplayName = (string) content.GetValueForProperty("ScopeDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ScopeDisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ScopeType = (string) content.GetValueForProperty("ScopeType",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ScopeType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedPropertiesRoleDefinitionId = (string) content.GetValueForProperty("ExpandedPropertiesRoleDefinitionId",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedPropertiesRoleDefinitionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).RoleDefinitionDisplayName = (string) content.GetValueForProperty("RoleDefinitionDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).RoleDefinitionDisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).RoleDefinitionType = (string) content.GetValueForProperty("RoleDefinitionType",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).RoleDefinitionType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedPropertiesPrincipalId = (string) content.GetValueForProperty("ExpandedPropertiesPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedPropertiesPrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).PrincipalDisplayName = (string) content.GetValueForProperty("PrincipalDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).PrincipalDisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).PrincipalEmail = (string) content.GetValueForProperty("PrincipalEmail",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).PrincipalEmail, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedPropertiesPrincipalType = (string) content.GetValueForProperty("ExpandedPropertiesPrincipalType",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)this).ExpandedPropertiesPrincipalType, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Role eligibility schedule properties with scope.
    [System.ComponentModel.TypeConverter(typeof(RoleEligibilitySchedulePropertiesTypeConverter))]
    public partial interface IRoleEligibilityScheduleProperties

    {

    }
}