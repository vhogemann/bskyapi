# BSky.Api.ChatBskyModerationApi

All URIs are relative to *https://public.api.bsky.app/xrpc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChatBskyModerationGetActorMetadata**](ChatBskyModerationApi.md#chatbskymoderationgetactormetadata) | **GET** /chat.bsky.moderation.getActorMetadata |  |
| [**ChatBskyModerationGetMessageContext**](ChatBskyModerationApi.md#chatbskymoderationgetmessagecontext) | **GET** /chat.bsky.moderation.getMessageContext |  |
| [**ChatBskyModerationUpdateActorAccess**](ChatBskyModerationApi.md#chatbskymoderationupdateactoraccess) | **POST** /chat.bsky.moderation.updateActorAccess |  |

<a id="chatbskymoderationgetactormetadata"></a>
# **ChatBskyModerationGetActorMetadata**
> ChatBskyModerationGetActorMetadata200Response ChatBskyModerationGetActorMetadata (string actor)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ChatBskyModerationGetActorMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChatBskyModerationApi(config);
            var actor = "actor_example";  // string | 

            try
            {
                ChatBskyModerationGetActorMetadata200Response result = apiInstance.ChatBskyModerationGetActorMetadata(actor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChatBskyModerationApi.ChatBskyModerationGetActorMetadata: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChatBskyModerationGetActorMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ChatBskyModerationGetActorMetadata200Response> response = apiInstance.ChatBskyModerationGetActorMetadataWithHttpInfo(actor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChatBskyModerationApi.ChatBskyModerationGetActorMetadataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **actor** | **string** |  |  |

### Return type

[**ChatBskyModerationGetActorMetadata200Response**](ChatBskyModerationGetActorMetadata200Response.md)

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

<a id="chatbskymoderationgetmessagecontext"></a>
# **ChatBskyModerationGetMessageContext**
> ChatBskyModerationGetMessageContext200Response ChatBskyModerationGetMessageContext (string messageId, string? convoId = null, int? before = null, int? after = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ChatBskyModerationGetMessageContextExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChatBskyModerationApi(config);
            var messageId = "messageId_example";  // string | 
            var convoId = "convoId_example";  // string? | Conversation that the message is from. NOTE: this field will eventually be required. (optional) 
            var before = 5;  // int? |  (optional)  (default to 5)
            var after = 5;  // int? |  (optional)  (default to 5)

            try
            {
                ChatBskyModerationGetMessageContext200Response result = apiInstance.ChatBskyModerationGetMessageContext(messageId, convoId, before, after);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChatBskyModerationApi.ChatBskyModerationGetMessageContext: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChatBskyModerationGetMessageContextWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ChatBskyModerationGetMessageContext200Response> response = apiInstance.ChatBskyModerationGetMessageContextWithHttpInfo(messageId, convoId, before, after);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChatBskyModerationApi.ChatBskyModerationGetMessageContextWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **string** |  |  |
| **convoId** | **string?** | Conversation that the message is from. NOTE: this field will eventually be required. | [optional]  |
| **before** | **int?** |  | [optional] [default to 5] |
| **after** | **int?** |  | [optional] [default to 5] |

### Return type

[**ChatBskyModerationGetMessageContext200Response**](ChatBskyModerationGetMessageContext200Response.md)

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

<a id="chatbskymoderationupdateactoraccess"></a>
# **ChatBskyModerationUpdateActorAccess**
> void ChatBskyModerationUpdateActorAccess (ChatBskyModerationUpdateActorAccessRequest chatBskyModerationUpdateActorAccessRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ChatBskyModerationUpdateActorAccessExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChatBskyModerationApi(config);
            var chatBskyModerationUpdateActorAccessRequest = new ChatBskyModerationUpdateActorAccessRequest(); // ChatBskyModerationUpdateActorAccessRequest | 

            try
            {
                apiInstance.ChatBskyModerationUpdateActorAccess(chatBskyModerationUpdateActorAccessRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChatBskyModerationApi.ChatBskyModerationUpdateActorAccess: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChatBskyModerationUpdateActorAccessWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ChatBskyModerationUpdateActorAccessWithHttpInfo(chatBskyModerationUpdateActorAccessRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChatBskyModerationApi.ChatBskyModerationUpdateActorAccessWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chatBskyModerationUpdateActorAccessRequest** | [**ChatBskyModerationUpdateActorAccessRequest**](ChatBskyModerationUpdateActorAccessRequest.md) |  |  |

### Return type

void (empty response body)

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

