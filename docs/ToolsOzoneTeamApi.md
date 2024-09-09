# BSky.Api.ToolsOzoneTeamApi

All URIs are relative to *https://public.api.bsky.app/xrpc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ToolsOzoneTeamAddMember**](ToolsOzoneTeamApi.md#toolsozoneteamaddmember) | **POST** /tools.ozone.team.addMember |  |
| [**ToolsOzoneTeamDeleteMember**](ToolsOzoneTeamApi.md#toolsozoneteamdeletemember) | **POST** /tools.ozone.team.deleteMember |  |
| [**ToolsOzoneTeamListMembers**](ToolsOzoneTeamApi.md#toolsozoneteamlistmembers) | **GET** /tools.ozone.team.listMembers |  |
| [**ToolsOzoneTeamUpdateMember**](ToolsOzoneTeamApi.md#toolsozoneteamupdatemember) | **POST** /tools.ozone.team.updateMember |  |

<a id="toolsozoneteamaddmember"></a>
# **ToolsOzoneTeamAddMember**
> ToolsOzoneTeamDefsMember ToolsOzoneTeamAddMember (ToolsOzoneTeamAddMemberRequest toolsOzoneTeamAddMemberRequest)



Add a member to the ozone team. Requires admin role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ToolsOzoneTeamAddMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolsOzoneTeamApi(config);
            var toolsOzoneTeamAddMemberRequest = new ToolsOzoneTeamAddMemberRequest(); // ToolsOzoneTeamAddMemberRequest | 

            try
            {
                ToolsOzoneTeamDefsMember result = apiInstance.ToolsOzoneTeamAddMember(toolsOzoneTeamAddMemberRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsOzoneTeamApi.ToolsOzoneTeamAddMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ToolsOzoneTeamAddMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ToolsOzoneTeamDefsMember> response = apiInstance.ToolsOzoneTeamAddMemberWithHttpInfo(toolsOzoneTeamAddMemberRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsOzoneTeamApi.ToolsOzoneTeamAddMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **toolsOzoneTeamAddMemberRequest** | [**ToolsOzoneTeamAddMemberRequest**](ToolsOzoneTeamAddMemberRequest.md) |  |  |

### Return type

[**ToolsOzoneTeamDefsMember**](ToolsOzoneTeamDefsMember.md)

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

<a id="toolsozoneteamdeletemember"></a>
# **ToolsOzoneTeamDeleteMember**
> void ToolsOzoneTeamDeleteMember (ComAtprotoAdminDeleteAccountRequest comAtprotoAdminDeleteAccountRequest)



Delete a member from ozone team. Requires admin role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ToolsOzoneTeamDeleteMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolsOzoneTeamApi(config);
            var comAtprotoAdminDeleteAccountRequest = new ComAtprotoAdminDeleteAccountRequest(); // ComAtprotoAdminDeleteAccountRequest | 

            try
            {
                apiInstance.ToolsOzoneTeamDeleteMember(comAtprotoAdminDeleteAccountRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsOzoneTeamApi.ToolsOzoneTeamDeleteMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ToolsOzoneTeamDeleteMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ToolsOzoneTeamDeleteMemberWithHttpInfo(comAtprotoAdminDeleteAccountRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsOzoneTeamApi.ToolsOzoneTeamDeleteMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoAdminDeleteAccountRequest** | [**ComAtprotoAdminDeleteAccountRequest**](ComAtprotoAdminDeleteAccountRequest.md) |  |  |

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

<a id="toolsozoneteamlistmembers"></a>
# **ToolsOzoneTeamListMembers**
> ToolsOzoneTeamListMembers200Response ToolsOzoneTeamListMembers (int? limit = null, string? cursor = null)



List all members with access to the ozone service.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ToolsOzoneTeamListMembersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolsOzoneTeamApi(config);
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                ToolsOzoneTeamListMembers200Response result = apiInstance.ToolsOzoneTeamListMembers(limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsOzoneTeamApi.ToolsOzoneTeamListMembers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ToolsOzoneTeamListMembersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ToolsOzoneTeamListMembers200Response> response = apiInstance.ToolsOzoneTeamListMembersWithHttpInfo(limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsOzoneTeamApi.ToolsOzoneTeamListMembersWithHttpInfo: " + e.Message);
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

[**ToolsOzoneTeamListMembers200Response**](ToolsOzoneTeamListMembers200Response.md)

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

<a id="toolsozoneteamupdatemember"></a>
# **ToolsOzoneTeamUpdateMember**
> ToolsOzoneTeamDefsMember ToolsOzoneTeamUpdateMember (ToolsOzoneTeamUpdateMemberRequest toolsOzoneTeamUpdateMemberRequest)



Update a member in the ozone service. Requires admin role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ToolsOzoneTeamUpdateMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolsOzoneTeamApi(config);
            var toolsOzoneTeamUpdateMemberRequest = new ToolsOzoneTeamUpdateMemberRequest(); // ToolsOzoneTeamUpdateMemberRequest | 

            try
            {
                ToolsOzoneTeamDefsMember result = apiInstance.ToolsOzoneTeamUpdateMember(toolsOzoneTeamUpdateMemberRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsOzoneTeamApi.ToolsOzoneTeamUpdateMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ToolsOzoneTeamUpdateMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ToolsOzoneTeamDefsMember> response = apiInstance.ToolsOzoneTeamUpdateMemberWithHttpInfo(toolsOzoneTeamUpdateMemberRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsOzoneTeamApi.ToolsOzoneTeamUpdateMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **toolsOzoneTeamUpdateMemberRequest** | [**ToolsOzoneTeamUpdateMemberRequest**](ToolsOzoneTeamUpdateMemberRequest.md) |  |  |

### Return type

[**ToolsOzoneTeamDefsMember**](ToolsOzoneTeamDefsMember.md)

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

