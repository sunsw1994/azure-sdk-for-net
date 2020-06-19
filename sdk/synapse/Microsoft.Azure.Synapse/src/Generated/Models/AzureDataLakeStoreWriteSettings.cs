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
    /// Azure data lake store write settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureDataLakeStoreWriteSettings")]
    public partial class AzureDataLakeStoreWriteSettings : StoreWriteSettings
    {
        /// <summary>
        /// Initializes a new instance of the AzureDataLakeStoreWriteSettings
        /// class.
        /// </summary>
        public AzureDataLakeStoreWriteSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureDataLakeStoreWriteSettings
        /// class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="maxConcurrentConnections">The maximum concurrent
        /// connection count for the source data store. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="copyBehavior">The type of copy behavior for copy
        /// sink.</param>
        public AzureDataLakeStoreWriteSettings(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object maxConcurrentConnections = default(object), object copyBehavior = default(object))
            : base(additionalProperties, maxConcurrentConnections, copyBehavior)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
