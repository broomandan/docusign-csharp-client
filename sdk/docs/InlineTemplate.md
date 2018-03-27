# IO.Swagger.Model.InlineTemplate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomFields** | [**AccountCustomFields**](AccountCustomFields.md) | An optional array of strings that allows the sender to provide custom data about the recipient. This information is returned in the envelope status but otherwise not used by DocuSign. Each customField string can be a maximum of 100 characters. | [optional] 
**Documents** | [**List&lt;Document&gt;**](Document.md) | Complex element contains the details on the documents in the envelope. | [optional] 
**Envelope** | [**Envelopes**](Envelopes.md) | A container used to send documents to recipients. The envelope carries information about the sender and timestamps to indicate the progress of the delivery procedure. It can contain collections of Documents, Tabs and Recipients. | [optional] 
**Recipients** | [**EnvelopeRecipients**](EnvelopeRecipients.md) |  | [optional] 
**Sequence** | **string** | Specifies the order in which templates are overlaid. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

