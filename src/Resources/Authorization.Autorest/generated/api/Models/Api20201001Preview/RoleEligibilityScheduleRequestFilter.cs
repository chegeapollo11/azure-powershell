namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Extensions;

    /// <summary>Role eligibility schedule request filter</summary>
    public partial class RoleEligibilityScheduleRequestFilter :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestFilter,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestFilterInternal
    {

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>Returns role eligibility requests of the specific principal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; set => this._principalId = value; }

        /// <summary>Backing field for <see cref="RequestorId" /> property.</summary>
        private string _requestorId;

        /// <summary>Returns role eligibility requests created by specific principal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string RequestorId { get => this._requestorId; set => this._requestorId = value; }

        /// <summary>Backing field for <see cref="RoleDefinitionId" /> property.</summary>
        private string _roleDefinitionId;

        /// <summary>Returns role eligibility requests of the specific role definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string RoleDefinitionId { get => this._roleDefinitionId; set => this._roleDefinitionId = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Returns role eligibility requests of specific status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="RoleEligibilityScheduleRequestFilter" /> instance.</summary>
        public RoleEligibilityScheduleRequestFilter()
        {

        }
    }
    /// Role eligibility schedule request filter
    public partial interface IRoleEligibilityScheduleRequestFilter :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.IJsonSerializable
    {
        /// <summary>Returns role eligibility requests of the specific principal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Returns role eligibility requests of the specific principal.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get; set; }
        /// <summary>Returns role eligibility requests created by specific principal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Returns role eligibility requests created by specific principal.",
        SerializedName = @"requestorId",
        PossibleTypes = new [] { typeof(string) })]
        string RequestorId { get; set; }
        /// <summary>Returns role eligibility requests of the specific role definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Returns role eligibility requests of the specific role definition.",
        SerializedName = @"roleDefinitionId",
        PossibleTypes = new [] { typeof(string) })]
        string RoleDefinitionId { get; set; }
        /// <summary>Returns role eligibility requests of specific status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Returns role eligibility requests of specific status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }

    }
    /// Role eligibility schedule request filter
    internal partial interface IRoleEligibilityScheduleRequestFilterInternal

    {
        /// <summary>Returns role eligibility requests of the specific principal.</summary>
        string PrincipalId { get; set; }
        /// <summary>Returns role eligibility requests created by specific principal.</summary>
        string RequestorId { get; set; }
        /// <summary>Returns role eligibility requests of the specific role definition.</summary>
        string RoleDefinitionId { get; set; }
        /// <summary>Returns role eligibility requests of specific status.</summary>
        string Status { get; set; }

    }
}