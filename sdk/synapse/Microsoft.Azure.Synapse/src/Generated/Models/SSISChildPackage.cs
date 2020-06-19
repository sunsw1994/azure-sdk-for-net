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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SSIS embedded child package.
    /// </summary>
    public partial class SSISChildPackage
    {
        /// <summary>
        /// Initializes a new instance of the SSISChildPackage class.
        /// </summary>
        public SSISChildPackage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SSISChildPackage class.
        /// </summary>
        /// <param name="packagePath">Path for embedded child package. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="packageContent">Content for embedded child package.
        /// Type: string (or Expression with resultType string).</param>
        /// <param name="packageName">Name for embedded child package.</param>
        /// <param name="packageLastModifiedDate">Last modified date for
        /// embedded child package.</param>
        public SSISChildPackage(object packagePath, object packageContent, string packageName = default(string), string packageLastModifiedDate = default(string))
        {
            PackagePath = packagePath;
            PackageName = packageName;
            PackageContent = packageContent;
            PackageLastModifiedDate = packageLastModifiedDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets path for embedded child package. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "packagePath")]
        public object PackagePath { get; set; }

        /// <summary>
        /// Gets or sets name for embedded child package.
        /// </summary>
        [JsonProperty(PropertyName = "packageName")]
        public string PackageName { get; set; }

        /// <summary>
        /// Gets or sets content for embedded child package. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "packageContent")]
        public object PackageContent { get; set; }

        /// <summary>
        /// Gets or sets last modified date for embedded child package.
        /// </summary>
        [JsonProperty(PropertyName = "packageLastModifiedDate")]
        public string PackageLastModifiedDate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PackagePath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PackagePath");
            }
            if (PackageContent == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PackageContent");
            }
        }
    }
}
