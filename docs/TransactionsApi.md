# Conekta.net.Api.TransactionsApi

All URIs are relative to *https://api.conekta.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTransaction**](TransactionsApi.md#gettransaction) | **GET** /transactions/{id} | Get transaction |
| [**GetTransactions**](TransactionsApi.md#gettransactions) | **GET** /transactions | Get List transactions |

<a id="gettransaction"></a>
# **GetTransaction**
> TransactionResponse GetTransaction (string id, string acceptLanguage = null, string xChildCompanyId = null)

Get transaction

Get the details of a transaction

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class GetTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TransactionsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)
            var xChildCompanyId = 6441b6376b60c3a638da80af;  // string | In the case of a holding company, the company id of the child company to which will process the request. (optional) 

            try
            {
                // Get transaction
                TransactionResponse result = apiInstance.GetTransaction(id, acceptLanguage, xChildCompanyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get transaction
    ApiResponse<TransactionResponse> response = apiInstance.GetTransactionWithHttpInfo(id, acceptLanguage, xChildCompanyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.GetTransactionWithHttpInfo: " + e.Message);
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

### Return type

[**TransactionResponse**](TransactionResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.conekta-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful |  * Date - The date and time that the response was sent <br>  * Content-Type - The format of the response body <br>  * Content-Length - The length of the response body in bytes <br>  * Connection - The type of connection used to transfer the response <br>  * Conekta-Media-Type -  <br>  |
| **401** | authentication error |  -  |
| **404** | authentication error |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettransactions"></a>
# **GetTransactions**
> GetTransactionsResponse GetTransactions (string acceptLanguage = null, string xChildCompanyId = null, int? limit = null, string next = null, string previous = null, string id = null, string chargeId = null, string type = null, string currency = null)

Get List transactions

Get transaction details in the form of a list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class GetTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TransactionsApi(config);
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)
            var xChildCompanyId = 6441b6376b60c3a638da80af;  // string | In the case of a holding company, the company id of the child company to which will process the request. (optional) 
            var limit = 20;  // int? | The numbers of items to return, the maximum value is 250 (optional)  (default to 20)
            var next = "next_example";  // string | next page (optional) 
            var previous = "previous_example";  // string | previous page (optional) 
            var id = 65412a893cd69a0001c25892;  // string | id of the object to be retrieved (optional) 
            var chargeId = 65412a893cd69a0001c25892;  // string | id of the charge used for filtering (optional) 
            var type = capture;  // string | type of the object to be retrieved (optional) 
            var currency = MXN;  // string | currency of the object to be retrieved (optional) 

            try
            {
                // Get List transactions
                GetTransactionsResponse result = apiInstance.GetTransactions(acceptLanguage, xChildCompanyId, limit, next, previous, id, chargeId, type, currency);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get List transactions
    ApiResponse<GetTransactionsResponse> response = apiInstance.GetTransactionsWithHttpInfo(acceptLanguage, xChildCompanyId, limit, next, previous, id, chargeId, type, currency);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.GetTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |
| **xChildCompanyId** | **string** | In the case of a holding company, the company id of the child company to which will process the request. | [optional]  |
| **limit** | **int?** | The numbers of items to return, the maximum value is 250 | [optional] [default to 20] |
| **next** | **string** | next page | [optional]  |
| **previous** | **string** | previous page | [optional]  |
| **id** | **string** | id of the object to be retrieved | [optional]  |
| **chargeId** | **string** | id of the charge used for filtering | [optional]  |
| **type** | **string** | type of the object to be retrieved | [optional]  |
| **currency** | **string** | currency of the object to be retrieved | [optional]  |

### Return type

[**GetTransactionsResponse**](GetTransactionsResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.conekta-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful |  * Date - The date and time that the response was sent <br>  * Content-Type - The format of the response body <br>  * Content-Length - The length of the response body in bytes <br>  * Connection - The type of connection used to transfer the response <br>  * Conekta-Media-Type -  <br>  |
| **401** | authentication error |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

