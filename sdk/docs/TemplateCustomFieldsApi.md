# IO.Swagger.Api.TemplateCustomFieldsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CustomFieldsDeleteTemplateCustomFields**](TemplateCustomFieldsApi.md#customfieldsdeletetemplatecustomfields) | **DELETE** /v2/accounts/{accountId}/templates/{templateId}/custom_fields | Deletes envelope custom fields in a template.
[**CustomFieldsGetTemplateCustomFields**](TemplateCustomFieldsApi.md#customfieldsgettemplatecustomfields) | **GET** /v2/accounts/{accountId}/templates/{templateId}/custom_fields | Gets the custom document fields from a template.
[**CustomFieldsPostTemplateCustomFields**](TemplateCustomFieldsApi.md#customfieldsposttemplatecustomfields) | **POST** /v2/accounts/{accountId}/templates/{templateId}/custom_fields | Creates custom document fields in an existing template document.
[**CustomFieldsPutTemplateCustomFields**](TemplateCustomFieldsApi.md#customfieldsputtemplatecustomfields) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/custom_fields | Updates envelope custom fields in a template.


<a name="customfieldsdeletetemplatecustomfields"></a>
# **CustomFieldsDeleteTemplateCustomFields**
> TemplateCustomFields CustomFieldsDeleteTemplateCustomFields (string accountId, string templateId, TemplateCustomFields templateCustomFields = null)

Deletes envelope custom fields in a template.

Deletes envelope custom fields in a template.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomFieldsDeleteTemplateCustomFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateCustomFieldsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var templateCustomFields = new TemplateCustomFields(); // TemplateCustomFields |  (optional) 

            try
            {
                // Deletes envelope custom fields in a template.
                TemplateCustomFields result = apiInstance.CustomFieldsDeleteTemplateCustomFields(accountId, templateId, templateCustomFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateCustomFieldsApi.CustomFieldsDeleteTemplateCustomFields: " + e.Message );
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
 **templateCustomFields** | [**TemplateCustomFields**](TemplateCustomFields.md)|  | [optional] 

### Return type

[**TemplateCustomFields**](TemplateCustomFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customfieldsgettemplatecustomfields"></a>
# **CustomFieldsGetTemplateCustomFields**
> TemplateCustomFields CustomFieldsGetTemplateCustomFields (string accountId, string templateId)

Gets the custom document fields from a template.

Retrieves the custom document field information from an existing template.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomFieldsGetTemplateCustomFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateCustomFieldsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Gets the custom document fields from a template.
                TemplateCustomFields result = apiInstance.CustomFieldsGetTemplateCustomFields(accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateCustomFieldsApi.CustomFieldsGetTemplateCustomFields: " + e.Message );
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

[**TemplateCustomFields**](TemplateCustomFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customfieldsposttemplatecustomfields"></a>
# **CustomFieldsPostTemplateCustomFields**
> TemplateCustomFields CustomFieldsPostTemplateCustomFields (string accountId, string templateId, TemplateCustomFields templateCustomFields = null)

Creates custom document fields in an existing template document.

Creates custom document fields in an existing template document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomFieldsPostTemplateCustomFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateCustomFieldsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var templateCustomFields = new TemplateCustomFields(); // TemplateCustomFields |  (optional) 

            try
            {
                // Creates custom document fields in an existing template document.
                TemplateCustomFields result = apiInstance.CustomFieldsPostTemplateCustomFields(accountId, templateId, templateCustomFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateCustomFieldsApi.CustomFieldsPostTemplateCustomFields: " + e.Message );
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
 **templateCustomFields** | [**TemplateCustomFields**](TemplateCustomFields.md)|  | [optional] 

### Return type

[**TemplateCustomFields**](TemplateCustomFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customfieldsputtemplatecustomfields"></a>
# **CustomFieldsPutTemplateCustomFields**
> TemplateCustomFields CustomFieldsPutTemplateCustomFields (string accountId, string templateId, TemplateCustomFields templateCustomFields = null)

Updates envelope custom fields in a template.

Updates the custom fields in a template.  Each custom field used in a template must have a unique name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomFieldsPutTemplateCustomFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplateCustomFieldsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var templateCustomFields = new TemplateCustomFields(); // TemplateCustomFields |  (optional) 

            try
            {
                // Updates envelope custom fields in a template.
                TemplateCustomFields result = apiInstance.CustomFieldsPutTemplateCustomFields(accountId, templateId, templateCustomFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateCustomFieldsApi.CustomFieldsPutTemplateCustomFields: " + e.Message );
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
 **templateCustomFields** | [**TemplateCustomFields**](TemplateCustomFields.md)|  | [optional] 

### Return type

[**TemplateCustomFields**](TemplateCustomFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

