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
    /// Extension methods for SparkSessionOperations.
    /// </summary>
    public static partial class SparkSessionOperationsExtensions
    {
            /// <summary>
            /// List all spark sessions which are running under a particular spark pool.
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
            /// <param name='detailed'>
            /// Optional query param specifying whether detailed response is returned
            /// beyond plain livy.
            /// </param>
            public static SparkSessionCollection GetSparkSessions(this ISparkSessionOperations operations, int? fromParameter = default(int?), int? size = default(int?), bool? detailed = default(bool?))
            {
                return operations.GetSparkSessionsAsync(fromParameter, size, detailed).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all spark sessions which are running under a particular spark pool.
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
            /// <param name='detailed'>
            /// Optional query param specifying whether detailed response is returned
            /// beyond plain livy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SparkSessionCollection> GetSparkSessionsAsync(this ISparkSessionOperations operations, int? fromParameter = default(int?), int? size = default(int?), bool? detailed = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSparkSessionsWithHttpMessagesAsync(fromParameter, size, detailed, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create new spark session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sparkSessionOptions'>
            /// Livy compatible batch job request payload.
            /// </param>
            /// <param name='detailed'>
            /// Optional query param specifying whether detailed response is returned
            /// beyond plain livy.
            /// </param>
            public static SparkSession CreateSparkSession(this ISparkSessionOperations operations, SparkSessionOptions sparkSessionOptions, bool? detailed = default(bool?))
            {
                return operations.CreateSparkSessionAsync(sparkSessionOptions, detailed).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create new spark session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sparkSessionOptions'>
            /// Livy compatible batch job request payload.
            /// </param>
            /// <param name='detailed'>
            /// Optional query param specifying whether detailed response is returned
            /// beyond plain livy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SparkSession> CreateSparkSessionAsync(this ISparkSessionOperations operations, SparkSessionOptions sparkSessionOptions, bool? detailed = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateSparkSessionWithHttpMessagesAsync(sparkSessionOptions, detailed, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a single spark session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            /// <param name='detailed'>
            /// Optional query param specifying whether detailed response is returned
            /// beyond plain livy.
            /// </param>
            public static SparkSession GetSparkSession(this ISparkSessionOperations operations, int sessionId, bool? detailed = default(bool?))
            {
                return operations.GetSparkSessionAsync(sessionId, detailed).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a single spark session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            /// <param name='detailed'>
            /// Optional query param specifying whether detailed response is returned
            /// beyond plain livy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SparkSession> GetSparkSessionAsync(this ISparkSessionOperations operations, int sessionId, bool? detailed = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSparkSessionWithHttpMessagesAsync(sessionId, detailed, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancels a running spark session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            public static void CancelSparkSession(this ISparkSessionOperations operations, int sessionId)
            {
                operations.CancelSparkSessionAsync(sessionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancels a running spark session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CancelSparkSessionAsync(this ISparkSessionOperations operations, int sessionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CancelSparkSessionWithHttpMessagesAsync(sessionId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Sends a keep alive call to the current session to reset the session
            /// timeout.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            public static void ResetSparkSessionTimeout(this ISparkSessionOperations operations, int sessionId)
            {
                operations.ResetSparkSessionTimeoutAsync(sessionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sends a keep alive call to the current session to reset the session
            /// timeout.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ResetSparkSessionTimeoutAsync(this ISparkSessionOperations operations, int sessionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ResetSparkSessionTimeoutWithHttpMessagesAsync(sessionId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a list of statements within a spark session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            public static SparkStatementCollection GetSparkStatements(this ISparkSessionOperations operations, int sessionId)
            {
                return operations.GetSparkStatementsAsync(sessionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of statements within a spark session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SparkStatementCollection> GetSparkStatementsAsync(this ISparkSessionOperations operations, int sessionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSparkStatementsWithHttpMessagesAsync(sessionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create statement within a spark session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            /// <param name='sparkStatementOptions'>
            /// Livy compatible batch job request payload.
            /// </param>
            public static SparkStatement CreateSparkStatement(this ISparkSessionOperations operations, int sessionId, SparkStatementOptions sparkStatementOptions)
            {
                return operations.CreateSparkStatementAsync(sessionId, sparkStatementOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create statement within a spark session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            /// <param name='sparkStatementOptions'>
            /// Livy compatible batch job request payload.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SparkStatement> CreateSparkStatementAsync(this ISparkSessionOperations operations, int sessionId, SparkStatementOptions sparkStatementOptions, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateSparkStatementWithHttpMessagesAsync(sessionId, sparkStatementOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a single statement within a spark session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            /// <param name='statementId'>
            /// Identifier for the statement.
            /// </param>
            public static SparkStatement GetSparkStatement(this ISparkSessionOperations operations, int sessionId, int statementId)
            {
                return operations.GetSparkStatementAsync(sessionId, statementId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a single statement within a spark session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            /// <param name='statementId'>
            /// Identifier for the statement.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SparkStatement> GetSparkStatementAsync(this ISparkSessionOperations operations, int sessionId, int statementId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSparkStatementWithHttpMessagesAsync(sessionId, statementId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Kill a statement within a session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            /// <param name='statementId'>
            /// Identifier for the statement.
            /// </param>
            public static SparkStatementCancellationResult CancelSparkStatement(this ISparkSessionOperations operations, int sessionId, int statementId)
            {
                return operations.CancelSparkStatementAsync(sessionId, statementId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Kill a statement within a session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sessionId'>
            /// Identifier for the session.
            /// </param>
            /// <param name='statementId'>
            /// Identifier for the statement.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SparkStatementCancellationResult> CancelSparkStatementAsync(this ISparkSessionOperations operations, int sessionId, int statementId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CancelSparkStatementWithHttpMessagesAsync(sessionId, statementId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
