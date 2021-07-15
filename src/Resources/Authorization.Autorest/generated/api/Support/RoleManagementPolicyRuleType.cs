// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support
{

    /// <summary>The type of rule</summary>
    public partial struct RoleManagementPolicyRuleType :
        System.IEquatable<RoleManagementPolicyRuleType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RoleManagementPolicyRuleType RoleManagementPolicyApprovalRule = @"RoleManagementPolicyApprovalRule";

        public static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RoleManagementPolicyRuleType RoleManagementPolicyAuthenticationContextRule = @"RoleManagementPolicyAuthenticationContextRule";

        public static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RoleManagementPolicyRuleType RoleManagementPolicyEnablementRule = @"RoleManagementPolicyEnablementRule";

        public static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RoleManagementPolicyRuleType RoleManagementPolicyExpirationRule = @"RoleManagementPolicyExpirationRule";

        public static Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RoleManagementPolicyRuleType RoleManagementPolicyNotificationRule = @"RoleManagementPolicyNotificationRule";

        /// <summary>
        /// the value for an instance of the <see cref="RoleManagementPolicyRuleType" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to RoleManagementPolicyRuleType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RoleManagementPolicyRuleType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new RoleManagementPolicyRuleType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type RoleManagementPolicyRuleType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RoleManagementPolicyRuleType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type RoleManagementPolicyRuleType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is RoleManagementPolicyRuleType && Equals((RoleManagementPolicyRuleType)obj);
        }

        /// <summary>Returns hashCode for enum RoleManagementPolicyRuleType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>
        /// Creates an instance of the <see cref="RoleManagementPolicyRuleType" Enum class./>
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private RoleManagementPolicyRuleType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for RoleManagementPolicyRuleType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to RoleManagementPolicyRuleType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RoleManagementPolicyRuleType" />.</param>

        public static implicit operator RoleManagementPolicyRuleType(string value)
        {
            return new RoleManagementPolicyRuleType(value);
        }

        /// <summary>Implicit operator to convert RoleManagementPolicyRuleType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="RoleManagementPolicyRuleType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RoleManagementPolicyRuleType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum RoleManagementPolicyRuleType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RoleManagementPolicyRuleType e1, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RoleManagementPolicyRuleType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum RoleManagementPolicyRuleType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RoleManagementPolicyRuleType e1, Microsoft.Azure.PowerShell.Cmdlets.Authorization.Support.RoleManagementPolicyRuleType e2)
        {
            return e2.Equals(e1);
        }
    }
}