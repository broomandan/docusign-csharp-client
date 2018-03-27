# IO.Swagger.Api.CustomTabsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TabDeleteCustomTab**](CustomTabsApi.md#tabdeletecustomtab) | **DELETE** /v2/accounts/{accountId}/tab_definitions/{customTabId} | Deletes custom tab information.
[**TabGetCustomTab**](CustomTabsApi.md#tabgetcustomtab) | **GET** /v2/accounts/{accountId}/tab_definitions/{customTabId} | Gets custom tab information.
[**TabPutCustomTab**](CustomTabsApi.md#tabputcustomtab) | **PUT** /v2/accounts/{accountId}/tab_definitions/{customTabId} | Updates custom tab information.  
[**TabsGetTabDefinitions**](CustomTabsApi.md#tabsgettabdefinitions) | **GET** /v2/accounts/{accountId}/tab_definitions | Gets a list of all account tabs.
[**TabsPostTabDefinitions**](CustomTabsApi.md#tabsposttabdefinitions) | **POST** /v2/accounts/{accountId}/tab_definitions | Creates a custom tab.


<a name="tabdeletecustomtab"></a>
# **TabDeleteCustomTab**
> void TabDeleteCustomTab (string accountId, string customTabId)

Deletes custom tab information.

Deletes the custom from the specified account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TabDeleteCustomTabExample
    {
        public void main()
        {
            
            var apiInstance = new CustomTabsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var customTabId = customTabId_example;  // string | 

            try
            {
                // Deletes custom tab information.
                apiInstance.TabDeleteCustomTab(accountId, customTabId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomTabsApi.TabDeleteCustomTab: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **customTabId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tabgetcustomtab"></a>
# **TabGetCustomTab**
> CustomTabs TabGetCustomTab (string accountId, string customTabId)

Gets custom tab information.

Retrieves information about the requested custom tab on the specified account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TabGetCustomTabExample
    {
        public void main()
        {
            
            var apiInstance = new CustomTabsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var customTabId = customTabId_example;  // string | 

            try
            {
                // Gets custom tab information.
                CustomTabs result = apiInstance.TabGetCustomTab(accountId, customTabId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomTabsApi.TabGetCustomTab: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **customTabId** | **string**|  | 

### Return type

[**CustomTabs**](CustomTabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tabputcustomtab"></a>
# **TabPutCustomTab**
> CustomTabs TabPutCustomTab (string accountId, string customTabId, CustomTabs customTabs = null)

Updates custom tab information.  

Updates the information in a custom tab for the specified account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TabPutCustomTabExample
    {
        public void main()
        {
            
            var apiInstance = new CustomTabsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var customTabId = customTabId_example;  // string | 
            var customTabs = new CustomTabs(); // CustomTabs |  (optional) 

            try
            {
                // Updates custom tab information.  
                CustomTabs result = apiInstance.TabPutCustomTab(accountId, customTabId, customTabs);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomTabsApi.TabPutCustomTab: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **customTabId** | **string**|  | 
 **customTabs** | [**CustomTabs**](CustomTabs.md)|  | [optional] 

### Return type

[**CustomTabs**](CustomTabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tabsgettabdefinitions"></a>
# **TabsGetTabDefinitions**
> TabMetadataList TabsGetTabDefinitions (string accountId, string customTabOnly = null)

Gets a list of all account tabs.

Retrieves a list of all tabs associated with the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TabsGetTabDefinitionsExample
    {
        public void main()
        {
            
            var apiInstance = new CustomTabsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var customTabOnly = customTabOnly_example;  // string | When set to **true**, only custom tabs are returned in the response.  (optional) 

            try
            {
                // Gets a list of all account tabs.
                TabMetadataList result = apiInstance.TabsGetTabDefinitions(accountId, customTabOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomTabsApi.TabsGetTabDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **customTabOnly** | **string**| When set to **true**, only custom tabs are returned in the response.  | [optional] 

### Return type

[**TabMetadataList**](TabMetadataList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tabsposttabdefinitions"></a>
# **TabsPostTabDefinitions**
> CustomTabs TabsPostTabDefinitions (string accountId, CustomTabs customTabs = null)

Creates a custom tab.

Creates a tab with pre-defined properties, such as a text tab with a certain font type and validation pattern. Users can access the custom tabs when sending documents through the DocuSign web application.  Custom tabs can be created for approve, checkbox, company, date, date signed, decline, email, email address, envelope ID, first name, formula, full name, initial here, last name, list, note, number, radio, sign here, signer attachment, SSN, text, title, and zip tabs.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TabsPostTabDefinitionsExample
    {
        public void main()
        {
            
            var apiInstance = new CustomTabsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var customTabs = new CustomTabs(); // CustomTabs |  (optional) 

            try
            {
                // Creates a custom tab.
                CustomTabs result = apiInstance.TabsPostTabDefinitions(accountId, customTabs);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomTabsApi.TabsPostTabDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **customTabs** | [**CustomTabs**](CustomTabs.md)|  | [optional] 

### Return type

[**CustomTabs**](CustomTabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

