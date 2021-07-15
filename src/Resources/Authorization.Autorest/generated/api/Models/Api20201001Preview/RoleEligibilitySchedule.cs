namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Extensions;

    /// <summary>Role eligibility schedule</summary>
    public partial class RoleEligibilitySchedule :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedule,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInternal
    {

        /// <summary>
        /// The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName]
        /// StringEqualsIgnoreCase 'foo_storage_container'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string Condition { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).Condition; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).Condition = value ?? null; }

        /// <summary>Version of the condition. Currently accepted value is '2.0'</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ConditionVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).ConditionVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).ConditionVersion = value ?? null; }

        /// <summary>DateTime when role eligibility schedule was created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public global::System.DateTime? CreatedOn { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).CreatedOn; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).CreatedOn = value ?? default(global::System.DateTime); }

        /// <summary>End DateTime when role eligibility schedule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public global::System.DateTime? EndDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).EndDateTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).EndDateTime = value ?? default(global::System.DateTime); }

        /// <summary>Id of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ExpandedPropertiesPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).ExpandedPropertiesPrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).ExpandedPropertiesPrincipalId = value ?? null; }

        /// <summary>Type of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ExpandedPropertiesPrincipalType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).ExpandedPropertiesPrincipalType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).ExpandedPropertiesPrincipalType = value ?? null; }

        /// <summary>Id of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ExpandedPropertiesRoleDefinitionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).ExpandedPropertiesRoleDefinitionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).ExpandedPropertiesRoleDefinitionId = value ?? null; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The role eligibility schedule Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Membership type of the role eligibility schedule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.MemberType? MemberType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).MemberType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).MemberType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.MemberType)""); }

        /// <summary>Internal Acessors for ExpandedProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedProperties Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInternal.ExpandedProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).ExpandedProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).ExpandedProperty = value; }

        /// <summary>Internal Acessors for ExpandedPropertyPrincipal</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesPrincipal Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInternal.ExpandedPropertyPrincipal { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).ExpandedPropertyPrincipal; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).ExpandedPropertyPrincipal = value; }

        /// <summary>Internal Acessors for ExpandedPropertyRoleDefinition</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesRoleDefinition Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInternal.ExpandedPropertyRoleDefinition { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).ExpandedPropertyRoleDefinition; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).ExpandedPropertyRoleDefinition = value; }

        /// <summary>Internal Acessors for ExpandedPropertyScope</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IExpandedPropertiesScope Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInternal.ExpandedPropertyScope { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).ExpandedPropertyScope; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).ExpandedPropertyScope = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleProperties Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleEligibilityScheduleProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The role eligibility schedule name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Display name of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string PrincipalDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).PrincipalDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).PrincipalDisplayName = value ?? null; }

        /// <summary>Email id of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string PrincipalEmail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).PrincipalEmail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).PrincipalEmail = value ?? null; }

        /// <summary>The principal ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string PrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).PrincipalId = value ?? null; }

        /// <summary>The principal type of the assigned principal ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.PrincipalType? PrincipalType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).PrincipalType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).PrincipalType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.PrincipalType)""); }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleProperties _property;

        /// <summary>role eligibility schedule properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleEligibilityScheduleProperties()); set => this._property = value; }

        /// <summary>
        /// The id of roleEligibilityScheduleRequest used to create this roleAssignmentSchedule
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string RequestId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).RoleEligibilityScheduleRequestId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).RoleEligibilityScheduleRequestId = value ?? null; }

        /// <summary>Display name of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string RoleDefinitionDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).RoleDefinitionDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).RoleDefinitionDisplayName = value ?? null; }

        /// <summary>The role definition ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string RoleDefinitionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).RoleDefinitionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).RoleDefinitionId = value ?? null; }

        /// <summary>Type of the role definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string RoleDefinitionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).RoleDefinitionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).RoleDefinitionType = value ?? null; }

        /// <summary>The role eligibility schedule scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string Scope { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).Scope; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).Scope = value ?? null; }

        /// <summary>Display name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ScopeDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).ScopeDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).ScopeDisplayName = value ?? null; }

        /// <summary>Scope id of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ScopeId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).ScopeId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).ScopeId = value ?? null; }

        /// <summary>Type of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ScopeType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).ScopeType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).ScopeType = value ?? null; }

        /// <summary>Start DateTime when role eligibility schedule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public global::System.DateTime? StartDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).StartDateTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).StartDateTime = value ?? default(global::System.DateTime); }

        /// <summary>The status of the role eligibility schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Status? Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).Status = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Status)""); }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The role eligibility schedule type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>DateTime when role eligibility schedule was modified</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public global::System.DateTime? UpdatedOn { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).UpdatedOn; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilitySchedulePropertiesInternal)Property).UpdatedOn = value ?? default(global::System.DateTime); }

        /// <summary>Creates an new <see cref="RoleEligibilitySchedule" /> instance.</summary>
        public RoleEligibilitySchedule()
        {

        }
    }
    /// Role eligibility schedule
    public partial interface IRoleEligibilitySchedule :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.IJsonSerializable
    {
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
        /// <summary>DateTime when role eligibility schedule was created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"DateTime when role eligibility schedule was created",
        SerializedName = @"createdOn",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedOn { get; set; }
        /// <summary>End DateTime when role eligibility schedule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"End DateTime when role eligibility schedule",
        SerializedName = @"endDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndDateTime { get; set; }
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
        /// <summary>The role eligibility schedule Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The role eligibility schedule Id.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>Membership type of the role eligibility schedule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Membership type of the role eligibility schedule",
        SerializedName = @"memberType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.MemberType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.MemberType? MemberType { get; set; }
        /// <summary>The role eligibility schedule name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The role eligibility schedule name.",
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
        ReadOnly = false,
        Description = @"The principal type of the assigned principal ID.",
        SerializedName = @"principalType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.PrincipalType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.PrincipalType? PrincipalType { get; set; }
        /// <summary>
        /// The id of roleEligibilityScheduleRequest used to create this roleAssignmentSchedule
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The id of roleEligibilityScheduleRequest used to create this roleAssignmentSchedule",
        SerializedName = @"roleEligibilityScheduleRequestId",
        PossibleTypes = new [] { typeof(string) })]
        string RequestId { get; set; }
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
        /// <summary>The role eligibility schedule scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The role eligibility schedule scope.",
        SerializedName = @"scope",
        PossibleTypes = new [] { typeof(string) })]
        string Scope { get; set; }
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
        /// <summary>Start DateTime when role eligibility schedule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Start DateTime when role eligibility schedule",
        SerializedName = @"startDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartDateTime { get; set; }
        /// <summary>The status of the role eligibility schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The status of the role eligibility schedule.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Status) })]
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Status? Status { get; set; }
        /// <summary>The role eligibility schedule type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The role eligibility schedule type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }
        /// <summary>DateTime when role eligibility schedule was modified</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"DateTime when role eligibility schedule was modified",
        SerializedName = @"updatedOn",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? UpdatedOn { get; set; }

    }
    /// Role eligibility schedule
    internal partial interface IRoleEligibilityScheduleInternal

    {
        /// <summary>
        /// The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName]
        /// StringEqualsIgnoreCase 'foo_storage_container'
        /// </summary>
        string Condition { get; set; }
        /// <summary>Version of the condition. Currently accepted value is '2.0'</summary>
        string ConditionVersion { get; set; }
        /// <summary>DateTime when role eligibility schedule was created</summary>
        global::System.DateTime? CreatedOn { get; set; }
        /// <summary>End DateTime when role eligibility schedule</summary>
        global::System.DateTime? EndDateTime { get; set; }
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
        /// <summary>The role eligibility schedule Id.</summary>
        string Id { get; set; }
        /// <summary>Membership type of the role eligibility schedule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.MemberType? MemberType { get; set; }
        /// <summary>The role eligibility schedule name.</summary>
        string Name { get; set; }
        /// <summary>Display name of the principal</summary>
        string PrincipalDisplayName { get; set; }
        /// <summary>Email id of the principal</summary>
        string PrincipalEmail { get; set; }
        /// <summary>The principal ID.</summary>
        string PrincipalId { get; set; }
        /// <summary>The principal type of the assigned principal ID.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.PrincipalType? PrincipalType { get; set; }
        /// <summary>role eligibility schedule properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleProperties Property { get; set; }
        /// <summary>
        /// The id of roleEligibilityScheduleRequest used to create this roleAssignmentSchedule
        /// </summary>
        string RequestId { get; set; }
        /// <summary>Display name of the role definition</summary>
        string RoleDefinitionDisplayName { get; set; }
        /// <summary>The role definition ID.</summary>
        string RoleDefinitionId { get; set; }
        /// <summary>Type of the role definition</summary>
        string RoleDefinitionType { get; set; }
        /// <summary>The role eligibility schedule scope.</summary>
        string Scope { get; set; }
        /// <summary>Display name of the resource</summary>
        string ScopeDisplayName { get; set; }
        /// <summary>Scope id of the resource</summary>
        string ScopeId { get; set; }
        /// <summary>Type of the resource</summary>
        string ScopeType { get; set; }
        /// <summary>Start DateTime when role eligibility schedule</summary>
        global::System.DateTime? StartDateTime { get; set; }
        /// <summary>The status of the role eligibility schedule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Status? Status { get; set; }
        /// <summary>The role eligibility schedule type.</summary>
        string Type { get; set; }
        /// <summary>DateTime when role eligibility schedule was modified</summary>
        global::System.DateTime? UpdatedOn { get; set; }

    }
}