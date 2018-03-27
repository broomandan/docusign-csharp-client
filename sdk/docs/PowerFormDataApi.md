# IO.Swagger.Api.PowerFormDataApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PowerFormsGetPowerFormFormData**](PowerFormDataApi.md#powerformsgetpowerformformdata) | **GET** /v2/accounts/{accountId}/powerforms/{powerFormId}/form_data | Returns the form data associated with the usage of a PowerForm.


<a name="powerformsgetpowerformformdata"></a>
# **PowerFormsGetPowerFormFormData**
> PowerFormsFormDataResponse PowerFormsGetPowerFormFormData (string accountId, string powerFormId, string fromDate = null, string toDate = null)

Returns the form data associated with the usage of a PowerForm.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PowerFormsGetPowerFormFormDataExample
    {
        public void main()
        {
            
            var apiInstance = new PowerFormDataApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var powerFormId = powerFormId_example;  // string | 
            var fromDate = fromDate_example;  // string | Start of the search date range. Only returns templates created on or after this date/time. If no value is specified, there is no limit on the earliest date created. (optional) 
            var toDate = toDate_example;  // string | End of the search date range. Only returns templates created up to this date/time. If no value is provided, this defaults to the current date. (optional) 

            try
            {
                // Returns the form data associated with the usage of a PowerForm.
                PowerFormsFormDataResponse result = apiInstance.PowerFormsGetPowerFormFormData(accountId, powerFormId, fromDate, toDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerFormDataApi.PowerFormsGetPowerFormFormData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **powerFormId** | **string**|  | 
 **fromDate** | **string**| Start of the search date range. Only returns templates created on or after this date/time. If no value is specified, there is no limit on the earliest date created. | [optional] 
 **toDate** | **string**| End of the search date range. Only returns templates created up to this date/time. If no value is provided, this defaults to the current date. | [optional] 

### Return type

[**PowerFormsFormDataResponse**](PowerFormsFormDataResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

