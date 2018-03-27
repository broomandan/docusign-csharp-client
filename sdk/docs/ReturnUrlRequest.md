# IO.Swagger.Model.ReturnUrlRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReturnUrl** | **string** | Your app&#39;s return url that the user will be redirected to after sending the envelope or completing the sending/tagging view. Query parameters &#x60;envelopeId&#x60; and &#x60;event&#x60; will be added to the URL. The event parameter values:   * &#x60;Send&#x60; (the user sent the envelope) * &#x60;Save&#x60; (the user saved the envelope, it is still a draft) * &#x60;Cancel&#x60; (the user canceled the sending transaction) * &#x60;Error&#x60; (there was an error during the send operation) * &#x60;SessionEnd&#x60; (the sending session ended before the user completed a different action) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

