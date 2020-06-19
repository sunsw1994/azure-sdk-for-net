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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Linked service reference type.
    /// </summary>
    public partial class LinkedServiceReference
    {
        /// <summary>
        /// Initializes a new instance of the LinkedServiceReference class.
        /// </summary>
        public LinkedServiceReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LinkedServiceReference class.
        /// </summary>
        /// <param name="referenceName">Reference LinkedService name.</param>
        /// <param name="parameters">Arguments for LinkedService.</param>
        public LinkedServiceReference(string referenceName, IDictionary<string, object> parameters = default(IDictionary<string, object>))
        {
            ReferenceName = referenceName;
            Parameters = parameters;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for LinkedServiceReference class.
        /// </summary>
        static LinkedServiceReference()
        {
            Type = "LinkedServiceReference";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets reference LinkedService name.
        /// </summary>
        [JsonProperty(PropertyName = "referenceName")]
        public string ReferenceName { get; set; }

        /// <summary>
        /// Gets or sets arguments for LinkedService.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IDictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// Linked service reference type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public static string Type { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ReferenceName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ReferenceName");
            }
        }
    }
}
