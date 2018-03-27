# IO.Swagger.Api.CloudStorageProvidersApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CloudStorageDeleteCloudStorage**](CloudStorageProvidersApi.md#cloudstoragedeletecloudstorage) | **DELETE** /v2/accounts/{accountId}/users/{userId}/cloud_storage/{serviceId} | Deletes the user authentication information for the specified cloud storage provider.
[**CloudStorageDeleteCloudStorageProviders**](CloudStorageProvidersApi.md#cloudstoragedeletecloudstorageproviders) | **DELETE** /v2/accounts/{accountId}/users/{userId}/cloud_storage | Deletes the user authentication information for one or more cloud storage providers.
[**CloudStorageGetCloudStorage**](CloudStorageProvidersApi.md#cloudstoragegetcloudstorage) | **GET** /v2/accounts/{accountId}/users/{userId}/cloud_storage/{serviceId} | Gets the specified Cloud Storage Provider configuration for the User.
[**CloudStorageGetCloudStorageProviders**](CloudStorageProvidersApi.md#cloudstoragegetcloudstorageproviders) | **GET** /v2/accounts/{accountId}/users/{userId}/cloud_storage | Get the Cloud Storage Provider configuration for the specified user.
[**CloudStoragePostCloudStorage**](CloudStorageProvidersApi.md#cloudstoragepostcloudstorage) | **POST** /v2/accounts/{accountId}/users/{userId}/cloud_storage | Configures the redirect URL information  for one or more cloud storage providers for the specified user.


<a name="cloudstoragedeletecloudstorage"></a>
# **CloudStorageDeleteCloudStorage**
> CloudStorageProviders CloudStorageDeleteCloudStorage (string accountId, string serviceId, string userId)

Deletes the user authentication information for the specified cloud storage provider.

Deletes the user authentication information for the specified cloud storage provider. The next time the user tries to access the cloud storage provider, they must pass normal authentication for this cloud storage provider.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CloudStorageDeleteCloudStorageExample
    {
        public void main()
        {
            
            var apiInstance = new CloudStorageProvidersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var serviceId = serviceId_example;  // string | The ID of the service to access.   Valid values are the service name (\"Box\") or the numerical serviceId (\"4136\").
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Deletes the user authentication information for the specified cloud storage provider.
                CloudStorageProviders result = apiInstance.CloudStorageDeleteCloudStorage(accountId, serviceId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudStorageProvidersApi.CloudStorageDeleteCloudStorage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **serviceId** | **string**| The ID of the service to access.   Valid values are the service name (\&quot;Box\&quot;) or the numerical serviceId (\&quot;4136\&quot;). | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 

### Return type

[**CloudStorageProviders**](CloudStorageProviders.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cloudstoragedeletecloudstorageproviders"></a>
# **CloudStorageDeleteCloudStorageProviders**
> CloudStorageProviders CloudStorageDeleteCloudStorageProviders (string accountId, string userId, CloudStorageProviders cloudStorageProviders = null)

Deletes the user authentication information for one or more cloud storage providers.

Deletes the user authentication information for one or more cloud storage providers. The next time the user tries to access the cloud storage provider, they must pass normal authentication.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CloudStorageDeleteCloudStorageProvidersExample
    {
        public void main()
        {
            
            var apiInstance = new CloudStorageProvidersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var cloudStorageProviders = new CloudStorageProviders(); // CloudStorageProviders |  (optional) 

            try
            {
                // Deletes the user authentication information for one or more cloud storage providers.
                CloudStorageProviders result = apiInstance.CloudStorageDeleteCloudStorageProviders(accountId, userId, cloudStorageProviders);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudStorageProvidersApi.CloudStorageDeleteCloudStorageProviders: " + e.Message );
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
 **cloudStorageProviders** | [**CloudStorageProviders**](CloudStorageProviders.md)|  | [optional] 

### Return type

[**CloudStorageProviders**](CloudStorageProviders.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cloudstoragegetcloudstorage"></a>
# **CloudStorageGetCloudStorage**
> CloudStorageProviders CloudStorageGetCloudStorage (string accountId, string serviceId, string userId, string redirectUrl = null)

Gets the specified Cloud Storage Provider configuration for the User.

Retrieves the list of cloud storage providers enabled for the account and the configuration information for the user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CloudStorageGetCloudStorageExample
    {
        public void main()
        {
            
            var apiInstance = new CloudStorageProvidersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var serviceId = serviceId_example;  // string | The ID of the service to access.   Valid values are the service name (\"Box\") or the numerical serviceId (\"4136\").
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var redirectUrl = redirectUrl_example;  // string |  The URL the user is redirected to after the cloud storage provider authenticates the user. Using this will append the redirectUrl to the authenticationUrl.  The redirectUrl is restricted to URLs in the docusign.com or docusign.net domains.   (optional) 

            try
            {
                // Gets the specified Cloud Storage Provider configuration for the User.
                CloudStorageProviders result = apiInstance.CloudStorageGetCloudStorage(accountId, serviceId, userId, redirectUrl);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudStorageProvidersApi.CloudStorageGetCloudStorage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **serviceId** | **string**| The ID of the service to access.   Valid values are the service name (\&quot;Box\&quot;) or the numerical serviceId (\&quot;4136\&quot;). | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **redirectUrl** | **string**|  The URL the user is redirected to after the cloud storage provider authenticates the user. Using this will append the redirectUrl to the authenticationUrl.  The redirectUrl is restricted to URLs in the docusign.com or docusign.net domains.   | [optional] 

### Return type

[**CloudStorageProviders**](CloudStorageProviders.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cloudstoragegetcloudstorageproviders"></a>
# **CloudStorageGetCloudStorageProviders**
> CloudStorageProviders CloudStorageGetCloudStorageProviders (string accountId, string userId, string redirectUrl = null)

Get the Cloud Storage Provider configuration for the specified user.

Retrieves the list of cloud storage providers enabled for the account and the configuration information for the user. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CloudStorageGetCloudStorageProvidersExample
    {
        public void main()
        {
            
            var apiInstance = new CloudStorageProvidersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var redirectUrl = redirectUrl_example;  // string |  The URL the user is redirected to after the cloud storage provider authenticates the user. Using this will append the redirectUrl to the authenticationUrl.  The redirectUrl is restricted to URLs in the docusign.com or docusign.net domains.   (optional) 

            try
            {
                // Get the Cloud Storage Provider configuration for the specified user.
                CloudStorageProviders result = apiInstance.CloudStorageGetCloudStorageProviders(accountId, userId, redirectUrl);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudStorageProvidersApi.CloudStorageGetCloudStorageProviders: " + e.Message );
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
 **redirectUrl** | **string**|  The URL the user is redirected to after the cloud storage provider authenticates the user. Using this will append the redirectUrl to the authenticationUrl.  The redirectUrl is restricted to URLs in the docusign.com or docusign.net domains.   | [optional] 

### Return type

[**CloudStorageProviders**](CloudStorageProviders.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cloudstoragepostcloudstorage"></a>
# **CloudStoragePostCloudStorage**
> CloudStorageProviders CloudStoragePostCloudStorage (string accountId, string userId, CloudStorageProviders cloudStorageProviders = null)

Configures the redirect URL information  for one or more cloud storage providers for the specified user.

Configures the redirect URL information  for one or more cloud storage providers for the specified user. The redirect URL is added to the authentication URL to complete the return route.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CloudStoragePostCloudStorageExample
    {
        public void main()
        {
            
            var apiInstance = new CloudStorageProvidersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var cloudStorageProviders = new CloudStorageProviders(); // CloudStorageProviders |  (optional) 

            try
            {
                // Configures the redirect URL information  for one or more cloud storage providers for the specified user.
                CloudStorageProviders result = apiInstance.CloudStoragePostCloudStorage(accountId, userId, cloudStorageProviders);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudStorageProvidersApi.CloudStoragePostCloudStorage: " + e.Message );
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
 **cloudStorageProviders** | [**CloudStorageProviders**](CloudStorageProviders.md)|  | [optional] 

### Return type

[**CloudStorageProviders**](CloudStorageProviders.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

