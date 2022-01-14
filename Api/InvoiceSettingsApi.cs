/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using CyberSource.Client;
using CyberSource.Model;
using NLog;
using AuthenticationSdk.util;

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInvoiceSettingsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Invoice Settings
        /// </summary>
        /// <remarks>
        /// Get the invoice settings for the invoice payment page.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InvoicingV2InvoiceSettingsGet200Response</returns>
        InvoicingV2InvoiceSettingsGet200Response GetInvoiceSettings ();

        /// <summary>
        /// Get Invoice Settings
        /// </summary>
        /// <remarks>
        /// Get the invoice settings for the invoice payment page.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InvoicingV2InvoiceSettingsGet200Response</returns>
        ApiResponse<InvoicingV2InvoiceSettingsGet200Response> GetInvoiceSettingsWithHttpInfo ();
        /// <summary>
        /// Update Invoice Settings
        /// </summary>
        /// <remarks>
        /// Update invoice settings for the invoice payment page.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceSettingsRequest"></param>
        /// <returns>InvoicingV2InvoiceSettingsGet200Response</returns>
        InvoicingV2InvoiceSettingsGet200Response UpdateInvoiceSettings (InvoiceSettingsRequest invoiceSettingsRequest);

        /// <summary>
        /// Update Invoice Settings
        /// </summary>
        /// <remarks>
        /// Update invoice settings for the invoice payment page.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceSettingsRequest"></param>
        /// <returns>ApiResponse of InvoicingV2InvoiceSettingsGet200Response</returns>
        ApiResponse<InvoicingV2InvoiceSettingsGet200Response> UpdateInvoiceSettingsWithHttpInfo (InvoiceSettingsRequest invoiceSettingsRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get Invoice Settings
        /// </summary>
        /// <remarks>
        /// Get the invoice settings for the invoice payment page.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InvoicingV2InvoiceSettingsGet200Response</returns>
        System.Threading.Tasks.Task<InvoicingV2InvoiceSettingsGet200Response> GetInvoiceSettingsAsync ();

        /// <summary>
        /// Get Invoice Settings
        /// </summary>
        /// <remarks>
        /// Get the invoice settings for the invoice payment page.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InvoicingV2InvoiceSettingsGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<InvoicingV2InvoiceSettingsGet200Response>> GetInvoiceSettingsAsyncWithHttpInfo ();
        /// <summary>
        /// Update Invoice Settings
        /// </summary>
        /// <remarks>
        /// Update invoice settings for the invoice payment page.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceSettingsRequest"></param>
        /// <returns>Task of InvoicingV2InvoiceSettingsGet200Response</returns>
        System.Threading.Tasks.Task<InvoicingV2InvoiceSettingsGet200Response> UpdateInvoiceSettingsAsync (InvoiceSettingsRequest invoiceSettingsRequest);

        /// <summary>
        /// Update Invoice Settings
        /// </summary>
        /// <remarks>
        /// Update invoice settings for the invoice payment page.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceSettingsRequest"></param>
        /// <returns>Task of ApiResponse (InvoicingV2InvoiceSettingsGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<InvoicingV2InvoiceSettingsGet200Response>> UpdateInvoiceSettingsAsyncWithHttpInfo (InvoiceSettingsRequest invoiceSettingsRequest);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InvoiceSettingsApi : IInvoiceSettingsApi
    {
        private static Logger logger;
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSettingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InvoiceSettingsApi(string basePath)
        {
            Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                Configuration.ApiClient.Configuration = Configuration;
            }

            if (logger == null)
            {
                logger = LogManager.GetCurrentClassLogger();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSettingsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InvoiceSettingsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                Configuration = Configuration.Default;
            else
                Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            Configuration.ApiClient.Configuration = Configuration;

            if (logger == null)
            {
                logger = LogManager.GetCurrentClassLogger();
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(string basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    logger.Error("InvalidOperationException : Multicast delegate for ExceptionFactory is unsupported.");
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
        public Dictionary<string, string> DefaultHeader()
        {
            return Configuration.DefaultHeader;
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
            Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get Invoice Settings Get the invoice settings for the invoice payment page.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InvoicingV2InvoiceSettingsGet200Response</returns>
        public InvoicingV2InvoiceSettingsGet200Response GetInvoiceSettings ()
        {
            logger.Debug("CALLING API \"GetInvoiceSettings\" STARTED");
            ApiResponse<InvoicingV2InvoiceSettingsGet200Response> localVarResponse = GetInvoiceSettingsWithHttpInfo();
            logger.Debug("CALLING API \"GetInvoiceSettings\" ENDED");
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Invoice Settings Get the invoice settings for the invoice payment page.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InvoicingV2InvoiceSettingsGet200Response</returns>
        public ApiResponse< InvoicingV2InvoiceSettingsGet200Response > GetInvoiceSettingsWithHttpInfo ()
        {

            var localVarPath = $"/invoicing/v2/invoiceSettings";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetInvoiceSettings", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<InvoicingV2InvoiceSettingsGet200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InvoicingV2InvoiceSettingsGet200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoicingV2InvoiceSettingsGet200Response))); // Return statement
        }

        /// <summary>
        /// Get Invoice Settings Get the invoice settings for the invoice payment page.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InvoicingV2InvoiceSettingsGet200Response</returns>
        public async System.Threading.Tasks.Task<InvoicingV2InvoiceSettingsGet200Response> GetInvoiceSettingsAsync ()
        {
            logger.Debug("CALLING API \"GetInvoiceSettingsAsync\" STARTED");
            ApiResponse<InvoicingV2InvoiceSettingsGet200Response> localVarResponse = await GetInvoiceSettingsAsyncWithHttpInfo();
            logger.Debug("CALLING API \"GetInvoiceSettingsAsync\" STARTED");
            return localVarResponse.Data;

        }

        /// <summary>
        /// Get Invoice Settings Get the invoice settings for the invoice payment page.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InvoicingV2InvoiceSettingsGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InvoicingV2InvoiceSettingsGet200Response>> GetInvoiceSettingsAsyncWithHttpInfo ()
        {

            var localVarPath = $"/invoicing/v2/invoiceSettings";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetInvoiceSettings", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<InvoicingV2InvoiceSettingsGet200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InvoicingV2InvoiceSettingsGet200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoicingV2InvoiceSettingsGet200Response))); // Return statement
        }
        /// <summary>
        /// Update Invoice Settings Update invoice settings for the invoice payment page.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceSettingsRequest"></param>
        /// <returns>InvoicingV2InvoiceSettingsGet200Response</returns>
        public InvoicingV2InvoiceSettingsGet200Response UpdateInvoiceSettings (InvoiceSettingsRequest invoiceSettingsRequest)
        {
            logger.Debug("CALLING API \"UpdateInvoiceSettings\" STARTED");
            ApiResponse<InvoicingV2InvoiceSettingsGet200Response> localVarResponse = UpdateInvoiceSettingsWithHttpInfo(invoiceSettingsRequest);
            logger.Debug("CALLING API \"UpdateInvoiceSettings\" ENDED");
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update Invoice Settings Update invoice settings for the invoice payment page.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceSettingsRequest"></param>
        /// <returns>ApiResponse of InvoicingV2InvoiceSettingsGet200Response</returns>
        public ApiResponse< InvoicingV2InvoiceSettingsGet200Response > UpdateInvoiceSettingsWithHttpInfo (InvoiceSettingsRequest invoiceSettingsRequest)
        {
            // verify the required parameter 'invoiceSettingsRequest' is set
            if (invoiceSettingsRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'invoiceSettingsRequest' when calling InvoiceSettingsApi->UpdateInvoiceSettings");
                throw new ApiException(400, "Missing required parameter 'invoiceSettingsRequest' when calling InvoiceSettingsApi->UpdateInvoiceSettings");
            }

            var localVarPath = $"/invoicing/v2/invoiceSettings";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (invoiceSettingsRequest != null && invoiceSettingsRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(invoiceSettingsRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = invoiceSettingsRequest; // byte array
            }

            if (LogUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{LogUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateInvoiceSettings", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<InvoicingV2InvoiceSettingsGet200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InvoicingV2InvoiceSettingsGet200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoicingV2InvoiceSettingsGet200Response))); // Return statement
        }

        /// <summary>
        /// Update Invoice Settings Update invoice settings for the invoice payment page.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceSettingsRequest"></param>
        /// <returns>Task of InvoicingV2InvoiceSettingsGet200Response</returns>
        public async System.Threading.Tasks.Task<InvoicingV2InvoiceSettingsGet200Response> UpdateInvoiceSettingsAsync (InvoiceSettingsRequest invoiceSettingsRequest)
        {
            logger.Debug("CALLING API \"UpdateInvoiceSettingsAsync\" STARTED");
            ApiResponse<InvoicingV2InvoiceSettingsGet200Response> localVarResponse = await UpdateInvoiceSettingsAsyncWithHttpInfo(invoiceSettingsRequest);
            logger.Debug("CALLING API \"UpdateInvoiceSettingsAsync\" STARTED");
            return localVarResponse.Data;

        }

        /// <summary>
        /// Update Invoice Settings Update invoice settings for the invoice payment page.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceSettingsRequest"></param>
        /// <returns>Task of ApiResponse (InvoicingV2InvoiceSettingsGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InvoicingV2InvoiceSettingsGet200Response>> UpdateInvoiceSettingsAsyncWithHttpInfo (InvoiceSettingsRequest invoiceSettingsRequest)
        {
            // verify the required parameter 'invoiceSettingsRequest' is set
            if (invoiceSettingsRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'invoiceSettingsRequest' when calling InvoiceSettingsApi->UpdateInvoiceSettings");
                throw new ApiException(400, "Missing required parameter 'invoiceSettingsRequest' when calling InvoiceSettingsApi->UpdateInvoiceSettings");
            }

            var localVarPath = $"/invoicing/v2/invoiceSettings";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (invoiceSettingsRequest != null && invoiceSettingsRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(invoiceSettingsRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = invoiceSettingsRequest; // byte array
            }

            if (LogUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{LogUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateInvoiceSettings", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<InvoicingV2InvoiceSettingsGet200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InvoicingV2InvoiceSettingsGet200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoicingV2InvoiceSettingsGet200Response))); // Return statement
        }
    }
}
