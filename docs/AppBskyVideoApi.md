# BSky.Api.AppBskyVideoApi

All URIs are relative to *https://public.api.bsky.app/xrpc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppBskyVideoGetJobStatus**](AppBskyVideoApi.md#appbskyvideogetjobstatus) | **GET** /app.bsky.video.getJobStatus |  |
| [**AppBskyVideoGetUploadLimits**](AppBskyVideoApi.md#appbskyvideogetuploadlimits) | **GET** /app.bsky.video.getUploadLimits |  |
| [**AppBskyVideoUploadVideo**](AppBskyVideoApi.md#appbskyvideouploadvideo) | **POST** /app.bsky.video.uploadVideo |  |

<a id="appbskyvideogetjobstatus"></a>
# **AppBskyVideoGetJobStatus**
> AppBskyVideoGetJobStatus200Response AppBskyVideoGetJobStatus (string jobId)



Get status details for a video processing job.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyVideoGetJobStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyVideoApi(config);
            var jobId = "jobId_example";  // string | 

            try
            {
                AppBskyVideoGetJobStatus200Response result = apiInstance.AppBskyVideoGetJobStatus(jobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyVideoApi.AppBskyVideoGetJobStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyVideoGetJobStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyVideoGetJobStatus200Response> response = apiInstance.AppBskyVideoGetJobStatusWithHttpInfo(jobId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyVideoApi.AppBskyVideoGetJobStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobId** | **string** |  |  |

### Return type

[**AppBskyVideoGetJobStatus200Response**](AppBskyVideoGetJobStatus200Response.md)

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

<a id="appbskyvideogetuploadlimits"></a>
# **AppBskyVideoGetUploadLimits**
> AppBskyVideoGetUploadLimits200Response AppBskyVideoGetUploadLimits ()



Get video upload limits for the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyVideoGetUploadLimitsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyVideoApi(config);

            try
            {
                AppBskyVideoGetUploadLimits200Response result = apiInstance.AppBskyVideoGetUploadLimits();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyVideoApi.AppBskyVideoGetUploadLimits: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyVideoGetUploadLimitsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyVideoGetUploadLimits200Response> response = apiInstance.AppBskyVideoGetUploadLimitsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyVideoApi.AppBskyVideoGetUploadLimitsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AppBskyVideoGetUploadLimits200Response**](AppBskyVideoGetUploadLimits200Response.md)

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

<a id="appbskyvideouploadvideo"></a>
# **AppBskyVideoUploadVideo**
> AppBskyVideoGetJobStatus200Response AppBskyVideoUploadVideo ()



Upload a video to be processed then stored on the PDS.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyVideoUploadVideoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyVideoApi(config);

            try
            {
                AppBskyVideoGetJobStatus200Response result = apiInstance.AppBskyVideoUploadVideo();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyVideoApi.AppBskyVideoUploadVideo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyVideoUploadVideoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyVideoGetJobStatus200Response> response = apiInstance.AppBskyVideoUploadVideoWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyVideoApi.AppBskyVideoUploadVideoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AppBskyVideoGetJobStatus200Response**](AppBskyVideoGetJobStatus200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: video/mp4
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

