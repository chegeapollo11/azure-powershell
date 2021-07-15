namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Extensions;

    /// <summary>The role management policy rule target.</summary>
    public partial class RoleManagementPolicyRuleTarget
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleTarget.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleTarget.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleTarget FromJson(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject json ? new RoleManagementPolicyRuleTarget(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject into a new instance of <see cref="RoleManagementPolicyRuleTarget" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal RoleManagementPolicyRuleTarget(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_caller = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString>("caller"), out var __jsonCaller) ? (string)__jsonCaller : (string)Caller;}
            {_operation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonArray>("operations"), out var __jsonOperations) ? If( __jsonOperations as Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : Operation;}
            {_level = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString>("level"), out var __jsonLevel) ? (string)__jsonLevel : (string)Level;}
            {_targetObject = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonArray>("targetObjects"), out var __jsonTargetObjects) ? If( __jsonTargetObjects as Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : TargetObject;}
            {_inheritableSetting = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonArray>("inheritableSettings"), out var __jsonInheritableSettings) ? If( __jsonInheritableSettings as Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(string) (__k is Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString __j ? (string)(__j.ToString()) : null)) ))() : null : InheritableSetting;}
            {_enforcedSetting = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonArray>("enforcedSettings"), out var __jsonEnforcedSettings) ? If( __jsonEnforcedSettings as Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__g, (__f)=>(string) (__f is Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString __e ? (string)(__e.ToString()) : null)) ))() : null : EnforcedSetting;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="RoleManagementPolicyRuleTarget" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="RoleManagementPolicyRuleTarget" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._caller)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString(this._caller.ToString()) : null, "caller" ,container.Add );
            if (null != this._operation)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.XNodeArray();
                foreach( var __x in this._operation )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("operations",__w);
            }
            AddIf( null != (((object)this._level)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString(this._level.ToString()) : null, "level" ,container.Add );
            if (null != this._targetObject)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.XNodeArray();
                foreach( var __s in this._targetObject )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("targetObjects",__r);
            }
            if (null != this._inheritableSetting)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.XNodeArray();
                foreach( var __n in this._inheritableSetting )
                {
                    AddIf(null != (((object)__n)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString(__n.ToString()) : null ,__m.Add);
                }
                container.Add("inheritableSettings",__m);
            }
            if (null != this._enforcedSetting)
            {
                var __h = new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.XNodeArray();
                foreach( var __i in this._enforcedSetting )
                {
                    AddIf(null != (((object)__i)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString(__i.ToString()) : null ,__h.Add);
                }
                container.Add("enforcedSettings",__h);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}