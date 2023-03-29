# Conekta.net.Api.PaymentMethodsApi

All URIs are relative to *https://api.conekta.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCustomerPaymentSources**](PaymentMethodsApi.md#createcustomerpaymentsources) | **POST** /customers/{id}/payment_sources | Create Payment Method |
| [**DeleteCustomerPaymentSources**](PaymentMethodsApi.md#deletecustomerpaymentsources) | **DELETE** /customers/{id}/payment_sources/{payment_sources_id} | Delete Payment Method |
| [**GetCustomerPaymentSources**](PaymentMethodsApi.md#getcustomerpaymentsources) | **GET** /customers/{id}/payment_sources | Get Payment Methods |
| [**UpdateCustomerPaymentSources**](PaymentMethodsApi.md#updatecustomerpaymentsources) | **PUT** /customers/{id}/payment_sources/{payment_sources_id} | Update Payment Method |

<a name="createcustomerpaymentsources"></a>
# **CreateCustomerPaymentSources**
> CreateCustomerPaymentSourcesResponse CreateCustomerPaymentSources (string id, CreateCustomerPaymentSourcesRequest createCustomerPaymentSourcesRequest, string acceptLanguage = null)

Create Payment Method

Create a payment method for a customer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class CreateCustomerPaymentSourcesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PaymentMethodsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var createCustomerPaymentSourcesRequest = new CreateCustomerPaymentSourcesRequest(); // CreateCustomerPaymentSourcesRequest | requested field for customer payment sources
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)

            try
            {
                // Create Payment Method
                CreateCustomerPaymentSourcesResponse result = apiInstance.CreateCustomerPaymentSources(id, createCustomerPaymentSourcesRequest, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentMethodsApi.CreateCustomerPaymentSources: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCustomerPaymentSourcesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Payment Method
    ApiResponse<CreateCustomerPaymentSourcesResponse> response = apiInstance.CreateCustomerPaymentSourcesWithHttpInfo(id, createCustomerPaymentSourcesRequest, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentMethodsApi.CreateCustomerPaymentSourcesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **createCustomerPaymentSourcesRequest** | [**CreateCustomerPaymentSourcesRequest**](CreateCustomerPaymentSourcesRequest.md) | requested field for customer payment sources |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |

### Return type

[**CreateCustomerPaymentSourcesResponse**](CreateCustomerPaymentSourcesResponse.md)

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

<a name="deletecustomerpaymentsources"></a>
# **DeleteCustomerPaymentSources**
> UpdateCustomerPaymentSourcesResponse DeleteCustomerPaymentSources (string id, string paymentSourcesId, string acceptLanguage = null)

Delete Payment Method

Delete an existing payment method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class DeleteCustomerPaymentSourcesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PaymentMethodsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var paymentSourcesId = src_2tQ974hSHcsdeSZHG;  // string | Identifier of the payment method
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)

            try
            {
                // Delete Payment Method
                UpdateCustomerPaymentSourcesResponse result = apiInstance.DeleteCustomerPaymentSources(id, paymentSourcesId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentMethodsApi.DeleteCustomerPaymentSources: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCustomerPaymentSourcesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Payment Method
    ApiResponse<UpdateCustomerPaymentSourcesResponse> response = apiInstance.DeleteCustomerPaymentSourcesWithHttpInfo(id, paymentSourcesId, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentMethodsApi.DeleteCustomerPaymentSourcesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **paymentSourcesId** | **string** | Identifier of the payment method |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |

### Return type

[**UpdateCustomerPaymentSourcesResponse**](UpdateCustomerPaymentSourcesResponse.md)

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

<a name="getcustomerpaymentsources"></a>
# **GetCustomerPaymentSources**
> GetPaymentSourcesResponse GetCustomerPaymentSources (string id, string acceptLanguage = null, int? limit = null, string next = null, string previous = null, string search = null)

Get Payment Methods

Get a list of Payment Methods

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class GetCustomerPaymentSourcesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PaymentMethodsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)
            var limit = 20;  // int? | The numbers of items to return, the maximum value is 250 (optional)  (default to 20)
            var next = "next_example";  // string | next page (optional) 
            var previous = "previous_example";  // string | previous page (optional) 
            var search = "search_example";  // string | General order search, e.g. by mail, reference etc. (optional) 

            try
            {
                // Get Payment Methods
                GetPaymentSourcesResponse result = apiInstance.GetCustomerPaymentSources(id, acceptLanguage, limit, next, previous, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentMethodsApi.GetCustomerPaymentSources: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomerPaymentSourcesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Payment Methods
    ApiResponse<GetPaymentSourcesResponse> response = apiInstance.GetCustomerPaymentSourcesWithHttpInfo(id, acceptLanguage, limit, next, previous, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentMethodsApi.GetCustomerPaymentSourcesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |
| **limit** | **int?** | The numbers of items to return, the maximum value is 250 | [optional] [default to 20] |
| **next** | **string** | next page | [optional]  |
| **previous** | **string** | previous page | [optional]  |
| **search** | **string** | General order search, e.g. by mail, reference etc. | [optional]  |

### Return type

[**GetPaymentSourcesResponse**](GetPaymentSourcesResponse.md)

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
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomerpaymentsources"></a>
# **UpdateCustomerPaymentSources**
> UpdateCustomerPaymentSourcesResponse UpdateCustomerPaymentSources (string id, string paymentSourcesId, UpdatePaymentSources updatePaymentSources, string acceptLanguage = null)

Update Payment Method

Gets a payment source that corresponds to a customer ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class UpdateCustomerPaymentSourcesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PaymentMethodsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var paymentSourcesId = src_2tQ974hSHcsdeSZHG;  // string | Identifier of the payment method
            var updatePaymentSources = new UpdatePaymentSources(); // UpdatePaymentSources | requested field for customer payment sources
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)

            try
            {
                // Update Payment Method
                UpdateCustomerPaymentSourcesResponse result = apiInstance.UpdateCustomerPaymentSources(id, paymentSourcesId, updatePaymentSources, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentMethodsApi.UpdateCustomerPaymentSources: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCustomerPaymentSourcesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Payment Method
    ApiResponse<UpdateCustomerPaymentSourcesResponse> response = apiInstance.UpdateCustomerPaymentSourcesWithHttpInfo(id, paymentSourcesId, updatePaymentSources, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentMethodsApi.UpdateCustomerPaymentSourcesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **paymentSourcesId** | **string** | Identifier of the payment method |  |
| **updatePaymentSources** | [**UpdatePaymentSources**](UpdatePaymentSources.md) | requested field for customer payment sources |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |

### Return type

[**UpdateCustomerPaymentSourcesResponse**](UpdateCustomerPaymentSourcesResponse.md)

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

