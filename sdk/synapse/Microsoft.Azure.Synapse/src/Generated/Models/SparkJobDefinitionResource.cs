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
    using System.Linq;

    /// <summary>
    /// Spark job definition resource type.
    /// </summary>
    public partial class SparkJobDefinitionResource : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the SparkJobDefinitionResource class.
        /// </summary>
        public SparkJobDefinitionResource()
        {
            Properties = new SparkJobDefinition();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SparkJobDefinitionResource class.
        /// </summary>
        /// <param name="properties">Properties of spark job
        /// definition.</param>
        /// <param name="id">The resource identifier.</param>
        /// <param name="name">The resource name.</param>
        /// <param name="type">The resource type.</param>
        /// <param name="etag">Etag identifies change in the resource.</param>
        public SparkJobDefinitionResource(SparkJobDefinition properties, string id = default(string), string name = default(string), string type = default(string), string etag = default(string))
            : base(id, name, type, etag)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets properties of spark job definition.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public SparkJobDefinition Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Properties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Properties");
            }
            if (Properties != null)
            {
                Properties.Validate();
            }
        }
    }
}
