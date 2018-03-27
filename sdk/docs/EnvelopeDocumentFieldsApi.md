# IO.Swagger.Api.EnvelopeDocumentFieldsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocumentFieldsDeleteDocumentFields**](EnvelopeDocumentFieldsApi.md#documentfieldsdeletedocumentfields) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/fields | Deletes custom document fields from an existing envelope document.
[**DocumentFieldsGetDocumentFields**](EnvelopeDocumentFieldsApi.md#documentfieldsgetdocumentfields) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/fields | Gets the custom document fields from an  existing envelope document.
[**DocumentFieldsPostDocumentFields**](EnvelopeDocumentFieldsApi.md#documentfieldspostdocumentfields) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/fields | Creates custom document fields in an existing envelope document.
[**DocumentFieldsPutDocumentFields**](EnvelopeDocumentFieldsApi.md#documentfieldsputdocumentfields) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/fields | Updates existing custom document fields in an existing envelope document.


<a name="documentfieldsdeletedocumentfields"></a>
# **DocumentFieldsDeleteDocumentFields**
> EnvelopeDocumentFields DocumentFieldsDeleteDocumentFields (string accountId, string documentId, string envelopeId, EnvelopeDocumentFields envelopeDocumentFields = null)

Deletes custom document fields from an existing envelope document.

Deletes custom document fields from an existing envelope document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentFieldsDeleteDocumentFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeDocumentFieldsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var envelopeDocumentFields = new EnvelopeDocumentFields(); // EnvelopeDocumentFields |  (optional) 

            try
            {
                // Deletes custom document fields from an existing envelope document.
                EnvelopeDocumentFields result = apiInstance.DocumentFieldsDeleteDocumentFields(accountId, documentId, envelopeId, envelopeDocumentFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeDocumentFieldsApi.DocumentFieldsDeleteDocumentFields: " + e.Message );
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
 **envelopeDocumentFields** | [**EnvelopeDocumentFields**](EnvelopeDocumentFields.md)|  | [optional] 

### Return type

[**EnvelopeDocumentFields**](EnvelopeDocumentFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentfieldsgetdocumentfields"></a>
# **DocumentFieldsGetDocumentFields**
> EnvelopeDocumentFields DocumentFieldsGetDocumentFields (string accountId, string documentId, string envelopeId)

Gets the custom document fields from an  existing envelope document.

Retrieves the custom document field information from an existing envelope document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentFieldsGetDocumentFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeDocumentFieldsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 

            try
            {
                // Gets the custom document fields from an  existing envelope document.
                EnvelopeDocumentFields result = apiInstance.DocumentFieldsGetDocumentFields(accountId, documentId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeDocumentFieldsApi.DocumentFieldsGetDocumentFields: " + e.Message );
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

### Return type

[**EnvelopeDocumentFields**](EnvelopeDocumentFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentfieldspostdocumentfields"></a>
# **DocumentFieldsPostDocumentFields**
> EnvelopeDocumentFields DocumentFieldsPostDocumentFields (string accountId, string documentId, string envelopeId, EnvelopeDocumentFields envelopeDocumentFields = null)

Creates custom document fields in an existing envelope document.

Creates custom document fields in an existing envelope document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentFieldsPostDocumentFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeDocumentFieldsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var envelopeDocumentFields = new EnvelopeDocumentFields(); // EnvelopeDocumentFields |  (optional) 

            try
            {
                // Creates custom document fields in an existing envelope document.
                EnvelopeDocumentFields result = apiInstance.DocumentFieldsPostDocumentFields(accountId, documentId, envelopeId, envelopeDocumentFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeDocumentFieldsApi.DocumentFieldsPostDocumentFields: " + e.Message );
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
 **envelopeDocumentFields** | [**EnvelopeDocumentFields**](EnvelopeDocumentFields.md)|  | [optional] 

### Return type

[**EnvelopeDocumentFields**](EnvelopeDocumentFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentfieldsputdocumentfields"></a>
# **DocumentFieldsPutDocumentFields**
> EnvelopeDocumentFields DocumentFieldsPutDocumentFields (string accountId, string documentId, string envelopeId, EnvelopeDocumentFields envelopeDocumentFields = null)

Updates existing custom document fields in an existing envelope document.

Updates existing custom document fields in an existing envelope document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentFieldsPutDocumentFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeDocumentFieldsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var envelopeDocumentFields = new EnvelopeDocumentFields(); // EnvelopeDocumentFields |  (optional) 

            try
            {
                // Updates existing custom document fields in an existing envelope document.
                EnvelopeDocumentFields result = apiInstance.DocumentFieldsPutDocumentFields(accountId, documentId, envelopeId, envelopeDocumentFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeDocumentFieldsApi.DocumentFieldsPutDocumentFields: " + e.Message );
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
 **envelopeDocumentFields** | [**EnvelopeDocumentFields**](EnvelopeDocumentFields.md)|  | [optional] 

### Return type

[**EnvelopeDocumentFields**](EnvelopeDocumentFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

