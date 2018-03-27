# IO.Swagger.Api.PaymentGatewayAccountsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PaymentGatewayAccountsGetAllPaymentGatewayAccounts**](PaymentGatewayAccountsApi.md#paymentgatewayaccountsgetallpaymentgatewayaccounts) | **GET** /v2/accounts/{accountId}/payment_gateway_accounts | List payment gateway account information


<a name="paymentgatewayaccountsgetallpaymentgatewayaccounts"></a>
# **PaymentGatewayAccountsGetAllPaymentGatewayAccounts**
> PaymentGatewayAccountsInfo PaymentGatewayAccountsGetAllPaymentGatewayAccounts (string accountId)

List payment gateway account information

List payment gateway account information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PaymentGatewayAccountsGetAllPaymentGatewayAccountsExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentGatewayAccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // List payment gateway account information
                PaymentGatewayAccountsInfo result = apiInstance.PaymentGatewayAccountsGetAllPaymentGatewayAccounts(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentGatewayAccountsApi.PaymentGatewayAccountsGetAllPaymentGatewayAccounts: " + e.Message );
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

[**PaymentGatewayAccountsInfo**](PaymentGatewayAccountsInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

