# IO.Swagger.Model.Document
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplyAnchorTabs** | **string** | Reserved: TBD | [optional] 
**Display** | **string** | This string sets the display and behavior properties of the document during signing. The possible values are:  * &#x60;modal&#x60;&lt;br&gt;   The document is shown as a supplement action strip   and can be viewed, downloaded, or printed in a modal window.   This is the recommended value for supplemental documents.   * &#x60;download&#x60;&lt;br&gt;   The document is shown as a supplement action strip   and can be viewed, downloaded, or printed in a new browser window.   * &#x60;inline&#x60;&lt;br&gt;   The document is shown in the normal signing window.   This value is not used with supplemental documents,   but is the default value for all other documents.  | [optional] 
**DocumentBase64** | **string** | The document&#39;s bytes. This field can be used to include a base64 version of the document bytes within an envelope definition instead of sending the document using a multi-part HTTP request. The maximum document size is smaller if this field is used due to the overhead of the base64 encoding. | [optional] 
**DocumentFields** | [**List&lt;NameValue&gt;**](NameValue.md) |  | [optional] 
**DocumentGroup** | **string** |  | [optional] 
**DocumentId** | **string** | Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute. | [optional] 
**EncryptedWithKeyManager** | **string** | When set to **true**, the document is been already encrypted by the sender for use with the DocuSign Key Manager Security Appliance.   | [optional] 
**FileExtension** | **string** | The file extension type of the document. If the document is not a PDF it is converted to a PDF.   | [optional] 
**FileFormatHint** | **string** |  | [optional] 
**IncludeInDownload** | **string** | When set to **true**, the document is included in the combined document download.  The default value is **true**.  | [optional] 
**MatchBoxes** | [**List&lt;MatchBox&gt;**](MatchBox.md) | Matchboxes define areas in a document for document matching when you are creating envelopes. They are only used when you upload and edit a template.   A matchbox consists of 5 elements:  * pageNumber - The document page number  on which the matchbox will appear.  * xPosition - The x position of the matchbox on a page.  * yPosition - The y position of the matchbox on a page. * width - The width of the matchbox.  * height - The height of the matchbox.   | [optional] 
**Name** | **string** |  | [optional] 
**Order** | **string** | An optional value that sets the direction order used to sort the item list.   Valid values are:   * asc &#x3D; ascending sort order * desc &#x3D; descending sort order  | [optional] 
**Pages** | **string** |  | [optional] 
**Password** | **string** |  | [optional] 
**RemoteUrl** | **string** | The file id from the cloud storage service where the document is located. This information is returned using [ML:GET /folders] or [ML:/folders/{folderid}].  | [optional] 
**SignerMustAcknowledge** | **string** | Sets how the signer interacts with the supplemental document. The possible values are:   * &#x60;no_interaction&#x60;&lt;br&gt;   No recipient action is required.   * &#x60;view&#x60;&lt;br&gt;   The recipient is required to view the document.   * &#x60;accept&#x60;&lt;br&gt;   The recipient is required to accept the document by selecting accept during signing, but is not required to view the document.   * &#x60;view_accept&#x60;&lt;br&gt;   The recipient is required to view and accept the document.     | [optional] 
**TemplateLocked** | **string** | When set to **true**, the sender cannot change any attributes of the recipient. Used only when working with template recipients.  | [optional] 
**TemplateRequired** | **string** | When set to **true**, the sender may not remove the recipient. Used only when working with template recipients. | [optional] 
**TransformPdfFields** | **string** | When set to **true**, PDF form field data is transformed into document tab values when the PDF form field name matches the DocuSign custom tab tabLabel. The resulting PDF form data is also returned in the PDF meta data when requesting the document PDF. See the [ML:Transform PDF Fields] section for more information about how fields are transformed into DocuSign tabs.  | [optional] 
**Uri** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

