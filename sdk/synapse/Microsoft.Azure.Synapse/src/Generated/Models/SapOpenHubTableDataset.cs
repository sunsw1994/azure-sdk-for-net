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
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Sap Business Warehouse Open Hub Destination Table properties.
    /// </summary>
    [Newtonsoft.Json.JsonObject("SapOpenHubTable")]
    [Rest.Serialization.JsonTransformation]
    public partial class SapOpenHubTableDataset : Dataset
    {
        /// <summary>
        /// Initializes a new instance of the SapOpenHubTableDataset class.
        /// </summary>
        public SapOpenHubTableDataset()
        {
            LinkedServiceName = new LinkedServiceReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SapOpenHubTableDataset class.
        /// </summary>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="openHubDestinationName">The name of the Open Hub
        /// Destination with destination type as Database Table. Type: string
        /// (or Expression with resultType string).</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Dataset description.</param>
        /// <param name="structure">Columns that define the structure of the
        /// dataset. Type: array (or Expression with resultType array),
        /// itemType: DatasetDataElement.</param>
        /// <param name="schema">Columns that define the physical type schema
        /// of the dataset. Type: array (or Expression with resultType array),
        /// itemType: DatasetSchemaDataElement.</param>
        /// <param name="parameters">Parameters for dataset.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the Dataset.</param>
        /// <param name="folder">The folder that this Dataset is in. If not
        /// specified, Dataset will appear at the root level.</param>
        /// <param name="excludeLastRequest">Whether to exclude the records of
        /// the last request. The default value is true. Type: boolean (or
        /// Expression with resultType boolean).</param>
        /// <param name="baseRequestId">The ID of request for delta loading.
        /// Once it is set, only data with requestId larger than the value of
        /// this property will be retrieved. The default value is 0. Type:
        /// integer (or Expression with resultType integer ).</param>
        public SapOpenHubTableDataset(LinkedServiceReference linkedServiceName, object openHubDestinationName, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), object structure = default(object), object schema = default(object), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>), DatasetFolder folder = default(DatasetFolder), object excludeLastRequest = default(object), object baseRequestId = default(object))
            : base(linkedServiceName, additionalProperties, description, structure, schema, parameters, annotations, folder)
        {
            OpenHubDestinationName = openHubDestinationName;
            ExcludeLastRequest = excludeLastRequest;
            BaseRequestId = baseRequestId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the Open Hub Destination with destination
        /// type as Database Table. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.openHubDestinationName")]
        public object OpenHubDestinationName { get; set; }

        /// <summary>
        /// Gets or sets whether to exclude the records of the last request.
        /// The default value is true. Type: boolean (or Expression with
        /// resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.excludeLastRequest")]
        public object ExcludeLastRequest { get; set; }

        /// <summary>
        /// Gets or sets the ID of request for delta loading. Once it is set,
        /// only data with requestId larger than the value of this property
        /// will be retrieved. The default value is 0. Type: integer (or
        /// Expression with resultType integer ).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.baseRequestId")]
        public object BaseRequestId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (OpenHubDestinationName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OpenHubDestinationName");
            }
        }
    }
}
