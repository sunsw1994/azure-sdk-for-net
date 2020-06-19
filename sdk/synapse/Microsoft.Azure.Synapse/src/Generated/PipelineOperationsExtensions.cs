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
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PipelineOperations.
    /// </summary>
    public static partial class PipelineOperationsExtensions
    {
            /// <summary>
            /// Lists pipelines.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<PipelineResource> GetPipelinesByWorkspace(this IPipelineOperations operations)
            {
                return operations.GetPipelinesByWorkspaceAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists pipelines.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PipelineResource>> GetPipelinesByWorkspaceAsync(this IPipelineOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPipelinesByWorkspaceWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a pipeline.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pipelineName'>
            /// The pipeline name.
            /// </param>
            /// <param name='pipeline'>
            /// Pipeline resource definition.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the pipeline entity.  Should only be specified for update, for
            /// which it should match existing entity or can be * for unconditional update.
            /// </param>
            public static PipelineResource CreateOrUpdatePipeline(this IPipelineOperations operations, string pipelineName, PipelineResource pipeline, string ifMatch = default(string))
            {
                return operations.CreateOrUpdatePipelineAsync(pipelineName, pipeline, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a pipeline.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pipelineName'>
            /// The pipeline name.
            /// </param>
            /// <param name='pipeline'>
            /// Pipeline resource definition.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the pipeline entity.  Should only be specified for update, for
            /// which it should match existing entity or can be * for unconditional update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PipelineResource> CreateOrUpdatePipelineAsync(this IPipelineOperations operations, string pipelineName, PipelineResource pipeline, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdatePipelineWithHttpMessagesAsync(pipelineName, pipeline, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a pipeline.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pipelineName'>
            /// The pipeline name.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// ETag of the pipeline entity. Should only be specified for get. If the ETag
            /// matches the existing entity tag, or if * was provided, then no content will
            /// be returned.
            /// </param>
            public static PipelineResource GetPipeline(this IPipelineOperations operations, string pipelineName, string ifNoneMatch = default(string))
            {
                return operations.GetPipelineAsync(pipelineName, ifNoneMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a pipeline.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pipelineName'>
            /// The pipeline name.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// ETag of the pipeline entity. Should only be specified for get. If the ETag
            /// matches the existing entity tag, or if * was provided, then no content will
            /// be returned.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PipelineResource> GetPipelineAsync(this IPipelineOperations operations, string pipelineName, string ifNoneMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPipelineWithHttpMessagesAsync(pipelineName, ifNoneMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a pipeline.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pipelineName'>
            /// The pipeline name.
            /// </param>
            public static void DeletePipeline(this IPipelineOperations operations, string pipelineName)
            {
                operations.DeletePipelineAsync(pipelineName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a pipeline.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pipelineName'>
            /// The pipeline name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeletePipelineAsync(this IPipelineOperations operations, string pipelineName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeletePipelineWithHttpMessagesAsync(pipelineName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a run of a pipeline.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pipelineName'>
            /// The pipeline name.
            /// </param>
            /// <param name='referencePipelineRunId'>
            /// The pipeline run identifier. If run ID is specified the parameters of the
            /// specified run will be used to create a new run.
            /// </param>
            /// <param name='isRecovery'>
            /// Recovery mode flag. If recovery mode is set to true, the specified
            /// referenced pipeline run and the new run will be grouped under the same
            /// groupId.
            /// </param>
            /// <param name='startActivityName'>
            /// In recovery mode, the rerun will start from this activity. If not
            /// specified, all activities will run.
            /// </param>
            /// <param name='parameters'>
            /// Parameters of the pipeline run. These parameters will be used only if the
            /// runId is not specified.
            /// </param>
            public static CreateRunResponse CreatePipelineRun(this IPipelineOperations operations, string pipelineName, string referencePipelineRunId = default(string), bool? isRecovery = default(bool?), string startActivityName = default(string), IDictionary<string, object> parameters = default(IDictionary<string, object>))
            {
                return operations.CreatePipelineRunAsync(pipelineName, referencePipelineRunId, isRecovery, startActivityName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a run of a pipeline.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pipelineName'>
            /// The pipeline name.
            /// </param>
            /// <param name='referencePipelineRunId'>
            /// The pipeline run identifier. If run ID is specified the parameters of the
            /// specified run will be used to create a new run.
            /// </param>
            /// <param name='isRecovery'>
            /// Recovery mode flag. If recovery mode is set to true, the specified
            /// referenced pipeline run and the new run will be grouped under the same
            /// groupId.
            /// </param>
            /// <param name='startActivityName'>
            /// In recovery mode, the rerun will start from this activity. If not
            /// specified, all activities will run.
            /// </param>
            /// <param name='parameters'>
            /// Parameters of the pipeline run. These parameters will be used only if the
            /// runId is not specified.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CreateRunResponse> CreatePipelineRunAsync(this IPipelineOperations operations, string pipelineName, string referencePipelineRunId = default(string), bool? isRecovery = default(bool?), string startActivityName = default(string), IDictionary<string, object> parameters = default(IDictionary<string, object>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreatePipelineRunWithHttpMessagesAsync(pipelineName, referencePipelineRunId, isRecovery, startActivityName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists pipelines.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PipelineResource> GetPipelinesByWorkspaceNext(this IPipelineOperations operations, string nextPageLink)
            {
                return operations.GetPipelinesByWorkspaceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists pipelines.
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
            public static async Task<IPage<PipelineResource>> GetPipelinesByWorkspaceNextAsync(this IPipelineOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPipelinesByWorkspaceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
