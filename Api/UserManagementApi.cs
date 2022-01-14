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

using AuthenticationSdk.util;

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserManagementApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get User Information - Deprecated
        /// </summary>
        /// <remarks>
        /// This endpoint is deprecated. Please use the search end point.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">This is the orgId of the organization which the user belongs to. (optional)</param>
        /// <param name="userName">User ID of the user you want to get details on. (optional)</param>
        /// <param name="permissionId">permission that you are trying to search user on. (optional)</param>
        /// <param name="roleId">role of the user you are trying to search on. (optional)</param>
        /// <returns>UmsV1UsersGet200Response</returns>
        UmsV1UsersGet200Response GetUsers (string organizationId = null, string userName = null, string permissionId = null, string roleId = null);

        /// <summary>
        /// Get User Information - Deprecated
        /// </summary>
        /// <remarks>
        /// This endpoint is deprecated. Please use the search end point.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">This is the orgId of the organization which the user belongs to. (optional)</param>
        /// <param name="userName">User ID of the user you want to get details on. (optional)</param>
        /// <param name="permissionId">permission that you are trying to search user on. (optional)</param>
        /// <param name="roleId">role of the user you are trying to search on. (optional)</param>
        /// <returns>ApiResponse of UmsV1UsersGet200Response</returns>
        ApiResponse<UmsV1UsersGet200Response> GetUsersWithHttpInfo (string organizationId = null, string userName = null, string permissionId = null, string roleId = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get User Information - Deprecated
        /// </summary>
        /// <remarks>
        /// This endpoint is deprecated. Please use the search end point.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">This is the orgId of the organization which the user belongs to. (optional)</param>
        /// <param name="userName">User ID of the user you want to get details on. (optional)</param>
        /// <param name="permissionId">permission that you are trying to search user on. (optional)</param>
        /// <param name="roleId">role of the user you are trying to search on. (optional)</param>
        /// <returns>Task of UmsV1UsersGet200Response</returns>
        System.Threading.Tasks.Task<UmsV1UsersGet200Response> GetUsersAsync (string organizationId = null, string userName = null, string permissionId = null, string roleId = null);

        /// <summary>
        /// Get User Information - Deprecated
        /// </summary>
        /// <remarks>
        /// This endpoint is deprecated. Please use the search end point.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">This is the orgId of the organization which the user belongs to. (optional)</param>
        /// <param name="userName">User ID of the user you want to get details on. (optional)</param>
        /// <param name="permissionId">permission that you are trying to search user on. (optional)</param>
        /// <param name="roleId">role of the user you are trying to search on. (optional)</param>
        /// <returns>Task of ApiResponse (UmsV1UsersGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<UmsV1UsersGet200Response>> GetUsersAsyncWithHttpInfo (string organizationId = null, string userName = null, string permissionId = null, string roleId = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UserManagementApi : IUserManagementApi
    {
        
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserManagementApi(string basePath)
        {
            Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                Configuration.ApiClient.Configuration = Configuration;
            }

            if (false)
            {
                
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserManagementApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                Configuration = Configuration.Default;
            else
                Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            Configuration.ApiClient.Configuration = Configuration;

            if (false)
            {
                
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
        /// Get User Information - Deprecated This endpoint is deprecated. Please use the search end point.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">This is the orgId of the organization which the user belongs to. (optional)</param>
        /// <param name="userName">User ID of the user you want to get details on. (optional)</param>
        /// <param name="permissionId">permission that you are trying to search user on. (optional)</param>
        /// <param name="roleId">role of the user you are trying to search on. (optional)</param>
        /// <returns>UmsV1UsersGet200Response</returns>
        public UmsV1UsersGet200Response GetUsers (string organizationId = null, string userName = null, string permissionId = null, string roleId = null)
        {
                         ApiResponse<UmsV1UsersGet200Response> localVarResponse = GetUsersWithHttpInfo(organizationId, userName, permissionId, roleId);
                         return localVarResponse.Data;
        }

        /// <summary>
        /// Get User Information - Deprecated This endpoint is deprecated. Please use the search end point.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">This is the orgId of the organization which the user belongs to. (optional)</param>
        /// <param name="userName">User ID of the user you want to get details on. (optional)</param>
        /// <param name="permissionId">permission that you are trying to search user on. (optional)</param>
        /// <param name="roleId">role of the user you are trying to search on. (optional)</param>
        /// <returns>ApiResponse of UmsV1UsersGet200Response</returns>
        public ApiResponse< UmsV1UsersGet200Response > GetUsersWithHttpInfo (string organizationId = null, string userName = null, string permissionId = null, string roleId = null)
        {

            var localVarPath = $"/ums/v1/users";
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
                "application/hal+json;charset=utf-8"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (organizationId != null)
            {
                localVarQueryParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // query parameter
            }
            if (userName != null)
            {
                localVarQueryParams.Add("userName", Configuration.ApiClient.ParameterToString(userName)); // query parameter
            }
            if (permissionId != null)
            {
                localVarQueryParams.Add("permissionId", Configuration.ApiClient.ParameterToString(permissionId)); // query parameter
            }
            if (roleId != null)
            {
                localVarQueryParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // query parameter
            }
                                                    

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUsers", localVarResponse);
                if (exception != null)
                {
                                         throw exception;
                }
            }

            return new ApiResponse<UmsV1UsersGet200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UmsV1UsersGet200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UmsV1UsersGet200Response))); // Return statement
        }

        /// <summary>
        /// Get User Information - Deprecated This endpoint is deprecated. Please use the search end point.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">This is the orgId of the organization which the user belongs to. (optional)</param>
        /// <param name="userName">User ID of the user you want to get details on. (optional)</param>
        /// <param name="permissionId">permission that you are trying to search user on. (optional)</param>
        /// <param name="roleId">role of the user you are trying to search on. (optional)</param>
        /// <returns>Task of UmsV1UsersGet200Response</returns>
        public async System.Threading.Tasks.Task<UmsV1UsersGet200Response> GetUsersAsync (string organizationId = null, string userName = null, string permissionId = null, string roleId = null)
        {
                         ApiResponse<UmsV1UsersGet200Response> localVarResponse = await GetUsersAsyncWithHttpInfo(organizationId, userName, permissionId, roleId);
                         return localVarResponse.Data;

        }

        /// <summary>
        /// Get User Information - Deprecated This endpoint is deprecated. Please use the search end point.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">This is the orgId of the organization which the user belongs to. (optional)</param>
        /// <param name="userName">User ID of the user you want to get details on. (optional)</param>
        /// <param name="permissionId">permission that you are trying to search user on. (optional)</param>
        /// <param name="roleId">role of the user you are trying to search on. (optional)</param>
        /// <returns>Task of ApiResponse (UmsV1UsersGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UmsV1UsersGet200Response>> GetUsersAsyncWithHttpInfo (string organizationId = null, string userName = null, string permissionId = null, string roleId = null)
        {

            var localVarPath = $"/ums/v1/users";
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
                "application/hal+json;charset=utf-8"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (organizationId != null)
            {
                localVarQueryParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // query parameter
            }
            if (userName != null)
            {
                localVarQueryParams.Add("userName", Configuration.ApiClient.ParameterToString(userName)); // query parameter
            }
            if (permissionId != null)
            {
                localVarQueryParams.Add("permissionId", Configuration.ApiClient.ParameterToString(permissionId)); // query parameter
            }
            if (roleId != null)
            {
                localVarQueryParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // query parameter
            }
                                                    

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUsers", localVarResponse);
                if (exception != null)
                {
                                         throw exception;
                }
            }

            return new ApiResponse<UmsV1UsersGet200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UmsV1UsersGet200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UmsV1UsersGet200Response))); // Return statement
        }
    }
}
