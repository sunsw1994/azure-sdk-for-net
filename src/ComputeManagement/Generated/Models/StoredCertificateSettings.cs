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

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// Service certificates with which to provision the new virtual machine.
    /// Stored certificate settings reference certificates that already exist
    /// in the Azure hosted service. Prior to configuring the stored
    /// certificates for the virtual machine, you must call the Add Service
    /// Certificate operation or add the certificate via the Azure Management
    /// portal.
    /// </summary>
    public partial class StoredCertificateSettings
    {
        private string _storeName;
        
        /// <summary>
        /// Required. Specifies the name of the certificate store from which to
        /// retrieve certificates.  For example, "My".
        /// </summary>
        public string StoreName
        {
            get { return this._storeName; }
            set { this._storeName = value; }
        }
        
        private string _thumbprint;
        
        /// <summary>
        /// Required. Specifies the thumbprint of the certificate to be
        /// provisioned. The thumbprint must specify an existing service
        /// certificate.
        /// </summary>
        public string Thumbprint
        {
            get { return this._thumbprint; }
            set { this._thumbprint = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the StoredCertificateSettings class.
        /// </summary>
        public StoredCertificateSettings()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the StoredCertificateSettings class
        /// with required arguments.
        /// </summary>
        public StoredCertificateSettings(string storeName, string thumbprint)
            : this()
        {
            if (storeName == null)
            {
                throw new ArgumentNullException("storeName");
            }
            if (thumbprint == null)
            {
                throw new ArgumentNullException("thumbprint");
            }
            this.StoreName = storeName;
            this.Thumbprint = thumbprint;
        }
    }
}
