namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Extensions;

    /// <summary>Role management policy properties with scope.</summary>
    public partial class RoleManagementPolicyProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject json ? new RoleManagementPolicyProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject into a new instance of <see cref="RoleManagementPolicyProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal RoleManagementPolicyProperties(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_lastModifiedBy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject>("lastModifiedBy"), out var __jsonLastModifiedBy) ? Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.Principal.FromJson(__jsonLastModifiedBy) : LastModifiedBy;}
            {_policyProperty = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject>("policyProperties"), out var __jsonPolicyProperties) ? Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.PolicyProperties.FromJson(__jsonPolicyProperties) : PolicyProperty;}
            {_scope = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString>("scope"), out var __jsonScope) ? (string)__jsonScope : (string)Scope;}
            {_displayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            {_isOrganizationDefault = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonBoolean>("isOrganizationDefault"), out var __jsonIsOrganizationDefault) ? (bool?)__jsonIsOrganizationDefault : IsOrganizationDefault;}
            {_lastModifiedDateTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString>("lastModifiedDateTime"), out var __jsonLastModifiedDateTime) ? global::System.DateTime.TryParse((string)__jsonLastModifiedDateTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastModifiedDateTimeValue) ? __jsonLastModifiedDateTimeValue : LastModifiedDateTime : LastModifiedDateTime;}
            {_rule = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonArray>("rules"), out var __jsonRules) ? If( __jsonRules as Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule) (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleManagementPolicyRule.FromJson(__u) )) ))() : null : Rule;}
            {_effectiveRule = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonArray>("effectiveRules"), out var __jsonEffectiveRules) ? If( __jsonEffectiveRules as Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule) (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleManagementPolicyRule.FromJson(__p) )) ))() : null : EffectiveRule;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="RoleManagementPolicyProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="RoleManagementPolicyProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._lastModifiedBy ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) this._lastModifiedBy.ToJson(null,serializationMode) : null, "lastModifiedBy" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._policyProperty ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) this._policyProperty.ToJson(null,serializationMode) : null, "policyProperties" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._scope)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString(this._scope.ToString()) : null, "scope" ,container.Add );
            }
            AddIf( null != (((object)this._displayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != (((object)this._description)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            AddIf( null != this._isOrganizationDefault ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonBoolean((bool)this._isOrganizationDefault) : null, "isOrganizationDefault" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._lastModifiedDateTime ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString(this._lastModifiedDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "lastModifiedDateTime" ,container.Add );
            }
            if (null != this._rule)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.XNodeArray();
                foreach( var __x in this._rule )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("rules",__w);
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._effectiveRule)
                {
                    var __r = new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.XNodeArray();
                    foreach( var __s in this._effectiveRule )
                    {
                        AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                    }
                    container.Add("effectiveRules",__r);
                }
            }
            AfterToJson(ref container);
            return container;
        }
    }
}