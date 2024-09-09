# BSky.Api.AppBskyNotificationApi

All URIs are relative to *https://public.api.bsky.app/xrpc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppBskyNotificationGetUnreadCount**](AppBskyNotificationApi.md#appbskynotificationgetunreadcount) | **GET** /app.bsky.notification.getUnreadCount |  |
| [**AppBskyNotificationListNotifications**](AppBskyNotificationApi.md#appbskynotificationlistnotifications) | **GET** /app.bsky.notification.listNotifications |  |
| [**AppBskyNotificationPutPreferences**](AppBskyNotificationApi.md#appbskynotificationputpreferences) | **POST** /app.bsky.notification.putPreferences |  |
| [**AppBskyNotificationRegisterPush**](AppBskyNotificationApi.md#appbskynotificationregisterpush) | **POST** /app.bsky.notification.registerPush |  |
| [**AppBskyNotificationUpdateSeen**](AppBskyNotificationApi.md#appbskynotificationupdateseen) | **POST** /app.bsky.notification.updateSeen |  |

<a id="appbskynotificationgetunreadcount"></a>
# **AppBskyNotificationGetUnreadCount**
> AppBskyNotificationGetUnreadCount200Response AppBskyNotificationGetUnreadCount (bool? priority = null, DateTime? seenAt = null)



Count the number of unread notifications for the requesting account. Requires auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyNotificationGetUnreadCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyNotificationApi(config);
            var priority = true;  // bool? |  (optional) 
            var seenAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                AppBskyNotificationGetUnreadCount200Response result = apiInstance.AppBskyNotificationGetUnreadCount(priority, seenAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyNotificationApi.AppBskyNotificationGetUnreadCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyNotificationGetUnreadCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyNotificationGetUnreadCount200Response> response = apiInstance.AppBskyNotificationGetUnreadCountWithHttpInfo(priority, seenAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyNotificationApi.AppBskyNotificationGetUnreadCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **priority** | **bool?** |  | [optional]  |
| **seenAt** | **DateTime?** |  | [optional]  |

### Return type

[**AppBskyNotificationGetUnreadCount200Response**](AppBskyNotificationGetUnreadCount200Response.md)

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

<a id="appbskynotificationlistnotifications"></a>
# **AppBskyNotificationListNotifications**
> AppBskyNotificationListNotifications200Response AppBskyNotificationListNotifications (int? limit = null, bool? priority = null, string? cursor = null, DateTime? seenAt = null)



Enumerate notifications for the requesting account. Requires auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyNotificationListNotificationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyNotificationApi(config);
            var limit = 50;  // int? |  (optional)  (default to 50)
            var priority = true;  // bool? |  (optional) 
            var cursor = "cursor_example";  // string? |  (optional) 
            var seenAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                AppBskyNotificationListNotifications200Response result = apiInstance.AppBskyNotificationListNotifications(limit, priority, cursor, seenAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyNotificationApi.AppBskyNotificationListNotifications: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyNotificationListNotificationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyNotificationListNotifications200Response> response = apiInstance.AppBskyNotificationListNotificationsWithHttpInfo(limit, priority, cursor, seenAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyNotificationApi.AppBskyNotificationListNotificationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** |  | [optional] [default to 50] |
| **priority** | **bool?** |  | [optional]  |
| **cursor** | **string?** |  | [optional]  |
| **seenAt** | **DateTime?** |  | [optional]  |

### Return type

[**AppBskyNotificationListNotifications200Response**](AppBskyNotificationListNotifications200Response.md)

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

<a id="appbskynotificationputpreferences"></a>
# **AppBskyNotificationPutPreferences**
> void AppBskyNotificationPutPreferences (AppBskyNotificationPutPreferencesRequest appBskyNotificationPutPreferencesRequest)



Set notification-related preferences for an account. Requires auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyNotificationPutPreferencesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyNotificationApi(config);
            var appBskyNotificationPutPreferencesRequest = new AppBskyNotificationPutPreferencesRequest(); // AppBskyNotificationPutPreferencesRequest | 

            try
            {
                apiInstance.AppBskyNotificationPutPreferences(appBskyNotificationPutPreferencesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyNotificationApi.AppBskyNotificationPutPreferences: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyNotificationPutPreferencesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppBskyNotificationPutPreferencesWithHttpInfo(appBskyNotificationPutPreferencesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyNotificationApi.AppBskyNotificationPutPreferencesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appBskyNotificationPutPreferencesRequest** | [**AppBskyNotificationPutPreferencesRequest**](AppBskyNotificationPutPreferencesRequest.md) |  |  |

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

<a id="appbskynotificationregisterpush"></a>
# **AppBskyNotificationRegisterPush**
> void AppBskyNotificationRegisterPush (AppBskyNotificationRegisterPushRequest appBskyNotificationRegisterPushRequest)



Register to receive push notifications, via a specified service, for the requesting account. Requires auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyNotificationRegisterPushExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyNotificationApi(config);
            var appBskyNotificationRegisterPushRequest = new AppBskyNotificationRegisterPushRequest(); // AppBskyNotificationRegisterPushRequest | 

            try
            {
                apiInstance.AppBskyNotificationRegisterPush(appBskyNotificationRegisterPushRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyNotificationApi.AppBskyNotificationRegisterPush: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyNotificationRegisterPushWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppBskyNotificationRegisterPushWithHttpInfo(appBskyNotificationRegisterPushRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyNotificationApi.AppBskyNotificationRegisterPushWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appBskyNotificationRegisterPushRequest** | [**AppBskyNotificationRegisterPushRequest**](AppBskyNotificationRegisterPushRequest.md) |  |  |

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

<a id="appbskynotificationupdateseen"></a>
# **AppBskyNotificationUpdateSeen**
> void AppBskyNotificationUpdateSeen (AppBskyNotificationUpdateSeenRequest appBskyNotificationUpdateSeenRequest)



Notify server that the requesting account has seen notifications. Requires auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyNotificationUpdateSeenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyNotificationApi(config);
            var appBskyNotificationUpdateSeenRequest = new AppBskyNotificationUpdateSeenRequest(); // AppBskyNotificationUpdateSeenRequest | 

            try
            {
                apiInstance.AppBskyNotificationUpdateSeen(appBskyNotificationUpdateSeenRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyNotificationApi.AppBskyNotificationUpdateSeen: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyNotificationUpdateSeenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppBskyNotificationUpdateSeenWithHttpInfo(appBskyNotificationUpdateSeenRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyNotificationApi.AppBskyNotificationUpdateSeenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appBskyNotificationUpdateSeenRequest** | [**AppBskyNotificationUpdateSeenRequest**](AppBskyNotificationUpdateSeenRequest.md) |  |  |

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

