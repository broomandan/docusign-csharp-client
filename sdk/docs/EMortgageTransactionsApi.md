# IO.Swagger.Api.EMortgageTransactionsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EMortgagePostTransactions**](EMortgageTransactionsApi.md#emortgageposttransactions) | **POST** /v2/accounts/{accountId}/eMortgage/transactions | Starts a new eMortgage Transaction


<a name="emortgageposttransactions"></a>
# **EMortgagePostTransactions**
> PostTransactionsResponse EMortgagePostTransactions (string accountId, EMortgageTransactions eMortgageTransactions = null)

Starts a new eMortgage Transaction



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EMortgagePostTransactionsExample
    {
        public void main()
        {
            
            var apiInstance = new EMortgageTransactionsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var eMortgageTransactions = new EMortgageTransactions(); // EMortgageTransactions |  (optional) 

            try
            {
                // Starts a new eMortgage Transaction
                PostTransactionsResponse result = apiInstance.EMortgagePostTransactions(accountId, eMortgageTransactions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EMortgageTransactionsApi.EMortgagePostTransactions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **eMortgageTransactions** | [**EMortgageTransactions**](EMortgageTransactions.md)|  | [optional] 

### Return type

[**PostTransactionsResponse**](PostTransactionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

