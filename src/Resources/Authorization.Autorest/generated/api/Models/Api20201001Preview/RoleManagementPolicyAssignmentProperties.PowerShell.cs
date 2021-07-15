namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.PowerShell;

    /// <summary>Role management policy assignment properties with scope.</summary>
    [System.ComponentModel.TypeConverter(typeof(RoleManagementPolicyAssignmentPropertiesTypeConverter))]
    public partial class RoleManagementPolicyAssignmentProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleManagementPolicyAssignmentProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RoleManagementPolicyAssignmentProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleManagementPolicyAssignmentProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RoleManagementPolicyAssignmentProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RoleManagementPolicyAssignmentProperties" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleManagementPolicyAssignmentProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RoleManagementPolicyAssignmentProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyAssignmentProperty = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentProperties) content.GetValueForProperty("PolicyAssignmentProperty",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyAssignmentProperty, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.PolicyAssignmentPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).Scope = (string) content.GetValueForProperty("Scope",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).Scope, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).RoleDefinitionId = (string) content.GetValueForProperty("RoleDefinitionId",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).RoleDefinitionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyId = (string) content.GetValueForProperty("PolicyId",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyAssignmentPropertyScope = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesScope) content.GetValueForProperty("PolicyAssignmentPropertyScope",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyAssignmentPropertyScope, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.PolicyAssignmentPropertiesScopeTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyAssignmentPropertyRoleDefinition = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesRoleDefinition) content.GetValueForProperty("PolicyAssignmentPropertyRoleDefinition",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyAssignmentPropertyRoleDefinition, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.PolicyAssignmentPropertiesRoleDefinitionTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyAssignmentPropertyPolicy = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesPolicy) content.GetValueForProperty("PolicyAssignmentPropertyPolicy",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyAssignmentPropertyPolicy, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.PolicyAssignmentPropertiesPolicyTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).ScopeId = (string) content.GetValueForProperty("ScopeId",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).ScopeId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).ScopeDisplayName = (string) content.GetValueForProperty("ScopeDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).ScopeDisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).ScopeType = (string) content.GetValueForProperty("ScopeType",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).ScopeType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyAssignmentPropertiesRoleDefinitionId = (string) content.GetValueForProperty("PolicyAssignmentPropertiesRoleDefinitionId",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyAssignmentPropertiesRoleDefinitionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).RoleDefinitionDisplayName = (string) content.GetValueForProperty("RoleDefinitionDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).RoleDefinitionDisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).RoleDefinitionType = (string) content.GetValueForProperty("RoleDefinitionType",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).RoleDefinitionType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyAssignmentPropertiesPolicyId = (string) content.GetValueForProperty("PolicyAssignmentPropertiesPolicyId",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyAssignmentPropertiesPolicyId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyLastModifiedBy = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPrincipal) content.GetValueForProperty("PolicyLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyLastModifiedBy, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.PrincipalTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyLastModifiedDateTime = (global::System.DateTime?) content.GetValueForProperty("PolicyLastModifiedDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyLastModifiedDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).LastModifiedById = (string) content.GetValueForProperty("LastModifiedById",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).LastModifiedById, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).LastModifiedByDisplayName = (string) content.GetValueForProperty("LastModifiedByDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).LastModifiedByDisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).LastModifiedByType = (string) content.GetValueForProperty("LastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).LastModifiedByType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).LastModifiedByEmail = (string) content.GetValueForProperty("LastModifiedByEmail",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).LastModifiedByEmail, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleManagementPolicyAssignmentProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RoleManagementPolicyAssignmentProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyAssignmentProperty = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentProperties) content.GetValueForProperty("PolicyAssignmentProperty",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyAssignmentProperty, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.PolicyAssignmentPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).Scope = (string) content.GetValueForProperty("Scope",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).Scope, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).RoleDefinitionId = (string) content.GetValueForProperty("RoleDefinitionId",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).RoleDefinitionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyId = (string) content.GetValueForProperty("PolicyId",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyAssignmentPropertyScope = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesScope) content.GetValueForProperty("PolicyAssignmentPropertyScope",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyAssignmentPropertyScope, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.PolicyAssignmentPropertiesScopeTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyAssignmentPropertyRoleDefinition = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesRoleDefinition) content.GetValueForProperty("PolicyAssignmentPropertyRoleDefinition",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyAssignmentPropertyRoleDefinition, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.PolicyAssignmentPropertiesRoleDefinitionTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyAssignmentPropertyPolicy = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesPolicy) content.GetValueForProperty("PolicyAssignmentPropertyPolicy",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyAssignmentPropertyPolicy, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.PolicyAssignmentPropertiesPolicyTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).ScopeId = (string) content.GetValueForProperty("ScopeId",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).ScopeId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).ScopeDisplayName = (string) content.GetValueForProperty("ScopeDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).ScopeDisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).ScopeType = (string) content.GetValueForProperty("ScopeType",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).ScopeType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyAssignmentPropertiesRoleDefinitionId = (string) content.GetValueForProperty("PolicyAssignmentPropertiesRoleDefinitionId",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyAssignmentPropertiesRoleDefinitionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).RoleDefinitionDisplayName = (string) content.GetValueForProperty("RoleDefinitionDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).RoleDefinitionDisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).RoleDefinitionType = (string) content.GetValueForProperty("RoleDefinitionType",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).RoleDefinitionType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyAssignmentPropertiesPolicyId = (string) content.GetValueForProperty("PolicyAssignmentPropertiesPolicyId",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyAssignmentPropertiesPolicyId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyLastModifiedBy = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IPrincipal) content.GetValueForProperty("PolicyLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyLastModifiedBy, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.PrincipalTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyLastModifiedDateTime = (global::System.DateTime?) content.GetValueForProperty("PolicyLastModifiedDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).PolicyLastModifiedDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).LastModifiedById = (string) content.GetValueForProperty("LastModifiedById",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).LastModifiedById, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).LastModifiedByDisplayName = (string) content.GetValueForProperty("LastModifiedByDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).LastModifiedByDisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).LastModifiedByType = (string) content.GetValueForProperty("LastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).LastModifiedByType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).LastModifiedByEmail = (string) content.GetValueForProperty("LastModifiedByEmail",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentPropertiesInternal)this).LastModifiedByEmail, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Role management policy assignment properties with scope.
    [System.ComponentModel.TypeConverter(typeof(RoleManagementPolicyAssignmentPropertiesTypeConverter))]
    public partial interface IRoleManagementPolicyAssignmentProperties

    {

    }
}