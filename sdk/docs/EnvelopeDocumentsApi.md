# IO.Swagger.Api.EnvelopeDocumentsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocumentsDeleteDocuments**](EnvelopeDocumentsApi.md#documentsdeletedocuments) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents | Deletes documents from a draft envelope.
[**DocumentsGetDocument**](EnvelopeDocumentsApi.md#documentsgetdocument) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId} | Gets a document from an envelope.
[**DocumentsGetDocuments**](EnvelopeDocumentsApi.md#documentsgetdocuments) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents | Gets a list of envelope documents.
[**DocumentsPutDocument**](EnvelopeDocumentsApi.md#documentsputdocument) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId} | Adds a document to an existing draft envelope.
[**DocumentsPutDocuments**](EnvelopeDocumentsApi.md#documentsputdocuments) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents | Adds one or more documents to an existing envelope document.


<a name="documentsdeletedocuments"></a>
# **DocumentsDeleteDocuments**
> EnvelopeDocuments DocumentsDeleteDocuments (string accountId, string envelopeId, EnvelopeDefinition envelopeDefinition = null)

Deletes documents from a draft envelope.

Deletes one or more documents from an existing draft envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentsDeleteDocumentsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeDocumentsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var envelopeDefinition = new EnvelopeDefinition(); // EnvelopeDefinition |  (optional) 

            try
            {
                // Deletes documents from a draft envelope.
                EnvelopeDocuments result = apiInstance.DocumentsDeleteDocuments(accountId, envelopeId, envelopeDefinition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeDocumentsApi.DocumentsDeleteDocuments: " + e.Message );
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
 **envelopeDefinition** | [**EnvelopeDefinition**](EnvelopeDefinition.md)|  | [optional] 

### Return type

[**EnvelopeDocuments**](EnvelopeDocuments.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsgetdocument"></a>
# **DocumentsGetDocument**
> System.IO.Stream DocumentsGetDocument (string accountId, string documentId, string envelopeId, string certificate = null, string encoding = null, string encrypt = null, string language = null, string recipientId = null, string showChanges = null, string watermark = null)

Gets a document from an envelope.

Retrieves the specified document from the envelope. If the account has the Highlight Data Changes feature enabled, there is an option to request that any changes in the envelope be highlighted.  The `{documentID}` parameter takes two special values:  | Value      | Description | | :- --       | :- -- | | `combined` | Retrieve a PDF that contains the combined content of all documents and the certificate. | | `archive`  | Retrieve a ZIP archive that contains all of the PDF documents, the certificate, and any .WAV files used for voice authentication. | 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentsGetDocumentExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeDocumentsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var certificate = certificate_example;  // string | When set to **false**, the envelope signing certificate is removed from the download. (optional) 
            var encoding = encoding_example;  // string |  (optional) 
            var encrypt = encrypt_example;  // string | When set to **true**, the PDF bytes returned in the response are encrypted for all the key managers configured on your DocuSign account. The documents can be decrypted with the KeyManager Decrypt Document API. (optional) 
            var language = language_example;  // string | Specifies the language for the Certificate of Completion in the response. The supported languages, with the language value shown in parenthesis, are: Chinese Simplified (zh_CN), , Chinese Traditional (zh_TW), Dutch (nl), English US (en), French (fr), German (de), Italian (it), Japanese (ja), Korean (ko), Portuguese (pt), Portuguese (Brazil) (pt_BR), Russian (ru), Spanish (es).  (optional) 
            var recipientId = recipientId_example;  // string |  (optional) 
            var showChanges = showChanges_example;  // string | When set to **true**, any changed fields for the returned PDF are highlighted in yellow and optional signatures or initials outlined in red.  (optional) 
            var watermark = watermark_example;  // string | When set to **true**, the account has the watermark feature enabled, and the envelope is not complete, the watermark for the account is added to the PDF documents. This option can remove the watermark.  (optional) 

            try
            {
                // Gets a document from an envelope.
                System.IO.Stream result = apiInstance.DocumentsGetDocument(accountId, documentId, envelopeId, certificate, encoding, encrypt, language, recipientId, showChanges, watermark);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeDocumentsApi.DocumentsGetDocument: " + e.Message );
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
 **certificate** | **string**| When set to **false**, the envelope signing certificate is removed from the download. | [optional] 
 **encoding** | **string**|  | [optional] 
 **encrypt** | **string**| When set to **true**, the PDF bytes returned in the response are encrypted for all the key managers configured on your DocuSign account. The documents can be decrypted with the KeyManager Decrypt Document API. | [optional] 
 **language** | **string**| Specifies the language for the Certificate of Completion in the response. The supported languages, with the language value shown in parenthesis, are: Chinese Simplified (zh_CN), , Chinese Traditional (zh_TW), Dutch (nl), English US (en), French (fr), German (de), Italian (it), Japanese (ja), Korean (ko), Portuguese (pt), Portuguese (Brazil) (pt_BR), Russian (ru), Spanish (es).  | [optional] 
 **recipientId** | **string**|  | [optional] 
 **showChanges** | **string**| When set to **true**, any changed fields for the returned PDF are highlighted in yellow and optional signatures or initials outlined in red.  | [optional] 
 **watermark** | **string**| When set to **true**, the account has the watermark feature enabled, and the envelope is not complete, the watermark for the account is added to the PDF documents. This option can remove the watermark.  | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsgetdocuments"></a>
# **DocumentsGetDocuments**
> EnvelopeDocuments DocumentsGetDocuments (string accountId, string envelopeId, string includeMetadata = null)

Gets a list of envelope documents.

Retrieves a list of documents associated with the specified envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentsGetDocumentsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeDocumentsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var includeMetadata = includeMetadata_example;  // string | Reserved for DocuSign.  (optional) 

            try
            {
                // Gets a list of envelope documents.
                EnvelopeDocuments result = apiInstance.DocumentsGetDocuments(accountId, envelopeId, includeMetadata);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeDocumentsApi.DocumentsGetDocuments: " + e.Message );
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
 **includeMetadata** | **string**| Reserved for DocuSign.  | [optional] 

### Return type

[**EnvelopeDocuments**](EnvelopeDocuments.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsputdocument"></a>
# **DocumentsPutDocument**
> void DocumentsPutDocument (string accountId, string documentId, string envelopeId, string applyDocumentFields = null)

Adds a document to an existing draft envelope.

Adds a document to an existing draft envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentsPutDocumentExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeDocumentsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var applyDocumentFields = applyDocumentFields_example;  // string | When **true**, document fields can be added or modified while adding or modifying envelope documents.  (optional) 

            try
            {
                // Adds a document to an existing draft envelope.
                apiInstance.DocumentsPutDocument(accountId, documentId, envelopeId, applyDocumentFields);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeDocumentsApi.DocumentsPutDocument: " + e.Message );
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
 **applyDocumentFields** | **string**| When **true**, document fields can be added or modified while adding or modifying envelope documents.  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsputdocuments"></a>
# **DocumentsPutDocuments**
> EnvelopeDocuments DocumentsPutDocuments (string accountId, string envelopeId, string applyDocumentFields = null, EnvelopeDefinition envelopeDefinition = null)

Adds one or more documents to an existing envelope document.

Adds one or more documents to an existing envelope document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentsPutDocumentsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeDocumentsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var applyDocumentFields = applyDocumentFields_example;  // string | When **true**, document fields can be added or modified while adding or modifying envelope documents.  (optional) 
            var envelopeDefinition = new EnvelopeDefinition(); // EnvelopeDefinition |  (optional) 

            try
            {
                // Adds one or more documents to an existing envelope document.
                EnvelopeDocuments result = apiInstance.DocumentsPutDocuments(accountId, envelopeId, applyDocumentFields, envelopeDefinition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeDocumentsApi.DocumentsPutDocuments: " + e.Message );
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
 **applyDocumentFields** | **string**| When **true**, document fields can be added or modified while adding or modifying envelope documents.  | [optional] 
 **envelopeDefinition** | [**EnvelopeDefinition**](EnvelopeDefinition.md)|  | [optional] 

### Return type

[**EnvelopeDocuments**](EnvelopeDocuments.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

