# IO.Swagger.Model.WorkspaceUser
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | The account ID associated with the envelope. | [optional] 
**AccountName** | **string** | The name of the account that the workspace user belongs to. | [optional] 
**ActiveSince** | **string** |  | [optional] 
**Created** | **string** | The UTC DateTime when the workspace user was created. | [optional] 
**CreatedById** | **string** |  | [optional] 
**Email** | **string** |  | [optional] 
**ErrorDetails** | [**ErrorDetails**](ErrorDetails.md) |  | [optional] 
**LastModified** | **string** | Utc date and time the comment was last updated (can only be done by creator.) | [optional] 
**LastModifiedById** | **string** |  | [optional] 
**Status** | **string** | Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later. | [optional] 
**Type** | **string** | Type of the user. Valid values: type_owner, type_participant. | [optional] 
**UserId** | **string** | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | [optional] 
**UserName** | **string** |  | [optional] 
**WorkspaceId** | **string** | Specifies the workspace ID GUID. | [optional] 
**WorkspaceUserBaseUrl** | **string** | The relative URI that may be used to access a workspace user. | [optional] 
**WorkspaceUserId** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

