# IO.Swagger.Api.AccountCustomFieldsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountCustomFieldsDeleteAccountCustomFields**](AccountCustomFieldsApi.md#accountcustomfieldsdeleteaccountcustomfields) | **DELETE** /v2/accounts/{accountId}/custom_fields/{customFieldId} | Delete an existing account custom field.
[**AccountCustomFieldsGetAccountCustomFields**](AccountCustomFieldsApi.md#accountcustomfieldsgetaccountcustomfields) | **GET** /v2/accounts/{accountId}/custom_fields | Gets a list of custom fields associated with the account.
[**AccountCustomFieldsPostAccountCustomFields**](AccountCustomFieldsApi.md#accountcustomfieldspostaccountcustomfields) | **POST** /v2/accounts/{accountId}/custom_fields | Creates an acount custom field.
[**AccountCustomFieldsPutAccountCustomFields**](AccountCustomFieldsApi.md#accountcustomfieldsputaccountcustomfields) | **PUT** /v2/accounts/{accountId}/custom_fields/{customFieldId} | Updates an existing account custom field.


<a name="accountcustomfieldsdeleteaccountcustomfields"></a>
# **AccountCustomFieldsDeleteAccountCustomFields**
> void AccountCustomFieldsDeleteAccountCustomFields (string accountId, string customFieldId, string applyToTemplates = null)

Delete an existing account custom field.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountCustomFieldsDeleteAccountCustomFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new AccountCustomFieldsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var customFieldId = customFieldId_example;  // string | 
            var applyToTemplates = applyToTemplates_example;  // string |  (optional) 

            try
            {
                // Delete an existing account custom field.
                apiInstance.AccountCustomFieldsDeleteAccountCustomFields(accountId, customFieldId, applyToTemplates);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountCustomFieldsApi.AccountCustomFieldsDeleteAccountCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **customFieldId** | **string**|  | 
 **applyToTemplates** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountcustomfieldsgetaccountcustomfields"></a>
# **AccountCustomFieldsGetAccountCustomFields**
> AccountCustomFields AccountCustomFieldsGetAccountCustomFields (string accountId)

Gets a list of custom fields associated with the account.

Retrieves a list of envelope custom fields associated with the account. You can use these fields in the envelopes for your account to record information about the envelope, help search for envelopes and track information. The envelope custom fields are shown in the Envelope Settings section when a user is creating an envelope in the DocuSign member console. The envelope custom fields are not seen by the envelope recipients.  There are two types of envelope custom fields, text, and list. A text custom field lets the sender enter the value for the field. The list custom field lets the sender select the value of the field from a list you provide.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountCustomFieldsGetAccountCustomFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new AccountCustomFieldsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Gets a list of custom fields associated with the account.
                AccountCustomFields result = apiInstance.AccountCustomFieldsGetAccountCustomFields(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountCustomFieldsApi.AccountCustomFieldsGetAccountCustomFields: " + e.Message );
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

[**AccountCustomFields**](AccountCustomFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountcustomfieldspostaccountcustomfields"></a>
# **AccountCustomFieldsPostAccountCustomFields**
> AccountCustomFields AccountCustomFieldsPostAccountCustomFields (string accountId, string applyToTemplates = null, CustomField customField = null)

Creates an acount custom field.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountCustomFieldsPostAccountCustomFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new AccountCustomFieldsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var applyToTemplates = applyToTemplates_example;  // string |  (optional) 
            var customField = new CustomField(); // CustomField |  (optional) 

            try
            {
                // Creates an acount custom field.
                AccountCustomFields result = apiInstance.AccountCustomFieldsPostAccountCustomFields(accountId, applyToTemplates, customField);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountCustomFieldsApi.AccountCustomFieldsPostAccountCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **applyToTemplates** | **string**|  | [optional] 
 **customField** | [**CustomField**](CustomField.md)|  | [optional] 

### Return type

[**AccountCustomFields**](AccountCustomFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountcustomfieldsputaccountcustomfields"></a>
# **AccountCustomFieldsPutAccountCustomFields**
> AccountCustomFields AccountCustomFieldsPutAccountCustomFields (string accountId, string customFieldId, string applyToTemplates = null, CustomField customField = null)

Updates an existing account custom field.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountCustomFieldsPutAccountCustomFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new AccountCustomFieldsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var customFieldId = customFieldId_example;  // string | 
            var applyToTemplates = applyToTemplates_example;  // string |  (optional) 
            var customField = new CustomField(); // CustomField |  (optional) 

            try
            {
                // Updates an existing account custom field.
                AccountCustomFields result = apiInstance.AccountCustomFieldsPutAccountCustomFields(accountId, customFieldId, applyToTemplates, customField);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountCustomFieldsApi.AccountCustomFieldsPutAccountCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **customFieldId** | **string**|  | 
 **applyToTemplates** | **string**|  | [optional] 
 **customField** | [**CustomField**](CustomField.md)|  | [optional] 

### Return type

[**AccountCustomFields**](AccountCustomFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

