# BSky.Api.ComAtprotoAdminApi

All URIs are relative to *https://public.api.bsky.app/xrpc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ComAtprotoAdminDeleteAccount**](ComAtprotoAdminApi.md#comatprotoadmindeleteaccount) | **POST** /com.atproto.admin.deleteAccount |  |
| [**ComAtprotoAdminDisableAccountInvites**](ComAtprotoAdminApi.md#comatprotoadmindisableaccountinvites) | **POST** /com.atproto.admin.disableAccountInvites |  |
| [**ComAtprotoAdminDisableInviteCodes**](ComAtprotoAdminApi.md#comatprotoadmindisableinvitecodes) | **POST** /com.atproto.admin.disableInviteCodes |  |
| [**ComAtprotoAdminEnableAccountInvites**](ComAtprotoAdminApi.md#comatprotoadminenableaccountinvites) | **POST** /com.atproto.admin.enableAccountInvites |  |
| [**ComAtprotoAdminGetAccountInfo**](ComAtprotoAdminApi.md#comatprotoadmingetaccountinfo) | **GET** /com.atproto.admin.getAccountInfo |  |
| [**ComAtprotoAdminGetAccountInfos**](ComAtprotoAdminApi.md#comatprotoadmingetaccountinfos) | **GET** /com.atproto.admin.getAccountInfos |  |
| [**ComAtprotoAdminGetInviteCodes**](ComAtprotoAdminApi.md#comatprotoadmingetinvitecodes) | **GET** /com.atproto.admin.getInviteCodes |  |
| [**ComAtprotoAdminGetSubjectStatus**](ComAtprotoAdminApi.md#comatprotoadmingetsubjectstatus) | **GET** /com.atproto.admin.getSubjectStatus |  |
| [**ComAtprotoAdminSearchAccounts**](ComAtprotoAdminApi.md#comatprotoadminsearchaccounts) | **GET** /com.atproto.admin.searchAccounts |  |
| [**ComAtprotoAdminSendEmail**](ComAtprotoAdminApi.md#comatprotoadminsendemail) | **POST** /com.atproto.admin.sendEmail |  |
| [**ComAtprotoAdminUpdateAccountEmail**](ComAtprotoAdminApi.md#comatprotoadminupdateaccountemail) | **POST** /com.atproto.admin.updateAccountEmail |  |
| [**ComAtprotoAdminUpdateAccountHandle**](ComAtprotoAdminApi.md#comatprotoadminupdateaccounthandle) | **POST** /com.atproto.admin.updateAccountHandle |  |
| [**ComAtprotoAdminUpdateAccountPassword**](ComAtprotoAdminApi.md#comatprotoadminupdateaccountpassword) | **POST** /com.atproto.admin.updateAccountPassword |  |
| [**ComAtprotoAdminUpdateSubjectStatus**](ComAtprotoAdminApi.md#comatprotoadminupdatesubjectstatus) | **POST** /com.atproto.admin.updateSubjectStatus |  |

<a id="comatprotoadmindeleteaccount"></a>
# **ComAtprotoAdminDeleteAccount**
> void ComAtprotoAdminDeleteAccount (ComAtprotoAdminDeleteAccountRequest comAtprotoAdminDeleteAccountRequest)



Delete a user account as an administrator.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoAdminDeleteAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var comAtprotoAdminDeleteAccountRequest = new ComAtprotoAdminDeleteAccountRequest(); // ComAtprotoAdminDeleteAccountRequest | 

            try
            {
                apiInstance.ComAtprotoAdminDeleteAccount(comAtprotoAdminDeleteAccountRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminDeleteAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminDeleteAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoAdminDeleteAccountWithHttpInfo(comAtprotoAdminDeleteAccountRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminDeleteAccountWithHttpInfo: " + e.Message);
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

<a id="comatprotoadmindisableaccountinvites"></a>
# **ComAtprotoAdminDisableAccountInvites**
> void ComAtprotoAdminDisableAccountInvites (ComAtprotoAdminDisableAccountInvitesRequest comAtprotoAdminDisableAccountInvitesRequest)



Disable an account from receiving new invite codes, but does not invalidate existing codes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoAdminDisableAccountInvitesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var comAtprotoAdminDisableAccountInvitesRequest = new ComAtprotoAdminDisableAccountInvitesRequest(); // ComAtprotoAdminDisableAccountInvitesRequest | 

            try
            {
                apiInstance.ComAtprotoAdminDisableAccountInvites(comAtprotoAdminDisableAccountInvitesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminDisableAccountInvites: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminDisableAccountInvitesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoAdminDisableAccountInvitesWithHttpInfo(comAtprotoAdminDisableAccountInvitesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminDisableAccountInvitesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoAdminDisableAccountInvitesRequest** | [**ComAtprotoAdminDisableAccountInvitesRequest**](ComAtprotoAdminDisableAccountInvitesRequest.md) |  |  |

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

<a id="comatprotoadmindisableinvitecodes"></a>
# **ComAtprotoAdminDisableInviteCodes**
> void ComAtprotoAdminDisableInviteCodes (ComAtprotoAdminDisableInviteCodesRequest comAtprotoAdminDisableInviteCodesRequest)



Disable some set of codes and/or all codes associated with a set of users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoAdminDisableInviteCodesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var comAtprotoAdminDisableInviteCodesRequest = new ComAtprotoAdminDisableInviteCodesRequest(); // ComAtprotoAdminDisableInviteCodesRequest | 

            try
            {
                apiInstance.ComAtprotoAdminDisableInviteCodes(comAtprotoAdminDisableInviteCodesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminDisableInviteCodes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminDisableInviteCodesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoAdminDisableInviteCodesWithHttpInfo(comAtprotoAdminDisableInviteCodesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminDisableInviteCodesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoAdminDisableInviteCodesRequest** | [**ComAtprotoAdminDisableInviteCodesRequest**](ComAtprotoAdminDisableInviteCodesRequest.md) |  |  |

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

<a id="comatprotoadminenableaccountinvites"></a>
# **ComAtprotoAdminEnableAccountInvites**
> void ComAtprotoAdminEnableAccountInvites (ComAtprotoAdminEnableAccountInvitesRequest comAtprotoAdminEnableAccountInvitesRequest)



Re-enable an account's ability to receive invite codes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoAdminEnableAccountInvitesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var comAtprotoAdminEnableAccountInvitesRequest = new ComAtprotoAdminEnableAccountInvitesRequest(); // ComAtprotoAdminEnableAccountInvitesRequest | 

            try
            {
                apiInstance.ComAtprotoAdminEnableAccountInvites(comAtprotoAdminEnableAccountInvitesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminEnableAccountInvites: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminEnableAccountInvitesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoAdminEnableAccountInvitesWithHttpInfo(comAtprotoAdminEnableAccountInvitesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminEnableAccountInvitesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoAdminEnableAccountInvitesRequest** | [**ComAtprotoAdminEnableAccountInvitesRequest**](ComAtprotoAdminEnableAccountInvitesRequest.md) |  |  |

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

<a id="comatprotoadmingetaccountinfo"></a>
# **ComAtprotoAdminGetAccountInfo**
> ComAtprotoAdminDefsAccountView ComAtprotoAdminGetAccountInfo (string did)



Get details about an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoAdminGetAccountInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var did = "did_example";  // string | 

            try
            {
                ComAtprotoAdminDefsAccountView result = apiInstance.ComAtprotoAdminGetAccountInfo(did);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminGetAccountInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminGetAccountInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoAdminDefsAccountView> response = apiInstance.ComAtprotoAdminGetAccountInfoWithHttpInfo(did);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminGetAccountInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **did** | **string** |  |  |

### Return type

[**ComAtprotoAdminDefsAccountView**](ComAtprotoAdminDefsAccountView.md)

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

<a id="comatprotoadmingetaccountinfos"></a>
# **ComAtprotoAdminGetAccountInfos**
> ComAtprotoAdminGetAccountInfos200Response ComAtprotoAdminGetAccountInfos (List<string> dids)



Get details about some accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoAdminGetAccountInfosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var dids = new List<string>(); // List<string> | 

            try
            {
                ComAtprotoAdminGetAccountInfos200Response result = apiInstance.ComAtprotoAdminGetAccountInfos(dids);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminGetAccountInfos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminGetAccountInfosWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoAdminGetAccountInfos200Response> response = apiInstance.ComAtprotoAdminGetAccountInfosWithHttpInfo(dids);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminGetAccountInfosWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dids** | [**List&lt;string&gt;**](string.md) |  |  |

### Return type

[**ComAtprotoAdminGetAccountInfos200Response**](ComAtprotoAdminGetAccountInfos200Response.md)

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

<a id="comatprotoadmingetinvitecodes"></a>
# **ComAtprotoAdminGetInviteCodes**
> ComAtprotoAdminGetInviteCodes200Response ComAtprotoAdminGetInviteCodes (string? sort = null, int? limit = null, string? cursor = null)



Get an admin view of invite codes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoAdminGetInviteCodesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var sort = "recent";  // string? |  (optional)  (default to recent)
            var limit = 100;  // int? |  (optional)  (default to 100)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                ComAtprotoAdminGetInviteCodes200Response result = apiInstance.ComAtprotoAdminGetInviteCodes(sort, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminGetInviteCodes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminGetInviteCodesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoAdminGetInviteCodes200Response> response = apiInstance.ComAtprotoAdminGetInviteCodesWithHttpInfo(sort, limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminGetInviteCodesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sort** | **string?** |  | [optional] [default to recent] |
| **limit** | **int?** |  | [optional] [default to 100] |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**ComAtprotoAdminGetInviteCodes200Response**](ComAtprotoAdminGetInviteCodes200Response.md)

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

<a id="comatprotoadmingetsubjectstatus"></a>
# **ComAtprotoAdminGetSubjectStatus**
> ComAtprotoAdminGetSubjectStatus200Response ComAtprotoAdminGetSubjectStatus (string? did = null, string? uri = null, string? blob = null)



Get the service-specific admin status of a subject (account, record, or blob).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoAdminGetSubjectStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var did = "did_example";  // string? |  (optional) 
            var uri = "uri_example";  // string? |  (optional) 
            var blob = "blob_example";  // string? |  (optional) 

            try
            {
                ComAtprotoAdminGetSubjectStatus200Response result = apiInstance.ComAtprotoAdminGetSubjectStatus(did, uri, blob);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminGetSubjectStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminGetSubjectStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoAdminGetSubjectStatus200Response> response = apiInstance.ComAtprotoAdminGetSubjectStatusWithHttpInfo(did, uri, blob);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminGetSubjectStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **did** | **string?** |  | [optional]  |
| **uri** | **string?** |  | [optional]  |
| **blob** | **string?** |  | [optional]  |

### Return type

[**ComAtprotoAdminGetSubjectStatus200Response**](ComAtprotoAdminGetSubjectStatus200Response.md)

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

<a id="comatprotoadminsearchaccounts"></a>
# **ComAtprotoAdminSearchAccounts**
> ComAtprotoAdminSearchAccounts200Response ComAtprotoAdminSearchAccounts (string? email = null, string? cursor = null, int? limit = null)



Get list of accounts that matches your search query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoAdminSearchAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var email = "email_example";  // string? |  (optional) 
            var cursor = "cursor_example";  // string? |  (optional) 
            var limit = 50;  // int? |  (optional)  (default to 50)

            try
            {
                ComAtprotoAdminSearchAccounts200Response result = apiInstance.ComAtprotoAdminSearchAccounts(email, cursor, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminSearchAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminSearchAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoAdminSearchAccounts200Response> response = apiInstance.ComAtprotoAdminSearchAccountsWithHttpInfo(email, cursor, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminSearchAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string?** |  | [optional]  |
| **cursor** | **string?** |  | [optional]  |
| **limit** | **int?** |  | [optional] [default to 50] |

### Return type

[**ComAtprotoAdminSearchAccounts200Response**](ComAtprotoAdminSearchAccounts200Response.md)

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

<a id="comatprotoadminsendemail"></a>
# **ComAtprotoAdminSendEmail**
> ComAtprotoAdminSendEmail200Response ComAtprotoAdminSendEmail (ComAtprotoAdminSendEmailRequest comAtprotoAdminSendEmailRequest)



Send email to a user's account email address.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoAdminSendEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var comAtprotoAdminSendEmailRequest = new ComAtprotoAdminSendEmailRequest(); // ComAtprotoAdminSendEmailRequest | 

            try
            {
                ComAtprotoAdminSendEmail200Response result = apiInstance.ComAtprotoAdminSendEmail(comAtprotoAdminSendEmailRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminSendEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminSendEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoAdminSendEmail200Response> response = apiInstance.ComAtprotoAdminSendEmailWithHttpInfo(comAtprotoAdminSendEmailRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminSendEmailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoAdminSendEmailRequest** | [**ComAtprotoAdminSendEmailRequest**](ComAtprotoAdminSendEmailRequest.md) |  |  |

### Return type

[**ComAtprotoAdminSendEmail200Response**](ComAtprotoAdminSendEmail200Response.md)

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

<a id="comatprotoadminupdateaccountemail"></a>
# **ComAtprotoAdminUpdateAccountEmail**
> void ComAtprotoAdminUpdateAccountEmail (ComAtprotoAdminUpdateAccountEmailRequest comAtprotoAdminUpdateAccountEmailRequest)



Administrative action to update an account's email.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoAdminUpdateAccountEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var comAtprotoAdminUpdateAccountEmailRequest = new ComAtprotoAdminUpdateAccountEmailRequest(); // ComAtprotoAdminUpdateAccountEmailRequest | 

            try
            {
                apiInstance.ComAtprotoAdminUpdateAccountEmail(comAtprotoAdminUpdateAccountEmailRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminUpdateAccountEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminUpdateAccountEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoAdminUpdateAccountEmailWithHttpInfo(comAtprotoAdminUpdateAccountEmailRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminUpdateAccountEmailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoAdminUpdateAccountEmailRequest** | [**ComAtprotoAdminUpdateAccountEmailRequest**](ComAtprotoAdminUpdateAccountEmailRequest.md) |  |  |

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

<a id="comatprotoadminupdateaccounthandle"></a>
# **ComAtprotoAdminUpdateAccountHandle**
> void ComAtprotoAdminUpdateAccountHandle (ComAtprotoAdminUpdateAccountHandleRequest comAtprotoAdminUpdateAccountHandleRequest)



Administrative action to update an account's handle.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoAdminUpdateAccountHandleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var comAtprotoAdminUpdateAccountHandleRequest = new ComAtprotoAdminUpdateAccountHandleRequest(); // ComAtprotoAdminUpdateAccountHandleRequest | 

            try
            {
                apiInstance.ComAtprotoAdminUpdateAccountHandle(comAtprotoAdminUpdateAccountHandleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminUpdateAccountHandle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminUpdateAccountHandleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoAdminUpdateAccountHandleWithHttpInfo(comAtprotoAdminUpdateAccountHandleRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminUpdateAccountHandleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoAdminUpdateAccountHandleRequest** | [**ComAtprotoAdminUpdateAccountHandleRequest**](ComAtprotoAdminUpdateAccountHandleRequest.md) |  |  |

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

<a id="comatprotoadminupdateaccountpassword"></a>
# **ComAtprotoAdminUpdateAccountPassword**
> void ComAtprotoAdminUpdateAccountPassword (ComAtprotoAdminUpdateAccountPasswordRequest comAtprotoAdminUpdateAccountPasswordRequest)



Update the password for a user account as an administrator.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoAdminUpdateAccountPasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var comAtprotoAdminUpdateAccountPasswordRequest = new ComAtprotoAdminUpdateAccountPasswordRequest(); // ComAtprotoAdminUpdateAccountPasswordRequest | 

            try
            {
                apiInstance.ComAtprotoAdminUpdateAccountPassword(comAtprotoAdminUpdateAccountPasswordRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminUpdateAccountPassword: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminUpdateAccountPasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoAdminUpdateAccountPasswordWithHttpInfo(comAtprotoAdminUpdateAccountPasswordRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminUpdateAccountPasswordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoAdminUpdateAccountPasswordRequest** | [**ComAtprotoAdminUpdateAccountPasswordRequest**](ComAtprotoAdminUpdateAccountPasswordRequest.md) |  |  |

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

<a id="comatprotoadminupdatesubjectstatus"></a>
# **ComAtprotoAdminUpdateSubjectStatus**
> ComAtprotoAdminUpdateSubjectStatus200Response ComAtprotoAdminUpdateSubjectStatus (ComAtprotoAdminGetSubjectStatus200Response comAtprotoAdminGetSubjectStatus200Response)



Update the service-specific admin status of a subject (account, record, or blob).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoAdminUpdateSubjectStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoAdminApi(config);
            var comAtprotoAdminGetSubjectStatus200Response = new ComAtprotoAdminGetSubjectStatus200Response(); // ComAtprotoAdminGetSubjectStatus200Response | 

            try
            {
                ComAtprotoAdminUpdateSubjectStatus200Response result = apiInstance.ComAtprotoAdminUpdateSubjectStatus(comAtprotoAdminGetSubjectStatus200Response);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminUpdateSubjectStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoAdminUpdateSubjectStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoAdminUpdateSubjectStatus200Response> response = apiInstance.ComAtprotoAdminUpdateSubjectStatusWithHttpInfo(comAtprotoAdminGetSubjectStatus200Response);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoAdminApi.ComAtprotoAdminUpdateSubjectStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoAdminGetSubjectStatus200Response** | [**ComAtprotoAdminGetSubjectStatus200Response**](ComAtprotoAdminGetSubjectStatus200Response.md) |  |  |

### Return type

[**ComAtprotoAdminUpdateSubjectStatus200Response**](ComAtprotoAdminUpdateSubjectStatus200Response.md)

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

