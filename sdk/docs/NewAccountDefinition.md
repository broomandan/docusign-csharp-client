# IO.Swagger.Model.NewAccountDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountName** | **string** | The account name for the new account. | [optional] 
**AccountSettings** | [**List&lt;NameValue&gt;**](NameValue.md) | The list of [account settings][accountsettings] that determine the features available for the account. Note that some features are determined by the plan used to create the account and cannot be overridden.  [accountsettings]: /esign/restapi/Accounts/Accounts/create/#account-settings  | [optional] 
**AddressInformation** | [**AccountAddress**](AccountAddress.md) | A complex type that contains the following information for the new account (all string content): address1, address2, city, country, fax, phone, postalCode and state.  **Note:** If country is US (United States) then State codes are validated for US States. Otherwise, State is treated as a non-validated string and serves the purpose of entering a state/province/region.  The maximum characters for the strings are: * address1, address2, city, country and state: 100 characters * postalCode, phone, and fax: 20 characters | [optional] 
**CreditCardInformation** | [**CreditCardInformation**](CreditCardInformation.md) | A complex type that has information about the credit card used to pay for this account. | [optional] 
**DistributorCode** | **string** | The code that identifies the billing plan groups and plans for the new account. | [optional] 
**DistributorPassword** | **string** | The password for the distributorCode. | [optional] 
**InitialUser** | [**Users**](Users.md) | A complex type with the initial user information for the new account. Note that some user information is set internally based on the plan and cannot be overridden. | [optional] 
**PaymentProcessorInformation** | [**PaymentProcessorInformation**](PaymentProcessorInformation.md) |  | [optional] 
**PlanInformation** | [**PlanInformation**](PlanInformation.md) | An object used to identify the features and attributes of the account being created. | [optional] 
**ReferralInformation** | [**ReferralInformation**](ReferralInformation.md) | A complex type that contains the following information for entering referral and discount information. The following items are included in the referral information (all string content): enableSupport, includedSeats, saleDiscountPercent, saleDiscountAmount, saleDiscountFixedAmount, saleDiscountPeriods, saleDiscountSeatPriceOverride, planStartMonth, referralCode, referrerName, advertisementId, publisherId, shopperId, promoCode, groupMemberId, idType, and industry   ###### Note: saleDiscountPercent, saleDiscountAmount, saleDiscountFixedAmount, saleDiscountPeriods, and saleDiscountSeatPriceOverride are reserved for DoucSign use only.   | [optional] 
**SocialAccountInformation** | [**UserSocialAccountLogins**](UserSocialAccountLogins.md) | Contains properties that map a DocuSign user to a social account (Facebook, Yahoo, etc.) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

