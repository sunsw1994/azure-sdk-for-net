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
    /// Delimited text read settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("DelimitedTextReadSettings")]
    public partial class DelimitedTextReadSettings : FormatReadSettings
    {
        /// <summary>
        /// Initializes a new instance of the DelimitedTextReadSettings class.
        /// </summary>
        public DelimitedTextReadSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DelimitedTextReadSettings class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="skipLineCount">Indicates the number of non-empty rows
        /// to skip when reading data from input files. Type: integer (or
        /// Expression with resultType integer).</param>
        public DelimitedTextReadSettings(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object skipLineCount = default(object))
            : base(additionalProperties)
        {
            SkipLineCount = skipLineCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates the number of non-empty rows to skip when
        /// reading data from input files. Type: integer (or Expression with
        /// resultType integer).
        /// </summary>
        [JsonProperty(PropertyName = "skipLineCount")]
        public object SkipLineCount { get; set; }

    }
}
