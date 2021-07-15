namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Extensions;

    /// <summary>Schedule info of the role eligibility schedule</summary>
    public partial class RoleEligibilityScheduleRequestPropertiesScheduleInfo :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfo,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoInternal
    {

        /// <summary>Backing field for <see cref="Expiration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration _expiration;

        /// <summary>Expiration of the role eligibility schedule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration Expiration { get => (this._expiration = this._expiration ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration()); set => this._expiration = value; }

        /// <summary>Duration of the role eligibility schedule in TimeSpan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public string ExpirationDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpirationInternal)Expiration).Duration; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpirationInternal)Expiration).Duration = value ?? null; }

        /// <summary>End DateTime of the role eligibility schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public global::System.DateTime? ExpirationEndDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpirationInternal)Expiration).EndDateTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpirationInternal)Expiration).EndDateTime = value ?? default(global::System.DateTime); }

        /// <summary>Type of the role eligibility schedule expiration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Type? ExpirationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpirationInternal)Expiration).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpirationInternal)Expiration).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Type)""); }

        /// <summary>Internal Acessors for Expiration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoInternal.Expiration { get => (this._expiration = this._expiration ?? new Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.RoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration()); set { {_expiration = value;} } }

        /// <summary>Backing field for <see cref="StartDateTime" /> property.</summary>
        private global::System.DateTime? _startDateTime;

        /// <summary>Start DateTime of the role eligibility schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public global::System.DateTime? StartDateTime { get => this._startDateTime; set => this._startDateTime = value; }

        /// <summary>
        /// Creates an new <see cref="RoleEligibilityScheduleRequestPropertiesScheduleInfo" /> instance.
        /// </summary>
        public RoleEligibilityScheduleRequestPropertiesScheduleInfo()
        {

        }
    }
    /// Schedule info of the role eligibility schedule
    public partial interface IRoleEligibilityScheduleRequestPropertiesScheduleInfo :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.IJsonSerializable
    {
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
        /// <summary>Start DateTime of the role eligibility schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Start DateTime of the role eligibility schedule.",
        SerializedName = @"startDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartDateTime { get; set; }

    }
    /// Schedule info of the role eligibility schedule
    internal partial interface IRoleEligibilityScheduleRequestPropertiesScheduleInfoInternal

    {
        /// <summary>Expiration of the role eligibility schedule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration Expiration { get; set; }
        /// <summary>Duration of the role eligibility schedule in TimeSpan.</summary>
        string ExpirationDuration { get; set; }
        /// <summary>End DateTime of the role eligibility schedule.</summary>
        global::System.DateTime? ExpirationEndDateTime { get; set; }
        /// <summary>Type of the role eligibility schedule expiration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.Type? ExpirationType { get; set; }
        /// <summary>Start DateTime of the role eligibility schedule.</summary>
        global::System.DateTime? StartDateTime { get; set; }

    }
}