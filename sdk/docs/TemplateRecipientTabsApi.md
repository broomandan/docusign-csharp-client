# IO.Swagger.Api.TemplateRecipientTabsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RecipientsDeleteTemplateRecipientTabs**](TemplateRecipientTabsApi.md#recipientsdeletetemplaterecipienttabs) | **DELETE** /v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/tabs | Deletes the tabs associated with a recipient in a template.
[**RecipientsGetTemplateRecipientTabs**](TemplateRecipientTabsApi.md#recipientsgettemplaterecipienttabs) | **GET** /v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/tabs | Gets the tabs information for a signer or sign-in-person recipient in a template.
[**RecipientsPostTemplateRecipientTabs**](TemplateRecipientTabsApi.md#recipientsposttemplaterecipienttabs) | **POST** /v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/tabs | Adds tabs for a recipient.
[**RecipientsPutTemplateRecipientTabs**](TemplateRecipientTabsApi.md#recipientsputtemplaterecipienttabs) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/tabs | Updates the tabs for a recipient.


<a name="recipientsdeletetemplaterecipienttabs"></a>
# **RecipientsDeleteTemplateRecipientTabs**
> TemplateRecipientTabs RecipientsDeleteTemplateRecipientTabs (string accountId, string recipientId, string templateId, TemplateTabs templateTabs = null)

Deletes the tabs associated with a recipient in a template.

Deletes one or more tabs associated with a recipient in a template.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsDeleteTemplateRecipientTabsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateRecipientTabsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var templateTabs = new TemplateTabs(); // TemplateTabs |  (optional) 

            try
            {
                // Deletes the tabs associated with a recipient in a template.
                TemplateRecipientTabs result = apiInstance.RecipientsDeleteTemplateRecipientTabs(accountId, recipientId, templateId, templateTabs);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateRecipientTabsApi.RecipientsDeleteTemplateRecipientTabs: " + e.Message );
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
 **templateTabs** | [**TemplateTabs**](TemplateTabs.md)|  | [optional] 

### Return type

[**TemplateRecipientTabs**](TemplateRecipientTabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsgettemplaterecipienttabs"></a>
# **RecipientsGetTemplateRecipientTabs**
> TemplateRecipientTabs RecipientsGetTemplateRecipientTabs (string accountId, string recipientId, string templateId, string includeAnchorTabLocations = null, string includeMetadata = null)

Gets the tabs information for a signer or sign-in-person recipient in a template.

Gets the tabs information for a signer or sign-in-person recipient in a template.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsGetTemplateRecipientTabsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateRecipientTabsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var includeAnchorTabLocations = includeAnchorTabLocations_example;  // string | When set to **true**, all tabs with anchor tab properties are included in the response.  (optional) 
            var includeMetadata = includeMetadata_example;  // string | Reserved for DocuSign.  (optional) 

            try
            {
                // Gets the tabs information for a signer or sign-in-person recipient in a template.
                TemplateRecipientTabs result = apiInstance.RecipientsGetTemplateRecipientTabs(accountId, recipientId, templateId, includeAnchorTabLocations, includeMetadata);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateRecipientTabsApi.RecipientsGetTemplateRecipientTabs: " + e.Message );
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
 **includeAnchorTabLocations** | **string**| When set to **true**, all tabs with anchor tab properties are included in the response.  | [optional] 
 **includeMetadata** | **string**| Reserved for DocuSign.  | [optional] 

### Return type

[**TemplateRecipientTabs**](TemplateRecipientTabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsposttemplaterecipienttabs"></a>
# **RecipientsPostTemplateRecipientTabs**
> TemplateRecipientTabs RecipientsPostTemplateRecipientTabs (string accountId, string recipientId, string templateId, TemplateTabs templateTabs = null)

Adds tabs for a recipient.

Adds one or more tabs for a recipient.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsPostTemplateRecipientTabsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateRecipientTabsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var templateTabs = new TemplateTabs(); // TemplateTabs |  (optional) 

            try
            {
                // Adds tabs for a recipient.
                TemplateRecipientTabs result = apiInstance.RecipientsPostTemplateRecipientTabs(accountId, recipientId, templateId, templateTabs);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateRecipientTabsApi.RecipientsPostTemplateRecipientTabs: " + e.Message );
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
 **templateTabs** | [**TemplateTabs**](TemplateTabs.md)|  | [optional] 

### Return type

[**TemplateRecipientTabs**](TemplateRecipientTabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsputtemplaterecipienttabs"></a>
# **RecipientsPutTemplateRecipientTabs**
> TemplateRecipientTabs RecipientsPutTemplateRecipientTabs (string accountId, string recipientId, string templateId, TemplateTabs templateTabs = null)

Updates the tabs for a recipient.

Updates one or more tabs for a recipient in a template.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsPutTemplateRecipientTabsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateRecipientTabsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var templateTabs = new TemplateTabs(); // TemplateTabs |  (optional) 

            try
            {
                // Updates the tabs for a recipient.
                TemplateRecipientTabs result = apiInstance.RecipientsPutTemplateRecipientTabs(accountId, recipientId, templateId, templateTabs);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateRecipientTabsApi.RecipientsPutTemplateRecipientTabs: " + e.Message );
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
 **templateTabs** | [**TemplateTabs**](TemplateTabs.md)|  | [optional] 

### Return type

[**TemplateRecipientTabs**](TemplateRecipientTabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

