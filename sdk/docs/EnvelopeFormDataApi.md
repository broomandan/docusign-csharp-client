# IO.Swagger.Api.EnvelopeFormDataApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FormDataGetFormData**](EnvelopeFormDataApi.md#formdatagetformdata) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/form_data | Returns envelope form data for an existing envelope.


<a name="formdatagetformdata"></a>
# **FormDataGetFormData**
> EnvelopeFormData FormDataGetFormData (string accountId, string envelopeId)

Returns envelope form data for an existing envelope.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FormDataGetFormDataExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeFormDataApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 

            try
            {
                // Returns envelope form data for an existing envelope.
                EnvelopeFormData result = apiInstance.FormDataGetFormData(accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeFormDataApi.FormDataGetFormData: " + e.Message );
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

[**EnvelopeFormData**](EnvelopeFormData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

