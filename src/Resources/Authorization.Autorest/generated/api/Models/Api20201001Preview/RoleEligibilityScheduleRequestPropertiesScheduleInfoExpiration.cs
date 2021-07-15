namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Extensions;

    /// <summary>Expiration of the role eligibility schedule</summary>
    public partial class RoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpirationInternal
    {

        /// <summary>Backing field for <see cref="Duration" /> property.</summary>
        private string _duration;

        /// <summary>Duration of the role eligibility schedule in TimeSpan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string Duration { get => this._duration; set => this._duration = value; }

        /// <summary>Backing field for <see cref="EndDateTime" /> property.</summary>
        private global::System.DateTime? _endDateTime;

        /// <summary>End DateTime of the role eligibility schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public global::System.DateTime? EndDateTime { get => this._endDateTime; set => this._endDateTime = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Type? _type;

        /// <summary>Type of the role eligibility schedule expiration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Type? Type { get => this._type; set => this._type = value; }

        /// <summary>
        /// Creates an new <see cref="RoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration" /> instance.
        /// </summary>
        public RoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration()
        {

        }
    }
    /// Expiration of the role eligibility schedule
    public partial interface IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.IJsonSerializable
    {
        /// <summary>Duration of the role eligibility schedule in TimeSpan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Duration of the role eligibility schedule in TimeSpan.",
        SerializedName = @"duration",
        PossibleTypes = new [] { typeof(string) })]
        string Duration { get; set; }
        /// <summary>End DateTime of the role eligibility schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"End DateTime of the role eligibility schedule.",
        SerializedName = @"endDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndDateTime { get; set; }
        /// <summary>Type of the role eligibility schedule expiration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the role eligibility schedule expiration",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Type) })]
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Type? Type { get; set; }

    }
    /// Expiration of the role eligibility schedule
    internal partial interface IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpirationInternal

    {
        /// <summary>Duration of the role eligibility schedule in TimeSpan.</summary>
        string Duration { get; set; }
        /// <summary>End DateTime of the role eligibility schedule.</summary>
        global::System.DateTime? EndDateTime { get; set; }
        /// <summary>Type of the role eligibility schedule expiration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Type? Type { get; set; }

    }
}