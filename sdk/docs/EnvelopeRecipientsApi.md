# IO.Swagger.Api.EnvelopeRecipientsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RecipientsDeleteRecipient**](EnvelopeRecipientsApi.md#recipientsdeleterecipient) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId} | Deletes a recipient from an envelope.
[**RecipientsDeleteRecipients**](EnvelopeRecipientsApi.md#recipientsdeleterecipients) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients | Deletes recipients from an envelope.
[**RecipientsGetRecipients**](EnvelopeRecipientsApi.md#recipientsgetrecipients) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients | Gets the status of recipients for an envelope.
[**RecipientsPostRecipients**](EnvelopeRecipientsApi.md#recipientspostrecipients) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients | Adds one or more recipients to an envelope.
[**RecipientsPutRecipients**](EnvelopeRecipientsApi.md#recipientsputrecipients) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients | Updates recipients in a draft envelope or corrects recipient information for an in process envelope.


<a name="recipientsdeleterecipient"></a>
# **RecipientsDeleteRecipient**
> EnvelopeRecipients RecipientsDeleteRecipient (string accountId, string envelopeId, string recipientId)

Deletes a recipient from an envelope.

Deletes a recipient from a `draft` or `sent` envelope.  If the envelope is \"In Process\" (has been sent and is not completed or voided), recipients that have completed their actions cannot be deleted.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsDeleteRecipientExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeRecipientsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.

            try
            {
                // Deletes a recipient from an envelope.
                EnvelopeRecipients result = apiInstance.RecipientsDeleteRecipient(accountId, envelopeId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeRecipientsApi.RecipientsDeleteRecipient: " + e.Message );
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
 **recipientId** | **string**| The &#x60;recipientId&#x60; used when the envelope or template was created. | 

### Return type

[**EnvelopeRecipients**](EnvelopeRecipients.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsdeleterecipients"></a>
# **RecipientsDeleteRecipients**
> EnvelopeRecipients RecipientsDeleteRecipients (string accountId, string envelopeId, EnvelopeRecipients envelopeRecipients = null)

Deletes recipients from an envelope.

Deletes one or more recipients from a draft or sent envelope. Recipients to be deleted are listed in the request, with the `recipientId` being used as the key for deleting recipients.  If the envelope is `In Process`, meaning that it has been sent and has not  been completed or voided, recipients that have completed their actions cannot be deleted.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsDeleteRecipientsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeRecipientsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var envelopeRecipients = new EnvelopeRecipients(); // EnvelopeRecipients |  (optional) 

            try
            {
                // Deletes recipients from an envelope.
                EnvelopeRecipients result = apiInstance.RecipientsDeleteRecipients(accountId, envelopeId, envelopeRecipients);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeRecipientsApi.RecipientsDeleteRecipients: " + e.Message );
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
 **envelopeRecipients** | [**EnvelopeRecipients**](EnvelopeRecipients.md)|  | [optional] 

### Return type

[**EnvelopeRecipients**](EnvelopeRecipients.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsgetrecipients"></a>
# **RecipientsGetRecipients**
> EnvelopeRecipients RecipientsGetRecipients (string accountId, string envelopeId, string includeAnchorTabLocations = null, string includeExtended = null, string includeMetadata = null, string includeTabs = null)

Gets the status of recipients for an envelope.

Retrieves the status of all recipients in a single envelope and identifies the current recipient in the routing list.   The `currentRoutingOrder` property of the response contains the `routingOrder` value of the current recipient indicating that the envelope has been sent to the recipient, but the recipient has not completed their actions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsGetRecipientsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeRecipientsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var includeAnchorTabLocations = includeAnchorTabLocations_example;  // string |  When set to **true** and `include_tabs` is set to **true**, all tabs with anchor tab properties are included in the response.  (optional) 
            var includeExtended = includeExtended_example;  // string |  When set to **true**, the extended properties are included in the response.  (optional) 
            var includeMetadata = includeMetadata_example;  // string | Reserved for DocuSign.  (optional) 
            var includeTabs = includeTabs_example;  // string | When set to **true**, the tab information associated with the recipient is included in the response. (optional) 

            try
            {
                // Gets the status of recipients for an envelope.
                EnvelopeRecipients result = apiInstance.RecipientsGetRecipients(accountId, envelopeId, includeAnchorTabLocations, includeExtended, includeMetadata, includeTabs);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeRecipientsApi.RecipientsGetRecipients: " + e.Message );
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
 **includeAnchorTabLocations** | **string**|  When set to **true** and &#x60;include_tabs&#x60; is set to **true**, all tabs with anchor tab properties are included in the response.  | [optional] 
 **includeExtended** | **string**|  When set to **true**, the extended properties are included in the response.  | [optional] 
 **includeMetadata** | **string**| Reserved for DocuSign.  | [optional] 
 **includeTabs** | **string**| When set to **true**, the tab information associated with the recipient is included in the response. | [optional] 

### Return type

[**EnvelopeRecipients**](EnvelopeRecipients.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientspostrecipients"></a>
# **RecipientsPostRecipients**
> EnvelopeRecipients RecipientsPostRecipients (string accountId, string envelopeId, string resendEnvelope = null, EnvelopeRecipients envelopeRecipients = null)

Adds one or more recipients to an envelope.

Adds one or more recipients to an envelope.  For an in process envelope, one that has been sent and has not been completed or voided, an email is sent to a new recipient when they are reached in the routing order. If the new recipient's routing order is before or the same as the envelope's next recipient, an email is only sent if the optional `resend_envelope` query string is set to **true**.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsPostRecipientsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeRecipientsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var resendEnvelope = resendEnvelope_example;  // string | When set to **true**, resends the   envelope if the new recipient's routing order is before or the same as the envelope's next recipient. (optional) 
            var envelopeRecipients = new EnvelopeRecipients(); // EnvelopeRecipients |  (optional) 

            try
            {
                // Adds one or more recipients to an envelope.
                EnvelopeRecipients result = apiInstance.RecipientsPostRecipients(accountId, envelopeId, resendEnvelope, envelopeRecipients);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeRecipientsApi.RecipientsPostRecipients: " + e.Message );
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
 **resendEnvelope** | **string**| When set to **true**, resends the   envelope if the new recipient&#39;s routing order is before or the same as the envelope&#39;s next recipient. | [optional] 
 **envelopeRecipients** | [**EnvelopeRecipients**](EnvelopeRecipients.md)|  | [optional] 

### Return type

[**EnvelopeRecipients**](EnvelopeRecipients.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsputrecipients"></a>
# **RecipientsPutRecipients**
> RecipientsUpdateSummary RecipientsPutRecipients (string accountId, string envelopeId, string resendEnvelope = null, EnvelopeRecipients envelopeRecipients = null)

Updates recipients in a draft envelope or corrects recipient information for an in process envelope.

Updates recipients in a draft envelope or corrects recipient information for an in process envelope.   For draft envelopes, you can edit the following properties: `email`, `userName`, `routingOrder`, `faxNumber`, `deliveryMethod`, `accessCode`, and `requireIdLookup`.  Once an envelope has been sent, you can only edit: `email`, `userName`, `signerName`, `routingOrder`, `faxNumber`, and `deliveryMethod`. You can also select to resend an envelope by using the `resend_envelope` option.  If you send information for a recipient that does not already exist in a draft envelope, the recipient is added to the envelope (similar to the POST).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsPutRecipientsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeRecipientsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var resendEnvelope = resendEnvelope_example;  // string | When set to **true**, resends the   envelope if the new recipient's routing order is before or the same as the envelope's next recipient. (optional) 
            var envelopeRecipients = new EnvelopeRecipients(); // EnvelopeRecipients |  (optional) 

            try
            {
                // Updates recipients in a draft envelope or corrects recipient information for an in process envelope.
                RecipientsUpdateSummary result = apiInstance.RecipientsPutRecipients(accountId, envelopeId, resendEnvelope, envelopeRecipients);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeRecipientsApi.RecipientsPutRecipients: " + e.Message );
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
 **resendEnvelope** | **string**| When set to **true**, resends the   envelope if the new recipient&#39;s routing order is before or the same as the envelope&#39;s next recipient. | [optional] 
 **envelopeRecipients** | [**EnvelopeRecipients**](EnvelopeRecipients.md)|  | [optional] 

### Return type

[**RecipientsUpdateSummary**](RecipientsUpdateSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

