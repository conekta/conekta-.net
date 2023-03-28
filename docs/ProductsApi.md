# Conekta.net.Api.ProductsApi

All URIs are relative to *https://api.conekta.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**OrdersCreateLineItems**](ProductsApi.md#orderscreatelineitems) | **POST** /orders/{id}/line_items | Create Product |
| [**OrdersDeleteLineItems**](ProductsApi.md#ordersdeletelineitems) | **DELETE** /orders/{id}/line_items/{line_item_id} | Delete Product |
| [**OrdersUpdateLineItems**](ProductsApi.md#ordersupdatelineitems) | **PUT** /orders/{id}/line_items/{line_item_id} | Update Product |

<a name="orderscreatelineitems"></a>
# **OrdersCreateLineItems**
> LineItemsOrderResponse OrdersCreateLineItems (string id, LineItems lineItems, string acceptLanguage = null)

Create Product

Create a new product for an existing order.

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

            var apiInstance = new ProductsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var lineItems = new LineItems(); // LineItems | requested field for a line items
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)

            try
            {
                // Create Product
                LineItemsOrderResponse result = apiInstance.OrdersCreateLineItems(id, lineItems, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.OrdersCreateLineItems: " + e.Message);
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
    // Create Product
    ApiResponse<LineItemsOrderResponse> response = apiInstance.OrdersCreateLineItemsWithHttpInfo(id, lineItems, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.OrdersCreateLineItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **lineItems** | [**LineItems**](LineItems.md) | requested field for a line items |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |

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

<a name="ordersdeletelineitems"></a>
# **OrdersDeleteLineItems**
> LineItemsOrderResponse OrdersDeleteLineItems (string id, string lineItemId, string acceptLanguage = null)

Delete Product

Delete product for an existing orden

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class OrdersDeleteLineItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var lineItemId = line_item_2tQ8HkkfbauaKP9Ho;  // string | identifier
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)

            try
            {
                // Delete Product
                LineItemsOrderResponse result = apiInstance.OrdersDeleteLineItems(id, lineItemId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.OrdersDeleteLineItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrdersDeleteLineItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Product
    ApiResponse<LineItemsOrderResponse> response = apiInstance.OrdersDeleteLineItemsWithHttpInfo(id, lineItemId, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.OrdersDeleteLineItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **lineItemId** | **string** | identifier |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |

### Return type

[**LineItemsOrderResponse**](LineItemsOrderResponse.md)

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

<a name="ordersupdatelineitems"></a>
# **OrdersUpdateLineItems**
> LineItemsOrderResponse OrdersUpdateLineItems (string id, string lineItemId, UpdateLineItems updateLineItems, string acceptLanguage = null)

Update Product

Update a existing line items for an existing orden

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

            var apiInstance = new ProductsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var lineItemId = line_item_2tQ8HkkfbauaKP9Ho;  // string | identifier
            var updateLineItems = new UpdateLineItems(); // UpdateLineItems | requested field for a line items
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)

            try
            {
                // Update Product
                LineItemsOrderResponse result = apiInstance.OrdersUpdateLineItems(id, lineItemId, updateLineItems, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.OrdersUpdateLineItems: " + e.Message);
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
    // Update Product
    ApiResponse<LineItemsOrderResponse> response = apiInstance.OrdersUpdateLineItemsWithHttpInfo(id, lineItemId, updateLineItems, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.OrdersUpdateLineItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **lineItemId** | **string** | identifier |  |
| **updateLineItems** | [**UpdateLineItems**](UpdateLineItems.md) | requested field for a line items |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |

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

