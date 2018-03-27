# IO.Swagger.Api.PowerFormsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PowerFormsDeletePowerForm**](PowerFormsApi.md#powerformsdeletepowerform) | **DELETE** /v2/accounts/{accountId}/powerforms/{powerFormId} | Delete a PowerForm.
[**PowerFormsDeletePowerFormsList**](PowerFormsApi.md#powerformsdeletepowerformslist) | **DELETE** /v2/accounts/{accountId}/powerforms | Deletes one or more PowerForms
[**PowerFormsGetPowerForm**](PowerFormsApi.md#powerformsgetpowerform) | **GET** /v2/accounts/{accountId}/powerforms/{powerFormId} | Returns a single PowerForm.
[**PowerFormsGetPowerFormsList**](PowerFormsApi.md#powerformsgetpowerformslist) | **GET** /v2/accounts/{accountId}/powerforms | Returns the list of PowerForms available to the user.
[**PowerFormsGetPowerFormsSenders**](PowerFormsApi.md#powerformsgetpowerformssenders) | **GET** /v2/accounts/{accountId}/powerforms/senders | Returns the list of PowerForms available to the user.
[**PowerFormsPostPowerForm**](PowerFormsApi.md#powerformspostpowerform) | **POST** /v2/accounts/{accountId}/powerforms | Creates a new PowerForm.
[**PowerFormsPutPowerForm**](PowerFormsApi.md#powerformsputpowerform) | **PUT** /v2/accounts/{accountId}/powerforms/{powerFormId} | Creates a new PowerForm.


<a name="powerformsdeletepowerform"></a>
# **PowerFormsDeletePowerForm**
> void PowerFormsDeletePowerForm (string accountId, string powerFormId)

Delete a PowerForm.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PowerFormsDeletePowerFormExample
    {
        public void main()
        {
            
            var apiInstance = new PowerFormsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var powerFormId = powerFormId_example;  // string | 

            try
            {
                // Delete a PowerForm.
                apiInstance.PowerFormsDeletePowerForm(accountId, powerFormId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerFormsApi.PowerFormsDeletePowerForm: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="powerformsdeletepowerformslist"></a>
# **PowerFormsDeletePowerFormsList**
> PowerFormsResponse PowerFormsDeletePowerFormsList (string accountId, PowerFormsRequest powerFormsRequest = null)

Deletes one or more PowerForms



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PowerFormsDeletePowerFormsListExample
    {
        public void main()
        {
            
            var apiInstance = new PowerFormsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var powerFormsRequest = new PowerFormsRequest(); // PowerFormsRequest |  (optional) 

            try
            {
                // Deletes one or more PowerForms
                PowerFormsResponse result = apiInstance.PowerFormsDeletePowerFormsList(accountId, powerFormsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerFormsApi.PowerFormsDeletePowerFormsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **powerFormsRequest** | [**PowerFormsRequest**](PowerFormsRequest.md)|  | [optional] 

### Return type

[**PowerFormsResponse**](PowerFormsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="powerformsgetpowerform"></a>
# **PowerFormsGetPowerForm**
> PowerForms PowerFormsGetPowerForm (string accountId, string powerFormId)

Returns a single PowerForm.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PowerFormsGetPowerFormExample
    {
        public void main()
        {
            
            var apiInstance = new PowerFormsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var powerFormId = powerFormId_example;  // string | 

            try
            {
                // Returns a single PowerForm.
                PowerForms result = apiInstance.PowerFormsGetPowerForm(accountId, powerFormId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerFormsApi.PowerFormsGetPowerForm: " + e.Message );
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

### Return type

[**PowerForms**](PowerForms.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="powerformsgetpowerformslist"></a>
# **PowerFormsGetPowerFormsList**
> PowerFormsResponse PowerFormsGetPowerFormsList (string accountId, string fromDate = null, string order = null, string orderBy = null, string toDate = null)

Returns the list of PowerForms available to the user.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PowerFormsGetPowerFormsListExample
    {
        public void main()
        {
            
            var apiInstance = new PowerFormsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var fromDate = fromDate_example;  // string | Start of the search date range. Only returns templates created on or after this date/time. If no value is specified, there is no limit on the earliest date created. (optional) 
            var order = order_example;  // string | An optional value that sets the direction order used to sort the item list.   Valid values are:   * asc = ascending sort order * desc = descending sort order  (optional) 
            var orderBy = orderBy_example;  // string | An optional value that sets the file attribute used to sort the item list.   Valid values are:   * modified * name   (optional) 
            var toDate = toDate_example;  // string | End of the search date range. Only returns templates created up to this date/time. If no value is provided, this defaults to the current date. (optional) 

            try
            {
                // Returns the list of PowerForms available to the user.
                PowerFormsResponse result = apiInstance.PowerFormsGetPowerFormsList(accountId, fromDate, order, orderBy, toDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerFormsApi.PowerFormsGetPowerFormsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **fromDate** | **string**| Start of the search date range. Only returns templates created on or after this date/time. If no value is specified, there is no limit on the earliest date created. | [optional] 
 **order** | **string**| An optional value that sets the direction order used to sort the item list.   Valid values are:   * asc &#x3D; ascending sort order * desc &#x3D; descending sort order  | [optional] 
 **orderBy** | **string**| An optional value that sets the file attribute used to sort the item list.   Valid values are:   * modified * name   | [optional] 
 **toDate** | **string**| End of the search date range. Only returns templates created up to this date/time. If no value is provided, this defaults to the current date. | [optional] 

### Return type

[**PowerFormsResponse**](PowerFormsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="powerformsgetpowerformssenders"></a>
# **PowerFormsGetPowerFormsSenders**
> PowerFormSendersResponse PowerFormsGetPowerFormsSenders (string accountId, string startPosition = null)

Returns the list of PowerForms available to the user.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PowerFormsGetPowerFormsSendersExample
    {
        public void main()
        {
            
            var apiInstance = new PowerFormsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var startPosition = startPosition_example;  // string | The position within the total result set from which to start returning values. The value **thumbnail** may be used to return the page image. (optional) 

            try
            {
                // Returns the list of PowerForms available to the user.
                PowerFormSendersResponse result = apiInstance.PowerFormsGetPowerFormsSenders(accountId, startPosition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerFormsApi.PowerFormsGetPowerFormsSenders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **startPosition** | **string**| The position within the total result set from which to start returning values. The value **thumbnail** may be used to return the page image. | [optional] 

### Return type

[**PowerFormSendersResponse**](PowerFormSendersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="powerformspostpowerform"></a>
# **PowerFormsPostPowerForm**
> PowerForms PowerFormsPostPowerForm (string accountId, PowerForms powerForms = null)

Creates a new PowerForm.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PowerFormsPostPowerFormExample
    {
        public void main()
        {
            
            var apiInstance = new PowerFormsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var powerForms = new PowerForms(); // PowerForms |  (optional) 

            try
            {
                // Creates a new PowerForm.
                PowerForms result = apiInstance.PowerFormsPostPowerForm(accountId, powerForms);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerFormsApi.PowerFormsPostPowerForm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **powerForms** | [**PowerForms**](PowerForms.md)|  | [optional] 

### Return type

[**PowerForms**](PowerForms.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="powerformsputpowerform"></a>
# **PowerFormsPutPowerForm**
> PowerForms PowerFormsPutPowerForm (string accountId, string powerFormId, PowerForms powerForms = null)

Creates a new PowerForm.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PowerFormsPutPowerFormExample
    {
        public void main()
        {
            
            var apiInstance = new PowerFormsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var powerFormId = powerFormId_example;  // string | 
            var powerForms = new PowerForms(); // PowerForms |  (optional) 

            try
            {
                // Creates a new PowerForm.
                PowerForms result = apiInstance.PowerFormsPutPowerForm(accountId, powerFormId, powerForms);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerFormsApi.PowerFormsPutPowerForm: " + e.Message );
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
 **powerForms** | [**PowerForms**](PowerForms.md)|  | [optional] 

### Return type

[**PowerForms**](PowerForms.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

