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
    /// Json dataset.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Json")]
    [Rest.Serialization.JsonTransformation]
    public partial class JsonDataset : Dataset
    {
        /// <summary>
        /// Initializes a new instance of the JsonDataset class.
        /// </summary>
        public JsonDataset()
        {
            LinkedServiceName = new LinkedServiceReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JsonDataset class.
        /// </summary>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="location">The location of the json data
        /// storage.</param>
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
        /// <param name="encodingName">The code page name of the preferred
        /// encoding. If not specified, the default value is UTF-8, unless BOM
        /// denotes another Unicode encoding. Refer to the name column of the
        /// table in the following link to set supported values:
        /// https://msdn.microsoft.com/library/system.text.encoding.aspx. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="compression">The data compression method used for the
        /// json dataset.</param>
        public JsonDataset(LinkedServiceReference linkedServiceName, DatasetLocation location, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), object structure = default(object), object schema = default(object), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>), DatasetFolder folder = default(DatasetFolder), object encodingName = default(object), DatasetCompression compression = default(DatasetCompression))
            : base(linkedServiceName, additionalProperties, description, structure, schema, parameters, annotations, folder)
        {
            Location = location;
            EncodingName = encodingName;
            Compression = compression;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the location of the json data storage.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.location")]
        public DatasetLocation Location { get; set; }

        /// <summary>
        /// Gets or sets the code page name of the preferred encoding. If not
        /// specified, the default value is UTF-8, unless BOM denotes another
        /// Unicode encoding. Refer to the name column of the table in the
        /// following link to set supported values:
        /// https://msdn.microsoft.com/library/system.text.encoding.aspx. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encodingName")]
        public object EncodingName { get; set; }

        /// <summary>
        /// Gets or sets the data compression method used for the json dataset.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.compression")]
        public DatasetCompression Compression { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
        }
    }
}
