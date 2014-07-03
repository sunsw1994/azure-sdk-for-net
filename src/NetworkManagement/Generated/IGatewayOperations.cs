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
using Microsoft.WindowsAzure.Management.Network.Models;

namespace Microsoft.WindowsAzure.Management.Network
{
    /// <summary>
    /// The Network Management API includes operations for managing the
    /// gateways for your subscription.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154113.aspx for
    /// more information)
    /// </summary>
    public partial interface IGatewayOperations
    {
        /// <summary>
        /// To connect to, disconnect from, or test your connection to a local
        /// network site, access the connection resource representing the
        /// local network and specify Connect, Disconnect or Test to perform
        /// the desired operation.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154107.aspx
        /// for more information)
        /// </summary>
        /// <param name='networkName'>
        /// The name of the virtual network for this gateway.
        /// </param>
        /// <param name='localNetworkSiteName'>
        /// The name of the site to connect to.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Begin Connect Disconnect Or Testing
        /// Gateway operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<GatewayOperationResponse> BeginConnectDisconnectOrTestingAsync(string networkName, string localNetworkSiteName, GatewayConnectDisconnectOrTestParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Begin Creating Virtual network Gateway operation creates a new
        /// network gateway for the specified virtual network in Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154119.aspx
        /// for more information)
        /// </summary>
        /// <param name='networkName'>
        /// The name of the virtual network for this gateway.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Begin Creating Virtual Network Gateway
        /// operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<GatewayOperationResponse> BeginCreatingAsync(string networkName, GatewayCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Begin Deleting Virtual Network Gateway operation deletes a
        /// network gateway for the specified virtual network in Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154129.aspx
        /// for more information)
        /// </summary>
        /// <param name='networkName'>
        /// The name of the virtual network.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<GatewayOperationResponse> BeginDeletingAsync(string networkName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Begin Failover Virtual Network Gateway operation causes a
        /// network gateway failover for the specified virtual network in
        /// Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154118.aspx
        /// for more information)
        /// </summary>
        /// <param name='networkName'>
        /// The name of the virtual network in Azure.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<GatewayOperationResponse> BeginFailoverAsync(string networkName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Generate VPN Client Package operation creates a VPN client
        /// package for the specified virtual network and gateway in Azure.
        /// (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn205126.aspx
        /// for more information)
        /// </summary>
        /// <param name='networkName'>
        /// The name of the virtual network for this gateway.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Generate VPN Client Package operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<GatewayOperationResponse> BeginGenerateVpnClientPackageAsync(string networkName, GatewayGenerateVpnClientPackageParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Begin Reset Virtual Network Gateway Shared Key operation resets
        /// the shared key on the virtual network gateway for the specified
        /// virtual network connection to the specified local network in
        /// Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154114.aspx
        /// for more information)
        /// </summary>
        /// <param name='networkName'>
        /// The name of the virtual network for this gateway.
        /// </param>
        /// <param name='localNetworkName'>
        /// The name of the local network.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Begin Virtual Network Gateway Reset
        /// Shared Key request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<GatewayOperationResponse> BeginResetSharedKeyAsync(string networkName, string localNetworkName, GatewayResetSharedKeyParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Begin Set Virtual Network Gateway Shared Key operation sets the
        /// shared key on the virtual network gateway for the specified
        /// virtual network connection to the specified local network in
        /// Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154114.aspx
        /// for more information)
        /// </summary>
        /// <param name='networkName'>
        /// The name of the virtual network for this gateway.
        /// </param>
        /// <param name='localNetworkName'>
        /// The name of the local network.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Begin Virtual Network Gateway Set Shared
        /// Key request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<GatewayOperationResponse> BeginSetSharedKeyAsync(string networkName, string localNetworkName, GatewaySetSharedKeyParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Begin Update Diagnostics operation begins an asynchronous
        /// operation to starta diagnostics session for the specified virtual
        /// network gateway in Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154119.aspx
        /// for more information)
        /// </summary>
        /// <param name='networkName'>
        /// The name of the virtual network for this gateway.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Begin Creating Virtual Network Gateway
        /// operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<GatewayOperationResponse> BeginUpdateDiagnosticsAsync(string networkName, UpdateGatewayPublicDiagnostics parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// To connect to, disconnect from, or test your connection to a local
        /// network site, access the connection resource representing the
        /// local network and specify Connect, Disconnect or Test to perform
        /// the desired operation.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154107.aspx
        /// for more information)
        /// </summary>
        /// <param name='networkName'>
        /// The name of the virtual network for this gateway.
        /// </param>
        /// <param name='localNetworkSiteName'>
        /// The name of the site to connect to.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Connect Disconnect Or Testing Gateway
        /// operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is in progress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<GatewayGetOperationStatusResponse> ConnectDisconnectOrTestAsync(string networkName, string localNetworkSiteName, GatewayConnectDisconnectOrTestParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Create Virtual network Gateway operation creates a new network
        /// gateway for the specified virtual network in Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154119.aspx
        /// for more information)
        /// </summary>
        /// <param name='networkName'>
        /// The name of the virtual network for this gateway.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Virtual Network Gateway operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is in progress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<GatewayGetOperationStatusResponse> CreateAsync(string networkName, GatewayCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Delete Virtual Network Gateway operation deletes a network
        /// gateway for the specified virtual network in Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154129.aspx
        /// for more information)
        /// </summary>
        /// <param name='networkName'>
        /// The name of the virtual network.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is in progress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<GatewayGetOperationStatusResponse> DeleteAsync(string networkName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Failover Virtual Network Gateway operation causes a network
        /// gateway failover for the specified virtual network in Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154118.aspx
        /// for more information)
        /// </summary>
        /// <param name='networkName'>
        /// The name of the virtual network in Azure.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is in progress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<GatewayGetOperationStatusResponse> FailoverAsync(string networkName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Generate VPN Client Package operation creates a VPN client
        /// package for the specified virtual network and gateway in Azure.
        /// (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154119.aspx
        /// for more information)
        /// </summary>
        /// <param name='networkName'>
        /// The name of the virtual network for this gateway.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Generate VPN Client Package operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is in progress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<GatewayGetOperationStatusResponse> GenerateVpnClientPackageAsync(string networkName, GatewayGenerateVpnClientPackageParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Virtual Network Gateway operation gets information about
        /// the network gateway for the specified virtual network in Azure.
        /// (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154109.aspx
        /// for more information)
        /// </summary>
        /// <param name='networkName'>
        /// The name of the virtual network for this gateway.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<GatewayGetResponse> GetAsync(string networkName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Device Configuration Script operation returns a script that
        /// you can use to configure local VPN devices to connect to the
        /// gateway.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154115.aspx
        /// for more information)
        /// </summary>
        /// <param name='networkName'>
        /// The name of the virtual network for this gateway.
        /// </param>
        /// <param name='parameters'>
        /// The parameters for the Get Device Configuration Script operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The configuration script returned from the get device configuration
        /// script operation.
        /// </returns>
        Task<GatewayGetDeviceConfigurationScriptResponse> GetDeviceConfigurationScriptAsync(string networkName, GatewayGetDeviceConfigurationScriptParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Diagnostics operation gets information about the current
        /// gateway diagnostics session for the specified virtual network in
        /// Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154119.aspx
        /// for more information)
        /// </summary>
        /// <param name='networkName'>
        /// The name of the virtual network for this gateway.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The status of a gateway diagnostics operation.
        /// </returns>
        Task<GatewayDiagnosticsStatus> GetDiagnosticsAsync(string networkName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Virtual Network Gateway Operation Status gets information
        /// on the status of network gateway operations in Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154112.aspx
        /// for more information)
        /// </summary>
        /// <param name='operationId'>
        /// The ID of the network operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is in progress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<GatewayGetOperationStatusResponse> GetOperationStatusAsync(string operationId, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Virtual Network Gateway Shared Key operation gets the
        /// shared key on the virtual network gateway for the specified
        /// virtual network connection to the specified local network in
        /// Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154122.aspx
        /// for more information)
        /// </summary>
        /// <param name='networkName'>
        /// The name of the virtual network for this gateway.
        /// </param>
        /// <param name='localNetworkName'>
        /// The name of the local network.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response to the get shared key request.
        /// </returns>
        Task<GatewayGetSharedKeyResponse> GetSharedKeyAsync(string networkName, string localNetworkName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The List Connections operation returns a list of the local network
        /// connections that can be accessed through the gateway.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154120.aspx
        /// for more information)
        /// </summary>
        /// <param name='networkName'>
        /// The name of the virtual network for this gateway.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response to a ListConnections request to a Virtual Network
        /// Gateway.
        /// </returns>
        Task<GatewayListConnectionsResponse> ListConnectionsAsync(string networkName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The List Virtual Network Gateway Supported Devices operation lists
        /// the supported, on-premise network devices that can connect to the
        /// gateway.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154102.aspx
        /// for more information)
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response to the list supported devices request.
        /// </returns>
        Task<GatewayListSupportedDevicesResponse> ListSupportedDevicesAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// The Reset Virtual Network Gateway Shared Key operation resets the
        /// shared key on the virtual network gateway for the specified
        /// virtual network connection to the specified local network in
        /// Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154114.aspx
        /// for more information)
        /// </summary>
        /// <param name='networkName'>
        /// The name of the virtual network for this gateway.
        /// </param>
        /// <param name='localNetworkName'>
        /// The name of the local network.
        /// </param>
        /// <param name='parameters'>
        /// The parameters to the Virtual Network Gateway Reset Shared Key
        /// request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is in progress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<GatewayGetOperationStatusResponse> ResetSharedKeyAsync(string networkName, string localNetworkName, GatewayResetSharedKeyParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Set Virtual Network Gateway Shared Key operation sets the
        /// shared key on the virtual network gateway for the specified
        /// virtual network connection to the specified local network in
        /// Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154114.aspx
        /// for more information)
        /// </summary>
        /// <param name='networkName'>
        /// The name of the virtual network for this gateway.
        /// </param>
        /// <param name='localNetworkName'>
        /// The name of the local network.
        /// </param>
        /// <param name='parameters'>
        /// The parameters to the Virtual Network Gateway Set Shared Key
        /// request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is in progress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<GatewayGetOperationStatusResponse> SetSharedKeyAsync(string networkName, string localNetworkName, GatewaySetSharedKeyParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Create Virtual network Gateway operation creates a new network
        /// gateway for the specified virtual network in Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154119.aspx
        /// for more information)
        /// </summary>
        /// <param name='networkName'>
        /// The name of the virtual network for this gateway.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Update Diagnostics operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is in progress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<GatewayGetOperationStatusResponse> UpdateDiagnosticsAsync(string networkName, UpdateGatewayPublicDiagnostics parameters, CancellationToken cancellationToken);
    }
}
