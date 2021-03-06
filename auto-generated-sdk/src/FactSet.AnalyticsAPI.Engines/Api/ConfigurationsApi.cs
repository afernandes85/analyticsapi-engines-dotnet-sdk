/* 
 * Engines API
 *
 * Allow clients to fetch Analytics through APIs.
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
    public interface IConfigurationsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Vault configuration by id
        /// </summary>
        /// <remarks>
        /// This endpoint returns details for a Vault configuration as well as a list of accounts it is used in.
        /// </remarks>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Vault configuration id to get the details of</param>
        /// <returns>VaultConfiguration</returns>
        VaultConfiguration GetVaultConfigurationById (string id);

        /// <summary>
        /// Get Vault configuration by id
        /// </summary>
        /// <remarks>
        /// This endpoint returns details for a Vault configuration as well as a list of accounts it is used in.
        /// </remarks>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Vault configuration id to get the details of</param>
        /// <returns>ApiResponse of VaultConfiguration</returns>
        ApiResponse<VaultConfiguration> GetVaultConfigurationByIdWithHttpInfo (string id);
        /// <summary>
        /// Get Vault configurations
        /// </summary>
        /// <remarks>
        /// This endpoint returns all the Vault configurations saved in the provided account.
        /// </remarks>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Required account query parameter to filter configurations for a specific account</param>
        /// <returns>Dictionary&lt;string, VaultConfigurationSummary&gt;</returns>
        Dictionary<string, VaultConfigurationSummary> GetVaultConfigurations (string account);

        /// <summary>
        /// Get Vault configurations
        /// </summary>
        /// <remarks>
        /// This endpoint returns all the Vault configurations saved in the provided account.
        /// </remarks>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Required account query parameter to filter configurations for a specific account</param>
        /// <returns>ApiResponse of Dictionary&lt;string, VaultConfigurationSummary&gt;</returns>
        ApiResponse<Dictionary<string, VaultConfigurationSummary>> GetVaultConfigurationsWithHttpInfo (string account);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConfigurationsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get Vault configuration by id
        /// </summary>
        /// <remarks>
        /// This endpoint returns details for a Vault configuration as well as a list of accounts it is used in.
        /// </remarks>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Vault configuration id to get the details of</param>
        /// <returns>Task of VaultConfiguration</returns>
        System.Threading.Tasks.Task<VaultConfiguration> GetVaultConfigurationByIdAsync (string id);

        /// <summary>
        /// Get Vault configuration by id
        /// </summary>
        /// <remarks>
        /// This endpoint returns details for a Vault configuration as well as a list of accounts it is used in.
        /// </remarks>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Vault configuration id to get the details of</param>
        /// <returns>Task of ApiResponse (VaultConfiguration)</returns>
        System.Threading.Tasks.Task<ApiResponse<VaultConfiguration>> GetVaultConfigurationByIdAsyncWithHttpInfo (string id);
        /// <summary>
        /// Get Vault configurations
        /// </summary>
        /// <remarks>
        /// This endpoint returns all the Vault configurations saved in the provided account.
        /// </remarks>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Required account query parameter to filter configurations for a specific account</param>
        /// <returns>Task of Dictionary&lt;string, VaultConfigurationSummary&gt;</returns>
        System.Threading.Tasks.Task<Dictionary<string, VaultConfigurationSummary>> GetVaultConfigurationsAsync (string account);

        /// <summary>
        /// Get Vault configurations
        /// </summary>
        /// <remarks>
        /// This endpoint returns all the Vault configurations saved in the provided account.
        /// </remarks>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Required account query parameter to filter configurations for a specific account</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, VaultConfigurationSummary&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dictionary<string, VaultConfigurationSummary>>> GetVaultConfigurationsAsyncWithHttpInfo (string account);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConfigurationsApi : IConfigurationsApiSync, IConfigurationsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ConfigurationsApi : IConfigurationsApi
    {
        private FactSet.AnalyticsAPI.Engines.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConfigurationsApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConfigurationsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="ConfigurationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConfigurationsApi(FactSet.AnalyticsAPI.Engines.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ConfigurationsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ConfigurationsApi(FactSet.AnalyticsAPI.Engines.Client.ISynchronousClient client,FactSet.AnalyticsAPI.Engines.Client.IAsynchronousClient asyncClient, FactSet.AnalyticsAPI.Engines.Client.IReadableConfiguration configuration)
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
        /// Get Vault configuration by id This endpoint returns details for a Vault configuration as well as a list of accounts it is used in.
        /// </summary>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Vault configuration id to get the details of</param>
        /// <returns>VaultConfiguration</returns>
        public VaultConfiguration GetVaultConfigurationById (string id)
        {
             FactSet.AnalyticsAPI.Engines.Client.ApiResponse<VaultConfiguration> localVarResponse = GetVaultConfigurationByIdWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Vault configuration by id This endpoint returns details for a Vault configuration as well as a list of accounts it is used in.
        /// </summary>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Vault configuration id to get the details of</param>
        /// <returns>ApiResponse of VaultConfiguration</returns>
        public FactSet.AnalyticsAPI.Engines.Client.ApiResponse< VaultConfiguration > GetVaultConfigurationByIdWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new FactSet.AnalyticsAPI.Engines.Client.ApiException(400, "Missing required parameter 'id' when calling ConfigurationsApi->GetVaultConfigurationById");

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

            localVarRequestOptions.PathParameters.Add("id", FactSet.AnalyticsAPI.Engines.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + FactSet.AnalyticsAPI.Engines.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< VaultConfiguration >("/analytics/lookups/v2/engines/vault/configurations/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetVaultConfigurationById", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Vault configuration by id This endpoint returns details for a Vault configuration as well as a list of accounts it is used in.
        /// </summary>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Vault configuration id to get the details of</param>
        /// <returns>Task of VaultConfiguration</returns>
        public async System.Threading.Tasks.Task<VaultConfiguration> GetVaultConfigurationByIdAsync (string id)
        {
             FactSet.AnalyticsAPI.Engines.Client.ApiResponse<VaultConfiguration> localVarResponse = await GetVaultConfigurationByIdAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Vault configuration by id This endpoint returns details for a Vault configuration as well as a list of accounts it is used in.
        /// </summary>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Vault configuration id to get the details of</param>
        /// <returns>Task of ApiResponse (VaultConfiguration)</returns>
        public async System.Threading.Tasks.Task<FactSet.AnalyticsAPI.Engines.Client.ApiResponse<VaultConfiguration>> GetVaultConfigurationByIdAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new FactSet.AnalyticsAPI.Engines.Client.ApiException(400, "Missing required parameter 'id' when calling ConfigurationsApi->GetVaultConfigurationById");


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
            
            localVarRequestOptions.PathParameters.Add("id", FactSet.AnalyticsAPI.Engines.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + FactSet.AnalyticsAPI.Engines.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<VaultConfiguration>("/analytics/lookups/v2/engines/vault/configurations/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetVaultConfigurationById", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Vault configurations This endpoint returns all the Vault configurations saved in the provided account.
        /// </summary>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Required account query parameter to filter configurations for a specific account</param>
        /// <returns>Dictionary&lt;string, VaultConfigurationSummary&gt;</returns>
        public Dictionary<string, VaultConfigurationSummary> GetVaultConfigurations (string account)
        {
             FactSet.AnalyticsAPI.Engines.Client.ApiResponse<Dictionary<string, VaultConfigurationSummary>> localVarResponse = GetVaultConfigurationsWithHttpInfo(account);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Vault configurations This endpoint returns all the Vault configurations saved in the provided account.
        /// </summary>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Required account query parameter to filter configurations for a specific account</param>
        /// <returns>ApiResponse of Dictionary&lt;string, VaultConfigurationSummary&gt;</returns>
        public FactSet.AnalyticsAPI.Engines.Client.ApiResponse< Dictionary<string, VaultConfigurationSummary> > GetVaultConfigurationsWithHttpInfo (string account)
        {
            // verify the required parameter 'account' is set
            if (account == null)
                throw new FactSet.AnalyticsAPI.Engines.Client.ApiException(400, "Missing required parameter 'account' when calling ConfigurationsApi->GetVaultConfigurations");

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

            localVarRequestOptions.QueryParameters.Add(FactSet.AnalyticsAPI.Engines.Client.ClientUtils.ParameterToMultiMap("", "account", account));

            // authentication (Basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + FactSet.AnalyticsAPI.Engines.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< Dictionary<string, VaultConfigurationSummary> >("/analytics/lookups/v2/engines/vault/configurations", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetVaultConfigurations", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Vault configurations This endpoint returns all the Vault configurations saved in the provided account.
        /// </summary>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Required account query parameter to filter configurations for a specific account</param>
        /// <returns>Task of Dictionary&lt;string, VaultConfigurationSummary&gt;</returns>
        public async System.Threading.Tasks.Task<Dictionary<string, VaultConfigurationSummary>> GetVaultConfigurationsAsync (string account)
        {
             FactSet.AnalyticsAPI.Engines.Client.ApiResponse<Dictionary<string, VaultConfigurationSummary>> localVarResponse = await GetVaultConfigurationsAsyncWithHttpInfo(account);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Vault configurations This endpoint returns all the Vault configurations saved in the provided account.
        /// </summary>
        /// <exception cref="FactSet.AnalyticsAPI.Engines.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Required account query parameter to filter configurations for a specific account</param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, VaultConfigurationSummary&gt;)</returns>
        public async System.Threading.Tasks.Task<FactSet.AnalyticsAPI.Engines.Client.ApiResponse<Dictionary<string, VaultConfigurationSummary>>> GetVaultConfigurationsAsyncWithHttpInfo (string account)
        {
            // verify the required parameter 'account' is set
            if (account == null)
                throw new FactSet.AnalyticsAPI.Engines.Client.ApiException(400, "Missing required parameter 'account' when calling ConfigurationsApi->GetVaultConfigurations");


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
            
            localVarRequestOptions.QueryParameters.Add(FactSet.AnalyticsAPI.Engines.Client.ClientUtils.ParameterToMultiMap("", "account", account));

            // authentication (Basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + FactSet.AnalyticsAPI.Engines.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Dictionary<string, VaultConfigurationSummary>>("/analytics/lookups/v2/engines/vault/configurations", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetVaultConfigurations", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
