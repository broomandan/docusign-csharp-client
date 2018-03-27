# IO.Swagger.Api.TemplateLocksApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LockDeleteTemplateLock**](TemplateLocksApi.md#lockdeletetemplatelock) | **DELETE** /v2/accounts/{accountId}/templates/{templateId}/lock | Deletes a template lock.
[**LockGetTemplateLock**](TemplateLocksApi.md#lockgettemplatelock) | **GET** /v2/accounts/{accountId}/templates/{templateId}/lock | Gets template lock information.
[**LockPostTemplateLock**](TemplateLocksApi.md#lockposttemplatelock) | **POST** /v2/accounts/{accountId}/templates/{templateId}/lock | Lock a template.
[**LockPutTemplateLock**](TemplateLocksApi.md#lockputtemplatelock) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/lock | Updates a template lock.


<a name="lockdeletetemplatelock"></a>
# **LockDeleteTemplateLock**
> TemplateLocks LockDeleteTemplateLock (string accountId, string templateId, LockRequest lockRequest = null)

Deletes a template lock.

Deletes the lock from the specified template. The `X-DocuSign-Edit` header must be included in the request.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LockDeleteTemplateLockExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateLocksApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var lockRequest = new LockRequest(); // LockRequest |  (optional) 

            try
            {
                // Deletes a template lock.
                TemplateLocks result = apiInstance.LockDeleteTemplateLock(accountId, templateId, lockRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateLocksApi.LockDeleteTemplateLock: " + e.Message );
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
 **lockRequest** | [**LockRequest**](LockRequest.md)|  | [optional] 

### Return type

[**TemplateLocks**](TemplateLocks.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="lockgettemplatelock"></a>
# **LockGetTemplateLock**
> TemplateLocks LockGetTemplateLock (string accountId, string templateId)

Gets template lock information.

Retrieves general information about the template lock.  If the call is made by the user who has the lock and the request has the same integrator key as original, then the `X-DocuSign-Edit` header  field and additional lock information is included in the response. This allows users to recover a lost editing session token and the `X-DocuSign-Edit` header.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LockGetTemplateLockExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateLocksApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Gets template lock information.
                TemplateLocks result = apiInstance.LockGetTemplateLock(accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateLocksApi.LockGetTemplateLock: " + e.Message );
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

[**TemplateLocks**](TemplateLocks.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="lockposttemplatelock"></a>
# **LockPostTemplateLock**
> TemplateLocks LockPostTemplateLock (string accountId, string templateId, LockRequest lockRequest = null)

Lock a template.

Locks the specified template, and sets the time until the lock expires, to prevent other users or recipients from accessing and changing the template.  ###### Note: Users must have envelope locking capability enabled to use this function (the userSetting property `canLockEnvelopes` must be set to **true** for the user).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LockPostTemplateLockExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateLocksApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var lockRequest = new LockRequest(); // LockRequest |  (optional) 

            try
            {
                // Lock a template.
                TemplateLocks result = apiInstance.LockPostTemplateLock(accountId, templateId, lockRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateLocksApi.LockPostTemplateLock: " + e.Message );
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
 **lockRequest** | [**LockRequest**](LockRequest.md)|  | [optional] 

### Return type

[**TemplateLocks**](TemplateLocks.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="lockputtemplatelock"></a>
# **LockPutTemplateLock**
> TemplateLocks LockPutTemplateLock (string accountId, string templateId, LockRequest lockRequest = null)

Updates a template lock.

Updates the lock duration time or update the `lockedByApp` property information for the specified template. The user and integrator key must match the user specified by the `lockByUser` property and integrator key information and the `X-DocuSign-Edit` header must be included or an error will be generated.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LockPutTemplateLockExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateLocksApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var lockRequest = new LockRequest(); // LockRequest |  (optional) 

            try
            {
                // Updates a template lock.
                TemplateLocks result = apiInstance.LockPutTemplateLock(accountId, templateId, lockRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateLocksApi.LockPutTemplateLock: " + e.Message );
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
 **lockRequest** | [**LockRequest**](LockRequest.md)|  | [optional] 

### Return type

[**TemplateLocks**](TemplateLocks.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

