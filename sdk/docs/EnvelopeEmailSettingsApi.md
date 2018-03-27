# IO.Swagger.Api.EnvelopeEmailSettingsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EmailSettingsDeleteEmailSettings**](EnvelopeEmailSettingsApi.md#emailsettingsdeleteemailsettings) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/email_settings | Deletes the email setting overrides for an envelope.
[**EmailSettingsGetEmailSettings**](EnvelopeEmailSettingsApi.md#emailsettingsgetemailsettings) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/email_settings | Gets the email setting overrides for an envelope.
[**EmailSettingsPostEmailSettings**](EnvelopeEmailSettingsApi.md#emailsettingspostemailsettings) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/email_settings | Adds email setting overrides to an envelope.
[**EmailSettingsPutEmailSettings**](EnvelopeEmailSettingsApi.md#emailsettingsputemailsettings) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/email_settings | Updates the email setting overrides for an envelope.


<a name="emailsettingsdeleteemailsettings"></a>
# **EmailSettingsDeleteEmailSettings**
> EnvelopeEmailSettings EmailSettingsDeleteEmailSettings (string accountId, string envelopeId)

Deletes the email setting overrides for an envelope.

Deletes all existing email override settings for the envelope. If you want to delete an individual email override setting, use the PUT and set the value to an empty string. Note that deleting email settings will only affect email communications that occur after the deletion and the normal account email settings are used for future email communications.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EmailSettingsDeleteEmailSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeEmailSettingsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 

            try
            {
                // Deletes the email setting overrides for an envelope.
                EnvelopeEmailSettings result = apiInstance.EmailSettingsDeleteEmailSettings(accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeEmailSettingsApi.EmailSettingsDeleteEmailSettings: " + e.Message );
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

[**EnvelopeEmailSettings**](EnvelopeEmailSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emailsettingsgetemailsettings"></a>
# **EmailSettingsGetEmailSettings**
> EnvelopeEmailSettings EmailSettingsGetEmailSettings (string accountId, string envelopeId)

Gets the email setting overrides for an envelope.

Retrieves the email override settings for the specified envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EmailSettingsGetEmailSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeEmailSettingsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 

            try
            {
                // Gets the email setting overrides for an envelope.
                EnvelopeEmailSettings result = apiInstance.EmailSettingsGetEmailSettings(accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeEmailSettingsApi.EmailSettingsGetEmailSettings: " + e.Message );
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

[**EnvelopeEmailSettings**](EnvelopeEmailSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emailsettingspostemailsettings"></a>
# **EmailSettingsPostEmailSettings**
> EnvelopeEmailSettings EmailSettingsPostEmailSettings (string accountId, string envelopeId, EnvelopeEmailSettings envelopeEmailSettings = null)

Adds email setting overrides to an envelope.

Adds email override settings, changing the email address to reply to an email address, name, or the BCC for email archive information, for the envelope. Note that adding email settings will only affect email communications that occur after the addition was made.  ### Important: The BCC Email address feature is designed to provide a copy of all email communications for external archiving purposes. DocuSign recommends that envelopes sent using the BCC for Email Archive feature, including the BCC Email Override option, include additional signer authentication options. To send a copy of the envelope to a recipient who does not need to sign, use a Carbon Copies or Certified Deliveries Recipient Type.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EmailSettingsPostEmailSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeEmailSettingsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var envelopeEmailSettings = new EnvelopeEmailSettings(); // EnvelopeEmailSettings |  (optional) 

            try
            {
                // Adds email setting overrides to an envelope.
                EnvelopeEmailSettings result = apiInstance.EmailSettingsPostEmailSettings(accountId, envelopeId, envelopeEmailSettings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeEmailSettingsApi.EmailSettingsPostEmailSettings: " + e.Message );
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
 **envelopeEmailSettings** | [**EnvelopeEmailSettings**](EnvelopeEmailSettings.md)|  | [optional] 

### Return type

[**EnvelopeEmailSettings**](EnvelopeEmailSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emailsettingsputemailsettings"></a>
# **EmailSettingsPutEmailSettings**
> EnvelopeEmailSettings EmailSettingsPutEmailSettings (string accountId, string envelopeId, EnvelopeEmailSettings envelopeEmailSettings = null)

Updates the email setting overrides for an envelope.

Updates the existing email override settings for the specified envelope. Note that modifying email settings will only affect email communications that occur after the modification was made.  This can also be used to delete an individual email override setting by using an empty string for the value to be deleted.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EmailSettingsPutEmailSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeEmailSettingsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var envelopeEmailSettings = new EnvelopeEmailSettings(); // EnvelopeEmailSettings |  (optional) 

            try
            {
                // Updates the email setting overrides for an envelope.
                EnvelopeEmailSettings result = apiInstance.EmailSettingsPutEmailSettings(accountId, envelopeId, envelopeEmailSettings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeEmailSettingsApi.EmailSettingsPutEmailSettings: " + e.Message );
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
 **envelopeEmailSettings** | [**EnvelopeEmailSettings**](EnvelopeEmailSettings.md)|  | [optional] 

### Return type

[**EnvelopeEmailSettings**](EnvelopeEmailSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

