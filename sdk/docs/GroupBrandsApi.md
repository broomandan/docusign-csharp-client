# IO.Swagger.Api.GroupBrandsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BrandsDeleteGroupBrands**](GroupBrandsApi.md#brandsdeletegroupbrands) | **DELETE** /v2/accounts/{accountId}/groups/{groupId}/brands | Deletes brand information from the requested group.
[**BrandsGetGroupBrands**](GroupBrandsApi.md#brandsgetgroupbrands) | **GET** /v2/accounts/{accountId}/groups/{groupId}/brands | Gets group brand ID Information. 
[**BrandsPutGroupBrands**](GroupBrandsApi.md#brandsputgroupbrands) | **PUT** /v2/accounts/{accountId}/groups/{groupId}/brands | Adds group brand ID information to a group.


<a name="brandsdeletegroupbrands"></a>
# **BrandsDeleteGroupBrands**
> GroupBrands BrandsDeleteGroupBrands (string accountId, string groupId, BrandsRequest brandsRequest = null)

Deletes brand information from the requested group.

Deletes brand information from the requested group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandsDeleteGroupBrandsExample
    {
        public void main()
        {
            
            var apiInstance = new GroupBrandsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groupId = groupId_example;  // string | The ID of the group being accessed.
            var brandsRequest = new BrandsRequest(); // BrandsRequest |  (optional) 

            try
            {
                // Deletes brand information from the requested group.
                GroupBrands result = apiInstance.BrandsDeleteGroupBrands(accountId, groupId, brandsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupBrandsApi.BrandsDeleteGroupBrands: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groupId** | **string**| The ID of the group being accessed. | 
 **brandsRequest** | [**BrandsRequest**](BrandsRequest.md)|  | [optional] 

### Return type

[**GroupBrands**](GroupBrands.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="brandsgetgroupbrands"></a>
# **BrandsGetGroupBrands**
> GroupBrands BrandsGetGroupBrands (string accountId, string groupId)

Gets group brand ID Information. 

Retrieves information about the brands associated with the requested group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandsGetGroupBrandsExample
    {
        public void main()
        {
            
            var apiInstance = new GroupBrandsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groupId = groupId_example;  // string | The ID of the group being accessed.

            try
            {
                // Gets group brand ID Information. 
                GroupBrands result = apiInstance.BrandsGetGroupBrands(accountId, groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupBrandsApi.BrandsGetGroupBrands: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groupId** | **string**| The ID of the group being accessed. | 

### Return type

[**GroupBrands**](GroupBrands.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="brandsputgroupbrands"></a>
# **BrandsPutGroupBrands**
> GroupBrands BrandsPutGroupBrands (string accountId, string groupId, BrandsRequest brandsRequest = null)

Adds group brand ID information to a group.

Adds group brand ID information to a group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandsPutGroupBrandsExample
    {
        public void main()
        {
            
            var apiInstance = new GroupBrandsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groupId = groupId_example;  // string | The ID of the group being accessed.
            var brandsRequest = new BrandsRequest(); // BrandsRequest |  (optional) 

            try
            {
                // Adds group brand ID information to a group.
                GroupBrands result = apiInstance.BrandsPutGroupBrands(accountId, groupId, brandsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupBrandsApi.BrandsPutGroupBrands: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groupId** | **string**| The ID of the group being accessed. | 
 **brandsRequest** | [**BrandsRequest**](BrandsRequest.md)|  | [optional] 

### Return type

[**GroupBrands**](GroupBrands.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

