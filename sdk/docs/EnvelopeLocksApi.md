# IO.Swagger.Api.EnvelopeLocksApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LockDeleteEnvelopeLock**](EnvelopeLocksApi.md#lockdeleteenvelopelock) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/lock | Deletes an envelope lock.
[**LockGetEnvelopeLock**](EnvelopeLocksApi.md#lockgetenvelopelock) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/lock | Gets envelope lock information.
[**LockPostEnvelopeLock**](EnvelopeLocksApi.md#lockpostenvelopelock) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/lock | Lock an envelope.
[**LockPutEnvelopeLock**](EnvelopeLocksApi.md#lockputenvelopelock) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/lock | Updates an envelope lock.


<a name="lockdeleteenvelopelock"></a>
# **LockDeleteEnvelopeLock**
> EnvelopeLocks LockDeleteEnvelopeLock (string accountId, string envelopeId)

Deletes an envelope lock.

Deletes the lock from the specified envelope. The `X-DocuSign-Edit` header must be included in the request.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LockDeleteEnvelopeLockExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeLocksApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 

            try
            {
                // Deletes an envelope lock.
                EnvelopeLocks result = apiInstance.LockDeleteEnvelopeLock(accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeLocksApi.LockDeleteEnvelopeLock: " + e.Message );
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

[**EnvelopeLocks**](EnvelopeLocks.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="lockgetenvelopelock"></a>
# **LockGetEnvelopeLock**
> EnvelopeLocks LockGetEnvelopeLock (string accountId, string envelopeId)

Gets envelope lock information.

Retrieves general information about the envelope lock.  If the call is made by the locked by user and the request has the same integrator key as original, then the `X-DocuSign-Edit` header and additional lock information is included in the response. This allows users to recover a lost editing session token and the `X-DocuSign-Edit` header.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LockGetEnvelopeLockExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeLocksApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 

            try
            {
                // Gets envelope lock information.
                EnvelopeLocks result = apiInstance.LockGetEnvelopeLock(accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeLocksApi.LockGetEnvelopeLock: " + e.Message );
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

[**EnvelopeLocks**](EnvelopeLocks.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="lockpostenvelopelock"></a>
# **LockPostEnvelopeLock**
> EnvelopeLocks LockPostEnvelopeLock (string accountId, string envelopeId, LockRequest lockRequest = null)

Lock an envelope.

Locks the specified envelope, and sets the time until the lock expires, to prevent other users or recipients from accessing and changing the envelope.  ###### Note: Users must have envelope locking capability enabled to use this function (userSetting `canLockEnvelopes` must be  set to true for the user).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LockPostEnvelopeLockExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeLocksApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var lockRequest = new LockRequest(); // LockRequest |  (optional) 

            try
            {
                // Lock an envelope.
                EnvelopeLocks result = apiInstance.LockPostEnvelopeLock(accountId, envelopeId, lockRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeLocksApi.LockPostEnvelopeLock: " + e.Message );
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
 **lockRequest** | [**LockRequest**](LockRequest.md)|  | [optional] 

### Return type

[**EnvelopeLocks**](EnvelopeLocks.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="lockputenvelopelock"></a>
# **LockPutEnvelopeLock**
> EnvelopeLocks LockPutEnvelopeLock (string accountId, string envelopeId, LockRequest lockRequest = null)

Updates an envelope lock.

Updates the lock duration time or update the `lockedByApp` property information for the specified envelope. The user and integrator key must match the user specified by the `lockByUser` property and integrator key information and the `X-DocuSign-Edit` header must be included or an error will be generated.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LockPutEnvelopeLockExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopeLocksApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelope's GUID. Eg 93be49ab-afa0-4adf-933c-f752070d71ec 
            var lockRequest = new LockRequest(); // LockRequest |  (optional) 

            try
            {
                // Updates an envelope lock.
                EnvelopeLocks result = apiInstance.LockPutEnvelopeLock(accountId, envelopeId, lockRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopeLocksApi.LockPutEnvelopeLock: " + e.Message );
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
 **lockRequest** | [**LockRequest**](LockRequest.md)|  | [optional] 

### Return type

[**EnvelopeLocks**](EnvelopeLocks.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

