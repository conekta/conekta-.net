# Conekta.net.Api.PaymentMethodsApi

All URIs are relative to *https://api.conekta.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCustomerPaymentMethods**](PaymentMethodsApi.md#createcustomerpaymentmethods) | **POST** /customers/{id}/payment_sources | Create Payment Method |
| [**DeleteCustomerPaymentMethods**](PaymentMethodsApi.md#deletecustomerpaymentmethods) | **DELETE** /customers/{id}/payment_sources/{payment_method_id} | Delete Payment Method |
| [**GetCustomerPaymentMethods**](PaymentMethodsApi.md#getcustomerpaymentmethods) | **GET** /customers/{id}/payment_sources | Get Payment Methods |
| [**UpdateCustomerPaymentMethods**](PaymentMethodsApi.md#updatecustomerpaymentmethods) | **PUT** /customers/{id}/payment_sources/{payment_method_id} | Update Payment Method |

<a name="createcustomerpaymentmethods"></a>
# **CreateCustomerPaymentMethods**
> CreateCustomerPaymentMethodsResponse CreateCustomerPaymentMethods (string id, CreateCustomerPaymentMethodsRequest createCustomerPaymentMethodsRequest, string acceptLanguage = null)

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
    public class CreateCustomerPaymentMethodsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PaymentMethodsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var createCustomerPaymentMethodsRequest = new CreateCustomerPaymentMethodsRequest(); // CreateCustomerPaymentMethodsRequest | requested field for customer payment methods
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)

            try
            {
                // Create Payment Method
                CreateCustomerPaymentMethodsResponse result = apiInstance.CreateCustomerPaymentMethods(id, createCustomerPaymentMethodsRequest, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentMethodsApi.CreateCustomerPaymentMethods: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCustomerPaymentMethodsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Payment Method
    ApiResponse<CreateCustomerPaymentMethodsResponse> response = apiInstance.CreateCustomerPaymentMethodsWithHttpInfo(id, createCustomerPaymentMethodsRequest, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentMethodsApi.CreateCustomerPaymentMethodsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **createCustomerPaymentMethodsRequest** | [**CreateCustomerPaymentMethodsRequest**](CreateCustomerPaymentMethodsRequest.md) | requested field for customer payment methods |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |

### Return type

[**CreateCustomerPaymentMethodsResponse**](CreateCustomerPaymentMethodsResponse.md)

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

<a name="deletecustomerpaymentmethods"></a>
# **DeleteCustomerPaymentMethods**
> UpdateCustomerPaymentMethodsResponse DeleteCustomerPaymentMethods (string id, string paymentMethodId, string acceptLanguage = null)

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
    public class DeleteCustomerPaymentMethodsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PaymentMethodsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var paymentMethodId = src_2tQ974hSHcsdeSZHG;  // string | Identifier of the payment method
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)

            try
            {
                // Delete Payment Method
                UpdateCustomerPaymentMethodsResponse result = apiInstance.DeleteCustomerPaymentMethods(id, paymentMethodId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentMethodsApi.DeleteCustomerPaymentMethods: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCustomerPaymentMethodsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Payment Method
    ApiResponse<UpdateCustomerPaymentMethodsResponse> response = apiInstance.DeleteCustomerPaymentMethodsWithHttpInfo(id, paymentMethodId, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentMethodsApi.DeleteCustomerPaymentMethodsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **paymentMethodId** | **string** | Identifier of the payment method |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |

### Return type

[**UpdateCustomerPaymentMethodsResponse**](UpdateCustomerPaymentMethodsResponse.md)

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

<a name="getcustomerpaymentmethods"></a>
# **GetCustomerPaymentMethods**
> GetPaymentMethodResponse GetCustomerPaymentMethods (string id, string acceptLanguage = null, int? limit = null, string next = null, string previous = null, string search = null)

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
    public class GetCustomerPaymentMethodsExample
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
                GetPaymentMethodResponse result = apiInstance.GetCustomerPaymentMethods(id, acceptLanguage, limit, next, previous, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentMethodsApi.GetCustomerPaymentMethods: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomerPaymentMethodsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Payment Methods
    ApiResponse<GetPaymentMethodResponse> response = apiInstance.GetCustomerPaymentMethodsWithHttpInfo(id, acceptLanguage, limit, next, previous, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentMethodsApi.GetCustomerPaymentMethodsWithHttpInfo: " + e.Message);
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

[**GetPaymentMethodResponse**](GetPaymentMethodResponse.md)

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

<a name="updatecustomerpaymentmethods"></a>
# **UpdateCustomerPaymentMethods**
> UpdateCustomerPaymentMethodsResponse UpdateCustomerPaymentMethods (string id, string paymentMethodId, UpdatePaymentMethods updatePaymentMethods, string acceptLanguage = null)

Update Payment Method

Gets a payment Method that corresponds to a customer ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class UpdateCustomerPaymentMethodsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PaymentMethodsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var paymentMethodId = src_2tQ974hSHcsdeSZHG;  // string | Identifier of the payment method
            var updatePaymentMethods = new UpdatePaymentMethods(); // UpdatePaymentMethods | requested field for customer payment methods
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)

            try
            {
                // Update Payment Method
                UpdateCustomerPaymentMethodsResponse result = apiInstance.UpdateCustomerPaymentMethods(id, paymentMethodId, updatePaymentMethods, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentMethodsApi.UpdateCustomerPaymentMethods: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCustomerPaymentMethodsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Payment Method
    ApiResponse<UpdateCustomerPaymentMethodsResponse> response = apiInstance.UpdateCustomerPaymentMethodsWithHttpInfo(id, paymentMethodId, updatePaymentMethods, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentMethodsApi.UpdateCustomerPaymentMethodsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **paymentMethodId** | **string** | Identifier of the payment method |  |
| **updatePaymentMethods** | [**UpdatePaymentMethods**](UpdatePaymentMethods.md) | requested field for customer payment methods |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |

### Return type

[**UpdateCustomerPaymentMethodsResponse**](UpdateCustomerPaymentMethodsResponse.md)

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

