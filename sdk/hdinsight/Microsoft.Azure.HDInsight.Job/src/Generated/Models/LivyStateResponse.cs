// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.HDInsight.Job.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LivyStateResponse
    {
        /// <summary>
        /// Initializes a new instance of the LivyStateResponse class.
        /// </summary>
        public LivyStateResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LivyStateResponse class.
        /// </summary>
        public LivyStateResponse(int? id = default(int?), string state = default(string))
        {
            Id = id;
            State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

    }
}
