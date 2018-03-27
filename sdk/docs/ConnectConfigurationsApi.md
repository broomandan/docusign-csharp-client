# IO.Swagger.Api.ConnectConfigurationsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConnectDeleteConnectConfig**](ConnectConfigurationsApi.md#connectdeleteconnectconfig) | **DELETE** /v2/accounts/{accountId}/connect/{connectId} | Deletes the specified connect configuration.
[**ConnectGetConnectConfig**](ConnectConfigurationsApi.md#connectgetconnectconfig) | **GET** /v2/accounts/{accountId}/connect/{connectId} | Get information on a Connect Configuration
[**ConnectGetConnectConfigs**](ConnectConfigurationsApi.md#connectgetconnectconfigs) | **GET** /v2/accounts/{accountId}/connect | Get Connect Configuration Information
[**ConnectGetConnectUsers**](ConnectConfigurationsApi.md#connectgetconnectusers) | **GET** /v2/accounts/{accountId}/connect/{connectId}/users | Returns users from the configured Connect service.
[**ConnectPostConnectConfiguration**](ConnectConfigurationsApi.md#connectpostconnectconfiguration) | **POST** /v2/accounts/{accountId}/connect | Creates a connect configuration for the specified account.
[**ConnectPutConnectConfiguration**](ConnectConfigurationsApi.md#connectputconnectconfiguration) | **PUT** /v2/accounts/{accountId}/connect | Updates a specified Connect configuration.


<a name="connectdeleteconnectconfig"></a>
# **ConnectDeleteConnectConfig**
> void ConnectDeleteConnectConfig (string accountId, string connectId)

Deletes the specified connect configuration.

Deletes the specified DocuSign Connect configuration.  ###### Note: Connect must be enabled for your account to use this function.    

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConnectDeleteConnectConfigExample
    {
        public void main()
        {
            
            var apiInstance = new ConnectConfigurationsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var connectId = connectId_example;  // string | The ID of the custom Connect configuration being accessed.

            try
            {
                // Deletes the specified connect configuration.
                apiInstance.ConnectDeleteConnectConfig(accountId, connectId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectConfigurationsApi.ConnectDeleteConnectConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **connectId** | **string**| The ID of the custom Connect configuration being accessed. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectgetconnectconfig"></a>
# **ConnectGetConnectConfig**
> ConnectConfigResults ConnectGetConnectConfig (string accountId, string connectId)

Get information on a Connect Configuration

Retrieves the information for the specified DocuSign Connect configuration.  ###### Note: Connect must be enabled for your account to use this function. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConnectGetConnectConfigExample
    {
        public void main()
        {
            
            var apiInstance = new ConnectConfigurationsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var connectId = connectId_example;  // string | The ID of the custom Connect configuration being accessed.

            try
            {
                // Get information on a Connect Configuration
                ConnectConfigResults result = apiInstance.ConnectGetConnectConfig(accountId, connectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectConfigurationsApi.ConnectGetConnectConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **connectId** | **string**| The ID of the custom Connect configuration being accessed. | 

### Return type

[**ConnectConfigResults**](ConnectConfigResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectgetconnectconfigs"></a>
# **ConnectGetConnectConfigs**
> ConnectConfigResults ConnectGetConnectConfigs (string accountId)

Get Connect Configuration Information

Retrieves all the DocuSign Custom Connect definitions for the specified account.  ###### Note: Connect must be enabled for your account to use this function. This does not retrieve information for Connect configurations for Box, eOriginal, or Salesforce.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConnectGetConnectConfigsExample
    {
        public void main()
        {
            
            var apiInstance = new ConnectConfigurationsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Get Connect Configuration Information
                ConnectConfigResults result = apiInstance.ConnectGetConnectConfigs(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectConfigurationsApi.ConnectGetConnectConfigs: " + e.Message );
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

[**ConnectConfigResults**](ConnectConfigResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectgetconnectusers"></a>
# **ConnectGetConnectUsers**
> IntegratedUserInfoList ConnectGetConnectUsers (string accountId, string connectId, string count = null, string emailSubstring = null, string listIncludedUsers = null, string startPosition = null, string status = null, string userNameSubstring = null)

Returns users from the configured Connect service.

Returns users from the configured Connect service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConnectGetConnectUsersExample
    {
        public void main()
        {
            
            var apiInstance = new ConnectConfigurationsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var connectId = connectId_example;  // string | The ID of the custom Connect configuration being accessed.
            var count = count_example;  // string | Optional. Number of items to return.  (optional) 
            var emailSubstring = emailSubstring_example;  // string | Filters the returned user records by the email address or a sub-string of email address. (optional) 
            var listIncludedUsers = listIncludedUsers_example;  // string |  (optional) 
            var startPosition = startPosition_example;  // string | The position within the total result set from which to start returning values. The value **thumbnail** may be used to return the page image. (optional) 
            var status = status_example;  // string | Filters the results by user status. You can specify a comma-separated list of the following statuses:  * ActivationRequired  * ActivationSent  * Active * Closed  * Disabled  (optional) 
            var userNameSubstring = userNameSubstring_example;  // string | Filters the user records returned by the user name or a sub-string of user name. (optional) 

            try
            {
                // Returns users from the configured Connect service.
                IntegratedUserInfoList result = apiInstance.ConnectGetConnectUsers(accountId, connectId, count, emailSubstring, listIncludedUsers, startPosition, status, userNameSubstring);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectConfigurationsApi.ConnectGetConnectUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **connectId** | **string**| The ID of the custom Connect configuration being accessed. | 
 **count** | **string**| Optional. Number of items to return.  | [optional] 
 **emailSubstring** | **string**| Filters the returned user records by the email address or a sub-string of email address. | [optional] 
 **listIncludedUsers** | **string**|  | [optional] 
 **startPosition** | **string**| The position within the total result set from which to start returning values. The value **thumbnail** may be used to return the page image. | [optional] 
 **status** | **string**| Filters the results by user status. You can specify a comma-separated list of the following statuses:  * ActivationRequired  * ActivationSent  * Active * Closed  * Disabled  | [optional] 
 **userNameSubstring** | **string**| Filters the user records returned by the user name or a sub-string of user name. | [optional] 

### Return type

[**IntegratedUserInfoList**](IntegratedUserInfoList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectpostconnectconfiguration"></a>
# **ConnectPostConnectConfiguration**
> ConnectConfigurations ConnectPostConnectConfiguration (string accountId, ConnectConfigurations connectConfigurations = null)

Creates a connect configuration for the specified account.

Creates a DocuSign Custom Connect definition for your account. DocuSign Connect enables the sending of real-time data updates to external applications. These updates are generated by user transactions as the envelope progresses through actions to completion. The Connect Service provides updated information about the status of these transactions and returns updates that include the actual content of document form fields. Be aware that, these updates might or might not include the document itself. For more information about Connect, see the [ML:DocuSign Connect Service Guide].  ###### Note: Connect must be enabled for your account to use this function. This cannot be used to set up Connect configurations for Salesforce or eOriginal.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConnectPostConnectConfigurationExample
    {
        public void main()
        {
            
            var apiInstance = new ConnectConfigurationsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var connectConfigurations = new ConnectConfigurations(); // ConnectConfigurations |  (optional) 

            try
            {
                // Creates a connect configuration for the specified account.
                ConnectConfigurations result = apiInstance.ConnectPostConnectConfiguration(accountId, connectConfigurations);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectConfigurationsApi.ConnectPostConnectConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **connectConfigurations** | [**ConnectConfigurations**](ConnectConfigurations.md)|  | [optional] 

### Return type

[**ConnectConfigurations**](ConnectConfigurations.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectputconnectconfiguration"></a>
# **ConnectPutConnectConfiguration**
> ConnectConfigurations ConnectPutConnectConfiguration (string accountId, ConnectConfigurations connectConfigurations = null)

Updates a specified Connect configuration.

Updates the specified DocuSign Connect configuration in your account.  ###### Note: Connect must be enabled for your account to use this function. This cannot be used to update Connect configurations for Box, eOriginal, or Salesforce.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConnectPutConnectConfigurationExample
    {
        public void main()
        {
            
            var apiInstance = new ConnectConfigurationsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var connectConfigurations = new ConnectConfigurations(); // ConnectConfigurations |  (optional) 

            try
            {
                // Updates a specified Connect configuration.
                ConnectConfigurations result = apiInstance.ConnectPutConnectConfiguration(accountId, connectConfigurations);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectConfigurationsApi.ConnectPutConnectConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **connectConfigurations** | [**ConnectConfigurations**](ConnectConfigurations.md)|  | [optional] 

### Return type

[**ConnectConfigurations**](ConnectConfigurations.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

