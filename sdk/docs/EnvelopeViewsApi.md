# IO.Swagger.Api.EnvelopeViewsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ViewsPostAccountConsoleView**](EnvelopeViewsApi.md#viewspostaccountconsoleview) | **POST** /v2/accounts/{accountId}/views/console | Returns a URL to the authentication view UI.
[**ViewsPostEnvelopeCorrectView**](EnvelopeViewsApi.md#viewspostenvelopecorrectview) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/views/correct | Returns a URL to the envelope correction UI.
[**ViewsPostEnvelopeEditView**](EnvelopeViewsApi.md#viewspostenvelopeeditview) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/views/edit | Returns a URL to the edit view UI.
[**ViewsPostEnvelopeRecipientView**](EnvelopeViewsApi.md#viewspostenveloperecipientview) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/views/recipient | Returns a URL to the recipient view UI.
[**ViewsPostEnvelopeSenderView**](EnvelopeViewsApi.md#viewspostenvelopesenderview) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/views/sender | Returns a URL to the sender view UI.


<a name="viewspostaccountconsoleview"></a>
# **ViewsPostAccountConsoleView**
> EnvelopeViews ViewsPostAccountConsoleView (string accountId, ConsoleViewRequest consoleViewRequest = null)

Returns a URL to the authentication view UI.

Returns a URL that allows you to embed the authentication view of the DocuSign UI in your applications.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ViewsPostAccountConsoleViewExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeViewsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var consoleViewRequest = new ConsoleViewRequest(); // ConsoleViewRequest |  (optional) 

            try
            {
                // Returns a URL to the authentication view UI.
                EnvelopeViews result = apiInstance.ViewsPostAccountConsoleView(accountId, consoleViewRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeViewsApi.ViewsPostAccountConsoleView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **consoleViewRequest** | [**ConsoleViewRequest**](ConsoleViewRequest.md)|  | [optional] 

### Return type

[**EnvelopeViews**](EnvelopeViews.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewspostenvelopecorrectview"></a>
# **ViewsPostEnvelopeCorrectView**
> EnvelopeViews ViewsPostEnvelopeCorrectView (string accountId, string envelopeId, CorrectViewRequest correctViewRequest = null)

Returns a URL to the envelope correction UI.

Returns a URL that allows you to embed the envelope correction view of the DocuSign UI in your applications.  Important: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ViewsPostEnvelopeCorrectViewExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeViewsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var correctViewRequest = new CorrectViewRequest(); // CorrectViewRequest |  (optional) 

            try
            {
                // Returns a URL to the envelope correction UI.
                EnvelopeViews result = apiInstance.ViewsPostEnvelopeCorrectView(accountId, envelopeId, correctViewRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeViewsApi.ViewsPostEnvelopeCorrectView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelope&#39;s GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec  | 
 **correctViewRequest** | [**CorrectViewRequest**](CorrectViewRequest.md)|  | [optional] 

### Return type

[**EnvelopeViews**](EnvelopeViews.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewspostenvelopeeditview"></a>
# **ViewsPostEnvelopeEditView**
> EnvelopeViews ViewsPostEnvelopeEditView (string accountId, string envelopeId, ReturnUrlRequest returnUrlRequest = null)

Returns a URL to the edit view UI.

Returns a URL that allows you to embed the edit view of the DocuSign UI in your applications. This is a one-time use login token that allows the user to be placed into the DocuSign editing view.   Upon sending completion, the user is returned to the return URL provided by the API application.  Important: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ViewsPostEnvelopeEditViewExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeViewsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var returnUrlRequest = new ReturnUrlRequest(); // ReturnUrlRequest |  (optional) 

            try
            {
                // Returns a URL to the edit view UI.
                EnvelopeViews result = apiInstance.ViewsPostEnvelopeEditView(accountId, envelopeId, returnUrlRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeViewsApi.ViewsPostEnvelopeEditView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelope&#39;s GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec  | 
 **returnUrlRequest** | [**ReturnUrlRequest**](ReturnUrlRequest.md)|  | [optional] 

### Return type

[**EnvelopeViews**](EnvelopeViews.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewspostenveloperecipientview"></a>
# **ViewsPostEnvelopeRecipientView**
> EnvelopeViews ViewsPostEnvelopeRecipientView (string accountId, string envelopeId, RecipientViewRequest recipientViewRequest = null)

Returns a URL to the recipient view UI.

Returns a URL that enables you to embed the recipient view of the DocuSign UI in your applications. If the recipient is a signer, then the view will provide the signing ceremony.  ###### Note: Please redirect the client to the URL. iFrames should not be used, especially if the recipient may be using a mobile or tablet.   This method is only used with envelopes in the `sent` status.  Your application is responsible for authenticating the identity of the recipient or signer when you use this method. Use the parameters `assertionId`, `authenticationInstant`, `authenticationMethod`, `clientUserId`, and `securityDomain` to record information on how the recipient was authenticated. At a minimum, `authenticationMethod` and `clientUserId` are required. The information that you provide is included in the envelope's certificate of completion.  ## The event status parameter After the signer completes or ends the signing ceremony, DocuSign will redirect the user's browser back to your app via the `returnUrl` that you supply. DocuSIgn appends an `event` query parameter to the URL with the outcome of the signing ceremony. Your app should use the event parameter to determine the next step for the envelope. Don't fetch the envelope's status via Envelopes: get or a similar method; that could break the DocuSign rule against polling.  ## The URL is time-limited The URL returned by this method is valid for one use. It must be used/displayed within a couple of minutes after being generated. Once the recipient is redirected to the recipient view, they must interact with the DocuSign system periodically or their session will time out.  Because the URL is time-limited, it should not be stored or sent via email. Immediately redirect the user's browser to the URL after you receive it.  If you want to invite someone to an embedded signing session via email, the email invitation's URL must be to your application. When invoked, your app should request a recipientView URL from DocuSign and then redirect the signer to that URL.  ## Maintaining State After the recipient completes the recipient view (or signing ceremony), they are redirected to your application. Your application can recover state information about the transaction by storing information in a cookie, or by including query parameters in the `returnUrl` field. Eg, `https://myapp.eg.com/docusign_return?myState=12345` When the user is redirected to your app, the `event` query parameter will be appended. In this example, prevent spoofing by not using a guessable value as the state value.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ViewsPostEnvelopeRecipientViewExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeViewsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var recipientViewRequest = new RecipientViewRequest(); // RecipientViewRequest |  (optional) 

            try
            {
                // Returns a URL to the recipient view UI.
                EnvelopeViews result = apiInstance.ViewsPostEnvelopeRecipientView(accountId, envelopeId, recipientViewRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeViewsApi.ViewsPostEnvelopeRecipientView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelope&#39;s GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec  | 
 **recipientViewRequest** | [**RecipientViewRequest**](RecipientViewRequest.md)|  | [optional] 

### Return type

[**EnvelopeViews**](EnvelopeViews.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewspostenvelopesenderview"></a>
# **ViewsPostEnvelopeSenderView**
> EnvelopeViews ViewsPostEnvelopeSenderView (string accountId, string envelopeId, ReturnUrlRequest returnUrlRequest = null)

Returns a URL to the sender view UI.

Returns a URL that enables you to embed the sender view of the DocuSign UI in your applications.   The returned URL can only be redirected to immediately after it is generated. It can only be used once. Therefore, request the URL immediately before you redirect your user to it.  For the best user experience, don't use an iFrame. For iOS devices DocuSign recommends using a WebView.  Multiple solutions are available for maintaining your client state. See the \"Maintaining State\" section of the [Embedded Signing introduction.](../../../../guide/usage/embedded_signing.html#maintaining-state)  After the user has completed the sending view, their browser is redirected to the `returnUrl` you supplied.  By default, if the envelope already contains one or more documents, DocuSign will initially show the document tagging view when you redirect to the URL.   To start with the envelope's recipients and documents view instead, examine the URL in the method's response.  Then change the query parameter from `send=1` to `send=0` to start with the recipients/documents view.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ViewsPostEnvelopeSenderViewExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeViewsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var returnUrlRequest = new ReturnUrlRequest(); // ReturnUrlRequest |  (optional) 

            try
            {
                // Returns a URL to the sender view UI.
                EnvelopeViews result = apiInstance.ViewsPostEnvelopeSenderView(accountId, envelopeId, returnUrlRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeViewsApi.ViewsPostEnvelopeSenderView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelope&#39;s GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec  | 
 **returnUrlRequest** | [**ReturnUrlRequest**](ReturnUrlRequest.md)|  | [optional] 

### Return type

[**EnvelopeViews**](EnvelopeViews.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

