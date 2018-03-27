# IO.Swagger.Api.TemplateRecipientsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RecipientsDeleteTemplateRecipient**](TemplateRecipientsApi.md#recipientsdeletetemplaterecipient) | **DELETE** /v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId} | Deletes the specified recipient file from a template.
[**RecipientsDeleteTemplateRecipients**](TemplateRecipientsApi.md#recipientsdeletetemplaterecipients) | **DELETE** /v2/accounts/{accountId}/templates/{templateId}/recipients | Deletes recipients from a template.
[**RecipientsGetTemplateRecipients**](TemplateRecipientsApi.md#recipientsgettemplaterecipients) | **GET** /v2/accounts/{accountId}/templates/{templateId}/recipients | Gets recipient information from a template.
[**RecipientsPostTemplateRecipients**](TemplateRecipientsApi.md#recipientsposttemplaterecipients) | **POST** /v2/accounts/{accountId}/templates/{templateId}/recipients | Adds tabs for a recipient.
[**RecipientsPutTemplateRecipients**](TemplateRecipientsApi.md#recipientsputtemplaterecipients) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/recipients | Updates recipients in a template.


<a name="recipientsdeletetemplaterecipient"></a>
# **RecipientsDeleteTemplateRecipient**
> TemplateRecipients RecipientsDeleteTemplateRecipient (string accountId, string recipientId, string templateId, TemplateRecipients templateRecipients = null)

Deletes the specified recipient file from a template.

Deletes the specified recipient file from the specified template.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsDeleteTemplateRecipientExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateRecipientsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var templateRecipients = new TemplateRecipients(); // TemplateRecipients |  (optional) 

            try
            {
                // Deletes the specified recipient file from a template.
                TemplateRecipients result = apiInstance.RecipientsDeleteTemplateRecipient(accountId, recipientId, templateId, templateRecipients);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateRecipientsApi.RecipientsDeleteTemplateRecipient: " + e.Message );
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
 **templateRecipients** | [**TemplateRecipients**](TemplateRecipients.md)|  | [optional] 

### Return type

[**TemplateRecipients**](TemplateRecipients.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsdeletetemplaterecipients"></a>
# **RecipientsDeleteTemplateRecipients**
> TemplateRecipients RecipientsDeleteTemplateRecipients (string accountId, string templateId, TemplateRecipients templateRecipients = null)

Deletes recipients from a template.

Deletes one or more recipients from a template. Recipients to be deleted are listed in the request, with the `recipientId` being used as the key for deleting recipients.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsDeleteTemplateRecipientsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateRecipientsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var templateRecipients = new TemplateRecipients(); // TemplateRecipients |  (optional) 

            try
            {
                // Deletes recipients from a template.
                TemplateRecipients result = apiInstance.RecipientsDeleteTemplateRecipients(accountId, templateId, templateRecipients);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateRecipientsApi.RecipientsDeleteTemplateRecipients: " + e.Message );
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
 **templateRecipients** | [**TemplateRecipients**](TemplateRecipients.md)|  | [optional] 

### Return type

[**TemplateRecipients**](TemplateRecipients.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsgettemplaterecipients"></a>
# **RecipientsGetTemplateRecipients**
> TemplateRecipients RecipientsGetTemplateRecipients (string accountId, string templateId, string includeAnchorTabLocations = null, string includeExtended = null, string includeTabs = null)

Gets recipient information from a template.

Retrieves the information for all recipients in the specified template.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsGetTemplateRecipientsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateRecipientsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var includeAnchorTabLocations = includeAnchorTabLocations_example;  // string |  When set to **true** and `include_tabs` is set to **true**, all tabs with anchor tab properties are included in the response.  (optional) 
            var includeExtended = includeExtended_example;  // string |  When set to **true**, the extended properties are included in the response.  (optional) 
            var includeTabs = includeTabs_example;  // string | When set to **true**, the tab information associated with the recipient is included in the response. (optional) 

            try
            {
                // Gets recipient information from a template.
                TemplateRecipients result = apiInstance.RecipientsGetTemplateRecipients(accountId, templateId, includeAnchorTabLocations, includeExtended, includeTabs);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateRecipientsApi.RecipientsGetTemplateRecipients: " + e.Message );
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
 **includeAnchorTabLocations** | **string**|  When set to **true** and &#x60;include_tabs&#x60; is set to **true**, all tabs with anchor tab properties are included in the response.  | [optional] 
 **includeExtended** | **string**|  When set to **true**, the extended properties are included in the response.  | [optional] 
 **includeTabs** | **string**| When set to **true**, the tab information associated with the recipient is included in the response. | [optional] 

### Return type

[**TemplateRecipients**](TemplateRecipients.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsposttemplaterecipients"></a>
# **RecipientsPostTemplateRecipients**
> TemplateRecipients RecipientsPostTemplateRecipients (string accountId, string templateId, string resendEnvelope = null, TemplateRecipients templateRecipients = null)

Adds tabs for a recipient.

Adds one or more recipients to a template.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsPostTemplateRecipientsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateRecipientsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var resendEnvelope = resendEnvelope_example;  // string | When set to **true**, resends the   envelope if the new recipient's routing order is before or the same as the envelope's next recipient. (optional) 
            var templateRecipients = new TemplateRecipients(); // TemplateRecipients |  (optional) 

            try
            {
                // Adds tabs for a recipient.
                TemplateRecipients result = apiInstance.RecipientsPostTemplateRecipients(accountId, templateId, resendEnvelope, templateRecipients);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateRecipientsApi.RecipientsPostTemplateRecipients: " + e.Message );
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
 **resendEnvelope** | **string**| When set to **true**, resends the   envelope if the new recipient&#39;s routing order is before or the same as the envelope&#39;s next recipient. | [optional] 
 **templateRecipients** | [**TemplateRecipients**](TemplateRecipients.md)|  | [optional] 

### Return type

[**TemplateRecipients**](TemplateRecipients.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsputtemplaterecipients"></a>
# **RecipientsPutTemplateRecipients**
> RecipientsUpdateSummary RecipientsPutTemplateRecipients (string accountId, string templateId, string resendEnvelope = null, TemplateRecipients templateRecipients = null)

Updates recipients in a template.

Updates recipients in a template.   You can edit the following properties: `email`, `userName`, `routingOrder`, `faxNumber`, `deliveryMethod`, `accessCode`, and `requireIdLookup`.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsPutTemplateRecipientsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateRecipientsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var resendEnvelope = resendEnvelope_example;  // string | When set to **true**, resends the   envelope if the new recipient's routing order is before or the same as the envelope's next recipient. (optional) 
            var templateRecipients = new TemplateRecipients(); // TemplateRecipients |  (optional) 

            try
            {
                // Updates recipients in a template.
                RecipientsUpdateSummary result = apiInstance.RecipientsPutTemplateRecipients(accountId, templateId, resendEnvelope, templateRecipients);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateRecipientsApi.RecipientsPutTemplateRecipients: " + e.Message );
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
 **resendEnvelope** | **string**| When set to **true**, resends the   envelope if the new recipient&#39;s routing order is before or the same as the envelope&#39;s next recipient. | [optional] 
 **templateRecipients** | [**TemplateRecipients**](TemplateRecipients.md)|  | [optional] 

### Return type

[**RecipientsUpdateSummary**](RecipientsUpdateSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

