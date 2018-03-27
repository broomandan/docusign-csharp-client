# IO.Swagger.Api.WorkspacesApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WorkspaceDeleteWorkspace**](WorkspacesApi.md#workspacedeleteworkspace) | **DELETE** /v2/accounts/{accountId}/workspaces/{workspaceId} | Delete Workspace
[**WorkspaceGetWorkspace**](WorkspacesApi.md#workspacegetworkspace) | **GET** /v2/accounts/{accountId}/workspaces/{workspaceId} | Get Workspace
[**WorkspaceGetWorkspaces**](WorkspacesApi.md#workspacegetworkspaces) | **GET** /v2/accounts/{accountId}/workspaces | List Workspaces
[**WorkspacePostWorkspace**](WorkspacesApi.md#workspacepostworkspace) | **POST** /v2/accounts/{accountId}/workspaces | Create a Workspace
[**WorkspacePutWorkspace**](WorkspacesApi.md#workspaceputworkspace) | **PUT** /v2/accounts/{accountId}/workspaces/{workspaceId} | Update Workspace


<a name="workspacedeleteworkspace"></a>
# **WorkspaceDeleteWorkspace**
> Workspaces WorkspaceDeleteWorkspace (string accountId, string workspaceId)

Delete Workspace

Deletes an existing workspace (logically).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WorkspaceDeleteWorkspaceExample
    {
        public void main()
        {
            
            var apiInstance = new WorkspacesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var workspaceId = workspaceId_example;  // string | Specifies the workspace ID GUID.

            try
            {
                // Delete Workspace
                Workspaces result = apiInstance.WorkspaceDeleteWorkspace(accountId, workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.WorkspaceDeleteWorkspace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **workspaceId** | **string**| Specifies the workspace ID GUID. | 

### Return type

[**Workspaces**](Workspaces.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workspacegetworkspace"></a>
# **WorkspaceGetWorkspace**
> Workspaces WorkspaceGetWorkspace (string accountId, string workspaceId)

Get Workspace

Retrives properties about a workspace given a unique workspaceId. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WorkspaceGetWorkspaceExample
    {
        public void main()
        {
            
            var apiInstance = new WorkspacesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var workspaceId = workspaceId_example;  // string | Specifies the workspace ID GUID.

            try
            {
                // Get Workspace
                Workspaces result = apiInstance.WorkspaceGetWorkspace(accountId, workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.WorkspaceGetWorkspace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **workspaceId** | **string**| Specifies the workspace ID GUID. | 

### Return type

[**Workspaces**](Workspaces.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workspacegetworkspaces"></a>
# **WorkspaceGetWorkspaces**
> WorkspaceList WorkspaceGetWorkspaces (string accountId)

List Workspaces

Gets information about the Workspaces that have been created.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WorkspaceGetWorkspacesExample
    {
        public void main()
        {
            
            var apiInstance = new WorkspacesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // List Workspaces
                WorkspaceList result = apiInstance.WorkspaceGetWorkspaces(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.WorkspaceGetWorkspaces: " + e.Message );
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

[**WorkspaceList**](WorkspaceList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workspacepostworkspace"></a>
# **WorkspacePostWorkspace**
> Workspaces WorkspacePostWorkspace (string accountId, Workspaces workspaces = null)

Create a Workspace

Creates a new workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WorkspacePostWorkspaceExample
    {
        public void main()
        {
            
            var apiInstance = new WorkspacesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var workspaces = new Workspaces(); // Workspaces |  (optional) 

            try
            {
                // Create a Workspace
                Workspaces result = apiInstance.WorkspacePostWorkspace(accountId, workspaces);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.WorkspacePostWorkspace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **workspaces** | [**Workspaces**](Workspaces.md)|  | [optional] 

### Return type

[**Workspaces**](Workspaces.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workspaceputworkspace"></a>
# **WorkspacePutWorkspace**
> Workspaces WorkspacePutWorkspace (string accountId, string workspaceId, Workspaces workspaces = null)

Update Workspace

Updates information about a specific workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WorkspacePutWorkspaceExample
    {
        public void main()
        {
            
            var apiInstance = new WorkspacesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var workspaceId = workspaceId_example;  // string | Specifies the workspace ID GUID.
            var workspaces = new Workspaces(); // Workspaces |  (optional) 

            try
            {
                // Update Workspace
                Workspaces result = apiInstance.WorkspacePutWorkspace(accountId, workspaceId, workspaces);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.WorkspacePutWorkspace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **workspaceId** | **string**| Specifies the workspace ID GUID. | 
 **workspaces** | [**Workspaces**](Workspaces.md)|  | [optional] 

### Return type

[**Workspaces**](Workspaces.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

