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
    /// The location of http server.
    /// </summary>
    [Newtonsoft.Json.JsonObject("HttpServerLocation")]
    public partial class HttpServerLocation : DatasetLocation
    {
        /// <summary>
        /// Initializes a new instance of the HttpServerLocation class.
        /// </summary>
        public HttpServerLocation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HttpServerLocation class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="folderPath">Specify the folder path of dataset. Type:
        /// string (or Expression with resultType string)</param>
        /// <param name="fileName">Specify the file name of dataset. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="relativeUrl">Specify the relativeUrl of http server.
        /// Type: string (or Expression with resultType string)</param>
        public HttpServerLocation(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object folderPath = default(object), object fileName = default(object), object relativeUrl = default(object))
            : base(additionalProperties, folderPath, fileName)
        {
            RelativeUrl = relativeUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specify the relativeUrl of http server. Type: string
        /// (or Expression with resultType string)
        /// </summary>
        [JsonProperty(PropertyName = "relativeUrl")]
        public object RelativeUrl { get; set; }

    }
}
