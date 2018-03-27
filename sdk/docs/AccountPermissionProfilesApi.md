# IO.Swagger.Api.AccountPermissionProfilesApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PermissionProfilesDeletePermissionProfiles**](AccountPermissionProfilesApi.md#permissionprofilesdeletepermissionprofiles) | **DELETE** /v2/accounts/{accountId}/permission_profiles/{permissionProfileId} | Deletes a permissions profile within the specified account.
[**PermissionProfilesGetPermissionProfile**](AccountPermissionProfilesApi.md#permissionprofilesgetpermissionprofile) | **GET** /v2/accounts/{accountId}/permission_profiles/{permissionProfileId} | Returns a permissions profile in the specified account.
[**PermissionProfilesGetPermissionProfiles**](AccountPermissionProfilesApi.md#permissionprofilesgetpermissionprofiles) | **GET** /v2/accounts/{accountId}/permission_profiles | Gets a list of permission profiles.
[**PermissionProfilesPostPermissionProfiles**](AccountPermissionProfilesApi.md#permissionprofilespostpermissionprofiles) | **POST** /v2/accounts/{accountId}/permission_profiles | Creates a new permission profile in the specified account.
[**PermissionProfilesPutPermissionProfiles**](AccountPermissionProfilesApi.md#permissionprofilesputpermissionprofiles) | **PUT** /v2/accounts/{accountId}/permission_profiles/{permissionProfileId} | Updates a permission profile within the specified account.


<a name="permissionprofilesdeletepermissionprofiles"></a>
# **PermissionProfilesDeletePermissionProfiles**
> void PermissionProfilesDeletePermissionProfiles (string accountId, string permissionProfileId)

Deletes a permissions profile within the specified account.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PermissionProfilesDeletePermissionProfilesExample
    {
        public void main()
        {
            
            var apiInstance = new AccountPermissionProfilesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var permissionProfileId = permissionProfileId_example;  // string | 

            try
            {
                // Deletes a permissions profile within the specified account.
                apiInstance.PermissionProfilesDeletePermissionProfiles(accountId, permissionProfileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountPermissionProfilesApi.PermissionProfilesDeletePermissionProfiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **permissionProfileId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="permissionprofilesgetpermissionprofile"></a>
# **PermissionProfilesGetPermissionProfile**
> AccountPermissionProfiles PermissionProfilesGetPermissionProfile (string accountId, string permissionProfileId, string include = null)

Returns a permissions profile in the specified account.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PermissionProfilesGetPermissionProfileExample
    {
        public void main()
        {
            
            var apiInstance = new AccountPermissionProfilesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var permissionProfileId = permissionProfileId_example;  // string | 
            var include = include_example;  // string | A comma-separated list of additional template attributes to include in the response. Valid values are: recipients, folders, documents, custom_fields, and notifications. (optional) 

            try
            {
                // Returns a permissions profile in the specified account.
                AccountPermissionProfiles result = apiInstance.PermissionProfilesGetPermissionProfile(accountId, permissionProfileId, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountPermissionProfilesApi.PermissionProfilesGetPermissionProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **permissionProfileId** | **string**|  | 
 **include** | **string**| A comma-separated list of additional template attributes to include in the response. Valid values are: recipients, folders, documents, custom_fields, and notifications. | [optional] 

### Return type

[**AccountPermissionProfiles**](AccountPermissionProfiles.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="permissionprofilesgetpermissionprofiles"></a>
# **PermissionProfilesGetPermissionProfiles**
> PermissionProfileInformation PermissionProfilesGetPermissionProfiles (string accountId, string include = null)

Gets a list of permission profiles.

Retrieves a list of Permission Profiles. Permission Profiles are a standard set of user permissions that you can apply to individual users or users in a Group. This makes it easier to manage user permissions for a large number of users, without having to change permissions on a user-by-user basis.  Currently, Permission Profiles can only be created and modified in the DocuSign console.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PermissionProfilesGetPermissionProfilesExample
    {
        public void main()
        {
            
            var apiInstance = new AccountPermissionProfilesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var include = include_example;  // string | Reserved for DocuSign.  (optional) 

            try
            {
                // Gets a list of permission profiles.
                PermissionProfileInformation result = apiInstance.PermissionProfilesGetPermissionProfiles(accountId, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountPermissionProfilesApi.PermissionProfilesGetPermissionProfiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **include** | **string**| Reserved for DocuSign.  | [optional] 

### Return type

[**PermissionProfileInformation**](PermissionProfileInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="permissionprofilespostpermissionprofiles"></a>
# **PermissionProfilesPostPermissionProfiles**
> AccountPermissionProfiles PermissionProfilesPostPermissionProfiles (string accountId, string include = null, AccountPermissionProfiles accountPermissionProfiles = null)

Creates a new permission profile in the specified account.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PermissionProfilesPostPermissionProfilesExample
    {
        public void main()
        {
            
            var apiInstance = new AccountPermissionProfilesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var include = include_example;  // string | A comma-separated list of additional template attributes to include in the response. Valid values are: recipients, folders, documents, custom_fields, and notifications. (optional) 
            var accountPermissionProfiles = new AccountPermissionProfiles(); // AccountPermissionProfiles |  (optional) 

            try
            {
                // Creates a new permission profile in the specified account.
                AccountPermissionProfiles result = apiInstance.PermissionProfilesPostPermissionProfiles(accountId, include, accountPermissionProfiles);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountPermissionProfilesApi.PermissionProfilesPostPermissionProfiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **include** | **string**| A comma-separated list of additional template attributes to include in the response. Valid values are: recipients, folders, documents, custom_fields, and notifications. | [optional] 
 **accountPermissionProfiles** | [**AccountPermissionProfiles**](AccountPermissionProfiles.md)|  | [optional] 

### Return type

[**AccountPermissionProfiles**](AccountPermissionProfiles.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="permissionprofilesputpermissionprofiles"></a>
# **PermissionProfilesPutPermissionProfiles**
> AccountPermissionProfiles PermissionProfilesPutPermissionProfiles (string accountId, string permissionProfileId, string include = null, AccountPermissionProfiles accountPermissionProfiles = null)

Updates a permission profile within the specified account.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PermissionProfilesPutPermissionProfilesExample
    {
        public void main()
        {
            
            var apiInstance = new AccountPermissionProfilesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var permissionProfileId = permissionProfileId_example;  // string | 
            var include = include_example;  // string | A comma-separated list of additional template attributes to include in the response. Valid values are: recipients, folders, documents, custom_fields, and notifications. (optional) 
            var accountPermissionProfiles = new AccountPermissionProfiles(); // AccountPermissionProfiles |  (optional) 

            try
            {
                // Updates a permission profile within the specified account.
                AccountPermissionProfiles result = apiInstance.PermissionProfilesPutPermissionProfiles(accountId, permissionProfileId, include, accountPermissionProfiles);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountPermissionProfilesApi.PermissionProfilesPutPermissionProfiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **permissionProfileId** | **string**|  | 
 **include** | **string**| A comma-separated list of additional template attributes to include in the response. Valid values are: recipients, folders, documents, custom_fields, and notifications. | [optional] 
 **accountPermissionProfiles** | [**AccountPermissionProfiles**](AccountPermissionProfiles.md)|  | [optional] 

### Return type

[**AccountPermissionProfiles**](AccountPermissionProfiles.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

