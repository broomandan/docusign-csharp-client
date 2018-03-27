# IO.Swagger.Api.RequestLogsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**APIRequestLogDeleteRequestLogs**](RequestLogsApi.md#apirequestlogdeleterequestlogs) | **DELETE** /v2/diagnostics/request_logs | Deletes the request log files.
[**APIRequestLogGetRequestLog**](RequestLogsApi.md#apirequestloggetrequestlog) | **GET** /v2/diagnostics/request_logs/{requestLogId} | Gets a request logging log file.
[**APIRequestLogGetRequestLogSettings**](RequestLogsApi.md#apirequestloggetrequestlogsettings) | **GET** /v2/diagnostics/settings | Gets the API request logging settings.
[**APIRequestLogGetRequestLogs**](RequestLogsApi.md#apirequestloggetrequestlogs) | **GET** /v2/diagnostics/request_logs | Gets the API request logging log files.
[**APIRequestLogPutRequestLogSettings**](RequestLogsApi.md#apirequestlogputrequestlogsettings) | **PUT** /v2/diagnostics/settings | Enables or disables API request logging for troubleshooting.


<a name="apirequestlogdeleterequestlogs"></a>
# **APIRequestLogDeleteRequestLogs**
> void APIRequestLogDeleteRequestLogs ()

Deletes the request log files.

Deletes the request log files.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class APIRequestLogDeleteRequestLogsExample
    {
        public void main()
        {
            
            var apiInstance = new RequestLogsApi();

            try
            {
                // Deletes the request log files.
                apiInstance.APIRequestLogDeleteRequestLogs();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestLogsApi.APIRequestLogDeleteRequestLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apirequestloggetrequestlog"></a>
# **APIRequestLogGetRequestLog**
> System.IO.Stream APIRequestLogGetRequestLog (string requestLogId)

Gets a request logging log file.

Retrieves information for a single log entry.  **Request** The `requestLogfId` property can be retrieved by getting the list of log entries. The Content-Transfer-Encoding header can be set to base64 to retrieve the API request/response as base 64 string. Otherwise the bytes of the request/response are returned.  **Response** If the Content-Transfer-Encoding header was set to base64, the log is returned as a base64 string.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class APIRequestLogGetRequestLogExample
    {
        public void main()
        {
            
            var apiInstance = new RequestLogsApi();
            var requestLogId = requestLogId_example;  // string | 

            try
            {
                // Gets a request logging log file.
                System.IO.Stream result = apiInstance.APIRequestLogGetRequestLog(requestLogId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestLogsApi.APIRequestLogGetRequestLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestLogId** | **string**|  | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apirequestloggetrequestlogsettings"></a>
# **APIRequestLogGetRequestLogSettings**
> RequestLogs APIRequestLogGetRequestLogSettings ()

Gets the API request logging settings.

Retrieves the current API request logging setting for the user and remaining log entries.  **Response** The response includes the current API request logging setting for the user, along with the maximum log entries and remaining log entries.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class APIRequestLogGetRequestLogSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new RequestLogsApi();

            try
            {
                // Gets the API request logging settings.
                RequestLogs result = apiInstance.APIRequestLogGetRequestLogSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestLogsApi.APIRequestLogGetRequestLogSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RequestLogs**](RequestLogs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apirequestloggetrequestlogs"></a>
# **APIRequestLogGetRequestLogs**
> ApiRequestLogsResult APIRequestLogGetRequestLogs (string encoding = null)

Gets the API request logging log files.

Retrieves a list of log entries as a JSON or xml object or as a zip file containing the entries.  If the Accept header is set to application/zip, the response is a zip file containing individual text files, each representing an API request.  If the Accept header is set to `application/json` or `application/xml`, the response returns list of log entries in either JSON or XML. An example JSON response body is shown below. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class APIRequestLogGetRequestLogsExample
    {
        public void main()
        {
            
            var apiInstance = new RequestLogsApi();
            var encoding = encoding_example;  // string |  (optional) 

            try
            {
                // Gets the API request logging log files.
                ApiRequestLogsResult result = apiInstance.APIRequestLogGetRequestLogs(encoding);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestLogsApi.APIRequestLogGetRequestLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **encoding** | **string**|  | [optional] 

### Return type

[**ApiRequestLogsResult**](ApiRequestLogsResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apirequestlogputrequestlogsettings"></a>
# **APIRequestLogPutRequestLogSettings**
> RequestLogs APIRequestLogPutRequestLogSettings (RequestLogs requestLogs = null)

Enables or disables API request logging for troubleshooting.

Enables or disables API request logging for troubleshooting.  When enabled (`apiRequestLogging` is set to true), REST API requests and responses for the user are added to a log. A log can have up to 50 requests/responses and the current number of log entries can be determined by getting the settings. Logging is automatically disabled when the log limit of 50 is reached.  You can call [ML:GetRequestLog] or [ML:GetRequestLogs] to download the log files (individually or as a zip file). Call [ML:DeleteRequestLogs] to clear the log by deleting current entries.  Private information, such as passwords and integrator key information, which is normally located in the call header is omitted from the request/response log.  ###### Note: API request logging only captures requests from the authenticated user. Any call that does not authenticate the user and resolve a userId isn't logged. Meaning that login_information, NewAccounts, or other distributor-credential calls are not logged. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class APIRequestLogPutRequestLogSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new RequestLogsApi();
            var requestLogs = new RequestLogs(); // RequestLogs |  (optional) 

            try
            {
                // Enables or disables API request logging for troubleshooting.
                RequestLogs result = apiInstance.APIRequestLogPutRequestLogSettings(requestLogs);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestLogsApi.APIRequestLogPutRequestLogSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestLogs** | [**RequestLogs**](RequestLogs.md)|  | [optional] 

### Return type

[**RequestLogs**](RequestLogs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

