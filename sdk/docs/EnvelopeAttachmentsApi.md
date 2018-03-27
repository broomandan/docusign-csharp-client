# IO.Swagger.Api.EnvelopeAttachmentsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AttachmentsDeleteAttachments**](EnvelopeAttachmentsApi.md#attachmentsdeleteattachments) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/attachments | Delete one or more attachments from a DRAFT envelope.
[**AttachmentsGetAttachment**](EnvelopeAttachmentsApi.md#attachmentsgetattachment) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/attachments/{attachmentId} | Retrieves an attachment from the envelope.
[**AttachmentsGetAttachments**](EnvelopeAttachmentsApi.md#attachmentsgetattachments) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/attachments | Returns a list of attachments associated with the specified envelope
[**AttachmentsPutAttachment**](EnvelopeAttachmentsApi.md#attachmentsputattachment) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/attachments/{attachmentId} | Add an attachment to a DRAFT or IN-PROCESS envelope.
[**AttachmentsPutAttachments**](EnvelopeAttachmentsApi.md#attachmentsputattachments) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/attachments | Add one or more attachments to a DRAFT or IN-PROCESS envelope.


<a name="attachmentsdeleteattachments"></a>
# **AttachmentsDeleteAttachments**
> EnvelopeAttachmentsResult AttachmentsDeleteAttachments (string accountId, string envelopeId, EnvelopeAttachmentsRequest envelopeAttachmentsRequest = null)

Delete one or more attachments from a DRAFT envelope.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AttachmentsDeleteAttachmentsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeAttachmentsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var envelopeAttachmentsRequest = new EnvelopeAttachmentsRequest(); // EnvelopeAttachmentsRequest |  (optional) 

            try
            {
                // Delete one or more attachments from a DRAFT envelope.
                EnvelopeAttachmentsResult result = apiInstance.AttachmentsDeleteAttachments(accountId, envelopeId, envelopeAttachmentsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeAttachmentsApi.AttachmentsDeleteAttachments: " + e.Message );
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
 **envelopeAttachmentsRequest** | [**EnvelopeAttachmentsRequest**](EnvelopeAttachmentsRequest.md)|  | [optional] 

### Return type

[**EnvelopeAttachmentsResult**](EnvelopeAttachmentsResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachmentsgetattachment"></a>
# **AttachmentsGetAttachment**
> void AttachmentsGetAttachment (string accountId, string attachmentId, string envelopeId)

Retrieves an attachment from the envelope.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AttachmentsGetAttachmentExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeAttachmentsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var attachmentId = attachmentId_example;  // string | 
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 

            try
            {
                // Retrieves an attachment from the envelope.
                apiInstance.AttachmentsGetAttachment(accountId, attachmentId, envelopeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeAttachmentsApi.AttachmentsGetAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **attachmentId** | **string**|  | 
 **envelopeId** | **string**| The envelope&#39;s GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachmentsgetattachments"></a>
# **AttachmentsGetAttachments**
> EnvelopeAttachmentsResult AttachmentsGetAttachments (string accountId, string envelopeId)

Returns a list of attachments associated with the specified envelope



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AttachmentsGetAttachmentsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeAttachmentsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 

            try
            {
                // Returns a list of attachments associated with the specified envelope
                EnvelopeAttachmentsResult result = apiInstance.AttachmentsGetAttachments(accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeAttachmentsApi.AttachmentsGetAttachments: " + e.Message );
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

### Return type

[**EnvelopeAttachmentsResult**](EnvelopeAttachmentsResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachmentsputattachment"></a>
# **AttachmentsPutAttachment**
> EnvelopeAttachmentsResult AttachmentsPutAttachment (string accountId, string attachmentId, string envelopeId, Attachment attachment = null)

Add an attachment to a DRAFT or IN-PROCESS envelope.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AttachmentsPutAttachmentExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeAttachmentsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var attachmentId = attachmentId_example;  // string | 
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var attachment = new Attachment(); // Attachment |  (optional) 

            try
            {
                // Add an attachment to a DRAFT or IN-PROCESS envelope.
                EnvelopeAttachmentsResult result = apiInstance.AttachmentsPutAttachment(accountId, attachmentId, envelopeId, attachment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeAttachmentsApi.AttachmentsPutAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **attachmentId** | **string**|  | 
 **envelopeId** | **string**| The envelope&#39;s GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec  | 
 **attachment** | [**Attachment**](Attachment.md)|  | [optional] 

### Return type

[**EnvelopeAttachmentsResult**](EnvelopeAttachmentsResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachmentsputattachments"></a>
# **AttachmentsPutAttachments**
> EnvelopeAttachmentsResult AttachmentsPutAttachments (string accountId, string envelopeId, EnvelopeAttachmentsRequest envelopeAttachmentsRequest = null)

Add one or more attachments to a DRAFT or IN-PROCESS envelope.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AttachmentsPutAttachmentsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeAttachmentsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var envelopeAttachmentsRequest = new EnvelopeAttachmentsRequest(); // EnvelopeAttachmentsRequest |  (optional) 

            try
            {
                // Add one or more attachments to a DRAFT or IN-PROCESS envelope.
                EnvelopeAttachmentsResult result = apiInstance.AttachmentsPutAttachments(accountId, envelopeId, envelopeAttachmentsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeAttachmentsApi.AttachmentsPutAttachments: " + e.Message );
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
 **envelopeAttachmentsRequest** | [**EnvelopeAttachmentsRequest**](EnvelopeAttachmentsRequest.md)|  | [optional] 

### Return type

[**EnvelopeAttachmentsResult**](EnvelopeAttachmentsResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

