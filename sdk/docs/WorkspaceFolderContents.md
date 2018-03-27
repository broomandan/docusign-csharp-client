# IO.Swagger.Model.WorkspaceFolderContents
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndPosition** | **string** | The last position in the result set.  | [optional] 
**Folder** | [**WorkspaceItems**](WorkspaceItems.md) | The query value can be a folder name or folder ID. The response will only return templates in the specified folder. | [optional] 
**Items** | [**List&lt;WorkspaceItems&gt;**](WorkspaceItems.md) |  | [optional] 
**ParentFolders** | [**List&lt;WorkspaceItems&gt;**](WorkspaceItems.md) |  | [optional] 
**ResultSetSize** | **string** | The number of results returned in this response.  | [optional] 
**StartPosition** | **string** | Starting position of the current result set. | [optional] 
**TotalSetSize** | **string** | The total number of items in the search&#39;s result set. It will always be greater than or equal to the value of the &#x60;resultSetSize&#x60; field. | [optional] 
**WorkspaceId** | **string** | The id of the workspace, always populated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

