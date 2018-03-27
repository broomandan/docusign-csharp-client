# IO.Swagger.Api.TemplateDocumentTabsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TabsGetTemplateDocumentTabs**](TemplateDocumentTabsApi.md#tabsgettemplatedocumenttabs) | **GET** /v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/tabs | Returns tabs on the document.
[**TabsGetTemplatePageTabs**](TemplateDocumentTabsApi.md#tabsgettemplatepagetabs) | **GET** /v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/pages/{pageNumber}/tabs | Returns tabs on the specified page.


<a name="tabsgettemplatedocumenttabs"></a>
# **TabsGetTemplateDocumentTabs**
> TemplateDocumentTabs TabsGetTemplateDocumentTabs (string accountId, string documentId, string templateId, string pageNumbers = null)

Returns tabs on the document.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TabsGetTemplateDocumentTabsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateDocumentTabsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var pageNumbers = pageNumbers_example;  // string |  (optional) 

            try
            {
                // Returns tabs on the document.
                TemplateDocumentTabs result = apiInstance.TabsGetTemplateDocumentTabs(accountId, documentId, templateId, pageNumbers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateDocumentTabsApi.TabsGetTemplateDocumentTabs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **documentId** | **string**| The ID of the document being accessed. | 
 **templateId** | **string**| The ID of the template being accessed. | 
 **pageNumbers** | **string**|  | [optional] 

### Return type

[**TemplateDocumentTabs**](TemplateDocumentTabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tabsgettemplatepagetabs"></a>
# **TabsGetTemplatePageTabs**
> TemplateDocumentTabs TabsGetTemplatePageTabs (string accountId, string documentId, string pageNumber, string templateId)

Returns tabs on the specified page.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TabsGetTemplatePageTabsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateDocumentTabsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var pageNumber = pageNumber_example;  // string | The page number being accessed.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Returns tabs on the specified page.
                TemplateDocumentTabs result = apiInstance.TabsGetTemplatePageTabs(accountId, documentId, pageNumber, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateDocumentTabsApi.TabsGetTemplatePageTabs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **documentId** | **string**| The ID of the document being accessed. | 
 **pageNumber** | **string**| The page number being accessed. | 
 **templateId** | **string**| The ID of the template being accessed. | 

### Return type

[**TemplateDocumentTabs**](TemplateDocumentTabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

