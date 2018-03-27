# IO.Swagger.Api.EnvelopeDocumentVisibilityApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RecipientsGetRecipientDocumentVisibility**](EnvelopeDocumentVisibilityApi.md#recipientsgetrecipientdocumentvisibility) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/document_visibility | Returns document visibility for the recipients
[**RecipientsPutRecipientDocumentVisibility**](EnvelopeDocumentVisibilityApi.md#recipientsputrecipientdocumentvisibility) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/document_visibility | Updates document visibility for the recipients
[**RecipientsPutRecipientsDocumentVisibility**](EnvelopeDocumentVisibilityApi.md#recipientsputrecipientsdocumentvisibility) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/document_visibility | Updates document visibility for the recipients


<a name="recipientsgetrecipientdocumentvisibility"></a>
# **RecipientsGetRecipientDocumentVisibility**
> EnvelopeDocumentVisibility RecipientsGetRecipientDocumentVisibility (string accountId, string envelopeId, string recipientId)

Returns document visibility for the recipients



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsGetRecipientDocumentVisibilityExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeDocumentVisibilityApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.

            try
            {
                // Returns document visibility for the recipients
                EnvelopeDocumentVisibility result = apiInstance.RecipientsGetRecipientDocumentVisibility(accountId, envelopeId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeDocumentVisibilityApi.RecipientsGetRecipientDocumentVisibility: " + e.Message );
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

[**EnvelopeDocumentVisibility**](EnvelopeDocumentVisibility.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsputrecipientdocumentvisibility"></a>
# **RecipientsPutRecipientDocumentVisibility**
> EnvelopeDocumentVisibility RecipientsPutRecipientDocumentVisibility (string accountId, string envelopeId, string recipientId, EnvelopeDocumentVisibility envelopeDocumentVisibility = null)

Updates document visibility for the recipients



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsPutRecipientDocumentVisibilityExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeDocumentVisibilityApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.
            var envelopeDocumentVisibility = new EnvelopeDocumentVisibility(); // EnvelopeDocumentVisibility |  (optional) 

            try
            {
                // Updates document visibility for the recipients
                EnvelopeDocumentVisibility result = apiInstance.RecipientsPutRecipientDocumentVisibility(accountId, envelopeId, recipientId, envelopeDocumentVisibility);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeDocumentVisibilityApi.RecipientsPutRecipientDocumentVisibility: " + e.Message );
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
 **envelopeDocumentVisibility** | [**EnvelopeDocumentVisibility**](EnvelopeDocumentVisibility.md)|  | [optional] 

### Return type

[**EnvelopeDocumentVisibility**](EnvelopeDocumentVisibility.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsputrecipientsdocumentvisibility"></a>
# **RecipientsPutRecipientsDocumentVisibility**
> EnvelopeDocumentVisibility RecipientsPutRecipientsDocumentVisibility (string accountId, string envelopeId, EnvelopeDocumentVisibility envelopeDocumentVisibility = null)

Updates document visibility for the recipients



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsPutRecipientsDocumentVisibilityExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeDocumentVisibilityApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var envelopeDocumentVisibility = new EnvelopeDocumentVisibility(); // EnvelopeDocumentVisibility |  (optional) 

            try
            {
                // Updates document visibility for the recipients
                EnvelopeDocumentVisibility result = apiInstance.RecipientsPutRecipientsDocumentVisibility(accountId, envelopeId, envelopeDocumentVisibility);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeDocumentVisibilityApi.RecipientsPutRecipientsDocumentVisibility: " + e.Message );
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
 **envelopeDocumentVisibility** | [**EnvelopeDocumentVisibility**](EnvelopeDocumentVisibility.md)|  | [optional] 

### Return type

[**EnvelopeDocumentVisibility**](EnvelopeDocumentVisibility.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

