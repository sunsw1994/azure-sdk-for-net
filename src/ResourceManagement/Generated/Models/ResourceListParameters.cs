// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Resources.Models
{
    /// <summary>
    /// Resource group information.
    /// </summary>
    public partial class ResourceListParameters
    {
        private string _resourceGroupName;
        
        /// <summary>
        /// Optional. Gets or sets resource resource group to filter by.
        /// Optional.
        /// </summary>
        public string ResourceGroupName
        {
            get { return this._resourceGroupName; }
            set { this._resourceGroupName = value; }
        }
        
        private string _resourceType;
        
        /// <summary>
        /// Optional. Filter the results for a particular resource type.
        /// Optional.
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }
        
        private string _tagName;
        
        /// <summary>
        /// Optional. Filter the results based on a particular tag name.
        /// Optional.
        /// </summary>
        public string TagName
        {
            get { return this._tagName; }
            set { this._tagName = value; }
        }
        
        private string _tagValue;
        
        /// <summary>
        /// Optional. Filter the results for a tag name along with a particular
        /// tag value. Optional.
        /// </summary>
        public string TagValue
        {
            get { return this._tagValue; }
            set { this._tagValue = value; }
        }
        
        private int? _top;
        
        /// <summary>
        /// Optional. Number of records to return. Optional.
        /// </summary>
        public int? Top
        {
            get { return this._top; }
            set { this._top = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ResourceListParameters class.
        /// </summary>
        public ResourceListParameters()
        {
        }
    }
}
