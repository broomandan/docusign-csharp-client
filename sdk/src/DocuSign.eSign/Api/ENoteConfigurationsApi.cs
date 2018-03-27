/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;
using RestSharp;

namespace DocuSign.eSign.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IENoteConfigurationsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Deletes configuration information for the eNote eOriginal integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <returns></returns>
        void ENoteConfigurationDeleteENoteConfiguration (string accountId);

        /// <summary>
        /// Deletes configuration information for the eNote eOriginal integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ENoteConfigurationDeleteENoteConfigurationWithHttpInfo (string accountId);
        /// <summary>
        /// Returns the configuration information for the eNote eOriginal integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <returns>ENoteConfigurations</returns>
        ENoteConfigurations ENoteConfigurationGetENoteConfiguration (string accountId);

        /// <summary>
        /// Returns the configuration information for the eNote eOriginal integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <returns>ApiResponse of ENoteConfigurations</returns>
        ApiResponse<ENoteConfigurations> ENoteConfigurationGetENoteConfigurationWithHttpInfo (string accountId);
        /// <summary>
        /// Updates configuration information for the eNote eOriginal integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="eNoteConfigurations"> (optional)</param>
        /// <returns>ENoteConfigurations</returns>
        ENoteConfigurations ENoteConfigurationPutENoteConfiguration (string accountId, ENoteConfigurations eNoteConfigurations = null);

        /// <summary>
        /// Updates configuration information for the eNote eOriginal integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="eNoteConfigurations"> (optional)</param>
        /// <returns>ApiResponse of ENoteConfigurations</returns>
        ApiResponse<ENoteConfigurations> ENoteConfigurationPutENoteConfigurationWithHttpInfo (string accountId, ENoteConfigurations eNoteConfigurations = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Deletes configuration information for the eNote eOriginal integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ENoteConfigurationDeleteENoteConfigurationAsync (string accountId);

        /// <summary>
        /// Deletes configuration information for the eNote eOriginal integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ENoteConfigurationDeleteENoteConfigurationAsyncWithHttpInfo (string accountId);
        /// <summary>
        /// Returns the configuration information for the eNote eOriginal integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <returns>Task of ENoteConfigurations</returns>
        System.Threading.Tasks.Task<ENoteConfigurations> ENoteConfigurationGetENoteConfigurationAsync (string accountId);

        /// <summary>
        /// Returns the configuration information for the eNote eOriginal integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <returns>Task of ApiResponse (ENoteConfigurations)</returns>
        System.Threading.Tasks.Task<ApiResponse<ENoteConfigurations>> ENoteConfigurationGetENoteConfigurationAsyncWithHttpInfo (string accountId);
        /// <summary>
        /// Updates configuration information for the eNote eOriginal integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="eNoteConfigurations"> (optional)</param>
        /// <returns>Task of ENoteConfigurations</returns>
        System.Threading.Tasks.Task<ENoteConfigurations> ENoteConfigurationPutENoteConfigurationAsync (string accountId, ENoteConfigurations eNoteConfigurations = null);

        /// <summary>
        /// Updates configuration information for the eNote eOriginal integration.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="eNoteConfigurations"> (optional)</param>
        /// <returns>Task of ApiResponse (ENoteConfigurations)</returns>
        System.Threading.Tasks.Task<ApiResponse<ENoteConfigurations>> ENoteConfigurationPutENoteConfigurationAsyncWithHttpInfo (string accountId, ENoteConfigurations eNoteConfigurations = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ENoteConfigurationsApi : IENoteConfigurationsApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ENoteConfigurationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ENoteConfigurationsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ENoteConfigurationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ENoteConfigurationsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Deletes configuration information for the eNote eOriginal integration. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <returns></returns>
        public void ENoteConfigurationDeleteENoteConfiguration (string accountId)
        {
             ENoteConfigurationDeleteENoteConfigurationWithHttpInfo(accountId);
        }

        /// <summary>
        /// Deletes configuration information for the eNote eOriginal integration. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ENoteConfigurationDeleteENoteConfigurationWithHttpInfo (string accountId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling ENoteConfigurationsApi->ENoteConfigurationDeleteENoteConfiguration");

            var localVarPath = "/v2/accounts/{accountId}/settings/enote_configuration";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ENoteConfigurationDeleteENoteConfiguration", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Deletes configuration information for the eNote eOriginal integration. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ENoteConfigurationDeleteENoteConfigurationAsync (string accountId)
        {
             await ENoteConfigurationDeleteENoteConfigurationAsyncWithHttpInfo(accountId);

        }

        /// <summary>
        /// Deletes configuration information for the eNote eOriginal integration. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ENoteConfigurationDeleteENoteConfigurationAsyncWithHttpInfo (string accountId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling ENoteConfigurationsApi->ENoteConfigurationDeleteENoteConfiguration");

            var localVarPath = "/v2/accounts/{accountId}/settings/enote_configuration";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ENoteConfigurationDeleteENoteConfiguration", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Returns the configuration information for the eNote eOriginal integration. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <returns>ENoteConfigurations</returns>
        public ENoteConfigurations ENoteConfigurationGetENoteConfiguration (string accountId)
        {
             ApiResponse<ENoteConfigurations> localVarResponse = ENoteConfigurationGetENoteConfigurationWithHttpInfo(accountId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the configuration information for the eNote eOriginal integration. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <returns>ApiResponse of ENoteConfigurations</returns>
        public ApiResponse< ENoteConfigurations > ENoteConfigurationGetENoteConfigurationWithHttpInfo (string accountId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling ENoteConfigurationsApi->ENoteConfigurationGetENoteConfiguration");

            var localVarPath = "/v2/accounts/{accountId}/settings/enote_configuration";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ENoteConfigurationGetENoteConfiguration", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ENoteConfigurations>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ENoteConfigurations) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ENoteConfigurations)));
            
        }

        /// <summary>
        /// Returns the configuration information for the eNote eOriginal integration. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <returns>Task of ENoteConfigurations</returns>
        public async System.Threading.Tasks.Task<ENoteConfigurations> ENoteConfigurationGetENoteConfigurationAsync (string accountId)
        {
             ApiResponse<ENoteConfigurations> localVarResponse = await ENoteConfigurationGetENoteConfigurationAsyncWithHttpInfo(accountId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns the configuration information for the eNote eOriginal integration. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <returns>Task of ApiResponse (ENoteConfigurations)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ENoteConfigurations>> ENoteConfigurationGetENoteConfigurationAsyncWithHttpInfo (string accountId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling ENoteConfigurationsApi->ENoteConfigurationGetENoteConfiguration");

            var localVarPath = "/v2/accounts/{accountId}/settings/enote_configuration";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ENoteConfigurationGetENoteConfiguration", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ENoteConfigurations>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ENoteConfigurations) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ENoteConfigurations)));
            
        }

        /// <summary>
        /// Updates configuration information for the eNote eOriginal integration. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="eNoteConfigurations"> (optional)</param>
        /// <returns>ENoteConfigurations</returns>
        public ENoteConfigurations ENoteConfigurationPutENoteConfiguration (string accountId, ENoteConfigurations eNoteConfigurations = null)
        {
             ApiResponse<ENoteConfigurations> localVarResponse = ENoteConfigurationPutENoteConfigurationWithHttpInfo(accountId, eNoteConfigurations);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates configuration information for the eNote eOriginal integration. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="eNoteConfigurations"> (optional)</param>
        /// <returns>ApiResponse of ENoteConfigurations</returns>
        public ApiResponse< ENoteConfigurations > ENoteConfigurationPutENoteConfigurationWithHttpInfo (string accountId, ENoteConfigurations eNoteConfigurations = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling ENoteConfigurationsApi->ENoteConfigurationPutENoteConfiguration");

            var localVarPath = "/v2/accounts/{accountId}/settings/enote_configuration";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (eNoteConfigurations != null && eNoteConfigurations.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(eNoteConfigurations); // http body (model) parameter
            }
            else
            {
                localVarPostBody = eNoteConfigurations; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ENoteConfigurationPutENoteConfiguration", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ENoteConfigurations>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ENoteConfigurations) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ENoteConfigurations)));
            
        }

        /// <summary>
        /// Updates configuration information for the eNote eOriginal integration. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="eNoteConfigurations"> (optional)</param>
        /// <returns>Task of ENoteConfigurations</returns>
        public async System.Threading.Tasks.Task<ENoteConfigurations> ENoteConfigurationPutENoteConfigurationAsync (string accountId, ENoteConfigurations eNoteConfigurations = null)
        {
             ApiResponse<ENoteConfigurations> localVarResponse = await ENoteConfigurationPutENoteConfigurationAsyncWithHttpInfo(accountId, eNoteConfigurations);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates configuration information for the eNote eOriginal integration. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="eNoteConfigurations"> (optional)</param>
        /// <returns>Task of ApiResponse (ENoteConfigurations)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ENoteConfigurations>> ENoteConfigurationPutENoteConfigurationAsyncWithHttpInfo (string accountId, ENoteConfigurations eNoteConfigurations = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling ENoteConfigurationsApi->ENoteConfigurationPutENoteConfiguration");

            var localVarPath = "/v2/accounts/{accountId}/settings/enote_configuration";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (eNoteConfigurations != null && eNoteConfigurations.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(eNoteConfigurations); // http body (model) parameter
            }
            else
            {
                localVarPostBody = eNoteConfigurations; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ENoteConfigurationPutENoteConfiguration", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ENoteConfigurations>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ENoteConfigurations) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ENoteConfigurations)));
            
        }

    }
}