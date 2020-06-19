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
    /// Information about an activity run in a pipeline.
    /// </summary>
    public partial class ActivityRun
    {
        /// <summary>
        /// Initializes a new instance of the ActivityRun class.
        /// </summary>
        public ActivityRun()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActivityRun class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="pipelineName">The name of the pipeline.</param>
        /// <param name="pipelineRunId">The id of the pipeline run.</param>
        /// <param name="activityName">The name of the activity.</param>
        /// <param name="activityType">The type of the activity.</param>
        /// <param name="activityRunId">The id of the activity run.</param>
        /// <param name="linkedServiceName">The name of the compute linked
        /// service.</param>
        /// <param name="status">The status of the activity run.</param>
        /// <param name="activityRunStart">The start time of the activity run
        /// in 'ISO 8601' format.</param>
        /// <param name="activityRunEnd">The end time of the activity run in
        /// 'ISO 8601' format.</param>
        /// <param name="durationInMs">The duration of the activity
        /// run.</param>
        /// <param name="input">The input for the activity.</param>
        /// <param name="output">The output for the activity.</param>
        /// <param name="error">The error if any from the activity run.</param>
        public ActivityRun(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string pipelineName = default(string), string pipelineRunId = default(string), string activityName = default(string), string activityType = default(string), string activityRunId = default(string), string linkedServiceName = default(string), string status = default(string), System.DateTimeOffset? activityRunStart = default(System.DateTimeOffset?), System.DateTimeOffset? activityRunEnd = default(System.DateTimeOffset?), int? durationInMs = default(int?), object input = default(object), object output = default(object), object error = default(object))
        {
            AdditionalProperties = additionalProperties;
            PipelineName = pipelineName;
            PipelineRunId = pipelineRunId;
            ActivityName = activityName;
            ActivityType = activityType;
            ActivityRunId = activityRunId;
            LinkedServiceName = linkedServiceName;
            Status = status;
            ActivityRunStart = activityRunStart;
            ActivityRunEnd = activityRunEnd;
            DurationInMs = durationInMs;
            Input = input;
            Output = output;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets the name of the pipeline.
        /// </summary>
        [JsonProperty(PropertyName = "pipelineName")]
        public string PipelineName { get; private set; }

        /// <summary>
        /// Gets the id of the pipeline run.
        /// </summary>
        [JsonProperty(PropertyName = "pipelineRunId")]
        public string PipelineRunId { get; private set; }

        /// <summary>
        /// Gets the name of the activity.
        /// </summary>
        [JsonProperty(PropertyName = "activityName")]
        public string ActivityName { get; private set; }

        /// <summary>
        /// Gets the type of the activity.
        /// </summary>
        [JsonProperty(PropertyName = "activityType")]
        public string ActivityType { get; private set; }

        /// <summary>
        /// Gets the id of the activity run.
        /// </summary>
        [JsonProperty(PropertyName = "activityRunId")]
        public string ActivityRunId { get; private set; }

        /// <summary>
        /// Gets the name of the compute linked service.
        /// </summary>
        [JsonProperty(PropertyName = "linkedServiceName")]
        public string LinkedServiceName { get; private set; }

        /// <summary>
        /// Gets the status of the activity run.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets the start time of the activity run in 'ISO 8601' format.
        /// </summary>
        [JsonProperty(PropertyName = "activityRunStart")]
        public System.DateTimeOffset? ActivityRunStart { get; private set; }

        /// <summary>
        /// Gets the end time of the activity run in 'ISO 8601' format.
        /// </summary>
        [JsonProperty(PropertyName = "activityRunEnd")]
        public System.DateTimeOffset? ActivityRunEnd { get; private set; }

        /// <summary>
        /// Gets the duration of the activity run.
        /// </summary>
        [JsonProperty(PropertyName = "durationInMs")]
        public int? DurationInMs { get; private set; }

        /// <summary>
        /// Gets the input for the activity.
        /// </summary>
        [JsonProperty(PropertyName = "input")]
        public object Input { get; private set; }

        /// <summary>
        /// Gets the output for the activity.
        /// </summary>
        [JsonProperty(PropertyName = "output")]
        public object Output { get; private set; }

        /// <summary>
        /// Gets the error if any from the activity run.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public object Error { get; private set; }

    }
}
