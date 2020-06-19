// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Synapse
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DataFlowOperations.
    /// </summary>
    public static partial class DataFlowOperationsExtensions
    {
            /// <summary>
            /// Creates or updates a data flow.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataFlowName'>
            /// The data flow name.
            /// </param>
            /// <param name='dataFlow'>
            /// Data flow resource definition.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the data flow entity. Should only be specified for update, for
            /// which it should match existing entity or can be * for unconditional update.
            /// </param>
            public static DataFlowResource CreateOrUpdateDataFlow(this IDataFlowOperations operations, string dataFlowName, DataFlowResource dataFlow, string ifMatch = default(string))
            {
                return operations.CreateOrUpdateDataFlowAsync(dataFlowName, dataFlow, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a data flow.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataFlowName'>
            /// The data flow name.
            /// </param>
            /// <param name='dataFlow'>
            /// Data flow resource definition.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the data flow entity. Should only be specified for update, for
            /// which it should match existing entity or can be * for unconditional update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataFlowResource> CreateOrUpdateDataFlowAsync(this IDataFlowOperations operations, string dataFlowName, DataFlowResource dataFlow, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateDataFlowWithHttpMessagesAsync(dataFlowName, dataFlow, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a data flow.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataFlowName'>
            /// The data flow name.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// ETag of the data flow entity. Should only be specified for get. If the ETag
            /// matches the existing entity tag, or if * was provided, then no content will
            /// be returned.
            /// </param>
            public static DataFlowResource GetDataFlow(this IDataFlowOperations operations, string dataFlowName, string ifNoneMatch = default(string))
            {
                return operations.GetDataFlowAsync(dataFlowName, ifNoneMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a data flow.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataFlowName'>
            /// The data flow name.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// ETag of the data flow entity. Should only be specified for get. If the ETag
            /// matches the existing entity tag, or if * was provided, then no content will
            /// be returned.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataFlowResource> GetDataFlowAsync(this IDataFlowOperations operations, string dataFlowName, string ifNoneMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDataFlowWithHttpMessagesAsync(dataFlowName, ifNoneMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a data flow.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataFlowName'>
            /// The data flow name.
            /// </param>
            public static void DeleteDataFlow(this IDataFlowOperations operations, string dataFlowName)
            {
                operations.DeleteDataFlowAsync(dataFlowName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a data flow.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataFlowName'>
            /// The data flow name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteDataFlowAsync(this IDataFlowOperations operations, string dataFlowName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteDataFlowWithHttpMessagesAsync(dataFlowName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists data flows.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<DataFlowResource> GetDataFlowsByWorkspace(this IDataFlowOperations operations)
            {
                return operations.GetDataFlowsByWorkspaceAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists data flows.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DataFlowResource>> GetDataFlowsByWorkspaceAsync(this IDataFlowOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDataFlowsByWorkspaceWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists data flows.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DataFlowResource> GetDataFlowsByWorkspaceNext(this IDataFlowOperations operations, string nextPageLink)
            {
                return operations.GetDataFlowsByWorkspaceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists data flows.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DataFlowResource>> GetDataFlowsByWorkspaceNextAsync(this IDataFlowOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDataFlowsByWorkspaceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
