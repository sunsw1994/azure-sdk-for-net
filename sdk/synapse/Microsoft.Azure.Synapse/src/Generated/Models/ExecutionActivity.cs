// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Base class for all execution activities.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Execution")]
    public partial class ExecutionActivity : Activity
    {
        /// <summary>
        /// Initializes a new instance of the ExecutionActivity class.
        /// </summary>
        public ExecutionActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExecutionActivity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Activity description.</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="userProperties">Activity user properties.</param>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="policy">Activity policy.</param>
        public ExecutionActivity(string name, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), IList<UserProperty> userProperties = default(IList<UserProperty>), LinkedServiceReference linkedServiceName = default(LinkedServiceReference), ActivityPolicy policy = default(ActivityPolicy))
            : base(name, additionalProperties, description, dependsOn, userProperties)
        {
            LinkedServiceName = linkedServiceName;
            Policy = policy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets linked service reference.
        /// </summary>
        [JsonProperty(PropertyName = "linkedServiceName")]
        public LinkedServiceReference LinkedServiceName { get; set; }

        /// <summary>
        /// Gets or sets activity policy.
        /// </summary>
        [JsonProperty(PropertyName = "policy")]
        public ActivityPolicy Policy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (LinkedServiceName != null)
            {
                LinkedServiceName.Validate();
            }
            if (Policy != null)
            {
                Policy.Validate();
            }
        }
    }
}
