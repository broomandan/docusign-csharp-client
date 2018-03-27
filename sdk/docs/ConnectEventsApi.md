# IO.Swagger.Api.ConnectEventsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConnectFailuresDeleteConnectFailureLog**](ConnectEventsApi.md#connectfailuresdeleteconnectfailurelog) | **DELETE** /v2/accounts/{accountId}/connect/failures/{failureId} | Deletes a Connect failure log entry.
[**ConnectFailuresGetConnectLogs**](ConnectEventsApi.md#connectfailuresgetconnectlogs) | **GET** /v2/accounts/{accountId}/connect/failures | Gets the Connect failure log information.
[**ConnectLogDeleteConnectLog**](ConnectEventsApi.md#connectlogdeleteconnectlog) | **DELETE** /v2/accounts/{accountId}/connect/logs/{logId} | Deletes a specified Connect log entry.
[**ConnectLogDeleteConnectLogs**](ConnectEventsApi.md#connectlogdeleteconnectlogs) | **DELETE** /v2/accounts/{accountId}/connect/logs | Gets a list of Connect log entries.
[**ConnectLogGetConnectLog**](ConnectEventsApi.md#connectloggetconnectlog) | **GET** /v2/accounts/{accountId}/connect/logs/{logId} | Get the specified Connect log entry.
[**ConnectLogGetConnectLogs**](ConnectEventsApi.md#connectloggetconnectlogs) | **GET** /v2/accounts/{accountId}/connect/logs | Gets the Connect log.
[**ConnectPublishPutConnectRetry**](ConnectEventsApi.md#connectpublishputconnectretry) | **PUT** /v2/accounts/{accountId}/connect/envelopes/retry_queue | Republishes Connect information for multiple envelopes.
[**ConnectPublishPutConnectRetryByEnvelope**](ConnectEventsApi.md#connectpublishputconnectretrybyenvelope) | **PUT** /v2/accounts/{accountId}/connect/envelopes/{envelopeId}/retry_queue | Republishes Connect information for the specified envelope.


<a name="connectfailuresdeleteconnectfailurelog"></a>
# **ConnectFailuresDeleteConnectFailureLog**
> void ConnectFailuresDeleteConnectFailureLog (string accountId, string failureId)

Deletes a Connect failure log entry.

Deletes the Connect failure log information for the specified entry.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConnectFailuresDeleteConnectFailureLogExample
    {
        public void main()
        {
            
            var apiInstance = new ConnectEventsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var failureId = failureId_example;  // string | The ID of the failed connect log entry.

            try
            {
                // Deletes a Connect failure log entry.
                apiInstance.ConnectFailuresDeleteConnectFailureLog(accountId, failureId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectEventsApi.ConnectFailuresDeleteConnectFailureLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **failureId** | **string**| The ID of the failed connect log entry. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectfailuresgetconnectlogs"></a>
# **ConnectFailuresGetConnectLogs**
> ConnectEvents ConnectFailuresGetConnectLogs (string accountId, string fromDate = null, string toDate = null)

Gets the Connect failure log information.

Retrieves the Connect Failure Log information. It can be used to determine which envelopes failed to post, so a republish request can be created.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConnectFailuresGetConnectLogsExample
    {
        public void main()
        {
            
            var apiInstance = new ConnectEventsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var fromDate = fromDate_example;  // string | Start of the search date range. Only returns templates created on or after this date/time. If no value is specified, there is no limit on the earliest date created. (optional) 
            var toDate = toDate_example;  // string | End of the search date range. Only returns templates created up to this date/time. If no value is provided, this defaults to the current date. (optional) 

            try
            {
                // Gets the Connect failure log information.
                ConnectEvents result = apiInstance.ConnectFailuresGetConnectLogs(accountId, fromDate, toDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectEventsApi.ConnectFailuresGetConnectLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **fromDate** | **string**| Start of the search date range. Only returns templates created on or after this date/time. If no value is specified, there is no limit on the earliest date created. | [optional] 
 **toDate** | **string**| End of the search date range. Only returns templates created up to this date/time. If no value is provided, this defaults to the current date. | [optional] 

### Return type

[**ConnectEvents**](ConnectEvents.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectlogdeleteconnectlog"></a>
# **ConnectLogDeleteConnectLog**
> void ConnectLogDeleteConnectLog (string accountId, string logId)

Deletes a specified Connect log entry.

Deletes a specified entry from the Connect Log. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConnectLogDeleteConnectLogExample
    {
        public void main()
        {
            
            var apiInstance = new ConnectEventsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var logId = logId_example;  // string | The ID of the connect log entry

            try
            {
                // Deletes a specified Connect log entry.
                apiInstance.ConnectLogDeleteConnectLog(accountId, logId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectEventsApi.ConnectLogDeleteConnectLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **logId** | **string**| The ID of the connect log entry | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectlogdeleteconnectlogs"></a>
# **ConnectLogDeleteConnectLogs**
> void ConnectLogDeleteConnectLogs (string accountId)

Gets a list of Connect log entries.

Retrieves a list of connect log entries for your account.  ###### Note: The `enableLog` property in the Connect configuration must be set to **true** to enable logging. If logging is not enabled, then no log entries are recorded.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConnectLogDeleteConnectLogsExample
    {
        public void main()
        {
            
            var apiInstance = new ConnectEventsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Gets a list of Connect log entries.
                apiInstance.ConnectLogDeleteConnectLogs(accountId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectEventsApi.ConnectLogDeleteConnectLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectloggetconnectlog"></a>
# **ConnectLogGetConnectLog**
> ConnectLog ConnectLogGetConnectLog (string accountId, string logId, string additionalInfo = null)

Get the specified Connect log entry.

Retrieves the specified Connect log entry for your account.  ###### Note: The `enableLog` setting in the Connect configuration must be set to true to enable logging. If logging is not enabled, then no log entries are recorded. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConnectLogGetConnectLogExample
    {
        public void main()
        {
            
            var apiInstance = new ConnectEventsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var logId = logId_example;  // string | The ID of the connect log entry
            var additionalInfo = additionalInfo_example;  // string | When true, the connectDebugLog information is included in the response. (optional) 

            try
            {
                // Get the specified Connect log entry.
                ConnectLog result = apiInstance.ConnectLogGetConnectLog(accountId, logId, additionalInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectEventsApi.ConnectLogGetConnectLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **logId** | **string**| The ID of the connect log entry | 
 **additionalInfo** | **string**| When true, the connectDebugLog information is included in the response. | [optional] 

### Return type

[**ConnectLog**](ConnectLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectloggetconnectlogs"></a>
# **ConnectLogGetConnectLogs**
> ConnectEvents ConnectLogGetConnectLogs (string accountId, string fromDate = null, string toDate = null)

Gets the Connect log.

Retrieves a list of connect log entries for your account.  ###### Note: The `enableLog` setting in the Connect configuration must be set to true to enable logging. If logging is not enabled, then no log entries are recorded. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConnectLogGetConnectLogsExample
    {
        public void main()
        {
            
            var apiInstance = new ConnectEventsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var fromDate = fromDate_example;  // string | Start of the search date range. Only returns templates created on or after this date/time. If no value is specified, there is no limit on the earliest date created. (optional) 
            var toDate = toDate_example;  // string | End of the search date range. Only returns templates created up to this date/time. If no value is provided, this defaults to the current date. (optional) 

            try
            {
                // Gets the Connect log.
                ConnectEvents result = apiInstance.ConnectLogGetConnectLogs(accountId, fromDate, toDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectEventsApi.ConnectLogGetConnectLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **fromDate** | **string**| Start of the search date range. Only returns templates created on or after this date/time. If no value is specified, there is no limit on the earliest date created. | [optional] 
 **toDate** | **string**| End of the search date range. Only returns templates created up to this date/time. If no value is provided, this defaults to the current date. | [optional] 

### Return type

[**ConnectEvents**](ConnectEvents.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectpublishputconnectretry"></a>
# **ConnectPublishPutConnectRetry**
> ConnectFailureResults ConnectPublishPutConnectRetry (string accountId, ConnectFailureFilter connectFailureFilter = null)

Republishes Connect information for multiple envelopes.

Republishes Connect information for the  specified set of envelopes. The primary use is to republish Connect post failures by including envelope IDs for the envelopes that failed to post in the request. The list of envelope IDs that failed to post correctly can be retrieved by calling to [ML:GetConnectLog] retrieve the failure log.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConnectPublishPutConnectRetryExample
    {
        public void main()
        {
            
            var apiInstance = new ConnectEventsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var connectFailureFilter = new ConnectFailureFilter(); // ConnectFailureFilter |  (optional) 

            try
            {
                // Republishes Connect information for multiple envelopes.
                ConnectFailureResults result = apiInstance.ConnectPublishPutConnectRetry(accountId, connectFailureFilter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectEventsApi.ConnectPublishPutConnectRetry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **connectFailureFilter** | [**ConnectFailureFilter**](ConnectFailureFilter.md)|  | [optional] 

### Return type

[**ConnectFailureResults**](ConnectFailureResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="connectpublishputconnectretrybyenvelope"></a>
# **ConnectPublishPutConnectRetryByEnvelope**
> ConnectFailureResults ConnectPublishPutConnectRetryByEnvelope (string accountId, string envelopeId)

Republishes Connect information for the specified envelope.

Republishes Connect information for the specified envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConnectPublishPutConnectRetryByEnvelopeExample
    {
        public void main()
        {
            
            var apiInstance = new ConnectEventsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 

            try
            {
                // Republishes Connect information for the specified envelope.
                ConnectFailureResults result = apiInstance.ConnectPublishPutConnectRetryByEnvelope(accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectEventsApi.ConnectPublishPutConnectRetryByEnvelope: " + e.Message );
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

[**ConnectFailureResults**](ConnectFailureResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

