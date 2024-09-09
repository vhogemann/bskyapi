# BSky.Api.ChatBskyConvoApi

All URIs are relative to *https://public.api.bsky.app/xrpc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChatBskyConvoDeleteMessageForSelf**](ChatBskyConvoApi.md#chatbskyconvodeletemessageforself) | **POST** /chat.bsky.convo.deleteMessageForSelf |  |
| [**ChatBskyConvoGetConvo**](ChatBskyConvoApi.md#chatbskyconvogetconvo) | **GET** /chat.bsky.convo.getConvo |  |
| [**ChatBskyConvoGetConvoForMembers**](ChatBskyConvoApi.md#chatbskyconvogetconvoformembers) | **GET** /chat.bsky.convo.getConvoForMembers |  |
| [**ChatBskyConvoGetLog**](ChatBskyConvoApi.md#chatbskyconvogetlog) | **GET** /chat.bsky.convo.getLog |  |
| [**ChatBskyConvoGetMessages**](ChatBskyConvoApi.md#chatbskyconvogetmessages) | **GET** /chat.bsky.convo.getMessages |  |
| [**ChatBskyConvoLeaveConvo**](ChatBskyConvoApi.md#chatbskyconvoleaveconvo) | **POST** /chat.bsky.convo.leaveConvo |  |
| [**ChatBskyConvoListConvos**](ChatBskyConvoApi.md#chatbskyconvolistconvos) | **GET** /chat.bsky.convo.listConvos |  |
| [**ChatBskyConvoMuteConvo**](ChatBskyConvoApi.md#chatbskyconvomuteconvo) | **POST** /chat.bsky.convo.muteConvo |  |
| [**ChatBskyConvoSendMessage**](ChatBskyConvoApi.md#chatbskyconvosendmessage) | **POST** /chat.bsky.convo.sendMessage |  |
| [**ChatBskyConvoSendMessageBatch**](ChatBskyConvoApi.md#chatbskyconvosendmessagebatch) | **POST** /chat.bsky.convo.sendMessageBatch |  |
| [**ChatBskyConvoUnmuteConvo**](ChatBskyConvoApi.md#chatbskyconvounmuteconvo) | **POST** /chat.bsky.convo.unmuteConvo |  |
| [**ChatBskyConvoUpdateRead**](ChatBskyConvoApi.md#chatbskyconvoupdateread) | **POST** /chat.bsky.convo.updateRead |  |

<a id="chatbskyconvodeletemessageforself"></a>
# **ChatBskyConvoDeleteMessageForSelf**
> ChatBskyConvoDefsDeletedMessageView ChatBskyConvoDeleteMessageForSelf (ChatBskyConvoDeleteMessageForSelfRequest chatBskyConvoDeleteMessageForSelfRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ChatBskyConvoDeleteMessageForSelfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChatBskyConvoApi(config);
            var chatBskyConvoDeleteMessageForSelfRequest = new ChatBskyConvoDeleteMessageForSelfRequest(); // ChatBskyConvoDeleteMessageForSelfRequest | 

            try
            {
                ChatBskyConvoDefsDeletedMessageView result = apiInstance.ChatBskyConvoDeleteMessageForSelf(chatBskyConvoDeleteMessageForSelfRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChatBskyConvoApi.ChatBskyConvoDeleteMessageForSelf: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChatBskyConvoDeleteMessageForSelfWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ChatBskyConvoDefsDeletedMessageView> response = apiInstance.ChatBskyConvoDeleteMessageForSelfWithHttpInfo(chatBskyConvoDeleteMessageForSelfRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChatBskyConvoApi.ChatBskyConvoDeleteMessageForSelfWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chatBskyConvoDeleteMessageForSelfRequest** | [**ChatBskyConvoDeleteMessageForSelfRequest**](ChatBskyConvoDeleteMessageForSelfRequest.md) |  |  |

### Return type

[**ChatBskyConvoDefsDeletedMessageView**](ChatBskyConvoDefsDeletedMessageView.md)

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

<a id="chatbskyconvogetconvo"></a>
# **ChatBskyConvoGetConvo**
> ChatBskyConvoGetConvo200Response ChatBskyConvoGetConvo (string convoId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ChatBskyConvoGetConvoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChatBskyConvoApi(config);
            var convoId = "convoId_example";  // string | 

            try
            {
                ChatBskyConvoGetConvo200Response result = apiInstance.ChatBskyConvoGetConvo(convoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChatBskyConvoApi.ChatBskyConvoGetConvo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChatBskyConvoGetConvoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ChatBskyConvoGetConvo200Response> response = apiInstance.ChatBskyConvoGetConvoWithHttpInfo(convoId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChatBskyConvoApi.ChatBskyConvoGetConvoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **convoId** | **string** |  |  |

### Return type

[**ChatBskyConvoGetConvo200Response**](ChatBskyConvoGetConvo200Response.md)

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

<a id="chatbskyconvogetconvoformembers"></a>
# **ChatBskyConvoGetConvoForMembers**
> ChatBskyConvoGetConvo200Response ChatBskyConvoGetConvoForMembers (List<string> members)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ChatBskyConvoGetConvoForMembersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChatBskyConvoApi(config);
            var members = new List<string>(); // List<string> | 

            try
            {
                ChatBskyConvoGetConvo200Response result = apiInstance.ChatBskyConvoGetConvoForMembers(members);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChatBskyConvoApi.ChatBskyConvoGetConvoForMembers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChatBskyConvoGetConvoForMembersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ChatBskyConvoGetConvo200Response> response = apiInstance.ChatBskyConvoGetConvoForMembersWithHttpInfo(members);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChatBskyConvoApi.ChatBskyConvoGetConvoForMembersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **members** | [**List&lt;string&gt;**](string.md) |  |  |

### Return type

[**ChatBskyConvoGetConvo200Response**](ChatBskyConvoGetConvo200Response.md)

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

<a id="chatbskyconvogetlog"></a>
# **ChatBskyConvoGetLog**
> ChatBskyConvoGetLog200Response ChatBskyConvoGetLog (string? cursor = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ChatBskyConvoGetLogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChatBskyConvoApi(config);
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                ChatBskyConvoGetLog200Response result = apiInstance.ChatBskyConvoGetLog(cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChatBskyConvoApi.ChatBskyConvoGetLog: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChatBskyConvoGetLogWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ChatBskyConvoGetLog200Response> response = apiInstance.ChatBskyConvoGetLogWithHttpInfo(cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChatBskyConvoApi.ChatBskyConvoGetLogWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cursor** | **string?** |  | [optional]  |

### Return type

[**ChatBskyConvoGetLog200Response**](ChatBskyConvoGetLog200Response.md)

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

<a id="chatbskyconvogetmessages"></a>
# **ChatBskyConvoGetMessages**
> ChatBskyConvoGetMessages200Response ChatBskyConvoGetMessages (string convoId, int? limit = null, string? cursor = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ChatBskyConvoGetMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChatBskyConvoApi(config);
            var convoId = "convoId_example";  // string | 
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                ChatBskyConvoGetMessages200Response result = apiInstance.ChatBskyConvoGetMessages(convoId, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChatBskyConvoApi.ChatBskyConvoGetMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChatBskyConvoGetMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ChatBskyConvoGetMessages200Response> response = apiInstance.ChatBskyConvoGetMessagesWithHttpInfo(convoId, limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChatBskyConvoApi.ChatBskyConvoGetMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **convoId** | **string** |  |  |
| **limit** | **int?** |  | [optional] [default to 50] |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**ChatBskyConvoGetMessages200Response**](ChatBskyConvoGetMessages200Response.md)

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

<a id="chatbskyconvoleaveconvo"></a>
# **ChatBskyConvoLeaveConvo**
> ChatBskyConvoLeaveConvo200Response ChatBskyConvoLeaveConvo (ChatBskyConvoLeaveConvoRequest chatBskyConvoLeaveConvoRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ChatBskyConvoLeaveConvoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChatBskyConvoApi(config);
            var chatBskyConvoLeaveConvoRequest = new ChatBskyConvoLeaveConvoRequest(); // ChatBskyConvoLeaveConvoRequest | 

            try
            {
                ChatBskyConvoLeaveConvo200Response result = apiInstance.ChatBskyConvoLeaveConvo(chatBskyConvoLeaveConvoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChatBskyConvoApi.ChatBskyConvoLeaveConvo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChatBskyConvoLeaveConvoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ChatBskyConvoLeaveConvo200Response> response = apiInstance.ChatBskyConvoLeaveConvoWithHttpInfo(chatBskyConvoLeaveConvoRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChatBskyConvoApi.ChatBskyConvoLeaveConvoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chatBskyConvoLeaveConvoRequest** | [**ChatBskyConvoLeaveConvoRequest**](ChatBskyConvoLeaveConvoRequest.md) |  |  |

### Return type

[**ChatBskyConvoLeaveConvo200Response**](ChatBskyConvoLeaveConvo200Response.md)

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

<a id="chatbskyconvolistconvos"></a>
# **ChatBskyConvoListConvos**
> ChatBskyConvoListConvos200Response ChatBskyConvoListConvos (int? limit = null, string? cursor = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ChatBskyConvoListConvosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChatBskyConvoApi(config);
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                ChatBskyConvoListConvos200Response result = apiInstance.ChatBskyConvoListConvos(limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChatBskyConvoApi.ChatBskyConvoListConvos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChatBskyConvoListConvosWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ChatBskyConvoListConvos200Response> response = apiInstance.ChatBskyConvoListConvosWithHttpInfo(limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChatBskyConvoApi.ChatBskyConvoListConvosWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** |  | [optional] [default to 50] |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**ChatBskyConvoListConvos200Response**](ChatBskyConvoListConvos200Response.md)

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

<a id="chatbskyconvomuteconvo"></a>
# **ChatBskyConvoMuteConvo**
> ChatBskyConvoGetConvo200Response ChatBskyConvoMuteConvo (ChatBskyConvoLeaveConvoRequest chatBskyConvoLeaveConvoRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ChatBskyConvoMuteConvoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChatBskyConvoApi(config);
            var chatBskyConvoLeaveConvoRequest = new ChatBskyConvoLeaveConvoRequest(); // ChatBskyConvoLeaveConvoRequest | 

            try
            {
                ChatBskyConvoGetConvo200Response result = apiInstance.ChatBskyConvoMuteConvo(chatBskyConvoLeaveConvoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChatBskyConvoApi.ChatBskyConvoMuteConvo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChatBskyConvoMuteConvoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ChatBskyConvoGetConvo200Response> response = apiInstance.ChatBskyConvoMuteConvoWithHttpInfo(chatBskyConvoLeaveConvoRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChatBskyConvoApi.ChatBskyConvoMuteConvoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chatBskyConvoLeaveConvoRequest** | [**ChatBskyConvoLeaveConvoRequest**](ChatBskyConvoLeaveConvoRequest.md) |  |  |

### Return type

[**ChatBskyConvoGetConvo200Response**](ChatBskyConvoGetConvo200Response.md)

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

<a id="chatbskyconvosendmessage"></a>
# **ChatBskyConvoSendMessage**
> ChatBskyConvoDefsMessageView ChatBskyConvoSendMessage (ChatBskyConvoSendMessageRequest chatBskyConvoSendMessageRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ChatBskyConvoSendMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChatBskyConvoApi(config);
            var chatBskyConvoSendMessageRequest = new ChatBskyConvoSendMessageRequest(); // ChatBskyConvoSendMessageRequest | 

            try
            {
                ChatBskyConvoDefsMessageView result = apiInstance.ChatBskyConvoSendMessage(chatBskyConvoSendMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChatBskyConvoApi.ChatBskyConvoSendMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChatBskyConvoSendMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ChatBskyConvoDefsMessageView> response = apiInstance.ChatBskyConvoSendMessageWithHttpInfo(chatBskyConvoSendMessageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChatBskyConvoApi.ChatBskyConvoSendMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chatBskyConvoSendMessageRequest** | [**ChatBskyConvoSendMessageRequest**](ChatBskyConvoSendMessageRequest.md) |  |  |

### Return type

[**ChatBskyConvoDefsMessageView**](ChatBskyConvoDefsMessageView.md)

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

<a id="chatbskyconvosendmessagebatch"></a>
# **ChatBskyConvoSendMessageBatch**
> ChatBskyConvoSendMessageBatch200Response ChatBskyConvoSendMessageBatch (ChatBskyConvoSendMessageBatchRequest chatBskyConvoSendMessageBatchRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ChatBskyConvoSendMessageBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChatBskyConvoApi(config);
            var chatBskyConvoSendMessageBatchRequest = new ChatBskyConvoSendMessageBatchRequest(); // ChatBskyConvoSendMessageBatchRequest | 

            try
            {
                ChatBskyConvoSendMessageBatch200Response result = apiInstance.ChatBskyConvoSendMessageBatch(chatBskyConvoSendMessageBatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChatBskyConvoApi.ChatBskyConvoSendMessageBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChatBskyConvoSendMessageBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ChatBskyConvoSendMessageBatch200Response> response = apiInstance.ChatBskyConvoSendMessageBatchWithHttpInfo(chatBskyConvoSendMessageBatchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChatBskyConvoApi.ChatBskyConvoSendMessageBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chatBskyConvoSendMessageBatchRequest** | [**ChatBskyConvoSendMessageBatchRequest**](ChatBskyConvoSendMessageBatchRequest.md) |  |  |

### Return type

[**ChatBskyConvoSendMessageBatch200Response**](ChatBskyConvoSendMessageBatch200Response.md)

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

<a id="chatbskyconvounmuteconvo"></a>
# **ChatBskyConvoUnmuteConvo**
> ChatBskyConvoGetConvo200Response ChatBskyConvoUnmuteConvo (ChatBskyConvoLeaveConvoRequest chatBskyConvoLeaveConvoRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ChatBskyConvoUnmuteConvoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChatBskyConvoApi(config);
            var chatBskyConvoLeaveConvoRequest = new ChatBskyConvoLeaveConvoRequest(); // ChatBskyConvoLeaveConvoRequest | 

            try
            {
                ChatBskyConvoGetConvo200Response result = apiInstance.ChatBskyConvoUnmuteConvo(chatBskyConvoLeaveConvoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChatBskyConvoApi.ChatBskyConvoUnmuteConvo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChatBskyConvoUnmuteConvoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ChatBskyConvoGetConvo200Response> response = apiInstance.ChatBskyConvoUnmuteConvoWithHttpInfo(chatBskyConvoLeaveConvoRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChatBskyConvoApi.ChatBskyConvoUnmuteConvoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chatBskyConvoLeaveConvoRequest** | [**ChatBskyConvoLeaveConvoRequest**](ChatBskyConvoLeaveConvoRequest.md) |  |  |

### Return type

[**ChatBskyConvoGetConvo200Response**](ChatBskyConvoGetConvo200Response.md)

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

<a id="chatbskyconvoupdateread"></a>
# **ChatBskyConvoUpdateRead**
> ChatBskyConvoGetConvo200Response ChatBskyConvoUpdateRead (ChatBskyConvoUpdateReadRequest chatBskyConvoUpdateReadRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ChatBskyConvoUpdateReadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChatBskyConvoApi(config);
            var chatBskyConvoUpdateReadRequest = new ChatBskyConvoUpdateReadRequest(); // ChatBskyConvoUpdateReadRequest | 

            try
            {
                ChatBskyConvoGetConvo200Response result = apiInstance.ChatBskyConvoUpdateRead(chatBskyConvoUpdateReadRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChatBskyConvoApi.ChatBskyConvoUpdateRead: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChatBskyConvoUpdateReadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ChatBskyConvoGetConvo200Response> response = apiInstance.ChatBskyConvoUpdateReadWithHttpInfo(chatBskyConvoUpdateReadRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChatBskyConvoApi.ChatBskyConvoUpdateReadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chatBskyConvoUpdateReadRequest** | [**ChatBskyConvoUpdateReadRequest**](ChatBskyConvoUpdateReadRequest.md) |  |  |

### Return type

[**ChatBskyConvoGetConvo200Response**](ChatBskyConvoGetConvo200Response.md)

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

