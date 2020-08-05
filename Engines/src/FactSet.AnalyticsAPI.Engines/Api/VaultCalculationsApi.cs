/* 
 * Engines API
 *
 * Allow clients to fetch Engines Analytics through APIs.
 *
 * The version of the OpenAPI document: 2
 * Contact: analytics.api.support@factset.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using FactSet.AnalyticsAPI.Engines.Client;
using FactSet.AnalyticsAPI.Engines.Model;

namespace FactSet.AnalyticsAPI.Engines.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVaultCalculationsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Cancel Vault calculation by id
        /// </summary>
        /// <remarks>
        /// This is the endpoint to cancel a previously submitted calculation.  Instead of doing a GET on the polling URL, cancel the request by doing a DELETE.
        /// </remarks>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">from url, provided from the location header in the Run Calculation endpoint</param>
        /// <returns></returns>
        void CancelVaultCalculationById (string id);

        /// <summary>
        /// Cancel Vault calculation by id
        /// </summary>
        /// <remarks>
        /// This is the endpoint to cancel a previously submitted calculation.  Instead of doing a GET on the polling URL, cancel the request by doing a DELETE.
        /// </remarks>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">from url, provided from the location header in the Run Calculation endpoint</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CancelVaultCalculationByIdWithHttpInfo (string id);
        /// <summary>
        /// Get Vault calculation by id
        /// </summary>
        /// <remarks>
        /// This is the endpoint to check on the progress of a previously requested calculation.  If the calculation has finished computing, the body of the response will contain the requested document in JSON.
        /// </remarks>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">from url, provided from the location header in the Run Calculation endpoint</param>
        /// <returns>Object</returns>
        Object GetVaultCalculationById (string id);

        /// <summary>
        /// Get Vault calculation by id
        /// </summary>
        /// <remarks>
        /// This is the endpoint to check on the progress of a previously requested calculation.  If the calculation has finished computing, the body of the response will contain the requested document in JSON.
        /// </remarks>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">from url, provided from the location header in the Run Calculation endpoint</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> GetVaultCalculationByIdWithHttpInfo (string id);
        /// <summary>
        /// Run Vault Calculation
        /// </summary>
        /// <remarks>
        /// This endpoint runs the Vault calculation specified in the POST body parameters.  It must be used first before polling or cancelling endpoints.  A successful response will contain the URL to poll for the result of the calculation.    Remarks:    *   Start and and end date must be within the configuration&#39;s min and max date range
        /// </remarks>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vaultCalculationParameters"> (optional)</param>
        /// <returns>Object</returns>
        Object RunVaultCalculation (VaultCalculationParameters vaultCalculationParameters = default(VaultCalculationParameters));

        /// <summary>
        /// Run Vault Calculation
        /// </summary>
        /// <remarks>
        /// This endpoint runs the Vault calculation specified in the POST body parameters.  It must be used first before polling or cancelling endpoints.  A successful response will contain the URL to poll for the result of the calculation.    Remarks:    *   Start and and end date must be within the configuration&#39;s min and max date range
        /// </remarks>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vaultCalculationParameters"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> RunVaultCalculationWithHttpInfo (VaultCalculationParameters vaultCalculationParameters = default(VaultCalculationParameters));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVaultCalculationsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Cancel Vault calculation by id
        /// </summary>
        /// <remarks>
        /// This is the endpoint to cancel a previously submitted calculation.  Instead of doing a GET on the polling URL, cancel the request by doing a DELETE.
        /// </remarks>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">from url, provided from the location header in the Run Calculation endpoint</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CancelVaultCalculationByIdAsync (string id);

        /// <summary>
        /// Cancel Vault calculation by id
        /// </summary>
        /// <remarks>
        /// This is the endpoint to cancel a previously submitted calculation.  Instead of doing a GET on the polling URL, cancel the request by doing a DELETE.
        /// </remarks>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">from url, provided from the location header in the Run Calculation endpoint</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CancelVaultCalculationByIdAsyncWithHttpInfo (string id);
        /// <summary>
        /// Get Vault calculation by id
        /// </summary>
        /// <remarks>
        /// This is the endpoint to check on the progress of a previously requested calculation.  If the calculation has finished computing, the body of the response will contain the requested document in JSON.
        /// </remarks>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">from url, provided from the location header in the Run Calculation endpoint</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> GetVaultCalculationByIdAsync (string id);

        /// <summary>
        /// Get Vault calculation by id
        /// </summary>
        /// <remarks>
        /// This is the endpoint to check on the progress of a previously requested calculation.  If the calculation has finished computing, the body of the response will contain the requested document in JSON.
        /// </remarks>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">from url, provided from the location header in the Run Calculation endpoint</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetVaultCalculationByIdAsyncWithHttpInfo (string id);
        /// <summary>
        /// Run Vault Calculation
        /// </summary>
        /// <remarks>
        /// This endpoint runs the Vault calculation specified in the POST body parameters.  It must be used first before polling or cancelling endpoints.  A successful response will contain the URL to poll for the result of the calculation.    Remarks:    *   Start and and end date must be within the configuration&#39;s min and max date range
        /// </remarks>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vaultCalculationParameters"> (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> RunVaultCalculationAsync (VaultCalculationParameters vaultCalculationParameters = default(VaultCalculationParameters));

        /// <summary>
        /// Run Vault Calculation
        /// </summary>
        /// <remarks>
        /// This endpoint runs the Vault calculation specified in the POST body parameters.  It must be used first before polling or cancelling endpoints.  A successful response will contain the URL to poll for the result of the calculation.    Remarks:    *   Start and and end date must be within the configuration&#39;s min and max date range
        /// </remarks>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vaultCalculationParameters"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RunVaultCalculationAsyncWithHttpInfo (VaultCalculationParameters vaultCalculationParameters = default(VaultCalculationParameters));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVaultCalculationsApi : IVaultCalculationsApiSync, IVaultCalculationsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class VaultCalculationsApi : IVaultCalculationsApi
    {
        private FactSet.AnalyticsAPI.Engines.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultCalculationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VaultCalculationsApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultCalculationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VaultCalculationsApi(String basePath)
        {
            this.Configuration = FactSet.AnalyticsAPI.Engines.Client.Configuration.MergeConfigurations(
                FactSet.AnalyticsAPI.Engines.Client.GlobalConfiguration.Instance,
                new FactSet.AnalyticsAPI.Engines.Client.Configuration { BasePath = basePath }
            );
            this.Client = new FactSet.AnalyticsAPI.Engines.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new FactSet.AnalyticsAPI.Engines.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = FactSet.AnalyticsAPI.Engines.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultCalculationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VaultCalculationsApi(FactSet.AnalyticsAPI.Engines.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = FactSet.AnalyticsAPI.Engines.Client.Configuration.MergeConfigurations(
                FactSet.AnalyticsAPI.Engines.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new FactSet.AnalyticsAPI.Engines.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new FactSet.AnalyticsAPI.Engines.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = FactSet.AnalyticsAPI.Engines.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultCalculationsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public VaultCalculationsApi(FactSet.AnalyticsAPI.Engines.Client.ISynchronousClient client,FactSet.AnalyticsAPI.Engines.Client.IAsynchronousClient asyncClient, FactSet.AnalyticsAPI.Engines.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = FactSet.AnalyticsAPI.Engines.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public FactSet.AnalyticsAPI.Engines.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public FactSet.AnalyticsAPI.Engines.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public FactSet.AnalyticsAPI.Engines.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public FactSet.AnalyticsAPI.Engines.Client.ExceptionFactory ExceptionFactory
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
        /// Cancel Vault calculation by id This is the endpoint to cancel a previously submitted calculation.  Instead of doing a GET on the polling URL, cancel the request by doing a DELETE.
        /// </summary>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">from url, provided from the location header in the Run Calculation endpoint</param>
        /// <returns></returns>
        public void CancelVaultCalculationById (string id)
        {
             CancelVaultCalculationByIdWithHttpInfo(id);
        }

        /// <summary>
        /// Cancel Vault calculation by id This is the endpoint to cancel a previously submitted calculation.  Instead of doing a GET on the polling URL, cancel the request by doing a DELETE.
        /// </summary>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">from url, provided from the location header in the Run Calculation endpoint</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public FactSet.AnalyticsAPI.Engines.Client.ApiResponse<Object> CancelVaultCalculationByIdWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new FactSet.AnalyticsAPI.Engines.Client.ApiException(400, "Missing required parameter 'id' when calling VaultCalculationsApi->CancelVaultCalculationById");

            FactSet.AnalyticsAPI.Engines.Client.RequestOptions localVarRequestOptions = new FactSet.AnalyticsAPI.Engines.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };

            var localVarContentType = FactSet.AnalyticsAPI.Engines.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = FactSet.AnalyticsAPI.Engines.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (id != null)
                localVarRequestOptions.PathParameters.Add("id", FactSet.AnalyticsAPI.Engines.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + FactSet.AnalyticsAPI.Engines.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/analytics/engines/vault/v2/calculations/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CancelVaultCalculationById", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Cancel Vault calculation by id This is the endpoint to cancel a previously submitted calculation.  Instead of doing a GET on the polling URL, cancel the request by doing a DELETE.
        /// </summary>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">from url, provided from the location header in the Run Calculation endpoint</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CancelVaultCalculationByIdAsync (string id)
        {
             await CancelVaultCalculationByIdAsyncWithHttpInfo(id);

        }

        /// <summary>
        /// Cancel Vault calculation by id This is the endpoint to cancel a previously submitted calculation.  Instead of doing a GET on the polling URL, cancel the request by doing a DELETE.
        /// </summary>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">from url, provided from the location header in the Run Calculation endpoint</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<FactSet.AnalyticsAPI.Engines.Client.ApiResponse<Object>> CancelVaultCalculationByIdAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new FactSet.AnalyticsAPI.Engines.Client.ApiException(400, "Missing required parameter 'id' when calling VaultCalculationsApi->CancelVaultCalculationById");


            FactSet.AnalyticsAPI.Engines.Client.RequestOptions localVarRequestOptions = new FactSet.AnalyticsAPI.Engines.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (id != null)
                localVarRequestOptions.PathParameters.Add("id", FactSet.AnalyticsAPI.Engines.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + FactSet.AnalyticsAPI.Engines.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/analytics/engines/vault/v2/calculations/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CancelVaultCalculationById", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Vault calculation by id This is the endpoint to check on the progress of a previously requested calculation.  If the calculation has finished computing, the body of the response will contain the requested document in JSON.
        /// </summary>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">from url, provided from the location header in the Run Calculation endpoint</param>
        /// <returns>Object</returns>
        public Object GetVaultCalculationById (string id)
        {
             FactSet.AnalyticsAPI.Engines.Client.ApiResponse<Object> localVarResponse = GetVaultCalculationByIdWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Vault calculation by id This is the endpoint to check on the progress of a previously requested calculation.  If the calculation has finished computing, the body of the response will contain the requested document in JSON.
        /// </summary>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">from url, provided from the location header in the Run Calculation endpoint</param>
        /// <returns>ApiResponse of Object</returns>
        public FactSet.AnalyticsAPI.Engines.Client.ApiResponse< Object > GetVaultCalculationByIdWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new FactSet.AnalyticsAPI.Engines.Client.ApiException(400, "Missing required parameter 'id' when calling VaultCalculationsApi->GetVaultCalculationById");

            FactSet.AnalyticsAPI.Engines.Client.RequestOptions localVarRequestOptions = new FactSet.AnalyticsAPI.Engines.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = FactSet.AnalyticsAPI.Engines.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = FactSet.AnalyticsAPI.Engines.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (id != null)
                localVarRequestOptions.PathParameters.Add("id", FactSet.AnalyticsAPI.Engines.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + FactSet.AnalyticsAPI.Engines.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< Object >("/analytics/engines/vault/v2/calculations/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetVaultCalculationById", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Vault calculation by id This is the endpoint to check on the progress of a previously requested calculation.  If the calculation has finished computing, the body of the response will contain the requested document in JSON.
        /// </summary>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">from url, provided from the location header in the Run Calculation endpoint</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> GetVaultCalculationByIdAsync (string id)
        {
             FactSet.AnalyticsAPI.Engines.Client.ApiResponse<Object> localVarResponse = await GetVaultCalculationByIdAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Vault calculation by id This is the endpoint to check on the progress of a previously requested calculation.  If the calculation has finished computing, the body of the response will contain the requested document in JSON.
        /// </summary>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">from url, provided from the location header in the Run Calculation endpoint</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<FactSet.AnalyticsAPI.Engines.Client.ApiResponse<Object>> GetVaultCalculationByIdAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new FactSet.AnalyticsAPI.Engines.Client.ApiException(400, "Missing required parameter 'id' when calling VaultCalculationsApi->GetVaultCalculationById");


            FactSet.AnalyticsAPI.Engines.Client.RequestOptions localVarRequestOptions = new FactSet.AnalyticsAPI.Engines.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (id != null)
                localVarRequestOptions.PathParameters.Add("id", FactSet.AnalyticsAPI.Engines.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + FactSet.AnalyticsAPI.Engines.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/analytics/engines/vault/v2/calculations/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetVaultCalculationById", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Run Vault Calculation This endpoint runs the Vault calculation specified in the POST body parameters.  It must be used first before polling or cancelling endpoints.  A successful response will contain the URL to poll for the result of the calculation.    Remarks:    *   Start and and end date must be within the configuration&#39;s min and max date range
        /// </summary>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vaultCalculationParameters"> (optional)</param>
        /// <returns>Object</returns>
        public Object RunVaultCalculation (VaultCalculationParameters vaultCalculationParameters = default(VaultCalculationParameters))
        {
             FactSet.AnalyticsAPI.Engines.Client.ApiResponse<Object> localVarResponse = RunVaultCalculationWithHttpInfo(vaultCalculationParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Run Vault Calculation This endpoint runs the Vault calculation specified in the POST body parameters.  It must be used first before polling or cancelling endpoints.  A successful response will contain the URL to poll for the result of the calculation.    Remarks:    *   Start and and end date must be within the configuration&#39;s min and max date range
        /// </summary>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vaultCalculationParameters"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        public FactSet.AnalyticsAPI.Engines.Client.ApiResponse< Object > RunVaultCalculationWithHttpInfo (VaultCalculationParameters vaultCalculationParameters = default(VaultCalculationParameters))
        {
            FactSet.AnalyticsAPI.Engines.Client.RequestOptions localVarRequestOptions = new FactSet.AnalyticsAPI.Engines.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = FactSet.AnalyticsAPI.Engines.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = FactSet.AnalyticsAPI.Engines.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = vaultCalculationParameters;

            // authentication (Basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + FactSet.AnalyticsAPI.Engines.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< Object >("/analytics/engines/vault/v2/calculations", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RunVaultCalculation", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Run Vault Calculation This endpoint runs the Vault calculation specified in the POST body parameters.  It must be used first before polling or cancelling endpoints.  A successful response will contain the URL to poll for the result of the calculation.    Remarks:    *   Start and and end date must be within the configuration&#39;s min and max date range
        /// </summary>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vaultCalculationParameters"> (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> RunVaultCalculationAsync (VaultCalculationParameters vaultCalculationParameters = default(VaultCalculationParameters))
        {
             FactSet.AnalyticsAPI.Engines.Client.ApiResponse<Object> localVarResponse = await RunVaultCalculationAsyncWithHttpInfo(vaultCalculationParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Run Vault Calculation This endpoint runs the Vault calculation specified in the POST body parameters.  It must be used first before polling or cancelling endpoints.  A successful response will contain the URL to poll for the result of the calculation.    Remarks:    *   Start and and end date must be within the configuration&#39;s min and max date range
        /// </summary>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vaultCalculationParameters"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<FactSet.AnalyticsAPI.Engines.Client.ApiResponse<Object>> RunVaultCalculationAsyncWithHttpInfo (VaultCalculationParameters vaultCalculationParameters = default(VaultCalculationParameters))
        {

            FactSet.AnalyticsAPI.Engines.Client.RequestOptions localVarRequestOptions = new FactSet.AnalyticsAPI.Engines.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.Data = vaultCalculationParameters;

            // authentication (Basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + FactSet.AnalyticsAPI.Engines.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/analytics/engines/vault/v2/calculations", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RunVaultCalculation", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}