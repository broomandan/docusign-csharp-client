# IO.Swagger.Api.ENoteConfigurationsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ENoteConfigurationDeleteENoteConfiguration**](ENoteConfigurationsApi.md#enoteconfigurationdeleteenoteconfiguration) | **DELETE** /v2/accounts/{accountId}/settings/enote_configuration | Deletes configuration information for the eNote eOriginal integration.
[**ENoteConfigurationGetENoteConfiguration**](ENoteConfigurationsApi.md#enoteconfigurationgetenoteconfiguration) | **GET** /v2/accounts/{accountId}/settings/enote_configuration | Returns the configuration information for the eNote eOriginal integration.
[**ENoteConfigurationPutENoteConfiguration**](ENoteConfigurationsApi.md#enoteconfigurationputenoteconfiguration) | **PUT** /v2/accounts/{accountId}/settings/enote_configuration | Updates configuration information for the eNote eOriginal integration.


<a name="enoteconfigurationdeleteenoteconfiguration"></a>
# **ENoteConfigurationDeleteENoteConfiguration**
> void ENoteConfigurationDeleteENoteConfiguration (string accountId)

Deletes configuration information for the eNote eOriginal integration.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ENoteConfigurationDeleteENoteConfigurationExample
    {
        public void main()
        {
            
            var apiInstance = new ENoteConfigurationsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Deletes configuration information for the eNote eOriginal integration.
                apiInstance.ENoteConfigurationDeleteENoteConfiguration(accountId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ENoteConfigurationsApi.ENoteConfigurationDeleteENoteConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enoteconfigurationgetenoteconfiguration"></a>
# **ENoteConfigurationGetENoteConfiguration**
> ENoteConfigurations ENoteConfigurationGetENoteConfiguration (string accountId)

Returns the configuration information for the eNote eOriginal integration.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ENoteConfigurationGetENoteConfigurationExample
    {
        public void main()
        {
            
            var apiInstance = new ENoteConfigurationsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Returns the configuration information for the eNote eOriginal integration.
                ENoteConfigurations result = apiInstance.ENoteConfigurationGetENoteConfiguration(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ENoteConfigurationsApi.ENoteConfigurationGetENoteConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**ENoteConfigurations**](ENoteConfigurations.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enoteconfigurationputenoteconfiguration"></a>
# **ENoteConfigurationPutENoteConfiguration**
> ENoteConfigurations ENoteConfigurationPutENoteConfiguration (string accountId, ENoteConfigurations eNoteConfigurations = null)

Updates configuration information for the eNote eOriginal integration.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ENoteConfigurationPutENoteConfigurationExample
    {
        public void main()
        {
            
            var apiInstance = new ENoteConfigurationsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var eNoteConfigurations = new ENoteConfigurations(); // ENoteConfigurations |  (optional) 

            try
            {
                // Updates configuration information for the eNote eOriginal integration.
                ENoteConfigurations result = apiInstance.ENoteConfigurationPutENoteConfiguration(accountId, eNoteConfigurations);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ENoteConfigurationsApi.ENoteConfigurationPutENoteConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **eNoteConfigurations** | [**ENoteConfigurations**](ENoteConfigurations.md)|  | [optional] 

### Return type

[**ENoteConfigurations**](ENoteConfigurations.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

