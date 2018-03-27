# IO.Swagger.Model.CreditCardInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | [**AddressInformation**](AddressInformation.md) | A complex element containing the credit card billing address information.   This can be the same as billing address and follows the same rules as billingAddress. It contains the following elements: street1, street2, city, state, zip, zipPlus4, phone, fax, and country. | [optional] 
**CardNumber** | **string** | The number on the credit card. | [optional] 
**CardType** | **string** | The credit card type. Valid values are: visa, mastercard, or amex. | [optional] 
**ExpirationMonth** | **string** | The month that the credit card expires (1-12). | [optional] 
**ExpirationYear** | **string** | The year 4 digit year in which the credit card expires. | [optional] 
**NameOnCard** | **string** | The exact name printed on the credit card. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

