# IO.Swagger.Api.AccountWatermarksApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WatermarkGetWatermark**](AccountWatermarksApi.md#watermarkgetwatermark) | **GET** /v2/accounts/{accountId}/watermark | Get watermark information.
[**WatermarkPreviewPutWatermarkPreview**](AccountWatermarksApi.md#watermarkpreviewputwatermarkpreview) | **PUT** /v2/accounts/{accountId}/watermark/preview | Get watermark preview.
[**WatermarkPutWatermark**](AccountWatermarksApi.md#watermarkputwatermark) | **PUT** /v2/accounts/{accountId}/watermark | Update watermark information.


<a name="watermarkgetwatermark"></a>
# **WatermarkGetWatermark**
> AccountWatermarks WatermarkGetWatermark (string accountId)

Get watermark information.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WatermarkGetWatermarkExample
    {
        public void main()
        {
            
            var apiInstance = new AccountWatermarksApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Get watermark information.
                AccountWatermarks result = apiInstance.WatermarkGetWatermark(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountWatermarksApi.WatermarkGetWatermark: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**AccountWatermarks**](AccountWatermarks.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="watermarkpreviewputwatermarkpreview"></a>
# **WatermarkPreviewPutWatermarkPreview**
> AccountWatermarks WatermarkPreviewPutWatermarkPreview (string accountId, AccountWatermarks accountWatermarks = null)

Get watermark preview.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WatermarkPreviewPutWatermarkPreviewExample
    {
        public void main()
        {
            
            var apiInstance = new AccountWatermarksApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var accountWatermarks = new AccountWatermarks(); // AccountWatermarks |  (optional) 

            try
            {
                // Get watermark preview.
                AccountWatermarks result = apiInstance.WatermarkPreviewPutWatermarkPreview(accountId, accountWatermarks);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountWatermarksApi.WatermarkPreviewPutWatermarkPreview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **accountWatermarks** | [**AccountWatermarks**](AccountWatermarks.md)|  | [optional] 

### Return type

[**AccountWatermarks**](AccountWatermarks.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="watermarkputwatermark"></a>
# **WatermarkPutWatermark**
> AccountWatermarks WatermarkPutWatermark (string accountId, AccountWatermarks accountWatermarks = null)

Update watermark information.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WatermarkPutWatermarkExample
    {
        public void main()
        {
            
            var apiInstance = new AccountWatermarksApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var accountWatermarks = new AccountWatermarks(); // AccountWatermarks |  (optional) 

            try
            {
                // Update watermark information.
                AccountWatermarks result = apiInstance.WatermarkPutWatermark(accountId, accountWatermarks);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountWatermarksApi.WatermarkPutWatermark: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **accountWatermarks** | [**AccountWatermarks**](AccountWatermarks.md)|  | [optional] 

### Return type

[**AccountWatermarks**](AccountWatermarks.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

