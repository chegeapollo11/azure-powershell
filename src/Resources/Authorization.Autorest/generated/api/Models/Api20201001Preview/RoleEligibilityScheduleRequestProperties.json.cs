namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Extensions;

    /// <summary>Role eligibility schedule request properties with scope.</summary>
    public partial class RoleEligibilityScheduleRequestProperties
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject json ? new RoleEligibilityScheduleRequestProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject into a new instance of <see cref="RoleEligibilityScheduleRequestProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal RoleEligibilityScheduleRequestProperties(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_scheduleInfo = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject>("scheduleInfo"), out var __jsonScheduleInfo) ? Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleEligibilityScheduleRequestPropertiesScheduleInfo.FromJson(__jsonScheduleInfo) : ScheduleInfo;}
            {_ticketInfo = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject>("ticketInfo"), out var __jsonTicketInfo) ? Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleEligibilityScheduleRequestPropertiesTicketInfo.FromJson(__jsonTicketInfo) : TicketInfo;}
            {_expandedProperty = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject>("expandedProperties"), out var __jsonExpandedProperties) ? Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.ExpandedProperties.FromJson(__jsonExpandedProperties) : ExpandedProperty;}
            {_scope = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString>("scope"), out var __jsonScope) ? (string)__jsonScope : (string)Scope;}
            {_roleDefinitionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString>("roleDefinitionId"), out var __jsonRoleDefinitionId) ? (string)__jsonRoleDefinitionId : (string)RoleDefinitionId;}
            {_principalId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString>("principalId"), out var __jsonPrincipalId) ? (string)__jsonPrincipalId : (string)PrincipalId;}
            {_principalType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString>("principalType"), out var __jsonPrincipalType) ? (string)__jsonPrincipalType : (string)PrincipalType;}
            {_requestType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString>("requestType"), out var __jsonRequestType) ? (string)__jsonRequestType : (string)RequestType;}
            {_status = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)Status;}
            {_approvalId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString>("approvalId"), out var __jsonApprovalId) ? (string)__jsonApprovalId : (string)ApprovalId;}
            {_targetRoleEligibilityScheduleId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString>("targetRoleEligibilityScheduleId"), out var __jsonTargetRoleEligibilityScheduleId) ? (string)__jsonTargetRoleEligibilityScheduleId : (string)TargetRoleEligibilityScheduleId;}
            {_targetRoleEligibilityScheduleInstanceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString>("targetRoleEligibilityScheduleInstanceId"), out var __jsonTargetRoleEligibilityScheduleInstanceId) ? (string)__jsonTargetRoleEligibilityScheduleInstanceId : (string)TargetRoleEligibilityScheduleInstanceId;}
            {_justification = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString>("justification"), out var __jsonJustification) ? (string)__jsonJustification : (string)Justification;}
            {_condition = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString>("condition"), out var __jsonCondition) ? (string)__jsonCondition : (string)Condition;}
            {_conditionVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString>("conditionVersion"), out var __jsonConditionVersion) ? (string)__jsonConditionVersion : (string)ConditionVersion;}
            {_createdOn = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString>("createdOn"), out var __jsonCreatedOn) ? global::System.DateTime.TryParse((string)__jsonCreatedOn, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonCreatedOnValue) ? __jsonCreatedOnValue : CreatedOn : CreatedOn;}
            {_requestorId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString>("requestorId"), out var __jsonRequestorId) ? (string)__jsonRequestorId : (string)RequestorId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="RoleEligibilityScheduleRequestProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="RoleEligibilityScheduleRequestProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode"
        /// />.
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
            AddIf( null != this._scheduleInfo ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) this._scheduleInfo.ToJson(null,serializationMode) : null, "scheduleInfo" ,container.Add );
            AddIf( null != this._ticketInfo ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) this._ticketInfo.ToJson(null,serializationMode) : null, "ticketInfo" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._expandedProperty ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) this._expandedProperty.ToJson(null,serializationMode) : null, "expandedProperties" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._scope)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString(this._scope.ToString()) : null, "scope" ,container.Add );
            }
            AddIf( null != (((object)this._roleDefinitionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString(this._roleDefinitionId.ToString()) : null, "roleDefinitionId" ,container.Add );
            AddIf( null != (((object)this._principalId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString(this._principalId.ToString()) : null, "principalId" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._principalType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString(this._principalType.ToString()) : null, "principalType" ,container.Add );
            }
            AddIf( null != (((object)this._requestType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString(this._requestType.ToString()) : null, "requestType" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._status)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString(this._status.ToString()) : null, "status" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._approvalId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString(this._approvalId.ToString()) : null, "approvalId" ,container.Add );
            }
            AddIf( null != (((object)this._targetRoleEligibilityScheduleId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString(this._targetRoleEligibilityScheduleId.ToString()) : null, "targetRoleEligibilityScheduleId" ,container.Add );
            AddIf( null != (((object)this._targetRoleEligibilityScheduleInstanceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString(this._targetRoleEligibilityScheduleInstanceId.ToString()) : null, "targetRoleEligibilityScheduleInstanceId" ,container.Add );
            AddIf( null != (((object)this._justification)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString(this._justification.ToString()) : null, "justification" ,container.Add );
            AddIf( null != (((object)this._condition)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString(this._condition.ToString()) : null, "condition" ,container.Add );
            AddIf( null != (((object)this._conditionVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString(this._conditionVersion.ToString()) : null, "conditionVersion" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._createdOn ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString(this._createdOn?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "createdOn" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._requestorId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Json.JsonString(this._requestorId.ToString()) : null, "requestorId" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}