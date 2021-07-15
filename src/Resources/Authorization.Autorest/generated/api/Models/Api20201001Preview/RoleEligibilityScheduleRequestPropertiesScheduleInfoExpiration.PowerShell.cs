namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.PowerShell;

    /// <summary>Expiration of the role eligibility schedule</summary>
    [System.ComponentModel.TypeConverter(typeof(RoleEligibilityScheduleRequestPropertiesScheduleInfoExpirationTypeConverter))]
    public partial class RoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration" />, deserializing
        /// the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpirationInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Type?) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpirationInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Type.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpirationInternal)this).EndDateTime = (global::System.DateTime?) content.GetValueForProperty("EndDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpirationInternal)this).EndDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpirationInternal)this).Duration = (string) content.GetValueForProperty("Duration",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpirationInternal)this).Duration, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpirationInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Type?) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpirationInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Type.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpirationInternal)this).EndDateTime = (global::System.DateTime?) content.GetValueForProperty("EndDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpirationInternal)this).EndDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpirationInternal)this).Duration = (string) content.GetValueForProperty("Duration",((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpirationInternal)this).Duration, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Expiration of the role eligibility schedule
    [System.ComponentModel.TypeConverter(typeof(RoleEligibilityScheduleRequestPropertiesScheduleInfoExpirationTypeConverter))]
    public partial interface IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration

    {

    }
}