namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Extensions;

    /// <summary>Role eligibility schedule request properties with scope.</summary>
    public partial class RoleEligibilityScheduleRequestProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ApprovalId" /> property.</summary>
        private string _approvalId;

        /// <summary>The approvalId of the role eligibility schedule request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string ApprovalId { get => this._approvalId; }

        /// <summary>Backing field for <see cref="Condition" /> property.</summary>
        private string _condition;

        /// <summary>
        /// The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName]
        /// StringEqualsIgnoreCase 'foo_storage_container'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string Condition { get => this._condition; set => this._condition = value; }

        /// <summary>Backing field for <see cref="ConditionVersion" /> property.</summary>
        private string _conditionVersion;

        /// <summary>Version of the condition. Currently accepted value is '2.0'</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string ConditionVersion { get => this._conditionVersion; set => this._conditionVersion = value; }

        /// <summary>Backing field for <see cref="CreatedOn" /> property.</summary>
        private global::System.DateTime? _createdOn;

        /// <summary>DateTime when role eligibility schedule request was created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public global::System.DateTime? CreatedOn { get => this._createdOn; }

        /// <summary>Id of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ExpandedPropertiesPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).PrincipalId = value ?? null; }

        /// <summary>Type of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ExpandedPropertiesPrincipalType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).PrincipalType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).PrincipalType = value ?? null; }

        /// <summary>Id of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ExpandedPropertiesRoleDefinitionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).RoleDefinitionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).RoleDefinitionId = value ?? null; }

        /// <summary>Backing field for <see cref="ExpandedProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedProperties _expandedProperty;

        /// <summary>Additional properties of principal, scope and role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedProperties ExpandedProperty { get => (this._expandedProperty = this._expandedProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.ExpandedProperties()); }

        /// <summary>Duration of the role eligibility schedule in TimeSpan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ExpirationDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoInternal)ScheduleInfo).ExpirationDuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoInternal)ScheduleInfo).ExpirationDuration = value ?? null; }

        /// <summary>End DateTime of the role eligibility schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public global::System.DateTime? ExpirationEndDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoInternal)ScheduleInfo).ExpirationEndDateTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoInternal)ScheduleInfo).ExpirationEndDateTime = value ?? default(global::System.DateTime); }

        /// <summary>Type of the role eligibility schedule expiration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Type? ExpirationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoInternal)ScheduleInfo).ExpirationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoInternal)ScheduleInfo).ExpirationType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Type)""); }

        /// <summary>Backing field for <see cref="Justification" /> property.</summary>
        private string _justification;

        /// <summary>Justification for the role eligibility</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string Justification { get => this._justification; set => this._justification = value; }

        /// <summary>Internal Acessors for ApprovalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal.ApprovalId { get => this._approvalId; set { {_approvalId = value;} } }

        /// <summary>Internal Acessors for CreatedOn</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal.CreatedOn { get => this._createdOn; set { {_createdOn = value;} } }

        /// <summary>Internal Acessors for ExpandedProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedProperties Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal.ExpandedProperty { get => (this._expandedProperty = this._expandedProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.ExpandedProperties()); set { {_expandedProperty = value;} } }

        /// <summary>Internal Acessors for ExpandedPropertyPrincipal</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesPrincipal Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal.ExpandedPropertyPrincipal { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).Principal; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).Principal = value; }

        /// <summary>Internal Acessors for ExpandedPropertyRoleDefinition</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesRoleDefinition Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal.ExpandedPropertyRoleDefinition { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).RoleDefinition; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).RoleDefinition = value; }

        /// <summary>Internal Acessors for ExpandedPropertyScope</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesScope Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal.ExpandedPropertyScope { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).Scope; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).Scope = value; }

        /// <summary>Internal Acessors for PrincipalType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.PrincipalType? Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal.PrincipalType { get => this._principalType; set { {_principalType = value;} } }

        /// <summary>Internal Acessors for RequestorId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal.RequestorId { get => this._requestorId; set { {_requestorId = value;} } }

        /// <summary>Internal Acessors for ScheduleInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfo Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal.ScheduleInfo { get => (this._scheduleInfo = this._scheduleInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleEligibilityScheduleRequestPropertiesScheduleInfo()); set { {_scheduleInfo = value;} } }

        /// <summary>Internal Acessors for ScheduleInfoExpiration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal.ScheduleInfoExpiration { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoInternal)ScheduleInfo).Expiration; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoInternal)ScheduleInfo).Expiration = value; }

        /// <summary>Internal Acessors for Scope</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal.Scope { get => this._scope; set { {_scope = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Status? Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Internal Acessors for TicketInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesTicketInfo Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal.TicketInfo { get => (this._ticketInfo = this._ticketInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleEligibilityScheduleRequestPropertiesTicketInfo()); set { {_ticketInfo = value;} } }

        /// <summary>Display name of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string PrincipalDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).PrincipalDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).PrincipalDisplayName = value ?? null; }

        /// <summary>Email id of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string PrincipalEmail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).PrincipalEmail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).PrincipalEmail = value ?? null; }

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>The principal ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; set => this._principalId = value; }

        /// <summary>Backing field for <see cref="PrincipalType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.PrincipalType? _principalType;

        /// <summary>The principal type of the assigned principal ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.PrincipalType? PrincipalType { get => this._principalType; }

        /// <summary>Backing field for <see cref="RequestType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RequestType _requestType;

        /// <summary>
        /// The type of the role assignment schedule request. Eg: SelfActivate, AdminAssign etc
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RequestType RequestType { get => this._requestType; set => this._requestType = value; }

        /// <summary>Backing field for <see cref="RequestorId" /> property.</summary>
        private string _requestorId;

        /// <summary>Id of the user who created this request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string RequestorId { get => this._requestorId; }

        /// <summary>Display name of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string RoleDefinitionDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).RoleDefinitionDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).RoleDefinitionDisplayName = value ?? null; }

        /// <summary>Backing field for <see cref="RoleDefinitionId" /> property.</summary>
        private string _roleDefinitionId;

        /// <summary>The role definition ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string RoleDefinitionId { get => this._roleDefinitionId; set => this._roleDefinitionId = value; }

        /// <summary>Type of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string RoleDefinitionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).RoleDefinitionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).RoleDefinitionType = value ?? null; }

        /// <summary>Backing field for <see cref="ScheduleInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfo _scheduleInfo;

        /// <summary>Schedule info of the role eligibility schedule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfo ScheduleInfo { get => (this._scheduleInfo = this._scheduleInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleEligibilityScheduleRequestPropertiesScheduleInfo()); set => this._scheduleInfo = value; }

        /// <summary>Start DateTime of the role eligibility schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public global::System.DateTime? ScheduleInfoStartDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoInternal)ScheduleInfo).StartDateTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoInternal)ScheduleInfo).StartDateTime = value ?? default(global::System.DateTime); }

        /// <summary>Backing field for <see cref="Scope" /> property.</summary>
        private string _scope;

        /// <summary>The role eligibility schedule request scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string Scope { get => this._scope; }

        /// <summary>Display name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ScopeDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).ScopeDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).ScopeDisplayName = value ?? null; }

        /// <summary>Scope id of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ScopeId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).ScopeId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).ScopeId = value ?? null; }

        /// <summary>Type of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ScopeType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).ScopeType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesInternal)ExpandedProperty).ScopeType = value ?? null; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Status? _status;

        /// <summary>The status of the role eligibility schedule request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Status? Status { get => this._status; }

        /// <summary>Backing field for <see cref="TargetRoleEligibilityScheduleId" /> property.</summary>
        private string _targetRoleEligibilityScheduleId;

        /// <summary>
        /// The resultant role eligibility schedule id or the role eligibility schedule id being updated
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string TargetRoleEligibilityScheduleId { get => this._targetRoleEligibilityScheduleId; set => this._targetRoleEligibilityScheduleId = value; }

        /// <summary>
        /// Backing field for <see cref="TargetRoleEligibilityScheduleInstanceId" /> property.
        /// </summary>
        private string _targetRoleEligibilityScheduleInstanceId;

        /// <summary>The role eligibility schedule instance id being updated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string TargetRoleEligibilityScheduleInstanceId { get => this._targetRoleEligibilityScheduleInstanceId; set => this._targetRoleEligibilityScheduleInstanceId = value; }

        /// <summary>Backing field for <see cref="TicketInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesTicketInfo _ticketInfo;

        /// <summary>Ticket Info of the role eligibility</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesTicketInfo TicketInfo { get => (this._ticketInfo = this._ticketInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleEligibilityScheduleRequestPropertiesTicketInfo()); set => this._ticketInfo = value; }

        /// <summary>Ticket number for the role eligibility</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string TicketInfoTicketNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesTicketInfoInternal)TicketInfo).TicketNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesTicketInfoInternal)TicketInfo).TicketNumber = value ?? null; }

        /// <summary>Ticket system name for the role eligibility</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string TicketInfoTicketSystem { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesTicketInfoInternal)TicketInfo).TicketSystem; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesTicketInfoInternal)TicketInfo).TicketSystem = value ?? null; }

        /// <summary>
        /// Creates an new <see cref="RoleEligibilityScheduleRequestProperties" /> instance.
        /// </summary>
        public RoleEligibilityScheduleRequestProperties()
        {

        }
    }
    /// Role eligibility schedule request properties with scope.
    public partial interface IRoleEligibilityScheduleRequestProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.IJsonSerializable
    {
        /// <summary>The approvalId of the role eligibility schedule request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The approvalId of the role eligibility schedule request.",
        SerializedName = @"approvalId",
        PossibleTypes = new [] { typeof(string) })]
        string ApprovalId { get;  }
        /// <summary>
        /// The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName]
        /// StringEqualsIgnoreCase 'foo_storage_container'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName] StringEqualsIgnoreCase 'foo_storage_container'",
        SerializedName = @"condition",
        PossibleTypes = new [] { typeof(string) })]
        string Condition { get; set; }
        /// <summary>Version of the condition. Currently accepted value is '2.0'</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Version of the condition. Currently accepted value is '2.0'",
        SerializedName = @"conditionVersion",
        PossibleTypes = new [] { typeof(string) })]
        string ConditionVersion { get; set; }
        /// <summary>DateTime when role eligibility schedule request was created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"DateTime when role eligibility schedule request was created",
        SerializedName = @"createdOn",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedOn { get;  }
        /// <summary>Id of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the principal",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string ExpandedPropertiesPrincipalId { get; set; }
        /// <summary>Type of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the principal",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string ExpandedPropertiesPrincipalType { get; set; }
        /// <summary>Id of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the role definition",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string ExpandedPropertiesRoleDefinitionId { get; set; }
        /// <summary>Duration of the role eligibility schedule in TimeSpan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Duration of the role eligibility schedule in TimeSpan.",
        SerializedName = @"duration",
        PossibleTypes = new [] { typeof(string) })]
        string ExpirationDuration { get; set; }
        /// <summary>End DateTime of the role eligibility schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"End DateTime of the role eligibility schedule.",
        SerializedName = @"endDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ExpirationEndDateTime { get; set; }
        /// <summary>Type of the role eligibility schedule expiration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the role eligibility schedule expiration",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Type) })]
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Type? ExpirationType { get; set; }
        /// <summary>Justification for the role eligibility</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Justification for the role eligibility",
        SerializedName = @"justification",
        PossibleTypes = new [] { typeof(string) })]
        string Justification { get; set; }
        /// <summary>Display name of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of the principal",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalDisplayName { get; set; }
        /// <summary>Email id of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Email id of the principal",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalEmail { get; set; }
        /// <summary>The principal ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The principal ID.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get; set; }
        /// <summary>The principal type of the assigned principal ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The principal type of the assigned principal ID.",
        SerializedName = @"principalType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.PrincipalType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.PrincipalType? PrincipalType { get;  }
        /// <summary>
        /// The type of the role assignment schedule request. Eg: SelfActivate, AdminAssign etc
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The type of the role assignment schedule request. Eg: SelfActivate, AdminAssign etc",
        SerializedName = @"requestType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RequestType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RequestType RequestType { get; set; }
        /// <summary>Id of the user who created this request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Id of the user who created this request",
        SerializedName = @"requestorId",
        PossibleTypes = new [] { typeof(string) })]
        string RequestorId { get;  }
        /// <summary>Display name of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of the role definition",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string RoleDefinitionDisplayName { get; set; }
        /// <summary>The role definition ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The role definition ID.",
        SerializedName = @"roleDefinitionId",
        PossibleTypes = new [] { typeof(string) })]
        string RoleDefinitionId { get; set; }
        /// <summary>Type of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the role definition",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string RoleDefinitionType { get; set; }
        /// <summary>Start DateTime of the role eligibility schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Start DateTime of the role eligibility schedule.",
        SerializedName = @"startDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ScheduleInfoStartDateTime { get; set; }
        /// <summary>The role eligibility schedule request scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The role eligibility schedule request scope.",
        SerializedName = @"scope",
        PossibleTypes = new [] { typeof(string) })]
        string Scope { get;  }
        /// <summary>Display name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of the resource",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string ScopeDisplayName { get; set; }
        /// <summary>Scope id of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Scope id of the resource",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string ScopeId { get; set; }
        /// <summary>Type of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the resource",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string ScopeType { get; set; }
        /// <summary>The status of the role eligibility schedule request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The status of the role eligibility schedule request.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Status) })]
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Status? Status { get;  }
        /// <summary>
        /// The resultant role eligibility schedule id or the role eligibility schedule id being updated
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resultant role eligibility schedule id or the role eligibility schedule id being updated",
        SerializedName = @"targetRoleEligibilityScheduleId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetRoleEligibilityScheduleId { get; set; }
        /// <summary>The role eligibility schedule instance id being updated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The role eligibility schedule instance id being updated",
        SerializedName = @"targetRoleEligibilityScheduleInstanceId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetRoleEligibilityScheduleInstanceId { get; set; }
        /// <summary>Ticket number for the role eligibility</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Ticket number for the role eligibility",
        SerializedName = @"ticketNumber",
        PossibleTypes = new [] { typeof(string) })]
        string TicketInfoTicketNumber { get; set; }
        /// <summary>Ticket system name for the role eligibility</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Ticket system name for the role eligibility",
        SerializedName = @"ticketSystem",
        PossibleTypes = new [] { typeof(string) })]
        string TicketInfoTicketSystem { get; set; }

    }
    /// Role eligibility schedule request properties with scope.
    internal partial interface IRoleEligibilityScheduleRequestPropertiesInternal

    {
        /// <summary>The approvalId of the role eligibility schedule request.</summary>
        string ApprovalId { get; set; }
        /// <summary>
        /// The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName]
        /// StringEqualsIgnoreCase 'foo_storage_container'
        /// </summary>
        string Condition { get; set; }
        /// <summary>Version of the condition. Currently accepted value is '2.0'</summary>
        string ConditionVersion { get; set; }
        /// <summary>DateTime when role eligibility schedule request was created</summary>
        global::System.DateTime? CreatedOn { get; set; }
        /// <summary>Id of the principal</summary>
        string ExpandedPropertiesPrincipalId { get; set; }
        /// <summary>Type of the principal</summary>
        string ExpandedPropertiesPrincipalType { get; set; }
        /// <summary>Id of the role definition</summary>
        string ExpandedPropertiesRoleDefinitionId { get; set; }
        /// <summary>Additional properties of principal, scope and role definition</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedProperties ExpandedProperty { get; set; }
        /// <summary>Details of the principal</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesPrincipal ExpandedPropertyPrincipal { get; set; }
        /// <summary>Details of role definition</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesRoleDefinition ExpandedPropertyRoleDefinition { get; set; }
        /// <summary>Details of the resource scope</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesScope ExpandedPropertyScope { get; set; }
        /// <summary>Duration of the role eligibility schedule in TimeSpan.</summary>
        string ExpirationDuration { get; set; }
        /// <summary>End DateTime of the role eligibility schedule.</summary>
        global::System.DateTime? ExpirationEndDateTime { get; set; }
        /// <summary>Type of the role eligibility schedule expiration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Type? ExpirationType { get; set; }
        /// <summary>Justification for the role eligibility</summary>
        string Justification { get; set; }
        /// <summary>Display name of the principal</summary>
        string PrincipalDisplayName { get; set; }
        /// <summary>Email id of the principal</summary>
        string PrincipalEmail { get; set; }
        /// <summary>The principal ID.</summary>
        string PrincipalId { get; set; }
        /// <summary>The principal type of the assigned principal ID.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.PrincipalType? PrincipalType { get; set; }
        /// <summary>
        /// The type of the role assignment schedule request. Eg: SelfActivate, AdminAssign etc
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RequestType RequestType { get; set; }
        /// <summary>Id of the user who created this request</summary>
        string RequestorId { get; set; }
        /// <summary>Display name of the role definition</summary>
        string RoleDefinitionDisplayName { get; set; }
        /// <summary>The role definition ID.</summary>
        string RoleDefinitionId { get; set; }
        /// <summary>Type of the role definition</summary>
        string RoleDefinitionType { get; set; }
        /// <summary>Schedule info of the role eligibility schedule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfo ScheduleInfo { get; set; }
        /// <summary>Expiration of the role eligibility schedule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration ScheduleInfoExpiration { get; set; }
        /// <summary>Start DateTime of the role eligibility schedule.</summary>
        global::System.DateTime? ScheduleInfoStartDateTime { get; set; }
        /// <summary>The role eligibility schedule request scope.</summary>
        string Scope { get; set; }
        /// <summary>Display name of the resource</summary>
        string ScopeDisplayName { get; set; }
        /// <summary>Scope id of the resource</summary>
        string ScopeId { get; set; }
        /// <summary>Type of the resource</summary>
        string ScopeType { get; set; }
        /// <summary>The status of the role eligibility schedule request.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Status? Status { get; set; }
        /// <summary>
        /// The resultant role eligibility schedule id or the role eligibility schedule id being updated
        /// </summary>
        string TargetRoleEligibilityScheduleId { get; set; }
        /// <summary>The role eligibility schedule instance id being updated</summary>
        string TargetRoleEligibilityScheduleInstanceId { get; set; }
        /// <summary>Ticket Info of the role eligibility</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesTicketInfo TicketInfo { get; set; }
        /// <summary>Ticket number for the role eligibility</summary>
        string TicketInfoTicketNumber { get; set; }
        /// <summary>Ticket system name for the role eligibility</summary>
        string TicketInfoTicketSystem { get; set; }

    }
}