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
    /// The folder that this Pipeline is in. If not specified, Pipeline will
    /// appear at the root level.
    /// </summary>
    public partial class PipelineFolder
    {
        /// <summary>
        /// Initializes a new instance of the PipelineFolder class.
        /// </summary>
        public PipelineFolder()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PipelineFolder class.
        /// </summary>
        /// <param name="name">The name of the folder that this Pipeline is
        /// in.</param>
        public PipelineFolder(string name = default(string))
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the folder that this Pipeline is in.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
