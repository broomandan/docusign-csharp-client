# IO.Swagger.Api.EnvelopeTemplatesApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TemplatesDeleteDocumentTemplates**](EnvelopeTemplatesApi.md#templatesdeletedocumenttemplates) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/templates/{templateId} | Deletes a template from a document in an existing envelope.
[**TemplatesGetDocumentTemplates**](EnvelopeTemplatesApi.md#templatesgetdocumenttemplates) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/templates | Gets the templates associated with a document in an existing envelope.
[**TemplatesGetEnvelopeTemplates**](EnvelopeTemplatesApi.md#templatesgetenvelopetemplates) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/templates | Get List of Templates used in an Envelope
[**TemplatesPostDocumentTemplates**](EnvelopeTemplatesApi.md#templatespostdocumenttemplates) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/templates | Adds templates to a document in an  envelope.
[**TemplatesPostEnvelopeTemplates**](EnvelopeTemplatesApi.md#templatespostenvelopetemplates) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/templates | Adds templates to an envelope.


<a name="templatesdeletedocumenttemplates"></a>
# **TemplatesDeleteDocumentTemplates**
> void TemplatesDeleteDocumentTemplates (string accountId, string documentId, string envelopeId, string templateId)

Deletes a template from a document in an existing envelope.

Deletes the specified template from a document in an existing envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TemplatesDeleteDocumentTemplatesExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeTemplatesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Deletes a template from a document in an existing envelope.
                apiInstance.TemplatesDeleteDocumentTemplates(accountId, documentId, envelopeId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeTemplatesApi.TemplatesDeleteDocumentTemplates: " + e.Message );
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
 **templateId** | **string**| The ID of the template being accessed. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatesgetdocumenttemplates"></a>
# **TemplatesGetDocumentTemplates**
> EnvelopeTemplates TemplatesGetDocumentTemplates (string accountId, string documentId, string envelopeId, string include = null)

Gets the templates associated with a document in an existing envelope.

Retrieves the templates associated with a document in the specified envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TemplatesGetDocumentTemplatesExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeTemplatesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var include = include_example;  // string | A comma-separated list that limits the results. Valid values:  * applied * matched  (optional) 

            try
            {
                // Gets the templates associated with a document in an existing envelope.
                EnvelopeTemplates result = apiInstance.TemplatesGetDocumentTemplates(accountId, documentId, envelopeId, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeTemplatesApi.TemplatesGetDocumentTemplates: " + e.Message );
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
 **include** | **string**| A comma-separated list that limits the results. Valid values:  * applied * matched  | [optional] 

### Return type

[**EnvelopeTemplates**](EnvelopeTemplates.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatesgetenvelopetemplates"></a>
# **TemplatesGetEnvelopeTemplates**
> EnvelopeTemplates TemplatesGetEnvelopeTemplates (string accountId, string envelopeId, string include = null)

Get List of Templates used in an Envelope

This returns a list of the server-side templates, their name and ID, used in an envelope. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TemplatesGetEnvelopeTemplatesExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeTemplatesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var include = include_example;  // string | The possible values are:  matching_applied - This returns template matching information for the template. (optional) 

            try
            {
                // Get List of Templates used in an Envelope
                EnvelopeTemplates result = apiInstance.TemplatesGetEnvelopeTemplates(accountId, envelopeId, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeTemplatesApi.TemplatesGetEnvelopeTemplates: " + e.Message );
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
 **include** | **string**| The possible values are:  matching_applied - This returns template matching information for the template. | [optional] 

### Return type

[**EnvelopeTemplates**](EnvelopeTemplates.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatespostdocumenttemplates"></a>
# **TemplatesPostDocumentTemplates**
> DocumentTemplateList TemplatesPostDocumentTemplates (string accountId, string documentId, string envelopeId, DocumentTemplateList documentTemplateList = null)

Adds templates to a document in an  envelope.

Adds templates to a document in the specified envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TemplatesPostDocumentTemplatesExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeTemplatesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var documentTemplateList = new DocumentTemplateList(); // DocumentTemplateList |  (optional) 

            try
            {
                // Adds templates to a document in an  envelope.
                DocumentTemplateList result = apiInstance.TemplatesPostDocumentTemplates(accountId, documentId, envelopeId, documentTemplateList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeTemplatesApi.TemplatesPostDocumentTemplates: " + e.Message );
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
 **documentTemplateList** | [**DocumentTemplateList**](DocumentTemplateList.md)|  | [optional] 

### Return type

[**DocumentTemplateList**](DocumentTemplateList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatespostenvelopetemplates"></a>
# **TemplatesPostEnvelopeTemplates**
> DocumentTemplateList TemplatesPostEnvelopeTemplates (string accountId, string envelopeId, DocumentTemplateList documentTemplateList = null)

Adds templates to an envelope.

Adds templates to the specified envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TemplatesPostEnvelopeTemplatesExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeTemplatesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var documentTemplateList = new DocumentTemplateList(); // DocumentTemplateList |  (optional) 

            try
            {
                // Adds templates to an envelope.
                DocumentTemplateList result = apiInstance.TemplatesPostEnvelopeTemplates(accountId, envelopeId, documentTemplateList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeTemplatesApi.TemplatesPostEnvelopeTemplates: " + e.Message );
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
 **documentTemplateList** | [**DocumentTemplateList**](DocumentTemplateList.md)|  | [optional] 

### Return type

[**DocumentTemplateList**](DocumentTemplateList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

