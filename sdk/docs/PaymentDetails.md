# IO.Swagger.Model.PaymentDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChargeId** | **string** |  | [optional] 
**CurrencyCode** | **string** | Specifies the three-letter [ISO 4217][ISO4217] currency code for the payment.  Supported currencies are:  * AUD Australian dollar * CAD Canadian dollar * EUR Euro * GBP Great Britain pund * USD United States dollar  Specifying any other ISO 4217 code for payments is an error.  [ISO4217]:          https://en.wikipedia.org/wiki/ISO_4217  | [optional] 
**GatewayAccountId** | **string** | A GUID that identifies the payment gateway connected to the sender&#39;s DocuSign account.  There is no public API for connecting payment gateway accounts You must connect and manage payment gateway accounts through the DocuSign Admin console and through your chosen payment gateway.  You can get the gateway account ID in the Payments section of the DocuSign Admin console.   [paymentgateways]:  https://support.docusign.com/en/guides/managing-payment-gateways  | [optional] 
**GatewayName** | **string** |  | [optional] 
**LineItems** | [**List&lt;PaymentLineItem&gt;**](PaymentLineItem.md) | A payment formula can have one or more line items that provide detail about individual items in a payment request.  The list of line items are returned as metadata to the payment gateway.  | [optional] 
**Status** | **string** | This read-only property describes the status of a payment.  * &#x60;new&#x60;&lt;br&gt;   This is a new payment request.   The envelope has been created,   but no payment authorizations have been made.  * &#x60;auth_complete&#x60;&lt;br&gt;   A recipient has entered their credit card information,   but the envelope has not been completed.   The card has not been charged.  * &#x60;payment_complete&#x60;&lt;br&gt;   The recipient&#39;s card has been charged.  * &#x60;payment_capture_failed&#x60;&lt;br&gt;   Final charge failed.   This can happen when too much time   passes between authorizing the payment   and completing the document.  | [optional] 
**Total** | [**Money**](Money.md) | This read-only property is a currency-formatted string that represents the total of all the line items. The total is available only after the document is completed, which is when all recipients have paid and have completed all required fields.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

