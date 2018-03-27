# IO.Swagger.Api.ResourcesApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ServiceInformationGetResourceInformation**](ResourcesApi.md#serviceinformationgetresourceinformation) | **GET** /v2 | Lists resources for REST version specified


<a name="serviceinformationgetresourceinformation"></a>
# **ServiceInformationGetResourceInformation**
> Resources ServiceInformationGetResourceInformation ()

Lists resources for REST version specified

Retrieves the base resources available for the DocuSign REST APIs.  You do not need an integrator key to view the REST API versions and resources.  Example: https://demo.docusign.net/restapi/v2 lists all of the base resources available in version 2 of the REST API on the DocuSign Demo system.  To view descriptions and samples of the service operations for all versions, remove the version number and add /help to the URL.  Example: https://demo.docusign.net/restapi/help lists the REST API operations on the DocuSign Demo system with XML and JSON request and response samples.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceInformationGetResourceInformationExample
    {
        public void main()
        {
            
            var apiInstance = new ResourcesApi();

            try
            {
                // Lists resources for REST version specified
                Resources result = apiInstance.ServiceInformationGetResourceInformation();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.ServiceInformationGetResourceInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Resources**](Resources.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

