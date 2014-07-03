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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.WebSites.Models;
using Microsoft.WindowsAzure;

namespace Microsoft.Azure.Management.WebSites
{
    /// <summary>
    /// Operations for managing the web sites in a web space.
    /// </summary>
    public partial interface IWebSiteOperations
    {
        /// <summary>
        /// You can create a web site by using a POST request that includes the
        /// name of the web site and other information in the request body.
        /// (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166986.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Web Site operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Create Web Space operation response.
        /// </returns>
        Task<WebSiteCreateResponse> CreateOrUpdateAsync(string resourceGroupName, WebSiteCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// A web site repository is essentially a GIT repository that you can
        /// use to manage your web site content. By using GIT source control
        /// tools, you can push or pull version controlled changes to your
        /// site. You can create a repository for your web site by issuing an
        /// HTTP POST request, or retrieve information about the repository by
        /// using HTTP GET.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166967.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> CreateRepositoryAsync(string resourceGroupName, string webSiteName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes the web site.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group..
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the Web Site resource.
        /// </param>
        /// <param name='parameters'>
        /// The parameters to delete a web site.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> DeleteAsync(string resourceGroupName, string webSiteName, WebSiteDeleteParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// A web site repository is essentially a GIT repository that you can
        /// use to manage your web site content. By using GIT source control
        /// tools, you can push or pull version controlled changes to your
        /// site. You can create a repository for your web site by issuing an
        /// HTTP POST request, or retrieve information about the repository by
        /// using HTTP GET.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166967.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Delete Web Site Repository operation response.
        /// </returns>
        Task<WebSiteDeleteRepositoryResponse> DeleteRepositoryAsync(string resourceGroupName, string webSiteName, CancellationToken cancellationToken);
        
        /// <summary>
        /// You can generate a new random password for publishing a site by
        /// issuing an HTTP POST request.  Tip: If you want to verify that the
        /// publish password has changed, call HTTP GET on /publishxml before
        /// calling /newpassword. In the publish XML, note the hash value in
        /// the userPWD attribute. After calling /newpassword, call
        /// /publishxml again. You can then compare the new value of userPWD
        /// in the Publish XML with the one you noted earlier.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn236428.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> GeneratePasswordAsync(string resourceGroupName, string webSiteName, CancellationToken cancellationToken);
        
        /// <summary>
        /// You can retrieve details for a web site by issuing an HTTP GET
        /// request.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn167007.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='parameters'>
        /// Additional parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Web Site Details operation response.
        /// </returns>
        Task<WebSiteGetResponse> GetAsync(string resourceGroupName, string webSiteName, WebSiteGetParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// You can retrieve the config settings for a web site by issuing an
        /// HTTP GET request, or update them by using HTTP PUT with a request
        /// body that contains the settings to be updated.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166985.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='parameters'>
        /// Additional parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Web Site Configuration operation response.
        /// </returns>
        Task<WebSiteGetConfigurationResponse> GetConfigurationAsync(string resourceGroupName, string webSiteName, WebSiteGetConfigurationParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// You can retrieve historical usage metrics for a site by issuing an
        /// HTTP GET request.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166964.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='parameters'>
        /// The Get Web Site Historical Usage Metrics parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Web Site Historical Usage Metrics operation response.
        /// </returns>
        Task<WebSiteGetHistoricalUsageMetricsResponse> GetHistoricalUsageMetricsAsync(string resourceGroupName, string webSiteName, WebSiteGetHistoricalUsageMetricsParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieve the publish settings information for a web site.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166996.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Web Site Publish Profile operation response.
        /// </returns>
        Task<WebSiteGetPublishProfileResponse> GetPublishProfileAsync(string resourceGroupName, string webSiteName, CancellationToken cancellationToken);
        
        /// <summary>
        /// A web site repository is essentially a GIT repository that you can
        /// use to manage your web site content. By using GIT source control
        /// tools, you can push or pull version controlled changes to your
        /// site. You can create a repository for your web site by issuing an
        /// HTTP POST request, or retrieve information about the repository by
        /// using HTTP GET.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166967.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Web Site Repository operation response.
        /// </returns>
        Task<WebSiteGetRepositoryResponse> GetRepositoryAsync(string resourceGroupName, string webSiteName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get a web site's current usage metrics. The metrics returned
        /// include CPU Time, Data In, Data Out, Local bytes read, Local bytes
        /// written, Network bytes read, Network bytes written, WP stop
        /// requests, Memory Usage, CPU Time - Minute Limit, and File System
        /// Storage.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166991.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Web Site Usage Metrics operation response.
        /// </returns>
        Task<WebSiteGetUsageMetricsResponse> GetUsageMetricsAsync(string resourceGroupName, string webSiteName, CancellationToken cancellationToken);
        
        /// <summary>
        /// List the Web Sites in a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// Additional parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Web Sites operation response.
        /// </returns>
        Task<WebSiteListResponse> ListAsync(string resourceGroupName, WebSiteListParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Restart the web site.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='webSiteName'>
        /// TBD
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> RestartAsync(string resourceGroupName, string webSiteName, CancellationToken cancellationToken);
        
        /// <summary>
        /// You can retrieve the config settings for a web site by issuing an
        /// HTTP GET request, or update them by using HTTP PUT with a request
        /// body that contains the settings to be updated.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166985.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='parameters'>
        /// The Update Web Site Configuration parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> UpdateConfigurationAsync(string resourceGroupName, string webSiteName, WebSiteUpdateConfigurationParameters parameters, CancellationToken cancellationToken);
    }
}
