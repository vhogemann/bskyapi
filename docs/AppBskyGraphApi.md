# BSky.Api.AppBskyGraphApi

All URIs are relative to *https://public.api.bsky.app/xrpc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppBskyGraphGetActorStarterPacks**](AppBskyGraphApi.md#appbskygraphgetactorstarterpacks) | **GET** /app.bsky.graph.getActorStarterPacks |  |
| [**AppBskyGraphGetBlocks**](AppBskyGraphApi.md#appbskygraphgetblocks) | **GET** /app.bsky.graph.getBlocks |  |
| [**AppBskyGraphGetFollowers**](AppBskyGraphApi.md#appbskygraphgetfollowers) | **GET** /app.bsky.graph.getFollowers |  |
| [**AppBskyGraphGetFollows**](AppBskyGraphApi.md#appbskygraphgetfollows) | **GET** /app.bsky.graph.getFollows |  |
| [**AppBskyGraphGetKnownFollowers**](AppBskyGraphApi.md#appbskygraphgetknownfollowers) | **GET** /app.bsky.graph.getKnownFollowers |  |
| [**AppBskyGraphGetList**](AppBskyGraphApi.md#appbskygraphgetlist) | **GET** /app.bsky.graph.getList |  |
| [**AppBskyGraphGetListBlocks**](AppBskyGraphApi.md#appbskygraphgetlistblocks) | **GET** /app.bsky.graph.getListBlocks |  |
| [**AppBskyGraphGetListMutes**](AppBskyGraphApi.md#appbskygraphgetlistmutes) | **GET** /app.bsky.graph.getListMutes |  |
| [**AppBskyGraphGetLists**](AppBskyGraphApi.md#appbskygraphgetlists) | **GET** /app.bsky.graph.getLists |  |
| [**AppBskyGraphGetMutes**](AppBskyGraphApi.md#appbskygraphgetmutes) | **GET** /app.bsky.graph.getMutes |  |
| [**AppBskyGraphGetRelationships**](AppBskyGraphApi.md#appbskygraphgetrelationships) | **GET** /app.bsky.graph.getRelationships |  |
| [**AppBskyGraphGetStarterPack**](AppBskyGraphApi.md#appbskygraphgetstarterpack) | **GET** /app.bsky.graph.getStarterPack |  |
| [**AppBskyGraphGetStarterPacks**](AppBskyGraphApi.md#appbskygraphgetstarterpacks) | **GET** /app.bsky.graph.getStarterPacks |  |
| [**AppBskyGraphGetSuggestedFollowsByActor**](AppBskyGraphApi.md#appbskygraphgetsuggestedfollowsbyactor) | **GET** /app.bsky.graph.getSuggestedFollowsByActor |  |
| [**AppBskyGraphMuteActor**](AppBskyGraphApi.md#appbskygraphmuteactor) | **POST** /app.bsky.graph.muteActor |  |
| [**AppBskyGraphMuteActorList**](AppBskyGraphApi.md#appbskygraphmuteactorlist) | **POST** /app.bsky.graph.muteActorList |  |
| [**AppBskyGraphMuteThread**](AppBskyGraphApi.md#appbskygraphmutethread) | **POST** /app.bsky.graph.muteThread |  |
| [**AppBskyGraphUnmuteActor**](AppBskyGraphApi.md#appbskygraphunmuteactor) | **POST** /app.bsky.graph.unmuteActor |  |
| [**AppBskyGraphUnmuteActorList**](AppBskyGraphApi.md#appbskygraphunmuteactorlist) | **POST** /app.bsky.graph.unmuteActorList |  |
| [**AppBskyGraphUnmuteThread**](AppBskyGraphApi.md#appbskygraphunmutethread) | **POST** /app.bsky.graph.unmuteThread |  |

<a id="appbskygraphgetactorstarterpacks"></a>
# **AppBskyGraphGetActorStarterPacks**
> AppBskyGraphGetActorStarterPacks200Response AppBskyGraphGetActorStarterPacks (string actor, int? limit = null, string? cursor = null)



Get a list of starter packs created by the actor.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyGraphGetActorStarterPacksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyGraphApi(config);
            var actor = "actor_example";  // string | 
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                AppBskyGraphGetActorStarterPacks200Response result = apiInstance.AppBskyGraphGetActorStarterPacks(actor, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetActorStarterPacks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyGraphGetActorStarterPacksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyGraphGetActorStarterPacks200Response> response = apiInstance.AppBskyGraphGetActorStarterPacksWithHttpInfo(actor, limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetActorStarterPacksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **actor** | **string** |  |  |
| **limit** | **int?** |  | [optional] [default to 50] |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**AppBskyGraphGetActorStarterPacks200Response**](AppBskyGraphGetActorStarterPacks200Response.md)

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

<a id="appbskygraphgetblocks"></a>
# **AppBskyGraphGetBlocks**
> AppBskyGraphGetBlocks200Response AppBskyGraphGetBlocks (int? limit = null, string? cursor = null)



Enumerates which accounts the requesting account is currently blocking. Requires auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyGraphGetBlocksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyGraphApi(config);
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                AppBskyGraphGetBlocks200Response result = apiInstance.AppBskyGraphGetBlocks(limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetBlocks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyGraphGetBlocksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyGraphGetBlocks200Response> response = apiInstance.AppBskyGraphGetBlocksWithHttpInfo(limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetBlocksWithHttpInfo: " + e.Message);
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

[**AppBskyGraphGetBlocks200Response**](AppBskyGraphGetBlocks200Response.md)

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

<a id="appbskygraphgetfollowers"></a>
# **AppBskyGraphGetFollowers**
> AppBskyGraphGetFollowers200Response AppBskyGraphGetFollowers (string actor, int? limit = null, string? cursor = null)



Enumerates accounts which follow a specified account (actor).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyGraphGetFollowersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyGraphApi(config);
            var actor = "actor_example";  // string | 
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                AppBskyGraphGetFollowers200Response result = apiInstance.AppBskyGraphGetFollowers(actor, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetFollowers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyGraphGetFollowersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyGraphGetFollowers200Response> response = apiInstance.AppBskyGraphGetFollowersWithHttpInfo(actor, limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetFollowersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **actor** | **string** |  |  |
| **limit** | **int?** |  | [optional] [default to 50] |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**AppBskyGraphGetFollowers200Response**](AppBskyGraphGetFollowers200Response.md)

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

<a id="appbskygraphgetfollows"></a>
# **AppBskyGraphGetFollows**
> AppBskyGraphGetFollows200Response AppBskyGraphGetFollows (string actor, int? limit = null, string? cursor = null)



Enumerates accounts which a specified account (actor) follows.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyGraphGetFollowsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyGraphApi(config);
            var actor = "actor_example";  // string | 
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                AppBskyGraphGetFollows200Response result = apiInstance.AppBskyGraphGetFollows(actor, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetFollows: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyGraphGetFollowsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyGraphGetFollows200Response> response = apiInstance.AppBskyGraphGetFollowsWithHttpInfo(actor, limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetFollowsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **actor** | **string** |  |  |
| **limit** | **int?** |  | [optional] [default to 50] |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**AppBskyGraphGetFollows200Response**](AppBskyGraphGetFollows200Response.md)

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

<a id="appbskygraphgetknownfollowers"></a>
# **AppBskyGraphGetKnownFollowers**
> AppBskyGraphGetFollowers200Response AppBskyGraphGetKnownFollowers (string actor, int? limit = null, string? cursor = null)



Enumerates accounts which follow a specified account (actor) and are followed by the viewer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyGraphGetKnownFollowersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyGraphApi(config);
            var actor = "actor_example";  // string | 
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                AppBskyGraphGetFollowers200Response result = apiInstance.AppBskyGraphGetKnownFollowers(actor, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetKnownFollowers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyGraphGetKnownFollowersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyGraphGetFollowers200Response> response = apiInstance.AppBskyGraphGetKnownFollowersWithHttpInfo(actor, limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetKnownFollowersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **actor** | **string** |  |  |
| **limit** | **int?** |  | [optional] [default to 50] |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**AppBskyGraphGetFollowers200Response**](AppBskyGraphGetFollowers200Response.md)

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

<a id="appbskygraphgetlist"></a>
# **AppBskyGraphGetList**
> AppBskyGraphGetList200Response AppBskyGraphGetList (string list, int? limit = null, string? cursor = null)



Gets a 'view' (with additional context) of a specified list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyGraphGetListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyGraphApi(config);
            var list = "list_example";  // string | Reference (AT-URI) of the list record to hydrate.
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                AppBskyGraphGetList200Response result = apiInstance.AppBskyGraphGetList(list, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyGraphGetListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyGraphGetList200Response> response = apiInstance.AppBskyGraphGetListWithHttpInfo(list, limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **list** | **string** | Reference (AT-URI) of the list record to hydrate. |  |
| **limit** | **int?** |  | [optional] [default to 50] |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**AppBskyGraphGetList200Response**](AppBskyGraphGetList200Response.md)

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

<a id="appbskygraphgetlistblocks"></a>
# **AppBskyGraphGetListBlocks**
> AppBskyGraphGetListBlocks200Response AppBskyGraphGetListBlocks (int? limit = null, string? cursor = null)



Get mod lists that the requesting account (actor) is blocking. Requires auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyGraphGetListBlocksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyGraphApi(config);
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                AppBskyGraphGetListBlocks200Response result = apiInstance.AppBskyGraphGetListBlocks(limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetListBlocks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyGraphGetListBlocksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyGraphGetListBlocks200Response> response = apiInstance.AppBskyGraphGetListBlocksWithHttpInfo(limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetListBlocksWithHttpInfo: " + e.Message);
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

[**AppBskyGraphGetListBlocks200Response**](AppBskyGraphGetListBlocks200Response.md)

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

<a id="appbskygraphgetlistmutes"></a>
# **AppBskyGraphGetListMutes**
> AppBskyGraphGetListBlocks200Response AppBskyGraphGetListMutes (int? limit = null, string? cursor = null)



Enumerates mod lists that the requesting account (actor) currently has muted. Requires auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyGraphGetListMutesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyGraphApi(config);
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                AppBskyGraphGetListBlocks200Response result = apiInstance.AppBskyGraphGetListMutes(limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetListMutes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyGraphGetListMutesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyGraphGetListBlocks200Response> response = apiInstance.AppBskyGraphGetListMutesWithHttpInfo(limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetListMutesWithHttpInfo: " + e.Message);
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

[**AppBskyGraphGetListBlocks200Response**](AppBskyGraphGetListBlocks200Response.md)

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

<a id="appbskygraphgetlists"></a>
# **AppBskyGraphGetLists**
> AppBskyGraphGetListBlocks200Response AppBskyGraphGetLists (string actor, int? limit = null, string? cursor = null)



Enumerates the lists created by a specified account (actor).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyGraphGetListsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyGraphApi(config);
            var actor = "actor_example";  // string | The account (actor) to enumerate lists from.
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                AppBskyGraphGetListBlocks200Response result = apiInstance.AppBskyGraphGetLists(actor, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetLists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyGraphGetListsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyGraphGetListBlocks200Response> response = apiInstance.AppBskyGraphGetListsWithHttpInfo(actor, limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetListsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **actor** | **string** | The account (actor) to enumerate lists from. |  |
| **limit** | **int?** |  | [optional] [default to 50] |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**AppBskyGraphGetListBlocks200Response**](AppBskyGraphGetListBlocks200Response.md)

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

<a id="appbskygraphgetmutes"></a>
# **AppBskyGraphGetMutes**
> AppBskyGraphGetMutes200Response AppBskyGraphGetMutes (int? limit = null, string? cursor = null)



Enumerates accounts that the requesting account (actor) currently has muted. Requires auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyGraphGetMutesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyGraphApi(config);
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                AppBskyGraphGetMutes200Response result = apiInstance.AppBskyGraphGetMutes(limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetMutes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyGraphGetMutesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyGraphGetMutes200Response> response = apiInstance.AppBskyGraphGetMutesWithHttpInfo(limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetMutesWithHttpInfo: " + e.Message);
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

[**AppBskyGraphGetMutes200Response**](AppBskyGraphGetMutes200Response.md)

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

<a id="appbskygraphgetrelationships"></a>
# **AppBskyGraphGetRelationships**
> AppBskyGraphGetRelationships200Response AppBskyGraphGetRelationships (string actor, List<string>? others = null)



Enumerates public relationships between one account, and a list of other accounts. Does not require auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyGraphGetRelationshipsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyGraphApi(config);
            var actor = "actor_example";  // string | Primary account requesting relationships for.
            var others = new List<string>?(); // List<string>? | List of 'other' accounts to be related back to the primary. (optional) 

            try
            {
                AppBskyGraphGetRelationships200Response result = apiInstance.AppBskyGraphGetRelationships(actor, others);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetRelationships: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyGraphGetRelationshipsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyGraphGetRelationships200Response> response = apiInstance.AppBskyGraphGetRelationshipsWithHttpInfo(actor, others);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetRelationshipsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **actor** | **string** | Primary account requesting relationships for. |  |
| **others** | [**List&lt;string&gt;?**](string.md) | List of &#39;other&#39; accounts to be related back to the primary. | [optional]  |

### Return type

[**AppBskyGraphGetRelationships200Response**](AppBskyGraphGetRelationships200Response.md)

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

<a id="appbskygraphgetstarterpack"></a>
# **AppBskyGraphGetStarterPack**
> AppBskyGraphGetStarterPack200Response AppBskyGraphGetStarterPack (string starterPack)



Gets a view of a starter pack.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyGraphGetStarterPackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyGraphApi(config);
            var starterPack = "starterPack_example";  // string | Reference (AT-URI) of the starter pack record.

            try
            {
                AppBskyGraphGetStarterPack200Response result = apiInstance.AppBskyGraphGetStarterPack(starterPack);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetStarterPack: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyGraphGetStarterPackWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyGraphGetStarterPack200Response> response = apiInstance.AppBskyGraphGetStarterPackWithHttpInfo(starterPack);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetStarterPackWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **starterPack** | **string** | Reference (AT-URI) of the starter pack record. |  |

### Return type

[**AppBskyGraphGetStarterPack200Response**](AppBskyGraphGetStarterPack200Response.md)

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

<a id="appbskygraphgetstarterpacks"></a>
# **AppBskyGraphGetStarterPacks**
> AppBskyGraphGetStarterPacks200Response AppBskyGraphGetStarterPacks (List<string> uris)



Get views for a list of starter packs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyGraphGetStarterPacksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyGraphApi(config);
            var uris = new List<string>(); // List<string> | 

            try
            {
                AppBskyGraphGetStarterPacks200Response result = apiInstance.AppBskyGraphGetStarterPacks(uris);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetStarterPacks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyGraphGetStarterPacksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyGraphGetStarterPacks200Response> response = apiInstance.AppBskyGraphGetStarterPacksWithHttpInfo(uris);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetStarterPacksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uris** | [**List&lt;string&gt;**](string.md) |  |  |

### Return type

[**AppBskyGraphGetStarterPacks200Response**](AppBskyGraphGetStarterPacks200Response.md)

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

<a id="appbskygraphgetsuggestedfollowsbyactor"></a>
# **AppBskyGraphGetSuggestedFollowsByActor**
> AppBskyGraphGetSuggestedFollowsByActor200Response AppBskyGraphGetSuggestedFollowsByActor (string actor)



Enumerates follows similar to a given account (actor). Expected use is to recommend additional accounts immediately after following one account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyGraphGetSuggestedFollowsByActorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyGraphApi(config);
            var actor = "actor_example";  // string | 

            try
            {
                AppBskyGraphGetSuggestedFollowsByActor200Response result = apiInstance.AppBskyGraphGetSuggestedFollowsByActor(actor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetSuggestedFollowsByActor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyGraphGetSuggestedFollowsByActorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyGraphGetSuggestedFollowsByActor200Response> response = apiInstance.AppBskyGraphGetSuggestedFollowsByActorWithHttpInfo(actor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphGetSuggestedFollowsByActorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **actor** | **string** |  |  |

### Return type

[**AppBskyGraphGetSuggestedFollowsByActor200Response**](AppBskyGraphGetSuggestedFollowsByActor200Response.md)

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

<a id="appbskygraphmuteactor"></a>
# **AppBskyGraphMuteActor**
> void AppBskyGraphMuteActor (AppBskyGraphMuteActorRequest appBskyGraphMuteActorRequest)



Creates a mute relationship for the specified account. Mutes are private in Bluesky. Requires auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyGraphMuteActorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyGraphApi(config);
            var appBskyGraphMuteActorRequest = new AppBskyGraphMuteActorRequest(); // AppBskyGraphMuteActorRequest | 

            try
            {
                apiInstance.AppBskyGraphMuteActor(appBskyGraphMuteActorRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphMuteActor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyGraphMuteActorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppBskyGraphMuteActorWithHttpInfo(appBskyGraphMuteActorRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphMuteActorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appBskyGraphMuteActorRequest** | [**AppBskyGraphMuteActorRequest**](AppBskyGraphMuteActorRequest.md) |  |  |

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

<a id="appbskygraphmuteactorlist"></a>
# **AppBskyGraphMuteActorList**
> void AppBskyGraphMuteActorList (AppBskyGraphMuteActorListRequest appBskyGraphMuteActorListRequest)



Creates a mute relationship for the specified list of accounts. Mutes are private in Bluesky. Requires auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyGraphMuteActorListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyGraphApi(config);
            var appBskyGraphMuteActorListRequest = new AppBskyGraphMuteActorListRequest(); // AppBskyGraphMuteActorListRequest | 

            try
            {
                apiInstance.AppBskyGraphMuteActorList(appBskyGraphMuteActorListRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphMuteActorList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyGraphMuteActorListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppBskyGraphMuteActorListWithHttpInfo(appBskyGraphMuteActorListRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphMuteActorListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appBskyGraphMuteActorListRequest** | [**AppBskyGraphMuteActorListRequest**](AppBskyGraphMuteActorListRequest.md) |  |  |

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

<a id="appbskygraphmutethread"></a>
# **AppBskyGraphMuteThread**
> void AppBskyGraphMuteThread (AppBskyGraphMuteThreadRequest appBskyGraphMuteThreadRequest)



Mutes a thread preventing notifications from the thread and any of its children. Mutes are private in Bluesky. Requires auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyGraphMuteThreadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyGraphApi(config);
            var appBskyGraphMuteThreadRequest = new AppBskyGraphMuteThreadRequest(); // AppBskyGraphMuteThreadRequest | 

            try
            {
                apiInstance.AppBskyGraphMuteThread(appBskyGraphMuteThreadRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphMuteThread: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyGraphMuteThreadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppBskyGraphMuteThreadWithHttpInfo(appBskyGraphMuteThreadRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphMuteThreadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appBskyGraphMuteThreadRequest** | [**AppBskyGraphMuteThreadRequest**](AppBskyGraphMuteThreadRequest.md) |  |  |

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

<a id="appbskygraphunmuteactor"></a>
# **AppBskyGraphUnmuteActor**
> void AppBskyGraphUnmuteActor (AppBskyGraphMuteActorRequest appBskyGraphMuteActorRequest)



Unmutes the specified account. Requires auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyGraphUnmuteActorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyGraphApi(config);
            var appBskyGraphMuteActorRequest = new AppBskyGraphMuteActorRequest(); // AppBskyGraphMuteActorRequest | 

            try
            {
                apiInstance.AppBskyGraphUnmuteActor(appBskyGraphMuteActorRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphUnmuteActor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyGraphUnmuteActorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppBskyGraphUnmuteActorWithHttpInfo(appBskyGraphMuteActorRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphUnmuteActorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appBskyGraphMuteActorRequest** | [**AppBskyGraphMuteActorRequest**](AppBskyGraphMuteActorRequest.md) |  |  |

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

<a id="appbskygraphunmuteactorlist"></a>
# **AppBskyGraphUnmuteActorList**
> void AppBskyGraphUnmuteActorList (AppBskyGraphMuteActorListRequest appBskyGraphMuteActorListRequest)



Unmutes the specified list of accounts. Requires auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyGraphUnmuteActorListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyGraphApi(config);
            var appBskyGraphMuteActorListRequest = new AppBskyGraphMuteActorListRequest(); // AppBskyGraphMuteActorListRequest | 

            try
            {
                apiInstance.AppBskyGraphUnmuteActorList(appBskyGraphMuteActorListRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphUnmuteActorList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyGraphUnmuteActorListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppBskyGraphUnmuteActorListWithHttpInfo(appBskyGraphMuteActorListRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphUnmuteActorListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appBskyGraphMuteActorListRequest** | [**AppBskyGraphMuteActorListRequest**](AppBskyGraphMuteActorListRequest.md) |  |  |

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

<a id="appbskygraphunmutethread"></a>
# **AppBskyGraphUnmuteThread**
> void AppBskyGraphUnmuteThread (AppBskyGraphMuteThreadRequest appBskyGraphMuteThreadRequest)



Unmutes the specified thread. Requires auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyGraphUnmuteThreadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyGraphApi(config);
            var appBskyGraphMuteThreadRequest = new AppBskyGraphMuteThreadRequest(); // AppBskyGraphMuteThreadRequest | 

            try
            {
                apiInstance.AppBskyGraphUnmuteThread(appBskyGraphMuteThreadRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphUnmuteThread: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyGraphUnmuteThreadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppBskyGraphUnmuteThreadWithHttpInfo(appBskyGraphMuteThreadRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyGraphApi.AppBskyGraphUnmuteThreadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appBskyGraphMuteThreadRequest** | [**AppBskyGraphMuteThreadRequest**](AppBskyGraphMuteThreadRequest.md) |  |  |

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

