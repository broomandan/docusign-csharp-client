# IO.Swagger.Api.SigningGroupUsersApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SigningGroupsDeleteSigningGroupUsers**](SigningGroupUsersApi.md#signinggroupsdeletesigninggroupusers) | **DELETE** /v2/accounts/{accountId}/signing_groups/{signingGroupId}/users | Deletes  one or more members from a signing group.
[**SigningGroupsGetSigningGroupUsers**](SigningGroupUsersApi.md#signinggroupsgetsigninggroupusers) | **GET** /v2/accounts/{accountId}/signing_groups/{signingGroupId}/users | Gets a list of members in a Signing Group.
[**SigningGroupsPutSigningGroupUsers**](SigningGroupUsersApi.md#signinggroupsputsigninggroupusers) | **PUT** /v2/accounts/{accountId}/signing_groups/{signingGroupId}/users | Adds members to a signing group. 


<a name="signinggroupsdeletesigninggroupusers"></a>
# **SigningGroupsDeleteSigningGroupUsers**
> SigningGroupUsers SigningGroupsDeleteSigningGroupUsers (string accountId, string signingGroupId, SigningGroupUsers signingGroupUsers = null)

Deletes  one or more members from a signing group.

Deletes  one or more members from the specified signing group. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SigningGroupsDeleteSigningGroupUsersExample
    {
        public void main()
        {
            
            var apiInstance = new SigningGroupUsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var signingGroupId = signingGroupId_example;  // string | 
            var signingGroupUsers = new SigningGroupUsers(); // SigningGroupUsers |  (optional) 

            try
            {
                // Deletes  one or more members from a signing group.
                SigningGroupUsers result = apiInstance.SigningGroupsDeleteSigningGroupUsers(accountId, signingGroupId, signingGroupUsers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SigningGroupUsersApi.SigningGroupsDeleteSigningGroupUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **signingGroupId** | **string**|  | 
 **signingGroupUsers** | [**SigningGroupUsers**](SigningGroupUsers.md)|  | [optional] 

### Return type

[**SigningGroupUsers**](SigningGroupUsers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signinggroupsgetsigninggroupusers"></a>
# **SigningGroupsGetSigningGroupUsers**
> SigningGroupUsers SigningGroupsGetSigningGroupUsers (string accountId, string signingGroupId)

Gets a list of members in a Signing Group.

Retrieves the list of members in the specified Signing Group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SigningGroupsGetSigningGroupUsersExample
    {
        public void main()
        {
            
            var apiInstance = new SigningGroupUsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var signingGroupId = signingGroupId_example;  // string | 

            try
            {
                // Gets a list of members in a Signing Group.
                SigningGroupUsers result = apiInstance.SigningGroupsGetSigningGroupUsers(accountId, signingGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SigningGroupUsersApi.SigningGroupsGetSigningGroupUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **signingGroupId** | **string**|  | 

### Return type

[**SigningGroupUsers**](SigningGroupUsers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signinggroupsputsigninggroupusers"></a>
# **SigningGroupsPutSigningGroupUsers**
> SigningGroupUsers SigningGroupsPutSigningGroupUsers (string accountId, string signingGroupId, SigningGroupUsers signingGroupUsers = null)

Adds members to a signing group. 

Adds one or more new members to a signing group. A signing group can have a maximum of 50 members. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SigningGroupsPutSigningGroupUsersExample
    {
        public void main()
        {
            
            var apiInstance = new SigningGroupUsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var signingGroupId = signingGroupId_example;  // string | 
            var signingGroupUsers = new SigningGroupUsers(); // SigningGroupUsers |  (optional) 

            try
            {
                // Adds members to a signing group. 
                SigningGroupUsers result = apiInstance.SigningGroupsPutSigningGroupUsers(accountId, signingGroupId, signingGroupUsers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SigningGroupUsersApi.SigningGroupsPutSigningGroupUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **signingGroupId** | **string**|  | 
 **signingGroupUsers** | [**SigningGroupUsers**](SigningGroupUsers.md)|  | [optional] 

### Return type

[**SigningGroupUsers**](SigningGroupUsers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

