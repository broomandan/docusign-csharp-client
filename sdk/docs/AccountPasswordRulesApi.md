# IO.Swagger.Api.AccountPasswordRulesApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountPasswordRulesGetAccountPasswordRules**](AccountPasswordRulesApi.md#accountpasswordrulesgetaccountpasswordrules) | **GET** /v2/accounts/{accountId}/settings/password_rules | Get the password rules
[**AccountPasswordRulesPutAccountPasswordRules**](AccountPasswordRulesApi.md#accountpasswordrulesputaccountpasswordrules) | **PUT** /v2/accounts/{accountId}/settings/password_rules | Update the password rules
[**PasswordRulesGetPasswordRules**](AccountPasswordRulesApi.md#passwordrulesgetpasswordrules) | **GET** /v2/current_user/password_rules | Get membership account password rules


<a name="accountpasswordrulesgetaccountpasswordrules"></a>
# **AccountPasswordRulesGetAccountPasswordRules**
> AccountPasswordRules AccountPasswordRulesGetAccountPasswordRules (string accountId)

Get the password rules



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountPasswordRulesGetAccountPasswordRulesExample
    {
        public void main()
        {
            
            var apiInstance = new AccountPasswordRulesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Get the password rules
                AccountPasswordRules result = apiInstance.AccountPasswordRulesGetAccountPasswordRules(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountPasswordRulesApi.AccountPasswordRulesGetAccountPasswordRules: " + e.Message );
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

[**AccountPasswordRules**](AccountPasswordRules.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountpasswordrulesputaccountpasswordrules"></a>
# **AccountPasswordRulesPutAccountPasswordRules**
> AccountPasswordRules AccountPasswordRulesPutAccountPasswordRules (string accountId, AccountPasswordRules accountPasswordRules = null)

Update the password rules



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountPasswordRulesPutAccountPasswordRulesExample
    {
        public void main()
        {
            
            var apiInstance = new AccountPasswordRulesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var accountPasswordRules = new AccountPasswordRules(); // AccountPasswordRules |  (optional) 

            try
            {
                // Update the password rules
                AccountPasswordRules result = apiInstance.AccountPasswordRulesPutAccountPasswordRules(accountId, accountPasswordRules);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountPasswordRulesApi.AccountPasswordRulesPutAccountPasswordRules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **accountPasswordRules** | [**AccountPasswordRules**](AccountPasswordRules.md)|  | [optional] 

### Return type

[**AccountPasswordRules**](AccountPasswordRules.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="passwordrulesgetpasswordrules"></a>
# **PasswordRulesGetPasswordRules**
> UserPasswordRules PasswordRulesGetPasswordRules ()

Get membership account password rules



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PasswordRulesGetPasswordRulesExample
    {
        public void main()
        {
            
            var apiInstance = new AccountPasswordRulesApi();

            try
            {
                // Get membership account password rules
                UserPasswordRules result = apiInstance.PasswordRulesGetPasswordRules();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountPasswordRulesApi.PasswordRulesGetPasswordRules: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserPasswordRules**](UserPasswordRules.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

