# IO.Swagger.Api.AccountConsumerDisclosuresApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConsumerDisclosureGetConsumerDisclosure**](AccountConsumerDisclosuresApi.md#consumerdisclosuregetconsumerdisclosure) | **GET** /v2/accounts/{accountId}/consumer_disclosure | Gets the Electronic Record and Signature Disclosure for the account.
[**ConsumerDisclosureGetConsumerDisclosureLangCode**](AccountConsumerDisclosuresApi.md#consumerdisclosuregetconsumerdisclosurelangcode) | **GET** /v2/accounts/{accountId}/consumer_disclosure/{langCode} | Gets the Electronic Record and Signature Disclosure.
[**ConsumerDisclosurePutConsumerDisclosure**](AccountConsumerDisclosuresApi.md#consumerdisclosureputconsumerdisclosure) | **PUT** /v2/accounts/{accountId}/consumer_disclosure/{langCode} | Update Consumer Disclosure.


<a name="consumerdisclosuregetconsumerdisclosure"></a>
# **ConsumerDisclosureGetConsumerDisclosure**
> AccountConsumerDisclosures ConsumerDisclosureGetConsumerDisclosure (string accountId, string langCode = null)

Gets the Electronic Record and Signature Disclosure for the account.

Retrieves the Electronic Record and Signature Disclosure, with HTML formatting, associated with the account. You can use an optional query string to set the language for the disclosure.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConsumerDisclosureGetConsumerDisclosureExample
    {
        public void main()
        {
            
            var apiInstance = new AccountConsumerDisclosuresApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var langCode = langCode_example;  // string | Specifies the language used in the response. The supported languages, with the language value shown in parenthesis, are: Arabic (ar), Bulgarian (bg), Czech (cs), Chinese Simplified (zh_CN), Chinese Traditional (zh_TW), Croatian (hr), Danish (da), Dutch (nl), English US (en), English UK (en_GB), Estonian (et), Farsi (fa), Finnish (fi), French (fr), French Canada (fr_CA), German (de), Greek (el), Hebrew (he), Hindi (hi), Hungarian (hu), Bahasa Indonesia (id), Italian (it), Japanese (ja), Korean (ko), Latvian (lv), Lithuanian (lt), Bahasa Melayu (ms), Norwegian (no), Polish (pl), Portuguese (pt), Portuguese Brazil (pt_BR), Romanian (ro), Russian (ru), Serbian (sr), Slovak (sk), Slovenian (sl), Spanish (es),Spanish Latin America (es_MX), Swedish (sv), Thai (th), Turkish (tr), Ukrainian (uk), and Vietnamese (vi).  Additionally, the value can be set to `browser` to automatically detect the browser language being used by the viewer and display the disclosure in that language.   (optional) 

            try
            {
                // Gets the Electronic Record and Signature Disclosure for the account.
                AccountConsumerDisclosures result = apiInstance.ConsumerDisclosureGetConsumerDisclosure(accountId, langCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountConsumerDisclosuresApi.ConsumerDisclosureGetConsumerDisclosure: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **langCode** | **string**| Specifies the language used in the response. The supported languages, with the language value shown in parenthesis, are: Arabic (ar), Bulgarian (bg), Czech (cs), Chinese Simplified (zh_CN), Chinese Traditional (zh_TW), Croatian (hr), Danish (da), Dutch (nl), English US (en), English UK (en_GB), Estonian (et), Farsi (fa), Finnish (fi), French (fr), French Canada (fr_CA), German (de), Greek (el), Hebrew (he), Hindi (hi), Hungarian (hu), Bahasa Indonesia (id), Italian (it), Japanese (ja), Korean (ko), Latvian (lv), Lithuanian (lt), Bahasa Melayu (ms), Norwegian (no), Polish (pl), Portuguese (pt), Portuguese Brazil (pt_BR), Romanian (ro), Russian (ru), Serbian (sr), Slovak (sk), Slovenian (sl), Spanish (es),Spanish Latin America (es_MX), Swedish (sv), Thai (th), Turkish (tr), Ukrainian (uk), and Vietnamese (vi).  Additionally, the value can be set to &#x60;browser&#x60; to automatically detect the browser language being used by the viewer and display the disclosure in that language.   | [optional] 

### Return type

[**AccountConsumerDisclosures**](AccountConsumerDisclosures.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="consumerdisclosuregetconsumerdisclosurelangcode"></a>
# **ConsumerDisclosureGetConsumerDisclosureLangCode**
> AccountConsumerDisclosures ConsumerDisclosureGetConsumerDisclosureLangCode (string accountId, string langCode)

Gets the Electronic Record and Signature Disclosure.

Retrieves the Electronic Record and Signature Disclosure, with HTML formatting, for the requested envelope recipient. This might be different than the current account disclosure depending on account settings, such as branding, and when the account disclosure was last updated. An optional query string can be included to return the language for the disclosure.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConsumerDisclosureGetConsumerDisclosureLangCodeExample
    {
        public void main()
        {
            
            var apiInstance = new AccountConsumerDisclosuresApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var langCode = langCode_example;  // string | The simple type enumeration the language used in the response. The supported languages, with the language value shown in parenthesis, are:Arabic (ar), Bulgarian (bg), Czech (cs), Chinese Simplified (zh_CN), Chinese Traditional (zh_TW), Croatian (hr), Danish (da), Dutch (nl), English US (en), English UK (en_GB), Estonian (et), Farsi (fa), Finnish (fi), French (fr), French Canada (fr_CA), German (de), Greek (el), Hebrew (he), Hindi (hi), Hungarian (hu), Bahasa Indonesia (id), Italian (it), Japanese (ja), Korean (ko), Latvian (lv), Lithuanian (lt), Bahasa Melayu (ms), Norwegian (no), Polish (pl), Portuguese (pt), Portuguese Brazil (pt_BR), Romanian (ro), Russian (ru), Serbian (sr), Slovak (sk), Slovenian (sl), Spanish (es),Spanish Latin America (es_MX), Swedish (sv), Thai (th), Turkish (tr), Ukrainian (uk) and Vietnamese (vi). Additionally, the value can be set to \"browser\" to automatically detect the browser language being used by the viewer and display the disclosure in that language.

            try
            {
                // Gets the Electronic Record and Signature Disclosure.
                AccountConsumerDisclosures result = apiInstance.ConsumerDisclosureGetConsumerDisclosureLangCode(accountId, langCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountConsumerDisclosuresApi.ConsumerDisclosureGetConsumerDisclosureLangCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **langCode** | **string**| The simple type enumeration the language used in the response. The supported languages, with the language value shown in parenthesis, are:Arabic (ar), Bulgarian (bg), Czech (cs), Chinese Simplified (zh_CN), Chinese Traditional (zh_TW), Croatian (hr), Danish (da), Dutch (nl), English US (en), English UK (en_GB), Estonian (et), Farsi (fa), Finnish (fi), French (fr), French Canada (fr_CA), German (de), Greek (el), Hebrew (he), Hindi (hi), Hungarian (hu), Bahasa Indonesia (id), Italian (it), Japanese (ja), Korean (ko), Latvian (lv), Lithuanian (lt), Bahasa Melayu (ms), Norwegian (no), Polish (pl), Portuguese (pt), Portuguese Brazil (pt_BR), Romanian (ro), Russian (ru), Serbian (sr), Slovak (sk), Slovenian (sl), Spanish (es),Spanish Latin America (es_MX), Swedish (sv), Thai (th), Turkish (tr), Ukrainian (uk) and Vietnamese (vi). Additionally, the value can be set to \&quot;browser\&quot; to automatically detect the browser language being used by the viewer and display the disclosure in that language. | 

### Return type

[**AccountConsumerDisclosures**](AccountConsumerDisclosures.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="consumerdisclosureputconsumerdisclosure"></a>
# **ConsumerDisclosurePutConsumerDisclosure**
> EnvelopeConsumerDisclosures ConsumerDisclosurePutConsumerDisclosure (string accountId, string langCode, string includeMetadata = null, EnvelopeConsumerDisclosures envelopeConsumerDisclosures = null)

Update Consumer Disclosure.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConsumerDisclosurePutConsumerDisclosureExample
    {
        public void main()
        {
            
            var apiInstance = new AccountConsumerDisclosuresApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var langCode = langCode_example;  // string | The simple type enumeration the language used in the response. The supported languages, with the language value shown in parenthesis, are:Arabic (ar), Bulgarian (bg), Czech (cs), Chinese Simplified (zh_CN), Chinese Traditional (zh_TW), Croatian (hr), Danish (da), Dutch (nl), English US (en), English UK (en_GB), Estonian (et), Farsi (fa), Finnish (fi), French (fr), French Canada (fr_CA), German (de), Greek (el), Hebrew (he), Hindi (hi), Hungarian (hu), Bahasa Indonesia (id), Italian (it), Japanese (ja), Korean (ko), Latvian (lv), Lithuanian (lt), Bahasa Melayu (ms), Norwegian (no), Polish (pl), Portuguese (pt), Portuguese Brazil (pt_BR), Romanian (ro), Russian (ru), Serbian (sr), Slovak (sk), Slovenian (sl), Spanish (es),Spanish Latin America (es_MX), Swedish (sv), Thai (th), Turkish (tr), Ukrainian (uk) and Vietnamese (vi). Additionally, the value can be set to \"browser\" to automatically detect the browser language being used by the viewer and display the disclosure in that language.
            var includeMetadata = includeMetadata_example;  // string | Reserved for DocuSign.  (optional) 
            var envelopeConsumerDisclosures = new EnvelopeConsumerDisclosures(); // EnvelopeConsumerDisclosures |  (optional) 

            try
            {
                // Update Consumer Disclosure.
                EnvelopeConsumerDisclosures result = apiInstance.ConsumerDisclosurePutConsumerDisclosure(accountId, langCode, includeMetadata, envelopeConsumerDisclosures);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountConsumerDisclosuresApi.ConsumerDisclosurePutConsumerDisclosure: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **langCode** | **string**| The simple type enumeration the language used in the response. The supported languages, with the language value shown in parenthesis, are:Arabic (ar), Bulgarian (bg), Czech (cs), Chinese Simplified (zh_CN), Chinese Traditional (zh_TW), Croatian (hr), Danish (da), Dutch (nl), English US (en), English UK (en_GB), Estonian (et), Farsi (fa), Finnish (fi), French (fr), French Canada (fr_CA), German (de), Greek (el), Hebrew (he), Hindi (hi), Hungarian (hu), Bahasa Indonesia (id), Italian (it), Japanese (ja), Korean (ko), Latvian (lv), Lithuanian (lt), Bahasa Melayu (ms), Norwegian (no), Polish (pl), Portuguese (pt), Portuguese Brazil (pt_BR), Romanian (ro), Russian (ru), Serbian (sr), Slovak (sk), Slovenian (sl), Spanish (es),Spanish Latin America (es_MX), Swedish (sv), Thai (th), Turkish (tr), Ukrainian (uk) and Vietnamese (vi). Additionally, the value can be set to \&quot;browser\&quot; to automatically detect the browser language being used by the viewer and display the disclosure in that language. | 
 **includeMetadata** | **string**| Reserved for DocuSign.  | [optional] 
 **envelopeConsumerDisclosures** | [**EnvelopeConsumerDisclosures**](EnvelopeConsumerDisclosures.md)|  | [optional] 

### Return type

[**EnvelopeConsumerDisclosures**](EnvelopeConsumerDisclosures.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

