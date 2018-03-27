# IO.Swagger.Api.EnvelopeConsumerDisclosuresApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConsumerDisclosureGetConsumerDisclosureEnvelopeIdRecipientId**](EnvelopeConsumerDisclosuresApi.md#consumerdisclosuregetconsumerdisclosureenvelopeidrecipientid) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/consumer_disclosure | Gets the Electronic Record and Signature Disclosure associated with the account.
[**ConsumerDisclosureGetConsumerDisclosureEnvelopeIdRecipientIdLangCode**](EnvelopeConsumerDisclosuresApi.md#consumerdisclosuregetconsumerdisclosureenvelopeidrecipientidlangcode) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/consumer_disclosure/{langCode} | Reserved: Gets the Electronic Record and Signature Disclosure associated with the account.


<a name="consumerdisclosuregetconsumerdisclosureenvelopeidrecipientid"></a>
# **ConsumerDisclosureGetConsumerDisclosureEnvelopeIdRecipientId**
> EnvelopeConsumerDisclosures ConsumerDisclosureGetConsumerDisclosureEnvelopeIdRecipientId (string accountId, string envelopeId, string recipientId, string langCode = null)

Gets the Electronic Record and Signature Disclosure associated with the account.

Retrieves the Electronic Record and Signature Disclosure, with html formatting, associated with the account. You can use an optional query string to set the language for the disclosure.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConsumerDisclosureGetConsumerDisclosureEnvelopeIdRecipientIdExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeConsumerDisclosuresApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.
            var langCode = langCode_example;  // string |  (optional) 

            try
            {
                // Gets the Electronic Record and Signature Disclosure associated with the account.
                EnvelopeConsumerDisclosures result = apiInstance.ConsumerDisclosureGetConsumerDisclosureEnvelopeIdRecipientId(accountId, envelopeId, recipientId, langCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeConsumerDisclosuresApi.ConsumerDisclosureGetConsumerDisclosureEnvelopeIdRecipientId: " + e.Message );
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
 **langCode** | **string**|  | [optional] 

### Return type

[**EnvelopeConsumerDisclosures**](EnvelopeConsumerDisclosures.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="consumerdisclosuregetconsumerdisclosureenvelopeidrecipientidlangcode"></a>
# **ConsumerDisclosureGetConsumerDisclosureEnvelopeIdRecipientIdLangCode**
> EnvelopeConsumerDisclosures ConsumerDisclosureGetConsumerDisclosureEnvelopeIdRecipientIdLangCode (string accountId, string envelopeId, string langCode, string recipientId, string langCode2 = null)

Reserved: Gets the Electronic Record and Signature Disclosure associated with the account.

Reserved: Retrieves the Electronic Record and Signature Disclosure, with HTML formatting, associated with the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConsumerDisclosureGetConsumerDisclosureEnvelopeIdRecipientIdLangCodeExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeConsumerDisclosuresApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var langCode = langCode_example;  // string | The simple type enumeration the language used in the response. The supported languages, with the language value shown in parenthesis, are:Arabic (ar), Bulgarian (bg), Czech (cs), Chinese Simplified (zh_CN), Chinese Traditional (zh_TW), Croatian (hr), Danish (da), Dutch (nl), English US (en), English UK (en_GB), Estonian (et), Farsi (fa), Finnish (fi), French (fr), French Canada (fr_CA), German (de), Greek (el), Hebrew (he), Hindi (hi), Hungarian (hu), Bahasa Indonesia (id), Italian (it), Japanese (ja), Korean (ko), Latvian (lv), Lithuanian (lt), Bahasa Melayu (ms), Norwegian (no), Polish (pl), Portuguese (pt), Portuguese Brazil (pt_BR), Romanian (ro), Russian (ru), Serbian (sr), Slovak (sk), Slovenian (sl), Spanish (es),Spanish Latin America (es_MX), Swedish (sv), Thai (th), Turkish (tr), Ukrainian (uk) and Vietnamese (vi). Additionally, the value can be set to \"browser\" to automatically detect the browser language being used by the viewer and display the disclosure in that language.
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.
            var langCode2 = langCode_example;  // string |  (optional) 

            try
            {
                // Reserved: Gets the Electronic Record and Signature Disclosure associated with the account.
                EnvelopeConsumerDisclosures result = apiInstance.ConsumerDisclosureGetConsumerDisclosureEnvelopeIdRecipientIdLangCode(accountId, envelopeId, langCode, recipientId, langCode2);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeConsumerDisclosuresApi.ConsumerDisclosureGetConsumerDisclosureEnvelopeIdRecipientIdLangCode: " + e.Message );
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
 **langCode** | **string**| The simple type enumeration the language used in the response. The supported languages, with the language value shown in parenthesis, are:Arabic (ar), Bulgarian (bg), Czech (cs), Chinese Simplified (zh_CN), Chinese Traditional (zh_TW), Croatian (hr), Danish (da), Dutch (nl), English US (en), English UK (en_GB), Estonian (et), Farsi (fa), Finnish (fi), French (fr), French Canada (fr_CA), German (de), Greek (el), Hebrew (he), Hindi (hi), Hungarian (hu), Bahasa Indonesia (id), Italian (it), Japanese (ja), Korean (ko), Latvian (lv), Lithuanian (lt), Bahasa Melayu (ms), Norwegian (no), Polish (pl), Portuguese (pt), Portuguese Brazil (pt_BR), Romanian (ro), Russian (ru), Serbian (sr), Slovak (sk), Slovenian (sl), Spanish (es),Spanish Latin America (es_MX), Swedish (sv), Thai (th), Turkish (tr), Ukrainian (uk) and Vietnamese (vi). Additionally, the value can be set to \&quot;browser\&quot; to automatically detect the browser language being used by the viewer and display the disclosure in that language. | 
 **recipientId** | **string**| The &#x60;recipientId&#x60; used when the envelope or template was created. | 
 **langCode2** | **string**|  | [optional] 

### Return type

[**EnvelopeConsumerDisclosures**](EnvelopeConsumerDisclosures.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

