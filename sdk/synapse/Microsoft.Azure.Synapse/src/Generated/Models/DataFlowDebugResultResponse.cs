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
    using System.Linq;

    /// <summary>
    /// Response body structure of data flow result for data preview,
    /// statistics or expression preview.
    /// </summary>
    public partial class DataFlowDebugResultResponse
    {
        /// <summary>
        /// Initializes a new instance of the DataFlowDebugResultResponse
        /// class.
        /// </summary>
        public DataFlowDebugResultResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataFlowDebugResultResponse
        /// class.
        /// </summary>
        /// <param name="status">The run status of data preview, statistics or
        /// expression preview.</param>
        /// <param name="data">The result data of data preview, statistics or
        /// expression preview.</param>
        public DataFlowDebugResultResponse(string status = default(string), string data = default(string))
        {
            Status = status;
            Data = data;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the run status of data preview, statistics or
        /// expression preview.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the result data of data preview, statistics or
        /// expression preview.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public string Data { get; set; }

    }
}
