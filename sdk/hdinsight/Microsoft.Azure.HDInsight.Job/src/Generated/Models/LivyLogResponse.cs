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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class LivyLogResponse
    {
        /// <summary>
        /// Initializes a new instance of the LivyLogResponse class.
        /// </summary>
        public LivyLogResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LivyLogResponse class.
        /// </summary>
        public LivyLogResponse(int? id = default(int?), int? fromProperty = default(int?), int? size = default(int?), IList<string> log = default(IList<string>))
        {
            Id = id;
            FromProperty = fromProperty;
            Size = size;
            Log = log;
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
        [JsonProperty(PropertyName = "from")]
        public int? FromProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public int? Size { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "log")]
        public IList<string> Log { get; set; }

    }
}
