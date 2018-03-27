# IO.Swagger.Model.BillingPlanInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AppStoreReceipt** | [**AppStoreReceipt**](AppStoreReceipt.md) |  | [optional] 
**BillingAddress** | [**AccountAddress**](AccountAddress.md) |  | [optional] 
**CreditCardInformation** | [**CreditCardInformation**](CreditCardInformation.md) | A complex type that has information about the credit card used to pay for this account. | [optional] 
**DowngradeReason** | **string** |  | [optional] 
**EnableSupport** | **string** | When set to **true**, then customer support is provided as part of the account plan. | [optional] 
**IncludedSeats** | **string** | The number of seats (users) included. | [optional] 
**IncrementalSeats** | **string** | Reserved: TBD | [optional] 
**PaymentProcessorInformation** | [**PaymentProcessorInformation**](PaymentProcessorInformation.md) |  | [optional] 
**PlanInformation** | [**PlanInformation**](PlanInformation.md) | An object used to identify the features and attributes of the account being created. | [optional] 
**ReferralInformation** | [**ReferralInformation**](ReferralInformation.md) | A complex type that contains the following information for entering referral and discount information. The following items are included in the referral information (all string content): enableSupport, includedSeats, saleDiscountPercent, saleDiscountAmount, saleDiscountFixedAmount, saleDiscountPeriods, saleDiscountSeatPriceOverride, planStartMonth, referralCode, referrerName, advertisementId, publisherId, shopperId, promoCode, groupMemberId, idType, and industry   ###### Note: saleDiscountPercent, saleDiscountAmount, saleDiscountFixedAmount, saleDiscountPeriods, and saleDiscountSeatPriceOverride are reserved for DoucSign use only.   | [optional] 
**RenewalStatus** | **string** |  | [optional] 
**SaleDiscountAmount** | **string** | Reserved for DocuSign use only. | [optional] 
**SaleDiscountFixedAmount** | **string** | Reserved for DocuSign use only. | [optional] 
**SaleDiscountPercent** | **string** | Reserved for DocuSign use only. | [optional] 
**SaleDiscountPeriods** | **string** | Reserved for DocuSign use only. | [optional] 
**SaleDiscountSeatPriceOverride** | **string** | Reserved for DocuSign use only. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

