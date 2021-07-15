namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Extensions;

    /// <summary>The approval stage.</summary>
    public partial class ApprovalStage :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IApprovalStage,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IApprovalStageInternal
    {

        /// <summary>Backing field for <see cref="EscalationApprover" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IUserSet[] _escalationApprover;

        /// <summary>The escalation approver of the request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IUserSet[] EscalationApprover { get => this._escalationApprover; set => this._escalationApprover = value; }

        /// <summary>Backing field for <see cref="EscalationTimeInMinute" /> property.</summary>
        private int? _escalationTimeInMinute;

        /// <summary>
        /// The time in minutes when the approval request would be escalated if the primary approver does not approves.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public int? EscalationTimeInMinute { get => this._escalationTimeInMinute; set => this._escalationTimeInMinute = value; }

        /// <summary>Backing field for <see cref="IsApproverJustificationRequired" /> property.</summary>
        private bool? _isApproverJustificationRequired;

        /// <summary>Determine whether approver need to provide justification for his decision.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public bool? IsApproverJustificationRequired { get => this._isApproverJustificationRequired; set => this._isApproverJustificationRequired = value; }

        /// <summary>Backing field for <see cref="IsEscalationEnabled" /> property.</summary>
        private bool? _isEscalationEnabled;

        /// <summary>The value determine whether escalation feature is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public bool? IsEscalationEnabled { get => this._isEscalationEnabled; set => this._isEscalationEnabled = value; }

        /// <summary>Backing field for <see cref="PrimaryApprover" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IUserSet[] _primaryApprover;

        /// <summary>The primary approver of the request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IUserSet[] PrimaryApprover { get => this._primaryApprover; set => this._primaryApprover = value; }

        /// <summary>Backing field for <see cref="TimeOutInDay" /> property.</summary>
        private int? _timeOutInDay;

        /// <summary>The time in days when approval request would be timed out.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public int? TimeOutInDay { get => this._timeOutInDay; set => this._timeOutInDay = value; }

        /// <summary>Creates an new <see cref="ApprovalStage" /> instance.</summary>
        public ApprovalStage()
        {

        }
    }
    /// The approval stage.
    public partial interface IApprovalStage :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.IJsonSerializable
    {
        /// <summary>The escalation approver of the request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The escalation approver of the request.",
        SerializedName = @"escalationApprovers",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IUserSet) })]
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IUserSet[] EscalationApprover { get; set; }
        /// <summary>
        /// The time in minutes when the approval request would be escalated if the primary approver does not approves.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The time in minutes when the approval request would be escalated if the primary approver does not approves.",
        SerializedName = @"escalationTimeInMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int? EscalationTimeInMinute { get; set; }
        /// <summary>Determine whether approver need to provide justification for his decision.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Determine whether approver need to provide justification for his decision.",
        SerializedName = @"isApproverJustificationRequired",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsApproverJustificationRequired { get; set; }
        /// <summary>The value determine whether escalation feature is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value determine whether escalation feature is enabled.",
        SerializedName = @"isEscalationEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsEscalationEnabled { get; set; }
        /// <summary>The primary approver of the request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The primary approver of the request.",
        SerializedName = @"primaryApprovers",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IUserSet) })]
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IUserSet[] PrimaryApprover { get; set; }
        /// <summary>The time in days when approval request would be timed out.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The time in days when approval request would be timed out.",
        SerializedName = @"approvalStageTimeOutInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? TimeOutInDay { get; set; }

    }
    /// The approval stage.
    internal partial interface IApprovalStageInternal

    {
        /// <summary>The escalation approver of the request.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IUserSet[] EscalationApprover { get; set; }
        /// <summary>
        /// The time in minutes when the approval request would be escalated if the primary approver does not approves.
        /// </summary>
        int? EscalationTimeInMinute { get; set; }
        /// <summary>Determine whether approver need to provide justification for his decision.</summary>
        bool? IsApproverJustificationRequired { get; set; }
        /// <summary>The value determine whether escalation feature is enabled.</summary>
        bool? IsEscalationEnabled { get; set; }
        /// <summary>The primary approver of the request.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IUserSet[] PrimaryApprover { get; set; }
        /// <summary>The time in days when approval request would be timed out.</summary>
        int? TimeOutInDay { get; set; }

    }
}