# IO.Swagger.Model.EnvelopesInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndPosition** | **string** | The last position in the result set.  | [optional] 
**Envelopes** | [**List&lt;Envelopes&gt;**](Envelopes.md) | Set of envelope information | [optional] 
**EnvelopeTransactionStatuses** | [**List&lt;EnvelopeTransactionStatus&gt;**](EnvelopeTransactionStatus.md) | Array of envelope statuses and transaction Ids in the result set. | [optional] 
**NextUri** | **string** | The URI for the next chunk of records based on the search request. It is &#x60;null&#x60; if this is the last set of results for the search.  | [optional] 
**PreviousUri** | **string** | The URI for the prior chunk of records based on the search request. It is &#x60;null&#x60; if this is the first set of results for the search.  | [optional] 
**ResultSetSize** | **string** | The number of results returned in this response.  | [optional] 
**StartPosition** | **string** | Starting position of the current result set. | [optional] 
**TotalSetSize** | **string** | The total number of items in the search&#39;s result set. It will always be greater than or equal to the value of the &#x60;resultSetSize&#x60; field. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

