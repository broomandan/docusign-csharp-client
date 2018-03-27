# IO.Swagger.Api.EnvelopeBulkRecipientsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RecipientsDeleteBulkRecipientsFile**](EnvelopeBulkRecipientsApi.md#recipientsdeletebulkrecipientsfile) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/bulk_recipients | Deletes the bulk recipient file from an envelope.
[**RecipientsGetBulkRecipients**](EnvelopeBulkRecipientsApi.md#recipientsgetbulkrecipients) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/bulk_recipients | Gets the bulk recipient file from an envelope.
[**RecipientsPutBulkRecipients**](EnvelopeBulkRecipientsApi.md#recipientsputbulkrecipients) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/bulk_recipients | Adds or replaces envelope bulk recipients.


<a name="recipientsdeletebulkrecipientsfile"></a>
# **RecipientsDeleteBulkRecipientsFile**
> BulkRecipientsUpdateResponse RecipientsDeleteBulkRecipientsFile (string accountId, string envelopeId, string recipientId)

Deletes the bulk recipient file from an envelope.

Deletes the bulk recipient file from an envelope. This cannot be used if the envelope has been sent.  After using this, the `bulkRecipientsUri` property is not returned in subsequent GET calls for the envelope, but the recipient will remain as a bulk recipient.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsDeleteBulkRecipientsFileExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeBulkRecipientsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.

            try
            {
                // Deletes the bulk recipient file from an envelope.
                BulkRecipientsUpdateResponse result = apiInstance.RecipientsDeleteBulkRecipientsFile(accountId, envelopeId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeBulkRecipientsApi.RecipientsDeleteBulkRecipientsFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelope&#39;s GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec  | 
 **recipientId** | **string**| The &#x60;recipientId&#x60; used when the envelope or template was created. | 

### Return type

[**BulkRecipientsUpdateResponse**](BulkRecipientsUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsgetbulkrecipients"></a>
# **RecipientsGetBulkRecipients**
> EnvelopeBulkRecipients RecipientsGetBulkRecipients (string accountId, string envelopeId, string recipientId, string includeTabs = null, string startPosition = null)

Gets the bulk recipient file from an envelope.

Retrieves the bulk recipient file information from an envelope that has a bulk recipient.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsGetBulkRecipientsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeBulkRecipientsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.
            var includeTabs = includeTabs_example;  // string | If **true** include the tabs in the the result.  (optional) 
            var startPosition = startPosition_example;  // string | Reserved for DocuSign.  (optional) 

            try
            {
                // Gets the bulk recipient file from an envelope.
                EnvelopeBulkRecipients result = apiInstance.RecipientsGetBulkRecipients(accountId, envelopeId, recipientId, includeTabs, startPosition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeBulkRecipientsApi.RecipientsGetBulkRecipients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelope&#39;s GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec  | 
 **recipientId** | **string**| The &#x60;recipientId&#x60; used when the envelope or template was created. | 
 **includeTabs** | **string**| If **true** include the tabs in the the result.  | [optional] 
 **startPosition** | **string**| Reserved for DocuSign.  | [optional] 

### Return type

[**EnvelopeBulkRecipients**](EnvelopeBulkRecipients.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsputbulkrecipients"></a>
# **RecipientsPutBulkRecipients**
> BulkRecipientsSummaryResponse RecipientsPutBulkRecipients (string accountId, string envelopeId, string recipientId, BulkRecipientsRequest bulkRecipientsRequest = null)

Adds or replaces envelope bulk recipients.

Updates the bulk recipients in a draft envelope using a file upload. The Content-Type supported for uploading a bulk recipient file is CSV (text/csv).  The REST API does not support modifying individual rows or values in the bulk recipients file. It only allows the entire file to be added or replaced with a new file.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsPutBulkRecipientsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeBulkRecipientsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.
            var bulkRecipientsRequest = new BulkRecipientsRequest(); // BulkRecipientsRequest |  (optional) 

            try
            {
                // Adds or replaces envelope bulk recipients.
                BulkRecipientsSummaryResponse result = apiInstance.RecipientsPutBulkRecipients(accountId, envelopeId, recipientId, bulkRecipientsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeBulkRecipientsApi.RecipientsPutBulkRecipients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelope&#39;s GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec  | 
 **recipientId** | **string**| The &#x60;recipientId&#x60; used when the envelope or template was created. | 
 **bulkRecipientsRequest** | [**BulkRecipientsRequest**](BulkRecipientsRequest.md)|  | [optional] 

### Return type

[**BulkRecipientsSummaryResponse**](BulkRecipientsSummaryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

