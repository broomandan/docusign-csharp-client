# IO.Swagger.Api.SigningGroupsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SigningGroupsDeleteSigningGroups**](SigningGroupsApi.md#signinggroupsdeletesigninggroups) | **DELETE** /v2/accounts/{accountId}/signing_groups | Deletes one or more signing groups.
[**SigningGroupsGetSigningGroup**](SigningGroupsApi.md#signinggroupsgetsigninggroup) | **GET** /v2/accounts/{accountId}/signing_groups/{signingGroupId} | Gets information about a signing group. 
[**SigningGroupsGetSigningGroups**](SigningGroupsApi.md#signinggroupsgetsigninggroups) | **GET** /v2/accounts/{accountId}/signing_groups | Gets a list of the Signing Groups in an account.
[**SigningGroupsPostSigningGroups**](SigningGroupsApi.md#signinggroupspostsigninggroups) | **POST** /v2/accounts/{accountId}/signing_groups | Creates a signing group. 
[**SigningGroupsPutSigningGroup**](SigningGroupsApi.md#signinggroupsputsigninggroup) | **PUT** /v2/accounts/{accountId}/signing_groups/{signingGroupId} | Updates a signing group. 
[**SigningGroupsPutSigningGroups**](SigningGroupsApi.md#signinggroupsputsigninggroups) | **PUT** /v2/accounts/{accountId}/signing_groups | Updates signing group names.


<a name="signinggroupsdeletesigninggroups"></a>
# **SigningGroupsDeleteSigningGroups**
> SigningGroupInformation SigningGroupsDeleteSigningGroups (string accountId, SigningGroupInformation signingGroupInformation = null)

Deletes one or more signing groups.

Deletes one or more signing groups in the specified account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SigningGroupsDeleteSigningGroupsExample
    {
        public void main()
        {
            
            var apiInstance = new SigningGroupsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var signingGroupInformation = new SigningGroupInformation(); // SigningGroupInformation |  (optional) 

            try
            {
                // Deletes one or more signing groups.
                SigningGroupInformation result = apiInstance.SigningGroupsDeleteSigningGroups(accountId, signingGroupInformation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SigningGroupsApi.SigningGroupsDeleteSigningGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **signingGroupInformation** | [**SigningGroupInformation**](SigningGroupInformation.md)|  | [optional] 

### Return type

[**SigningGroupInformation**](SigningGroupInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signinggroupsgetsigninggroup"></a>
# **SigningGroupsGetSigningGroup**
> SigningGroups SigningGroupsGetSigningGroup (string accountId, string signingGroupId)

Gets information about a signing group. 

Retrieves information, including group member information, for the specified signing group. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SigningGroupsGetSigningGroupExample
    {
        public void main()
        {
            
            var apiInstance = new SigningGroupsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var signingGroupId = signingGroupId_example;  // string | 

            try
            {
                // Gets information about a signing group. 
                SigningGroups result = apiInstance.SigningGroupsGetSigningGroup(accountId, signingGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SigningGroupsApi.SigningGroupsGetSigningGroup: " + e.Message );
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

[**SigningGroups**](SigningGroups.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signinggroupsgetsigninggroups"></a>
# **SigningGroupsGetSigningGroups**
> SigningGroupInformation SigningGroupsGetSigningGroups (string accountId, string groupType = null, string includeUsers = null)

Gets a list of the Signing Groups in an account.

Retrieves a list of all signing groups in the specified account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SigningGroupsGetSigningGroupsExample
    {
        public void main()
        {
            
            var apiInstance = new SigningGroupsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groupType = groupType_example;  // string |  (optional) 
            var includeUsers = includeUsers_example;  // string | When set to **true**, the response includes the signing group members.  (optional) 

            try
            {
                // Gets a list of the Signing Groups in an account.
                SigningGroupInformation result = apiInstance.SigningGroupsGetSigningGroups(accountId, groupType, includeUsers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SigningGroupsApi.SigningGroupsGetSigningGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groupType** | **string**|  | [optional] 
 **includeUsers** | **string**| When set to **true**, the response includes the signing group members.  | [optional] 

### Return type

[**SigningGroupInformation**](SigningGroupInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signinggroupspostsigninggroups"></a>
# **SigningGroupsPostSigningGroups**
> SigningGroupInformation SigningGroupsPostSigningGroups (string accountId, SigningGroupInformation signingGroupInformation = null)

Creates a signing group. 

Creates one or more signing groups.   Multiple signing groups can be created in one call. Only users with account administrator privileges can create signing groups.   An account can have a maximum of 50 signing groups. Each signing group can have a maximum of 50 group members.   Signing groups can be used by any account user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SigningGroupsPostSigningGroupsExample
    {
        public void main()
        {
            
            var apiInstance = new SigningGroupsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var signingGroupInformation = new SigningGroupInformation(); // SigningGroupInformation |  (optional) 

            try
            {
                // Creates a signing group. 
                SigningGroupInformation result = apiInstance.SigningGroupsPostSigningGroups(accountId, signingGroupInformation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SigningGroupsApi.SigningGroupsPostSigningGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **signingGroupInformation** | [**SigningGroupInformation**](SigningGroupInformation.md)|  | [optional] 

### Return type

[**SigningGroupInformation**](SigningGroupInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signinggroupsputsigninggroup"></a>
# **SigningGroupsPutSigningGroup**
> SigningGroups SigningGroupsPutSigningGroup (string accountId, string signingGroupId, SigningGroups signingGroups = null)

Updates a signing group. 

Updates signing group name and member information. You can also add new members to the signing group. A signing group can have a maximum of 50 members. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SigningGroupsPutSigningGroupExample
    {
        public void main()
        {
            
            var apiInstance = new SigningGroupsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var signingGroupId = signingGroupId_example;  // string | 
            var signingGroups = new SigningGroups(); // SigningGroups |  (optional) 

            try
            {
                // Updates a signing group. 
                SigningGroups result = apiInstance.SigningGroupsPutSigningGroup(accountId, signingGroupId, signingGroups);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SigningGroupsApi.SigningGroupsPutSigningGroup: " + e.Message );
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
 **signingGroups** | [**SigningGroups**](SigningGroups.md)|  | [optional] 

### Return type

[**SigningGroups**](SigningGroups.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signinggroupsputsigninggroups"></a>
# **SigningGroupsPutSigningGroups**
> SigningGroupInformation SigningGroupsPutSigningGroups (string accountId, SigningGroupInformation signingGroupInformation = null)

Updates signing group names.

Updates the name of one or more existing signing groups. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SigningGroupsPutSigningGroupsExample
    {
        public void main()
        {
            
            var apiInstance = new SigningGroupsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var signingGroupInformation = new SigningGroupInformation(); // SigningGroupInformation |  (optional) 

            try
            {
                // Updates signing group names.
                SigningGroupInformation result = apiInstance.SigningGroupsPutSigningGroups(accountId, signingGroupInformation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SigningGroupsApi.SigningGroupsPutSigningGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **signingGroupInformation** | [**SigningGroupInformation**](SigningGroupInformation.md)|  | [optional] 

### Return type

[**SigningGroupInformation**](SigningGroupInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

