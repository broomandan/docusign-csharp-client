# IO.Swagger.Model.UserProfiles
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | [**AddressInformationV2**](AddressInformationV2.md) |  | [optional] 
**AuthenticationMethods** | [**List&lt;AuthenticationMethod&gt;**](AuthenticationMethod.md) | These properties cannot be modified in the PUT.   Indicates the authentication methods used by the user. | [optional] 
**CompanyName** | **string** | The name of the user&#39;s Company. | [optional] 
**DisplayOrganizationInfo** | **string** |  When set to **true**, the user&#39;s company and title information are shown on the ID card.  | [optional] 
**DisplayPersonalInfo** | **string** | When set to **true**, the user&#39;s Address and Phone number are shown on the ID card. | [optional] 
**DisplayProfile** | **string** | When set to **true**, the user&#39;s ID card can be viewed from signed documents and envelope history. | [optional] 
**DisplayUsageHistory** | **string** | When set to **true**, the user&#39;s usage information is shown on the ID card. | [optional] 
**ProfileImageUri** | **string** |  | [optional] 
**Title** | **string** | The title of the user. | [optional] 
**UsageHistory** | [**UsageHistory**](UsageHistory.md) | A complex element consisting of:   * lastSentDateTime - the date and time the user last sent an envelope.  * lastSignedDateTime - the date and time the user last signed an envelope. * sentCount - the number of envelopes the user has sent. * signedCount - the number of envelopes the user has signed.   | [optional] 
**UserDetails** | [**Users**](Users.md) |  | [optional] 
**UserProfileLastModifiedDate** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

