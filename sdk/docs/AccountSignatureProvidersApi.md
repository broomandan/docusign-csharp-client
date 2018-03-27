# IO.Swagger.Api.AccountSignatureProvidersApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountSignatureProvidersGetSignatureProviders**](AccountSignatureProvidersApi.md#accountsignatureprovidersgetsignatureproviders) | **GET** /v2/accounts/{accountId}/signatureProviders | Returns Account available signature providers for specified account.


<a name="accountsignatureprovidersgetsignatureproviders"></a>
# **AccountSignatureProvidersGetSignatureProviders**
> AccountSignatureProviders AccountSignatureProvidersGetSignatureProviders (string accountId)

Returns Account available signature providers for specified account.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountSignatureProvidersGetSignatureProvidersExample
    {
        public void main()
        {
            
            var apiInstance = new AccountSignatureProvidersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Returns Account available signature providers for specified account.
                AccountSignatureProviders result = apiInstance.AccountSignatureProvidersGetSignatureProviders(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountSignatureProvidersApi.AccountSignatureProvidersGetSignatureProviders: " + e.Message );
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

[**AccountSignatureProviders**](AccountSignatureProviders.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

