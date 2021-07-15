namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Extensions;

    /// <summary>The detail of a user.</summary>
    public partial class UserSet :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IUserSet,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IUserSetInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>The description of the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The object id of the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="IsBackup" /> property.</summary>
        private bool? _isBackup;

        /// <summary>The value indicating whether the user is a backup fallback approver</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public bool? IsBackup { get => this._isBackup; set => this._isBackup = value; }

        /// <summary>Backing field for <see cref="UserType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.UserType? _userType;

        /// <summary>The type of user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.UserType? UserType { get => this._userType; set => this._userType = value; }

        /// <summary>Creates an new <see cref="UserSet" /> instance.</summary>
        public UserSet()
        {

        }
    }
    /// The detail of a user.
    public partial interface IUserSet :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.IJsonSerializable
    {
        /// <summary>The description of the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The description of the user.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The object id of the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The object id of the user.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The value indicating whether the user is a backup fallback approver</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value indicating whether the user is a backup fallback approver",
        SerializedName = @"isBackup",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsBackup { get; set; }
        /// <summary>The type of user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of user.",
        SerializedName = @"userType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.UserType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.UserType? UserType { get; set; }

    }
    /// The detail of a user.
    internal partial interface IUserSetInternal

    {
        /// <summary>The description of the user.</summary>
        string Description { get; set; }
        /// <summary>The object id of the user.</summary>
        string Id { get; set; }
        /// <summary>The value indicating whether the user is a backup fallback approver</summary>
        bool? IsBackup { get; set; }
        /// <summary>The type of user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.UserType? UserType { get; set; }

    }
}