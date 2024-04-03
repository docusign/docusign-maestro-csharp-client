/* 
 * Maestro API
 *
 * Maestro authors and executes experiences that allow non-coders the ability to define Simple Business Process without having to write code and to deploy them seamlessly without having to have development expertise
 *
 * OpenAPI spec version: 1.0.0
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using DocuSign.Maestro.Client;
using DocuSign.Maestro.Model;

namespace DocuSign.Maestro.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWorkflowTriggerApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Creates a new workflow instance after authenticating with DS Account Server
        /// </summary>
        /// <remarks>
        /// Creates a new workflow instance after authenticating with DS Account Server
        /// </remarks>
        /// <exception cref="DocuSign.Maestro.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Account ID</param>
        /// <param name="body">JSON payload that will be passed to the triggered workflow</param>
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns></returns>
        TriggerWorkflowViaPostResponse TriggerWorkflow(string accountId, TriggerPayload body, WorkflowTriggerApi.TriggerWorkflowOptions options = null);

        /// <summary>
        /// Creates a new workflow instance after authenticating with DS Account Server
        /// </summary>
        /// <remarks>
        /// Creates a new workflow instance after authenticating with DS Account Server
        /// </remarks>
        /// <exception cref="DocuSign.Maestro.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Account ID</param>
        /// <param name="body">JSON payload that will be passed to the triggered workflow</param>
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>ApiResponse of </returns>
        ApiResponse<TriggerWorkflowViaPostResponse> TriggerWorkflowWithHttpInfo(string accountId, TriggerPayload body, WorkflowTriggerApi.TriggerWorkflowOptions options = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Creates a new workflow instance after authenticating with DS Account Server
        /// </summary>
        /// <remarks>
        /// Creates a new workflow instance after authenticating with DS Account Server
        /// </remarks>
        /// <exception cref="DocuSign.Maestro.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Account ID</param>
        /// <param name="body">JSON payload that will be passed to the triggered workflow</param>
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of TriggerWorkflowViaPostResponse</returns>
        System.Threading.Tasks.Task<TriggerWorkflowViaPostResponse> TriggerWorkflowAsync(string accountId, TriggerPayload body, WorkflowTriggerApi.TriggerWorkflowOptions options = null);

        /// <summary>
        /// Creates a new workflow instance after authenticating with DS Account Server
        /// </summary>
        /// <remarks>
        /// Creates a new workflow instance after authenticating with DS Account Server
        /// </remarks>
        /// <exception cref="DocuSign.Maestro.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Account ID</param>
        /// <param name="body">JSON payload that will be passed to the triggered workflow</param>
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of ApiResponse (TriggerWorkflowViaPostResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TriggerWorkflowViaPostResponse>> TriggerWorkflowAsyncWithHttpInfo(string accountId, TriggerPayload body, WorkflowTriggerApi.TriggerWorkflowOptions options = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WorkflowTriggerApi : IWorkflowTriggerApi
    {
        private DocuSign.Maestro.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTriggerApi"/> class
        /// using AplClient object
        /// </summary>
        /// <param name="aplClient">An instance of AplClient</param>
        /// <returns></returns>
        public WorkflowTriggerApi(DocuSignClient aplClient)
        {
            this.ApiClient = aplClient;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.ApiClient.GetBasePath();
        }

        /// <summary>
        /// Gets or sets the ApiClient object
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public DocuSignClient ApiClient { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public DocuSign.Maestro.Client.ExceptionFactory ExceptionFactory
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
        /// Creates a new workflow instance after authenticating with DS Account Server Creates a new workflow instance after authenticating with DS Account Server
        /// </summary>
        public class TriggerWorkflowOptions
        {
            /// Managed Token Id registered with DS Account Server 
            public string mtid {get; set;}
            /// Managed Token Secret registered with DS Account Server 
            public string mtsec {get; set;}
        }

        /// <summary>
        /// Creates a new workflow instance after authenticating with DS Account Server Creates a new workflow instance after authenticating with DS Account Server
        /// </summary>
        /// <exception cref="DocuSign.Maestro.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Account ID</param>
        /// <param name="body">JSON payload that will be passed to the triggered workflow</param>
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>TriggerWorkflowViaPostResponse</returns>
        public TriggerWorkflowViaPostResponse TriggerWorkflow(string accountId, TriggerPayload body, WorkflowTriggerApi.TriggerWorkflowOptions options = null)
        {
             ApiResponse<TriggerWorkflowViaPostResponse> localVarResponse = TriggerWorkflowWithHttpInfo(accountId, body, options);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a new workflow instance after authenticating with DS Account Server Creates a new workflow instance after authenticating with DS Account Server
        /// </summary>
        /// <exception cref="DocuSign.Maestro.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Account ID</param>
        /// <param name="body">JSON payload that will be passed to the triggered workflow</param>
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>ApiResponse of TriggerWorkflowViaPostResponse</returns>
        public ApiResponse<TriggerWorkflowViaPostResponse> TriggerWorkflowWithHttpInfo(string accountId, TriggerPayload body, WorkflowTriggerApi.TriggerWorkflowOptions options = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling WorkflowTriggerApi->TriggerWorkflow");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkflowTriggerApi->TriggerWorkflow");

            var localVarPath = "aow-auth/v1.0/accounts/{accountId}/workflows/trigger";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(this.ApiClient.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new List<FileParameter>();
            Object localVarPostBody = null;
            String localVarHttpContentDisposition = string.Empty;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", this.ApiClient.ParameterToString(accountId)); // path parameter
            if (options != null)
            {
                if (options.mtid != null) localVarQueryParams.Add("mtid", this.ApiClient.ParameterToString(options.mtid)); // query parameter
                if (options.mtsec != null) localVarQueryParams.Add("mtsec", this.ApiClient.ParameterToString(options.mtsec)); // query parameter
            }
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (docusignAccessCode) required
            // oauth required
            if (!String.IsNullOrEmpty(this.ApiClient.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.ApiClient.Configuration.AccessToken;
            }


            // make the HTTP request
            DocuSignRequest localVarRequest = this.ApiClient.PrepareRequest(localVarPath, new HttpMethod("POST"), localVarQueryParams.ToList(), localVarPostBody, localVarHeaderParams.ToList(), localVarFormParams.ToList(), localVarPathParams.ToList(), localVarFileParams, localVarHttpContentType, localVarHttpContentDisposition);
            DocuSignResponse localVarResponse = this.ApiClient.CallApi(localVarRequest);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TriggerWorkflow", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TriggerWorkflowViaPostResponse>(localVarStatusCode, 
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()), 
                (TriggerWorkflowViaPostResponse)this.ApiClient.Deserialize(localVarResponse, typeof(TriggerWorkflowViaPostResponse)));
        }

        /// <summary>
        /// Creates a new workflow instance after authenticating with DS Account Server Creates a new workflow instance after authenticating with DS Account Server
        /// </summary>
        /// <exception cref="DocuSign.Maestro.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Account ID</param>
        /// <param name="body">JSON payload that will be passed to the triggered workflow</param>
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of TriggerWorkflowViaPostResponse</returns>
        public async System.Threading.Tasks.Task<TriggerWorkflowViaPostResponse> TriggerWorkflowAsync(string accountId, TriggerPayload body, WorkflowTriggerApi.TriggerWorkflowOptions options = null)
        {
             ApiResponse<TriggerWorkflowViaPostResponse> localVarResponse = await TriggerWorkflowAsyncWithHttpInfo(accountId, body, options);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a new workflow instance after authenticating with DS Account Server Creates a new workflow instance after authenticating with DS Account Server
        /// </summary>
        /// <exception cref="DocuSign.Maestro.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Account ID</param>
        /// <param name="body">JSON payload that will be passed to the triggered workflow</param>
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of ApiResponse (TriggerWorkflowViaPostResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TriggerWorkflowViaPostResponse>> TriggerWorkflowAsyncWithHttpInfo(string accountId, TriggerPayload body, WorkflowTriggerApi.TriggerWorkflowOptions options = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling WorkflowTriggerApi->TriggerWorkflow");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkflowTriggerApi->TriggerWorkflow");

            var localVarPath = "aow-auth/v1.0/accounts/{accountId}/workflows/trigger";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(this.ApiClient.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new List<FileParameter>();
            Object localVarPostBody = null;
            String localVarHttpContentDisposition = string.Empty;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", this.ApiClient.ParameterToString(accountId)); // path parameter
            if (options != null)
            {
                if (options.mtid != null) localVarQueryParams.Add("mtid", this.ApiClient.ParameterToString(options.mtid)); // query parameter
                if (options.mtsec != null) localVarQueryParams.Add("mtsec", this.ApiClient.ParameterToString(options.mtsec)); // query parameter
            }
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (docusignAccessCode) required
            // oauth required
            if (!String.IsNullOrEmpty(this.ApiClient.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.ApiClient.Configuration.AccessToken;
            }


            // make the HTTP request
            DocuSignRequest localVarRequest = this.ApiClient.PrepareRequest(localVarPath, new HttpMethod("POST"), localVarQueryParams.ToList(), localVarPostBody, localVarHeaderParams.ToList(), localVarFormParams.ToList(), localVarPathParams.ToList(), localVarFileParams, localVarHttpContentType, localVarHttpContentDisposition);
            DocuSignResponse localVarResponse = await this.ApiClient.CallApiAsync(localVarRequest);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TriggerWorkflow", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TriggerWorkflowViaPostResponse>(localVarStatusCode, 
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()), 
                (TriggerWorkflowViaPostResponse)this.ApiClient.Deserialize(localVarResponse, typeof(TriggerWorkflowViaPostResponse)));
        }

    }
}