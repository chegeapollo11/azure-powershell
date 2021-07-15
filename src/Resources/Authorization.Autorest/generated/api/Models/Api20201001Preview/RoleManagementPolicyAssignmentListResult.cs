namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Extensions;

    /// <summary>Role management policy assignment list operation result.</summary>
    public partial class RoleManagementPolicyAssignmentListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentListResult,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The URL to use for getting the next set of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignment[] _value;

        /// <summary>Role management policy assignment list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignment[] Value { get => this._value; set => this._value = value; }

        /// <summary>
        /// Creates an new <see cref="RoleManagementPolicyAssignmentListResult" /> instance.
        /// </summary>
        public RoleManagementPolicyAssignmentListResult()
        {

        }
    }
    /// Role management policy assignment list operation result.
    public partial interface IRoleManagementPolicyAssignmentListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.IJsonSerializable
    {
        /// <summary>The URL to use for getting the next set of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URL to use for getting the next set of results.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Role management policy assignment list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Role management policy assignment list.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignment) })]
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignment[] Value { get; set; }

    }
    /// Role management policy assignment list operation result.
    internal partial interface IRoleManagementPolicyAssignmentListResultInternal

    {
        /// <summary>The URL to use for getting the next set of results.</summary>
        string NextLink { get; set; }
        /// <summary>Role management policy assignment list.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignment[] Value { get; set; }

    }
}