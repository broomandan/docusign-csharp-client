# IO.Swagger.Api.ServicesApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ServiceInformationGetServiceInformation**](ServicesApi.md#serviceinformationgetserviceinformation) | **GET** /service_information | Retrieves the available REST API versions.


<a name="serviceinformationgetserviceinformation"></a>
# **ServiceInformationGetServiceInformation**
> Services ServiceInformationGetServiceInformation ()

Retrieves the available REST API versions.

Retrieves the available REST API versions.  DocuSign Production system: https://www.docusign.net/restapi/service_information DocuSign Demo system: https://demo.docusign.net/restapi/service_information  You do not need an integrator key to view the REST API versions and resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceInformationGetServiceInformationExample
    {
        public void main()
        {
            
            var apiInstance = new ServicesApi();

            try
            {
                // Retrieves the available REST API versions.
                Services result = apiInstance.ServiceInformationGetServiceInformation();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServicesApi.ServiceInformationGetServiceInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Services**](Services.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

