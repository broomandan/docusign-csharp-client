# IO.Swagger.Api.EnvelopeCustomFieldsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CustomFieldsDeleteCustomFields**](EnvelopeCustomFieldsApi.md#customfieldsdeletecustomfields) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/custom_fields | Deletes envelope custom fields for draft and in-process envelopes.
[**CustomFieldsGetCustomFields**](EnvelopeCustomFieldsApi.md#customfieldsgetcustomfields) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/custom_fields | Gets the custom field information for the specified envelope.
[**CustomFieldsPostCustomFields**](EnvelopeCustomFieldsApi.md#customfieldspostcustomfields) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/custom_fields | Updates envelope custom fields for an envelope.
[**CustomFieldsPutCustomFields**](EnvelopeCustomFieldsApi.md#customfieldsputcustomfields) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/custom_fields | Updates envelope custom fields in an envelope.


<a name="customfieldsdeletecustomfields"></a>
# **CustomFieldsDeleteCustomFields**
> EnvelopeCustomFields CustomFieldsDeleteCustomFields (string accountId, string envelopeId, EnvelopeCustomFields envelopeCustomFields = null)

Deletes envelope custom fields for draft and in-process envelopes.

Deletes envelope custom fields for draft and in-process envelopes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomFieldsDeleteCustomFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeCustomFieldsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var envelopeCustomFields = new EnvelopeCustomFields(); // EnvelopeCustomFields |  (optional) 

            try
            {
                // Deletes envelope custom fields for draft and in-process envelopes.
                EnvelopeCustomFields result = apiInstance.CustomFieldsDeleteCustomFields(accountId, envelopeId, envelopeCustomFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeCustomFieldsApi.CustomFieldsDeleteCustomFields: " + e.Message );
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
 **envelopeCustomFields** | [**EnvelopeCustomFields**](EnvelopeCustomFields.md)|  | [optional] 

### Return type

[**EnvelopeCustomFields**](EnvelopeCustomFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customfieldsgetcustomfields"></a>
# **CustomFieldsGetCustomFields**
> CustomFieldsEnvelope CustomFieldsGetCustomFields (string accountId, string envelopeId)

Gets the custom field information for the specified envelope.

Retrieves the custom field information for the specified envelope. You can use these fields in the envelopes for your account to record information about the envelope, help search for envelopes, and track information. The envelope custom fields are shown in the Envelope Settings section when a user is creating an envelope in the DocuSign member console. The envelope custom fields are not seen by the envelope recipients.  There are two types of envelope custom fields, text, and list. A text custom field lets the sender enter the value for the field. With a list custom field, the sender selects the value of the field from a pre-made list.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomFieldsGetCustomFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeCustomFieldsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 

            try
            {
                // Gets the custom field information for the specified envelope.
                CustomFieldsEnvelope result = apiInstance.CustomFieldsGetCustomFields(accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeCustomFieldsApi.CustomFieldsGetCustomFields: " + e.Message );
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

[**CustomFieldsEnvelope**](CustomFieldsEnvelope.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customfieldspostcustomfields"></a>
# **CustomFieldsPostCustomFields**
> EnvelopeCustomFields CustomFieldsPostCustomFields (string accountId, string envelopeId, EnvelopeCustomFields envelopeCustomFields = null)

Updates envelope custom fields for an envelope.

Updates the envelope custom fields for draft and in-process envelopes.  Each custom field used in an envelope must have a unique name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomFieldsPostCustomFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeCustomFieldsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var envelopeCustomFields = new EnvelopeCustomFields(); // EnvelopeCustomFields |  (optional) 

            try
            {
                // Updates envelope custom fields for an envelope.
                EnvelopeCustomFields result = apiInstance.CustomFieldsPostCustomFields(accountId, envelopeId, envelopeCustomFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeCustomFieldsApi.CustomFieldsPostCustomFields: " + e.Message );
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
 **envelopeCustomFields** | [**EnvelopeCustomFields**](EnvelopeCustomFields.md)|  | [optional] 

### Return type

[**EnvelopeCustomFields**](EnvelopeCustomFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customfieldsputcustomfields"></a>
# **CustomFieldsPutCustomFields**
> EnvelopeCustomFields CustomFieldsPutCustomFields (string accountId, string envelopeId, EnvelopeCustomFields envelopeCustomFields = null)

Updates envelope custom fields in an envelope.

Updates the envelope custom fields in draft and in-process envelopes.  Each custom field used in an envelope must have a unique name. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomFieldsPutCustomFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeCustomFieldsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var envelopeCustomFields = new EnvelopeCustomFields(); // EnvelopeCustomFields |  (optional) 

            try
            {
                // Updates envelope custom fields in an envelope.
                EnvelopeCustomFields result = apiInstance.CustomFieldsPutCustomFields(accountId, envelopeId, envelopeCustomFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeCustomFieldsApi.CustomFieldsPutCustomFields: " + e.Message );
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
 **envelopeCustomFields** | [**EnvelopeCustomFields**](EnvelopeCustomFields.md)|  | [optional] 

### Return type

[**EnvelopeCustomFields**](EnvelopeCustomFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

