# BSky.Api.ChatBskyActorApi

All URIs are relative to *https://public.api.bsky.app/xrpc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChatBskyActorDeleteAccount**](ChatBskyActorApi.md#chatbskyactordeleteaccount) | **POST** /chat.bsky.actor.deleteAccount |  |
| [**ChatBskyActorExportAccountData**](ChatBskyActorApi.md#chatbskyactorexportaccountdata) | **GET** /chat.bsky.actor.exportAccountData |  |

<a id="chatbskyactordeleteaccount"></a>
# **ChatBskyActorDeleteAccount**
> AppBskyFeedSendInteractions200Response ChatBskyActorDeleteAccount ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ChatBskyActorDeleteAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChatBskyActorApi(config);

            try
            {
                AppBskyFeedSendInteractions200Response result = apiInstance.ChatBskyActorDeleteAccount();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChatBskyActorApi.ChatBskyActorDeleteAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChatBskyActorDeleteAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyFeedSendInteractions200Response> response = apiInstance.ChatBskyActorDeleteAccountWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChatBskyActorApi.ChatBskyActorDeleteAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AppBskyFeedSendInteractions200Response**](AppBskyFeedSendInteractions200Response.md)

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

<a id="chatbskyactorexportaccountdata"></a>
# **ChatBskyActorExportAccountData**
> void ChatBskyActorExportAccountData ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ChatBskyActorExportAccountDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChatBskyActorApi(config);

            try
            {
                apiInstance.ChatBskyActorExportAccountData();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChatBskyActorApi.ChatBskyActorExportAccountData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChatBskyActorExportAccountDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ChatBskyActorExportAccountDataWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChatBskyActorApi.ChatBskyActorExportAccountDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/jsonl, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

