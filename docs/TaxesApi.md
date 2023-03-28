# Conekta.net.Api.TaxesApi

All URIs are relative to *https://api.conekta.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**OrdersCreateTaxLines**](TaxesApi.md#orderscreatetaxlines) | **POST** /orders/{id}/tax_lines | Create Tax |
| [**OrdersDeleteTaxLines**](TaxesApi.md#ordersdeletetaxlines) | **DELETE** /orders/{id}/tax_lines/{tax_lines_id} | Delete Tax |
| [**OrdersUpdateTaxLines**](TaxesApi.md#ordersupdatetaxlines) | **PUT** /orders/{id}/tax_lines/{tax_lines_id} | Update Tax |

<a name="orderscreatetaxlines"></a>
# **OrdersCreateTaxLines**
> UpdateOrderTaxLinesResponse OrdersCreateTaxLines (string id, OrderTaxLinesRequest orderTaxLinesRequest, string acceptLanguage = null)

Create Tax

creates a new tax lines for an existing orden

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class OrdersCreateTaxLinesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TaxesApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var orderTaxLinesRequest = new OrderTaxLinesRequest(); // OrderTaxLinesRequest | requested field for a tax lines
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)

            try
            {
                // Create Tax
                UpdateOrderTaxLinesResponse result = apiInstance.OrdersCreateTaxLines(id, orderTaxLinesRequest, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxesApi.OrdersCreateTaxLines: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrdersCreateTaxLinesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Tax
    ApiResponse<UpdateOrderTaxLinesResponse> response = apiInstance.OrdersCreateTaxLinesWithHttpInfo(id, orderTaxLinesRequest, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaxesApi.OrdersCreateTaxLinesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **orderTaxLinesRequest** | [**OrderTaxLinesRequest**](OrderTaxLinesRequest.md) | requested field for a tax lines |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |

### Return type

[**UpdateOrderTaxLinesResponse**](UpdateOrderTaxLinesResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.conekta-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful |  -  |
| **401** | authentication error |  -  |
| **422** | parameter validation error |  -  |
| **404** | not found entity |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordersdeletetaxlines"></a>
# **OrdersDeleteTaxLines**
> UpdateOrderTaxLinesResponse OrdersDeleteTaxLines (string id, string taxLinesId, string acceptLanguage = null)

Delete Tax

Delete a tax lines for an existing orden

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class OrdersDeleteTaxLinesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TaxesApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var taxLinesId = tax_lin_2tQ974hSHcsdeSZHG;  // string | identifier
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)

            try
            {
                // Delete Tax
                UpdateOrderTaxLinesResponse result = apiInstance.OrdersDeleteTaxLines(id, taxLinesId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxesApi.OrdersDeleteTaxLines: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrdersDeleteTaxLinesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Tax
    ApiResponse<UpdateOrderTaxLinesResponse> response = apiInstance.OrdersDeleteTaxLinesWithHttpInfo(id, taxLinesId, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaxesApi.OrdersDeleteTaxLinesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **taxLinesId** | **string** | identifier |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |

### Return type

[**UpdateOrderTaxLinesResponse**](UpdateOrderTaxLinesResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.conekta-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful |  -  |
| **401** | authentication error |  -  |
| **422** | parameter validation error |  -  |
| **404** | not found entity |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordersupdatetaxlines"></a>
# **OrdersUpdateTaxLines**
> UpdateOrderTaxLinesResponse OrdersUpdateTaxLines (string id, string taxLinesId, UpdateOrderTaxLinesRequest updateOrderTaxLinesRequest, string acceptLanguage = null)

Update Tax

updates a tax lines for an existing orden

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class OrdersUpdateTaxLinesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TaxesApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var taxLinesId = tax_lin_2tQ974hSHcsdeSZHG;  // string | identifier
            var updateOrderTaxLinesRequest = new UpdateOrderTaxLinesRequest(); // UpdateOrderTaxLinesRequest | requested field for a tax lines
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)

            try
            {
                // Update Tax
                UpdateOrderTaxLinesResponse result = apiInstance.OrdersUpdateTaxLines(id, taxLinesId, updateOrderTaxLinesRequest, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxesApi.OrdersUpdateTaxLines: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrdersUpdateTaxLinesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Tax
    ApiResponse<UpdateOrderTaxLinesResponse> response = apiInstance.OrdersUpdateTaxLinesWithHttpInfo(id, taxLinesId, updateOrderTaxLinesRequest, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaxesApi.OrdersUpdateTaxLinesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **taxLinesId** | **string** | identifier |  |
| **updateOrderTaxLinesRequest** | [**UpdateOrderTaxLinesRequest**](UpdateOrderTaxLinesRequest.md) | requested field for a tax lines |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |

### Return type

[**UpdateOrderTaxLinesResponse**](UpdateOrderTaxLinesResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.conekta-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful |  -  |
| **401** | authentication error |  -  |
| **422** | parameter validation error |  -  |
| **404** | not found entity |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

