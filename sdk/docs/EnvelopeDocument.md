# IO.Swagger.Model.EnvelopeDocument
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AttachmentTabId** | **string** |  | [optional] 
**AvailableDocumentTypes** | [**List&lt;SignatureType&gt;**](SignatureType.md) |  | [optional] 
**ContainsPdfFormFields** | **string** |  | [optional] 
**Display** | **string** | This string sets the display and behavior properties of the document during signing. The possible values are:  * &#x60;modal&#x60;&lt;br&gt;   The document is shown as a supplement action strip   and can be viewed, downloaded, or printed in a modal window.   This is the recommended value for supplemental documents.   * &#x60;download&#x60;&lt;br&gt;   The document is shown as a supplement action strip   and can be viewed, downloaded, or printed in a new browser window.   * &#x60;inline&#x60;&lt;br&gt;   The document is shown in the normal signing window.   This value is not used with supplemental documents,   but is the default value for all other documents.  | [optional] 
**DocumentFields** | [**List&lt;NameValue&gt;**](NameValue.md) |  | [optional] 
**DocumentGroup** | **string** |  | [optional] 
**DocumentId** | **string** | Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute. | [optional] 
**ErrorDetails** | [**ErrorDetails**](ErrorDetails.md) |  | [optional] 
**IncludeInDownload** | **string** | When set to **true**, the document is included in the combined document download.  The default value is **true**.  | [optional] 
**Name** | **string** |  | [optional] 
**Order** | **string** | An optional value that sets the direction order used to sort the item list.   Valid values are:   * asc &#x3D; ascending sort order * desc &#x3D; descending sort order  | [optional] 
**Pages** | **string** |  | [optional] 
**SignerMustAcknowledge** | **string** | Sets how the signer interacts with the supplemental document. The possible values are:   * &#x60;no_interaction&#x60;&lt;br&gt;   No recipient action is required.   * &#x60;view&#x60;&lt;br&gt;   The recipient is required to view the document.   * &#x60;accept&#x60;&lt;br&gt;   The recipient is required to accept the document by selecting accept during signing, but is not required to view the document.   * &#x60;view_accept&#x60;&lt;br&gt;   The recipient is required to view and accept the document.     | [optional] 
**Type** | **string** | Type of the user. Valid values: type_owner, type_participant. | [optional] 
**Uri** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

