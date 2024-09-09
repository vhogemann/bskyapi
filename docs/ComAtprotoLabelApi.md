# BSky.Api.ComAtprotoLabelApi

All URIs are relative to *https://public.api.bsky.app/xrpc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ComAtprotoLabelQueryLabels**](ComAtprotoLabelApi.md#comatprotolabelquerylabels) | **GET** /com.atproto.label.queryLabels |  |

<a id="comatprotolabelquerylabels"></a>
# **ComAtprotoLabelQueryLabels**
> ComAtprotoLabelQueryLabels200Response ComAtprotoLabelQueryLabels (List<string> uriPatterns, List<string>? sources = null, int? limit = null, string? cursor = null)



Find labels relevant to the provided AT-URI patterns. Public endpoint for moderation services, though may return different or additional results with auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoLabelQueryLabelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoLabelApi(config);
            var uriPatterns = new List<string>(); // List<string> | List of AT URI patterns to match (boolean 'OR'). Each may be a prefix (ending with '*'; will match inclusive of the string leading to '*'), or a full URI.
            var sources = new List<string>?(); // List<string>? | Optional list of label sources (DIDs) to filter on. (optional) 
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                ComAtprotoLabelQueryLabels200Response result = apiInstance.ComAtprotoLabelQueryLabels(uriPatterns, sources, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoLabelApi.ComAtprotoLabelQueryLabels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoLabelQueryLabelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoLabelQueryLabels200Response> response = apiInstance.ComAtprotoLabelQueryLabelsWithHttpInfo(uriPatterns, sources, limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoLabelApi.ComAtprotoLabelQueryLabelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uriPatterns** | [**List&lt;string&gt;**](string.md) | List of AT URI patterns to match (boolean &#39;OR&#39;). Each may be a prefix (ending with &#39;*&#39;; will match inclusive of the string leading to &#39;*&#39;), or a full URI. |  |
| **sources** | [**List&lt;string&gt;?**](string.md) | Optional list of label sources (DIDs) to filter on. | [optional]  |
| **limit** | **int?** |  | [optional] [default to 50] |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**ComAtprotoLabelQueryLabels200Response**](ComAtprotoLabelQueryLabels200Response.md)

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

