// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifies Reboot related Scheduled Event related configurations.
    /// </summary>
    public partial class UserInitiatedReboot
    {
        /// <summary>
        /// Initializes a new instance of the UserInitiatedReboot class.
        /// </summary>
        public UserInitiatedReboot()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserInitiatedReboot class.
        /// </summary>
        /// <param name="automaticallyApprove">Specifies Reboot Scheduled Event
        /// related configurations.</param>
        public UserInitiatedReboot(bool? automaticallyApprove = default(bool?))
        {
            AutomaticallyApprove = automaticallyApprove;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies Reboot Scheduled Event related
        /// configurations.
        /// </summary>
        [JsonProperty(PropertyName = "automaticallyApprove")]
        public bool? AutomaticallyApprove { get; set; }

    }
}
