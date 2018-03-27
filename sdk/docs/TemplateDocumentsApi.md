# IO.Swagger.Api.TemplateDocumentsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocumentsDeleteTemplateDocuments**](TemplateDocumentsApi.md#documentsdeletetemplatedocuments) | **DELETE** /v2/accounts/{accountId}/templates/{templateId}/documents | Deletes documents from a template.
[**DocumentsGetTemplateDocument**](TemplateDocumentsApi.md#documentsgettemplatedocument) | **GET** /v2/accounts/{accountId}/templates/{templateId}/documents/{documentId} | Gets PDF documents from a template.
[**DocumentsGetTemplateDocuments**](TemplateDocumentsApi.md#documentsgettemplatedocuments) | **GET** /v2/accounts/{accountId}/templates/{templateId}/documents | Gets a list of documents associated with a template.
[**DocumentsPutTemplateDocument**](TemplateDocumentsApi.md#documentsputtemplatedocument) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/documents/{documentId} | Adds a document to a template document.
[**DocumentsPutTemplateDocuments**](TemplateDocumentsApi.md#documentsputtemplatedocuments) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/documents | Adds documents to a template document.


<a name="documentsdeletetemplatedocuments"></a>
# **DocumentsDeleteTemplateDocuments**
> TemplateDocuments DocumentsDeleteTemplateDocuments (string accountId, string templateId, EnvelopeDefinition envelopeDefinition = null)

Deletes documents from a template.

Deletes one or more documents from an existing template.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentsDeleteTemplateDocumentsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateDocumentsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var envelopeDefinition = new EnvelopeDefinition(); // EnvelopeDefinition |  (optional) 

            try
            {
                // Deletes documents from a template.
                TemplateDocuments result = apiInstance.DocumentsDeleteTemplateDocuments(accountId, templateId, envelopeDefinition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateDocumentsApi.DocumentsDeleteTemplateDocuments: " + e.Message );
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
 **envelopeDefinition** | [**EnvelopeDefinition**](EnvelopeDefinition.md)|  | [optional] 

### Return type

[**TemplateDocuments**](TemplateDocuments.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsgettemplatedocument"></a>
# **DocumentsGetTemplateDocument**
> System.IO.Stream DocumentsGetTemplateDocument (string accountId, string documentId, string templateId, string encrypt = null, string showChanges = null)

Gets PDF documents from a template.

Retrieves one or more PDF documents from the specified template.  You can specify the ID of the document to retrieve or can specify `combined` to retrieve all documents in the template as one pdf.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentsGetTemplateDocumentExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateDocumentsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var encrypt = encrypt_example;  // string |  (optional) 
            var showChanges = showChanges_example;  // string |  (optional) 

            try
            {
                // Gets PDF documents from a template.
                System.IO.Stream result = apiInstance.DocumentsGetTemplateDocument(accountId, documentId, templateId, encrypt, showChanges);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateDocumentsApi.DocumentsGetTemplateDocument: " + e.Message );
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
 **encrypt** | **string**|  | [optional] 
 **showChanges** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsgettemplatedocuments"></a>
# **DocumentsGetTemplateDocuments**
> TemplateDocuments DocumentsGetTemplateDocuments (string accountId, string templateId)

Gets a list of documents associated with a template.

Retrieves a list of documents associated with the specified template.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentsGetTemplateDocumentsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateDocumentsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Gets a list of documents associated with a template.
                TemplateDocuments result = apiInstance.DocumentsGetTemplateDocuments(accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateDocumentsApi.DocumentsGetTemplateDocuments: " + e.Message );
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

### Return type

[**TemplateDocuments**](TemplateDocuments.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsputtemplatedocument"></a>
# **DocumentsPutTemplateDocument**
> EnvelopeDocument DocumentsPutTemplateDocument (string accountId, string documentId, string templateId, string applyDocumentFields = null, string isEnvelopeDefinition = null, EnvelopeDefinition envelopeDefinition = null)

Adds a document to a template document.

Adds the specified document to an existing template document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentsPutTemplateDocumentExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateDocumentsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var applyDocumentFields = applyDocumentFields_example;  // string | When **true**, document fields can be added or modified while adding or modifying envelope documents.  (optional) 
            var isEnvelopeDefinition = isEnvelopeDefinition_example;  // string |  (optional) 
            var envelopeDefinition = new EnvelopeDefinition(); // EnvelopeDefinition |  (optional) 

            try
            {
                // Adds a document to a template document.
                EnvelopeDocument result = apiInstance.DocumentsPutTemplateDocument(accountId, documentId, templateId, applyDocumentFields, isEnvelopeDefinition, envelopeDefinition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateDocumentsApi.DocumentsPutTemplateDocument: " + e.Message );
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
 **applyDocumentFields** | **string**| When **true**, document fields can be added or modified while adding or modifying envelope documents.  | [optional] 
 **isEnvelopeDefinition** | **string**|  | [optional] 
 **envelopeDefinition** | [**EnvelopeDefinition**](EnvelopeDefinition.md)|  | [optional] 

### Return type

[**EnvelopeDocument**](EnvelopeDocument.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsputtemplatedocuments"></a>
# **DocumentsPutTemplateDocuments**
> TemplateDocuments DocumentsPutTemplateDocuments (string accountId, string templateId, string applyDocumentFields = null, EnvelopeDefinition envelopeDefinition = null)

Adds documents to a template document.

Adds one or more documents to an existing template document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentsPutTemplateDocumentsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateDocumentsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var applyDocumentFields = applyDocumentFields_example;  // string | When **true**, document fields can be added or modified while adding or modifying envelope documents.  (optional) 
            var envelopeDefinition = new EnvelopeDefinition(); // EnvelopeDefinition |  (optional) 

            try
            {
                // Adds documents to a template document.
                TemplateDocuments result = apiInstance.DocumentsPutTemplateDocuments(accountId, templateId, applyDocumentFields, envelopeDefinition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateDocumentsApi.DocumentsPutTemplateDocuments: " + e.Message );
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
 **applyDocumentFields** | **string**| When **true**, document fields can be added or modified while adding or modifying envelope documents.  | [optional] 
 **envelopeDefinition** | [**EnvelopeDefinition**](EnvelopeDefinition.md)|  | [optional] 

### Return type

[**TemplateDocuments**](TemplateDocuments.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

