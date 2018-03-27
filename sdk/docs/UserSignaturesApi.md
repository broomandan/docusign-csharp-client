# IO.Swagger.Api.UserSignaturesApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UserSignaturesDeleteUserSignature**](UserSignaturesApi.md#usersignaturesdeleteusersignature) | **DELETE** /v2/accounts/{accountId}/users/{userId}/signatures/{signatureId} | Removes removes signature information for the specified user.
[**UserSignaturesDeleteUserSignatureImage**](UserSignaturesApi.md#usersignaturesdeleteusersignatureimage) | **DELETE** /v2/accounts/{accountId}/users/{userId}/signatures/{signatureId}/{imageType} | Deletes the user initials image or the  user signature image for the specified user.
[**UserSignaturesGetUserSignature**](UserSignaturesApi.md#usersignaturesgetusersignature) | **GET** /v2/accounts/{accountId}/users/{userId}/signatures/{signatureId} | Gets the user signature information for the specified user.
[**UserSignaturesGetUserSignatureImage**](UserSignaturesApi.md#usersignaturesgetusersignatureimage) | **GET** /v2/accounts/{accountId}/users/{userId}/signatures/{signatureId}/{imageType} | Retrieves the user initials image or the  user signature image for the specified user.
[**UserSignaturesGetUserSignatures**](UserSignaturesApi.md#usersignaturesgetusersignatures) | **GET** /v2/accounts/{accountId}/users/{userId}/signatures | Retrieves a list of user signature definitions for a specified user.
[**UserSignaturesPostUserSignatures**](UserSignaturesApi.md#usersignaturespostusersignatures) | **POST** /v2/accounts/{accountId}/users/{userId}/signatures | Adds user Signature and initials images to a Signature.
[**UserSignaturesPutUserSignature**](UserSignaturesApi.md#usersignaturesputusersignature) | **PUT** /v2/accounts/{accountId}/users/{userId}/signatures | Adds/updates a user signature.
[**UserSignaturesPutUserSignatureById**](UserSignaturesApi.md#usersignaturesputusersignaturebyid) | **PUT** /v2/accounts/{accountId}/users/{userId}/signatures/{signatureId} | Updates the user signature for a specified user.
[**UserSignaturesPutUserSignatureImage**](UserSignaturesApi.md#usersignaturesputusersignatureimage) | **PUT** /v2/accounts/{accountId}/users/{userId}/signatures/{signatureId}/{imageType} | Updates the user signature image or user initials image for the specified user.


<a name="usersignaturesdeleteusersignature"></a>
# **UserSignaturesDeleteUserSignature**
> void UserSignaturesDeleteUserSignature (string accountId, string signatureId, string userId)

Removes removes signature information for the specified user.

Removes the signature information for the user.  The userId parameter specified in the endpoint must match the authenticated user's user ID and the user must be a member of the account.  The `signatureId` accepts a signature ID or a signature name. DocuSign recommends you use signature ID (`signatureId`), since some names contain characters that do not properly encode into a URL. If you use the user name, it is likely that the name includes spaces. In that case, URL encode the name before using it in the endpoint.   For example encode \"Bob Smith\" as \"Bob%20Smith\".

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserSignaturesDeleteUserSignatureExample
    {
        public void main()
        {
            
            var apiInstance = new UserSignaturesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var signatureId = signatureId_example;  // string | The ID of the signature being accessed.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Removes removes signature information for the specified user.
                apiInstance.UserSignaturesDeleteUserSignature(accountId, signatureId, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserSignaturesApi.UserSignaturesDeleteUserSignature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **signatureId** | **string**| The ID of the signature being accessed. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersignaturesdeleteusersignatureimage"></a>
# **UserSignaturesDeleteUserSignatureImage**
> UserSignatures UserSignaturesDeleteUserSignatureImage (string accountId, string imageType, string signatureId, string userId)

Deletes the user initials image or the  user signature image for the specified user.

Deletes the specified initials image or signature image for the specified user.  The function deletes one or the other of the image types, to delete both the initials image and signature image you must call the endpoint twice.  The userId parameter specified in the endpoint must match the authenticated user's user ID and the user must be a member of the account.  The `signatureId` parameter accepts a signature ID or a signature name. DocuSign recommends you use signature ID (`signatureId`), since some names contain characters that do not properly encode into a URL. If you use the user name, it is likely that the name includes spaces. In that case, URL encode the name before using it in the endpoint.   For example encode \"Bob Smith\" as \"Bob%20Smith\".

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserSignaturesDeleteUserSignatureImageExample
    {
        public void main()
        {
            
            var apiInstance = new UserSignaturesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var imageType = imageType_example;  // string | One of **signature_image** or **initials_image**.
            var signatureId = signatureId_example;  // string | The ID of the signature being accessed.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Deletes the user initials image or the  user signature image for the specified user.
                UserSignatures result = apiInstance.UserSignaturesDeleteUserSignatureImage(accountId, imageType, signatureId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserSignaturesApi.UserSignaturesDeleteUserSignatureImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **imageType** | **string**| One of **signature_image** or **initials_image**. | 
 **signatureId** | **string**| The ID of the signature being accessed. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 

### Return type

[**UserSignatures**](UserSignatures.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersignaturesgetusersignature"></a>
# **UserSignaturesGetUserSignature**
> UserSignatures UserSignaturesGetUserSignature (string accountId, string signatureId, string userId)

Gets the user signature information for the specified user.

Retrieves the structure of a single signature with a known signature name.  The userId specified in the endpoint must match the authenticated user's user ID and the user must be a member of the account.  The `signatureId` parameter accepts a signature ID or a signature name. DocuSign recommends you use signature ID (`signatureId`), since some names contain characters that do not properly encode into a URL. If you use the user name, it is likely that the name includes spaces. In that case, URL encode the name before using it in the endpoint.   For example encode \"Bob Smith\" as \"Bob%20Smith\".

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserSignaturesGetUserSignatureExample
    {
        public void main()
        {
            
            var apiInstance = new UserSignaturesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var signatureId = signatureId_example;  // string | The ID of the signature being accessed.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Gets the user signature information for the specified user.
                UserSignatures result = apiInstance.UserSignaturesGetUserSignature(accountId, signatureId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserSignaturesApi.UserSignaturesGetUserSignature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **signatureId** | **string**| The ID of the signature being accessed. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 

### Return type

[**UserSignatures**](UserSignatures.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersignaturesgetusersignatureimage"></a>
# **UserSignaturesGetUserSignatureImage**
> System.IO.Stream UserSignaturesGetUserSignatureImage (string accountId, string imageType, string signatureId, string userId, string includeChrome = null)

Retrieves the user initials image or the  user signature image for the specified user.

Retrieves the specified initials image or signature image for the specified user. The image is returned in the same format as uploaded. In the request you can specify if the chrome (the added line and identifier around the initial image) is returned with the image.  The userId property specified in the endpoint must match the authenticated user's user ID and the user must be a member of the account.  The `signatureId` parameter accepts a signature ID or a signature name. DocuSign recommends you use signature ID (`signatureId`), since some names contain characters that do not properly encode into a URL. If you use the user name, it is likely that the name includes spaces. In that case, URL encode the name before using it in the endpoint.   For example encode \"Bob Smith\" as \"Bob%20Smith\".  ###### Note: Older envelopes might only have chromed images. If getting the non-chromed image fails, try getting the chromed image.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserSignaturesGetUserSignatureImageExample
    {
        public void main()
        {
            
            var apiInstance = new UserSignaturesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var imageType = imageType_example;  // string | One of **signature_image** or **initials_image**.
            var signatureId = signatureId_example;  // string | The ID of the signature being accessed.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var includeChrome = includeChrome_example;  // string |  (optional) 

            try
            {
                // Retrieves the user initials image or the  user signature image for the specified user.
                System.IO.Stream result = apiInstance.UserSignaturesGetUserSignatureImage(accountId, imageType, signatureId, userId, includeChrome);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserSignaturesApi.UserSignaturesGetUserSignatureImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **imageType** | **string**| One of **signature_image** or **initials_image**. | 
 **signatureId** | **string**| The ID of the signature being accessed. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **includeChrome** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/gif

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersignaturesgetusersignatures"></a>
# **UserSignaturesGetUserSignatures**
> UserSignaturesInformation UserSignaturesGetUserSignatures (string accountId, string userId, string stampType = null)

Retrieves a list of user signature definitions for a specified user.

Retrieves the signature definitions for the specified user.  The userId parameter specified in the endpoint must match the authenticated user's user ID and the user must be a member of the account.  The `signatureId` parameter accepts a signature ID or a signature name. DocuSign recommends you use signature ID (`signatureId`), since some names contain characters that do not properly encode into a URL. If you use the user name, it is likely that the name includes spaces. In that case, URL encode the name before using it in the endpoint.   For example encode \"Bob Smith\" as \"Bob%20Smith\".

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserSignaturesGetUserSignaturesExample
    {
        public void main()
        {
            
            var apiInstance = new UserSignaturesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var stampType = stampType_example;  // string |  (optional) 

            try
            {
                // Retrieves a list of user signature definitions for a specified user.
                UserSignaturesInformation result = apiInstance.UserSignaturesGetUserSignatures(accountId, userId, stampType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserSignaturesApi.UserSignaturesGetUserSignatures: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **stampType** | **string**|  | [optional] 

### Return type

[**UserSignaturesInformation**](UserSignaturesInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersignaturespostusersignatures"></a>
# **UserSignaturesPostUserSignatures**
> UserSignaturesInformation UserSignaturesPostUserSignatures (string accountId, string userId, UserSignaturesInformation userSignaturesInformation = null)

Adds user Signature and initials images to a Signature.

Adds a user signature image and/or user initials image to the specified user.   The userId property specified in the endpoint must match the authenticated user's userId and the user must be a member of the account.  The rules and processes associated with this are:  * If Content-Type is set to application/json, then the default behavior for creating a default signature image, based on the name and a DocuSign font, is used. * If Content-Type is set to multipart/form-data, then the request must contain a first part with the user signature information, followed by parts that contain the images.  For each Image part, the Content-Disposition header has a \"filename\" value that is used to map to the `signatureName` and/or `signatureInitials` properties in the JSON to the image.   For example:  `Content-Disposition: file; filename=\"Ron Test20121127083900\"`  If no matching image (by filename value) is found, then the image is not set. One, both, or neither of the signature and initials images can be set with this call.  The Content-Transfer-Encoding: base64 header, set in the header for the part containing the image, can be set to indicate that the images are formatted as base64 instead of as binary.  If successful, 200-OK is returned, and a JSON structure containing the signature information is provided, note that the signatureId can change with each API POST, PUT, or DELETE since the changes to the signature structure cause the current signature to be closed, and a new signature record to be created.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserSignaturesPostUserSignaturesExample
    {
        public void main()
        {
            
            var apiInstance = new UserSignaturesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var userSignaturesInformation = new UserSignaturesInformation(); // UserSignaturesInformation |  (optional) 

            try
            {
                // Adds user Signature and initials images to a Signature.
                UserSignaturesInformation result = apiInstance.UserSignaturesPostUserSignatures(accountId, userId, userSignaturesInformation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserSignaturesApi.UserSignaturesPostUserSignatures: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **userSignaturesInformation** | [**UserSignaturesInformation**](UserSignaturesInformation.md)|  | [optional] 

### Return type

[**UserSignaturesInformation**](UserSignaturesInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersignaturesputusersignature"></a>
# **UserSignaturesPutUserSignature**
> UserSignaturesInformation UserSignaturesPutUserSignature (string accountId, string userId, UserSignaturesInformation userSignaturesInformation = null)

Adds/updates a user signature.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserSignaturesPutUserSignatureExample
    {
        public void main()
        {
            
            var apiInstance = new UserSignaturesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var userSignaturesInformation = new UserSignaturesInformation(); // UserSignaturesInformation |  (optional) 

            try
            {
                // Adds/updates a user signature.
                UserSignaturesInformation result = apiInstance.UserSignaturesPutUserSignature(accountId, userId, userSignaturesInformation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserSignaturesApi.UserSignaturesPutUserSignature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **userSignaturesInformation** | [**UserSignaturesInformation**](UserSignaturesInformation.md)|  | [optional] 

### Return type

[**UserSignaturesInformation**](UserSignaturesInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersignaturesputusersignaturebyid"></a>
# **UserSignaturesPutUserSignatureById**
> UserSignatures UserSignaturesPutUserSignatureById (string accountId, string signatureId, string userId, string closeExistingSignature = null, UserSignatureDefinition userSignatureDefinition = null)

Updates the user signature for a specified user.

Creates, or updates, the signature font and initials for the specified user. When creating a signature, you use this resource to create the signature name and then add the signature and initials images into the signature.  ###### Note: This will also create a default signature for the user when one does not exist.  The userId property specified in the endpoint must match the authenticated user's user ID and the user must be a member of the account.  The `signatureId` parameter accepts a signature ID or a signature name. DocuSign recommends you use signature ID (`signatureId`), since some names contain characters that do not properly encode into a URL. If you use the user name, it is likely that the name includes spaces. In that case, URL encode the name before using it in the endpoint.   For example encode \"Bob Smith\" as \"Bob%20Smith\".

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserSignaturesPutUserSignatureByIdExample
    {
        public void main()
        {
            
            var apiInstance = new UserSignaturesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var signatureId = signatureId_example;  // string | The ID of the signature being accessed.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var closeExistingSignature = closeExistingSignature_example;  // string | When set to **true**, closes the current signature. (optional) 
            var userSignatureDefinition = new UserSignatureDefinition(); // UserSignatureDefinition |  (optional) 

            try
            {
                // Updates the user signature for a specified user.
                UserSignatures result = apiInstance.UserSignaturesPutUserSignatureById(accountId, signatureId, userId, closeExistingSignature, userSignatureDefinition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserSignaturesApi.UserSignaturesPutUserSignatureById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **signatureId** | **string**| The ID of the signature being accessed. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **closeExistingSignature** | **string**| When set to **true**, closes the current signature. | [optional] 
 **userSignatureDefinition** | [**UserSignatureDefinition**](UserSignatureDefinition.md)|  | [optional] 

### Return type

[**UserSignatures**](UserSignatures.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersignaturesputusersignatureimage"></a>
# **UserSignaturesPutUserSignatureImage**
> UserSignatures UserSignaturesPutUserSignatureImage (string accountId, string imageType, string signatureId, string userId)

Updates the user signature image or user initials image for the specified user.

Updates the user signature image or user initials image for the specified user. The supported image formats for this file are: gif, png, jpeg, and bmp. The file must be less than 200K.  The userId property specified in the endpoint must match the authenticated user's user ID and the user must be a member of the account.  The `signatureId` parameter accepts a signature ID or a signature name. DocuSign recommends you use signature ID (`signatureId`), since some names contain characters that do not properly encode into a URL. If you use the user name, it is likely that the name includes spaces. In that case, URL encode the name before using it in the endpoint.   For example encode \"Bob Smith\" as \"Bob%20Smith\". 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserSignaturesPutUserSignatureImageExample
    {
        public void main()
        {
            
            var apiInstance = new UserSignaturesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var imageType = imageType_example;  // string | One of **signature_image** or **initials_image**.
            var signatureId = signatureId_example;  // string | The ID of the signature being accessed.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Updates the user signature image or user initials image for the specified user.
                UserSignatures result = apiInstance.UserSignaturesPutUserSignatureImage(accountId, imageType, signatureId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserSignaturesApi.UserSignaturesPutUserSignatureImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **imageType** | **string**| One of **signature_image** or **initials_image**. | 
 **signatureId** | **string**| The ID of the signature being accessed. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 

### Return type

[**UserSignatures**](UserSignatures.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

