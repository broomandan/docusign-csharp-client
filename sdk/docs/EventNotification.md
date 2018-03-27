# IO.Swagger.Model.EventNotification
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnvelopeEvents** | [**List&lt;EnvelopeEvent&gt;**](EnvelopeEvent.md) | A list of envelope-level event statuses that will trigger Connect to send updates to the endpoint specified in the &#x60;url&#x60; property.   To receive notifications, you must include either an &#x60;envelopeEvents&#x60; node or a &#x60;recipientEvents&#x60; node. You do not need to specify both. | [optional] 
**IncludeCertificateOfCompletion** | **string** | When set to **true**, the Connect Service includes the Certificate of Completion with completed envelopes.  | [optional] 
**IncludeCertificateWithSoap** | **string** | When set to **true**, the Connect service will send the DocuSign signedby certificate as part of the SOAP xml. The certificate is included in the XML message as &#x60;wsse:BinarySecurityToken&#x60;. | [optional] 
**IncludeDocumentFields** | **string** | When set to **true**, the Document Fields associated with the envelope&#39;s documents are included in the notification messages. Document Fields are optional custom name-value pairs added to documents using the API.  | [optional] 
**IncludeDocuments** | **string** | When set to **true**, the XML webhook messages will include the envelope&#39;s PDF documents. Including the PDF documents will greatly increase the size of the notification messages. Ensure that your listener can handle incoming messages that are 25MB or larger.  | [optional] 
**IncludeEnvelopeVoidReason** | **string** | When set to **true**, if the envelope is voided, the Connect Service notification will include the void reason, as entered by the person that voided the envelope.  | [optional] 
**IncludeSenderAccountAsCustomField** | **string** | When set to **true**, Connect will include the sender account as Custom Field in the data. | [optional] 
**IncludeTimeZone** | **string** | When set to **true**, the envelope&#39;s time zone information is included in the webhook messages.  | [optional] 
**LoggingEnabled** | **string** | When set to **true**, the webhook messages are logged. They can be viewed on the DocuSign Administration Web Tool in the Connect section. Logged messages can also be downloaded via the [ConnectEvents resource](../../../Connect/ConnectEvents/) | [optional] 
**RecipientEvents** | [**List&lt;RecipientEvent&gt;**](RecipientEvent.md) | An array of recipient event statuses that will trigger Connect to send notifications to your webhook listener at the url endpoint specified in the &#x60;url&#x60; property.   To receive notifications, you must include either an &#x60;envelopeEvents&#x60; node or a &#x60;recipientEvents&#x60; node. You do not need to specify both. | [optional] 
**RequireAcknowledgment** | **string** | When set to **true**, the DocuSign Connect service checks that the message was received and retries on failures.  | [optional] 
**SignMessageWithX509Cert** | **string** | When set to **true**, notification messages are digitally signed with an [X509 certificate](https://trust.docusign.com/en-us/trust-certifications/docusign-public-certificates/).  | [optional] 
**SoapNameSpace** | **string** | The namespace of the SOAP interface.  The namespace value must be set if useSoapInterface is set to true. | [optional] 
**Url** | **string** | The endpoint to which webhook notification messages are sent via an HTTP/S POST request. For the DocuSign production platform, the url must start with https. For the demo platform, either http or https is ok. | [optional] 
**UseSoapInterface** | **string** | When set to **true**, the notifications are sent to your endpoint as SOAP requests.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

