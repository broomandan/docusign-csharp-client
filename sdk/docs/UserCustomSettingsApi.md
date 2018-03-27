# IO.Swagger.Api.UserCustomSettingsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UserCustomSettingsDeleteCustomSettings**](UserCustomSettingsApi.md#usercustomsettingsdeletecustomsettings) | **DELETE** /v2/accounts/{accountId}/users/{userId}/custom_settings | Deletes custom user settings for a specified user.
[**UserCustomSettingsGetCustomSettings**](UserCustomSettingsApi.md#usercustomsettingsgetcustomsettings) | **GET** /v2/accounts/{accountId}/users/{userId}/custom_settings | Retrieves the custom user settings for a specified user.
[**UserCustomSettingsPutCustomSettings**](UserCustomSettingsApi.md#usercustomsettingsputcustomsettings) | **PUT** /v2/accounts/{accountId}/users/{userId}/custom_settings | Adds or updates custom user settings for the specified user.


<a name="usercustomsettingsdeletecustomsettings"></a>
# **UserCustomSettingsDeleteCustomSettings**
> UserCustomSettings UserCustomSettingsDeleteCustomSettings (string accountId, string userId, UserCustomSettings userCustomSettings = null)

Deletes custom user settings for a specified user.

Deletes the specified custom user settings for a single user.  ###Deleting Grouped Custom User Settings###  If the custom user settings you want to delete are grouped, you must include the following information in the header, after Content-Type, in the request:  `X-DocuSign-User-Settings-Key:group_name`  Where the `group_name` is your designated name for the group of customer user settings.  If the extra header information is not included, only the custom user settings that were added without a group are deleted.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserCustomSettingsDeleteCustomSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new UserCustomSettingsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var userCustomSettings = new UserCustomSettings(); // UserCustomSettings |  (optional) 

            try
            {
                // Deletes custom user settings for a specified user.
                UserCustomSettings result = apiInstance.UserCustomSettingsDeleteCustomSettings(accountId, userId, userCustomSettings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserCustomSettingsApi.UserCustomSettingsDeleteCustomSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **userCustomSettings** | [**UserCustomSettings**](UserCustomSettings.md)|  | [optional] 

### Return type

[**UserCustomSettings**](UserCustomSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usercustomsettingsgetcustomsettings"></a>
# **UserCustomSettingsGetCustomSettings**
> UserCustomSettings UserCustomSettingsGetCustomSettings (string accountId, string userId)

Retrieves the custom user settings for a specified user.

Retrieves a list of custom user settings for a single user.  Custom settings provide a flexible way to store and retrieve custom user information that can be used in your own system.  ###### Note: Custom user settings are not the same as user account settings.  ###Getting Grouped Custom User Settings###  If the custom user settings you want to retrieve are grouped, you must include the following information in the header, after Content-Type, in the request:  `X-DocuSign-User-Settings-Key:group_name`  Where the `group_name` is your designated name for the group of customer user settings.  If the extra header information is not included, only the custom user settings that were added without a group are retrieved.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserCustomSettingsGetCustomSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new UserCustomSettingsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Retrieves the custom user settings for a specified user.
                UserCustomSettings result = apiInstance.UserCustomSettingsGetCustomSettings(accountId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserCustomSettingsApi.UserCustomSettingsGetCustomSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 

### Return type

[**UserCustomSettings**](UserCustomSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usercustomsettingsputcustomsettings"></a>
# **UserCustomSettingsPutCustomSettings**
> UserCustomSettings UserCustomSettingsPutCustomSettings (string accountId, string userId, UserCustomSettings userCustomSettings = null)

Adds or updates custom user settings for the specified user.

Adds or updates custom user settings for the specified user.  ###### Note: Custom user settings are not the same as user account settings.  Custom settings provide a flexible way to store and retrieve custom user information that you can use in your own system.  **Important**: There is a limit on the size for all the custom user settings for a single user. The limit is 4,000 characters, which includes the XML and JSON structure for the settings.  ### Grouping Custom User Settings ###  You can group custom user settings when adding them. Grouping allows you to retrieve settings that are in a specific group, instead of retrieving all the user custom settings.  To group custom user settings, add the following information in the header, after Content-Type:  `X-DocuSign-User-Settings-Key:group_name`  Where the `group_name` is your designated name for the group of customer user settings. Grouping is shown in the Example Request Body below.  When getting or deleting grouped custom user settings, you must include the extra header information.  Grouping custom user settings is not required and if the extra header information is not included, the custom user settings are added normally and can be retrieved or deleted without including the additional header.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserCustomSettingsPutCustomSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new UserCustomSettingsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var userCustomSettings = new UserCustomSettings(); // UserCustomSettings |  (optional) 

            try
            {
                // Adds or updates custom user settings for the specified user.
                UserCustomSettings result = apiInstance.UserCustomSettingsPutCustomSettings(accountId, userId, userCustomSettings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserCustomSettingsApi.UserCustomSettingsPutCustomSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **userCustomSettings** | [**UserCustomSettings**](UserCustomSettings.md)|  | [optional] 

### Return type

[**UserCustomSettings**](UserCustomSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

