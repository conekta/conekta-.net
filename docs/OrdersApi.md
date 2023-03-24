# Conekta.net.Api.OrdersApi

All URIs are relative to *https://api.conekta.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateOrder**](OrdersApi.md#createorder) | **POST** /orders | Create order |
| [**GetOrderById**](OrdersApi.md#getorderbyid) | **GET** /orders/{id} | Info for a specific order |
| [**GetOrders**](OrdersApi.md#getorders) | **GET** /orders | returns a set of /orders |
| [**OrderRefund**](OrdersApi.md#orderrefund) | **POST** /orders/{id}/refunds | A refunded order describes the items, amount, and reason an order is being refunded. |
| [**OrdersCreateCapture**](OrdersApi.md#orderscreatecapture) | **POST** /orders/{id}/capture | Processes an order that has been previously authorized. |
| [**OrdersCreateCharge**](OrdersApi.md#orderscreatecharge) | **POST** /orders/{id}/charges | creates a new charge for an existing orden |
| [**OrdersCreateDiscountLine**](OrdersApi.md#orderscreatediscountline) | **POST** /orders/{id}/discount_lines | creates a new discount lines for an existing orden |
| [**OrdersCreateLineItems**](OrdersApi.md#orderscreatelineitems) | **POST** /orders/{id}/line_items | creates a new line items for an existing orden |
| [**OrdersCreateShippingLines**](OrdersApi.md#orderscreateshippinglines) | **POST** /orders/{id}/shipping_lines | creates a new shipping lines for an existing orden |
| [**OrdersCreateTaxLines**](OrdersApi.md#orderscreatetaxlines) | **POST** /orders/{id}/tax_lines | creates a new tax lines for an existing orden |
| [**OrdersUpdateDiscountLines**](OrdersApi.md#ordersupdatediscountlines) | **PUT** /orders/{id}/discount_lines/{discount_lines_id} | updates an existing discount lines for an existing orden |
| [**OrdersUpdateLineItems**](OrdersApi.md#ordersupdatelineitems) | **PUT** /orders/{id}/line_items/{line_item_id} | updates a existing line items for an existing orden |
| [**OrdersUpdateShippingLines**](OrdersApi.md#ordersupdateshippinglines) | **PUT** /orders/{id}/shipping_lines/{shipping_lines_id} | updates an existing shipping lines for an existing orden |
| [**OrdersUpdateTaxLines**](OrdersApi.md#ordersupdatetaxlines) | **PUT** /orders/{id}/tax_lines/{tax_lines_id} | updates a new tax lines for an existing orden |
| [**UpdateOrder**](OrdersApi.md#updateorder) | **PUT** /orders/{id} | Update an existing Order. |

<a name="createorder"></a>
# **CreateOrder**
> OrderResponse CreateOrder (OrderRequest orderRequest, string acceptLanguage = null)

Create order

Create a new order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class CreateOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrdersApi(config);
            var orderRequest = new OrderRequest(); // OrderRequest | requested field for order
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // Create order
                OrderResponse result = apiInstance.CreateOrder(orderRequest, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.CreateOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create order
    ApiResponse<OrderResponse> response = apiInstance.CreateOrderWithHttpInfo(orderRequest, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.CreateOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderRequest** | [**OrderRequest**](OrderRequest.md) | requested field for order |  |
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |

### Return type

[**OrderResponse**](OrderResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.conekta-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **422** | parameter validation error |  -  |
| **401** | authentication error |  -  |
| **402** | payment required error |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderbyid"></a>
# **GetOrderById**
> OrderResponse GetOrderById (string id, string acceptLanguage = null)

Info for a specific order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class GetOrderByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrdersApi(config);
            var id = 6307a60c41de27127515a575;  // string | identifier
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // Info for a specific order
                OrderResponse result = apiInstance.GetOrderById(id, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetOrderById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrderByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Info for a specific order
    ApiResponse<OrderResponse> response = apiInstance.GetOrderByIdWithHttpInfo(id, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.GetOrderByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | identifier |  |
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |

### Return type

[**OrderResponse**](OrderResponse.md)

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
| **404** | not found entity |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorders"></a>
# **GetOrders**
> GetOrdersResponse GetOrders (string acceptLanguage = null, int? limit = null, string search = null, string next = null, string previous = null)

returns a set of /orders

returns a set of /orders.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class GetOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrdersApi(config);
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)
            var limit = 20;  // int? | The numbers of items to return, the maximum value is 250 (optional)  (default to 20)
            var search = "search_example";  // string | General order search, e.g. by mail, reference etc. (optional) 
            var next = "next_example";  // string | next page (optional) 
            var previous = "previous_example";  // string | previous page (optional) 

            try
            {
                // returns a set of /orders
                GetOrdersResponse result = apiInstance.GetOrders(acceptLanguage, limit, search, next, previous);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetOrders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrdersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // returns a set of /orders
    ApiResponse<GetOrdersResponse> response = apiInstance.GetOrdersWithHttpInfo(acceptLanguage, limit, search, next, previous);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.GetOrdersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |
| **limit** | **int?** | The numbers of items to return, the maximum value is 250 | [optional] [default to 20] |
| **search** | **string** | General order search, e.g. by mail, reference etc. | [optional]  |
| **next** | **string** | next page | [optional]  |
| **previous** | **string** | previous page | [optional]  |

### Return type

[**GetOrdersResponse**](GetOrdersResponse.md)

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
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderrefund"></a>
# **OrderRefund**
> OrderResponse OrderRefund (string id, OrderRefundRequest orderRefundRequest, string acceptLanguage = null)

A refunded order describes the items, amount, and reason an order is being refunded.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class OrderRefundExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrdersApi(config);
            var id = 6307a60c41de27127515a575;  // string | identifier
            var orderRefundRequest = new OrderRefundRequest(); // OrderRefundRequest | requested field for a refund
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // A refunded order describes the items, amount, and reason an order is being refunded.
                OrderResponse result = apiInstance.OrderRefund(id, orderRefundRequest, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.OrderRefund: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderRefundWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // A refunded order describes the items, amount, and reason an order is being refunded.
    ApiResponse<OrderResponse> response = apiInstance.OrderRefundWithHttpInfo(id, orderRefundRequest, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.OrderRefundWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | identifier |  |
| **orderRefundRequest** | [**OrderRefundRequest**](OrderRefundRequest.md) | requested field for a refund |  |
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |

### Return type

[**OrderResponse**](OrderResponse.md)

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

<a name="orderscreatecapture"></a>
# **OrdersCreateCapture**
> OrderResponse OrdersCreateCapture (string id, string acceptLanguage = null)

Processes an order that has been previously authorized.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class OrdersCreateCaptureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrdersApi(config);
            var id = 6307a60c41de27127515a575;  // string | identifier
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // Processes an order that has been previously authorized.
                OrderResponse result = apiInstance.OrdersCreateCapture(id, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.OrdersCreateCapture: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrdersCreateCaptureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Processes an order that has been previously authorized.
    ApiResponse<OrderResponse> response = apiInstance.OrdersCreateCaptureWithHttpInfo(id, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.OrdersCreateCaptureWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | identifier |  |
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |

### Return type

[**OrderResponse**](OrderResponse.md)

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
| **404** | not found entity |  -  |
| **428** | Precondition Required |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderscreatecharge"></a>
# **OrdersCreateCharge**
> ChargeOrderResponse OrdersCreateCharge (string id, ChargeRequest chargeRequest, string acceptLanguage = null)

creates a new charge for an existing orden

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class OrdersCreateChargeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrdersApi(config);
            var id = 6307a60c41de27127515a575;  // string | identifier
            var chargeRequest = new ChargeRequest(); // ChargeRequest | requested field for a charge
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // creates a new charge for an existing orden
                ChargeOrderResponse result = apiInstance.OrdersCreateCharge(id, chargeRequest, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.OrdersCreateCharge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrdersCreateChargeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // creates a new charge for an existing orden
    ApiResponse<ChargeOrderResponse> response = apiInstance.OrdersCreateChargeWithHttpInfo(id, chargeRequest, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.OrdersCreateChargeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | identifier |  |
| **chargeRequest** | [**ChargeRequest**](ChargeRequest.md) | requested field for a charge |  |
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |

### Return type

[**ChargeOrderResponse**](ChargeOrderResponse.md)

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
| **428** | Precondition Required |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderscreatediscountline"></a>
# **OrdersCreateDiscountLine**
> DiscountLinesResponse OrdersCreateDiscountLine (string id, OrderDiscountLinesRequest orderDiscountLinesRequest, string acceptLanguage = null)

creates a new discount lines for an existing orden

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class OrdersCreateDiscountLineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrdersApi(config);
            var id = 6307a60c41de27127515a575;  // string | identifier
            var orderDiscountLinesRequest = new OrderDiscountLinesRequest(); // OrderDiscountLinesRequest | requested field for a discount lines
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // creates a new discount lines for an existing orden
                DiscountLinesResponse result = apiInstance.OrdersCreateDiscountLine(id, orderDiscountLinesRequest, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.OrdersCreateDiscountLine: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrdersCreateDiscountLineWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // creates a new discount lines for an existing orden
    ApiResponse<DiscountLinesResponse> response = apiInstance.OrdersCreateDiscountLineWithHttpInfo(id, orderDiscountLinesRequest, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.OrdersCreateDiscountLineWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | identifier |  |
| **orderDiscountLinesRequest** | [**OrderDiscountLinesRequest**](OrderDiscountLinesRequest.md) | requested field for a discount lines |  |
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |

### Return type

[**DiscountLinesResponse**](DiscountLinesResponse.md)

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

<a name="orderscreatelineitems"></a>
# **OrdersCreateLineItems**
> LineItemsOrderResponse OrdersCreateLineItems (string id, LineItems lineItems, string acceptLanguage = null)

creates a new line items for an existing orden

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class OrdersCreateLineItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrdersApi(config);
            var id = 6307a60c41de27127515a575;  // string | identifier
            var lineItems = new LineItems(); // LineItems | requested field for a line items
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // creates a new line items for an existing orden
                LineItemsOrderResponse result = apiInstance.OrdersCreateLineItems(id, lineItems, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.OrdersCreateLineItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrdersCreateLineItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // creates a new line items for an existing orden
    ApiResponse<LineItemsOrderResponse> response = apiInstance.OrdersCreateLineItemsWithHttpInfo(id, lineItems, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.OrdersCreateLineItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | identifier |  |
| **lineItems** | [**LineItems**](LineItems.md) | requested field for a line items |  |
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |

### Return type

[**LineItemsOrderResponse**](LineItemsOrderResponse.md)

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

<a name="orderscreateshippinglines"></a>
# **OrdersCreateShippingLines**
> ShippingLinesOrderResponse OrdersCreateShippingLines (string id, ShippingLinesRequest shippingLinesRequest, string acceptLanguage = null)

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

            var apiInstance = new OrdersApi(config);
            var id = 6307a60c41de27127515a575;  // string | identifier
            var shippingLinesRequest = new ShippingLinesRequest(); // ShippingLinesRequest | requested field for a shipping lines
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // creates a new shipping lines for an existing orden
                ShippingLinesOrderResponse result = apiInstance.OrdersCreateShippingLines(id, shippingLinesRequest, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.OrdersCreateShippingLines: " + e.Message);
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
    // creates a new shipping lines for an existing orden
    ApiResponse<ShippingLinesOrderResponse> response = apiInstance.OrdersCreateShippingLinesWithHttpInfo(id, shippingLinesRequest, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.OrdersCreateShippingLinesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | identifier |  |
| **shippingLinesRequest** | [**ShippingLinesRequest**](ShippingLinesRequest.md) | requested field for a shipping lines |  |
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |

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

<a name="orderscreatetaxlines"></a>
# **OrdersCreateTaxLines**
> UpdateOrderTaxLinesResponse OrdersCreateTaxLines (string id, OrderTaxLinesRequest orderTaxLinesRequest, string acceptLanguage = null)

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

            var apiInstance = new OrdersApi(config);
            var id = 6307a60c41de27127515a575;  // string | identifier
            var orderTaxLinesRequest = new OrderTaxLinesRequest(); // OrderTaxLinesRequest | requested field for a tax lines
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // creates a new tax lines for an existing orden
                UpdateOrderTaxLinesResponse result = apiInstance.OrdersCreateTaxLines(id, orderTaxLinesRequest, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.OrdersCreateTaxLines: " + e.Message);
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
    // creates a new tax lines for an existing orden
    ApiResponse<UpdateOrderTaxLinesResponse> response = apiInstance.OrdersCreateTaxLinesWithHttpInfo(id, orderTaxLinesRequest, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.OrdersCreateTaxLinesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | identifier |  |
| **orderTaxLinesRequest** | [**OrderTaxLinesRequest**](OrderTaxLinesRequest.md) | requested field for a tax lines |  |
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |

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

<a name="ordersupdatediscountlines"></a>
# **OrdersUpdateDiscountLines**
> DiscountLinesResponse OrdersUpdateDiscountLines (string id, string discountLinesId, UpdateOrderDiscountLinesRequest updateOrderDiscountLinesRequest, string acceptLanguage = null)

updates an existing discount lines for an existing orden

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class OrdersUpdateDiscountLinesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrdersApi(config);
            var id = 6307a60c41de27127515a575;  // string | identifier
            var discountLinesId = dis_lin_2tQ974hSHcsdeSZHG;  // string | identifier
            var updateOrderDiscountLinesRequest = new UpdateOrderDiscountLinesRequest(); // UpdateOrderDiscountLinesRequest | requested field for a discount lines
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // updates an existing discount lines for an existing orden
                DiscountLinesResponse result = apiInstance.OrdersUpdateDiscountLines(id, discountLinesId, updateOrderDiscountLinesRequest, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.OrdersUpdateDiscountLines: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrdersUpdateDiscountLinesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // updates an existing discount lines for an existing orden
    ApiResponse<DiscountLinesResponse> response = apiInstance.OrdersUpdateDiscountLinesWithHttpInfo(id, discountLinesId, updateOrderDiscountLinesRequest, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.OrdersUpdateDiscountLinesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | identifier |  |
| **discountLinesId** | **string** | identifier |  |
| **updateOrderDiscountLinesRequest** | [**UpdateOrderDiscountLinesRequest**](UpdateOrderDiscountLinesRequest.md) | requested field for a discount lines |  |
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |

### Return type

[**DiscountLinesResponse**](DiscountLinesResponse.md)

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

<a name="ordersupdatelineitems"></a>
# **OrdersUpdateLineItems**
> LineItemsOrderResponse OrdersUpdateLineItems (string id, string lineItemId, UpdateLineItems updateLineItems, string acceptLanguage = null)

updates a existing line items for an existing orden

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class OrdersUpdateLineItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrdersApi(config);
            var id = 6307a60c41de27127515a575;  // string | identifier
            var lineItemId = line_item_2tQ8HkkfbauaKP9Ho;  // string | identifier
            var updateLineItems = new UpdateLineItems(); // UpdateLineItems | requested field for a line items
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // updates a existing line items for an existing orden
                LineItemsOrderResponse result = apiInstance.OrdersUpdateLineItems(id, lineItemId, updateLineItems, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.OrdersUpdateLineItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrdersUpdateLineItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // updates a existing line items for an existing orden
    ApiResponse<LineItemsOrderResponse> response = apiInstance.OrdersUpdateLineItemsWithHttpInfo(id, lineItemId, updateLineItems, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.OrdersUpdateLineItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | identifier |  |
| **lineItemId** | **string** | identifier |  |
| **updateLineItems** | [**UpdateLineItems**](UpdateLineItems.md) | requested field for a line items |  |
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |

### Return type

[**LineItemsOrderResponse**](LineItemsOrderResponse.md)

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

<a name="ordersupdateshippinglines"></a>
# **OrdersUpdateShippingLines**
> ShippingLinesOrderResponse OrdersUpdateShippingLines (string id, string shippingLinesId, ShippingLinesRequest shippingLinesRequest, string acceptLanguage = null)

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

            var apiInstance = new OrdersApi(config);
            var id = 6307a60c41de27127515a575;  // string | identifier
            var shippingLinesId = ship_lin_2tQ974hSHcsdeSZHG;  // string | identifier
            var shippingLinesRequest = new ShippingLinesRequest(); // ShippingLinesRequest | requested field for a shipping lines
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // updates an existing shipping lines for an existing orden
                ShippingLinesOrderResponse result = apiInstance.OrdersUpdateShippingLines(id, shippingLinesId, shippingLinesRequest, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.OrdersUpdateShippingLines: " + e.Message);
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
    // updates an existing shipping lines for an existing orden
    ApiResponse<ShippingLinesOrderResponse> response = apiInstance.OrdersUpdateShippingLinesWithHttpInfo(id, shippingLinesId, shippingLinesRequest, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.OrdersUpdateShippingLinesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | identifier |  |
| **shippingLinesId** | **string** | identifier |  |
| **shippingLinesRequest** | [**ShippingLinesRequest**](ShippingLinesRequest.md) | requested field for a shipping lines |  |
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |

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

<a name="ordersupdatetaxlines"></a>
# **OrdersUpdateTaxLines**
> UpdateOrderTaxLinesResponse OrdersUpdateTaxLines (string id, string taxLinesId, UpdateOrderTaxLinesRequest updateOrderTaxLinesRequest, string acceptLanguage = null)

updates a new tax lines for an existing orden

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

            var apiInstance = new OrdersApi(config);
            var id = 6307a60c41de27127515a575;  // string | identifier
            var taxLinesId = tax_lin_2tQ974hSHcsdeSZHG;  // string | identifier
            var updateOrderTaxLinesRequest = new UpdateOrderTaxLinesRequest(); // UpdateOrderTaxLinesRequest | requested field for a tax lines
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // updates a new tax lines for an existing orden
                UpdateOrderTaxLinesResponse result = apiInstance.OrdersUpdateTaxLines(id, taxLinesId, updateOrderTaxLinesRequest, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.OrdersUpdateTaxLines: " + e.Message);
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
    // updates a new tax lines for an existing orden
    ApiResponse<UpdateOrderTaxLinesResponse> response = apiInstance.OrdersUpdateTaxLinesWithHttpInfo(id, taxLinesId, updateOrderTaxLinesRequest, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.OrdersUpdateTaxLinesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | identifier |  |
| **taxLinesId** | **string** | identifier |  |
| **updateOrderTaxLinesRequest** | [**UpdateOrderTaxLinesRequest**](UpdateOrderTaxLinesRequest.md) | requested field for a tax lines |  |
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |

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

<a name="updateorder"></a>
# **UpdateOrder**
> OrderResponse UpdateOrder (string id, OrderUpdateRequest orderUpdateRequest, string acceptLanguage = null)

Update an existing Order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class UpdateOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrdersApi(config);
            var id = 6307a60c41de27127515a575;  // string | identifier
            var orderUpdateRequest = new OrderUpdateRequest(); // OrderUpdateRequest | requested field for an order
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // Update an existing Order.
                OrderResponse result = apiInstance.UpdateOrder(id, orderUpdateRequest, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.UpdateOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an existing Order.
    ApiResponse<OrderResponse> response = apiInstance.UpdateOrderWithHttpInfo(id, orderUpdateRequest, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.UpdateOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | identifier |  |
| **orderUpdateRequest** | [**OrderUpdateRequest**](OrderUpdateRequest.md) | requested field for an order |  |
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |

### Return type

[**OrderResponse**](OrderResponse.md)

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

