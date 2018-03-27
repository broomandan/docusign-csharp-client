# IO.Swagger.Api.CloudStorageApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CloudStorageFolderGetCloudStorageFolder**](CloudStorageApi.md#cloudstoragefoldergetcloudstoragefolder) | **GET** /v2/accounts/{accountId}/users/{userId}/cloud_storage/{serviceId}/folders/{folderId} | Gets a list of all the items from the specified cloud storage provider.
[**CloudStorageFolderGetCloudStorageFolderAll**](CloudStorageApi.md#cloudstoragefoldergetcloudstoragefolderall) | **GET** /v2/accounts/{accountId}/users/{userId}/cloud_storage/{serviceId}/folders | Retrieves a list of all the items in a specified folder from the specified cloud storage provider.


<a name="cloudstoragefoldergetcloudstoragefolder"></a>
# **CloudStorageFolderGetCloudStorageFolder**
> CloudStorage CloudStorageFolderGetCloudStorageFolder (string accountId, string folderId, string serviceId, string userId, string cloudStorageFolderPath = null, string count = null, string order = null, string orderBy = null, string searchText = null, string startPosition = null)

Gets a list of all the items from the specified cloud storage provider.

Retrieves a list of all the items in all  the folders associated with the user from the specified cloud storage provider. You can limit the scope of the returned items by providing a comma separated list of folder IDs in the request.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CloudStorageFolderGetCloudStorageFolderExample
    {
        public void main()
        {
            
            var apiInstance = new CloudStorageApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var folderId = folderId_example;  // string | The ID of the folder being accessed.
            var serviceId = serviceId_example;  // string | The ID of the service to access.   Valid values are the service name (\"Box\") or the numerical serviceId (\"4136\").
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var cloudStorageFolderPath = cloudStorageFolderPath_example;  // string |  (optional) 
            var count = count_example;  // string | An optional value that sets how many items are included in the response.   The default setting for this is 25.  (optional) 
            var order = order_example;  // string | An optional value that sets the direction order used to sort the item list.   Valid values are:   * asc = ascending sort order * desc = descending sort order  (optional) 
            var orderBy = orderBy_example;  // string | An optional value that sets the file attribute used to sort the item list.   Valid values are:   * modified * name   (optional) 
            var searchText = searchText_example;  // string |  (optional) 
            var startPosition = startPosition_example;  // string | Indicates the starting point of the first item included in the response set. It uses a 0-based index. The default setting for this is 0.   (optional) 

            try
            {
                // Gets a list of all the items from the specified cloud storage provider.
                CloudStorage result = apiInstance.CloudStorageFolderGetCloudStorageFolder(accountId, folderId, serviceId, userId, cloudStorageFolderPath, count, order, orderBy, searchText, startPosition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudStorageApi.CloudStorageFolderGetCloudStorageFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **folderId** | **string**| The ID of the folder being accessed. | 
 **serviceId** | **string**| The ID of the service to access.   Valid values are the service name (\&quot;Box\&quot;) or the numerical serviceId (\&quot;4136\&quot;). | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **cloudStorageFolderPath** | **string**|  | [optional] 
 **count** | **string**| An optional value that sets how many items are included in the response.   The default setting for this is 25.  | [optional] 
 **order** | **string**| An optional value that sets the direction order used to sort the item list.   Valid values are:   * asc &#x3D; ascending sort order * desc &#x3D; descending sort order  | [optional] 
 **orderBy** | **string**| An optional value that sets the file attribute used to sort the item list.   Valid values are:   * modified * name   | [optional] 
 **searchText** | **string**|  | [optional] 
 **startPosition** | **string**| Indicates the starting point of the first item included in the response set. It uses a 0-based index. The default setting for this is 0.   | [optional] 

### Return type

[**CloudStorage**](CloudStorage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cloudstoragefoldergetcloudstoragefolderall"></a>
# **CloudStorageFolderGetCloudStorageFolderAll**
> CloudStorage CloudStorageFolderGetCloudStorageFolderAll (string accountId, string serviceId, string userId, string cloudStorageFolderPath = null, string count = null, string order = null, string orderBy = null, string searchText = null, string startPosition = null)

Retrieves a list of all the items in a specified folder from the specified cloud storage provider.

Retrieves a list of all the items in a specified folder from the specified cloud storage provider. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CloudStorageFolderGetCloudStorageFolderAllExample
    {
        public void main()
        {
            
            var apiInstance = new CloudStorageApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var serviceId = serviceId_example;  // string | The ID of the service to access.   Valid values are the service name (\"Box\") or the numerical serviceId (\"4136\").
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var cloudStorageFolderPath = cloudStorageFolderPath_example;  // string | A comma separated list of folder IDs included in the request.  (optional) 
            var count = count_example;  // string | An optional value that sets how many items are included in the response.   The default setting for this is 25.  (optional) 
            var order = order_example;  // string | An optional value that sets the direction order used to sort the item list.   Valid values are:   * asc = ascending sort order * desc = descending sort order  (optional) 
            var orderBy = orderBy_example;  // string | An optional value that sets the file attribute used to sort the item list.   Valid values are:   * modified * name   (optional) 
            var searchText = searchText_example;  // string |  (optional) 
            var startPosition = startPosition_example;  // string | Indicates the starting point of the first item included in the response set. It uses a 0-based index. The default setting for this is 0.   (optional) 

            try
            {
                // Retrieves a list of all the items in a specified folder from the specified cloud storage provider.
                CloudStorage result = apiInstance.CloudStorageFolderGetCloudStorageFolderAll(accountId, serviceId, userId, cloudStorageFolderPath, count, order, orderBy, searchText, startPosition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudStorageApi.CloudStorageFolderGetCloudStorageFolderAll: " + e.Message );
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
 **cloudStorageFolderPath** | **string**| A comma separated list of folder IDs included in the request.  | [optional] 
 **count** | **string**| An optional value that sets how many items are included in the response.   The default setting for this is 25.  | [optional] 
 **order** | **string**| An optional value that sets the direction order used to sort the item list.   Valid values are:   * asc &#x3D; ascending sort order * desc &#x3D; descending sort order  | [optional] 
 **orderBy** | **string**| An optional value that sets the file attribute used to sort the item list.   Valid values are:   * modified * name   | [optional] 
 **searchText** | **string**|  | [optional] 
 **startPosition** | **string**| Indicates the starting point of the first item included in the response set. It uses a 0-based index. The default setting for this is 0.   | [optional] 

### Return type

[**CloudStorage**](CloudStorage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

