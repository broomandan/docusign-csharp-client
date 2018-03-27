# IO.Swagger.Model.BulkEnvelopeStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BatchId** | **string** | Specifies an identifier which can be used to retrieve a more detailed status of individual bulk recipient batches. | [optional] 
**BatchSize** | **string** | The number of items returned in this response. | [optional] 
**BulkEnvelopes** | [**List&lt;BulkEnvelope&gt;**](BulkEnvelope.md) | Reserved: TBD | [optional] 
**BulkEnvelopesBatchUri** | **string** | Reserved: TBD | [optional] 
**EndPosition** | **string** | The last position in the result set.  | [optional] 
**Failed** | **string** | The number of entries with a status of failed.  | [optional] 
**NextUri** | **string** | The URI for the next chunk of records based on the search request. It is &#x60;null&#x60; if this is the last set of results for the search.  | [optional] 
**PreviousUri** | **string** | The URI for the prior chunk of records based on the search request. It is &#x60;null&#x60; if this is the first set of results for the search.  | [optional] 
**Queued** | **string** | The number of entries with a status of queued.  | [optional] 
**ResultSetSize** | **string** | The number of results returned in this response.  | [optional] 
**Sent** | **string** | The number of entries with a status of sent. | [optional] 
**StartPosition** | **string** | Starting position of the current result set. | [optional] 
**SubmittedDate** | **string** |  | [optional] 
**TotalSetSize** | **string** | The total number of items in the search&#39;s result set. It will always be greater than or equal to the value of the &#x60;resultSetSize&#x60; field. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

