# Conekta.net.Api.BlacklistApi

All URIs are relative to *https://api.conekta.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNewBlacklistRule**](BlacklistApi.md#createnewblacklistrule) | **POST** /antifraud/blacklists | Create a blacklisted rule |
| [**DeleteBlacklistRule**](BlacklistApi.md#deleteblacklistrule) | **DELETE** /antifraud/blacklists | Delete a blacklisted rule |
| [**GetBlacklist**](BlacklistApi.md#getblacklist) | **GET** /antifraud/blacklists | Get a list of blacklisted rules |

<a name="createnewblacklistrule"></a>
# **CreateNewBlacklistRule**
> BlacklistRuleResponse CreateNewBlacklistRule (CreateRiskRulesData createRiskRulesData)

Create a blacklisted rule

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class CreateNewBlacklistRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BlacklistApi(config);
            var createRiskRulesData = new CreateRiskRulesData(); // CreateRiskRulesData | requested field for blacklist rule

            try
            {
                // Create a blacklisted rule
                BlacklistRuleResponse result = apiInstance.CreateNewBlacklistRule(createRiskRulesData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlacklistApi.CreateNewBlacklistRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateNewBlacklistRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a blacklisted rule
    ApiResponse<BlacklistRuleResponse> response = apiInstance.CreateNewBlacklistRuleWithHttpInfo(createRiskRulesData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlacklistApi.CreateNewBlacklistRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createRiskRulesData** | [**CreateRiskRulesData**](CreateRiskRulesData.md) | requested field for blacklist rule |  |

### Return type

[**BlacklistRuleResponse**](BlacklistRuleResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.conekta-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successfully registered rule |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteblacklistrule"></a>
# **DeleteBlacklistRule**
> DeletedBlacklistRuleResponse DeleteBlacklistRule ()

Delete a blacklisted rule

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class DeleteBlacklistRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BlacklistApi(config);

            try
            {
                // Delete a blacklisted rule
                DeletedBlacklistRuleResponse result = apiInstance.DeleteBlacklistRule();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlacklistApi.DeleteBlacklistRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteBlacklistRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a blacklisted rule
    ApiResponse<DeletedBlacklistRuleResponse> response = apiInstance.DeleteBlacklistRuleWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlacklistApi.DeleteBlacklistRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DeletedBlacklistRuleResponse**](DeletedBlacklistRuleResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.conekta-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successfully deleted rule |  -  |
| **401** | authentication error |  -  |
| **404** | not found entity |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getblacklist"></a>
# **GetBlacklist**
> RiskRulesList GetBlacklist ()

Get a list of blacklisted rules

Return all rules

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class GetBlacklistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BlacklistApi(config);

            try
            {
                // Get a list of blacklisted rules
                RiskRulesList result = apiInstance.GetBlacklist();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlacklistApi.GetBlacklist: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBlacklistWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of blacklisted rules
    ApiResponse<RiskRulesList> response = apiInstance.GetBlacklistWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlacklistApi.GetBlacklistWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**RiskRulesList**](RiskRulesList.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.conekta-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All the rules |  -  |
| **401** | authentication error |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

