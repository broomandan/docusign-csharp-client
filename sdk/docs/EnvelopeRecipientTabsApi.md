# IO.Swagger.Api.EnvelopeRecipientTabsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RecipientsDeleteRecipientTabs**](EnvelopeRecipientTabsApi.md#recipientsdeleterecipienttabs) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/tabs | Deletes the tabs associated with a recipient.
[**RecipientsGetRecipientTabs**](EnvelopeRecipientTabsApi.md#recipientsgetrecipienttabs) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/tabs | Gets the tabs information for a signer or sign-in-person recipient in an envelope.
[**RecipientsPostRecipientTabs**](EnvelopeRecipientTabsApi.md#recipientspostrecipienttabs) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/tabs | Adds tabs for a recipient.
[**RecipientsPutRecipientTabs**](EnvelopeRecipientTabsApi.md#recipientsputrecipienttabs) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/tabs | Updates the tabs for a recipient.  


<a name="recipientsdeleterecipienttabs"></a>
# **RecipientsDeleteRecipientTabs**
> EnvelopeRecipientTabs RecipientsDeleteRecipientTabs (string accountId, string envelopeId, string recipientId, EnvelopeRecipientTabs envelopeRecipientTabs = null)

Deletes the tabs associated with a recipient.

Deletes one or more tabs associated with a recipient in a draft envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsDeleteRecipientTabsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeRecipientTabsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.
            var envelopeRecipientTabs = new EnvelopeRecipientTabs(); // EnvelopeRecipientTabs |  (optional) 

            try
            {
                // Deletes the tabs associated with a recipient.
                EnvelopeRecipientTabs result = apiInstance.RecipientsDeleteRecipientTabs(accountId, envelopeId, recipientId, envelopeRecipientTabs);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeRecipientTabsApi.RecipientsDeleteRecipientTabs: " + e.Message );
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
 **envelopeRecipientTabs** | [**EnvelopeRecipientTabs**](EnvelopeRecipientTabs.md)|  | [optional] 

### Return type

[**EnvelopeRecipientTabs**](EnvelopeRecipientTabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsgetrecipienttabs"></a>
# **RecipientsGetRecipientTabs**
> EnvelopeRecipientTabs RecipientsGetRecipientTabs (string accountId, string envelopeId, string recipientId, string includeAnchorTabLocations = null, string includeMetadata = null)

Gets the tabs information for a signer or sign-in-person recipient in an envelope.

Retrieves information about the tabs associated with a recipient in a draft envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsGetRecipientTabsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeRecipientTabsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.
            var includeAnchorTabLocations = includeAnchorTabLocations_example;  // string | When set to **true**, all tabs with anchor tab properties are included in the response.  (optional) 
            var includeMetadata = includeMetadata_example;  // string | Reserved for DocuSign.  (optional) 

            try
            {
                // Gets the tabs information for a signer or sign-in-person recipient in an envelope.
                EnvelopeRecipientTabs result = apiInstance.RecipientsGetRecipientTabs(accountId, envelopeId, recipientId, includeAnchorTabLocations, includeMetadata);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeRecipientTabsApi.RecipientsGetRecipientTabs: " + e.Message );
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
 **includeAnchorTabLocations** | **string**| When set to **true**, all tabs with anchor tab properties are included in the response.  | [optional] 
 **includeMetadata** | **string**| Reserved for DocuSign.  | [optional] 

### Return type

[**EnvelopeRecipientTabs**](EnvelopeRecipientTabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientspostrecipienttabs"></a>
# **RecipientsPostRecipientTabs**
> EnvelopeRecipientTabs RecipientsPostRecipientTabs (string accountId, string envelopeId, string recipientId, EnvelopeRecipientTabs envelopeRecipientTabs = null)

Adds tabs for a recipient.

Adds one or more tabs for a recipient.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsPostRecipientTabsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeRecipientTabsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.
            var envelopeRecipientTabs = new EnvelopeRecipientTabs(); // EnvelopeRecipientTabs |  (optional) 

            try
            {
                // Adds tabs for a recipient.
                EnvelopeRecipientTabs result = apiInstance.RecipientsPostRecipientTabs(accountId, envelopeId, recipientId, envelopeRecipientTabs);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeRecipientTabsApi.RecipientsPostRecipientTabs: " + e.Message );
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
 **envelopeRecipientTabs** | [**EnvelopeRecipientTabs**](EnvelopeRecipientTabs.md)|  | [optional] 

### Return type

[**EnvelopeRecipientTabs**](EnvelopeRecipientTabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsputrecipienttabs"></a>
# **RecipientsPutRecipientTabs**
> EnvelopeRecipientTabs RecipientsPutRecipientTabs (string accountId, string envelopeId, string recipientId, EnvelopeRecipientTabs envelopeRecipientTabs = null)

Updates the tabs for a recipient.  

Updates one or more tabs for a recipient in a draft envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsPutRecipientTabsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeRecipientTabsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.
            var envelopeRecipientTabs = new EnvelopeRecipientTabs(); // EnvelopeRecipientTabs |  (optional) 

            try
            {
                // Updates the tabs for a recipient.  
                EnvelopeRecipientTabs result = apiInstance.RecipientsPutRecipientTabs(accountId, envelopeId, recipientId, envelopeRecipientTabs);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeRecipientTabsApi.RecipientsPutRecipientTabs: " + e.Message );
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
 **envelopeRecipientTabs** | [**EnvelopeRecipientTabs**](EnvelopeRecipientTabs.md)|  | [optional] 

### Return type

[**EnvelopeRecipientTabs**](EnvelopeRecipientTabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

