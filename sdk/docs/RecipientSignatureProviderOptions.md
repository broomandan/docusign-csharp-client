# IO.Swagger.Model.RecipientSignatureProviderOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CpfNumber** | **string** | Reserved for DocuSign | [optional] 
**OneTimePassword** | **string** | A pre-shared secret that the signer must enter to complete the signing process. Eg last six digits of the signer&#39;s government ID or Social Security number. Or a newly created pre-shared secret for the transaction. Note: some signature providers may require an exact (case-sensitive) match if alphabetic characters are included in the field. | [optional] 
**SignerRole** | **string** | The role or capacity of the signing recipient. Examples: Manager, Approver, etc. | [optional] 
**Sms** | **string** | The mobile phone number used to send the recipient an access code for the signing ceremony. Format: a string starting with +, then the country code followed by the full mobile phone number without any spaces or special characters. Omit leading zeroes before a city code. Examples: +14155551234, +97235551234, +33505551234. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

