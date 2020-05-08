// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.HDInsight.Job
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SparkBatchOperations.
    /// </summary>
    public static partial class SparkBatchOperationsExtensions
    {
            /// <summary>
            /// List all spark batch jobs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fromParameter'>
            /// Optional param specifying which index the list should begin from.
            /// </param>
            /// <param name='size'>
            /// Optional param specifying the size of the returned list.
            /// By default it is 20 and that is the maximum.
            /// </param>
            public static LivyListBatchResponse List(this ISparkBatchOperations operations, int? fromParameter = default(int?), int? size = default(int?))
            {
                return operations.ListAsync(fromParameter, size).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all spark batch jobs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fromParameter'>
            /// Optional param specifying which index the list should begin from.
            /// </param>
            /// <param name='size'>
            /// Optional param specifying the size of the returned list.
            /// By default it is 20 and that is the maximum.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LivyListBatchResponse> ListAsync(this ISparkBatchOperations operations, int? fromParameter = default(int?), int? size = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(fromParameter, size, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create new spark batch job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='livyRequest'>
            /// Livy compatible batch job request payload.
            /// </param>
            public static LivyBatchResponse Create(this ISparkBatchOperations operations, LivyBatchRequest livyRequest)
            {
                return operations.CreateAsync(livyRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create new spark batch job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='livyRequest'>
            /// Livy compatible batch job request payload.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LivyBatchResponse> CreateAsync(this ISparkBatchOperations operations, LivyBatchRequest livyRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(livyRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a single spark batch job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='batchId'>
            /// Identifier for the batch job.
            /// </param>
            public static LivyBatchResponse Get(this ISparkBatchOperations operations, int batchId)
            {
                return operations.GetAsync(batchId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a single spark batch job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='batchId'>
            /// Identifier for the batch job.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LivyBatchResponse> GetAsync(this ISparkBatchOperations operations, int batchId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(batchId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancels a running spark batch job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='batchId'>
            /// Identifier for the batch job.
            /// </param>
            public static void Delete(this ISparkBatchOperations operations, int batchId)
            {
                operations.DeleteAsync(batchId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancels a running spark batch job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='batchId'>
            /// Identifier for the batch job.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISparkBatchOperations operations, int batchId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(batchId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a single spark batch job logs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='batchId'>
            /// Identifier for the batch job.
            /// </param>
            /// <param name='fromParameter'>
            /// Optional param specifying which index the list should begin from.
            /// </param>
            /// <param name='size'>
            /// Optional param specifying the size of the returned list.
            /// By default it is 20 and that is the maximum.
            /// </param>
            public static LivyLogResponse GetLogs(this ISparkBatchOperations operations, int batchId, int? fromParameter = default(int?), int? size = default(int?))
            {
                return operations.GetLogsAsync(batchId, fromParameter, size).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a single spark batch job logs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='batchId'>
            /// Identifier for the batch job.
            /// </param>
            /// <param name='fromParameter'>
            /// Optional param specifying which index the list should begin from.
            /// </param>
            /// <param name='size'>
            /// Optional param specifying the size of the returned list.
            /// By default it is 20 and that is the maximum.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LivyLogResponse> GetLogsAsync(this ISparkBatchOperations operations, int batchId, int? fromParameter = default(int?), int? size = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetLogsWithHttpMessagesAsync(batchId, fromParameter, size, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a single spark batch state.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='batchId'>
            /// Identifier for the batch job.
            /// </param>
            public static LivyStateResponse GetState(this ISparkBatchOperations operations, int batchId)
            {
                return operations.GetStateAsync(batchId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a single spark batch state.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='batchId'>
            /// Identifier for the batch job.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LivyStateResponse> GetStateAsync(this ISparkBatchOperations operations, int batchId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStateWithHttpMessagesAsync(batchId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
