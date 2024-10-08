/*
 * AT Protocol XRPC API
 *
 * This section contains HTTP API reference docs for Bluesky and AT Protocol lexicons. Generate a bearer token to test API calls directly from the docs.
 *
 * The version of the OpenAPI document: 0.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using BSky.Client;
using BSky.Model;

namespace BSky.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAppBskyVideoApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get status details for a video processing job.
        /// </remarks>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AppBskyVideoGetJobStatus200Response</returns>
        AppBskyVideoGetJobStatus200Response AppBskyVideoGetJobStatus(string jobId, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get status details for a video processing job.
        /// </remarks>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AppBskyVideoGetJobStatus200Response</returns>
        ApiResponse<AppBskyVideoGetJobStatus200Response> AppBskyVideoGetJobStatusWithHttpInfo(string jobId, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get video upload limits for the authenticated user.
        /// </remarks>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AppBskyVideoGetUploadLimits200Response</returns>
        AppBskyVideoGetUploadLimits200Response AppBskyVideoGetUploadLimits(int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get video upload limits for the authenticated user.
        /// </remarks>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AppBskyVideoGetUploadLimits200Response</returns>
        ApiResponse<AppBskyVideoGetUploadLimits200Response> AppBskyVideoGetUploadLimitsWithHttpInfo(int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Upload a video to be processed then stored on the PDS.
        /// </remarks>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AppBskyVideoGetJobStatus200Response</returns>
        AppBskyVideoGetJobStatus200Response AppBskyVideoUploadVideo(int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Upload a video to be processed then stored on the PDS.
        /// </remarks>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AppBskyVideoGetJobStatus200Response</returns>
        ApiResponse<AppBskyVideoGetJobStatus200Response> AppBskyVideoUploadVideoWithHttpInfo(int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAppBskyVideoApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get status details for a video processing job.
        /// </remarks>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AppBskyVideoGetJobStatus200Response</returns>
        System.Threading.Tasks.Task<AppBskyVideoGetJobStatus200Response> AppBskyVideoGetJobStatusAsync(string jobId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get status details for a video processing job.
        /// </remarks>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AppBskyVideoGetJobStatus200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AppBskyVideoGetJobStatus200Response>> AppBskyVideoGetJobStatusWithHttpInfoAsync(string jobId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get video upload limits for the authenticated user.
        /// </remarks>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AppBskyVideoGetUploadLimits200Response</returns>
        System.Threading.Tasks.Task<AppBskyVideoGetUploadLimits200Response> AppBskyVideoGetUploadLimitsAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get video upload limits for the authenticated user.
        /// </remarks>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AppBskyVideoGetUploadLimits200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AppBskyVideoGetUploadLimits200Response>> AppBskyVideoGetUploadLimitsWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Upload a video to be processed then stored on the PDS.
        /// </remarks>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AppBskyVideoGetJobStatus200Response</returns>
        System.Threading.Tasks.Task<AppBskyVideoGetJobStatus200Response> AppBskyVideoUploadVideoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Upload a video to be processed then stored on the PDS.
        /// </remarks>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AppBskyVideoGetJobStatus200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AppBskyVideoGetJobStatus200Response>> AppBskyVideoUploadVideoWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAppBskyVideoApi : IAppBskyVideoApiSync, IAppBskyVideoApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AppBskyVideoApi : IAppBskyVideoApi
    {
        private BSky.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyVideoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AppBskyVideoApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyVideoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AppBskyVideoApi(string basePath)
        {
            this.Configuration = BSky.Client.Configuration.MergeConfigurations(
                BSky.Client.GlobalConfiguration.Instance,
                new BSky.Client.Configuration { BasePath = basePath }
            );
            this.Client = new BSky.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new BSky.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = BSky.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyVideoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AppBskyVideoApi(BSky.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = BSky.Client.Configuration.MergeConfigurations(
                BSky.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new BSky.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new BSky.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = BSky.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyVideoApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AppBskyVideoApi(BSky.Client.ISynchronousClient client, BSky.Client.IAsynchronousClient asyncClient, BSky.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = BSky.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public BSky.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public BSky.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public BSky.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public BSky.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  Get status details for a video processing job.
        /// </summary>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AppBskyVideoGetJobStatus200Response</returns>
        public AppBskyVideoGetJobStatus200Response AppBskyVideoGetJobStatus(string jobId, int operationIndex = 0)
        {
            BSky.Client.ApiResponse<AppBskyVideoGetJobStatus200Response> localVarResponse = AppBskyVideoGetJobStatusWithHttpInfo(jobId);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Get status details for a video processing job.
        /// </summary>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AppBskyVideoGetJobStatus200Response</returns>
        public BSky.Client.ApiResponse<AppBskyVideoGetJobStatus200Response> AppBskyVideoGetJobStatusWithHttpInfo(string jobId, int operationIndex = 0)
        {
            // verify the required parameter 'jobId' is set
            if (jobId == null)
            {
                throw new BSky.Client.ApiException(400, "Missing required parameter 'jobId' when calling AppBskyVideoApi->AppBskyVideoGetJobStatus");
            }

            BSky.Client.RequestOptions localVarRequestOptions = new BSky.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = BSky.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = BSky.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(BSky.Client.ClientUtils.ParameterToMultiMap("", "jobId", jobId));

            localVarRequestOptions.Operation = "AppBskyVideoApi.AppBskyVideoGetJobStatus";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<AppBskyVideoGetJobStatus200Response>("/app.bsky.video.getJobStatus", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AppBskyVideoGetJobStatus", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Get status details for a video processing job.
        /// </summary>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AppBskyVideoGetJobStatus200Response</returns>
        public async System.Threading.Tasks.Task<AppBskyVideoGetJobStatus200Response> AppBskyVideoGetJobStatusAsync(string jobId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            BSky.Client.ApiResponse<AppBskyVideoGetJobStatus200Response> localVarResponse = await AppBskyVideoGetJobStatusWithHttpInfoAsync(jobId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Get status details for a video processing job.
        /// </summary>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AppBskyVideoGetJobStatus200Response)</returns>
        public async System.Threading.Tasks.Task<BSky.Client.ApiResponse<AppBskyVideoGetJobStatus200Response>> AppBskyVideoGetJobStatusWithHttpInfoAsync(string jobId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'jobId' is set
            if (jobId == null)
            {
                throw new BSky.Client.ApiException(400, "Missing required parameter 'jobId' when calling AppBskyVideoApi->AppBskyVideoGetJobStatus");
            }


            BSky.Client.RequestOptions localVarRequestOptions = new BSky.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = BSky.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = BSky.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(BSky.Client.ClientUtils.ParameterToMultiMap("", "jobId", jobId));

            localVarRequestOptions.Operation = "AppBskyVideoApi.AppBskyVideoGetJobStatus";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<AppBskyVideoGetJobStatus200Response>("/app.bsky.video.getJobStatus", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AppBskyVideoGetJobStatus", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Get video upload limits for the authenticated user.
        /// </summary>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AppBskyVideoGetUploadLimits200Response</returns>
        public AppBskyVideoGetUploadLimits200Response AppBskyVideoGetUploadLimits(int operationIndex = 0)
        {
            BSky.Client.ApiResponse<AppBskyVideoGetUploadLimits200Response> localVarResponse = AppBskyVideoGetUploadLimitsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Get video upload limits for the authenticated user.
        /// </summary>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AppBskyVideoGetUploadLimits200Response</returns>
        public BSky.Client.ApiResponse<AppBskyVideoGetUploadLimits200Response> AppBskyVideoGetUploadLimitsWithHttpInfo(int operationIndex = 0)
        {
            BSky.Client.RequestOptions localVarRequestOptions = new BSky.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = BSky.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = BSky.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "AppBskyVideoApi.AppBskyVideoGetUploadLimits";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<AppBskyVideoGetUploadLimits200Response>("/app.bsky.video.getUploadLimits", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AppBskyVideoGetUploadLimits", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Get video upload limits for the authenticated user.
        /// </summary>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AppBskyVideoGetUploadLimits200Response</returns>
        public async System.Threading.Tasks.Task<AppBskyVideoGetUploadLimits200Response> AppBskyVideoGetUploadLimitsAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            BSky.Client.ApiResponse<AppBskyVideoGetUploadLimits200Response> localVarResponse = await AppBskyVideoGetUploadLimitsWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Get video upload limits for the authenticated user.
        /// </summary>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AppBskyVideoGetUploadLimits200Response)</returns>
        public async System.Threading.Tasks.Task<BSky.Client.ApiResponse<AppBskyVideoGetUploadLimits200Response>> AppBskyVideoGetUploadLimitsWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {

            BSky.Client.RequestOptions localVarRequestOptions = new BSky.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = BSky.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = BSky.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "AppBskyVideoApi.AppBskyVideoGetUploadLimits";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<AppBskyVideoGetUploadLimits200Response>("/app.bsky.video.getUploadLimits", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AppBskyVideoGetUploadLimits", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Upload a video to be processed then stored on the PDS.
        /// </summary>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AppBskyVideoGetJobStatus200Response</returns>
        public AppBskyVideoGetJobStatus200Response AppBskyVideoUploadVideo(int operationIndex = 0)
        {
            BSky.Client.ApiResponse<AppBskyVideoGetJobStatus200Response> localVarResponse = AppBskyVideoUploadVideoWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Upload a video to be processed then stored on the PDS.
        /// </summary>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AppBskyVideoGetJobStatus200Response</returns>
        public BSky.Client.ApiResponse<AppBskyVideoGetJobStatus200Response> AppBskyVideoUploadVideoWithHttpInfo(int operationIndex = 0)
        {
            BSky.Client.RequestOptions localVarRequestOptions = new BSky.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "video/mp4"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = BSky.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = BSky.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "AppBskyVideoApi.AppBskyVideoUploadVideo";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<AppBskyVideoGetJobStatus200Response>("/app.bsky.video.uploadVideo", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AppBskyVideoUploadVideo", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Upload a video to be processed then stored on the PDS.
        /// </summary>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AppBskyVideoGetJobStatus200Response</returns>
        public async System.Threading.Tasks.Task<AppBskyVideoGetJobStatus200Response> AppBskyVideoUploadVideoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            BSky.Client.ApiResponse<AppBskyVideoGetJobStatus200Response> localVarResponse = await AppBskyVideoUploadVideoWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Upload a video to be processed then stored on the PDS.
        /// </summary>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AppBskyVideoGetJobStatus200Response)</returns>
        public async System.Threading.Tasks.Task<BSky.Client.ApiResponse<AppBskyVideoGetJobStatus200Response>> AppBskyVideoUploadVideoWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {

            BSky.Client.RequestOptions localVarRequestOptions = new BSky.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "video/mp4"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = BSky.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = BSky.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "AppBskyVideoApi.AppBskyVideoUploadVideo";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<AppBskyVideoGetJobStatus200Response>("/app.bsky.video.uploadVideo", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AppBskyVideoUploadVideo", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
