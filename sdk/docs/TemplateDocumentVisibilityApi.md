# IO.Swagger.Api.TemplateDocumentVisibilityApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RecipientsGetTemplateRecipientDocumentVisibility**](TemplateDocumentVisibilityApi.md#recipientsgettemplaterecipientdocumentvisibility) | **GET** /v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/document_visibility | Returns document visibility for the recipients
[**RecipientsPutTemplateRecipientDocumentVisibility**](TemplateDocumentVisibilityApi.md#recipientsputtemplaterecipientdocumentvisibility) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/document_visibility | Updates document visibility for the recipients
[**RecipientsPutTemplateRecipientsDocumentVisibility**](TemplateDocumentVisibilityApi.md#recipientsputtemplaterecipientsdocumentvisibility) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/recipients/document_visibility | Updates document visibility for the recipients


<a name="recipientsgettemplaterecipientdocumentvisibility"></a>
# **RecipientsGetTemplateRecipientDocumentVisibility**
> EnvelopeDocumentVisibility RecipientsGetTemplateRecipientDocumentVisibility (string accountId, string recipientId, string templateId)

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
    public class RecipientsGetTemplateRecipientDocumentVisibilityExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateDocumentVisibilityApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Returns document visibility for the recipients
                EnvelopeDocumentVisibility result = apiInstance.RecipientsGetTemplateRecipientDocumentVisibility(accountId, recipientId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateDocumentVisibilityApi.RecipientsGetTemplateRecipientDocumentVisibility: " + e.Message );
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

[**EnvelopeDocumentVisibility**](EnvelopeDocumentVisibility.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsputtemplaterecipientdocumentvisibility"></a>
# **RecipientsPutTemplateRecipientDocumentVisibility**
> TemplateDocumentVisibility RecipientsPutTemplateRecipientDocumentVisibility (string accountId, string recipientId, string templateId, TemplateDocumentVisibility templateDocumentVisibility = null)

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
    public class RecipientsPutTemplateRecipientDocumentVisibilityExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateDocumentVisibilityApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var templateDocumentVisibility = new TemplateDocumentVisibility(); // TemplateDocumentVisibility |  (optional) 

            try
            {
                // Updates document visibility for the recipients
                TemplateDocumentVisibility result = apiInstance.RecipientsPutTemplateRecipientDocumentVisibility(accountId, recipientId, templateId, templateDocumentVisibility);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateDocumentVisibilityApi.RecipientsPutTemplateRecipientDocumentVisibility: " + e.Message );
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
 **templateDocumentVisibility** | [**TemplateDocumentVisibility**](TemplateDocumentVisibility.md)|  | [optional] 

### Return type

[**TemplateDocumentVisibility**](TemplateDocumentVisibility.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsputtemplaterecipientsdocumentvisibility"></a>
# **RecipientsPutTemplateRecipientsDocumentVisibility**
> TemplateDocumentVisibility RecipientsPutTemplateRecipientsDocumentVisibility (string accountId, string templateId, TemplateDocumentVisibility templateDocumentVisibility = null)

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
    public class RecipientsPutTemplateRecipientsDocumentVisibilityExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateDocumentVisibilityApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var templateDocumentVisibility = new TemplateDocumentVisibility(); // TemplateDocumentVisibility |  (optional) 

            try
            {
                // Updates document visibility for the recipients
                TemplateDocumentVisibility result = apiInstance.RecipientsPutTemplateRecipientsDocumentVisibility(accountId, templateId, templateDocumentVisibility);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateDocumentVisibilityApi.RecipientsPutTemplateRecipientsDocumentVisibility: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 
 **templateDocumentVisibility** | [**TemplateDocumentVisibility**](TemplateDocumentVisibility.md)|  | [optional] 

### Return type

[**TemplateDocumentVisibility**](TemplateDocumentVisibility.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

