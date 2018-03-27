# IO.Swagger.Api.GroupsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GroupsDeleteGroups**](GroupsApi.md#groupsdeletegroups) | **DELETE** /v2/accounts/{accountId}/groups | Deletes an existing user group.
[**GroupsGetGroups**](GroupsApi.md#groupsgetgroups) | **GET** /v2/accounts/{accountId}/groups | Gets information about groups associated with the account.
[**GroupsPostGroups**](GroupsApi.md#groupspostgroups) | **POST** /v2/accounts/{accountId}/groups | Creates one or more groups for the account.
[**GroupsPutGroups**](GroupsApi.md#groupsputgroups) | **PUT** /v2/accounts/{accountId}/groups | Updates the group information for a group.


<a name="groupsdeletegroups"></a>
# **GroupsDeleteGroups**
> Groups GroupsDeleteGroups (string accountId, Groups groups = null)

Deletes an existing user group.

Deletes an existing user group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GroupsDeleteGroupsExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groups = new Groups(); // Groups |  (optional) 

            try
            {
                // Deletes an existing user group.
                Groups result = apiInstance.GroupsDeleteGroups(accountId, groups);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GroupsDeleteGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groups** | [**Groups**](Groups.md)|  | [optional] 

### Return type

[**Groups**](Groups.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupsgetgroups"></a>
# **GroupsGetGroups**
> Groups GroupsGetGroups (string accountId, string count = null, string groupName = null, string groupType = null, string searchText = null, string startPosition = null)

Gets information about groups associated with the account.

Retrieves information about groups associated with the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GroupsGetGroupsExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var count = count_example;  // string | Number of records to return. The number must be greater than 1 and less than or equal to 100. (optional) 
            var groupName = groupName_example;  // string | Filters the groups returned by the group name or a sub-string of group name. (optional) 
            var groupType = groupType_example;  // string |  (optional) 
            var searchText = searchText_example;  // string |  (optional) 
            var startPosition = startPosition_example;  // string | Starting value for the list. (optional) 

            try
            {
                // Gets information about groups associated with the account.
                Groups result = apiInstance.GroupsGetGroups(accountId, count, groupName, groupType, searchText, startPosition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GroupsGetGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **count** | **string**| Number of records to return. The number must be greater than 1 and less than or equal to 100. | [optional] 
 **groupName** | **string**| Filters the groups returned by the group name or a sub-string of group name. | [optional] 
 **groupType** | **string**|  | [optional] 
 **searchText** | **string**|  | [optional] 
 **startPosition** | **string**| Starting value for the list. | [optional] 

### Return type

[**Groups**](Groups.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupspostgroups"></a>
# **GroupsPostGroups**
> Groups GroupsPostGroups (string accountId, Groups groups = null)

Creates one or more groups for the account.

Creates one or more groups for the account.  Groups can be used to help manage users by associating users with a group. You can associate a group with a Permission Profile, which sets the user permissions for users in that group without having to set the `userSettings` property for each user. You are not required to set Permission Profiles for a group, but it makes it easier to manage user permissions for a large number of users. You can also use groups with template sharing to limit user access to templates.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GroupsPostGroupsExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groups = new Groups(); // Groups |  (optional) 

            try
            {
                // Creates one or more groups for the account.
                Groups result = apiInstance.GroupsPostGroups(accountId, groups);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GroupsPostGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groups** | [**Groups**](Groups.md)|  | [optional] 

### Return type

[**Groups**](Groups.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupsputgroups"></a>
# **GroupsPutGroups**
> Groups GroupsPutGroups (string accountId, Groups groups = null)

Updates the group information for a group.

Updates the group name and modifies, or sets, the permission profile for the group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GroupsPutGroupsExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groups = new Groups(); // Groups |  (optional) 

            try
            {
                // Updates the group information for a group.
                Groups result = apiInstance.GroupsPutGroups(accountId, groups);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GroupsPutGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groups** | [**Groups**](Groups.md)|  | [optional] 

### Return type

[**Groups**](Groups.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

