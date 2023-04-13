# Conekta.net.Api.WhitelistsApi

All URIs are relative to *https://api.conekta.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNewRuleWhitelist**](WhitelistsApi.md#createnewrulewhitelist) | **POST** /antifraud/whitelists | Create a whitelisted rule |
| [**DeleteRuleWhitelist**](WhitelistsApi.md#deleterulewhitelist) | **DELETE** /antifraud/whitelists | Delete a whitelisted rule |
| [**GetWhiteList**](WhitelistsApi.md#getwhitelist) | **GET** /antifraud/whitelists | Get a list of whitelisted rules |

<a name="createnewrulewhitelist"></a>
# **CreateNewRuleWhitelist**
> void CreateNewRuleWhitelist (CreateRiskRulesData createRiskRulesData = null)

Create a whitelisted rule

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class CreateNewRuleWhitelistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WhitelistsApi(config);
            var createRiskRulesData = new CreateRiskRulesData(); // CreateRiskRulesData |  (optional) 

            try
            {
                // Create a whitelisted rule
                apiInstance.CreateNewRuleWhitelist(createRiskRulesData);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WhitelistsApi.CreateNewRuleWhitelist: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateNewRuleWhitelistWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a whitelisted rule
    apiInstance.CreateNewRuleWhitelistWithHttpInfo(createRiskRulesData);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WhitelistsApi.CreateNewRuleWhitelistWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createRiskRulesData** | [**CreateRiskRulesData**](CreateRiskRulesData.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successfully registered rule |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterulewhitelist"></a>
# **DeleteRuleWhitelist**
> void DeleteRuleWhitelist ()

Delete a whitelisted rule

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

namespace Example
{
    public class DeleteRuleWhitelistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WhitelistsApi(config);

            try
            {
                // Delete a whitelisted rule
                apiInstance.DeleteRuleWhitelist();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WhitelistsApi.DeleteRuleWhitelist: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRuleWhitelistWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a whitelisted rule
    apiInstance.DeleteRuleWhitelistWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WhitelistsApi.DeleteRuleWhitelistWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successfully deleted rule |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwhitelist"></a>
# **GetWhiteList**
> RiskRulesList GetWhiteList ()

Get a list of whitelisted rules

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
    public class GetWhiteListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.conekta.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WhitelistsApi(config);

            try
            {
                // Get a list of whitelisted rules
                RiskRulesList result = apiInstance.GetWhiteList();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WhitelistsApi.GetWhiteList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWhiteListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of whitelisted rules
    ApiResponse<RiskRulesList> response = apiInstance.GetWhiteListWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WhitelistsApi.GetWhiteListWithHttpInfo: " + e.Message);
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
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All the rules |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

