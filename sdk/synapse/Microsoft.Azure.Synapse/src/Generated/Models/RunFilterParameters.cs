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
    /// Query parameters for listing runs.
    /// </summary>
    public partial class RunFilterParameters
    {
        /// <summary>
        /// Initializes a new instance of the RunFilterParameters class.
        /// </summary>
        public RunFilterParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RunFilterParameters class.
        /// </summary>
        /// <param name="lastUpdatedAfter">The time at or after which the run
        /// event was updated in 'ISO 8601' format.</param>
        /// <param name="lastUpdatedBefore">The time at or before which the run
        /// event was updated in 'ISO 8601' format.</param>
        /// <param name="continuationToken">The continuation token for getting
        /// the next page of results. Null for first page.</param>
        /// <param name="filters">List of filters.</param>
        /// <param name="orderBy">List of OrderBy option.</param>
        public RunFilterParameters(System.DateTimeOffset lastUpdatedAfter, System.DateTimeOffset lastUpdatedBefore, string continuationToken = default(string), IList<RunQueryFilter> filters = default(IList<RunQueryFilter>), IList<RunQueryOrderBy> orderBy = default(IList<RunQueryOrderBy>))
        {
            ContinuationToken = continuationToken;
            LastUpdatedAfter = lastUpdatedAfter;
            LastUpdatedBefore = lastUpdatedBefore;
            Filters = filters;
            OrderBy = orderBy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the continuation token for getting the next page of
        /// results. Null for first page.
        /// </summary>
        [JsonProperty(PropertyName = "continuationToken")]
        public string ContinuationToken { get; set; }

        /// <summary>
        /// Gets or sets the time at or after which the run event was updated
        /// in 'ISO 8601' format.
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdatedAfter")]
        public System.DateTimeOffset LastUpdatedAfter { get; set; }

        /// <summary>
        /// Gets or sets the time at or before which the run event was updated
        /// in 'ISO 8601' format.
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdatedBefore")]
        public System.DateTimeOffset LastUpdatedBefore { get; set; }

        /// <summary>
        /// Gets or sets list of filters.
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public IList<RunQueryFilter> Filters { get; set; }

        /// <summary>
        /// Gets or sets list of OrderBy option.
        /// </summary>
        [JsonProperty(PropertyName = "orderBy")]
        public IList<RunQueryOrderBy> OrderBy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Filters != null)
            {
                foreach (var element in Filters)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (OrderBy != null)
            {
                foreach (var element1 in OrderBy)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
