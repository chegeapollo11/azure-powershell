namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Extensions;

    /// <summary>Role Eligibility schedule request</summary>
    public partial class RoleEligibilityScheduleRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequest,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestInternal
    {

        /// <summary>The approvalId of the role eligibility schedule request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ApprovalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ApprovalId; }

        /// <summary>
        /// The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName]
        /// StringEqualsIgnoreCase 'foo_storage_container'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string Condition { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).Condition; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).Condition = value ?? null; }

        /// <summary>Version of the condition. Currently accepted value is '2.0'</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ConditionVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ConditionVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ConditionVersion = value ?? null; }

        /// <summary>DateTime when role eligibility schedule request was created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public global::System.DateTime? CreatedOn { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).CreatedOn; }

        /// <summary>Id of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ExpandedPropertiesPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ExpandedPropertiesPrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ExpandedPropertiesPrincipalId = value ?? null; }

        /// <summary>Type of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ExpandedPropertiesPrincipalType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ExpandedPropertiesPrincipalType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ExpandedPropertiesPrincipalType = value ?? null; }

        /// <summary>Id of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ExpandedPropertiesRoleDefinitionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ExpandedPropertiesRoleDefinitionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ExpandedPropertiesRoleDefinitionId = value ?? null; }

        /// <summary>Duration of the role eligibility schedule in TimeSpan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ExpirationDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ExpirationDuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ExpirationDuration = value ?? null; }

        /// <summary>End DateTime of the role eligibility schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public global::System.DateTime? ExpirationEndDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ExpirationEndDateTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ExpirationEndDateTime = value ?? default(global::System.DateTime); }

        /// <summary>Type of the role eligibility schedule expiration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Type? ExpirationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ExpirationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ExpirationType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Type)""); }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The role eligibility schedule request ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Justification for the role eligibility</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string Justification { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).Justification; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).Justification = value ?? null; }

        /// <summary>Internal Acessors for ApprovalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestInternal.ApprovalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ApprovalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ApprovalId = value; }

        /// <summary>Internal Acessors for CreatedOn</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestInternal.CreatedOn { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).CreatedOn; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).CreatedOn = value; }

        /// <summary>Internal Acessors for ExpandedProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedProperties Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestInternal.ExpandedProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ExpandedProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ExpandedProperty = value; }

        /// <summary>Internal Acessors for ExpandedPropertyPrincipal</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesPrincipal Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestInternal.ExpandedPropertyPrincipal { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ExpandedPropertyPrincipal; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ExpandedPropertyPrincipal = value; }

        /// <summary>Internal Acessors for ExpandedPropertyRoleDefinition</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesRoleDefinition Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestInternal.ExpandedPropertyRoleDefinition { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ExpandedPropertyRoleDefinition; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ExpandedPropertyRoleDefinition = value; }

        /// <summary>Internal Acessors for ExpandedPropertyScope</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesScope Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestInternal.ExpandedPropertyScope { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ExpandedPropertyScope; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ExpandedPropertyScope = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for PrincipalType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.PrincipalType? Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestInternal.PrincipalType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).PrincipalType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).PrincipalType = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestProperties Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleEligibilityScheduleRequestProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for RequestorId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestInternal.RequestorId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).RequestorId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).RequestorId = value; }

        /// <summary>Internal Acessors for ScheduleInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfo Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestInternal.ScheduleInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ScheduleInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ScheduleInfo = value; }

        /// <summary>Internal Acessors for ScheduleInfoExpiration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestInternal.ScheduleInfoExpiration { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ScheduleInfoExpiration; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ScheduleInfoExpiration = value; }

        /// <summary>Internal Acessors for Scope</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestInternal.Scope { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).Scope; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).Scope = value; }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Status? Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).Status = value; }

        /// <summary>Internal Acessors for TicketInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesTicketInfo Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestInternal.TicketInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).TicketInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).TicketInfo = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The role eligibility schedule request name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Display name of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string PrincipalDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).PrincipalDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).PrincipalDisplayName = value ?? null; }

        /// <summary>Email id of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string PrincipalEmail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).PrincipalEmail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).PrincipalEmail = value ?? null; }

        /// <summary>The principal ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string PrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).PrincipalId = value ?? null; }

        /// <summary>The principal type of the assigned principal ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.PrincipalType? PrincipalType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).PrincipalType; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestProperties _property;

        /// <summary>Role eligibility schedule request properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleEligibilityScheduleRequestProperties()); set => this._property = value; }

        /// <summary>
        /// The type of the role assignment schedule request. Eg: SelfActivate, AdminAssign etc
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RequestType? RequestType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).RequestType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).RequestType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RequestType)""); }

        /// <summary>Id of the user who created this request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string RequestorId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).RequestorId; }

        /// <summary>Display name of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string RoleDefinitionDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).RoleDefinitionDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).RoleDefinitionDisplayName = value ?? null; }

        /// <summary>The role definition ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string RoleDefinitionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).RoleDefinitionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).RoleDefinitionId = value ?? null; }

        /// <summary>Type of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string RoleDefinitionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).RoleDefinitionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).RoleDefinitionType = value ?? null; }

        /// <summary>Start DateTime of the role eligibility schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public global::System.DateTime? ScheduleInfoStartDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ScheduleInfoStartDateTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ScheduleInfoStartDateTime = value ?? default(global::System.DateTime); }

        /// <summary>The role eligibility schedule request scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string Scope { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).Scope; }

        /// <summary>Display name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ScopeDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ScopeDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ScopeDisplayName = value ?? null; }

        /// <summary>Scope id of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ScopeId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ScopeId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ScopeId = value ?? null; }

        /// <summary>Type of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ScopeType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ScopeType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).ScopeType = value ?? null; }

        /// <summary>The status of the role eligibility schedule request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Status? Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).Status; }

        /// <summary>
        /// The resultant role eligibility schedule id or the role eligibility schedule id being updated
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string TargetRoleEligibilityScheduleId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).TargetRoleEligibilityScheduleId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).TargetRoleEligibilityScheduleId = value ?? null; }

        /// <summary>The role eligibility schedule instance id being updated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string TargetRoleEligibilityScheduleInstanceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).TargetRoleEligibilityScheduleInstanceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).TargetRoleEligibilityScheduleInstanceId = value ?? null; }

        /// <summary>Ticket number for the role eligibility</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string TicketInfoTicketNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).TicketInfoTicketNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).TicketInfoTicketNumber = value ?? null; }

        /// <summary>Ticket system name for the role eligibility</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string TicketInfoTicketSystem { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).TicketInfoTicketSystem; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesInternal)Property).TicketInfoTicketSystem = value ?? null; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The role eligibility schedule request type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="RoleEligibilityScheduleRequest" /> instance.</summary>
        public RoleEligibilityScheduleRequest()
        {

        }
    }
    /// Role Eligibility schedule request
    public partial interface IRoleEligibilityScheduleRequest :
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
        /// <summary>The role eligibility schedule request ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The role eligibility schedule request ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>Justification for the role eligibility</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Justification for the role eligibility",
        SerializedName = @"justification",
        PossibleTypes = new [] { typeof(string) })]
        string Justification { get; set; }
        /// <summary>The role eligibility schedule request name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The role eligibility schedule request name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
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
        Required = false,
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
        Required = false,
        ReadOnly = false,
        Description = @"The type of the role assignment schedule request. Eg: SelfActivate, AdminAssign etc",
        SerializedName = @"requestType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RequestType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RequestType? RequestType { get; set; }
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
        Required = false,
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
        /// <summary>The role eligibility schedule request type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The role eligibility schedule request type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// Role Eligibility schedule request
    internal partial interface IRoleEligibilityScheduleRequestInternal

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
        /// <summary>The role eligibility schedule request ID.</summary>
        string Id { get; set; }
        /// <summary>Justification for the role eligibility</summary>
        string Justification { get; set; }
        /// <summary>The role eligibility schedule request name.</summary>
        string Name { get; set; }
        /// <summary>Display name of the principal</summary>
        string PrincipalDisplayName { get; set; }
        /// <summary>Email id of the principal</summary>
        string PrincipalEmail { get; set; }
        /// <summary>The principal ID.</summary>
        string PrincipalId { get; set; }
        /// <summary>The principal type of the assigned principal ID.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.PrincipalType? PrincipalType { get; set; }
        /// <summary>Role eligibility schedule request properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestProperties Property { get; set; }
        /// <summary>
        /// The type of the role assignment schedule request. Eg: SelfActivate, AdminAssign etc
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RequestType? RequestType { get; set; }
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
        /// <summary>The role eligibility schedule request type.</summary>
        string Type { get; set; }

    }
}