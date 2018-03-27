# IO.Swagger.Api.AuthenticationApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LoginInformationGetLoginInformation**](AuthenticationApi.md#logininformationgetlogininformation) | **GET** /v2/login_information | Gets login information for a specified user.
[**LoginInformationPutLoginInformation**](AuthenticationApi.md#logininformationputlogininformation) | **PUT** /v2/login_information/{loginPart} | Updates the password for a specified user.
[**OAuth2PostRevoke**](AuthenticationApi.md#oauth2postrevoke) | **POST** /v2/oauth2/revoke | **Deprecated** Revokes an authorization token. 
[**OAuth2PostToken**](AuthenticationApi.md#oauth2posttoken) | **POST** /v2/oauth2/token | **Deprecated** Creates an authorization token. 


<a name="logininformationgetlogininformation"></a>
# **LoginInformationGetLoginInformation**
> Authentication LoginInformationGetLoginInformation (string apiPassword = null, string embedAccountIdGuid = null, string includeAccountIdGuid = null, string loginSettings = null)

Gets login information for a specified user.

Retrieves account information for the authenticated user. Since the API is sessionless, this method does not actually log you in.  Instead, the method returns information about the account or accounts that the authenticated user has access to.  ###### Important: This method must only be used for the [Legacy Header Authentication][legacyheader] flow. Use the [`AccountServer: userInfo` method](../../../../guide/authentication/userinfo.html) for the OAuth2 Authentiction Code and Implicit Grant flows.  Each account has a `baseUrl` property, returned in the response. Use this `baseUrl` in all future API calls as the base of the request URL.  For each account, the `baseUrl` property includes the DocuSign server, the API version, and the `accountId` property.  It is not uncommon for an authenticated user to have access to more than one account (and more than one `baseUrl`). Depending on your integration's use case, your integration may choose to:  * Use the account whose `isDefault` field is `true`. * List the available accounts and ask the user to choose one. * Enable the system administrator to set the account that should be used by your integration.  If this method returns successfully, then you also know that the user has successfully authenticated with the DocuSign Signature platform.   [legacyheader]: ../../../../guide/authentication/legacy_auth.html [userinfo]: ../../../../guide/authentication/userinfo.html [authcode]: ../../../../guide/authentication/oa2_auth_code.md [implicit]: ../../../../guide/authentication/oa2_implicit.md 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LoginInformationGetLoginInformationExample
    {
        public void main()
        {
            
            var apiInstance = new AuthenticationApi();
            var apiPassword = apiPassword_example;  // string | Reserved for DocuSign.  (optional) 
            var embedAccountIdGuid = embedAccountIdGuid_example;  // string |  (optional) 
            var includeAccountIdGuid = includeAccountIdGuid_example;  // string | When set to **true**, shows the account ID GUID in the response. (optional) 
            var loginSettings = loginSettings_example;  // string | Determines whether login settings are returned in the response.  Valid Values:  * all -  All the login settings are returned.  * none - no login settings are returned. (optional) 

            try
            {
                // Gets login information for a specified user.
                Authentication result = apiInstance.LoginInformationGetLoginInformation(apiPassword, embedAccountIdGuid, includeAccountIdGuid, loginSettings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.LoginInformationGetLoginInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiPassword** | **string**| Reserved for DocuSign.  | [optional] 
 **embedAccountIdGuid** | **string**|  | [optional] 
 **includeAccountIdGuid** | **string**| When set to **true**, shows the account ID GUID in the response. | [optional] 
 **loginSettings** | **string**| Determines whether login settings are returned in the response.  Valid Values:  * all -  All the login settings are returned.  * none - no login settings are returned. | [optional] 

### Return type

[**Authentication**](Authentication.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logininformationputlogininformation"></a>
# **LoginInformationPutLoginInformation**
> void LoginInformationPutLoginInformation (string loginPart, UserPasswordInformation userPasswordInformation = null)

Updates the password for a specified user.

Updates the password for a specified user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LoginInformationPutLoginInformationExample
    {
        public void main()
        {
            
            var apiInstance = new AuthenticationApi();
            var loginPart = loginPart_example;  // string | Currently, only the value **password** is supported.
            var userPasswordInformation = new UserPasswordInformation(); // UserPasswordInformation |  (optional) 

            try
            {
                // Updates the password for a specified user.
                apiInstance.LoginInformationPutLoginInformation(loginPart, userPasswordInformation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.LoginInformationPutLoginInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loginPart** | **string**| Currently, only the value **password** is supported. | 
 **userPasswordInformation** | [**UserPasswordInformation**](UserPasswordInformation.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oauth2postrevoke"></a>
# **OAuth2PostRevoke**
> void OAuth2PostRevoke ()

**Deprecated** Revokes an authorization token. 

**Deprecated**  Revokes an OAuth2 authorization server token. After the revocation is complete, a caller must re-authenticate to restore access. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OAuth2PostRevokeExample
    {
        public void main()
        {
            
            var apiInstance = new AuthenticationApi();

            try
            {
                // **Deprecated** Revokes an authorization token. 
                apiInstance.OAuth2PostRevoke();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.OAuth2PostRevoke: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oauth2posttoken"></a>
# **OAuth2PostToken**
> OauthAccess OAuth2PostToken ()

**Deprecated** Creates an authorization token. 

**Deprecated**  Creates an OAuth2 authorization server token endpoint. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OAuth2PostTokenExample
    {
        public void main()
        {
            
            var apiInstance = new AuthenticationApi();

            try
            {
                // **Deprecated** Creates an authorization token. 
                OauthAccess result = apiInstance.OAuth2PostToken();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.OAuth2PostToken: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**OauthAccess**](OauthAccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

