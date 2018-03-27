# IO.Swagger.Model.UserSettingsInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountManagementGranular** | [**UserAccountManagementGranularInformation**](UserAccountManagementGranularInformation.md) |  | [optional] 
**SenderEmailNotifications** | [**SenderEmailNotifications**](SenderEmailNotifications.md) |   An array of email notifications that sets the email the user receives when they are a sender. When the specific email notification is set to true, the user will receive those types of email notifications from DocuSign.   The user inherits the default account sender email notification settings when the user is created. The email notifications are:  * envelopeComplete * changedSigner  * senderEnvelopeDeclined  * withdrawnConsent  * recipientViewed  * deliveryFailed    | [optional] 
**SignerEmailNotifications** | [**SignerEmailNotifications**](SignerEmailNotifications.md) | An array of email notifications that specifies the email the user receives when they are a sender. When the specific email notification is set to true, the user receives those types of email notifications from DocuSign. The user inherits the default account sender email notification settings when the user is created. | [optional] 
**UserSettings** | [**List&lt;NameValue&gt;**](NameValue.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

