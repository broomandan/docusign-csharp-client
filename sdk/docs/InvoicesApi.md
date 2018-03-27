# IO.Swagger.Api.InvoicesApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BillingInvoicesGetBillingInvoice**](InvoicesApi.md#billinginvoicesgetbillinginvoice) | **GET** /v2/accounts/{accountId}/billing_invoices/{invoiceId} | Retrieves a billing invoice.
[**BillingInvoicesGetBillingInvoices**](InvoicesApi.md#billinginvoicesgetbillinginvoices) | **GET** /v2/accounts/{accountId}/billing_invoices | Get a List of Billing Invoices
[**BillingInvoicesGetBillingInvoicesPastDue**](InvoicesApi.md#billinginvoicesgetbillinginvoicespastdue) | **GET** /v2/accounts/{accountId}/billing_invoices_past_due | Get a list of past due invoices.


<a name="billinginvoicesgetbillinginvoice"></a>
# **BillingInvoicesGetBillingInvoice**
> Invoices BillingInvoicesGetBillingInvoice (string accountId, string invoiceId)

Retrieves a billing invoice.

Retrieves the specified invoice.   ###### Note: If the `pdfAvailable` property in the response is set to *true*, you can download a PDF version of the invoice. To download the PDF, make the call again and change the value of the `Accept` property in the header to `Accept: application/pdf`.  Privileges required: account administrator  The response returns a list of charges and information about the charges. Quantities are usually shown as 'unlimited' or an integer. Amounts are shown in the currency set for the account.  **Response** The following table provides a description of the different `chargeName` property values. The information will grow as more chargeable items are added to the system.  | chargeName | Description | | - -- | - -- | | id_check | ID Check Charge | | in_person_signing | In Person Signing charge | | envelopes Included | Sent Envelopes for the account | | age_verify | Age verification check | | ofac | OFAC Check | | id_confirm | ID confirmation check | | student_authentication | STAN PIN authentication check | | wet_sign_fax | Pages for returning signed documents by fax | | attachment_fax | Pages for returning attachments by fax | | phone_authentication | Phone authentication charge | | powerforms | PowerForm envelopes sent | | signer_payments | Payment processing charge | | outbound_fax | Send by fax charge | | bulk_recipient_envelopes | Bulk Recipient Envelopes sent | | sms_authentications | SMS authentication charge | | saml_authentications | SAML authentication charge | | express_signer_certificate | DocuSign Express Certificate charge | | personal_signer_certificate | Personal Signer Certificate charge | | safe_certificate | SAFE BioPharma Signer Certificate charge | | seats | Included active seats charge | | open_trust_certificate | OpenTrust Signer Certificate charge | 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BillingInvoicesGetBillingInvoiceExample
    {
        public void main()
        {
            
            var apiInstance = new InvoicesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var invoiceId = invoiceId_example;  // string | 

            try
            {
                // Retrieves a billing invoice.
                Invoices result = apiInstance.BillingInvoicesGetBillingInvoice(accountId, invoiceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.BillingInvoicesGetBillingInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **invoiceId** | **string**|  | 

### Return type

[**Invoices**](Invoices.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billinginvoicesgetbillinginvoices"></a>
# **BillingInvoicesGetBillingInvoices**
> BillingInvoicesResponse BillingInvoicesGetBillingInvoices (string accountId, string fromDate = null, string toDate = null)

Get a List of Billing Invoices

Retrieves a list of invoices for the account. If the from date or to date queries are not specified, the response returns invoices for the last 365 days.  Privileges required: account administrator 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BillingInvoicesGetBillingInvoicesExample
    {
        public void main()
        {
            
            var apiInstance = new InvoicesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var fromDate = fromDate_example;  // string | Specifies the date/time of the earliest invoice in the account to retrieve. (optional) 
            var toDate = toDate_example;  // string | Specifies the date/time of the latest invoice in the account to retrieve. (optional) 

            try
            {
                // Get a List of Billing Invoices
                BillingInvoicesResponse result = apiInstance.BillingInvoicesGetBillingInvoices(accountId, fromDate, toDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.BillingInvoicesGetBillingInvoices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **fromDate** | **string**| Specifies the date/time of the earliest invoice in the account to retrieve. | [optional] 
 **toDate** | **string**| Specifies the date/time of the latest invoice in the account to retrieve. | [optional] 

### Return type

[**BillingInvoicesResponse**](BillingInvoicesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billinginvoicesgetbillinginvoicespastdue"></a>
# **BillingInvoicesGetBillingInvoicesPastDue**
> BillingInvoicesSummary BillingInvoicesGetBillingInvoicesPastDue (string accountId)

Get a list of past due invoices.

Returns a list past due invoices for the account and notes if payment can be made through the REST API.   Privileges Required: account administrator

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BillingInvoicesGetBillingInvoicesPastDueExample
    {
        public void main()
        {
            
            var apiInstance = new InvoicesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Get a list of past due invoices.
                BillingInvoicesSummary result = apiInstance.BillingInvoicesGetBillingInvoicesPastDue(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.BillingInvoicesGetBillingInvoicesPastDue: " + e.Message );
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

[**BillingInvoicesSummary**](BillingInvoicesSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

