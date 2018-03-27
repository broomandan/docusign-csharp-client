# IO.Swagger.Model.AddressInformationInput
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressInformation** | [**AddressInformation**](AddressInformation.md) | A complex type that contains the following information for the new account (all string content): address1, address2, city, country, fax, phone, postalCode and state.  ###### Note: If country is US (United States) then State codes are validated for US States.  Otherwise, State is treated as a non-validated string and serves the purpose of entering a state/province/region. The maximum characters for the strings are:  * address1, address2, city, country and state: 100 characters * postalCode, phone, and fax: 20 characters  | [optional] 
**DisplayLevelCode** | **string** | Specifies the display level for the recipient.  Valid values are:   * ReadOnly * Editable * DoNotDisplay | [optional] 
**ReceiveInResponse** | **string** | When set to **true**, the information needs to be returned in the response. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

