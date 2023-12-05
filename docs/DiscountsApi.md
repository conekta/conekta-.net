# Conekta.net.Api.DiscountsApi

All URIs are relative to *https://api.conekta.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**OrdersCreateDiscountLine**](DiscountsApi.md#orderscreatediscountline) | **POST** /orders/{id}/discount_lines | Create Discount |
| [**OrdersDeleteDiscountLines**](DiscountsApi.md#ordersdeletediscountlines) | **DELETE** /orders/{id}/discount_lines/{discount_lines_id} | Delete Discount |
| [**OrdersGetDiscountLine**](DiscountsApi.md#ordersgetdiscountline) | **GET** /orders/{id}/discount_lines/{discount_lines_id} | Get Discount |
| [**OrdersGetDiscountLines**](DiscountsApi.md#ordersgetdiscountlines) | **GET** /orders/{id}/discount_lines | Get a List of Discount |
| [**OrdersUpdateDiscountLines**](DiscountsApi.md#ordersupdatediscountlines) | **PUT** /orders/{id}/discount_lines/{discount_lines_id} | Update Discount |

<a id="orderscreatediscountline"></a>
# **OrdersCreateDiscountLine**
> DiscountLinesResponse OrdersCreateDiscountLine (string id, OrderDiscountLinesRequest orderDiscountLinesRequest, string acceptLanguage = null, string xChildCompanyId = null)

Create Discount

Create discount lines for an existing orden

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

            var apiInstance = new DiscountsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var orderDiscountLinesRequest = new OrderDiscountLinesRequest(); // OrderDiscountLinesRequest | requested field for a discount lines
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)
            var xChildCompanyId = 6441b6376b60c3a638da80af;  // string | In the case of a holding company, the company id of the child company to which will process the request. (optional) 

            try
            {
                // Create Discount
                DiscountLinesResponse result = apiInstance.OrdersCreateDiscountLine(id, orderDiscountLinesRequest, acceptLanguage, xChildCompanyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscountsApi.OrdersCreateDiscountLine: " + e.Message);
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
    // Create Discount
    ApiResponse<DiscountLinesResponse> response = apiInstance.OrdersCreateDiscountLineWithHttpInfo(id, orderDiscountLinesRequest, acceptLanguage, xChildCompanyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiscountsApi.OrdersCreateDiscountLineWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **orderDiscountLinesRequest** | [**OrderDiscountLinesRequest**](OrderDiscountLinesRequest.md) | requested field for a discount lines |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |
| **xChildCompanyId** | **string** | In the case of a holding company, the company id of the child company to which will process the request. | [optional]  |

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

<a id="ordersdeletediscountlines"></a>
# **OrdersDeleteDiscountLines**
> DiscountLinesResponse OrdersDeleteDiscountLines (string id, string discountLinesId, string acceptLanguage = null, string xChildCompanyId = null)

Delete Discount

Delete an existing discount lines for an existing orden

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class OrdersDeleteDiscountLinesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiscountsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var discountLinesId = dis_lin_2tQ974hSHcsdeSZHG;  // string | discount line id identifier
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)
            var xChildCompanyId = 6441b6376b60c3a638da80af;  // string | In the case of a holding company, the company id of the child company to which will process the request. (optional) 

            try
            {
                // Delete Discount
                DiscountLinesResponse result = apiInstance.OrdersDeleteDiscountLines(id, discountLinesId, acceptLanguage, xChildCompanyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscountsApi.OrdersDeleteDiscountLines: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrdersDeleteDiscountLinesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Discount
    ApiResponse<DiscountLinesResponse> response = apiInstance.OrdersDeleteDiscountLinesWithHttpInfo(id, discountLinesId, acceptLanguage, xChildCompanyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiscountsApi.OrdersDeleteDiscountLinesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **discountLinesId** | **string** | discount line id identifier |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |
| **xChildCompanyId** | **string** | In the case of a holding company, the company id of the child company to which will process the request. | [optional]  |

### Return type

[**DiscountLinesResponse**](DiscountLinesResponse.md)

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
| **422** | parameter validation error |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ordersgetdiscountline"></a>
# **OrdersGetDiscountLine**
> DiscountLinesResponse OrdersGetDiscountLine (string id, string discountLinesId, string acceptLanguage = null, string xChildCompanyId = null)

Get Discount

Get an existing discount lines for an existing orden

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class OrdersGetDiscountLineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiscountsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var discountLinesId = dis_lin_2tQ974hSHcsdeSZHG;  // string | discount line id identifier
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)
            var xChildCompanyId = 6441b6376b60c3a638da80af;  // string | In the case of a holding company, the company id of the child company to which will process the request. (optional) 

            try
            {
                // Get Discount
                DiscountLinesResponse result = apiInstance.OrdersGetDiscountLine(id, discountLinesId, acceptLanguage, xChildCompanyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscountsApi.OrdersGetDiscountLine: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrdersGetDiscountLineWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Discount
    ApiResponse<DiscountLinesResponse> response = apiInstance.OrdersGetDiscountLineWithHttpInfo(id, discountLinesId, acceptLanguage, xChildCompanyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiscountsApi.OrdersGetDiscountLineWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **discountLinesId** | **string** | discount line id identifier |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |
| **xChildCompanyId** | **string** | In the case of a holding company, the company id of the child company to which will process the request. | [optional]  |

### Return type

[**DiscountLinesResponse**](DiscountLinesResponse.md)

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
| **422** | parameter validation error |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ordersgetdiscountlines"></a>
# **OrdersGetDiscountLines**
> GetOrderDiscountLinesResponse OrdersGetDiscountLines (string id, string acceptLanguage = null, string xChildCompanyId = null, int? limit = null, string search = null, string next = null, string previous = null)

Get a List of Discount

Get discount lines for an existing orden

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class OrdersGetDiscountLinesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DiscountsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)
            var xChildCompanyId = 6441b6376b60c3a638da80af;  // string | In the case of a holding company, the company id of the child company to which will process the request. (optional) 
            var limit = 20;  // int? | The numbers of items to return, the maximum value is 250 (optional)  (default to 20)
            var search = "search_example";  // string | General order search, e.g. by mail, reference etc. (optional) 
            var next = "next_example";  // string | next page (optional) 
            var previous = "previous_example";  // string | previous page (optional) 

            try
            {
                // Get a List of Discount
                GetOrderDiscountLinesResponse result = apiInstance.OrdersGetDiscountLines(id, acceptLanguage, xChildCompanyId, limit, search, next, previous);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscountsApi.OrdersGetDiscountLines: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrdersGetDiscountLinesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a List of Discount
    ApiResponse<GetOrderDiscountLinesResponse> response = apiInstance.OrdersGetDiscountLinesWithHttpInfo(id, acceptLanguage, xChildCompanyId, limit, search, next, previous);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiscountsApi.OrdersGetDiscountLinesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |
| **xChildCompanyId** | **string** | In the case of a holding company, the company id of the child company to which will process the request. | [optional]  |
| **limit** | **int?** | The numbers of items to return, the maximum value is 250 | [optional] [default to 20] |
| **search** | **string** | General order search, e.g. by mail, reference etc. | [optional]  |
| **next** | **string** | next page | [optional]  |
| **previous** | **string** | previous page | [optional]  |

### Return type

[**GetOrderDiscountLinesResponse**](GetOrderDiscountLinesResponse.md)

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
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ordersupdatediscountlines"></a>
# **OrdersUpdateDiscountLines**
> DiscountLinesResponse OrdersUpdateDiscountLines (string id, string discountLinesId, UpdateOrderDiscountLinesRequest updateOrderDiscountLinesRequest, string acceptLanguage = null, string xChildCompanyId = null)

Update Discount

Update an existing discount lines for an existing orden

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

            var apiInstance = new DiscountsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var discountLinesId = dis_lin_2tQ974hSHcsdeSZHG;  // string | discount line id identifier
            var updateOrderDiscountLinesRequest = new UpdateOrderDiscountLinesRequest(); // UpdateOrderDiscountLinesRequest | requested field for a discount lines
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)
            var xChildCompanyId = 6441b6376b60c3a638da80af;  // string | In the case of a holding company, the company id of the child company to which will process the request. (optional) 

            try
            {
                // Update Discount
                DiscountLinesResponse result = apiInstance.OrdersUpdateDiscountLines(id, discountLinesId, updateOrderDiscountLinesRequest, acceptLanguage, xChildCompanyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscountsApi.OrdersUpdateDiscountLines: " + e.Message);
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
    // Update Discount
    ApiResponse<DiscountLinesResponse> response = apiInstance.OrdersUpdateDiscountLinesWithHttpInfo(id, discountLinesId, updateOrderDiscountLinesRequest, acceptLanguage, xChildCompanyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiscountsApi.OrdersUpdateDiscountLinesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **discountLinesId** | **string** | discount line id identifier |  |
| **updateOrderDiscountLinesRequest** | [**UpdateOrderDiscountLinesRequest**](UpdateOrderDiscountLinesRequest.md) | requested field for a discount lines |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |
| **xChildCompanyId** | **string** | In the case of a holding company, the company id of the child company to which will process the request. | [optional]  |

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

