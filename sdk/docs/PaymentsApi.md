# IO.Swagger.Api.PaymentsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BillingPaymentsGetPayment**](PaymentsApi.md#billingpaymentsgetpayment) | **GET** /v2/accounts/{accountId}/billing_payments/{paymentId} | Gets billing payment information for a specific payment.
[**BillingPaymentsGetPaymentList**](PaymentsApi.md#billingpaymentsgetpaymentlist) | **GET** /v2/accounts/{accountId}/billing_payments | Gets payment information for one or more payments.
[**BillingPaymentsPostPayment**](PaymentsApi.md#billingpaymentspostpayment) | **POST** /v2/accounts/{accountId}/billing_payments | Posts a payment to a past due invoice.


<a name="billingpaymentsgetpayment"></a>
# **BillingPaymentsGetPayment**
> Payments BillingPaymentsGetPayment (string accountId, string paymentId)

Gets billing payment information for a specific payment.

Retrieves the information for a specified payment.   Privileges required: account administrator 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BillingPaymentsGetPaymentExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var paymentId = paymentId_example;  // string | 

            try
            {
                // Gets billing payment information for a specific payment.
                Payments result = apiInstance.BillingPaymentsGetPayment(accountId, paymentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.BillingPaymentsGetPayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **paymentId** | **string**|  | 

### Return type

[**Payments**](Payments.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billingpaymentsgetpaymentlist"></a>
# **BillingPaymentsGetPaymentList**
> BillingPaymentsResponse BillingPaymentsGetPaymentList (string accountId, string fromDate = null, string toDate = null)

Gets payment information for one or more payments.

Retrieves a list containing information about one or more payments. If the from date or to date queries are not used, the response returns payment information for the last 365 days.   Privileges required: account administrator 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BillingPaymentsGetPaymentListExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var fromDate = fromDate_example;  // string | Specifies the date/time of the earliest payment in the account to retrieve. (optional) 
            var toDate = toDate_example;  // string | Specifies the date/time of the latest payment in the account to retrieve. (optional) 

            try
            {
                // Gets payment information for one or more payments.
                BillingPaymentsResponse result = apiInstance.BillingPaymentsGetPaymentList(accountId, fromDate, toDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.BillingPaymentsGetPaymentList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **fromDate** | **string**| Specifies the date/time of the earliest payment in the account to retrieve. | [optional] 
 **toDate** | **string**| Specifies the date/time of the latest payment in the account to retrieve. | [optional] 

### Return type

[**BillingPaymentsResponse**](BillingPaymentsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billingpaymentspostpayment"></a>
# **BillingPaymentsPostPayment**
> BillingPaymentResponse BillingPaymentsPostPayment (string accountId, BillingPaymentRequest billingPaymentRequest = null)

Posts a payment to a past due invoice.

Posts a payment to a past due invoice.   ###### Note: This can only be used if the `paymentAllowed` value for a past due invoice is true. This can be determined calling [ML:GetBillingInvoicesPastDue].  The response returns information for a single payment, if a payment ID was used in the endpoint, or a list of payments. If the from date or to date queries or payment ID are not used, the response returns payment information for the last 365 days. If the request was for a single payment ID, the `nextUri` and `previousUri` properties are not returned.  Privileges required: account administrator

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BillingPaymentsPostPaymentExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var billingPaymentRequest = new BillingPaymentRequest(); // BillingPaymentRequest |  (optional) 

            try
            {
                // Posts a payment to a past due invoice.
                BillingPaymentResponse result = apiInstance.BillingPaymentsPostPayment(accountId, billingPaymentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.BillingPaymentsPostPayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **billingPaymentRequest** | [**BillingPaymentRequest**](BillingPaymentRequest.md)|  | [optional] 

### Return type

[**BillingPaymentResponse**](BillingPaymentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

