# IO.Swagger.Model.Money
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmountInBaseUnit** | **string** | The total payment amount in the currency&#39;s base unit. For example, for USD the base currency is one cent.  | [optional] 
**Currency** | **string** | The three-letter [ISO 4217][ISO4217] currency code for the payment.  For example:  * AUD Australian dollar * CAD Canadian dollar * EUR Euro * GBP Great Britain pund * USD United States dollar  This is a read-only property.  [ISO4217]:          https://en.wikipedia.org/wiki/ISO_4217  | [optional] 
**DisplayAmount** | **string** | The payment amount as displayed in the &#x60;currency&#x60;.  For example, if the payment amount is USD 12.59, the &#x60;amountInBaseUnit&#x60; is 1259 (cents), and the displayed amount is &#x60;$12.59 USD&#x60;.  This is a read-only property.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

