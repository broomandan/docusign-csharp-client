# IO.Swagger.Api.ContactsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContactsDeleteContactWithId**](ContactsApi.md#contactsdeletecontactwithid) | **DELETE** /v2/accounts/{accountId}/contacts/{contactId} | Replaces a particular contact associated with an account for the DocuSign service.
[**ContactsDeleteContacts**](ContactsApi.md#contactsdeletecontacts) | **DELETE** /v2/accounts/{accountId}/contacts | Delete contacts associated with an account for the DocuSign service.
[**ContactsGetContactById**](ContactsApi.md#contactsgetcontactbyid) | **GET** /v2/accounts/{accountId}/contacts/{contactId} | Gets a particular contact associated with the user&#39;s account.
[**ContactsPostContacts**](ContactsApi.md#contactspostcontacts) | **POST** /v2/accounts/{accountId}/contacts | Imports multiple new contacts into the contacts collection from CSV, JSON, or XML (based on content type).
[**ContactsPutContacts**](ContactsApi.md#contactsputcontacts) | **PUT** /v2/accounts/{accountId}/contacts | Replaces contacts associated with an account for the DocuSign service.


<a name="contactsdeletecontactwithid"></a>
# **ContactsDeleteContactWithId**
> ContactUpdateResponse ContactsDeleteContactWithId (string accountId, string contactId)

Replaces a particular contact associated with an account for the DocuSign service.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsDeleteContactWithIdExample
    {
        public void main()
        {
            
            var apiInstance = new ContactsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var contactId = contactId_example;  // string | The unique identifier of a person in the contacts address book.

            try
            {
                // Replaces a particular contact associated with an account for the DocuSign service.
                ContactUpdateResponse result = apiInstance.ContactsDeleteContactWithId(accountId, contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsDeleteContactWithId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **contactId** | **string**| The unique identifier of a person in the contacts address book. | 

### Return type

[**ContactUpdateResponse**](ContactUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsdeletecontacts"></a>
# **ContactsDeleteContacts**
> ContactUpdateResponse ContactsDeleteContacts (string accountId, ContactModRequest contactModRequest = null)

Delete contacts associated with an account for the DocuSign service.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsDeleteContactsExample
    {
        public void main()
        {
            
            var apiInstance = new ContactsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var contactModRequest = new ContactModRequest(); // ContactModRequest |  (optional) 

            try
            {
                // Delete contacts associated with an account for the DocuSign service.
                ContactUpdateResponse result = apiInstance.ContactsDeleteContacts(accountId, contactModRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsDeleteContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **contactModRequest** | [**ContactModRequest**](ContactModRequest.md)|  | [optional] 

### Return type

[**ContactUpdateResponse**](ContactUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsgetcontactbyid"></a>
# **ContactsGetContactById**
> ContactGetResponse ContactsGetContactById (string accountId, string contactId, string cloudProvider = null)

Gets a particular contact associated with the user's account.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsGetContactByIdExample
    {
        public void main()
        {
            
            var apiInstance = new ContactsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var contactId = contactId_example;  // string | The unique identifier of a person in the contacts address book.
            var cloudProvider = cloudProvider_example;  // string |  (optional) 

            try
            {
                // Gets a particular contact associated with the user's account.
                ContactGetResponse result = apiInstance.ContactsGetContactById(accountId, contactId, cloudProvider);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsGetContactById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **contactId** | **string**| The unique identifier of a person in the contacts address book. | 
 **cloudProvider** | **string**|  | [optional] 

### Return type

[**ContactGetResponse**](ContactGetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactspostcontacts"></a>
# **ContactsPostContacts**
> ContactUpdateResponse ContactsPostContacts (string accountId, ContactModRequest contactModRequest = null)

Imports multiple new contacts into the contacts collection from CSV, JSON, or XML (based on content type).



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsPostContactsExample
    {
        public void main()
        {
            
            var apiInstance = new ContactsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var contactModRequest = new ContactModRequest(); // ContactModRequest |  (optional) 

            try
            {
                // Imports multiple new contacts into the contacts collection from CSV, JSON, or XML (based on content type).
                ContactUpdateResponse result = apiInstance.ContactsPostContacts(accountId, contactModRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsPostContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **contactModRequest** | [**ContactModRequest**](ContactModRequest.md)|  | [optional] 

### Return type

[**ContactUpdateResponse**](ContactUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactsputcontacts"></a>
# **ContactsPutContacts**
> ContactUpdateResponse ContactsPutContacts (string accountId, ContactModRequest contactModRequest = null)

Replaces contacts associated with an account for the DocuSign service.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContactsPutContactsExample
    {
        public void main()
        {
            
            var apiInstance = new ContactsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var contactModRequest = new ContactModRequest(); // ContactModRequest |  (optional) 

            try
            {
                // Replaces contacts associated with an account for the DocuSign service.
                ContactUpdateResponse result = apiInstance.ContactsPutContacts(accountId, contactModRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsPutContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **contactModRequest** | [**ContactModRequest**](ContactModRequest.md)|  | [optional] 

### Return type

[**ContactUpdateResponse**](ContactUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

