# IO.Swagger.Api.AccountTabSettingsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TabSettingsGetTabSettings**](AccountTabSettingsApi.md#tabsettingsgettabsettings) | **GET** /v2/accounts/{accountId}/settings/tabs | Returns tab settings list for specified account
[**TabSettingsPutSettings**](AccountTabSettingsApi.md#tabsettingsputsettings) | **PUT** /v2/accounts/{accountId}/settings/tabs | Modifies tab settings for specified account


<a name="tabsettingsgettabsettings"></a>
# **TabSettingsGetTabSettings**
> AccountTabSettings TabSettingsGetTabSettings (string accountId)

Returns tab settings list for specified account



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TabSettingsGetTabSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new AccountTabSettingsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Returns tab settings list for specified account
                AccountTabSettings result = apiInstance.TabSettingsGetTabSettings(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountTabSettingsApi.TabSettingsGetTabSettings: " + e.Message );
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

[**AccountTabSettings**](AccountTabSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tabsettingsputsettings"></a>
# **TabSettingsPutSettings**
> AccountTabSettings TabSettingsPutSettings (string accountId, AccountTabSettings accountTabSettings = null)

Modifies tab settings for specified account



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TabSettingsPutSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new AccountTabSettingsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var accountTabSettings = new AccountTabSettings(); // AccountTabSettings |  (optional) 

            try
            {
                // Modifies tab settings for specified account
                AccountTabSettings result = apiInstance.TabSettingsPutSettings(accountId, accountTabSettings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountTabSettingsApi.TabSettingsPutSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **accountTabSettings** | [**AccountTabSettings**](AccountTabSettings.md)|  | [optional] 

### Return type

[**AccountTabSettings**](AccountTabSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

