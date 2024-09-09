# BSky.Api.AppBskyActorApi

All URIs are relative to *https://public.api.bsky.app/xrpc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppBskyActorGetPreferences**](AppBskyActorApi.md#appbskyactorgetpreferences) | **GET** /app.bsky.actor.getPreferences |  |
| [**AppBskyActorGetProfile**](AppBskyActorApi.md#appbskyactorgetprofile) | **GET** /app.bsky.actor.getProfile |  |
| [**AppBskyActorGetProfiles**](AppBskyActorApi.md#appbskyactorgetprofiles) | **GET** /app.bsky.actor.getProfiles |  |
| [**AppBskyActorGetSuggestions**](AppBskyActorApi.md#appbskyactorgetsuggestions) | **GET** /app.bsky.actor.getSuggestions |  |
| [**AppBskyActorPutPreferences**](AppBskyActorApi.md#appbskyactorputpreferences) | **POST** /app.bsky.actor.putPreferences |  |
| [**AppBskyActorSearchActors**](AppBskyActorApi.md#appbskyactorsearchactors) | **GET** /app.bsky.actor.searchActors |  |
| [**AppBskyActorSearchActorsTypeahead**](AppBskyActorApi.md#appbskyactorsearchactorstypeahead) | **GET** /app.bsky.actor.searchActorsTypeahead |  |

<a id="appbskyactorgetpreferences"></a>
# **AppBskyActorGetPreferences**
> AppBskyActorGetPreferences200Response AppBskyActorGetPreferences ()



Get private preferences attached to the current account. Expected use is synchronization between multiple devices, and import/export during account migration. Requires auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyActorGetPreferencesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyActorApi(config);

            try
            {
                AppBskyActorGetPreferences200Response result = apiInstance.AppBskyActorGetPreferences();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyActorApi.AppBskyActorGetPreferences: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyActorGetPreferencesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyActorGetPreferences200Response> response = apiInstance.AppBskyActorGetPreferencesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyActorApi.AppBskyActorGetPreferencesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AppBskyActorGetPreferences200Response**](AppBskyActorGetPreferences200Response.md)

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

<a id="appbskyactorgetprofile"></a>
# **AppBskyActorGetProfile**
> AppBskyActorDefsProfileViewDetailed AppBskyActorGetProfile (string actor)



Get detailed profile view of an actor. Does not require auth, but contains relevant metadata with auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyActorGetProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyActorApi(config);
            var actor = "actor_example";  // string | Handle or DID of account to fetch profile of.

            try
            {
                AppBskyActorDefsProfileViewDetailed result = apiInstance.AppBskyActorGetProfile(actor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyActorApi.AppBskyActorGetProfile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyActorGetProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyActorDefsProfileViewDetailed> response = apiInstance.AppBskyActorGetProfileWithHttpInfo(actor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyActorApi.AppBskyActorGetProfileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **actor** | **string** | Handle or DID of account to fetch profile of. |  |

### Return type

[**AppBskyActorDefsProfileViewDetailed**](AppBskyActorDefsProfileViewDetailed.md)

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

<a id="appbskyactorgetprofiles"></a>
# **AppBskyActorGetProfiles**
> AppBskyActorGetProfiles200Response AppBskyActorGetProfiles (List<string> actors)



Get detailed profile views of multiple actors.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyActorGetProfilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyActorApi(config);
            var actors = new List<string>(); // List<string> | 

            try
            {
                AppBskyActorGetProfiles200Response result = apiInstance.AppBskyActorGetProfiles(actors);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyActorApi.AppBskyActorGetProfiles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyActorGetProfilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyActorGetProfiles200Response> response = apiInstance.AppBskyActorGetProfilesWithHttpInfo(actors);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyActorApi.AppBskyActorGetProfilesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **actors** | [**List&lt;string&gt;**](string.md) |  |  |

### Return type

[**AppBskyActorGetProfiles200Response**](AppBskyActorGetProfiles200Response.md)

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

<a id="appbskyactorgetsuggestions"></a>
# **AppBskyActorGetSuggestions**
> AppBskyActorGetSuggestions200Response AppBskyActorGetSuggestions (int? limit = null, string? cursor = null)



Get a list of suggested actors. Expected use is discovery of accounts to follow during new account onboarding.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyActorGetSuggestionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyActorApi(config);
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                AppBskyActorGetSuggestions200Response result = apiInstance.AppBskyActorGetSuggestions(limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyActorApi.AppBskyActorGetSuggestions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyActorGetSuggestionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyActorGetSuggestions200Response> response = apiInstance.AppBskyActorGetSuggestionsWithHttpInfo(limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyActorApi.AppBskyActorGetSuggestionsWithHttpInfo: " + e.Message);
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

[**AppBskyActorGetSuggestions200Response**](AppBskyActorGetSuggestions200Response.md)

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

<a id="appbskyactorputpreferences"></a>
# **AppBskyActorPutPreferences**
> void AppBskyActorPutPreferences (AppBskyActorGetPreferences200Response appBskyActorGetPreferences200Response)



Set the private preferences attached to the account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyActorPutPreferencesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyActorApi(config);
            var appBskyActorGetPreferences200Response = new AppBskyActorGetPreferences200Response(); // AppBskyActorGetPreferences200Response | 

            try
            {
                apiInstance.AppBskyActorPutPreferences(appBskyActorGetPreferences200Response);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyActorApi.AppBskyActorPutPreferences: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyActorPutPreferencesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppBskyActorPutPreferencesWithHttpInfo(appBskyActorGetPreferences200Response);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyActorApi.AppBskyActorPutPreferencesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appBskyActorGetPreferences200Response** | [**AppBskyActorGetPreferences200Response**](AppBskyActorGetPreferences200Response.md) |  |  |

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

<a id="appbskyactorsearchactors"></a>
# **AppBskyActorSearchActors**
> AppBskyActorGetSuggestions200Response AppBskyActorSearchActors (string? q = null, int? limit = null, string? cursor = null)



Find actors (profiles) matching search criteria. Does not require auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyActorSearchActorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyActorApi(config);
            var q = "q_example";  // string? | Search query string. Syntax, phrase, boolean, and faceting is unspecified, but Lucene query syntax is recommended. (optional) 
            var limit = 25;  // int? |  (optional)  (default to 25)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                AppBskyActorGetSuggestions200Response result = apiInstance.AppBskyActorSearchActors(q, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyActorApi.AppBskyActorSearchActors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyActorSearchActorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyActorGetSuggestions200Response> response = apiInstance.AppBskyActorSearchActorsWithHttpInfo(q, limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyActorApi.AppBskyActorSearchActorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **q** | **string?** | Search query string. Syntax, phrase, boolean, and faceting is unspecified, but Lucene query syntax is recommended. | [optional]  |
| **limit** | **int?** |  | [optional] [default to 25] |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**AppBskyActorGetSuggestions200Response**](AppBskyActorGetSuggestions200Response.md)

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

<a id="appbskyactorsearchactorstypeahead"></a>
# **AppBskyActorSearchActorsTypeahead**
> AppBskyActorSearchActorsTypeahead200Response AppBskyActorSearchActorsTypeahead (string? q = null, int? limit = null)



Find actor suggestions for a prefix search term. Expected use is for auto-completion during text field entry. Does not require auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class AppBskyActorSearchActorsTypeaheadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppBskyActorApi(config);
            var q = "q_example";  // string? | Search query prefix; not a full query string. (optional) 
            var limit = 10;  // int? |  (optional)  (default to 10)

            try
            {
                AppBskyActorSearchActorsTypeahead200Response result = apiInstance.AppBskyActorSearchActorsTypeahead(q, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppBskyActorApi.AppBskyActorSearchActorsTypeahead: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppBskyActorSearchActorsTypeaheadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppBskyActorSearchActorsTypeahead200Response> response = apiInstance.AppBskyActorSearchActorsTypeaheadWithHttpInfo(q, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppBskyActorApi.AppBskyActorSearchActorsTypeaheadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **q** | **string?** | Search query prefix; not a full query string. | [optional]  |
| **limit** | **int?** |  | [optional] [default to 10] |

### Return type

[**AppBskyActorSearchActorsTypeahead200Response**](AppBskyActorSearchActorsTypeahead200Response.md)

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

