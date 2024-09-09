# BSky.Api.AppBskyLabelerApi

All URIs are relative to *https://public.api.bsky.app/xrpc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppBskyLabelerGetServices**](AppBskyLabelerApi.md#appbskylabelergetservices) | **GET** /app.bsky.labeler.getServices |  |

<a id="appbskylabelergetservices"></a>
# **AppBskyLabelerGetServices**
> AppBskyLabelerGetServices200Response AppBskyLabelerGetServices (List<string> dids, bool? detailed = null)



Get information about a list of labeler services.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyLabelerGetServicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyLabelerApi(config);
            var dids = new List<string>(); // List<string> | 
            var detailed = true;  // bool? |  (optional) 

            try
            {
                AppBskyLabelerGetServices200Response result = apiInstance.AppBskyLabelerGetServices(dids, detailed);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyLabelerApi.AppBskyLabelerGetServices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyLabelerGetServicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyLabelerGetServices200Response> response = apiInstance.AppBskyLabelerGetServicesWithHttpInfo(dids, detailed);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyLabelerApi.AppBskyLabelerGetServicesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dids** | [**List&lt;string&gt;**](string.md) |  |  |
| **detailed** | **bool?** |  | [optional]  |

### Return type

[**AppBskyLabelerGetServices200Response**](AppBskyLabelerGetServices200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

