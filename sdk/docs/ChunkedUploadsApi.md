# IO.Swagger.Api.ChunkedUploadsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChunkedUploadsDeleteChunkedUpload**](ChunkedUploadsApi.md#chunkeduploadsdeletechunkedupload) | **DELETE** /v2/accounts/{accountId}/chunked_uploads/{chunkedUploadId} | Delete an existing ChunkedUpload.
[**ChunkedUploadsGetChunkedUpload**](ChunkedUploadsApi.md#chunkeduploadsgetchunkedupload) | **GET** /v2/accounts/{accountId}/chunked_uploads/{chunkedUploadId} | Retrieves the current metadata of a ChunkedUpload.
[**ChunkedUploadsPostChunkedUploads**](ChunkedUploadsApi.md#chunkeduploadspostchunkeduploads) | **POST** /v2/accounts/{accountId}/chunked_uploads | Initiate a new ChunkedUpload.
[**ChunkedUploadsPutChunkedUploadPart**](ChunkedUploadsApi.md#chunkeduploadsputchunkeduploadpart) | **PUT** /v2/accounts/{accountId}/chunked_uploads/{chunkedUploadId}/{chunkedUploadPartSeq} | Add a chunk, a chunk &#39;part&#39;, to an existing ChunkedUpload.
[**ChunkedUploadsPutChunkedUploads**](ChunkedUploadsApi.md#chunkeduploadsputchunkeduploads) | **PUT** /v2/accounts/{accountId}/chunked_uploads/{chunkedUploadId} | Integrity-Check and Commit a ChunkedUpload, readying it for use elsewhere.


<a name="chunkeduploadsdeletechunkedupload"></a>
# **ChunkedUploadsDeleteChunkedUpload**
> ChunkedUploads ChunkedUploadsDeleteChunkedUpload (string accountId, string chunkedUploadId)

Delete an existing ChunkedUpload.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChunkedUploadsDeleteChunkedUploadExample
    {
        public void main()
        {
            
            var apiInstance = new ChunkedUploadsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var chunkedUploadId = chunkedUploadId_example;  // string | 

            try
            {
                // Delete an existing ChunkedUpload.
                ChunkedUploads result = apiInstance.ChunkedUploadsDeleteChunkedUpload(accountId, chunkedUploadId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChunkedUploadsApi.ChunkedUploadsDeleteChunkedUpload: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **chunkedUploadId** | **string**|  | 

### Return type

[**ChunkedUploads**](ChunkedUploads.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chunkeduploadsgetchunkedupload"></a>
# **ChunkedUploadsGetChunkedUpload**
> ChunkedUploads ChunkedUploadsGetChunkedUpload (string accountId, string chunkedUploadId, string include = null)

Retrieves the current metadata of a ChunkedUpload.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChunkedUploadsGetChunkedUploadExample
    {
        public void main()
        {
            
            var apiInstance = new ChunkedUploadsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var chunkedUploadId = chunkedUploadId_example;  // string | 
            var include = include_example;  // string | A comma-separated list of additional template attributes to include in the response. Valid values are: recipients, folders, documents, custom_fields, and notifications. (optional) 

            try
            {
                // Retrieves the current metadata of a ChunkedUpload.
                ChunkedUploads result = apiInstance.ChunkedUploadsGetChunkedUpload(accountId, chunkedUploadId, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChunkedUploadsApi.ChunkedUploadsGetChunkedUpload: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **chunkedUploadId** | **string**|  | 
 **include** | **string**| A comma-separated list of additional template attributes to include in the response. Valid values are: recipients, folders, documents, custom_fields, and notifications. | [optional] 

### Return type

[**ChunkedUploads**](ChunkedUploads.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chunkeduploadspostchunkeduploads"></a>
# **ChunkedUploadsPostChunkedUploads**
> ChunkedUploads ChunkedUploadsPostChunkedUploads (string accountId, ChunkedUploadRequest chunkedUploadRequest = null)

Initiate a new ChunkedUpload.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChunkedUploadsPostChunkedUploadsExample
    {
        public void main()
        {
            
            var apiInstance = new ChunkedUploadsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var chunkedUploadRequest = new ChunkedUploadRequest(); // ChunkedUploadRequest |  (optional) 

            try
            {
                // Initiate a new ChunkedUpload.
                ChunkedUploads result = apiInstance.ChunkedUploadsPostChunkedUploads(accountId, chunkedUploadRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChunkedUploadsApi.ChunkedUploadsPostChunkedUploads: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **chunkedUploadRequest** | [**ChunkedUploadRequest**](ChunkedUploadRequest.md)|  | [optional] 

### Return type

[**ChunkedUploads**](ChunkedUploads.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chunkeduploadsputchunkeduploadpart"></a>
# **ChunkedUploadsPutChunkedUploadPart**
> ChunkedUploads ChunkedUploadsPutChunkedUploadPart (string accountId, string chunkedUploadId, string chunkedUploadPartSeq, ChunkedUploadRequest chunkedUploadRequest = null)

Add a chunk, a chunk 'part', to an existing ChunkedUpload.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChunkedUploadsPutChunkedUploadPartExample
    {
        public void main()
        {
            
            var apiInstance = new ChunkedUploadsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var chunkedUploadId = chunkedUploadId_example;  // string | 
            var chunkedUploadPartSeq = chunkedUploadPartSeq_example;  // string | 
            var chunkedUploadRequest = new ChunkedUploadRequest(); // ChunkedUploadRequest |  (optional) 

            try
            {
                // Add a chunk, a chunk 'part', to an existing ChunkedUpload.
                ChunkedUploads result = apiInstance.ChunkedUploadsPutChunkedUploadPart(accountId, chunkedUploadId, chunkedUploadPartSeq, chunkedUploadRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChunkedUploadsApi.ChunkedUploadsPutChunkedUploadPart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **chunkedUploadId** | **string**|  | 
 **chunkedUploadPartSeq** | **string**|  | 
 **chunkedUploadRequest** | [**ChunkedUploadRequest**](ChunkedUploadRequest.md)|  | [optional] 

### Return type

[**ChunkedUploads**](ChunkedUploads.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chunkeduploadsputchunkeduploads"></a>
# **ChunkedUploadsPutChunkedUploads**
> ChunkedUploads ChunkedUploadsPutChunkedUploads (string accountId, string chunkedUploadId, string action = null)

Integrity-Check and Commit a ChunkedUpload, readying it for use elsewhere.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChunkedUploadsPutChunkedUploadsExample
    {
        public void main()
        {
            
            var apiInstance = new ChunkedUploadsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var chunkedUploadId = chunkedUploadId_example;  // string | 
            var action = action_example;  // string |  (optional) 

            try
            {
                // Integrity-Check and Commit a ChunkedUpload, readying it for use elsewhere.
                ChunkedUploads result = apiInstance.ChunkedUploadsPutChunkedUploads(accountId, chunkedUploadId, action);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChunkedUploadsApi.ChunkedUploadsPutChunkedUploads: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **chunkedUploadId** | **string**|  | 
 **action** | **string**|  | [optional] 

### Return type

[**ChunkedUploads**](ChunkedUploads.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

