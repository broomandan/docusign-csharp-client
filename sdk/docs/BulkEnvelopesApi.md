# IO.Swagger.Api.BulkEnvelopesApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkEnvelopesGetBulkEnvelopesBatchId**](BulkEnvelopesApi.md#bulkenvelopesgetbulkenvelopesbatchid) | **GET** /v2/accounts/{accountId}/bulk_envelopes/{batchId} | Gets the status of a specified bulk send operation.
[**BulkEnvelopesGetEnvelopesBulk**](BulkEnvelopesApi.md#bulkenvelopesgetenvelopesbulk) | **GET** /v2/accounts/{accountId}/bulk_envelopes | Gets status information about bulk recipient batches.


<a name="bulkenvelopesgetbulkenvelopesbatchid"></a>
# **BulkEnvelopesGetBulkEnvelopesBatchId**
> BulkEnvelopeStatus BulkEnvelopesGetBulkEnvelopesBatchId (string accountId, string batchId, string count = null, string include = null, string startPosition = null)

Gets the status of a specified bulk send operation.

Retrieves the status information of a single bulk recipient batch. A bulk recipient batch is the set of envelopes sent from a single bulk recipient file. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BulkEnvelopesGetBulkEnvelopesBatchIdExample
    {
        public void main()
        {
            
            var apiInstance = new BulkEnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var batchId = batchId_example;  // string | 
            var count = count_example;  // string | Specifies the number of entries to return. (optional) 
            var include = include_example;  // string | Specifies which entries are included in the response. Multiple entries can be included by using commas in the query string (example: ?include=\"failed,queued\")   Valid values:  * all - Returns all entries. If present, overrides all other query settings. This is the default if no query string is provided. * failed - Entries with a failed status. * processing - Entries with a processing status. * queued - Entries with a queued status. * sent - Entries with a sent status.   (optional) 
            var startPosition = startPosition_example;  // string | Specifies the location in the list of envelopes from which to start. (optional) 

            try
            {
                // Gets the status of a specified bulk send operation.
                BulkEnvelopeStatus result = apiInstance.BulkEnvelopesGetBulkEnvelopesBatchId(accountId, batchId, count, include, startPosition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkEnvelopesApi.BulkEnvelopesGetBulkEnvelopesBatchId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **batchId** | **string**|  | 
 **count** | **string**| Specifies the number of entries to return. | [optional] 
 **include** | **string**| Specifies which entries are included in the response. Multiple entries can be included by using commas in the query string (example: ?include&#x3D;\&quot;failed,queued\&quot;)   Valid values:  * all - Returns all entries. If present, overrides all other query settings. This is the default if no query string is provided. * failed - Entries with a failed status. * processing - Entries with a processing status. * queued - Entries with a queued status. * sent - Entries with a sent status.   | [optional] 
 **startPosition** | **string**| Specifies the location in the list of envelopes from which to start. | [optional] 

### Return type

[**BulkEnvelopeStatus**](BulkEnvelopeStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkenvelopesgetenvelopesbulk"></a>
# **BulkEnvelopesGetEnvelopesBulk**
> BulkEnvelopes BulkEnvelopesGetEnvelopesBulk (string accountId, string count = null, string include = null, string startPosition = null)

Gets status information about bulk recipient batches.

Retrieves status information about all the bulk recipient batches. A bulk recipient batch is the set of envelopes sent from a single bulk recipient file. The response includes general information about each bulk recipient batch.   The response returns information about the envelopes sent with bulk recipient batches, including the `batchId` property, which can be used to retrieve a more detailed status of individual bulk recipient batches.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BulkEnvelopesGetEnvelopesBulkExample
    {
        public void main()
        {
            
            var apiInstance = new BulkEnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var count = count_example;  // string | The number of results to return. This can be 1 to 20. (optional) 
            var include = include_example;  // string | Specifies which entries are included in the response. Multiple entries can be included by using commas in the query string (example: ?include=\"failed,queued\")   Valid values:  * all - Returns all entries. If present, overrides all other query settings. This is the default if no query string is provided. * failed - Entries with a failed status. * processing - Entries with a processing status. * queued - Entries with a queued status. * sent - Entries with a sent status.   (optional) 
            var startPosition = startPosition_example;  // string | The position of the bulk envelope items in the response. This is used for repeated calls, when the number of bulk envelopes returned is too large for one return. The default value is 0. (optional) 

            try
            {
                // Gets status information about bulk recipient batches.
                BulkEnvelopes result = apiInstance.BulkEnvelopesGetEnvelopesBulk(accountId, count, include, startPosition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkEnvelopesApi.BulkEnvelopesGetEnvelopesBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **count** | **string**| The number of results to return. This can be 1 to 20. | [optional] 
 **include** | **string**| Specifies which entries are included in the response. Multiple entries can be included by using commas in the query string (example: ?include&#x3D;\&quot;failed,queued\&quot;)   Valid values:  * all - Returns all entries. If present, overrides all other query settings. This is the default if no query string is provided. * failed - Entries with a failed status. * processing - Entries with a processing status. * queued - Entries with a queued status. * sent - Entries with a sent status.   | [optional] 
 **startPosition** | **string**| The position of the bulk envelope items in the response. This is used for repeated calls, when the number of bulk envelopes returned is too large for one return. The default value is 0. | [optional] 

### Return type

[**BulkEnvelopes**](BulkEnvelopes.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

