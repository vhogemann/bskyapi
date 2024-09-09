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
    public interface IComAtprotoLabelApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Find labels relevant to the provided AT-URI patterns. Public endpoint for moderation services, though may return different or additional results with auth.
        /// </remarks>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uriPatterns">List of AT URI patterns to match (boolean &#39;OR&#39;). Each may be a prefix (ending with &#39;*&#39;; will match inclusive of the string leading to &#39;*&#39;), or a full URI.</param>
        /// <param name="sources">Optional list of label sources (DIDs) to filter on. (optional)</param>
        /// <param name="limit"> (optional, default to 50)</param>
        /// <param name="cursor"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ComAtprotoLabelQueryLabels200Response</returns>
        ComAtprotoLabelQueryLabels200Response ComAtprotoLabelQueryLabels(List<string> uriPatterns, List<string>? sources = default(List<string>?), int? limit = default(int?), string? cursor = default(string?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Find labels relevant to the provided AT-URI patterns. Public endpoint for moderation services, though may return different or additional results with auth.
        /// </remarks>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uriPatterns">List of AT URI patterns to match (boolean &#39;OR&#39;). Each may be a prefix (ending with &#39;*&#39;; will match inclusive of the string leading to &#39;*&#39;), or a full URI.</param>
        /// <param name="sources">Optional list of label sources (DIDs) to filter on. (optional)</param>
        /// <param name="limit"> (optional, default to 50)</param>
        /// <param name="cursor"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ComAtprotoLabelQueryLabels200Response</returns>
        ApiResponse<ComAtprotoLabelQueryLabels200Response> ComAtprotoLabelQueryLabelsWithHttpInfo(List<string> uriPatterns, List<string>? sources = default(List<string>?), int? limit = default(int?), string? cursor = default(string?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IComAtprotoLabelApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Find labels relevant to the provided AT-URI patterns. Public endpoint for moderation services, though may return different or additional results with auth.
        /// </remarks>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uriPatterns">List of AT URI patterns to match (boolean &#39;OR&#39;). Each may be a prefix (ending with &#39;*&#39;; will match inclusive of the string leading to &#39;*&#39;), or a full URI.</param>
        /// <param name="sources">Optional list of label sources (DIDs) to filter on. (optional)</param>
        /// <param name="limit"> (optional, default to 50)</param>
        /// <param name="cursor"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ComAtprotoLabelQueryLabels200Response</returns>
        System.Threading.Tasks.Task<ComAtprotoLabelQueryLabels200Response> ComAtprotoLabelQueryLabelsAsync(List<string> uriPatterns, List<string>? sources = default(List<string>?), int? limit = default(int?), string? cursor = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Find labels relevant to the provided AT-URI patterns. Public endpoint for moderation services, though may return different or additional results with auth.
        /// </remarks>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uriPatterns">List of AT URI patterns to match (boolean &#39;OR&#39;). Each may be a prefix (ending with &#39;*&#39;; will match inclusive of the string leading to &#39;*&#39;), or a full URI.</param>
        /// <param name="sources">Optional list of label sources (DIDs) to filter on. (optional)</param>
        /// <param name="limit"> (optional, default to 50)</param>
        /// <param name="cursor"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ComAtprotoLabelQueryLabels200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ComAtprotoLabelQueryLabels200Response>> ComAtprotoLabelQueryLabelsWithHttpInfoAsync(List<string> uriPatterns, List<string>? sources = default(List<string>?), int? limit = default(int?), string? cursor = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IComAtprotoLabelApi : IComAtprotoLabelApiSync, IComAtprotoLabelApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ComAtprotoLabelApi : IComAtprotoLabelApi
    {
        private BSky.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoLabelApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ComAtprotoLabelApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoLabelApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ComAtprotoLabelApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ComAtprotoLabelApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ComAtprotoLabelApi(BSky.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ComAtprotoLabelApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ComAtprotoLabelApi(BSky.Client.ISynchronousClient client, BSky.Client.IAsynchronousClient asyncClient, BSky.Client.IReadableConfiguration configuration)
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
        ///  Find labels relevant to the provided AT-URI patterns. Public endpoint for moderation services, though may return different or additional results with auth.
        /// </summary>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uriPatterns">List of AT URI patterns to match (boolean &#39;OR&#39;). Each may be a prefix (ending with &#39;*&#39;; will match inclusive of the string leading to &#39;*&#39;), or a full URI.</param>
        /// <param name="sources">Optional list of label sources (DIDs) to filter on. (optional)</param>
        /// <param name="limit"> (optional, default to 50)</param>
        /// <param name="cursor"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ComAtprotoLabelQueryLabels200Response</returns>
        public ComAtprotoLabelQueryLabels200Response ComAtprotoLabelQueryLabels(List<string> uriPatterns, List<string>? sources = default(List<string>?), int? limit = default(int?), string? cursor = default(string?), int operationIndex = 0)
        {
            BSky.Client.ApiResponse<ComAtprotoLabelQueryLabels200Response> localVarResponse = ComAtprotoLabelQueryLabelsWithHttpInfo(uriPatterns, sources, limit, cursor);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Find labels relevant to the provided AT-URI patterns. Public endpoint for moderation services, though may return different or additional results with auth.
        /// </summary>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uriPatterns">List of AT URI patterns to match (boolean &#39;OR&#39;). Each may be a prefix (ending with &#39;*&#39;; will match inclusive of the string leading to &#39;*&#39;), or a full URI.</param>
        /// <param name="sources">Optional list of label sources (DIDs) to filter on. (optional)</param>
        /// <param name="limit"> (optional, default to 50)</param>
        /// <param name="cursor"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ComAtprotoLabelQueryLabels200Response</returns>
        public BSky.Client.ApiResponse<ComAtprotoLabelQueryLabels200Response> ComAtprotoLabelQueryLabelsWithHttpInfo(List<string> uriPatterns, List<string>? sources = default(List<string>?), int? limit = default(int?), string? cursor = default(string?), int operationIndex = 0)
        {
            // verify the required parameter 'uriPatterns' is set
            if (uriPatterns == null)
            {
                throw new BSky.Client.ApiException(400, "Missing required parameter 'uriPatterns' when calling ComAtprotoLabelApi->ComAtprotoLabelQueryLabels");
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

            localVarRequestOptions.QueryParameters.Add(BSky.Client.ClientUtils.ParameterToMultiMap("multi", "uriPatterns", uriPatterns));
            if (sources != null)
            {
                localVarRequestOptions.QueryParameters.Add(BSky.Client.ClientUtils.ParameterToMultiMap("multi", "sources", sources));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(BSky.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (cursor != null)
            {
                localVarRequestOptions.QueryParameters.Add(BSky.Client.ClientUtils.ParameterToMultiMap("", "cursor", cursor));
            }

            localVarRequestOptions.Operation = "ComAtprotoLabelApi.ComAtprotoLabelQueryLabels";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ComAtprotoLabelQueryLabels200Response>("/com.atproto.label.queryLabels", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ComAtprotoLabelQueryLabels", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Find labels relevant to the provided AT-URI patterns. Public endpoint for moderation services, though may return different or additional results with auth.
        /// </summary>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uriPatterns">List of AT URI patterns to match (boolean &#39;OR&#39;). Each may be a prefix (ending with &#39;*&#39;; will match inclusive of the string leading to &#39;*&#39;), or a full URI.</param>
        /// <param name="sources">Optional list of label sources (DIDs) to filter on. (optional)</param>
        /// <param name="limit"> (optional, default to 50)</param>
        /// <param name="cursor"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ComAtprotoLabelQueryLabels200Response</returns>
        public async System.Threading.Tasks.Task<ComAtprotoLabelQueryLabels200Response> ComAtprotoLabelQueryLabelsAsync(List<string> uriPatterns, List<string>? sources = default(List<string>?), int? limit = default(int?), string? cursor = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            BSky.Client.ApiResponse<ComAtprotoLabelQueryLabels200Response> localVarResponse = await ComAtprotoLabelQueryLabelsWithHttpInfoAsync(uriPatterns, sources, limit, cursor, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Find labels relevant to the provided AT-URI patterns. Public endpoint for moderation services, though may return different or additional results with auth.
        /// </summary>
        /// <exception cref="BSky.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uriPatterns">List of AT URI patterns to match (boolean &#39;OR&#39;). Each may be a prefix (ending with &#39;*&#39;; will match inclusive of the string leading to &#39;*&#39;), or a full URI.</param>
        /// <param name="sources">Optional list of label sources (DIDs) to filter on. (optional)</param>
        /// <param name="limit"> (optional, default to 50)</param>
        /// <param name="cursor"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ComAtprotoLabelQueryLabels200Response)</returns>
        public async System.Threading.Tasks.Task<BSky.Client.ApiResponse<ComAtprotoLabelQueryLabels200Response>> ComAtprotoLabelQueryLabelsWithHttpInfoAsync(List<string> uriPatterns, List<string>? sources = default(List<string>?), int? limit = default(int?), string? cursor = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'uriPatterns' is set
            if (uriPatterns == null)
            {
                throw new BSky.Client.ApiException(400, "Missing required parameter 'uriPatterns' when calling ComAtprotoLabelApi->ComAtprotoLabelQueryLabels");
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

            localVarRequestOptions.QueryParameters.Add(BSky.Client.ClientUtils.ParameterToMultiMap("multi", "uriPatterns", uriPatterns));
            if (sources != null)
            {
                localVarRequestOptions.QueryParameters.Add(BSky.Client.ClientUtils.ParameterToMultiMap("multi", "sources", sources));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(BSky.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (cursor != null)
            {
                localVarRequestOptions.QueryParameters.Add(BSky.Client.ClientUtils.ParameterToMultiMap("", "cursor", cursor));
            }

            localVarRequestOptions.Operation = "ComAtprotoLabelApi.ComAtprotoLabelQueryLabels";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ComAtprotoLabelQueryLabels200Response>("/com.atproto.label.queryLabels", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ComAtprotoLabelQueryLabels", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
