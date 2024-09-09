# BSky.Api.ToolsOzoneServerApi

All URIs are relative to *https://public.api.bsky.app/xrpc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ToolsOzoneServerGetConfig**](ToolsOzoneServerApi.md#toolsozoneservergetconfig) | **GET** /tools.ozone.server.getConfig |  |

<a id="toolsozoneservergetconfig"></a>
# **ToolsOzoneServerGetConfig**
> ToolsOzoneServerGetConfig200Response ToolsOzoneServerGetConfig ()



Get details about ozone's server configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ToolsOzoneServerGetConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolsOzoneServerApi(config);

            try
            {
                ToolsOzoneServerGetConfig200Response result = apiInstance.ToolsOzoneServerGetConfig();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsOzoneServerApi.ToolsOzoneServerGetConfig: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ToolsOzoneServerGetConfigWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ToolsOzoneServerGetConfig200Response> response = apiInstance.ToolsOzoneServerGetConfigWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsOzoneServerApi.ToolsOzoneServerGetConfigWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ToolsOzoneServerGetConfig200Response**](ToolsOzoneServerGetConfig200Response.md)

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

