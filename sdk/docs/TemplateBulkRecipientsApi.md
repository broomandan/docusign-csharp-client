# IO.Swagger.Api.TemplateBulkRecipientsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RecipientsDeleteTemplateBulkRecipientsFile**](TemplateBulkRecipientsApi.md#recipientsdeletetemplatebulkrecipientsfile) | **DELETE** /v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/bulk_recipients | Deletes the bulk recipient list on a template.
[**RecipientsGetTemplateBulkRecipients**](TemplateBulkRecipientsApi.md#recipientsgettemplatebulkrecipients) | **GET** /v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/bulk_recipients | Gets the bulk recipient file from a template.
[**RecipientsPutTemplateBulkRecipients**](TemplateBulkRecipientsApi.md#recipientsputtemplatebulkrecipients) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/bulk_recipients | Adds or replaces the bulk recipients list in a template.


<a name="recipientsdeletetemplatebulkrecipientsfile"></a>
# **RecipientsDeleteTemplateBulkRecipientsFile**
> BulkRecipientsUpdateResponse RecipientsDeleteTemplateBulkRecipientsFile (string accountId, string recipientId, string templateId)

Deletes the bulk recipient list on a template.

Deletes the bulk recipient list on a template.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsDeleteTemplateBulkRecipientsFileExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateBulkRecipientsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Deletes the bulk recipient list on a template.
                BulkRecipientsUpdateResponse result = apiInstance.RecipientsDeleteTemplateBulkRecipientsFile(accountId, recipientId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateBulkRecipientsApi.RecipientsDeleteTemplateBulkRecipientsFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **recipientId** | **string**| The &#x60;recipientId&#x60; used when the envelope or template was created. | 
 **templateId** | **string**| The ID of the template being accessed. | 

### Return type

[**BulkRecipientsUpdateResponse**](BulkRecipientsUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsgettemplatebulkrecipients"></a>
# **RecipientsGetTemplateBulkRecipients**
> TemplateBulkRecipients RecipientsGetTemplateBulkRecipients (string accountId, string recipientId, string templateId, string includeTabs = null, string startPosition = null)

Gets the bulk recipient file from a template.

Retrieves the bulk recipient file information from a template that has a bulk recipient.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsGetTemplateBulkRecipientsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateBulkRecipientsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var includeTabs = includeTabs_example;  // string | When set to **true**, the tab information associated with the recipient is included in the response. (optional) 
            var startPosition = startPosition_example;  // string | Reserved for DocuSign.  (optional) 

            try
            {
                // Gets the bulk recipient file from a template.
                TemplateBulkRecipients result = apiInstance.RecipientsGetTemplateBulkRecipients(accountId, recipientId, templateId, includeTabs, startPosition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateBulkRecipientsApi.RecipientsGetTemplateBulkRecipients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **recipientId** | **string**| The &#x60;recipientId&#x60; used when the envelope or template was created. | 
 **templateId** | **string**| The ID of the template being accessed. | 
 **includeTabs** | **string**| When set to **true**, the tab information associated with the recipient is included in the response. | [optional] 
 **startPosition** | **string**| Reserved for DocuSign.  | [optional] 

### Return type

[**TemplateBulkRecipients**](TemplateBulkRecipients.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsputtemplatebulkrecipients"></a>
# **RecipientsPutTemplateBulkRecipients**
> BulkRecipientsSummaryResponse RecipientsPutTemplateBulkRecipients (string accountId, string recipientId, string templateId, BulkRecipientsRequest bulkRecipientsRequest = null)

Adds or replaces the bulk recipients list in a template.

Updates the bulk recipients in a template using a file upload. The Content-Type supported for uploading a bulk recipient file is CSV (text/csv).  The REST API does not support modifying individual rows or values in the bulk recipients file. It only allows the entire file to be added or replaced with a new file.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsPutTemplateBulkRecipientsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateBulkRecipientsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var bulkRecipientsRequest = new BulkRecipientsRequest(); // BulkRecipientsRequest |  (optional) 

            try
            {
                // Adds or replaces the bulk recipients list in a template.
                BulkRecipientsSummaryResponse result = apiInstance.RecipientsPutTemplateBulkRecipients(accountId, recipientId, templateId, bulkRecipientsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateBulkRecipientsApi.RecipientsPutTemplateBulkRecipients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **recipientId** | **string**| The &#x60;recipientId&#x60; used when the envelope or template was created. | 
 **templateId** | **string**| The ID of the template being accessed. | 
 **bulkRecipientsRequest** | [**BulkRecipientsRequest**](BulkRecipientsRequest.md)|  | [optional] 

### Return type

[**BulkRecipientsSummaryResponse**](BulkRecipientsSummaryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

