# IO.Swagger.Api.TemplatesApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NotificationGetTemplatesTemplateIdNotification**](TemplatesApi.md#notificationgettemplatestemplateidnotification) | **GET** /v2/accounts/{accountId}/templates/{templateId}/notification | Gets template notification information.
[**NotificationPutTemplatesTemplateIdNotification**](TemplatesApi.md#notificationputtemplatestemplateidnotification) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/notification | Updates the notification  structure for an existing template.
[**PagesDeleteTemplatePage**](TemplatesApi.md#pagesdeletetemplatepage) | **DELETE** /v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/pages/{pageNumber} | Deletes a page from a document in an template.
[**PagesGetTemplatePageImage**](TemplatesApi.md#pagesgettemplatepageimage) | **GET** /v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/pages/{pageNumber}/page_image | Gets a page image from a template for display.
[**PagesGetTemplatePageImages**](TemplatesApi.md#pagesgettemplatepageimages) | **GET** /v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/pages | Returns document page image(s) based on input.
[**PagesPutTemplatePageImage**](TemplatesApi.md#pagesputtemplatepageimage) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/pages/{pageNumber}/page_image | Rotates page image from a template for display.
[**TemplatesDeleteTemplatePart**](TemplatesApi.md#templatesdeletetemplatepart) | **DELETE** /v2/accounts/{accountId}/templates/{templateId}/{templatePart} | Removes a member group&#39;s sharing permissions for a template.
[**TemplatesGetTemplate**](TemplatesApi.md#templatesgettemplate) | **GET** /v2/accounts/{accountId}/templates/{templateId} | Gets a list of templates for a specified account.
[**TemplatesGetTemplates**](TemplatesApi.md#templatesgettemplates) | **GET** /v2/accounts/{accountId}/templates | Gets the definition of a template.
[**TemplatesPostTemplates**](TemplatesApi.md#templatesposttemplates) | **POST** /v2/accounts/{accountId}/templates | Creates an envelope from a template.
[**TemplatesPutTemplate**](TemplatesApi.md#templatesputtemplate) | **PUT** /v2/accounts/{accountId}/templates/{templateId} | Updates an existing template.
[**TemplatesPutTemplatePart**](TemplatesApi.md#templatesputtemplatepart) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/{templatePart} | Shares a template with a group


<a name="notificationgettemplatestemplateidnotification"></a>
# **NotificationGetTemplatesTemplateIdNotification**
> Notification NotificationGetTemplatesTemplateIdNotification (string accountId, string templateId)

Gets template notification information.

Retrieves the envelope notification, reminders and expirations, information for an existing template.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class NotificationGetTemplatesTemplateIdNotificationExample
    {
        public void main()
        {
            
            var apiInstance = new TemplatesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Gets template notification information.
                Notification result = apiInstance.NotificationGetTemplatesTemplateIdNotification(accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.NotificationGetTemplatesTemplateIdNotification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 

### Return type

[**Notification**](Notification.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationputtemplatestemplateidnotification"></a>
# **NotificationPutTemplatesTemplateIdNotification**
> Notification NotificationPutTemplatesTemplateIdNotification (string accountId, string templateId, TemplateNotificationRequest templateNotificationRequest = null)

Updates the notification  structure for an existing template.

Updates the notification structure for an existing template. Use this endpoint to set reminder and expiration notifications.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class NotificationPutTemplatesTemplateIdNotificationExample
    {
        public void main()
        {
            
            var apiInstance = new TemplatesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var templateNotificationRequest = new TemplateNotificationRequest(); // TemplateNotificationRequest |  (optional) 

            try
            {
                // Updates the notification  structure for an existing template.
                Notification result = apiInstance.NotificationPutTemplatesTemplateIdNotification(accountId, templateId, templateNotificationRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.NotificationPutTemplatesTemplateIdNotification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 
 **templateNotificationRequest** | [**TemplateNotificationRequest**](TemplateNotificationRequest.md)|  | [optional] 

### Return type

[**Notification**](Notification.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pagesdeletetemplatepage"></a>
# **PagesDeleteTemplatePage**
> void PagesDeleteTemplatePage (string accountId, string documentId, string pageNumber, string templateId, PageRequest pageRequest = null)

Deletes a page from a document in an template.

Deletes a page from a document in a template based on the page number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PagesDeleteTemplatePageExample
    {
        public void main()
        {
            
            var apiInstance = new TemplatesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var pageNumber = pageNumber_example;  // string | The page number being accessed.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var pageRequest = new PageRequest(); // PageRequest |  (optional) 

            try
            {
                // Deletes a page from a document in an template.
                apiInstance.PagesDeleteTemplatePage(accountId, documentId, pageNumber, templateId, pageRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.PagesDeleteTemplatePage: " + e.Message );
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
 **pageNumber** | **string**| The page number being accessed. | 
 **templateId** | **string**| The ID of the template being accessed. | 
 **pageRequest** | [**PageRequest**](PageRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pagesgettemplatepageimage"></a>
# **PagesGetTemplatePageImage**
> System.IO.Stream PagesGetTemplatePageImage (string accountId, string documentId, string pageNumber, string templateId, string dpi = null, string maxHeight = null, string maxWidth = null, string showChanges = null)

Gets a page image from a template for display.

Retrieves a page image for display from the specified template.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PagesGetTemplatePageImageExample
    {
        public void main()
        {
            
            var apiInstance = new TemplatesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var pageNumber = pageNumber_example;  // string | The page number being accessed.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var dpi = dpi_example;  // string | Number of dots per inch for the resulting image. The default if not used is 94. The range is 1-310. (optional) 
            var maxHeight = maxHeight_example;  // string | Sets the maximum height (in pixels) of the returned image. (optional) 
            var maxWidth = maxWidth_example;  // string | Sets the maximum width (in pixels) of the returned image. (optional) 
            var showChanges = showChanges_example;  // string |  (optional) 

            try
            {
                // Gets a page image from a template for display.
                System.IO.Stream result = apiInstance.PagesGetTemplatePageImage(accountId, documentId, pageNumber, templateId, dpi, maxHeight, maxWidth, showChanges);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.PagesGetTemplatePageImage: " + e.Message );
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
 **pageNumber** | **string**| The page number being accessed. | 
 **templateId** | **string**| The ID of the template being accessed. | 
 **dpi** | **string**| Number of dots per inch for the resulting image. The default if not used is 94. The range is 1-310. | [optional] 
 **maxHeight** | **string**| Sets the maximum height (in pixels) of the returned image. | [optional] 
 **maxWidth** | **string**| Sets the maximum width (in pixels) of the returned image. | [optional] 
 **showChanges** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/png

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pagesgettemplatepageimages"></a>
# **PagesGetTemplatePageImages**
> PageImages PagesGetTemplatePageImages (string accountId, string documentId, string templateId, string count = null, string dpi = null, string maxHeight = null, string maxWidth = null, string nocache = null, string showChanges = null, string startPosition = null)

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
    public class PagesGetTemplatePageImagesExample
    {
        public void main()
        {
            
            var apiInstance = new TemplatesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
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
                PageImages result = apiInstance.PagesGetTemplatePageImages(accountId, documentId, templateId, count, dpi, maxHeight, maxWidth, nocache, showChanges, startPosition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.PagesGetTemplatePageImages: " + e.Message );
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
 **templateId** | **string**| The ID of the template being accessed. | 
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

<a name="pagesputtemplatepageimage"></a>
# **PagesPutTemplatePageImage**
> void PagesPutTemplatePageImage (string accountId, string documentId, string pageNumber, string templateId, PageRequest pageRequest = null)

Rotates page image from a template for display.

Rotates page image from a template for display. The page image can be rotated to the left or right.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PagesPutTemplatePageImageExample
    {
        public void main()
        {
            
            var apiInstance = new TemplatesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var pageNumber = pageNumber_example;  // string | The page number being accessed.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var pageRequest = new PageRequest(); // PageRequest |  (optional) 

            try
            {
                // Rotates page image from a template for display.
                apiInstance.PagesPutTemplatePageImage(accountId, documentId, pageNumber, templateId, pageRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.PagesPutTemplatePageImage: " + e.Message );
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
 **pageNumber** | **string**| The page number being accessed. | 
 **templateId** | **string**| The ID of the template being accessed. | 
 **pageRequest** | [**PageRequest**](PageRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatesdeletetemplatepart"></a>
# **TemplatesDeleteTemplatePart**
> Groups TemplatesDeleteTemplatePart (string accountId, string templateId, string templatePart, Groups groups = null)

Removes a member group's sharing permissions for a template.

Removes a member group's sharing permissions for a specified template.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TemplatesDeleteTemplatePartExample
    {
        public void main()
        {
            
            var apiInstance = new TemplatesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var templatePart = templatePart_example;  // string | Currently, the only defined part is **groups**.
            var groups = new Groups(); // Groups |  (optional) 

            try
            {
                // Removes a member group's sharing permissions for a template.
                Groups result = apiInstance.TemplatesDeleteTemplatePart(accountId, templateId, templatePart, groups);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplatesDeleteTemplatePart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 
 **templatePart** | **string**| Currently, the only defined part is **groups**. | 
 **groups** | [**Groups**](Groups.md)|  | [optional] 

### Return type

[**Groups**](Groups.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatesgettemplate"></a>
# **TemplatesGetTemplate**
> Templates TemplatesGetTemplate (string accountId, string templateId, string include = null)

Gets a list of templates for a specified account.

Retrieves the definition of the specified template.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TemplatesGetTemplateExample
    {
        public void main()
        {
            
            var apiInstance = new TemplatesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var include = include_example;  // string | A comma-separated list of additional template attributes to include in the response. Valid values are: recipients, folders, documents, custom_fields, and notifications. (optional) 

            try
            {
                // Gets a list of templates for a specified account.
                Templates result = apiInstance.TemplatesGetTemplate(accountId, templateId, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplatesGetTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 
 **include** | **string**| A comma-separated list of additional template attributes to include in the response. Valid values are: recipients, folders, documents, custom_fields, and notifications. | [optional] 

### Return type

[**Templates**](Templates.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatesgettemplates"></a>
# **TemplatesGetTemplates**
> EnvelopeTemplateResults TemplatesGetTemplates (string accountId, string count = null, string folder = null, string folderIds = null, string folderTypes = null, string fromDate = null, string include = null, string order = null, string orderBy = null, string searchText = null, string shared = null, string sharedByMe = null, string startPosition = null, string toDate = null, string usedFromDate = null, string usedToDate = null, string userFilter = null, string userId = null)

Gets the definition of a template.

Retrieves the list of templates for the specified account. The request can be limited to a specific folder.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TemplatesGetTemplatesExample
    {
        public void main()
        {
            
            var apiInstance = new TemplatesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var count = count_example;  // string | Number of records to return in the cache. (optional) 
            var folder = folder_example;  // string | The query value can be a folder name or folder ID. The response will only return templates in the specified folder. (optional) 
            var folderIds = folderIds_example;  // string | A comma separated list of folder ID GUIDs. (optional) 
            var folderTypes = folderTypes_example;  // string |  (optional) 
            var fromDate = fromDate_example;  // string | Start of the search date range. Only returns templates created on or after this date/time. If no value is specified, there is no limit on the earliest date created. (optional) 
            var include = include_example;  // string | A comma-separated list of additional template attributes to include in the response. Valid values are:  * custom_fields * documents * folders * notifications * recipients  (optional) 
            var order = order_example;  // string | Sets the direction order used to sort the list. Valid values are: -asc = ascending sort order (a to z)  -desc = descending sort order (z to a) (optional) 
            var orderBy = orderBy_example;  // string | Sets the file attribute used to sort the list. Valid values are:  -name: template name  -modified: date/time template was last modified.  -used: date/time the template was last used. (optional) 
            var searchText = searchText_example;  // string | The search text used to search the names of templates. (optional) 
            var shared = shared_example;  // string |  (optional) 
            var sharedByMe = sharedByMe_example;  // string | If true, the response only includes templates shared by the user. If false, the response only returns template not shared by the user. If not specified, the response is not affected. (optional) 
            var startPosition = startPosition_example;  // string | The starting index for the first template shown in the response. This must be greater than or equal to 0 (zero). (optional) 
            var toDate = toDate_example;  // string | End of the search date range. Only returns templates created up to this date/time. If no value is provided, this defaults to the current date. (optional) 
            var usedFromDate = usedFromDate_example;  // string | Start of the search date range. Only returns templates used or edited on or after this date/time. If no value is specified, there is no limit on the earliest date used. (optional) 
            var usedToDate = usedToDate_example;  // string | End of the search date range. Only returns templates used or edited up to this date/time. If no value is provided, this defaults to the current date. (optional) 
            var userFilter = userFilter_example;  // string | Sets if the templates shown in the response Valid values are:  -owned_by_me: only shows templates the user owns.  -shared_with_me: only shows templates that are shared with the user.  -all: shows all templates owned or shared with the user. (optional) 
            var userId = userId_example;  // string |  (optional) 

            try
            {
                // Gets the definition of a template.
                EnvelopeTemplateResults result = apiInstance.TemplatesGetTemplates(accountId, count, folder, folderIds, folderTypes, fromDate, include, order, orderBy, searchText, shared, sharedByMe, startPosition, toDate, usedFromDate, usedToDate, userFilter, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplatesGetTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **count** | **string**| Number of records to return in the cache. | [optional] 
 **folder** | **string**| The query value can be a folder name or folder ID. The response will only return templates in the specified folder. | [optional] 
 **folderIds** | **string**| A comma separated list of folder ID GUIDs. | [optional] 
 **folderTypes** | **string**|  | [optional] 
 **fromDate** | **string**| Start of the search date range. Only returns templates created on or after this date/time. If no value is specified, there is no limit on the earliest date created. | [optional] 
 **include** | **string**| A comma-separated list of additional template attributes to include in the response. Valid values are:  * custom_fields * documents * folders * notifications * recipients  | [optional] 
 **order** | **string**| Sets the direction order used to sort the list. Valid values are: -asc &#x3D; ascending sort order (a to z)  -desc &#x3D; descending sort order (z to a) | [optional] 
 **orderBy** | **string**| Sets the file attribute used to sort the list. Valid values are:  -name: template name  -modified: date/time template was last modified.  -used: date/time the template was last used. | [optional] 
 **searchText** | **string**| The search text used to search the names of templates. | [optional] 
 **shared** | **string**|  | [optional] 
 **sharedByMe** | **string**| If true, the response only includes templates shared by the user. If false, the response only returns template not shared by the user. If not specified, the response is not affected. | [optional] 
 **startPosition** | **string**| The starting index for the first template shown in the response. This must be greater than or equal to 0 (zero). | [optional] 
 **toDate** | **string**| End of the search date range. Only returns templates created up to this date/time. If no value is provided, this defaults to the current date. | [optional] 
 **usedFromDate** | **string**| Start of the search date range. Only returns templates used or edited on or after this date/time. If no value is specified, there is no limit on the earliest date used. | [optional] 
 **usedToDate** | **string**| End of the search date range. Only returns templates used or edited up to this date/time. If no value is provided, this defaults to the current date. | [optional] 
 **userFilter** | **string**| Sets if the templates shown in the response Valid values are:  -owned_by_me: only shows templates the user owns.  -shared_with_me: only shows templates that are shared with the user.  -all: shows all templates owned or shared with the user. | [optional] 
 **userId** | **string**|  | [optional] 

### Return type

[**EnvelopeTemplateResults**](EnvelopeTemplateResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatesposttemplates"></a>
# **TemplatesPostTemplates**
> TemplateSummary TemplatesPostTemplates (string accountId, Templates templates = null)

Creates an envelope from a template.

Creates a template definition using a multipart request.  ### Template Email Subject Merge Fields  Call this endpoint to insert a recipient name and email address merge fields into the email subject line when creating or sending from a template.  The merge fields, based on the recipient's role name, are added to the `emailSubject` property when the template is created or when the template is used to create an envelope. After a template sender adds the name and email information for the recipient and sends the envelope, the recipient information is automatically merged into the appropriate fields in the email subject line.  Both the sender and the recipients will see the information in the email subject line for any emails associated with the template. This provides an easy way for senders to organize their envelope emails without having to open an envelope to check the recipient. ###### Note: If merging the recipient information into the subject line causes the subject line to exceed 100 characters, then any characters over the 100 character limit are not included in the subject line. For cases where the recipient name or email is expected to be long, you should consider placing the merge field at the start of the email subject.  To add a recipient's name in the subject line add the following text in the `emailSubject` property when creating the template or when sending an envelope from a template:  `[[<roleName>_UserName]]`  Example:  `\"emailSubject\":\"[[Signer 1_UserName]], Please sign this NDA\",`  To add a recipient's email address in the subject line add the following text in the `emailSubject` property when creating the template or when sending an envelope from a template:  `[[<roleName>_Email]]`  Example:  `\"emailSubject\":\"[[Signer 1_Email]], Please sign this NDA\",`   In both cases the <roleName> is the recipient's contents of the `roleName` property in the template.  For cases where another recipient (such as an Agent, Editor, or Intermediary recipient) is entering the name and email information for the recipient included in the email subject, then `[[<roleName>_UserName]]` or `[[<roleName>_Email]]` is shown in the email subject.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TemplatesPostTemplatesExample
    {
        public void main()
        {
            
            var apiInstance = new TemplatesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templates = new Templates(); // Templates |  (optional) 

            try
            {
                // Creates an envelope from a template.
                TemplateSummary result = apiInstance.TemplatesPostTemplates(accountId, templates);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplatesPostTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templates** | [**Templates**](Templates.md)|  | [optional] 

### Return type

[**TemplateSummary**](TemplateSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatesputtemplate"></a>
# **TemplatesPutTemplate**
> TemplateUpdateSummary TemplatesPutTemplate (string accountId, string templateId, Templates templates = null)

Updates an existing template.

Updates an existing template.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TemplatesPutTemplateExample
    {
        public void main()
        {
            
            var apiInstance = new TemplatesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var templates = new Templates(); // Templates |  (optional) 

            try
            {
                // Updates an existing template.
                TemplateUpdateSummary result = apiInstance.TemplatesPutTemplate(accountId, templateId, templates);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplatesPutTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 
 **templates** | [**Templates**](Templates.md)|  | [optional] 

### Return type

[**TemplateUpdateSummary**](TemplateUpdateSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatesputtemplatepart"></a>
# **TemplatesPutTemplatePart**
> Groups TemplatesPutTemplatePart (string accountId, string templateId, string templatePart, Groups groups = null)

Shares a template with a group

Shares a template with the specified members group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TemplatesPutTemplatePartExample
    {
        public void main()
        {
            
            var apiInstance = new TemplatesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var templatePart = templatePart_example;  // string | Currently, the only defined part is **groups**.
            var groups = new Groups(); // Groups |  (optional) 

            try
            {
                // Shares a template with a group
                Groups result = apiInstance.TemplatesPutTemplatePart(accountId, templateId, templatePart, groups);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplatesPutTemplatePart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 
 **templatePart** | **string**| Currently, the only defined part is **groups**. | 
 **groups** | [**Groups**](Groups.md)|  | [optional] 

### Return type

[**Groups**](Groups.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

