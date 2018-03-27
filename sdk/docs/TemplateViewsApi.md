# IO.Swagger.Api.TemplateViewsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ViewsPostTemplateEditView**](TemplateViewsApi.md#viewsposttemplateeditview) | **POST** /v2/accounts/{accountId}/templates/{templateId}/views/edit | Provides a URL to start an edit view of the Template UI


<a name="viewsposttemplateeditview"></a>
# **ViewsPostTemplateEditView**
> TemplateViews ViewsPostTemplateEditView (string accountId, string templateId, ReturnUrlRequest returnUrlRequest = null)

Provides a URL to start an edit view of the Template UI



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ViewsPostTemplateEditViewExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateViewsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var returnUrlRequest = new ReturnUrlRequest(); // ReturnUrlRequest |  (optional) 

            try
            {
                // Provides a URL to start an edit view of the Template UI
                TemplateViews result = apiInstance.ViewsPostTemplateEditView(accountId, templateId, returnUrlRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateViewsApi.ViewsPostTemplateEditView: " + e.Message );
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
 **returnUrlRequest** | [**ReturnUrlRequest**](ReturnUrlRequest.md)|  | [optional] 

### Return type

[**TemplateViews**](TemplateViews.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

