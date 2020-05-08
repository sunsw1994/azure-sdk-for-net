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

    public partial class LivyListSessionResponse
    {
        /// <summary>
        /// Initializes a new instance of the LivyListSessionResponse class.
        /// </summary>
        public LivyListSessionResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LivyListSessionResponse class.
        /// </summary>
        public LivyListSessionResponse(int? fromProperty = default(int?), int? total = default(int?), IList<LivySessionResponse> sessions = default(IList<LivySessionResponse>))
        {
            FromProperty = fromProperty;
            Total = total;
            Sessions = sessions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public int? FromProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public int? Total { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sessions")]
        public IList<LivySessionResponse> Sessions { get; set; }

    }
}
