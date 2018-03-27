# IO.Swagger.Api.WorkspaceItemsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WorkspaceFileGetWorkspaceFile**](WorkspaceItemsApi.md#workspacefilegetworkspacefile) | **GET** /v2/accounts/{accountId}/workspaces/{workspaceId}/folders/{folderId}/files/{fileId} | Get Workspace File
[**WorkspaceFilePagesGetWorkspaceFilePages**](WorkspaceItemsApi.md#workspacefilepagesgetworkspacefilepages) | **GET** /v2/accounts/{accountId}/workspaces/{workspaceId}/folders/{folderId}/files/{fileId}/pages | List File Pages
[**WorkspaceFilePostWorkspaceFiles**](WorkspaceItemsApi.md#workspacefilepostworkspacefiles) | **POST** /v2/accounts/{accountId}/workspaces/{workspaceId}/folders/{folderId}/files | Creates a workspace file.
[**WorkspaceFilePutWorkspaceFile**](WorkspaceItemsApi.md#workspacefileputworkspacefile) | **PUT** /v2/accounts/{accountId}/workspaces/{workspaceId}/folders/{folderId}/files/{fileId} | Update Workspace File Metadata
[**WorkspaceFolderDeleteWorkspaceItems**](WorkspaceItemsApi.md#workspacefolderdeleteworkspaceitems) | **DELETE** /v2/accounts/{accountId}/workspaces/{workspaceId}/folders/{folderId} | Deletes workspace one or more specific files/folders from the given folder or root.
[**WorkspaceFolderGetWorkspaceFolder**](WorkspaceItemsApi.md#workspacefoldergetworkspacefolder) | **GET** /v2/accounts/{accountId}/workspaces/{workspaceId}/folders/{folderId} | List Workspace Folder Contents


<a name="workspacefilegetworkspacefile"></a>
# **WorkspaceFileGetWorkspaceFile**
> void WorkspaceFileGetWorkspaceFile (string accountId, string fileId, string folderId, string workspaceId, string isDownload = null, string pdfVersion = null)

Get Workspace File

Retrieves a workspace file (the binary).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WorkspaceFileGetWorkspaceFileExample
    {
        public void main()
        {
            
            var apiInstance = new WorkspaceItemsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var fileId = fileId_example;  // string | Specifies the room file ID GUID.
            var folderId = folderId_example;  // string | The ID of the folder being accessed.
            var workspaceId = workspaceId_example;  // string | Specifies the workspace ID GUID.
            var isDownload = isDownload_example;  // string | When set to **true**, the Content-Disposition header is set in the response. The value of the header provides the filename of the file. Default is **false**. (optional) 
            var pdfVersion = pdfVersion_example;  // string | When set to **true** the file returned as a PDF. (optional) 

            try
            {
                // Get Workspace File
                apiInstance.WorkspaceFileGetWorkspaceFile(accountId, fileId, folderId, workspaceId, isDownload, pdfVersion);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspaceItemsApi.WorkspaceFileGetWorkspaceFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **fileId** | **string**| Specifies the room file ID GUID. | 
 **folderId** | **string**| The ID of the folder being accessed. | 
 **workspaceId** | **string**| Specifies the workspace ID GUID. | 
 **isDownload** | **string**| When set to **true**, the Content-Disposition header is set in the response. The value of the header provides the filename of the file. Default is **false**. | [optional] 
 **pdfVersion** | **string**| When set to **true** the file returned as a PDF. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workspacefilepagesgetworkspacefilepages"></a>
# **WorkspaceFilePagesGetWorkspaceFilePages**
> PageImages WorkspaceFilePagesGetWorkspaceFilePages (string accountId, string fileId, string folderId, string workspaceId, string count = null, string dpi = null, string maxHeight = null, string maxWidth = null, string startPosition = null)

List File Pages

Retrieves a workspace file as rasterized pages.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WorkspaceFilePagesGetWorkspaceFilePagesExample
    {
        public void main()
        {
            
            var apiInstance = new WorkspaceItemsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var fileId = fileId_example;  // string | Specifies the room file ID GUID.
            var folderId = folderId_example;  // string | The ID of the folder being accessed.
            var workspaceId = workspaceId_example;  // string | Specifies the workspace ID GUID.
            var count = count_example;  // string | The maximum number of results to be returned by this request. (optional) 
            var dpi = dpi_example;  // string | Number of dots per inch for the resulting image. The default if not used is 94. The range is 1-310. (optional) 
            var maxHeight = maxHeight_example;  // string | Sets the maximum height (in pixels) of the returned image. (optional) 
            var maxWidth = maxWidth_example;  // string | Sets the maximum width (in pixels) of the returned image. (optional) 
            var startPosition = startPosition_example;  // string | The position within the total result set from which to start returning values. The value **thumbnail** may be used to return the page image. (optional) 

            try
            {
                // List File Pages
                PageImages result = apiInstance.WorkspaceFilePagesGetWorkspaceFilePages(accountId, fileId, folderId, workspaceId, count, dpi, maxHeight, maxWidth, startPosition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspaceItemsApi.WorkspaceFilePagesGetWorkspaceFilePages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **fileId** | **string**| Specifies the room file ID GUID. | 
 **folderId** | **string**| The ID of the folder being accessed. | 
 **workspaceId** | **string**| Specifies the workspace ID GUID. | 
 **count** | **string**| The maximum number of results to be returned by this request. | [optional] 
 **dpi** | **string**| Number of dots per inch for the resulting image. The default if not used is 94. The range is 1-310. | [optional] 
 **maxHeight** | **string**| Sets the maximum height (in pixels) of the returned image. | [optional] 
 **maxWidth** | **string**| Sets the maximum width (in pixels) of the returned image. | [optional] 
 **startPosition** | **string**| The position within the total result set from which to start returning values. The value **thumbnail** may be used to return the page image. | [optional] 

### Return type

[**PageImages**](PageImages.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workspacefilepostworkspacefiles"></a>
# **WorkspaceFilePostWorkspaceFiles**
> WorkspaceItems WorkspaceFilePostWorkspaceFiles (string accountId, string folderId, string workspaceId)

Creates a workspace file.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WorkspaceFilePostWorkspaceFilesExample
    {
        public void main()
        {
            
            var apiInstance = new WorkspaceItemsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var folderId = folderId_example;  // string | The ID of the folder being accessed.
            var workspaceId = workspaceId_example;  // string | Specifies the workspace ID GUID.

            try
            {
                // Creates a workspace file.
                WorkspaceItems result = apiInstance.WorkspaceFilePostWorkspaceFiles(accountId, folderId, workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspaceItemsApi.WorkspaceFilePostWorkspaceFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **folderId** | **string**| The ID of the folder being accessed. | 
 **workspaceId** | **string**| Specifies the workspace ID GUID. | 

### Return type

[**WorkspaceItems**](WorkspaceItems.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workspacefileputworkspacefile"></a>
# **WorkspaceFilePutWorkspaceFile**
> WorkspaceItems WorkspaceFilePutWorkspaceFile (string accountId, string fileId, string folderId, string workspaceId)

Update Workspace File Metadata

Updates workspace item metadata for one or more specific files/folders.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WorkspaceFilePutWorkspaceFileExample
    {
        public void main()
        {
            
            var apiInstance = new WorkspaceItemsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var fileId = fileId_example;  // string | Specifies the room file ID GUID.
            var folderId = folderId_example;  // string | The ID of the folder being accessed.
            var workspaceId = workspaceId_example;  // string | Specifies the workspace ID GUID.

            try
            {
                // Update Workspace File Metadata
                WorkspaceItems result = apiInstance.WorkspaceFilePutWorkspaceFile(accountId, fileId, folderId, workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspaceItemsApi.WorkspaceFilePutWorkspaceFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **fileId** | **string**| Specifies the room file ID GUID. | 
 **folderId** | **string**| The ID of the folder being accessed. | 
 **workspaceId** | **string**| Specifies the workspace ID GUID. | 

### Return type

[**WorkspaceItems**](WorkspaceItems.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workspacefolderdeleteworkspaceitems"></a>
# **WorkspaceFolderDeleteWorkspaceItems**
> void WorkspaceFolderDeleteWorkspaceItems (string accountId, string folderId, string workspaceId, WorkspaceItemList workspaceItemList = null)

Deletes workspace one or more specific files/folders from the given folder or root.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WorkspaceFolderDeleteWorkspaceItemsExample
    {
        public void main()
        {
            
            var apiInstance = new WorkspaceItemsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var folderId = folderId_example;  // string | The ID of the folder being accessed.
            var workspaceId = workspaceId_example;  // string | Specifies the workspace ID GUID.
            var workspaceItemList = new WorkspaceItemList(); // WorkspaceItemList |  (optional) 

            try
            {
                // Deletes workspace one or more specific files/folders from the given folder or root.
                apiInstance.WorkspaceFolderDeleteWorkspaceItems(accountId, folderId, workspaceId, workspaceItemList);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspaceItemsApi.WorkspaceFolderDeleteWorkspaceItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **folderId** | **string**| The ID of the folder being accessed. | 
 **workspaceId** | **string**| Specifies the workspace ID GUID. | 
 **workspaceItemList** | [**WorkspaceItemList**](WorkspaceItemList.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workspacefoldergetworkspacefolder"></a>
# **WorkspaceFolderGetWorkspaceFolder**
> WorkspaceFolderContents WorkspaceFolderGetWorkspaceFolder (string accountId, string folderId, string workspaceId, string count = null, string includeFiles = null, string includeSubFolders = null, string includeThumbnails = null, string includeUserDetail = null, string startPosition = null, string workspaceUserId = null)

List Workspace Folder Contents

Retrieves workspace folder contents, which can include sub folders and files.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WorkspaceFolderGetWorkspaceFolderExample
    {
        public void main()
        {
            
            var apiInstance = new WorkspaceItemsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var folderId = folderId_example;  // string | The ID of the folder being accessed.
            var workspaceId = workspaceId_example;  // string | Specifies the workspace ID GUID.
            var count = count_example;  // string | The maximum number of results to be returned by this request. (optional) 
            var includeFiles = includeFiles_example;  // string | When set to **true**, file information is returned in the response along with folder information. The default is **false**. (optional) 
            var includeSubFolders = includeSubFolders_example;  // string | When set to **true**, information about the sub-folders of the current folder is returned. The default is **false**. (optional) 
            var includeThumbnails = includeThumbnails_example;  // string | When set to **true**, thumbnails are returned as part of the response.  The default is **false**. (optional) 
            var includeUserDetail = includeUserDetail_example;  // string | Set to **true** to return extended details about the user. The default is **false**. (optional) 
            var startPosition = startPosition_example;  // string | The position within the total result set from which to start returning values. (optional) 
            var workspaceUserId = workspaceUserId_example;  // string | If set, then the results are filtered to those associated with the specified userId. (optional) 

            try
            {
                // List Workspace Folder Contents
                WorkspaceFolderContents result = apiInstance.WorkspaceFolderGetWorkspaceFolder(accountId, folderId, workspaceId, count, includeFiles, includeSubFolders, includeThumbnails, includeUserDetail, startPosition, workspaceUserId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspaceItemsApi.WorkspaceFolderGetWorkspaceFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **folderId** | **string**| The ID of the folder being accessed. | 
 **workspaceId** | **string**| Specifies the workspace ID GUID. | 
 **count** | **string**| The maximum number of results to be returned by this request. | [optional] 
 **includeFiles** | **string**| When set to **true**, file information is returned in the response along with folder information. The default is **false**. | [optional] 
 **includeSubFolders** | **string**| When set to **true**, information about the sub-folders of the current folder is returned. The default is **false**. | [optional] 
 **includeThumbnails** | **string**| When set to **true**, thumbnails are returned as part of the response.  The default is **false**. | [optional] 
 **includeUserDetail** | **string**| Set to **true** to return extended details about the user. The default is **false**. | [optional] 
 **startPosition** | **string**| The position within the total result set from which to start returning values. | [optional] 
 **workspaceUserId** | **string**| If set, then the results are filtered to those associated with the specified userId. | [optional] 

### Return type

[**WorkspaceFolderContents**](WorkspaceFolderContents.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

