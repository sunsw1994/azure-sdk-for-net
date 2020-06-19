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
    /// Avro write settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AvroWriteSettings")]
    public partial class AvroWriteSettings : FormatWriteSettings
    {
        /// <summary>
        /// Initializes a new instance of the AvroWriteSettings class.
        /// </summary>
        public AvroWriteSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AvroWriteSettings class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="recordName">Top level record name in write result,
        /// which is required in AVRO spec.</param>
        /// <param name="recordNamespace">Record namespace in the write
        /// result.</param>
        public AvroWriteSettings(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string recordName = default(string), string recordNamespace = default(string))
            : base(additionalProperties)
        {
            RecordName = recordName;
            RecordNamespace = recordNamespace;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets top level record name in write result, which is
        /// required in AVRO spec.
        /// </summary>
        [JsonProperty(PropertyName = "recordName")]
        public string RecordName { get; set; }

        /// <summary>
        /// Gets or sets record namespace in the write result.
        /// </summary>
        [JsonProperty(PropertyName = "recordNamespace")]
        public string RecordNamespace { get; set; }

    }
}
