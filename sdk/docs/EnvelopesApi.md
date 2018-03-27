# IO.Swagger.Api.EnvelopesApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuditEventsGetAuditEvents**](EnvelopesApi.md#auditeventsgetauditevents) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/audit_events | Gets the envelope audit events for an envelope.
[**EnvelopesGetEnvelope**](EnvelopesApi.md#envelopesgetenvelope) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId} | Gets the status of a envelope.
[**EnvelopesGetEnvelopes**](EnvelopesApi.md#envelopesgetenvelopes) | **GET** /v2/accounts/{accountId}/envelopes | Gets status changes for one or more envelopes.
[**EnvelopesPostEnvelopes**](EnvelopesApi.md#envelopespostenvelopes) | **POST** /v2/accounts/{accountId}/envelopes | Creates an envelope.
[**EnvelopesPutEnvelope**](EnvelopesApi.md#envelopesputenvelope) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId} | Send Draft Envelope/Void Envelope/Move/Purge Envelope/Modify draft
[**EnvelopesPutStatus**](EnvelopesApi.md#envelopesputstatus) | **PUT** /v2/accounts/{accountId}/envelopes/status | Gets the envelope status for the specified envelopes.
[**NotificationGetEnvelopesEnvelopeIdNotification**](EnvelopesApi.md#notificationgetenvelopesenvelopeidnotification) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/notification | Gets envelope notification information.
[**NotificationPutEnvelopesEnvelopeIdNotification**](EnvelopesApi.md#notificationputenvelopesenvelopeidnotification) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/notification | Sets envelope notification (Reminders/Expirations) structure for an existing envelope.
[**PagesDeletePage**](EnvelopesApi.md#pagesdeletepage) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/pages/{pageNumber} | Deletes a page from a document in an envelope.
[**PagesGetPageImage**](EnvelopesApi.md#pagesgetpageimage) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/pages/{pageNumber}/page_image | Gets a page image from an envelope for display.
[**PagesGetPageImages**](EnvelopesApi.md#pagesgetpageimages) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/pages | Returns document page image(s) based on input.
[**PagesPutPageImage**](EnvelopesApi.md#pagesputpageimage) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/pages/{pageNumber}/page_image | Rotates page image from an envelope for display.
[**RecipientsGetRecipientInitialsImage**](EnvelopesApi.md#recipientsgetrecipientinitialsimage) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/initials_image | Gets the initials image for a user.
[**RecipientsGetRecipientSignature**](EnvelopesApi.md#recipientsgetrecipientsignature) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/signature | Gets signature information for a signer or sign-in-person recipient.
[**RecipientsGetRecipientSignatureImage**](EnvelopesApi.md#recipientsgetrecipientsignatureimage) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/signature_image | Retrieve signature image information for a signer/sign-in-person recipient.
[**RecipientsPutRecipientInitialsImage**](EnvelopesApi.md#recipientsputrecipientinitialsimage) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/initials_image | Sets the initials image for an accountless signer.
[**RecipientsPutRecipientSignatureImage**](EnvelopesApi.md#recipientsputrecipientsignatureimage) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/signature_image | Sets the signature image for an accountless signer.


<a name="auditeventsgetauditevents"></a>
# **AuditEventsGetAuditEvents**
> EnvelopeAuditEventResponse AuditEventsGetAuditEvents (string accountId, string envelopeId)

Gets the envelope audit events for an envelope.

Gets the envelope audit events for the specified envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AuditEventsGetAuditEventsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 

            try
            {
                // Gets the envelope audit events for an envelope.
                EnvelopeAuditEventResponse result = apiInstance.AuditEventsGetAuditEvents(accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.AuditEventsGetAuditEvents: " + e.Message );
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

### Return type

[**EnvelopeAuditEventResponse**](EnvelopeAuditEventResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="envelopesgetenvelope"></a>
# **EnvelopesGetEnvelope**
> Envelopes EnvelopesGetEnvelope (string accountId, string envelopeId, string advancedUpdate = null, string include = null)

Gets the status of a envelope.

Retrieves the overall status for the specified envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EnvelopesGetEnvelopeExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var advancedUpdate = advancedUpdate_example;  // string | When true, envelope information can be added or modified. (optional) 
            var include = include_example;  // string | Reserved for DocuSign.  (optional) 

            try
            {
                // Gets the status of a envelope.
                Envelopes result = apiInstance.EnvelopesGetEnvelope(accountId, envelopeId, advancedUpdate, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.EnvelopesGetEnvelope: " + e.Message );
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
 **advancedUpdate** | **string**| When true, envelope information can be added or modified. | [optional] 
 **include** | **string**| Reserved for DocuSign.  | [optional] 

### Return type

[**Envelopes**](Envelopes.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="envelopesgetenvelopes"></a>
# **EnvelopesGetEnvelopes**
> EnvelopesInformation EnvelopesGetEnvelopes (string accountId, string acStatus = null, string block = null, string count = null, string customField = null, string email = null, string envelopeIds = null, string exclude = null, string folderIds = null, string folderTypes = null, string fromDate = null, string fromToStatus = null, string include = null, string includePurgeInformation = null, string intersectingFolderIds = null, string order = null, string orderBy = null, string powerformids = null, string searchText = null, string startPosition = null, string status = null, string toDate = null, string transactionIds = null, string userFilter = null, string userId = null, string userName = null)

Gets status changes for one or more envelopes.

Retrieves a list of envelopes that match your request.  A large set of optional filters let you filter by date, by envelope ID, or by status codes.  Your request must include one or more of the following parameters:  * `from_date` * `envelope_ids` * `transaction_ids`   Getting envelope status using `transaction_ids` is useful for offline signing situations where it can be used determine if an envelope was created or not. It can be used for the cases where a network connection was lost, before the envelope status could be returned.  To avoid unnecessary database queries, the DocuSign signature platform first checks requests to ensure that the filter set supplied does not result in a zero-size response before querying the database.   For example, for a request with a `from_to_status` of `delivered` and a current `status` of `created,sent`, DocuSign will always return an empty list.  This is because the request translates to: find the envelopes that were delivered between the `from_date` and `to_date` dates that have a current status of `created` or `sent`. Since an envelope that has been delivered can never have a status of `created` or `sent`, a zero-size response would be generated.  In this case, DocuSign does not query the database and returns an empty list immediately.   The following table shows the valid current envelope statuses (`status` parameter) for the different status qualifiers (`from_to_status` parameter) in the request. If the status and status qualifiers in the API request do not contain any of the values shown in the Valid Current Statuses column, then an empty list is returned.  Client applications should check that the statuses (`status` parameter) they are requesting make sense for a given `from_to_status` parameter value.  | Status Qualifier<br>(`from_to_status`) | Effective Status Qualifier | Valid Current Statuses                                                      |   | :- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | :- -- -- -- -- -- -- -- -- -- -- -- -- | :- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - |   | any (changed)                          | StatusChanged              | any, created, sent, delivered, signed, completed, declined, voided, deleted |   | created                                | Created                    | any, created, sent, delivered, signed, completed, declined, voided, deleted |   | sent                                   | Sent                       | any, sent, delivered, signed, completed, declined, voided, deleted          |   | delivered                              | StatusChanged              | any, delivered, signed, completed, declined, voided, deleted                |   | signed                                 | StatusChanged              | any, signed, completed, declined, voided, deleted                           |   | completed                              | Completed                  | any, completed, declined, voided, deleted                                   |   | declined                               | StatusChanged              | any, declined, voided, deleted                                              |   | timedout<br>always return zero results | StatusChanged              | any, voided, deleted                                                        |   | voided                                 | Voided                     | any, voided, deleted                                                        |   | deleted                                | StatusChanged              | any, deleted                                                                |    ## Extraneous results  In some cases, a request for a specific envelope status will include envelopes with additional statuses. For example, in a request with a `from_date` of 2017-01-01, a `to_date` of 2017-01-07 and the status qualifier (`from_to_status`) set to `delivered`, the response set might contain envelopes that were created during that time period, but not delivered during the time period. As a workaround, check the envelope status values in the result set as needed.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EnvelopesGetEnvelopesExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var acStatus = acStatus_example;  // string | Specifies the Authoritative Copy Status for the envelopes. The possible values are: Unknown, Original, Transferred, AuthoritativeCopy, AuthoritativeCopyExportPending, AuthoritativeCopyExported, DepositPending, Deposited, DepositedEO, or DepositFailed. (optional) 
            var block = block_example;  // string | Reserved for DocuSign.  (optional) 
            var count = count_example;  // string | Optional. Number of items to return.  (optional) 
            var customField = customField_example;  // string | Optional. Specifies a envelope custom field name and value searched for in the envelopes. Format: `custom_envelope_field_name=desired_value`  The value portion of the query can use partial strings by adding '%' (percent sign) around the custom field query value.   Example 1: If you have an envelope custom field named \"Region\" and you want to search for all envelopes where the value is \"West\" you would use set this parameter to `Region=West`.   Example 2: To search for envelopes where the `ApplicationID` custom field has the value or partial value of \"DocuSign\" in the field, set this parameter to `ApplicationId=%DocuSign%` This would match envelopes where the custom field's value is \"DocuSign for Salesforce\" or \"DocuSign envelope\".   (optional) 
            var email = email_example;  // string | Limit results to envelopes sent by the account user with this email address.  `user_name` must be given as well, and both `email` and `user_name` must refer to an existing account user.  (optional) 
            var envelopeIds = envelopeIds_example;  // string | Comma separated list of `envelopeId` values. (optional) 
            var exclude = exclude_example;  // string | Reserved for DocuSign.  (optional) 
            var folderIds = folderIds_example;  // string | Reserved for DocuSign.  (optional) 
            var folderTypes = folderTypes_example;  // string | Reserved for DocuSign.  (optional) 
            var fromDate = fromDate_example;  // string | Specifies the date and time to start looking for status changes. This parameter is required unless `envelopeIds` or `transactionIds` are set.   Although you can use any date format supported by the .NET system library's [`DateTime.Parse()`][msoft] function, DocuSign recommends using [ISO 8601][] format dates with an explicit time zone offset If you do not provide a time zone offset, the method uses the server's time zone.  For example, the following dates and times refer to the same instant:  * `2017-05-02T01:44Z` * `2017-05-01T21:44-04:00` * `2017-05-01T18:44-07:00`   [msoft]: https://msdn.microsoft.com/en-us/library/system.datetime.parse(v=vs.110).aspx#StringToParse [ISO 8601]: https://en.wikipedia.org/wiki/ISO_8601 (optional) 
            var fromToStatus = fromToStatus_example;  // string | The status value checked for in the `from_date` to `to_date` time period.   Possible values are: Voided, Changed, Created, Deleted, Sent, Delivered, Signed, Completed, Declined, TimedOut and Processing.  If `Changed` is specified, then envelopes that changed status during the period will be returned.   For example, if `Created` is specified, then envelopes created during the period are found.   The default is `Changed`.  (optional) 
            var include = include_example;  // string | Reserved for DocuSign.  (optional) 
            var includePurgeInformation = includePurgeInformation_example;  // string |  (optional) 
            var intersectingFolderIds = intersectingFolderIds_example;  // string | Reserved for DocuSign.  (optional) 
            var order = order_example;  // string | Reserved for DocuSign.  (optional) 
            var orderBy = orderBy_example;  // string | Reserved for DocuSign.  (optional) 
            var powerformids = powerformids_example;  // string | Reserved for DocuSign.  (optional) 
            var searchText = searchText_example;  // string | Reserved for DocuSign.  (optional) 
            var startPosition = startPosition_example;  // string | Reserved for DocuSign.  (optional) 
            var status = status_example;  // string | A comma-separated list of current envelope statuses to included in the response. Possible values are:  * completed * created * declined * deleted * delivered * processing * sent * signed * timedout * voided  The `any` value is equivalent to any status.   (optional) 
            var toDate = toDate_example;  // string | Specifies the date and time to stop looking for status changes. The default is the current date and time.  Although you can use any date format supported by the .NET system library's [`DateTime.Parse()`][msoft] function, DocuSign recommends using [ISO 8601][] format dates with an explicit time zone offset If you do not provide a time zone offset, the method uses the server's time zone.  For example, the following dates and times refer to the same instant:  * `2017-05-02T01:44Z` * `2017-05-01T21:44-04:00` * `2017-05-01T18:44-07:00`   [msoft]: https://msdn.microsoft.com/en-us/library/system.datetime.parse(v=vs.110).aspx#StringToParse [ISO 8601]: https://en.wikipedia.org/wiki/ISO_8601  (optional) 
            var transactionIds = transactionIds_example;  // string | A comma-separated list of envelope transaction IDs. Transaction IDs are only valid for seven days.  (optional) 
            var userFilter = userFilter_example;  // string | Reserved for DocuSign.  (optional) 
            var userId = userId_example;  // string | Reserved for DocuSign.  (optional) 
            var userName = userName_example;  // string | Limit results to envelopes sent by the account user with this user name.  `email` must be given as well, and both `email` and `user_name` must refer to an existing account user.  (optional) 

            try
            {
                // Gets status changes for one or more envelopes.
                EnvelopesInformation result = apiInstance.EnvelopesGetEnvelopes(accountId, acStatus, block, count, customField, email, envelopeIds, exclude, folderIds, folderTypes, fromDate, fromToStatus, include, includePurgeInformation, intersectingFolderIds, order, orderBy, powerformids, searchText, startPosition, status, toDate, transactionIds, userFilter, userId, userName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.EnvelopesGetEnvelopes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **acStatus** | **string**| Specifies the Authoritative Copy Status for the envelopes. The possible values are: Unknown, Original, Transferred, AuthoritativeCopy, AuthoritativeCopyExportPending, AuthoritativeCopyExported, DepositPending, Deposited, DepositedEO, or DepositFailed. | [optional] 
 **block** | **string**| Reserved for DocuSign.  | [optional] 
 **count** | **string**| Optional. Number of items to return.  | [optional] 
 **customField** | **string**| Optional. Specifies a envelope custom field name and value searched for in the envelopes. Format: &#x60;custom_envelope_field_name&#x3D;desired_value&#x60;  The value portion of the query can use partial strings by adding &#39;%&#39; (percent sign) around the custom field query value.   Example 1: If you have an envelope custom field named \&quot;Region\&quot; and you want to search for all envelopes where the value is \&quot;West\&quot; you would use set this parameter to &#x60;Region&#x3D;West&#x60;.   Example 2: To search for envelopes where the &#x60;ApplicationID&#x60; custom field has the value or partial value of \&quot;DocuSign\&quot; in the field, set this parameter to &#x60;ApplicationId&#x3D;%DocuSign%&#x60; This would match envelopes where the custom field&#39;s value is \&quot;DocuSign for Salesforce\&quot; or \&quot;DocuSign envelope\&quot;.   | [optional] 
 **email** | **string**| Limit results to envelopes sent by the account user with this email address.  &#x60;user_name&#x60; must be given as well, and both &#x60;email&#x60; and &#x60;user_name&#x60; must refer to an existing account user.  | [optional] 
 **envelopeIds** | **string**| Comma separated list of &#x60;envelopeId&#x60; values. | [optional] 
 **exclude** | **string**| Reserved for DocuSign.  | [optional] 
 **folderIds** | **string**| Reserved for DocuSign.  | [optional] 
 **folderTypes** | **string**| Reserved for DocuSign.  | [optional] 
 **fromDate** | **string**| Specifies the date and time to start looking for status changes. This parameter is required unless &#x60;envelopeIds&#x60; or &#x60;transactionIds&#x60; are set.   Although you can use any date format supported by the .NET system library&#39;s [&#x60;DateTime.Parse()&#x60;][msoft] function, DocuSign recommends using [ISO 8601][] format dates with an explicit time zone offset If you do not provide a time zone offset, the method uses the server&#39;s time zone.  For example, the following dates and times refer to the same instant:  * &#x60;2017-05-02T01:44Z&#x60; * &#x60;2017-05-01T21:44-04:00&#x60; * &#x60;2017-05-01T18:44-07:00&#x60;   [msoft]: https://msdn.microsoft.com/en-us/library/system.datetime.parse(v&#x3D;vs.110).aspx#StringToParse [ISO 8601]: https://en.wikipedia.org/wiki/ISO_8601 | [optional] 
 **fromToStatus** | **string**| The status value checked for in the &#x60;from_date&#x60; to &#x60;to_date&#x60; time period.   Possible values are: Voided, Changed, Created, Deleted, Sent, Delivered, Signed, Completed, Declined, TimedOut and Processing.  If &#x60;Changed&#x60; is specified, then envelopes that changed status during the period will be returned.   For example, if &#x60;Created&#x60; is specified, then envelopes created during the period are found.   The default is &#x60;Changed&#x60;.  | [optional] 
 **include** | **string**| Reserved for DocuSign.  | [optional] 
 **includePurgeInformation** | **string**|  | [optional] 
 **intersectingFolderIds** | **string**| Reserved for DocuSign.  | [optional] 
 **order** | **string**| Reserved for DocuSign.  | [optional] 
 **orderBy** | **string**| Reserved for DocuSign.  | [optional] 
 **powerformids** | **string**| Reserved for DocuSign.  | [optional] 
 **searchText** | **string**| Reserved for DocuSign.  | [optional] 
 **startPosition** | **string**| Reserved for DocuSign.  | [optional] 
 **status** | **string**| A comma-separated list of current envelope statuses to included in the response. Possible values are:  * completed * created * declined * deleted * delivered * processing * sent * signed * timedout * voided  The &#x60;any&#x60; value is equivalent to any status.   | [optional] 
 **toDate** | **string**| Specifies the date and time to stop looking for status changes. The default is the current date and time.  Although you can use any date format supported by the .NET system library&#39;s [&#x60;DateTime.Parse()&#x60;][msoft] function, DocuSign recommends using [ISO 8601][] format dates with an explicit time zone offset If you do not provide a time zone offset, the method uses the server&#39;s time zone.  For example, the following dates and times refer to the same instant:  * &#x60;2017-05-02T01:44Z&#x60; * &#x60;2017-05-01T21:44-04:00&#x60; * &#x60;2017-05-01T18:44-07:00&#x60;   [msoft]: https://msdn.microsoft.com/en-us/library/system.datetime.parse(v&#x3D;vs.110).aspx#StringToParse [ISO 8601]: https://en.wikipedia.org/wiki/ISO_8601  | [optional] 
 **transactionIds** | **string**| A comma-separated list of envelope transaction IDs. Transaction IDs are only valid for seven days.  | [optional] 
 **userFilter** | **string**| Reserved for DocuSign.  | [optional] 
 **userId** | **string**| Reserved for DocuSign.  | [optional] 
 **userName** | **string**| Limit results to envelopes sent by the account user with this user name.  &#x60;email&#x60; must be given as well, and both &#x60;email&#x60; and &#x60;user_name&#x60; must refer to an existing account user.  | [optional] 

### Return type

[**EnvelopesInformation**](EnvelopesInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="envelopespostenvelopes"></a>
# **EnvelopesPostEnvelopes**
> EnvelopeSummary EnvelopesPostEnvelopes (string accountId, string cdseMode = null, string completedDocumentsOnly = null, string mergeRolesOnDraft = null, EnvelopeDefinition envelopeDefinition = null)

Creates an envelope.

Creates and sends an envelope or creates a draft envelope. Envelopes are fundamental resources in the DocuSign platform and are used in a variety of ways.  With this method you can:  * Create and send an envelope   with documents, recipients, and tabs. * Create and send an envelope from a template. * Create and send an envelope from   a combination of documents and templates. * Create a draft envelope.  There are many ways to use envelopes. You can create and send an envelope with a single API request, or you can use several API requests to create, populate, and send envelopes.  When you use this method to create and send an envelope in a single request, the following parameters are required:  | Parameter      | Description | | :- -- -- -- -      | :- -- -- -- -- - | | `status`       | Set to `sent` to send the envelope to recipients.<br>Set to `created` (or don't set at all) to save the envelope as a draft. | | `emailSubject` | The subject of the email used to send the envelope. | | `documents`    | The documents to be signed. | | `recipients`   | The email addresses of the envelope recipients. |  If you are creating an envelope to be sent later, save it as a draft by either setting `status` to `created` or leaving it unset. For instance, you can create a draft envelope with documents only. Using additional API requests, you can add the recipients and send the envelope in subsequent API requests.    ## Feature Availability  Not all DocuSign features are available to all accounts. Use DocuSign Admin to check and enable feature availability. You can also check feature availability via the web application. For example, if the web application allows you to send an envelope with SMS authentication, then you can use the same feature through the API.  ## Sending Envelopes  Documents can be included with the Envelopes:create method, or a template can include documents. Documents can be added by using a multipart/form request or by using the `documentBase64` property of the [`document` object][documentDef].  ### Adding Documents to Requests  There are two ways to add documents to your envelopes:  1. Use the `documents` property of the envelope definition. 2. Send this request as a multipart/form-data `POST`    with documents added through additional request parts.  Using the `documents` property is the simpler option, but the request may be quite large due to the base64 encoding. This example shows how to add a document using this method.  ```json {   \"status\": \"sent\",   \"emailSubject\": \"Example of one recipient, type signer\",   \"documents\": [{     \"documentId\": \"1\",     \"name\": \"contract.pdf\",     \"documentBase64\": \"base64 document bytes...\",   }],   \"recipients\": {     \"signers\": [{       \"name\": \"Lisa Simpson\",       \"email\": \"lisa@email.com\",       \"recipientId\": \"1\",       \"routingOrder\": \"1\",       \"tabs\": {         \"signHereTabs\": [{           \"xPosition\": \"150\",           \"yPosition\": \"200\",           \"documentId\": \"1\",           \"pageNumber\": \"1\"         }],       }     }]   } } ```  If you are using a multipart/form-data `POST` request, you do not have to base64 encode your documents. You place the envelope definition in one part and the document bytes in another:  ``` - -AAA Content-Type: application/json Content-Disposition: form-data  <ENVELOPE DEFINITION GOES HERE> - -AAA Content-Type:application/pdf Content-Disposition: file; filename=\"contract.pdf\"; documentid=1  <DOCUMENT BYTES GO HERE> - -AAA- - ```  ### Using Supplemental Documents  Supplemental documents are supporting materials such as disclosures and other informational documents that need to accompany a document sent for signature. These supplemental documents are available to the signer to view and acknowledge, without making the envelope too large or confusing for signers.  Supplemental documents use the following properties in the [`document` object][documentDef].  | Name                  | Type    | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | | :- -- -- -- -- -- -- -- -- -- - | :- -- -- - | :- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | includeInDownload     | Boolean | When set to **true**, the document is included in the combined document download. The default value is **true**.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | | display               | String  | This string sets the display and behavior properties of the document during signing. The possible values are:<br>`<ul><li><p><code>modal</code><br>The document is shown as a supplement action strip and can be viewed, downloaded, or printed in a modal window. This is the recommended value for supplemental documents.</p></li><li><p><code>download</code><br>The document is shown as a supplement action strip and can be viewed, downloaded, or printed in a new browser window.</p></li><li><p><code>inline</code><br>This value is not used with supplemental documents, but is the default value for all other documents. The document is shown in the normal signing window.</li></ul> | | signerMustAcknowledge | String  | Sets how the signer interacts with the supplemental document. The possible values are:<br><ul><li><p><code>no_interaction</code><br>No recipient action is required.</p></li><li><p><code>view</code><br>The recipient is required to view the document.</p></li><li><p><code>accept</code><br>The recipient is required to accept the document by selecting accept during signing, but is not required to view the document.</p></li><li><p><code>view_accept</code><br>The recipient is required to view and accept the document.</p></li></ul>                                                                                                                                                    |   [viewtab]: /esign/restapi/Envelopes/EnvelopeRecipientTabs/#view-tab  The [View][viewtab] and Approve tabs are used to set the interactions for individual recipients. The View tab includes a `required` property that requires the recipient to view the supplemental document. If the View tab `required` property is not set, the recipient can, but is not required to, view the supplemental document.  To use the View and Approve tabs for supplemental documents, the document `display` property must be set to `modal` or `download`.  The actions that the recipient must take depend on the value of the `signerMustAcknowledge` document property and whether the signer is assigned View or Approve tabs on the document.  To set the interactions for individual recipients, set the `signerMustAcknowledge` property to `no_interaction`, then add View and Approve tabs on the appropriate document for the recipient.   The action that a signer must take depends on the value of the `signerMustAcknowledge` document property, whether the signer has an Approve tab, and the value of the `required` property of the View tab. The following table shows the actions a recipient must take for different combinations of these tabs and properties.    | Document `signerMustAcknowledge`property  | Approve Tab | View Tab `required` property  | Recipient is required to ...  | | :- -- -                                     | :- -- -       | :- -- -                         | :- -- -                         | | no_interaction                            | No          |  - -                           |  Take no action               | | no_interaction                            | No          |  false                        |  Take no action               | | no_interaction                            | No          |  true                         |  View                         | | no_interaction                            | Yes         |  false                        |  Accept                       | | no_interaction                            | Yes         |  true                         |  View and Accept              | | view                                      | No          |  - -                           |  View                         | | view                                      | Yes         |  - -                           |  View and Accept              | | accept                                    | - -          |  false                        |  Accept                       | | accept                                    | - -          |  true                         |  View and Accept              | | view_accept                               | - -          |  - -                           |  View and Accept              |     ### Recipient Types  An [`envelopeDefinition` object][envelopeDef] is used as the method's body. Envelope recipients can be defined in the envelope or in templates. The `envelopeDefinition` object's `recipients` property is an [`EnvelopeRecipients` resource object][envelopeRecipientsDef]. It includes arrays of the seven types of recipients defined by DocuSign:  | Recipient type                      | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | | :- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | :- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | [Agents][agentDef]                  | An agent recipient can add name and email information for recipients that appear after the agent in routing order.                                                                                                                                                                                                                                                                                                                                                                                  | | [Carbon Copies][ccDef]              | Carbon copy recipients get a copy of the envelope but don't need to sign, initial, date or add information to any of the documents. This type of recipient can be used in any routing order. Carbon copy recipients receive their copy of the envelope when the envelope reaches the recipient's order in the process flow and when the envelope is completed.                                                                                                                                      | | [Certified Deliveries][certfiedDef] | Certified delivery recipients must receive the completed documents for the envelope to be completed. However, they don't need to sign, initial, date or add information to any of the documents.                                                                                                                                                                                                                                                                                                    | | [Editors][editorDef]                | Editors have the same management and access rights for the envelope as the sender. They can make changes to the envelope as if they were using the Advanced Correct feature. This recipient can add name and email information, add or change the routing order and set authentication options for the remaining recipients. Additionally, this recipient can edit signature/initial tabs and data fields for the remaining recipients. The recipient must have a DocuSign account to be an editor. | | [In-Person Signers][inPersonDef]    | An in-person recipient is a DocuSign user, acting as a Signing Host, who is in the same physical location as the signer.                                                                                                                                                                                                                                                                                                                                                                            | | [Intermediaries][intermediaryDef]   | An intermediary is a recipient who can, but is not required to, add name and email information for recipients at the same or subsequent level in the routing order, unless subsequent agents, editors or intermediaries are added.                                                                                                                                                                                                                                                                  | | [Signers][signerDef]                | A signer is a recipient who must sign, initial, date, or add data to form fields on the documents in the envelope.                                                                                                                                                                                                                                                                                                                                                                                  |   Additional information about the different types of recipients is available from the [`EnvelopeRecipients` resource page][envelopeRecipientsRes] and from the Developer Center [Recipients][devecenterrecipients] topic.    ### Tabs  Tabs (also referred to as tags and fields in the web application), can be defined in the `envelopeDefinition`, in templates, by transforming PDF Form Fields, or by using Composite Templates (see below).  The `inPersonSigner`, and `signer` recipient objects include a `tabs` property. It is an [`EnvelopeRecipientTabs` resource object][envRecipientTabsDef] that includes arrays of the different tab types available. See the [`EnvelopeRecipientTabs` resource][envRecipientTabsRes] for more information.   ## Using Templates  Envelopes use specific people or groups as recipients. Templates can specify a role, eg `account_manager.` When a template is used in an envelope, the roles must be replaced with specific people or groups.  When you create an envelope using a `templateId`, the different recipient type objects within the [`EnvelopeRecipients` property][envelopeRecipientsDef] are used to assign recipients to the template's roles via the `roleName` property. The recipient objects can also override settings that were specified in the template, and set values for tab fields that were defined in the template.  ### Message Lock  When a template is added or applied to an envelope, and the template has a locked email subject and message, that subject and message are used for the envelope and cannot be changed even if another locked template is subsequently added or applied to the envelope. The `messageLock` property is used to lock the email subject and message.  If an email subject or message is entered before adding or applying a template with `messageLock` set to **true**, the email subject and message is overwritten with the locked email subject and message from the template.  ## Envelope Status  The status of sent envelopes can be determined through the DocuSign webhook system or by polling. Webhooks are highly recommended: they provide your application with the quickest updates when an envelope's status changes. DocuSign limits polling to once every 15 minutes or less frequently. See [API Rules and Limits][apirules] for more information and examples.   When a webhook is used, DocuSign calls your application via the URL you provide, with a notification XML message.  See the [Webhook recipe](https://www.docusign.com/developer-center/recipes/webhook-status) for examples and live demos of using webhooks.  ## Webhook Options  The two webhook options, `eventNotification` and Connect, use the same notification mechanism and message formats. Use `eventNotification` to create a webhook for a specific envelope sent via the API. Connect webhooks can be used for any envelope sent from an account, from any user, from any client. The [Connect guide][connectGuide] discusses the webhook notification message format.  ### eventNotification Webhooks  The Envelopes:create method includes an optional [`eventNotification` object][eventNotificationDef] property that adds a webhook to the envelope. `eventNotification` webhooks are available for all DocuSign accounts with API access.  ### Connect Webhooks  Connect can be used to create a webhook for all envelopes sent by all users in an account, either through the API or through other DocuSign clients (web, mobile, etc). Connect configurations are independent of specific envelopes. A Connect configuration includes a filter that may be used to limit the webhook to specific users, envelope statuses, etc.  You can create and manage Connect configurations with the [ConnectConfigurations resource][connectConfigurationsRes]. Configurations can also be created and managed from DocuSign Admin accessed by selecting **Go to Admin** from the menu next to your picture on the DocuSign web app. See the **Connect** topic in the **Integrations** section of DocuSign Admin. For repeatability, and to minimize support questions, creating Connect configurations via the API is recommended, especially for ISVs.  Connect is available for some DocuSign account types. Please contact DocuSign Sales for more information.  ## Composite Templates  The Composite Templates feature, like [compositing in film production](https://en.wikipedia.org/wiki/Compositing), enables you to overlay document, recipient, and tab definitions from multiple sources, including PDF Form Field definitions, templates defined on the server, and more.  Each Composite Template consists of optional elements: server templates, inline templates, PDF Metadata templates, and documents.  * The Composite Template ID is an optional element used to identify the   composite template. It is used as a reference when adding document   object information via a multipart HTTP message. If used, the document   content-disposition must include the `compositeTemplateId` to which the   document should be added. If `compositeTemplateId` is not specified in   the content-disposition, the document is applied based on the   `documentId` only. If no document object is specified, the composite   template inherits the first document.  * Server Templates are server-side templates stored on the DocuSign   platform. If supplied, they are overlaid into the envelope in the order   of their Sequence value.  * Inline Templates provide a container to add documents, recipients,   tabs, and custom fields. If inline templates are supplied, they are   overlaid into the envelope in the order of their Sequence value.  * Document objects are optional structures that provide a container to   pass in a document or form. If this object is not included, the   composite template inherits the *first* document it finds from a server   template or inline template, starting with the lowest sequence value.  PDF Form objects are only transformed from the document object. DocuSign does not derive PDF form properties from server templates or inline templates. To instruct DocuSign to transform fields from the PDF form, set `transformPdfFields` to **true** for the document.  See [PDF Form Field Transformation](#pdf-form-field-transformation) for more information about process.  * PDF Metadata Templates provide a container to embed design-time   template information into a PDF document. DocuSign uses this information   when processing the Envelope. This convention allows the document to   carry the signing instructions with it, so that less information needs   to be provided at run-time through an inline template or synchronized   with an external structure like a server template. PDF Metadata   templates are stored in the Metadata layer of a PDF in accordance with   Acrobat's XMP specification. DocuSign will only find PDF Metadata   templates inside documents passed in the Document object (see below). If   supplied, the PDF metadata template will be overlaid into the envelope   in the order of its Sequence value.  ### Compositing the Definitions  Each Composite Template adds a new document and templates overlay into the envelope. For each Composite Template these rules are applied:  * Templates are overlaid in the order of their Sequence value. * If Document is not passed into the Composite Template's `document`   field, the *first* template's document (based on the template's Sequence   value) is used. * Last in wins in all cases except for the document (i.e. envelope   information, recipient information, secure field information). There is   no special casing.  For example, if you want higher security on a tab, then that needs to be specified in a later template (by sequence number) than where the tab is included. If you want higher security on a role recipient, then it needs to be in a later template than where that role recipient is specified.  * Recipient matching is based on Recipient Role and Routing Order. If   there are matches, the recipient information is merged together. A final   pass is done on all Composite Templates, after all template overlays   have been applied, to collapse recipients with the same email, username   and routing order. This prevents having the same recipients at the same   routing order.  * If you specify in a template that a recipient is locked, once that   recipient is overlaid the recipient attributes can no longer be changed.   The only items that can be changed for the recipient in this case are   the email, username, access code and IDCheckInformationInput.  * Tab matching is based on Tab Labels, Tab Types and Documents. If a Tab   Label matches but the Document is not supplied, the Tab is overlaid for   all the Documents.  For example, if you have a simple inline template with only one tab in it with a label and a value, the Signature, Initial, Company, Envelope ID, User Name tabs will only be matched and collapsed if they fall in the exact same X and Y locations.  * `roleName` and `tabLabel` matching is case sensitive.  * The `defaultRecipient` property enables you to specify which recipient   the tabs generated from a PDF form are mapped to. You can also set PDF   form generated tabs to a recipient other than the default recipient by   specifying the mapping of the tab label that is created to one of the   template recipients.  * You can use `tabLabel` wild carding to map a series of tabs from the PDF   form. To use this you must end a tab label with \"\\*\" and then the system   matches tabs that start with the label.  * If no `defaultRecipient` is specified, tabs must be explicitly mapped   to recipients in order to be generated from the form. Unmapped form   objects will not be generated into their DocuSign equivalents. (In the   case of Signature/Initials, the tabs will be disregarded entirely; in   the case of pdf text fields, the field data will be flattened on the   Envelope document, but there will not be a corresponding DocuSign data   tab.)  ### Including the Document Content for Composite Templates  Document content can be supplied inline, using the `documentBase64` or can be included in a multipart HTTP message. If a multipart message is used and there are multiple Composite Templates, the document content-disposition can include the `compositeTemplateId` to which the document should be added. Using the `compositeTemplateId` sets which documents are associated with particular composite templates. An example of this usage is:  ``` - -5cd3320a-5aac-4453-b3a4-cbb52a4cba5d Content-Type: application/pdf Content-Disposition: file; filename=\"eula.pdf\"; documentId=1; compositeTemplateId=\"1\" Content-Transfer-Encoding: base64 ```  ### PDF Form Field Transformation  Only the following PDF Form FieldTypes are transformed to DocuSign tabs:  * CheckBox * DateTime * ListBox * Numeric * Password * Radio * Signature, * Text  Field Properties that are transformed:  * Read Only * Required * Max Length * Positions * Initial Data  When transforming a PDF Form Digital Signature Field, the following rules apply. Any other PDF Form Digital Signature Field will be transformed to a DocuSign Signature tab   | If the PDF Field Name contains                              | Then the DocuSign tab will be | | :- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | :- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | DocuSignSignHere or<br> eSignSignHere                       | Signature                     | | DocuSignSignHereOptional or<br> eSignSignHereOptional       | Optional Signature            | | DocuSignInitialHere or<br> eSignInitialHere                 | Initials                      | | DocuSignInitialHereOptional or<br> eSignInitialHereOptional | Optional Initials             |   When transforming PDF Form Text Fields, the following rules apply. Any other PDF Form Text Field will be transformed to a DocuSign data (text) tab.   | If the PDF Field Name contains                                        | Then the DocuSign tab will be | | :- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | :- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | DocuSignSignHere or<br> eSignSignHere                                 | Signature                     | | DocuSignSignHereOptional or<br> eSignSignHereOptional                 | Optional Signature            | | DocuSignInitialHere or<br> eSignInitialHere                           | Initials                      | | DocuSignInitialHereOptional or<br> eSignInitialHereOptional           | Optional Initials             | | DocuSignEnvelopeID or<br> eSignEnvelopeID                             | EnvelopeID                    | | DocuSignCompany or<br> eSignCompany                                   | Company                       | | DocuSignDateSigned or<br> eSignDateSigned                             | Date Signed                   | | DocuSignTitle or<br> eSignTitle                                       | Title                         | | DocuSignFullName or<br> eSignFullName                                 | Full Name                     | | DocuSignSignerAttachmentOptional or<br> eSignSignerAttachmentOptional | Optional Signer Attachment    |   PDF Form Field Names that include `DocuSignIgnoreTransform` or `eSignIgnoreTransform` will not be transformed.  PDF Form Date fields that include `DocuSignDateSigned` or `eSignDateSigned` will be transformed to Date Signed fields.  ## Template Email Subject Merge Fields  This feature enables you to insert recipient name and email address merge fields into the email subject line when creating or sending from a template.  The merge fields, based on the recipient's `roleName`, are added to the `emailSubject` when the template is created or when the template is used to create an envelope. After a template sender adds the name and email information for the recipient and sends the envelope, the recipient information is automatically merged into the appropriate fields in the email subject line.  Both the sender and the recipients will see the information in the email subject line for any emails associated with the template. This provides an easy way for senders to organize their envelope emails without having to open an envelope to check the recipient.  If merging the recipient information into the subject line causes the subject line to exceed 100 characters, then any characters over the 100 character limit are not included in the subject line. For cases where the recipient name or email is expected to be long, you should consider placing the merge field at the start of the email subject.  * To add a recipient's name in the subject line add the following text   in the `emailSubject` when creating the template or when sending an   envelope from a template:     `[[<roleName>_UserName]]`     Example:     `\"emailSubject\":\"[[Signer 1_UserName]], Please sign this NDA\"`  * To add a recipient's email address in the subject line add the   following text in the emailSubject when creating the template or when   sending an envelope from a template:     `[[<roleName>_Email]]`     Example:     `\"emailSubject\":\"[[Signer 1_Email]], Please sign this NDA\"`  In both cases `<roleName>` is the recipient's `roleName` in the template.  For cases where another recipient (such as an Agent, Editor, or Intermediary recipient) is entering the name and email information for the recipient included in the email subject, then `[[<roleName>_UserName]]` or `[[<roleName>_Email]]` is shown in the email subject.  ## Branding an Envelope  The following rules are used to determine the `brandId` used in an envelope:  * If a `brandId` is specified in the envelope or template   and that `brandId` is available to the account,   that brand is used in the envelope. * If more than one template is used in an envelope,   and more than one `brandId` is specified,   the first `brandId` specified is used throughout the envelope. * In cases where no brand is specified,   and the sender belongs to a group:   - If there is only one brand associated with the group,     then that brand is used in the envelope.   - Otherwise, the account's default signing brand is used. * For envelopes that do not meet any of the previous criteria,   the account's default signing brand is used for the envelope.   ## BCC Email Address Feature  The BCC Email address feature is designed to provide a copy of all email communications for external archiving purposes. DocuSign recommends that envelopes sent using the BCC for Email Archive feature, including the BCC Email Override option, include additional signer authentication options.  Do **not** use this feature to send a copy of the envelope to a recipient who does not need to sign. Use a Carbon Copy or Certified Delivery Recipient type instead.  ## Merge Recipient Roles for Draft Envelopes  When an envelope with multiple templates is sent, the recipients from the templates are merged according to the template roles, and empty recipients are removed. When creating an envelope with multiple templates, but not sending it (keeping it in a created state), duplicate recipients are not merged, which could leave duplicate recipients in the envelope.  To prevent this, the query parameter `merge_roles_on_draft` should be added when posting a draft envelope (`status` is `created`) with multiple templates. Doing this will merge template roles and remove empty recipients.   DocuSign recommends that the `merge_roles_on_draft` query parameter be used any time you are creating an envelope with multiple templates and keeping it in draft (`status` is `created`) status.   [agentDef]:                 #/definitions/agent [apirules]:                 /esign/guide/appendix/resource_limits.html#api-rules-and-limits [ccDef]:                     #/definitions/carbonCopy [certfiedDef]:               #/definitions/certifiedDelivery [connectConfigurationsRes]: /esign/restapi/Connect/ConnectConfigurations/ [connectGuide]:             https://www.docusign.com/supportdocs/pdf/connect-guide.pdf [devecenterrecipients]:     https://www.docusign.com/developer-center/explore/features/recipients [documentDef]:               #/definitions/document [editorDef]:                 #/definitions/editor [envelopeDef]:               #/definitions/envelopeDefinition [envelopeRecipientsDef]:     #/definitions/EnvelopeRecipients [envelopeRecipientsRes]:    /esign/restapi/Envelopes/EnvelopeRecipients/ [envRecipientTabsDef]:       #/definitions/EnvelopeRecipientTabs [envRecipientTabsRes]:      /esign/restapi/Envelopes/EnvelopeRecipientTabs/ [eventNotificationDef]:      #/definitions/eventNotification [inPersonDef]:               #/definitions/inPersonSigner [intermediaryDef]:           #/definitions/intermediary [signerDef]:                 #/definitions/signer 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EnvelopesPostEnvelopesExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var cdseMode = cdseMode_example;  // string | Reserved for DocuSign.  (optional) 
            var completedDocumentsOnly = completedDocumentsOnly_example;  // string | Reserved for DocuSign.  (optional) 
            var mergeRolesOnDraft = mergeRolesOnDraft_example;  // string | When set to **true**, template roles will be merged, and empty recipients will be removed. This parameter applies when you create a draft envelope with multiple templates. (To create a draft envelope, the `status` field is set to `created`.)  ###### Note: DocuSign recommends that this parameter should be set to **true** whenever you create a draft envelope with multiple templates. (optional) 
            var envelopeDefinition = new EnvelopeDefinition(); // EnvelopeDefinition |  (optional) 

            try
            {
                // Creates an envelope.
                EnvelopeSummary result = apiInstance.EnvelopesPostEnvelopes(accountId, cdseMode, completedDocumentsOnly, mergeRolesOnDraft, envelopeDefinition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.EnvelopesPostEnvelopes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **cdseMode** | **string**| Reserved for DocuSign.  | [optional] 
 **completedDocumentsOnly** | **string**| Reserved for DocuSign.  | [optional] 
 **mergeRolesOnDraft** | **string**| When set to **true**, template roles will be merged, and empty recipients will be removed. This parameter applies when you create a draft envelope with multiple templates. (To create a draft envelope, the &#x60;status&#x60; field is set to &#x60;created&#x60;.)  ###### Note: DocuSign recommends that this parameter should be set to **true** whenever you create a draft envelope with multiple templates. | [optional] 
 **envelopeDefinition** | [**EnvelopeDefinition**](EnvelopeDefinition.md)|  | [optional] 

### Return type

[**EnvelopeSummary**](EnvelopeSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="envelopesputenvelope"></a>
# **EnvelopesPutEnvelope**
> EnvelopeUpdateSummary EnvelopesPutEnvelope (string accountId, string envelopeId, string advancedUpdate = null, string resendEnvelope = null, Envelopes envelopes = null)

Send Draft Envelope/Void Envelope/Move/Purge Envelope/Modify draft

The Put Envelopes endpoint provides the following functionality:  * Sends the specified single draft envelope. Add {\"status\":\"sent\"} to the request body to send the envelope.  * Voids the specified in-process envelope. Add {\"status\":\"voided\", \"voidedReason\":\"The reason for voiding the envelope\"} to the request body to void the envelope.  * Replaces the current email subject and message for a draft envelope. Add {\"emailSubject\":\"subject\",  \"emailBlurb\":\"message\"}  to the request body to modify the subject and message.  * Place the envelope documents and envelope metadata in a purge queue so that this information is removed from the DocuSign system. Add {\"purgeState\":\"purge type\"} to the request body.  *Additional information on purging documents*  The purge request can only be used for completed envelopes that are not marked as the authoritative copy. The requesting user must have permission to purge documents and must be the sender (the requesting user can act as the sender using Send On Behalf Of).  ###### Note: If you have set the Document Retention policy on your account, envelope documents are automatically placed in the purge queue and the warning emails are sent at the end of the retention period.  ###### Note: You can set the Document Retention policy in the Classic DocuSign Experience by specifying the number of days to retain documents.  ###### Note: Setting a Document Retention policy is the same as setting a schedule for purging documents.  When the purge request is initiated the envelope documents, or documents and envelope metadata, are placed in a purge queue for deletion in 14 days. A warning email notification is sent to the sender and recipients associated with the envelope, notifying them that the envelope documents will be deleted in 14 days and providing a link to the documents. A second email is sent 7 days later with the same message. At the end of the 14-day period, the envelope documents are deleted from the system.  If `purgeState=\"documents_queued\"` is used in the request, then only the documents are deleted and any corresponding attachments and tabs remain in the DocuSign system. If `purgeState= \"documents_and_metadata_queued\"` is used in the request, then the documents, attachments, and tabs are deleted.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EnvelopesPutEnvelopeExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var advancedUpdate = advancedUpdate_example;  // string | When set to **true**, allows the caller to update recipients, tabs, custom fields, notification, email settings and other envelope attributes. (optional) 
            var resendEnvelope = resendEnvelope_example;  // string | When set to **true**, sends the specified envelope again. (optional) 
            var envelopes = new Envelopes(); // Envelopes |  (optional) 

            try
            {
                // Send Draft Envelope/Void Envelope/Move/Purge Envelope/Modify draft
                EnvelopeUpdateSummary result = apiInstance.EnvelopesPutEnvelope(accountId, envelopeId, advancedUpdate, resendEnvelope, envelopes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.EnvelopesPutEnvelope: " + e.Message );
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
 **advancedUpdate** | **string**| When set to **true**, allows the caller to update recipients, tabs, custom fields, notification, email settings and other envelope attributes. | [optional] 
 **resendEnvelope** | **string**| When set to **true**, sends the specified envelope again. | [optional] 
 **envelopes** | [**Envelopes**](Envelopes.md)|  | [optional] 

### Return type

[**EnvelopeUpdateSummary**](EnvelopeUpdateSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="envelopesputstatus"></a>
# **EnvelopesPutStatus**
> EnvelopesInformation EnvelopesPutStatus (string accountId, string email = null, string fromDate = null, string startPosition = null, string toDate = null, EnvelopeIdsRequest envelopeIdsRequest = null)

Gets the envelope status for the specified envelopes.

Retrieves the envelope status for the specified envelopes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EnvelopesPutStatusExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var email = email_example;  // string | Reserved for DocuSign.  (optional) 
            var fromDate = fromDate_example;  // string | The date/time setting that specifies when the request begins checking for status changes for envelopes in the account.  This is required unless parameters `envelopeIds` and/or `transactionIds` are set. (optional) 
            var startPosition = startPosition_example;  // string | Reserved for DocuSign.  (optional) 
            var toDate = toDate_example;  // string | Optional date/time setting that specifies the last date/time  or envelope status changes in the result set.   Default: \"now\", the time that you call the method.   (optional) 
            var envelopeIdsRequest = new EnvelopeIdsRequest(); // EnvelopeIdsRequest |  (optional) 

            try
            {
                // Gets the envelope status for the specified envelopes.
                EnvelopesInformation result = apiInstance.EnvelopesPutStatus(accountId, email, fromDate, startPosition, toDate, envelopeIdsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.EnvelopesPutStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **email** | **string**| Reserved for DocuSign.  | [optional] 
 **fromDate** | **string**| The date/time setting that specifies when the request begins checking for status changes for envelopes in the account.  This is required unless parameters &#x60;envelopeIds&#x60; and/or &#x60;transactionIds&#x60; are set. | [optional] 
 **startPosition** | **string**| Reserved for DocuSign.  | [optional] 
 **toDate** | **string**| Optional date/time setting that specifies the last date/time  or envelope status changes in the result set.   Default: \&quot;now\&quot;, the time that you call the method.   | [optional] 
 **envelopeIdsRequest** | [**EnvelopeIdsRequest**](EnvelopeIdsRequest.md)|  | [optional] 

### Return type

[**EnvelopesInformation**](EnvelopesInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationgetenvelopesenvelopeidnotification"></a>
# **NotificationGetEnvelopesEnvelopeIdNotification**
> Notification NotificationGetEnvelopesEnvelopeIdNotification (string accountId, string envelopeId)

Gets envelope notification information.

Retrieves the envelope notification, reminders and expirations, information for an existing envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class NotificationGetEnvelopesEnvelopeIdNotificationExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 

            try
            {
                // Gets envelope notification information.
                Notification result = apiInstance.NotificationGetEnvelopesEnvelopeIdNotification(accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.NotificationGetEnvelopesEnvelopeIdNotification: " + e.Message );
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

### Return type

[**Notification**](Notification.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationputenvelopesenvelopeidnotification"></a>
# **NotificationPutEnvelopesEnvelopeIdNotification**
> Notification NotificationPutEnvelopesEnvelopeIdNotification (string accountId, string envelopeId, EnvelopeNotificationRequest envelopeNotificationRequest = null)

Sets envelope notification (Reminders/Expirations) structure for an existing envelope.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class NotificationPutEnvelopesEnvelopeIdNotificationExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var envelopeNotificationRequest = new EnvelopeNotificationRequest(); // EnvelopeNotificationRequest |  (optional) 

            try
            {
                // Sets envelope notification (Reminders/Expirations) structure for an existing envelope.
                Notification result = apiInstance.NotificationPutEnvelopesEnvelopeIdNotification(accountId, envelopeId, envelopeNotificationRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.NotificationPutEnvelopesEnvelopeIdNotification: " + e.Message );
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
 **envelopeNotificationRequest** | [**EnvelopeNotificationRequest**](EnvelopeNotificationRequest.md)|  | [optional] 

### Return type

[**Notification**](Notification.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pagesdeletepage"></a>
# **PagesDeletePage**
> void PagesDeletePage (string accountId, string documentId, string envelopeId, string pageNumber)

Deletes a page from a document in an envelope.

Deletes a page from a document in an envelope based on the page number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PagesDeletePageExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var pageNumber = pageNumber_example;  // string | The page number being accessed.

            try
            {
                // Deletes a page from a document in an envelope.
                apiInstance.PagesDeletePage(accountId, documentId, envelopeId, pageNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.PagesDeletePage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **documentId** | **string**| The ID of the document being accessed. | 
 **envelopeId** | **string**| The envelope&#39;s GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec  | 
 **pageNumber** | **string**| The page number being accessed. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pagesgetpageimage"></a>
# **PagesGetPageImage**
> System.IO.Stream PagesGetPageImage (string accountId, string documentId, string envelopeId, string pageNumber, string dpi = null, string maxHeight = null, string maxWidth = null, string showChanges = null)

Gets a page image from an envelope for display.

Retrieves a page image for display from the specified envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PagesGetPageImageExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var pageNumber = pageNumber_example;  // string | The page number being accessed.
            var dpi = dpi_example;  // string | Sets the dpi for the image. (optional) 
            var maxHeight = maxHeight_example;  // string | Sets the maximum height for the page image in pixels. The dpi is recalculated based on this setting. (optional) 
            var maxWidth = maxWidth_example;  // string | Sets the maximum width for the page image in pixels. The dpi is recalculated based on this setting. (optional) 
            var showChanges = showChanges_example;  // string |  (optional) 

            try
            {
                // Gets a page image from an envelope for display.
                System.IO.Stream result = apiInstance.PagesGetPageImage(accountId, documentId, envelopeId, pageNumber, dpi, maxHeight, maxWidth, showChanges);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.PagesGetPageImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **documentId** | **string**| The ID of the document being accessed. | 
 **envelopeId** | **string**| The envelope&#39;s GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec  | 
 **pageNumber** | **string**| The page number being accessed. | 
 **dpi** | **string**| Sets the dpi for the image. | [optional] 
 **maxHeight** | **string**| Sets the maximum height for the page image in pixels. The dpi is recalculated based on this setting. | [optional] 
 **maxWidth** | **string**| Sets the maximum width for the page image in pixels. The dpi is recalculated based on this setting. | [optional] 
 **showChanges** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/png

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pagesgetpageimages"></a>
# **PagesGetPageImages**
> PageImages PagesGetPageImages (string accountId, string documentId, string envelopeId, string count = null, string dpi = null, string maxHeight = null, string maxWidth = null, string nocache = null, string showChanges = null, string startPosition = null)

Returns document page image(s) based on input.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PagesGetPageImagesExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var count = count_example;  // string | The maximum number of results to be returned by this request. (optional) 
            var dpi = dpi_example;  // string | Number of dots per inch for the resulting image. The default if not used is 94. The range is 1-310. (optional) 
            var maxHeight = maxHeight_example;  // string | Sets the maximum height (in pixels) of the returned image. (optional) 
            var maxWidth = maxWidth_example;  // string | Sets the maximum width (in pixels) of the returned image. (optional) 
            var nocache = nocache_example;  // string |  (optional) 
            var showChanges = showChanges_example;  // string |  (optional) 
            var startPosition = startPosition_example;  // string | The position within the total result set from which to start returning values. The value **thumbnail** may be used to return the page image. (optional) 

            try
            {
                // Returns document page image(s) based on input.
                PageImages result = apiInstance.PagesGetPageImages(accountId, documentId, envelopeId, count, dpi, maxHeight, maxWidth, nocache, showChanges, startPosition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.PagesGetPageImages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **documentId** | **string**| The ID of the document being accessed. | 
 **envelopeId** | **string**| The envelope&#39;s GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec  | 
 **count** | **string**| The maximum number of results to be returned by this request. | [optional] 
 **dpi** | **string**| Number of dots per inch for the resulting image. The default if not used is 94. The range is 1-310. | [optional] 
 **maxHeight** | **string**| Sets the maximum height (in pixels) of the returned image. | [optional] 
 **maxWidth** | **string**| Sets the maximum width (in pixels) of the returned image. | [optional] 
 **nocache** | **string**|  | [optional] 
 **showChanges** | **string**|  | [optional] 
 **startPosition** | **string**| The position within the total result set from which to start returning values. The value **thumbnail** may be used to return the page image. | [optional] 

### Return type

[**PageImages**](PageImages.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pagesputpageimage"></a>
# **PagesPutPageImage**
> void PagesPutPageImage (string accountId, string documentId, string envelopeId, string pageNumber, PageRequest pageRequest = null)

Rotates page image from an envelope for display.

Rotates page image from an envelope for display. The page image can be rotated to the left or right.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PagesPutPageImageExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var pageNumber = pageNumber_example;  // string | The page number being accessed.
            var pageRequest = new PageRequest(); // PageRequest |  (optional) 

            try
            {
                // Rotates page image from an envelope for display.
                apiInstance.PagesPutPageImage(accountId, documentId, envelopeId, pageNumber, pageRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.PagesPutPageImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **documentId** | **string**| The ID of the document being accessed. | 
 **envelopeId** | **string**| The envelope&#39;s GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec  | 
 **pageNumber** | **string**| The page number being accessed. | 
 **pageRequest** | [**PageRequest**](PageRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsgetrecipientinitialsimage"></a>
# **RecipientsGetRecipientInitialsImage**
> System.IO.Stream RecipientsGetRecipientInitialsImage (string accountId, string envelopeId, string recipientId, string includeChrome = null)

Gets the initials image for a user.

Retrieves the initials image for the specified user. The image is returned in the same format as it was uploaded. In the request you can specify if the chrome (the added line and identifier around the initial image) is returned with the image.  The userId specified in the endpoint must match the authenticated user's user id and the user must be a member of the account.  The `signatureIdOrName` paramter accepts signature ID or signature name. DocuSign recommends you use signature ID (`signatureId`), since some names contain characters that do not properly URL encode. If you use the user name, it is likely that the name includes spaces and you might need to URL encode the name before using it in the endpoint.   For example: \"Bob Smith\" to \"Bob%20Smith\"  Older envelopes might only contain chromed images. If getting the non-chromed image fails, try getting the chromed image.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsGetRecipientInitialsImageExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.
            var includeChrome = includeChrome_example;  // string | The added line and identifier around the initial image. Note: Older envelopes might only have chromed images. If getting the non-chromed image fails, try getting the chromed image. (optional) 

            try
            {
                // Gets the initials image for a user.
                System.IO.Stream result = apiInstance.RecipientsGetRecipientInitialsImage(accountId, envelopeId, recipientId, includeChrome);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.RecipientsGetRecipientInitialsImage: " + e.Message );
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
 **recipientId** | **string**| The &#x60;recipientId&#x60; used when the envelope or template was created. | 
 **includeChrome** | **string**| The added line and identifier around the initial image. Note: Older envelopes might only have chromed images. If getting the non-chromed image fails, try getting the chromed image. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/gif

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsgetrecipientsignature"></a>
# **RecipientsGetRecipientSignature**
> UserSignatures RecipientsGetRecipientSignature (string accountId, string envelopeId, string recipientId)

Gets signature information for a signer or sign-in-person recipient.

Retrieves signature information for a signer or sign-in-person recipient.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsGetRecipientSignatureExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.

            try
            {
                // Gets signature information for a signer or sign-in-person recipient.
                UserSignatures result = apiInstance.RecipientsGetRecipientSignature(accountId, envelopeId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.RecipientsGetRecipientSignature: " + e.Message );
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
 **recipientId** | **string**| The &#x60;recipientId&#x60; used when the envelope or template was created. | 

### Return type

[**UserSignatures**](UserSignatures.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsgetrecipientsignatureimage"></a>
# **RecipientsGetRecipientSignatureImage**
> System.IO.Stream RecipientsGetRecipientSignatureImage (string accountId, string envelopeId, string recipientId, string includeChrome = null)

Retrieve signature image information for a signer/sign-in-person recipient.

Retrieves the specified user signature image. The image is returned in the same format as uploaded. In the request you can specify if the chrome (the added line and identifier around the initial image) is returned with the image.  The userId specified in the endpoint must match the authenticated user's user ID and the user must be a member of the account.  The `signatureIdOrName` parameter accepts signature ID or signature name. DocuSign recommends you use signature ID (`signatureId`), since some names contain characters that don't properly URL encode. If you use the user name, it is likely that the name includes spaces and you might need to URL encode the name before using it in the endpoint.   For example: \"Bob Smith\" to \"Bob%20Smith\"  Older envelopes might only have chromed images. If getting the non-chromed image fails, try getting the chromed image.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsGetRecipientSignatureImageExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.
            var includeChrome = includeChrome_example;  // string | When set to **true**, indicates the chromed version of the signature image should be retrieved. (optional) 

            try
            {
                // Retrieve signature image information for a signer/sign-in-person recipient.
                System.IO.Stream result = apiInstance.RecipientsGetRecipientSignatureImage(accountId, envelopeId, recipientId, includeChrome);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.RecipientsGetRecipientSignatureImage: " + e.Message );
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
 **recipientId** | **string**| The &#x60;recipientId&#x60; used when the envelope or template was created. | 
 **includeChrome** | **string**| When set to **true**, indicates the chromed version of the signature image should be retrieved. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/gif

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsputrecipientinitialsimage"></a>
# **RecipientsPutRecipientInitialsImage**
> void RecipientsPutRecipientInitialsImage (string accountId, string envelopeId, string recipientId)

Sets the initials image for an accountless signer.

Updates the initials image for a signer that does not have a DocuSign account. The supported image formats for this file are: gif, png, jpeg, and bmp. The file size must be less than 200K.  For the Authentication/Authorization for this call, the credentials must match the sender of the envelope, the recipient must be an accountless signer or in person signer. The account must have the `CanSendEnvelope` property set to **true** and the `ExpressSendOnly` property in `SendingUser` structure must be set to **false**.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsPutRecipientInitialsImageExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.

            try
            {
                // Sets the initials image for an accountless signer.
                apiInstance.RecipientsPutRecipientInitialsImage(accountId, envelopeId, recipientId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.RecipientsPutRecipientInitialsImage: " + e.Message );
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
 **recipientId** | **string**| The &#x60;recipientId&#x60; used when the envelope or template was created. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recipientsputrecipientsignatureimage"></a>
# **RecipientsPutRecipientSignatureImage**
> void RecipientsPutRecipientSignatureImage (string accountId, string envelopeId, string recipientId)

Sets the signature image for an accountless signer.

Updates the signature image for an accountless signer. The supported image formats for this file are: gif, png, jpeg, and bmp. The file size must be less than 200K.  For the Authentication/Authorization for this call, the credentials must match the sender of the envelope, the recipient must be an accountless signer or in person signer. The account must have the `CanSendEnvelope` property set to **true** and the `ExpressSendOnly` property in `SendingUser` structure must be set to **false**.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipientsPutRecipientSignatureImageExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var recipientId = recipientId_example;  // string | The `recipientId` used when the envelope or template was created.

            try
            {
                // Sets the signature image for an accountless signer.
                apiInstance.RecipientsPutRecipientSignatureImage(accountId, envelopeId, recipientId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.RecipientsPutRecipientSignatureImage: " + e.Message );
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
 **recipientId** | **string**| The &#x60;recipientId&#x60; used when the envelope or template was created. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

