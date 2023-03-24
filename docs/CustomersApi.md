# Conekta.net.Api.CustomersApi

All URIs are relative to *https://api.conekta.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCustomer**](CustomersApi.md#createcustomer) | **POST** /customers | creates a new customer |
| [**CreateCustomerFiscalEntities**](CustomersApi.md#createcustomerfiscalentities) | **POST** /customers/{id}/fiscal_entities | creates a fiscal entities |
| [**CreateCustomerPaymentSources**](CustomersApi.md#createcustomerpaymentsources) | **POST** /customers/{id}/payment_sources | creates a payment source |
| [**CreateCustomerShippingContacts**](CustomersApi.md#createcustomershippingcontacts) | **POST** /customers/{id}/shipping_contacts | creates a shipping contacts |
| [**DeleteCustomerById**](CustomersApi.md#deletecustomerbyid) | **DELETE** /customers/{id} | deletes a customer |
| [**DeleteCustomerPaymentSources**](CustomersApi.md#deletecustomerpaymentsources) | **DELETE** /customers/{id}/payment_sources/{payment_sources_id} | Deletes a payment source |
| [**GetCustomerById**](CustomersApi.md#getcustomerbyid) | **GET** /customers/{id} | returns a customer |
| [**GetCustomers**](CustomersApi.md#getcustomers) | **GET** /customers | returns customers |
| [**UpdateCustomer**](CustomersApi.md#updatecustomer) | **PUT** /customers/{id} | updates a customer |
| [**UpdateCustomerFiscalEntities**](CustomersApi.md#updatecustomerfiscalentities) | **PUT** /customers/{id}/fiscal_entities/{fiscal_entities_id} | updates a  fiscal entities |
| [**UpdateCustomerPaymentSources**](CustomersApi.md#updatecustomerpaymentsources) | **PUT** /customers/{id}/payment_sources/{payment_sources_id} | updates a payment source |
| [**UpdateCustomerShippingContacts**](CustomersApi.md#updatecustomershippingcontacts) | **PUT** /customers/{id}/shipping_contacts/{shipping_contacts_id} | updates a shipping contacts |

<a name="createcustomer"></a>
# **CreateCustomer**
> CustomerResponse CreateCustomer (Customer customer, string acceptLanguage = null)

creates a new customer

The purpose of business is to create and keep a customer, you will learn what elements you need to create a customer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class CreateCustomerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var customer = new Customer(); // Customer | requested field for customer
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // creates a new customer
                CustomerResponse result = apiInstance.CreateCustomer(customer, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CreateCustomer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCustomerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // creates a new customer
    ApiResponse<CustomerResponse> response = apiInstance.CreateCustomerWithHttpInfo(customer, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.CreateCustomerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customer** | [**Customer**](Customer.md) | requested field for customer |  |
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |

### Return type

[**CustomerResponse**](CustomerResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.conekta-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * Date - The date and time that the response was sent <br>  * Content-Type - The format of the response body <br>  * Content-Length - The length of the response body in bytes <br>  * Connection - The type of connection used to transfer the response <br>  * Conekta-Media-Type -  <br>  |
| **401** | authentication error |  -  |
| **402** | payment required error |  -  |
| **422** | parameter validation error |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcustomerfiscalentities"></a>
# **CreateCustomerFiscalEntities**
> CreateCustomerFiscalEntitiesResponse CreateCustomerFiscalEntities (string id, CustomerFiscalEntitiesRequest customerFiscalEntitiesRequest, string acceptLanguage = null)

creates a fiscal entities

creates a customer resource that corresponds to a customer ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class CreateCustomerFiscalEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var id = 6307a60c41de27127515a575;  // string | identifier
            var customerFiscalEntitiesRequest = new CustomerFiscalEntitiesRequest(); // CustomerFiscalEntitiesRequest | requested field for customer fiscal entities
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // creates a fiscal entities
                CreateCustomerFiscalEntitiesResponse result = apiInstance.CreateCustomerFiscalEntities(id, customerFiscalEntitiesRequest, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CreateCustomerFiscalEntities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCustomerFiscalEntitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // creates a fiscal entities
    ApiResponse<CreateCustomerFiscalEntitiesResponse> response = apiInstance.CreateCustomerFiscalEntitiesWithHttpInfo(id, customerFiscalEntitiesRequest, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.CreateCustomerFiscalEntitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | identifier |  |
| **customerFiscalEntitiesRequest** | [**CustomerFiscalEntitiesRequest**](CustomerFiscalEntitiesRequest.md) | requested field for customer fiscal entities |  |
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |

### Return type

[**CreateCustomerFiscalEntitiesResponse**](CreateCustomerFiscalEntitiesResponse.md)

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

<a name="createcustomerpaymentsources"></a>
# **CreateCustomerPaymentSources**
> CreateCustomerPaymentSourcesResponse CreateCustomerPaymentSources (string id, CreateCustomerPaymentSourcesRequest createCustomerPaymentSourcesRequest, string acceptLanguage = null)

creates a payment source

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
    public class CreateCustomerPaymentSourcesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var id = 6307a60c41de27127515a575;  // string | identifier
            var createCustomerPaymentSourcesRequest = new CreateCustomerPaymentSourcesRequest(); // CreateCustomerPaymentSourcesRequest | requested field for customer payment sources
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // creates a payment source
                CreateCustomerPaymentSourcesResponse result = apiInstance.CreateCustomerPaymentSources(id, createCustomerPaymentSourcesRequest, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CreateCustomerPaymentSources: " + e.Message);
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
    // creates a payment source
    ApiResponse<CreateCustomerPaymentSourcesResponse> response = apiInstance.CreateCustomerPaymentSourcesWithHttpInfo(id, createCustomerPaymentSourcesRequest, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.CreateCustomerPaymentSourcesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | identifier |  |
| **createCustomerPaymentSourcesRequest** | [**CreateCustomerPaymentSourcesRequest**](CreateCustomerPaymentSourcesRequest.md) | requested field for customer payment sources |  |
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |

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

<a name="createcustomershippingcontacts"></a>
# **CreateCustomerShippingContacts**
> CustomerShippingContactsResponse CreateCustomerShippingContacts (string id, CustomerShippingContacts customerShippingContacts, string acceptLanguage = null)

creates a shipping contacts

Gets a customer resource that corresponds to a customer ID.

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

            var apiInstance = new CustomersApi(config);
            var id = 6307a60c41de27127515a575;  // string | identifier
            var customerShippingContacts = new CustomerShippingContacts(); // CustomerShippingContacts | requested field for customer shippings contacts
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // creates a shipping contacts
                CustomerShippingContactsResponse result = apiInstance.CreateCustomerShippingContacts(id, customerShippingContacts, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CreateCustomerShippingContacts: " + e.Message);
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
    // creates a shipping contacts
    ApiResponse<CustomerShippingContactsResponse> response = apiInstance.CreateCustomerShippingContactsWithHttpInfo(id, customerShippingContacts, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.CreateCustomerShippingContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | identifier |  |
| **customerShippingContacts** | [**CustomerShippingContacts**](CustomerShippingContacts.md) | requested field for customer shippings contacts |  |
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |

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

<a name="deletecustomerbyid"></a>
# **DeleteCustomerById**
> CustomerResponse DeleteCustomerById (string id, string acceptLanguage = null)

deletes a customer

Deleted a customer resource that corresponds to a customer ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class DeleteCustomerByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var id = 6307a60c41de27127515a575;  // string | identifier
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // deletes a customer
                CustomerResponse result = apiInstance.DeleteCustomerById(id, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.DeleteCustomerById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCustomerByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // deletes a customer
    ApiResponse<CustomerResponse> response = apiInstance.DeleteCustomerByIdWithHttpInfo(id, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.DeleteCustomerByIdWithHttpInfo: " + e.Message);
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

[**CustomerResponse**](CustomerResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.conekta-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **422** | parameter validation error |  -  |
| **401** | authentication error |  -  |
| **404** | not found entity |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomerpaymentsources"></a>
# **DeleteCustomerPaymentSources**
> UpdateCustomerPaymentSourcesResponse DeleteCustomerPaymentSources (string id, string paymentSourcesId, string acceptLanguage = null)

Deletes a payment source

deletes a payment  source that corresponds to a customer ID.

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

            var apiInstance = new CustomersApi(config);
            var id = 6307a60c41de27127515a575;  // string | identifier
            var paymentSourcesId = tax_lin_2tQ974hSHcsdeSZHG;  // string | identifier
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // Deletes a payment source
                UpdateCustomerPaymentSourcesResponse result = apiInstance.DeleteCustomerPaymentSources(id, paymentSourcesId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.DeleteCustomerPaymentSources: " + e.Message);
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
    // Deletes a payment source
    ApiResponse<UpdateCustomerPaymentSourcesResponse> response = apiInstance.DeleteCustomerPaymentSourcesWithHttpInfo(id, paymentSourcesId, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.DeleteCustomerPaymentSourcesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | identifier |  |
| **paymentSourcesId** | **string** | identifier |  |
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |

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

<a name="getcustomerbyid"></a>
# **GetCustomerById**
> CustomerResponse GetCustomerById (string id, string acceptLanguage = null)

returns a customer

Gets a customer resource that corresponds to a customer ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class GetCustomerByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var id = 6307a60c41de27127515a575;  // string | identifier
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // returns a customer
                CustomerResponse result = apiInstance.GetCustomerById(id, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.GetCustomerById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomerByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // returns a customer
    ApiResponse<CustomerResponse> response = apiInstance.GetCustomerByIdWithHttpInfo(id, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.GetCustomerByIdWithHttpInfo: " + e.Message);
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

[**CustomerResponse**](CustomerResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.conekta-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **422** | parameter validation error |  -  |
| **401** | authentication error |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomers"></a>
# **GetCustomers**
> CustomersResponse GetCustomers (string acceptLanguage = null, int? limit = null, string next = null, string previous = null)

returns customers

The purpose of business is to create and maintain a client, you will learn what elements you need to obtain a list of clients, which can be paged.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class GetCustomersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)
            var limit = 20;  // int? | The numbers of items to return, the maximum value is 250 (optional)  (default to 20)
            var next = "next_example";  // string | next page (optional) 
            var previous = "previous_example";  // string | previous page (optional) 

            try
            {
                // returns customers
                CustomersResponse result = apiInstance.GetCustomers(acceptLanguage, limit, next, previous);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.GetCustomers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // returns customers
    ApiResponse<CustomersResponse> response = apiInstance.GetCustomersWithHttpInfo(acceptLanguage, limit, next, previous);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.GetCustomersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |
| **limit** | **int?** | The numbers of items to return, the maximum value is 250 | [optional] [default to 20] |
| **next** | **string** | next page | [optional]  |
| **previous** | **string** | previous page | [optional]  |

### Return type

[**CustomersResponse**](CustomersResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.conekta-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * Date - The date and time that the response was sent <br>  * Content-Type - The format of the response body <br>  * Content-Length - The length of the response body in bytes <br>  * Connection - The type of connection used to transfer the response <br>  * Conekta-Media-Type -  <br>  |
| **401** | authentication error |  -  |
| **402** | payment required error |  -  |
| **422** | parameter validation error |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomer"></a>
# **UpdateCustomer**
> CustomerResponse UpdateCustomer (string id, UpdateCustomer updateCustomer, string acceptLanguage = null)

updates a customer

You can update customer-related data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class UpdateCustomerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var id = 6307a60c41de27127515a575;  // string | identifier
            var updateCustomer = new UpdateCustomer(); // UpdateCustomer | requested field for customer
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // updates a customer
                CustomerResponse result = apiInstance.UpdateCustomer(id, updateCustomer, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.UpdateCustomer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCustomerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // updates a customer
    ApiResponse<CustomerResponse> response = apiInstance.UpdateCustomerWithHttpInfo(id, updateCustomer, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.UpdateCustomerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | identifier |  |
| **updateCustomer** | [**UpdateCustomer**](UpdateCustomer.md) | requested field for customer |  |
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |

### Return type

[**CustomerResponse**](CustomerResponse.md)

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
| **402** | payment required error |  -  |
| **422** | parameter validation error |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomerfiscalentities"></a>
# **UpdateCustomerFiscalEntities**
> UpdateCustomerFiscalEntitiesResponse UpdateCustomerFiscalEntities (string id, string fiscalEntitiesId, CustomerUpdateFiscalEntitiesRequest customerUpdateFiscalEntitiesRequest, string acceptLanguage = null)

updates a  fiscal entities

updates a customer resource that corresponds to a customer ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class UpdateCustomerFiscalEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomersApi(config);
            var id = 6307a60c41de27127515a575;  // string | identifier
            var fiscalEntitiesId = line_item_2tQ8HkkfbauaKP9Ho;  // string | identifier
            var customerUpdateFiscalEntitiesRequest = new CustomerUpdateFiscalEntitiesRequest(); // CustomerUpdateFiscalEntitiesRequest | requested field for customer update fiscal entities
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // updates a  fiscal entities
                UpdateCustomerFiscalEntitiesResponse result = apiInstance.UpdateCustomerFiscalEntities(id, fiscalEntitiesId, customerUpdateFiscalEntitiesRequest, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.UpdateCustomerFiscalEntities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCustomerFiscalEntitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // updates a  fiscal entities
    ApiResponse<UpdateCustomerFiscalEntitiesResponse> response = apiInstance.UpdateCustomerFiscalEntitiesWithHttpInfo(id, fiscalEntitiesId, customerUpdateFiscalEntitiesRequest, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.UpdateCustomerFiscalEntitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | identifier |  |
| **fiscalEntitiesId** | **string** | identifier |  |
| **customerUpdateFiscalEntitiesRequest** | [**CustomerUpdateFiscalEntitiesRequest**](CustomerUpdateFiscalEntitiesRequest.md) | requested field for customer update fiscal entities |  |
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |

### Return type

[**UpdateCustomerFiscalEntitiesResponse**](UpdateCustomerFiscalEntitiesResponse.md)

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

<a name="updatecustomerpaymentsources"></a>
# **UpdateCustomerPaymentSources**
> UpdateCustomerPaymentSourcesResponse UpdateCustomerPaymentSources (string id, string paymentSourcesId, UpdatePaymentSources updatePaymentSources, string acceptLanguage = null)

updates a payment source

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

            var apiInstance = new CustomersApi(config);
            var id = 6307a60c41de27127515a575;  // string | identifier
            var paymentSourcesId = tax_lin_2tQ974hSHcsdeSZHG;  // string | identifier
            var updatePaymentSources = new UpdatePaymentSources(); // UpdatePaymentSources | requested field for customer payment sources
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // updates a payment source
                UpdateCustomerPaymentSourcesResponse result = apiInstance.UpdateCustomerPaymentSources(id, paymentSourcesId, updatePaymentSources, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.UpdateCustomerPaymentSources: " + e.Message);
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
    // updates a payment source
    ApiResponse<UpdateCustomerPaymentSourcesResponse> response = apiInstance.UpdateCustomerPaymentSourcesWithHttpInfo(id, paymentSourcesId, updatePaymentSources, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.UpdateCustomerPaymentSourcesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | identifier |  |
| **paymentSourcesId** | **string** | identifier |  |
| **updatePaymentSources** | [**UpdatePaymentSources**](UpdatePaymentSources.md) | requested field for customer payment sources |  |
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |

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

<a name="updatecustomershippingcontacts"></a>
# **UpdateCustomerShippingContacts**
> CustomerShippingContactsResponse UpdateCustomerShippingContacts (string id, string shippingContactsId, CustomerShippingContacts customerShippingContacts, string acceptLanguage = null)

updates a shipping contacts

Gets a customer resource that corresponds to a customer ID.

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

            var apiInstance = new CustomersApi(config);
            var id = 6307a60c41de27127515a575;  // string | identifier
            var shippingContactsId = 6307a60c41de27127515a575;  // string | identifier
            var customerShippingContacts = new CustomerShippingContacts(); // CustomerShippingContacts | requested field for customer shippings contacts
            var acceptLanguage = es;  // string | use for knowing which language to use (optional)  (default to es)

            try
            {
                // updates a shipping contacts
                CustomerShippingContactsResponse result = apiInstance.UpdateCustomerShippingContacts(id, shippingContactsId, customerShippingContacts, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.UpdateCustomerShippingContacts: " + e.Message);
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
    // updates a shipping contacts
    ApiResponse<CustomerShippingContactsResponse> response = apiInstance.UpdateCustomerShippingContactsWithHttpInfo(id, shippingContactsId, customerShippingContacts, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.UpdateCustomerShippingContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | identifier |  |
| **shippingContactsId** | **string** | identifier |  |
| **customerShippingContacts** | [**CustomerShippingContacts**](CustomerShippingContacts.md) | requested field for customer shippings contacts |  |
| **acceptLanguage** | **string** | use for knowing which language to use | [optional] [default to es] |

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

