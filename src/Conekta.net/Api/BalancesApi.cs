/*
 * Conekta API
 *
 * Conekta sdk
 *
 * The version of the OpenAPI document: 2.1.0
 * Contact: engineering@conekta.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Conekta.net.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBalancesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a company&#39;s balance
        /// </summary>
        /// <remarks>
        /// Get a company&#39;s balance
        /// </remarks>
        /// <exception cref="Conekta.net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">Use for knowing which language to use (optional, default to es)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>BalanceResponse</returns>
        BalanceResponse GetBalance(string acceptLanguage = default(string), int operationIndex = 0);

        /// <summary>
        /// Get a company&#39;s balance
        /// </summary>
        /// <remarks>
        /// Get a company&#39;s balance
        /// </remarks>
        /// <exception cref="Conekta.net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">Use for knowing which language to use (optional, default to es)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of BalanceResponse</returns>
        ApiResponse<BalanceResponse> GetBalanceWithHttpInfo(string acceptLanguage = default(string), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBalancesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get a company&#39;s balance
        /// </summary>
        /// <remarks>
        /// Get a company&#39;s balance
        /// </remarks>
        /// <exception cref="Conekta.net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">Use for knowing which language to use (optional, default to es)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BalanceResponse</returns>
        System.Threading.Tasks.Task<BalanceResponse> GetBalanceAsync(string acceptLanguage = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a company&#39;s balance
        /// </summary>
        /// <remarks>
        /// Get a company&#39;s balance
        /// </remarks>
        /// <exception cref="Conekta.net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">Use for knowing which language to use (optional, default to es)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BalanceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BalanceResponse>> GetBalanceWithHttpInfoAsync(string acceptLanguage = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBalancesApi : IBalancesApiSync, IBalancesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BalancesApi : IBalancesApi
    {
        private Conekta.net.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BalancesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BalancesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BalancesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BalancesApi(string basePath)
        {
            this.Configuration = Conekta.net.Client.Configuration.MergeConfigurations(
                Conekta.net.Client.GlobalConfiguration.Instance,
                new Conekta.net.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Conekta.net.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Conekta.net.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Conekta.net.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BalancesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BalancesApi(Conekta.net.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Conekta.net.Client.Configuration.MergeConfigurations(
                Conekta.net.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Conekta.net.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Conekta.net.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Conekta.net.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BalancesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public BalancesApi(Conekta.net.Client.ISynchronousClient client, Conekta.net.Client.IAsynchronousClient asyncClient, Conekta.net.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Conekta.net.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Conekta.net.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Conekta.net.Client.ISynchronousClient Client { get; set; }

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
        public Conekta.net.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Conekta.net.Client.ExceptionFactory ExceptionFactory
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
        /// Get a company&#39;s balance Get a company&#39;s balance
        /// </summary>
        /// <exception cref="Conekta.net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">Use for knowing which language to use (optional, default to es)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>BalanceResponse</returns>
        public BalanceResponse GetBalance(string acceptLanguage = default(string), int operationIndex = 0)
        {
            Conekta.net.Client.ApiResponse<BalanceResponse> localVarResponse = GetBalanceWithHttpInfo(acceptLanguage);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a company&#39;s balance Get a company&#39;s balance
        /// </summary>
        /// <exception cref="Conekta.net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">Use for knowing which language to use (optional, default to es)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of BalanceResponse</returns>
        public Conekta.net.Client.ApiResponse<BalanceResponse> GetBalanceWithHttpInfo(string acceptLanguage = default(string), int operationIndex = 0)
        {
            Conekta.net.Client.RequestOptions localVarRequestOptions = new Conekta.net.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/vnd.conekta-v2.1.0+json"
            };

            var localVarContentType = Conekta.net.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Conekta.net.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (acceptLanguage != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Language", Conekta.net.Client.ClientUtils.ParameterToString(acceptLanguage)); // header parameter
            }

            localVarRequestOptions.Operation = "BalancesApi.GetBalance";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<BalanceResponse>("/balance", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetBalance", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a company&#39;s balance Get a company&#39;s balance
        /// </summary>
        /// <exception cref="Conekta.net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">Use for knowing which language to use (optional, default to es)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BalanceResponse</returns>
        public async System.Threading.Tasks.Task<BalanceResponse> GetBalanceAsync(string acceptLanguage = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Conekta.net.Client.ApiResponse<BalanceResponse> localVarResponse = await GetBalanceWithHttpInfoAsync(acceptLanguage, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a company&#39;s balance Get a company&#39;s balance
        /// </summary>
        /// <exception cref="Conekta.net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">Use for knowing which language to use (optional, default to es)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BalanceResponse)</returns>
        public async System.Threading.Tasks.Task<Conekta.net.Client.ApiResponse<BalanceResponse>> GetBalanceWithHttpInfoAsync(string acceptLanguage = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Conekta.net.Client.RequestOptions localVarRequestOptions = new Conekta.net.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/vnd.conekta-v2.1.0+json"
            };

            var localVarContentType = Conekta.net.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Conekta.net.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (acceptLanguage != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Language", Conekta.net.Client.ClientUtils.ParameterToString(acceptLanguage)); // header parameter
            }

            localVarRequestOptions.Operation = "BalancesApi.GetBalance";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<BalanceResponse>("/balance", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetBalance", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}