# Conekta.net.Api.ShippingContactsApi

All URIs are relative to *https://api.conekta.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCustomerShippingContacts**](ShippingContactsApi.md#createcustomershippingcontacts) | **POST** /customers/{id}/shipping_contacts | Create a shipping contacts |
| [**DeleteCustomerShippingContacts**](ShippingContactsApi.md#deletecustomershippingcontacts) | **DELETE** /customers/{id}/shipping_contacts/{shipping_contacts_id} | Delete shipping contacts |
| [**UpdateCustomerShippingContacts**](ShippingContactsApi.md#updatecustomershippingcontacts) | **PUT** /customers/{id}/shipping_contacts/{shipping_contacts_id} | Update shipping contacts |

<a name="createcustomershippingcontacts"></a>
# **CreateCustomerShippingContacts**
> CustomerShippingContactsResponse CreateCustomerShippingContacts (string id, CustomerShippingContacts customerShippingContacts, string acceptLanguage = null)

Create a shipping contacts

Create a shipping contacts for a customer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class CreateCustomerShippingContactsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShippingContactsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var customerShippingContacts = new CustomerShippingContacts(); // CustomerShippingContacts | requested field for customer shippings contacts
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)

            try
            {
                // Create a shipping contacts
                CustomerShippingContactsResponse result = apiInstance.CreateCustomerShippingContacts(id, customerShippingContacts, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShippingContactsApi.CreateCustomerShippingContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCustomerShippingContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a shipping contacts
    ApiResponse<CustomerShippingContactsResponse> response = apiInstance.CreateCustomerShippingContactsWithHttpInfo(id, customerShippingContacts, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShippingContactsApi.CreateCustomerShippingContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **customerShippingContacts** | [**CustomerShippingContacts**](CustomerShippingContacts.md) | requested field for customer shippings contacts |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |

### Return type

[**CustomerShippingContactsResponse**](CustomerShippingContactsResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.conekta-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **401** | authentication error |  -  |
| **404** | not found entity |  -  |
| **422** | parameter validation error |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomershippingcontacts"></a>
# **DeleteCustomerShippingContacts**
> CustomerShippingContactsResponse DeleteCustomerShippingContacts (string id, string shippingContactsId, string acceptLanguage = null)

Delete shipping contacts

Delete shipping contact that corresponds to a customer ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class DeleteCustomerShippingContactsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShippingContactsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var shippingContactsId = 6307a60c41de27127515a575;  // string | identifier
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)

            try
            {
                // Delete shipping contacts
                CustomerShippingContactsResponse result = apiInstance.DeleteCustomerShippingContacts(id, shippingContactsId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShippingContactsApi.DeleteCustomerShippingContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCustomerShippingContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete shipping contacts
    ApiResponse<CustomerShippingContactsResponse> response = apiInstance.DeleteCustomerShippingContactsWithHttpInfo(id, shippingContactsId, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShippingContactsApi.DeleteCustomerShippingContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **shippingContactsId** | **string** | identifier |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |

### Return type

[**CustomerShippingContactsResponse**](CustomerShippingContactsResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.conekta-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **401** | authentication error |  -  |
| **404** | not found entity |  -  |
| **422** | parameter validation error |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomershippingcontacts"></a>
# **UpdateCustomerShippingContacts**
> CustomerShippingContactsResponse UpdateCustomerShippingContacts (string id, string shippingContactsId, CustomerUpdateShippingContacts customerUpdateShippingContacts, string acceptLanguage = null)

Update shipping contacts

Update shipping contact that corresponds to a customer ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class UpdateCustomerShippingContactsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShippingContactsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var shippingContactsId = 6307a60c41de27127515a575;  // string | identifier
            var customerUpdateShippingContacts = new CustomerUpdateShippingContacts(); // CustomerUpdateShippingContacts | requested field for customer update shippings contacts
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)

            try
            {
                // Update shipping contacts
                CustomerShippingContactsResponse result = apiInstance.UpdateCustomerShippingContacts(id, shippingContactsId, customerUpdateShippingContacts, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShippingContactsApi.UpdateCustomerShippingContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCustomerShippingContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update shipping contacts
    ApiResponse<CustomerShippingContactsResponse> response = apiInstance.UpdateCustomerShippingContactsWithHttpInfo(id, shippingContactsId, customerUpdateShippingContacts, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShippingContactsApi.UpdateCustomerShippingContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **shippingContactsId** | **string** | identifier |  |
| **customerUpdateShippingContacts** | [**CustomerUpdateShippingContacts**](CustomerUpdateShippingContacts.md) | requested field for customer update shippings contacts |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |

### Return type

[**CustomerShippingContactsResponse**](CustomerShippingContactsResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.conekta-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **401** | authentication error |  -  |
| **404** | not found entity |  -  |
| **422** | parameter validation error |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

