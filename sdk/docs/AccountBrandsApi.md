# IO.Swagger.Api.AccountBrandsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BrandDeleteBrand**](AccountBrandsApi.md#branddeletebrand) | **DELETE** /v2/accounts/{accountId}/brands/{brandId} | Removes a brand.
[**BrandExportGetBrandExportFile**](AccountBrandsApi.md#brandexportgetbrandexportfile) | **GET** /v2/accounts/{accountId}/brands/{brandId}/file | Export a specific brand.
[**BrandGetBrand**](AccountBrandsApi.md#brandgetbrand) | **GET** /v2/accounts/{accountId}/brands/{brandId} | Get information for a specific brand.
[**BrandLogoDeleteBrandLogo**](AccountBrandsApi.md#brandlogodeletebrandlogo) | **DELETE** /v2/accounts/{accountId}/brands/{brandId}/logos/{logoType} | Delete one branding logo.
[**BrandLogoGetBrandLogo**](AccountBrandsApi.md#brandlogogetbrandlogo) | **GET** /v2/accounts/{accountId}/brands/{brandId}/logos/{logoType} | Obtains the specified image for a brand.
[**BrandLogoPutBrandLogo**](AccountBrandsApi.md#brandlogoputbrandlogo) | **PUT** /v2/accounts/{accountId}/brands/{brandId}/logos/{logoType} | Put one branding logo.
[**BrandPutBrand**](AccountBrandsApi.md#brandputbrand) | **PUT** /v2/accounts/{accountId}/brands/{brandId} | Updates an existing brand.
[**BrandResourcesGetBrandResources**](AccountBrandsApi.md#brandresourcesgetbrandresources) | **GET** /v2/accounts/{accountId}/brands/{brandId}/resources/{resourceContentType} | Returns the specified branding resource file.
[**BrandResourcesGetBrandResourcesList**](AccountBrandsApi.md#brandresourcesgetbrandresourceslist) | **GET** /v2/accounts/{accountId}/brands/{brandId}/resources | Returns the specified account&#39;s list of branding resources (metadata).
[**BrandResourcesPutBrandResources**](AccountBrandsApi.md#brandresourcesputbrandresources) | **PUT** /v2/accounts/{accountId}/brands/{brandId}/resources/{resourceContentType} | Uploads a branding resource file.
[**BrandsDeleteBrands**](AccountBrandsApi.md#brandsdeletebrands) | **DELETE** /v2/accounts/{accountId}/brands | Deletes one or more brand profiles.
[**BrandsGetBrands**](AccountBrandsApi.md#brandsgetbrands) | **GET** /v2/accounts/{accountId}/brands | Gets a list of brand profiles.
[**BrandsPostBrands**](AccountBrandsApi.md#brandspostbrands) | **POST** /v2/accounts/{accountId}/brands | Creates one or more brand profile files for the account.


<a name="branddeletebrand"></a>
# **BrandDeleteBrand**
> void BrandDeleteBrand (string accountId, string brandId)

Removes a brand.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandDeleteBrandExample
    {
        public void main()
        {
            
            var apiInstance = new AccountBrandsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var brandId = brandId_example;  // string | The unique identifier of a brand.

            try
            {
                // Removes a brand.
                apiInstance.BrandDeleteBrand(accountId, brandId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountBrandsApi.BrandDeleteBrand: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **brandId** | **string**| The unique identifier of a brand. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="brandexportgetbrandexportfile"></a>
# **BrandExportGetBrandExportFile**
> void BrandExportGetBrandExportFile (string accountId, string brandId)

Export a specific brand.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandExportGetBrandExportFileExample
    {
        public void main()
        {
            
            var apiInstance = new AccountBrandsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var brandId = brandId_example;  // string | The unique identifier of a brand.

            try
            {
                // Export a specific brand.
                apiInstance.BrandExportGetBrandExportFile(accountId, brandId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountBrandsApi.BrandExportGetBrandExportFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **brandId** | **string**| The unique identifier of a brand. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="brandgetbrand"></a>
# **BrandGetBrand**
> Brand BrandGetBrand (string accountId, string brandId, string includeExternalReferences = null, string includeLogos = null)

Get information for a specific brand.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandGetBrandExample
    {
        public void main()
        {
            
            var apiInstance = new AccountBrandsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var brandId = brandId_example;  // string | The unique identifier of a brand.
            var includeExternalReferences = includeExternalReferences_example;  // string |  (optional) 
            var includeLogos = includeLogos_example;  // string |  (optional) 

            try
            {
                // Get information for a specific brand.
                Brand result = apiInstance.BrandGetBrand(accountId, brandId, includeExternalReferences, includeLogos);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountBrandsApi.BrandGetBrand: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **brandId** | **string**| The unique identifier of a brand. | 
 **includeExternalReferences** | **string**|  | [optional] 
 **includeLogos** | **string**|  | [optional] 

### Return type

[**Brand**](Brand.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="brandlogodeletebrandlogo"></a>
# **BrandLogoDeleteBrandLogo**
> void BrandLogoDeleteBrandLogo (string accountId, string brandId, string logoType)

Delete one branding logo.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandLogoDeleteBrandLogoExample
    {
        public void main()
        {
            
            var apiInstance = new AccountBrandsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var brandId = brandId_example;  // string | The unique identifier of a brand.
            var logoType = logoType_example;  // string | One of **Primary**, **Secondary** or **Email**.

            try
            {
                // Delete one branding logo.
                apiInstance.BrandLogoDeleteBrandLogo(accountId, brandId, logoType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountBrandsApi.BrandLogoDeleteBrandLogo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **brandId** | **string**| The unique identifier of a brand. | 
 **logoType** | **string**| One of **Primary**, **Secondary** or **Email**. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="brandlogogetbrandlogo"></a>
# **BrandLogoGetBrandLogo**
> void BrandLogoGetBrandLogo (string accountId, string brandId, string logoType)

Obtains the specified image for a brand.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandLogoGetBrandLogoExample
    {
        public void main()
        {
            
            var apiInstance = new AccountBrandsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var brandId = brandId_example;  // string | The unique identifier of a brand.
            var logoType = logoType_example;  // string | One of **Primary**, **Secondary** or **Email**.

            try
            {
                // Obtains the specified image for a brand.
                apiInstance.BrandLogoGetBrandLogo(accountId, brandId, logoType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountBrandsApi.BrandLogoGetBrandLogo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **brandId** | **string**| The unique identifier of a brand. | 
 **logoType** | **string**| One of **Primary**, **Secondary** or **Email**. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="brandlogoputbrandlogo"></a>
# **BrandLogoPutBrandLogo**
> void BrandLogoPutBrandLogo (string accountId, string brandId, string logoType)

Put one branding logo.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandLogoPutBrandLogoExample
    {
        public void main()
        {
            
            var apiInstance = new AccountBrandsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var brandId = brandId_example;  // string | The unique identifier of a brand.
            var logoType = logoType_example;  // string | One of **Primary**, **Secondary** or **Email**.

            try
            {
                // Put one branding logo.
                apiInstance.BrandLogoPutBrandLogo(accountId, brandId, logoType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountBrandsApi.BrandLogoPutBrandLogo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **brandId** | **string**| The unique identifier of a brand. | 
 **logoType** | **string**| One of **Primary**, **Secondary** or **Email**. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="brandputbrand"></a>
# **BrandPutBrand**
> Brand BrandPutBrand (string accountId, string brandId, Brand brand = null)

Updates an existing brand.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandPutBrandExample
    {
        public void main()
        {
            
            var apiInstance = new AccountBrandsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var brandId = brandId_example;  // string | The unique identifier of a brand.
            var brand = new Brand(); // Brand |  (optional) 

            try
            {
                // Updates an existing brand.
                Brand result = apiInstance.BrandPutBrand(accountId, brandId, brand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountBrandsApi.BrandPutBrand: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **brandId** | **string**| The unique identifier of a brand. | 
 **brand** | [**Brand**](Brand.md)|  | [optional] 

### Return type

[**Brand**](Brand.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="brandresourcesgetbrandresources"></a>
# **BrandResourcesGetBrandResources**
> void BrandResourcesGetBrandResources (string accountId, string brandId, string resourceContentType, string langcode = null, string returnMaster = null)

Returns the specified branding resource file.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandResourcesGetBrandResourcesExample
    {
        public void main()
        {
            
            var apiInstance = new AccountBrandsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var brandId = brandId_example;  // string | The unique identifier of a brand.
            var resourceContentType = resourceContentType_example;  // string | 
            var langcode = langcode_example;  // string |  (optional) 
            var returnMaster = returnMaster_example;  // string |  (optional) 

            try
            {
                // Returns the specified branding resource file.
                apiInstance.BrandResourcesGetBrandResources(accountId, brandId, resourceContentType, langcode, returnMaster);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountBrandsApi.BrandResourcesGetBrandResources: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **brandId** | **string**| The unique identifier of a brand. | 
 **resourceContentType** | **string**|  | 
 **langcode** | **string**|  | [optional] 
 **returnMaster** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="brandresourcesgetbrandresourceslist"></a>
# **BrandResourcesGetBrandResourcesList**
> BrandResourcesList BrandResourcesGetBrandResourcesList (string accountId, string brandId)

Returns the specified account's list of branding resources (metadata).



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandResourcesGetBrandResourcesListExample
    {
        public void main()
        {
            
            var apiInstance = new AccountBrandsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var brandId = brandId_example;  // string | The unique identifier of a brand.

            try
            {
                // Returns the specified account's list of branding resources (metadata).
                BrandResourcesList result = apiInstance.BrandResourcesGetBrandResourcesList(accountId, brandId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountBrandsApi.BrandResourcesGetBrandResourcesList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **brandId** | **string**| The unique identifier of a brand. | 

### Return type

[**BrandResourcesList**](BrandResourcesList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="brandresourcesputbrandresources"></a>
# **BrandResourcesPutBrandResources**
> BrandResources BrandResourcesPutBrandResources (string accountId, string brandId, string resourceContentType)

Uploads a branding resource file.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandResourcesPutBrandResourcesExample
    {
        public void main()
        {
            
            var apiInstance = new AccountBrandsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var brandId = brandId_example;  // string | The unique identifier of a brand.
            var resourceContentType = resourceContentType_example;  // string | 

            try
            {
                // Uploads a branding resource file.
                BrandResources result = apiInstance.BrandResourcesPutBrandResources(accountId, brandId, resourceContentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountBrandsApi.BrandResourcesPutBrandResources: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **brandId** | **string**| The unique identifier of a brand. | 
 **resourceContentType** | **string**|  | 

### Return type

[**BrandResources**](BrandResources.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="brandsdeletebrands"></a>
# **BrandsDeleteBrands**
> AccountBrands BrandsDeleteBrands (string accountId, BrandsRequest brandsRequest = null)

Deletes one or more brand profiles.

Deletes one or more brand profiles from an account. The Account Branding feature (accountSettings properties `canSelfBrandSend` and `canSelfBrandSend`) must be set to **true** to use this call.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandsDeleteBrandsExample
    {
        public void main()
        {
            
            var apiInstance = new AccountBrandsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var brandsRequest = new BrandsRequest(); // BrandsRequest |  (optional) 

            try
            {
                // Deletes one or more brand profiles.
                AccountBrands result = apiInstance.BrandsDeleteBrands(accountId, brandsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountBrandsApi.BrandsDeleteBrands: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **brandsRequest** | [**BrandsRequest**](BrandsRequest.md)|  | [optional] 

### Return type

[**AccountBrands**](AccountBrands.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="brandsgetbrands"></a>
# **BrandsGetBrands**
> AccountBrands BrandsGetBrands (string accountId, string excludeDistributorBrand = null, string includeLogos = null)

Gets a list of brand profiles.

Retrieves the list of brand profiles associated with the account and the default brand profiles. The Account Branding feature (accountSettings properties `canSelfBrandSend` and `canSelfBrandSend`)  must be set to **true** for the account to use this call.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandsGetBrandsExample
    {
        public void main()
        {
            
            var apiInstance = new AccountBrandsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var excludeDistributorBrand = excludeDistributorBrand_example;  // string | When set to **true**, excludes distributor brand information from the response set. (optional) 
            var includeLogos = includeLogos_example;  // string | When set to **true**, returns the logos associated with the brand. (optional) 

            try
            {
                // Gets a list of brand profiles.
                AccountBrands result = apiInstance.BrandsGetBrands(accountId, excludeDistributorBrand, includeLogos);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountBrandsApi.BrandsGetBrands: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **excludeDistributorBrand** | **string**| When set to **true**, excludes distributor brand information from the response set. | [optional] 
 **includeLogos** | **string**| When set to **true**, returns the logos associated with the brand. | [optional] 

### Return type

[**AccountBrands**](AccountBrands.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="brandspostbrands"></a>
# **BrandsPostBrands**
> AccountBrands BrandsPostBrands (string accountId, Brand brand = null)

Creates one or more brand profile files for the account.

Creates one or more brand profile files for the account. The Account Branding feature (accountSettings properties `canSelfBrandSend` and `canSelfBrandSig`) must be set to **true** for the account to use this call.  An error is returned if `brandId` property for a brand profile is already set for the account. To upload a new version of an existing brand profile, you must delete the profile and then upload the newer version.  When brand profile files are being uploaded, they must be combined into one zip file and the `Content-Type` must be `application/zip`.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrandsPostBrandsExample
    {
        public void main()
        {
            
            var apiInstance = new AccountBrandsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var brand = new Brand(); // Brand |  (optional) 

            try
            {
                // Creates one or more brand profile files for the account.
                AccountBrands result = apiInstance.BrandsPostBrands(accountId, brand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountBrandsApi.BrandsPostBrands: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **brand** | [**Brand**](Brand.md)|  | [optional] 

### Return type

[**AccountBrands**](AccountBrands.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

