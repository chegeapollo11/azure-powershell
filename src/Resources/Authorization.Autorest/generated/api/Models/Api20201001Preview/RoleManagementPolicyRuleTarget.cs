namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Extensions;

    /// <summary>The role management policy rule target.</summary>
    public partial class RoleManagementPolicyRuleTarget :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleTarget,
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRuleTargetInternal
    {

        /// <summary>Backing field for <see cref="Caller" /> property.</summary>
        private string _caller;

        /// <summary>The caller of the setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string Caller { get => this._caller; set => this._caller = value; }

        /// <summary>Backing field for <see cref="EnforcedSetting" /> property.</summary>
        private string[] _enforcedSetting;

        /// <summary>The list of enforced settings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string[] EnforcedSetting { get => this._enforcedSetting; set => this._enforcedSetting = value; }

        /// <summary>Backing field for <see cref="InheritableSetting" /> property.</summary>
        private string[] _inheritableSetting;

        /// <summary>The list of inheritable settings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string[] InheritableSetting { get => this._inheritableSetting; set => this._inheritableSetting = value; }

        /// <summary>Backing field for <see cref="Level" /> property.</summary>
        private string _level;

        /// <summary>The assignment level to which it is applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string Level { get => this._level; set => this._level = value; }

        /// <summary>Backing field for <see cref="Operation" /> property.</summary>
        private string[] _operation;

        /// <summary>The type of operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string[] Operation { get => this._operation; set => this._operation = value; }

        /// <summary>Backing field for <see cref="TargetObject" /> property.</summary>
        private string[] _targetObject;

        /// <summary>The list of target objects.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Origin(Microsoft.Azure.PowerShell.Cmdlets.Authorization.PropertyOrigin.Owned)]
        public string[] TargetObject { get => this._targetObject; set => this._targetObject = value; }

        /// <summary>Creates an new <see cref="RoleManagementPolicyRuleTarget" /> instance.</summary>
        public RoleManagementPolicyRuleTarget()
        {

        }
    }
    /// The role management policy rule target.
    public partial interface IRoleManagementPolicyRuleTarget :
        Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.IJsonSerializable
    {
        /// <summary>The caller of the setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The caller of the setting.",
        SerializedName = @"caller",
        PossibleTypes = new [] { typeof(string) })]
        string Caller { get; set; }
        /// <summary>The list of enforced settings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of enforced settings.",
        SerializedName = @"enforcedSettings",
        PossibleTypes = new [] { typeof(string) })]
        string[] EnforcedSetting { get; set; }
        /// <summary>The list of inheritable settings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of inheritable settings.",
        SerializedName = @"inheritableSettings",
        PossibleTypes = new [] { typeof(string) })]
        string[] InheritableSetting { get; set; }
        /// <summary>The assignment level to which it is applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The assignment level to which it is applied.",
        SerializedName = @"level",
        PossibleTypes = new [] { typeof(string) })]
        string Level { get; set; }
        /// <summary>The type of operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of operation.",
        SerializedName = @"operations",
        PossibleTypes = new [] { typeof(string) })]
        string[] Operation { get; set; }
        /// <summary>The list of target objects.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Authorization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of target objects.",
        SerializedName = @"targetObjects",
        PossibleTypes = new [] { typeof(string) })]
        string[] TargetObject { get; set; }

    }
    /// The role management policy rule target.
    internal partial interface IRoleManagementPolicyRuleTargetInternal

    {
        /// <summary>The caller of the setting.</summary>
        string Caller { get; set; }
        /// <summary>The list of enforced settings.</summary>
        string[] EnforcedSetting { get; set; }
        /// <summary>The list of inheritable settings.</summary>
        string[] InheritableSetting { get; set; }
        /// <summary>The assignment level to which it is applied.</summary>
        string Level { get; set; }
        /// <summary>The type of operation.</summary>
        string[] Operation { get; set; }
        /// <summary>The list of target objects.</summary>
        string[] TargetObject { get; set; }

    }
}