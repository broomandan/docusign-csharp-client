# IO.Swagger.Api.UserSocialAccountLoginsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UserSocialLoginDeleteUserSocialLogin**](UserSocialAccountLoginsApi.md#usersociallogindeleteusersociallogin) | **DELETE** /v2/accounts/{accountId}/users/{userId}/social | Deletes user&#39;s social account.
[**UserSocialLoginGetUserSocialLogin**](UserSocialAccountLoginsApi.md#usersociallogingetusersociallogin) | **GET** /v2/accounts/{accountId}/users/{userId}/social | Gets a list of a user&#39;s social accounts.
[**UserSocialLoginPutUserSocialLogin**](UserSocialAccountLoginsApi.md#usersocialloginputusersociallogin) | **PUT** /v2/accounts/{accountId}/users/{userId}/social | Adds social account for a user.


<a name="usersociallogindeleteusersociallogin"></a>
# **UserSocialLoginDeleteUserSocialLogin**
> void UserSocialLoginDeleteUserSocialLogin (string accountId, string userId, UserSocialAccountLogins userSocialAccountLogins = null)

Deletes user's social account.

Deletes a social account from a use's account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserSocialLoginDeleteUserSocialLoginExample
    {
        public void main()
        {
            
            var apiInstance = new UserSocialAccountLoginsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var userSocialAccountLogins = new UserSocialAccountLogins(); // UserSocialAccountLogins |  (optional) 

            try
            {
                // Deletes user's social account.
                apiInstance.UserSocialLoginDeleteUserSocialLogin(accountId, userId, userSocialAccountLogins);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserSocialAccountLoginsApi.UserSocialLoginDeleteUserSocialLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **userSocialAccountLogins** | [**UserSocialAccountLogins**](UserSocialAccountLogins.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersociallogingetusersociallogin"></a>
# **UserSocialLoginGetUserSocialLogin**
> UserSocialIdResult UserSocialLoginGetUserSocialLogin (string accountId, string userId)

Gets a list of a user's social accounts.

Retrieves a list of social accounts linked to a user's account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserSocialLoginGetUserSocialLoginExample
    {
        public void main()
        {
            
            var apiInstance = new UserSocialAccountLoginsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Gets a list of a user's social accounts.
                UserSocialIdResult result = apiInstance.UserSocialLoginGetUserSocialLogin(accountId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserSocialAccountLoginsApi.UserSocialLoginGetUserSocialLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 

### Return type

[**UserSocialIdResult**](UserSocialIdResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersocialloginputusersociallogin"></a>
# **UserSocialLoginPutUserSocialLogin**
> void UserSocialLoginPutUserSocialLogin (string accountId, string userId, UserSocialAccountLogins userSocialAccountLogins = null)

Adds social account for a user.

Adds a new social account to a user's account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserSocialLoginPutUserSocialLoginExample
    {
        public void main()
        {
            
            var apiInstance = new UserSocialAccountLoginsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var userSocialAccountLogins = new UserSocialAccountLogins(); // UserSocialAccountLogins |  (optional) 

            try
            {
                // Adds social account for a user.
                apiInstance.UserSocialLoginPutUserSocialLogin(accountId, userId, userSocialAccountLogins);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserSocialAccountLoginsApi.UserSocialLoginPutUserSocialLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **userSocialAccountLogins** | [**UserSocialAccountLogins**](UserSocialAccountLogins.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

