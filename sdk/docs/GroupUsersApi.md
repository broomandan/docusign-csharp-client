# IO.Swagger.Api.GroupUsersApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GroupsDeleteGroupUsers**](GroupUsersApi.md#groupsdeletegroupusers) | **DELETE** /v2/accounts/{accountId}/groups/{groupId}/users | Deletes one or more users from a gro
[**GroupsGetGroupUsers**](GroupUsersApi.md#groupsgetgroupusers) | **GET** /v2/accounts/{accountId}/groups/{groupId}/users | Gets a list of users in a group.
[**GroupsPutGroupUsers**](GroupUsersApi.md#groupsputgroupusers) | **PUT** /v2/accounts/{accountId}/groups/{groupId}/users | Adds one or more users to an existing group.


<a name="groupsdeletegroupusers"></a>
# **GroupsDeleteGroupUsers**
> GroupUsers GroupsDeleteGroupUsers (string accountId, string groupId, UserInfoList userInfoList = null)

Deletes one or more users from a gro

Deletes one or more users from a group. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GroupsDeleteGroupUsersExample
    {
        public void main()
        {
            
            var apiInstance = new GroupUsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groupId = groupId_example;  // string | The ID of the group being accessed.
            var userInfoList = new UserInfoList(); // UserInfoList |  (optional) 

            try
            {
                // Deletes one or more users from a gro
                GroupUsers result = apiInstance.GroupsDeleteGroupUsers(accountId, groupId, userInfoList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupUsersApi.GroupsDeleteGroupUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groupId** | **string**| The ID of the group being accessed. | 
 **userInfoList** | [**UserInfoList**](UserInfoList.md)|  | [optional] 

### Return type

[**GroupUsers**](GroupUsers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupsgetgroupusers"></a>
# **GroupsGetGroupUsers**
> GroupUsers GroupsGetGroupUsers (string accountId, string groupId, string count = null, string startPosition = null)

Gets a list of users in a group.

Retrieves a list of users in a group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GroupsGetGroupUsersExample
    {
        public void main()
        {
            
            var apiInstance = new GroupUsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groupId = groupId_example;  // string | The ID of the group being accessed.
            var count = count_example;  // string | Number of records to return. The number must be greater than 1 and less than or equal to 100.  (optional) 
            var startPosition = startPosition_example;  // string | Starting value for the list. (optional) 

            try
            {
                // Gets a list of users in a group.
                GroupUsers result = apiInstance.GroupsGetGroupUsers(accountId, groupId, count, startPosition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupUsersApi.GroupsGetGroupUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groupId** | **string**| The ID of the group being accessed. | 
 **count** | **string**| Number of records to return. The number must be greater than 1 and less than or equal to 100.  | [optional] 
 **startPosition** | **string**| Starting value for the list. | [optional] 

### Return type

[**GroupUsers**](GroupUsers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupsputgroupusers"></a>
# **GroupsPutGroupUsers**
> GroupUsers GroupsPutGroupUsers (string accountId, string groupId, UserInfoList userInfoList = null)

Adds one or more users to an existing group.

Adds one or more users to an existing group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GroupsPutGroupUsersExample
    {
        public void main()
        {
            
            var apiInstance = new GroupUsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groupId = groupId_example;  // string | The ID of the group being accessed.
            var userInfoList = new UserInfoList(); // UserInfoList |  (optional) 

            try
            {
                // Adds one or more users to an existing group.
                GroupUsers result = apiInstance.GroupsPutGroupUsers(accountId, groupId, userInfoList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupUsersApi.GroupsPutGroupUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groupId** | **string**| The ID of the group being accessed. | 
 **userInfoList** | [**UserInfoList**](UserInfoList.md)|  | [optional] 

### Return type

[**GroupUsers**](GroupUsers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

