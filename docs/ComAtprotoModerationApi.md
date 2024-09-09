# BSky.Api.ComAtprotoModerationApi

All URIs are relative to *https://public.api.bsky.app/xrpc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ComAtprotoModerationCreateReport**](ComAtprotoModerationApi.md#comatprotomoderationcreatereport) | **POST** /com.atproto.moderation.createReport |  |

<a id="comatprotomoderationcreatereport"></a>
# **ComAtprotoModerationCreateReport**
> ComAtprotoModerationCreateReport200Response ComAtprotoModerationCreateReport (ComAtprotoModerationCreateReportRequest comAtprotoModerationCreateReportRequest)



Submit a moderation report regarding an atproto account or record. Implemented by moderation services (with PDS proxying), and requires auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoModerationCreateReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoModerationApi(config);
            var comAtprotoModerationCreateReportRequest = new ComAtprotoModerationCreateReportRequest(); // ComAtprotoModerationCreateReportRequest | 

            try
            {
                ComAtprotoModerationCreateReport200Response result = apiInstance.ComAtprotoModerationCreateReport(comAtprotoModerationCreateReportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoModerationApi.ComAtprotoModerationCreateReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoModerationCreateReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoModerationCreateReport200Response> response = apiInstance.ComAtprotoModerationCreateReportWithHttpInfo(comAtprotoModerationCreateReportRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoModerationApi.ComAtprotoModerationCreateReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoModerationCreateReportRequest** | [**ComAtprotoModerationCreateReportRequest**](ComAtprotoModerationCreateReportRequest.md) |  |  |

### Return type

[**ComAtprotoModerationCreateReport200Response**](ComAtprotoModerationCreateReport200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

