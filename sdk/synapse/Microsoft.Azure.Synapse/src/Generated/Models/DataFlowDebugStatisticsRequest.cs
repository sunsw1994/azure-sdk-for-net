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
    /// Request body structure for data flow statistics.
    /// </summary>
    public partial class DataFlowDebugStatisticsRequest
    {
        /// <summary>
        /// Initializes a new instance of the DataFlowDebugStatisticsRequest
        /// class.
        /// </summary>
        public DataFlowDebugStatisticsRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataFlowDebugStatisticsRequest
        /// class.
        /// </summary>
        /// <param name="sessionId">The ID of data flow debug session.</param>
        /// <param name="dataFlowName">The data flow which contains the debug
        /// session.</param>
        /// <param name="streamName">The output stream name.</param>
        /// <param name="columns">List of column names.</param>
        public DataFlowDebugStatisticsRequest(string sessionId = default(string), string dataFlowName = default(string), string streamName = default(string), IList<string> columns = default(IList<string>))
        {
            SessionId = sessionId;
            DataFlowName = dataFlowName;
            StreamName = streamName;
            Columns = columns;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of data flow debug session.
        /// </summary>
        [JsonProperty(PropertyName = "sessionId")]
        public string SessionId { get; set; }

        /// <summary>
        /// Gets or sets the data flow which contains the debug session.
        /// </summary>
        [JsonProperty(PropertyName = "dataFlowName")]
        public string DataFlowName { get; set; }

        /// <summary>
        /// Gets or sets the output stream name.
        /// </summary>
        [JsonProperty(PropertyName = "streamName")]
        public string StreamName { get; set; }

        /// <summary>
        /// Gets or sets list of column names.
        /// </summary>
        [JsonProperty(PropertyName = "columns")]
        public IList<string> Columns { get; set; }

    }
}
