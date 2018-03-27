# IO.Swagger.Api.BillingPlansApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BillingPlanGetBillingPlan**](BillingPlansApi.md#billingplangetbillingplan) | **GET** /v2/accounts/{accountId}/billing_plan | Get Account Billing Plan
[**BillingPlanGetCreditCardInfo**](BillingPlansApi.md#billingplangetcreditcardinfo) | **GET** /v2/accounts/{accountId}/billing_plan/credit_card | Get metadata for a given credit card.
[**BillingPlanPutBillingPlan**](BillingPlansApi.md#billingplanputbillingplan) | **PUT** /v2/accounts/{accountId}/billing_plan | Updates the account billing plan.
[**BillingPlansGetBillingPlan**](BillingPlansApi.md#billingplansgetbillingplan) | **GET** /v2/billing_plans/{billingPlanId} | Get the billing plan details.
[**BillingPlansGetBillingPlans**](BillingPlansApi.md#billingplansgetbillingplans) | **GET** /v2/billing_plans | Gets the list of available billing plans.
[**PurchasedEnvelopesPutPurchasedEnvelopes**](BillingPlansApi.md#purchasedenvelopesputpurchasedenvelopes) | **PUT** /v2/accounts/{accountId}/billing_plan/purchased_envelopes | Reserverd: Purchase additional envelopes.


<a name="billingplangetbillingplan"></a>
# **BillingPlanGetBillingPlan**
> BillingPlans BillingPlanGetBillingPlan (string accountId, string includeCreditCardInformation = null, string includeMetadata = null, string includeSuccessorPlans = null)

Get Account Billing Plan

Retrieves the billing plan information for the specified account, including the current billing plan, successor plans, billing address, and billing credit card.  By default the successor plan and credit card information is included in the response. This information can be excluded from the response by adding the appropriate optional query string with the `setting` set to **false**.   Response  The response returns the billing plan information, including the currency code, for the plan. The `billingPlan` and `succesorPlans` property values are the same as those shown in the [ML:Get Billing Plan Details] reference. the `billingAddress` and `creditCardInformation` property values are the same as those shown in the [ML:Update Billing Plan] reference.  ###### Note: When credit card number information is shown, a mask is applied to the response so that only the last 4 digits of the card number are visible. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BillingPlanGetBillingPlanExample
    {
        public void main()
        {
            
            var apiInstance = new BillingPlansApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var includeCreditCardInformation = includeCreditCardInformation_example;  // string | When set to **true**, excludes credit card information from the response. (optional) 
            var includeMetadata = includeMetadata_example;  // string | When set to **true**, the `canUpgrade` and `renewalStatus` properities are included the response and an array of `supportedCountries` property is added to the `billingAddress` information.  (optional) 
            var includeSuccessorPlans = includeSuccessorPlans_example;  // string | When set to **true**, excludes successor information from the response. (optional) 

            try
            {
                // Get Account Billing Plan
                BillingPlans result = apiInstance.BillingPlanGetBillingPlan(accountId, includeCreditCardInformation, includeMetadata, includeSuccessorPlans);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingPlansApi.BillingPlanGetBillingPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **includeCreditCardInformation** | **string**| When set to **true**, excludes credit card information from the response. | [optional] 
 **includeMetadata** | **string**| When set to **true**, the &#x60;canUpgrade&#x60; and &#x60;renewalStatus&#x60; properities are included the response and an array of &#x60;supportedCountries&#x60; property is added to the &#x60;billingAddress&#x60; information.  | [optional] 
 **includeSuccessorPlans** | **string**| When set to **true**, excludes successor information from the response. | [optional] 

### Return type

[**BillingPlans**](BillingPlans.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billingplangetcreditcardinfo"></a>
# **BillingPlanGetCreditCardInfo**
> CreditCardInformation BillingPlanGetCreditCardInfo (string accountId)

Get metadata for a given credit card.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BillingPlanGetCreditCardInfoExample
    {
        public void main()
        {
            
            var apiInstance = new BillingPlansApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Get metadata for a given credit card.
                CreditCardInformation result = apiInstance.BillingPlanGetCreditCardInfo(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingPlansApi.BillingPlanGetCreditCardInfo: " + e.Message );
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

[**CreditCardInformation**](CreditCardInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billingplanputbillingplan"></a>
# **BillingPlanPutBillingPlan**
> BillingPlanUpdateResponse BillingPlanPutBillingPlan (string accountId, string previewBillingPlan = null, BillingPlanInformation billingPlanInformation = null)

Updates the account billing plan.

Updates the billing plan information, billing address, and credit card information for the specified account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BillingPlanPutBillingPlanExample
    {
        public void main()
        {
            
            var apiInstance = new BillingPlansApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var previewBillingPlan = previewBillingPlan_example;  // string | When set to **true**, updates the account using a preview billing plan. (optional) 
            var billingPlanInformation = new BillingPlanInformation(); // BillingPlanInformation |  (optional) 

            try
            {
                // Updates the account billing plan.
                BillingPlanUpdateResponse result = apiInstance.BillingPlanPutBillingPlan(accountId, previewBillingPlan, billingPlanInformation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingPlansApi.BillingPlanPutBillingPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **previewBillingPlan** | **string**| When set to **true**, updates the account using a preview billing plan. | [optional] 
 **billingPlanInformation** | [**BillingPlanInformation**](BillingPlanInformation.md)|  | [optional] 

### Return type

[**BillingPlanUpdateResponse**](BillingPlanUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billingplansgetbillingplan"></a>
# **BillingPlansGetBillingPlan**
> BillingPlanResponse BillingPlansGetBillingPlan (string billingPlanId)

Get the billing plan details.

Retrieves the billing plan details for the specified billing plan ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BillingPlansGetBillingPlanExample
    {
        public void main()
        {
            
            var apiInstance = new BillingPlansApi();
            var billingPlanId = billingPlanId_example;  // string | The ID of the billing plan being accessed.

            try
            {
                // Get the billing plan details.
                BillingPlanResponse result = apiInstance.BillingPlansGetBillingPlan(billingPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingPlansApi.BillingPlansGetBillingPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingPlanId** | **string**| The ID of the billing plan being accessed. | 

### Return type

[**BillingPlanResponse**](BillingPlanResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billingplansgetbillingplans"></a>
# **BillingPlansGetBillingPlans**
> BillingPlansResponse BillingPlansGetBillingPlans ()

Gets the list of available billing plans.

Retrieves a list of the billing plans associated with a distributor.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BillingPlansGetBillingPlansExample
    {
        public void main()
        {
            
            var apiInstance = new BillingPlansApi();

            try
            {
                // Gets the list of available billing plans.
                BillingPlansResponse result = apiInstance.BillingPlansGetBillingPlans();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingPlansApi.BillingPlansGetBillingPlans: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BillingPlansResponse**](BillingPlansResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchasedenvelopesputpurchasedenvelopes"></a>
# **PurchasedEnvelopesPutPurchasedEnvelopes**
> void PurchasedEnvelopesPutPurchasedEnvelopes (string accountId, PurchasedEnvelopesInformation purchasedEnvelopesInformation = null)

Reserverd: Purchase additional envelopes.

Reserved: At this time, this endpoint is limited to DocuSign internal use only. Completes the purchase of envelopes for your account. The actual purchase is done as part of an internal workflow interaction with an envelope vendor.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchasedEnvelopesPutPurchasedEnvelopesExample
    {
        public void main()
        {
            
            var apiInstance = new BillingPlansApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var purchasedEnvelopesInformation = new PurchasedEnvelopesInformation(); // PurchasedEnvelopesInformation |  (optional) 

            try
            {
                // Reserverd: Purchase additional envelopes.
                apiInstance.PurchasedEnvelopesPutPurchasedEnvelopes(accountId, purchasedEnvelopesInformation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingPlansApi.PurchasedEnvelopesPutPurchasedEnvelopes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **purchasedEnvelopesInformation** | [**PurchasedEnvelopesInformation**](PurchasedEnvelopesInformation.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

