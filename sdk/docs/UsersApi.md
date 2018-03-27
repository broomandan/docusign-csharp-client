# IO.Swagger.Api.UsersApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UserGetUser**](UsersApi.md#usergetuser) | **GET** /v2/accounts/{accountId}/users/{userId} | Gets the user information for a specified user.
[**UserProfileImageDeleteUserProfileImage**](UsersApi.md#userprofileimagedeleteuserprofileimage) | **DELETE** /v2/accounts/{accountId}/users/{userId}/profile/image | Deletes the user profile image for the specified user.
[**UserProfileImageGetUserProfileImage**](UsersApi.md#userprofileimagegetuserprofileimage) | **GET** /v2/accounts/{accountId}/users/{userId}/profile/image | Retrieves the user profile image for the specified user.
[**UserProfileImagePutUserProfileImage**](UsersApi.md#userprofileimageputuserprofileimage) | **PUT** /v2/accounts/{accountId}/users/{userId}/profile/image | Updates the user profile image for a specified user.
[**UserPutUser**](UsersApi.md#userputuser) | **PUT** /v2/accounts/{accountId}/users/{userId} | Updates the specified user information.
[**UserSettingsGetUserSettings**](UsersApi.md#usersettingsgetusersettings) | **GET** /v2/accounts/{accountId}/users/{userId}/settings | Gets the user account settings for a specified user.
[**UserSettingsPutUserSettings**](UsersApi.md#usersettingsputusersettings) | **PUT** /v2/accounts/{accountId}/users/{userId}/settings | Updates the user account settings for a specified user.
[**UsersDeleteUsers**](UsersApi.md#usersdeleteusers) | **DELETE** /v2/accounts/{accountId}/users | Removes users account privileges.
[**UsersGetUsers**](UsersApi.md#usersgetusers) | **GET** /v2/accounts/{accountId}/users | Retrieves the list of users for the specified account.
[**UsersPostUsers**](UsersApi.md#userspostusers) | **POST** /v2/accounts/{accountId}/users | Adds news user to the specified account.
[**UsersPutUsers**](UsersApi.md#usersputusers) | **PUT** /v2/accounts/{accountId}/users | Change one or more user in the specified account.


<a name="usergetuser"></a>
# **UserGetUser**
> Users UserGetUser (string accountId, string userId, string additionalInfo = null, string email = null)

Gets the user information for a specified user.

Retrieves the user information for the specified user.   To return additional user information that details the last login date, login status, and the user's password expiration date, set the optional `additional_info` query string parameter to **true**.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserGetUserExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var additionalInfo = additionalInfo_example;  // string | When set to **true**, the full list of user information is returned for each user in the account. (optional) 
            var email = email_example;  // string |  (optional) 

            try
            {
                // Gets the user information for a specified user.
                Users result = apiInstance.UserGetUser(accountId, userId, additionalInfo, email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UserGetUser: " + e.Message );
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
 **additionalInfo** | **string**| When set to **true**, the full list of user information is returned for each user in the account. | [optional] 
 **email** | **string**|  | [optional] 

### Return type

[**Users**](Users.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprofileimagedeleteuserprofileimage"></a>
# **UserProfileImageDeleteUserProfileImage**
> void UserProfileImageDeleteUserProfileImage (string accountId, string userId)

Deletes the user profile image for the specified user.

Deletes the user profile image from the  specified user's profile.  The userId parameter specified in the endpoint must match the authenticated user's user ID and the user must be a member of the specified account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserProfileImageDeleteUserProfileImageExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Deletes the user profile image for the specified user.
                apiInstance.UserProfileImageDeleteUserProfileImage(accountId, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UserProfileImageDeleteUserProfileImage: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprofileimagegetuserprofileimage"></a>
# **UserProfileImageGetUserProfileImage**
> System.IO.Stream UserProfileImageGetUserProfileImage (string accountId, string userId, string encoding = null)

Retrieves the user profile image for the specified user.

Retrieves the user profile picture for the specified user. The image is returned in the same format as uploaded.  The userId parameter specified in the endpoint must match the authenticated user's user ID and the user must be a member of the specified account.  If successful, the response returns a 200 - OK and the user profile image.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserProfileImageGetUserProfileImageExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var encoding = encoding_example;  // string |  (optional) 

            try
            {
                // Retrieves the user profile image for the specified user.
                System.IO.Stream result = apiInstance.UserProfileImageGetUserProfileImage(accountId, userId, encoding);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UserProfileImageGetUserProfileImage: " + e.Message );
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
 **encoding** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/gif

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprofileimageputuserprofileimage"></a>
# **UserProfileImagePutUserProfileImage**
> void UserProfileImagePutUserProfileImage (string accountId, string userId)

Updates the user profile image for a specified user.

Updates the user profile image by uploading an image to the user profile.  The supported image formats are: gif, png, jpeg, and bmp. The file must be less than 200K. For best viewing results, DocuSign recommends that the image is no more than 79 pixels wide and high.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserProfileImagePutUserProfileImageExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Updates the user profile image for a specified user.
                apiInstance.UserProfileImagePutUserProfileImage(accountId, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UserProfileImagePutUserProfileImage: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userputuser"></a>
# **UserPutUser**
> Users UserPutUser (string accountId, string userId, Users users = null)

Updates the specified user information.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserPutUserExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var users = new Users(); // Users |  (optional) 

            try
            {
                // Updates the specified user information.
                Users result = apiInstance.UserPutUser(accountId, userId, users);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UserPutUser: " + e.Message );
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
 **users** | [**Users**](Users.md)|  | [optional] 

### Return type

[**Users**](Users.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersettingsgetusersettings"></a>
# **UserSettingsGetUserSettings**
> UserSettingsInformation UserSettingsGetUserSettings (string accountId, string userId)

Gets the user account settings for a specified user.

Retrieves a list of the account settings and email notification information for the specified user.  The response returns the account setting name/value information and the email notification settings for the specified user. For more information about the different user settings, see the [ML:userSettings list].

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserSettingsGetUserSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Gets the user account settings for a specified user.
                UserSettingsInformation result = apiInstance.UserSettingsGetUserSettings(accountId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UserSettingsGetUserSettings: " + e.Message );
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

[**UserSettingsInformation**](UserSettingsInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersettingsputusersettings"></a>
# **UserSettingsPutUserSettings**
> void UserSettingsPutUserSettings (string accountId, string userId, UserSettingsInformation userSettingsInformation = null)

Updates the user account settings for a specified user.

Updates the account settings list and email notification types for the specified user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserSettingsPutUserSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var userSettingsInformation = new UserSettingsInformation(); // UserSettingsInformation |  (optional) 

            try
            {
                // Updates the user account settings for a specified user.
                apiInstance.UserSettingsPutUserSettings(accountId, userId, userSettingsInformation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UserSettingsPutUserSettings: " + e.Message );
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
 **userSettingsInformation** | [**UserSettingsInformation**](UserSettingsInformation.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersdeleteusers"></a>
# **UsersDeleteUsers**
> GroupUsers UsersDeleteUsers (string accountId, UserInfoList userInfoList = null)

Removes users account privileges.

This closes one or more user records in the account. Users are never deleted from an account, but closing a user prevents them from using account functions.  The response returns whether the API execution was successful (200 - OK) or  if it failed. The response contains a user structure similar to the request and includes the user changes. If an error occurred during the DELETE operation for any of the users, the response for that user contains an `errorDetails` node with `errorCode` and `message` properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersDeleteUsersExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userInfoList = new UserInfoList(); // UserInfoList |  (optional) 

            try
            {
                // Removes users account privileges.
                GroupUsers result = apiInstance.UsersDeleteUsers(accountId, userInfoList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersDeleteUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **userInfoList** | [**UserInfoList**](UserInfoList.md)|  | [optional] 

### Return type

[**GroupUsers**](GroupUsers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersgetusers"></a>
# **UsersGetUsers**
> UserInformationList UsersGetUsers (string accountId, string additionalInfo = null, string count = null, string email = null, string emailSubstring = null, string groupId = null, string includeUsersettingsForCsv = null, string loginStatus = null, string notGroupId = null, string startPosition = null, string status = null, string userNameSubstring = null)

Retrieves the list of users for the specified account.

Retrieves the list of users for the specified account.  The response returns the list of users for the account along with the information about the result set. If the `additional_info` query was added to the endpoint and set to **true**, the full user information is returned for each user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersGetUsersExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var additionalInfo = additionalInfo_example;  // string | When set to **true**, the full list of user information is returned for each user in the account. (optional) 
            var count = count_example;  // string | Number of records to return. The number must be greater than 0 and less than or equal to 100.  (optional) 
            var email = email_example;  // string |  (optional) 
            var emailSubstring = emailSubstring_example;  // string | Filters the returned user records by the email address or a sub-string of email address. (optional) 
            var groupId = groupId_example;  // string | Filters user records returned by one or more group Id's. (optional) 
            var includeUsersettingsForCsv = includeUsersettingsForCsv_example;  // string |  (optional) 
            var loginStatus = loginStatus_example;  // string |  (optional) 
            var notGroupId = notGroupId_example;  // string |  (optional) 
            var startPosition = startPosition_example;  // string | Starting value for the list.  (optional) 
            var status = status_example;  // string | Filters the results by user status. You can specify a comma-separated list of the following statuses:  * ActivationRequired  * ActivationSent  * Active * Closed  * Disabled  (optional) 
            var userNameSubstring = userNameSubstring_example;  // string | Filters the user records returned by the user name or a sub-string of user name. (optional) 

            try
            {
                // Retrieves the list of users for the specified account.
                UserInformationList result = apiInstance.UsersGetUsers(accountId, additionalInfo, count, email, emailSubstring, groupId, includeUsersettingsForCsv, loginStatus, notGroupId, startPosition, status, userNameSubstring);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersGetUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **additionalInfo** | **string**| When set to **true**, the full list of user information is returned for each user in the account. | [optional] 
 **count** | **string**| Number of records to return. The number must be greater than 0 and less than or equal to 100.  | [optional] 
 **email** | **string**|  | [optional] 
 **emailSubstring** | **string**| Filters the returned user records by the email address or a sub-string of email address. | [optional] 
 **groupId** | **string**| Filters user records returned by one or more group Id&#39;s. | [optional] 
 **includeUsersettingsForCsv** | **string**|  | [optional] 
 **loginStatus** | **string**|  | [optional] 
 **notGroupId** | **string**|  | [optional] 
 **startPosition** | **string**| Starting value for the list.  | [optional] 
 **status** | **string**| Filters the results by user status. You can specify a comma-separated list of the following statuses:  * ActivationRequired  * ActivationSent  * Active * Closed  * Disabled  | [optional] 
 **userNameSubstring** | **string**| Filters the user records returned by the user name or a sub-string of user name. | [optional] 

### Return type

[**UserInformationList**](UserInformationList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userspostusers"></a>
# **UsersPostUsers**
> NewUsersSummary UsersPostUsers (string accountId, NewUsersDefinition newUsersDefinition = null)

Adds news user to the specified account.

Adds new users to your account. Set the `userSettings` property in the request to specify the actions the users can perform on the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersPostUsersExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var newUsersDefinition = new NewUsersDefinition(); // NewUsersDefinition |  (optional) 

            try
            {
                // Adds news user to the specified account.
                NewUsersSummary result = apiInstance.UsersPostUsers(accountId, newUsersDefinition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersPostUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **newUsersDefinition** | [**NewUsersDefinition**](NewUsersDefinition.md)|  | [optional] 

### Return type

[**NewUsersSummary**](NewUsersSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersputusers"></a>
# **UsersPutUsers**
> UserInformationList UsersPutUsers (string accountId, UserInformationList userInformationList = null)

Change one or more user in the specified account.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersPutUsersExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userInformationList = new UserInformationList(); // UserInformationList |  (optional) 

            try
            {
                // Change one or more user in the specified account.
                UserInformationList result = apiInstance.UsersPutUsers(accountId, userInformationList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersPutUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **userInformationList** | [**UserInformationList**](UserInformationList.md)|  | [optional] 

### Return type

[**UserInformationList**](UserInformationList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

