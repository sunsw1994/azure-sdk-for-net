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
    /// Response body with a run identifier.
    /// </summary>
    public partial class CreateRunResponse
    {
        /// <summary>
        /// Initializes a new instance of the CreateRunResponse class.
        /// </summary>
        public CreateRunResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateRunResponse class.
        /// </summary>
        /// <param name="runId">Identifier of a run.</param>
        public CreateRunResponse(string runId)
        {
            RunId = runId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets identifier of a run.
        /// </summary>
        [JsonProperty(PropertyName = "runId")]
        public string RunId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RunId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RunId");
            }
        }
    }
}
