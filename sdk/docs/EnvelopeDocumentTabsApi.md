# IO.Swagger.Api.EnvelopeDocumentTabsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TabsGetDocumentTabs**](EnvelopeDocumentTabsApi.md#tabsgetdocumenttabs) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/tabs | Returns tabs on the document.
[**TabsGetPageTabs**](EnvelopeDocumentTabsApi.md#tabsgetpagetabs) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/pages/{pageNumber}/tabs | Returns tabs on the specified page.


<a name="tabsgetdocumenttabs"></a>
# **TabsGetDocumentTabs**
> EnvelopeDocumentTabs TabsGetDocumentTabs (string accountId, string documentId, string envelopeId, string pageNumbers = null)

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
    public class TabsGetDocumentTabsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeDocumentTabsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var pageNumbers = pageNumbers_example;  // string |  (optional) 

            try
            {
                // Returns tabs on the document.
                EnvelopeDocumentTabs result = apiInstance.TabsGetDocumentTabs(accountId, documentId, envelopeId, pageNumbers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeDocumentTabsApi.TabsGetDocumentTabs: " + e.Message );
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
 **envelopeId** | **string**| The envelope&#39;s GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec  | 
 **pageNumbers** | **string**|  | [optional] 

### Return type

[**EnvelopeDocumentTabs**](EnvelopeDocumentTabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tabsgetpagetabs"></a>
# **TabsGetPageTabs**
> EnvelopeDocumentTabs TabsGetPageTabs (string accountId, string documentId, string envelopeId, string pageNumber)

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
    public class TabsGetPageTabsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeDocumentTabsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var pageNumber = pageNumber_example;  // string | The page number being accessed.

            try
            {
                // Returns tabs on the specified page.
                EnvelopeDocumentTabs result = apiInstance.TabsGetPageTabs(accountId, documentId, envelopeId, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeDocumentTabsApi.TabsGetPageTabs: " + e.Message );
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
 **envelopeId** | **string**| The envelope&#39;s GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec  | 
 **pageNumber** | **string**| The page number being accessed. | 

### Return type

[**EnvelopeDocumentTabs**](EnvelopeDocumentTabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

