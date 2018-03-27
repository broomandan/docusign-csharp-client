# IO.Swagger.Api.TemplateDocumentFieldsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocumentFieldsDeleteTemplateDocumentFields**](TemplateDocumentFieldsApi.md#documentfieldsdeletetemplatedocumentfields) | **DELETE** /v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/fields | Deletes custom document fields from an existing template document.
[**DocumentFieldsGetTemplateDocumentFields**](TemplateDocumentFieldsApi.md#documentfieldsgettemplatedocumentfields) | **GET** /v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/fields | Gets the custom document fields for a an existing template document.
[**DocumentFieldsPostTemplateDocumentFields**](TemplateDocumentFieldsApi.md#documentfieldsposttemplatedocumentfields) | **POST** /v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/fields | Creates custom document fields in an existing template document.
[**DocumentFieldsPutTemplateDocumentFields**](TemplateDocumentFieldsApi.md#documentfieldsputtemplatedocumentfields) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/fields | Updates existing custom document fields in an existing template document.


<a name="documentfieldsdeletetemplatedocumentfields"></a>
# **DocumentFieldsDeleteTemplateDocumentFields**
> TemplateDocumentFields DocumentFieldsDeleteTemplateDocumentFields (string accountId, string documentId, string templateId, TemplateDocumentFields templateDocumentFields = null)

Deletes custom document fields from an existing template document.

Deletes custom document fields from an existing template document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentFieldsDeleteTemplateDocumentFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateDocumentFieldsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var templateDocumentFields = new TemplateDocumentFields(); // TemplateDocumentFields |  (optional) 

            try
            {
                // Deletes custom document fields from an existing template document.
                TemplateDocumentFields result = apiInstance.DocumentFieldsDeleteTemplateDocumentFields(accountId, documentId, templateId, templateDocumentFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateDocumentFieldsApi.DocumentFieldsDeleteTemplateDocumentFields: " + e.Message );
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
 **templateDocumentFields** | [**TemplateDocumentFields**](TemplateDocumentFields.md)|  | [optional] 

### Return type

[**TemplateDocumentFields**](TemplateDocumentFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentfieldsgettemplatedocumentfields"></a>
# **DocumentFieldsGetTemplateDocumentFields**
> TemplateDocumentFields DocumentFieldsGetTemplateDocumentFields (string accountId, string documentId, string templateId)

Gets the custom document fields for a an existing template document.

Retrieves the custom document fields for an existing template document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentFieldsGetTemplateDocumentFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateDocumentFieldsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Gets the custom document fields for a an existing template document.
                TemplateDocumentFields result = apiInstance.DocumentFieldsGetTemplateDocumentFields(accountId, documentId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateDocumentFieldsApi.DocumentFieldsGetTemplateDocumentFields: " + e.Message );
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

### Return type

[**TemplateDocumentFields**](TemplateDocumentFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentfieldsposttemplatedocumentfields"></a>
# **DocumentFieldsPostTemplateDocumentFields**
> TemplateDocumentFields DocumentFieldsPostTemplateDocumentFields (string accountId, string documentId, string templateId, TemplateDocumentFields templateDocumentFields = null)

Creates custom document fields in an existing template document.

Creates custom document fields in an existing template document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentFieldsPostTemplateDocumentFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateDocumentFieldsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var templateDocumentFields = new TemplateDocumentFields(); // TemplateDocumentFields |  (optional) 

            try
            {
                // Creates custom document fields in an existing template document.
                TemplateDocumentFields result = apiInstance.DocumentFieldsPostTemplateDocumentFields(accountId, documentId, templateId, templateDocumentFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateDocumentFieldsApi.DocumentFieldsPostTemplateDocumentFields: " + e.Message );
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
 **templateDocumentFields** | [**TemplateDocumentFields**](TemplateDocumentFields.md)|  | [optional] 

### Return type

[**TemplateDocumentFields**](TemplateDocumentFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentfieldsputtemplatedocumentfields"></a>
# **DocumentFieldsPutTemplateDocumentFields**
> TemplateDocumentFields DocumentFieldsPutTemplateDocumentFields (string accountId, string documentId, string templateId, TemplateDocumentFields templateDocumentFields = null)

Updates existing custom document fields in an existing template document.

Updates existing custom document fields in an existing template document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentFieldsPutTemplateDocumentFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateDocumentFieldsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var templateDocumentFields = new TemplateDocumentFields(); // TemplateDocumentFields |  (optional) 

            try
            {
                // Updates existing custom document fields in an existing template document.
                TemplateDocumentFields result = apiInstance.DocumentFieldsPutTemplateDocumentFields(accountId, documentId, templateId, templateDocumentFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateDocumentFieldsApi.DocumentFieldsPutTemplateDocumentFields: " + e.Message );
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
 **templateDocumentFields** | [**TemplateDocumentFields**](TemplateDocumentFields.md)|  | [optional] 

### Return type

[**TemplateDocumentFields**](TemplateDocumentFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

