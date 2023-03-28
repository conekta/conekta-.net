# Conekta.net.Api.ShippingsApi

All URIs are relative to *https://api.conekta.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**OrdersCreateShippingLines**](ShippingsApi.md#orderscreateshippinglines) | **POST** /orders/{id}/shipping_lines | Create Shipping |
| [**OrdersUpdateShippingLines**](ShippingsApi.md#ordersupdateshippinglines) | **PUT** /orders/{id}/shipping_lines/{shipping_lines_id} | Update Shipping |

<a name="orderscreateshippinglines"></a>
# **OrdersCreateShippingLines**
> ShippingLinesOrderResponse OrdersCreateShippingLines (string id, ShippingLinesRequest shippingLinesRequest, string acceptLanguage = null)

Create Shipping

creates a new shipping lines for an existing orden

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class OrdersCreateShippingLinesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShippingsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var shippingLinesRequest = new ShippingLinesRequest(); // ShippingLinesRequest | requested field for a shipping lines
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)

            try
            {
                // Create Shipping
                ShippingLinesOrderResponse result = apiInstance.OrdersCreateShippingLines(id, shippingLinesRequest, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShippingsApi.OrdersCreateShippingLines: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrdersCreateShippingLinesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Shipping
    ApiResponse<ShippingLinesOrderResponse> response = apiInstance.OrdersCreateShippingLinesWithHttpInfo(id, shippingLinesRequest, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShippingsApi.OrdersCreateShippingLinesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **shippingLinesRequest** | [**ShippingLinesRequest**](ShippingLinesRequest.md) | requested field for a shipping lines |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |

### Return type

[**ShippingLinesOrderResponse**](ShippingLinesOrderResponse.md)

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
| **404** | not found entity |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordersupdateshippinglines"></a>
# **OrdersUpdateShippingLines**
> ShippingLinesOrderResponse OrdersUpdateShippingLines (string id, string shippingLinesId, ShippingLinesRequest shippingLinesRequest, string acceptLanguage = null)

Update Shipping

updates an existing shipping lines for an existing orden

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class OrdersUpdateShippingLinesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShippingsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var shippingLinesId = ship_lin_2tQ974hSHcsdeSZHG;  // string | identifier
            var shippingLinesRequest = new ShippingLinesRequest(); // ShippingLinesRequest | requested field for a shipping lines
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)

            try
            {
                // Update Shipping
                ShippingLinesOrderResponse result = apiInstance.OrdersUpdateShippingLines(id, shippingLinesId, shippingLinesRequest, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShippingsApi.OrdersUpdateShippingLines: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrdersUpdateShippingLinesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Shipping
    ApiResponse<ShippingLinesOrderResponse> response = apiInstance.OrdersUpdateShippingLinesWithHttpInfo(id, shippingLinesId, shippingLinesRequest, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShippingsApi.OrdersUpdateShippingLinesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **shippingLinesId** | **string** | identifier |  |
| **shippingLinesRequest** | [**ShippingLinesRequest**](ShippingLinesRequest.md) | requested field for a shipping lines |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |

### Return type

[**ShippingLinesOrderResponse**](ShippingLinesOrderResponse.md)

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
| **404** | not found entity |  -  |
| **422** | parameter validation error |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

