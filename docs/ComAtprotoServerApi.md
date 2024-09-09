# BSky.Api.ComAtprotoServerApi

All URIs are relative to *https://public.api.bsky.app/xrpc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ComAtprotoServerActivateAccount**](ComAtprotoServerApi.md#comatprotoserveractivateaccount) | **POST** /com.atproto.server.activateAccount |  |
| [**ComAtprotoServerCheckAccountStatus**](ComAtprotoServerApi.md#comatprotoservercheckaccountstatus) | **GET** /com.atproto.server.checkAccountStatus |  |
| [**ComAtprotoServerConfirmEmail**](ComAtprotoServerApi.md#comatprotoserverconfirmemail) | **POST** /com.atproto.server.confirmEmail |  |
| [**ComAtprotoServerCreateAccount**](ComAtprotoServerApi.md#comatprotoservercreateaccount) | **POST** /com.atproto.server.createAccount |  |
| [**ComAtprotoServerCreateAppPassword**](ComAtprotoServerApi.md#comatprotoservercreateapppassword) | **POST** /com.atproto.server.createAppPassword |  |
| [**ComAtprotoServerCreateInviteCode**](ComAtprotoServerApi.md#comatprotoservercreateinvitecode) | **POST** /com.atproto.server.createInviteCode |  |
| [**ComAtprotoServerCreateInviteCodes**](ComAtprotoServerApi.md#comatprotoservercreateinvitecodes) | **POST** /com.atproto.server.createInviteCodes |  |
| [**ComAtprotoServerCreateSession**](ComAtprotoServerApi.md#comatprotoservercreatesession) | **POST** /com.atproto.server.createSession |  |
| [**ComAtprotoServerDeactivateAccount**](ComAtprotoServerApi.md#comatprotoserverdeactivateaccount) | **POST** /com.atproto.server.deactivateAccount |  |
| [**ComAtprotoServerDeleteAccount**](ComAtprotoServerApi.md#comatprotoserverdeleteaccount) | **POST** /com.atproto.server.deleteAccount |  |
| [**ComAtprotoServerDeleteSession**](ComAtprotoServerApi.md#comatprotoserverdeletesession) | **POST** /com.atproto.server.deleteSession |  |
| [**ComAtprotoServerDescribeServer**](ComAtprotoServerApi.md#comatprotoserverdescribeserver) | **GET** /com.atproto.server.describeServer |  |
| [**ComAtprotoServerGetAccountInviteCodes**](ComAtprotoServerApi.md#comatprotoservergetaccountinvitecodes) | **GET** /com.atproto.server.getAccountInviteCodes |  |
| [**ComAtprotoServerGetServiceAuth**](ComAtprotoServerApi.md#comatprotoservergetserviceauth) | **GET** /com.atproto.server.getServiceAuth |  |
| [**ComAtprotoServerGetSession**](ComAtprotoServerApi.md#comatprotoservergetsession) | **GET** /com.atproto.server.getSession |  |
| [**ComAtprotoServerListAppPasswords**](ComAtprotoServerApi.md#comatprotoserverlistapppasswords) | **GET** /com.atproto.server.listAppPasswords |  |
| [**ComAtprotoServerRefreshSession**](ComAtprotoServerApi.md#comatprotoserverrefreshsession) | **POST** /com.atproto.server.refreshSession |  |
| [**ComAtprotoServerRequestAccountDelete**](ComAtprotoServerApi.md#comatprotoserverrequestaccountdelete) | **POST** /com.atproto.server.requestAccountDelete |  |
| [**ComAtprotoServerRequestEmailConfirmation**](ComAtprotoServerApi.md#comatprotoserverrequestemailconfirmation) | **POST** /com.atproto.server.requestEmailConfirmation |  |
| [**ComAtprotoServerRequestEmailUpdate**](ComAtprotoServerApi.md#comatprotoserverrequestemailupdate) | **POST** /com.atproto.server.requestEmailUpdate |  |
| [**ComAtprotoServerRequestPasswordReset**](ComAtprotoServerApi.md#comatprotoserverrequestpasswordreset) | **POST** /com.atproto.server.requestPasswordReset |  |
| [**ComAtprotoServerReserveSigningKey**](ComAtprotoServerApi.md#comatprotoserverreservesigningkey) | **POST** /com.atproto.server.reserveSigningKey |  |
| [**ComAtprotoServerResetPassword**](ComAtprotoServerApi.md#comatprotoserverresetpassword) | **POST** /com.atproto.server.resetPassword |  |
| [**ComAtprotoServerRevokeAppPassword**](ComAtprotoServerApi.md#comatprotoserverrevokeapppassword) | **POST** /com.atproto.server.revokeAppPassword |  |
| [**ComAtprotoServerUpdateEmail**](ComAtprotoServerApi.md#comatprotoserverupdateemail) | **POST** /com.atproto.server.updateEmail |  |

<a id="comatprotoserveractivateaccount"></a>
# **ComAtprotoServerActivateAccount**
> void ComAtprotoServerActivateAccount ()



Activates a currently deactivated account. Used to finalize account migration after the account's repo is imported and identity is setup.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerActivateAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoServerApi(config);

            try
            {
                apiInstance.ComAtprotoServerActivateAccount();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerActivateAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerActivateAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoServerActivateAccountWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerActivateAccountWithHttpInfo: " + e.Message);
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
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotoservercheckaccountstatus"></a>
# **ComAtprotoServerCheckAccountStatus**
> ComAtprotoServerCheckAccountStatus200Response ComAtprotoServerCheckAccountStatus ()



Returns the status of an account, especially as pertaining to import or recovery. Can be called many times over the course of an account migration. Requires auth and can only be called pertaining to oneself.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerCheckAccountStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoServerApi(config);

            try
            {
                ComAtprotoServerCheckAccountStatus200Response result = apiInstance.ComAtprotoServerCheckAccountStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerCheckAccountStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerCheckAccountStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoServerCheckAccountStatus200Response> response = apiInstance.ComAtprotoServerCheckAccountStatusWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerCheckAccountStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ComAtprotoServerCheckAccountStatus200Response**](ComAtprotoServerCheckAccountStatus200Response.md)

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

<a id="comatprotoserverconfirmemail"></a>
# **ComAtprotoServerConfirmEmail**
> void ComAtprotoServerConfirmEmail (ComAtprotoServerConfirmEmailRequest comAtprotoServerConfirmEmailRequest)



Confirm an email using a token from com.atproto.server.requestEmailConfirmation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerConfirmEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoServerApi(config);
            var comAtprotoServerConfirmEmailRequest = new ComAtprotoServerConfirmEmailRequest(); // ComAtprotoServerConfirmEmailRequest | 

            try
            {
                apiInstance.ComAtprotoServerConfirmEmail(comAtprotoServerConfirmEmailRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerConfirmEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerConfirmEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoServerConfirmEmailWithHttpInfo(comAtprotoServerConfirmEmailRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerConfirmEmailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoServerConfirmEmailRequest** | [**ComAtprotoServerConfirmEmailRequest**](ComAtprotoServerConfirmEmailRequest.md) |  |  |

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

<a id="comatprotoservercreateaccount"></a>
# **ComAtprotoServerCreateAccount**
> ComAtprotoServerCreateAccount200Response ComAtprotoServerCreateAccount (ComAtprotoServerCreateAccountRequest comAtprotoServerCreateAccountRequest)



Create an account. Implemented by PDS.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerCreateAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            var apiInstance = new ComAtprotoServerApi(config);
            var comAtprotoServerCreateAccountRequest = new ComAtprotoServerCreateAccountRequest(); // ComAtprotoServerCreateAccountRequest | 

            try
            {
                ComAtprotoServerCreateAccount200Response result = apiInstance.ComAtprotoServerCreateAccount(comAtprotoServerCreateAccountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerCreateAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerCreateAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoServerCreateAccount200Response> response = apiInstance.ComAtprotoServerCreateAccountWithHttpInfo(comAtprotoServerCreateAccountRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerCreateAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoServerCreateAccountRequest** | [**ComAtprotoServerCreateAccountRequest**](ComAtprotoServerCreateAccountRequest.md) |  |  |

### Return type

[**ComAtprotoServerCreateAccount200Response**](ComAtprotoServerCreateAccount200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotoservercreateapppassword"></a>
# **ComAtprotoServerCreateAppPassword**
> ComAtprotoServerCreateAppPasswordAppPassword ComAtprotoServerCreateAppPassword (ComAtprotoServerCreateAppPasswordRequest comAtprotoServerCreateAppPasswordRequest)



Create an App Password.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerCreateAppPasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoServerApi(config);
            var comAtprotoServerCreateAppPasswordRequest = new ComAtprotoServerCreateAppPasswordRequest(); // ComAtprotoServerCreateAppPasswordRequest | 

            try
            {
                ComAtprotoServerCreateAppPasswordAppPassword result = apiInstance.ComAtprotoServerCreateAppPassword(comAtprotoServerCreateAppPasswordRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerCreateAppPassword: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerCreateAppPasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoServerCreateAppPasswordAppPassword> response = apiInstance.ComAtprotoServerCreateAppPasswordWithHttpInfo(comAtprotoServerCreateAppPasswordRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerCreateAppPasswordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoServerCreateAppPasswordRequest** | [**ComAtprotoServerCreateAppPasswordRequest**](ComAtprotoServerCreateAppPasswordRequest.md) |  |  |

### Return type

[**ComAtprotoServerCreateAppPasswordAppPassword**](ComAtprotoServerCreateAppPasswordAppPassword.md)

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

<a id="comatprotoservercreateinvitecode"></a>
# **ComAtprotoServerCreateInviteCode**
> ComAtprotoServerCreateInviteCode200Response ComAtprotoServerCreateInviteCode (ComAtprotoServerCreateInviteCodeRequest comAtprotoServerCreateInviteCodeRequest)



Create an invite code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerCreateInviteCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoServerApi(config);
            var comAtprotoServerCreateInviteCodeRequest = new ComAtprotoServerCreateInviteCodeRequest(); // ComAtprotoServerCreateInviteCodeRequest | 

            try
            {
                ComAtprotoServerCreateInviteCode200Response result = apiInstance.ComAtprotoServerCreateInviteCode(comAtprotoServerCreateInviteCodeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerCreateInviteCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerCreateInviteCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoServerCreateInviteCode200Response> response = apiInstance.ComAtprotoServerCreateInviteCodeWithHttpInfo(comAtprotoServerCreateInviteCodeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerCreateInviteCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoServerCreateInviteCodeRequest** | [**ComAtprotoServerCreateInviteCodeRequest**](ComAtprotoServerCreateInviteCodeRequest.md) |  |  |

### Return type

[**ComAtprotoServerCreateInviteCode200Response**](ComAtprotoServerCreateInviteCode200Response.md)

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

<a id="comatprotoservercreateinvitecodes"></a>
# **ComAtprotoServerCreateInviteCodes**
> ComAtprotoServerCreateInviteCodes200Response ComAtprotoServerCreateInviteCodes (ComAtprotoServerCreateInviteCodesRequest comAtprotoServerCreateInviteCodesRequest)



Create invite codes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerCreateInviteCodesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoServerApi(config);
            var comAtprotoServerCreateInviteCodesRequest = new ComAtprotoServerCreateInviteCodesRequest(); // ComAtprotoServerCreateInviteCodesRequest | 

            try
            {
                ComAtprotoServerCreateInviteCodes200Response result = apiInstance.ComAtprotoServerCreateInviteCodes(comAtprotoServerCreateInviteCodesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerCreateInviteCodes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerCreateInviteCodesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoServerCreateInviteCodes200Response> response = apiInstance.ComAtprotoServerCreateInviteCodesWithHttpInfo(comAtprotoServerCreateInviteCodesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerCreateInviteCodesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoServerCreateInviteCodesRequest** | [**ComAtprotoServerCreateInviteCodesRequest**](ComAtprotoServerCreateInviteCodesRequest.md) |  |  |

### Return type

[**ComAtprotoServerCreateInviteCodes200Response**](ComAtprotoServerCreateInviteCodes200Response.md)

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

<a id="comatprotoservercreatesession"></a>
# **ComAtprotoServerCreateSession**
> ComAtprotoServerCreateSession200Response ComAtprotoServerCreateSession (ComAtprotoServerCreateSessionRequest comAtprotoServerCreateSessionRequest)



Create an authentication session.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerCreateSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            var apiInstance = new ComAtprotoServerApi(config);
            var comAtprotoServerCreateSessionRequest = new ComAtprotoServerCreateSessionRequest(); // ComAtprotoServerCreateSessionRequest | 

            try
            {
                ComAtprotoServerCreateSession200Response result = apiInstance.ComAtprotoServerCreateSession(comAtprotoServerCreateSessionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerCreateSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerCreateSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoServerCreateSession200Response> response = apiInstance.ComAtprotoServerCreateSessionWithHttpInfo(comAtprotoServerCreateSessionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerCreateSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoServerCreateSessionRequest** | [**ComAtprotoServerCreateSessionRequest**](ComAtprotoServerCreateSessionRequest.md) |  |  |

### Return type

[**ComAtprotoServerCreateSession200Response**](ComAtprotoServerCreateSession200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotoserverdeactivateaccount"></a>
# **ComAtprotoServerDeactivateAccount**
> void ComAtprotoServerDeactivateAccount (ComAtprotoServerDeactivateAccountRequest comAtprotoServerDeactivateAccountRequest)



Deactivates a currently active account. Stops serving of repo, and future writes to repo until reactivated. Used to finalize account migration with the old host after the account has been activated on the new host.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerDeactivateAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoServerApi(config);
            var comAtprotoServerDeactivateAccountRequest = new ComAtprotoServerDeactivateAccountRequest(); // ComAtprotoServerDeactivateAccountRequest | 

            try
            {
                apiInstance.ComAtprotoServerDeactivateAccount(comAtprotoServerDeactivateAccountRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerDeactivateAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerDeactivateAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoServerDeactivateAccountWithHttpInfo(comAtprotoServerDeactivateAccountRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerDeactivateAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoServerDeactivateAccountRequest** | [**ComAtprotoServerDeactivateAccountRequest**](ComAtprotoServerDeactivateAccountRequest.md) |  |  |

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

<a id="comatprotoserverdeleteaccount"></a>
# **ComAtprotoServerDeleteAccount**
> void ComAtprotoServerDeleteAccount (ComAtprotoServerDeleteAccountRequest comAtprotoServerDeleteAccountRequest)



Delete an actor's account with a token and password. Can only be called after requesting a deletion token. Requires auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerDeleteAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            var apiInstance = new ComAtprotoServerApi(config);
            var comAtprotoServerDeleteAccountRequest = new ComAtprotoServerDeleteAccountRequest(); // ComAtprotoServerDeleteAccountRequest | 

            try
            {
                apiInstance.ComAtprotoServerDeleteAccount(comAtprotoServerDeleteAccountRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerDeleteAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerDeleteAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoServerDeleteAccountWithHttpInfo(comAtprotoServerDeleteAccountRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerDeleteAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoServerDeleteAccountRequest** | [**ComAtprotoServerDeleteAccountRequest**](ComAtprotoServerDeleteAccountRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotoserverdeletesession"></a>
# **ComAtprotoServerDeleteSession**
> void ComAtprotoServerDeleteSession ()



Delete the current session. Requires auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerDeleteSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoServerApi(config);

            try
            {
                apiInstance.ComAtprotoServerDeleteSession();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerDeleteSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerDeleteSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoServerDeleteSessionWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerDeleteSessionWithHttpInfo: " + e.Message);
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
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotoserverdescribeserver"></a>
# **ComAtprotoServerDescribeServer**
> ComAtprotoServerDescribeServer200Response ComAtprotoServerDescribeServer ()



Describes the server's account creation requirements and capabilities. Implemented by PDS.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerDescribeServerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            var apiInstance = new ComAtprotoServerApi(config);

            try
            {
                ComAtprotoServerDescribeServer200Response result = apiInstance.ComAtprotoServerDescribeServer();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerDescribeServer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerDescribeServerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoServerDescribeServer200Response> response = apiInstance.ComAtprotoServerDescribeServerWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerDescribeServerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ComAtprotoServerDescribeServer200Response**](ComAtprotoServerDescribeServer200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotoservergetaccountinvitecodes"></a>
# **ComAtprotoServerGetAccountInviteCodes**
> ComAtprotoServerGetAccountInviteCodes200Response ComAtprotoServerGetAccountInviteCodes (bool? includeUsed = null, bool? createAvailable = null)



Get all invite codes for the current account. Requires auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerGetAccountInviteCodesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoServerApi(config);
            var includeUsed = true;  // bool? |  (optional)  (default to true)
            var createAvailable = true;  // bool? | Controls whether any new 'earned' but not 'created' invites should be created. (optional)  (default to true)

            try
            {
                ComAtprotoServerGetAccountInviteCodes200Response result = apiInstance.ComAtprotoServerGetAccountInviteCodes(includeUsed, createAvailable);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerGetAccountInviteCodes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerGetAccountInviteCodesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoServerGetAccountInviteCodes200Response> response = apiInstance.ComAtprotoServerGetAccountInviteCodesWithHttpInfo(includeUsed, createAvailable);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerGetAccountInviteCodesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **includeUsed** | **bool?** |  | [optional] [default to true] |
| **createAvailable** | **bool?** | Controls whether any new &#39;earned&#39; but not &#39;created&#39; invites should be created. | [optional] [default to true] |

### Return type

[**ComAtprotoServerGetAccountInviteCodes200Response**](ComAtprotoServerGetAccountInviteCodes200Response.md)

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

<a id="comatprotoservergetserviceauth"></a>
# **ComAtprotoServerGetServiceAuth**
> ComAtprotoServerGetServiceAuth200Response ComAtprotoServerGetServiceAuth (string aud, int? exp = null, string? lxm = null)



Get a signed token on behalf of the requesting DID for the requested service.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerGetServiceAuthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoServerApi(config);
            var aud = "aud_example";  // string | The DID of the service that the token will be used to authenticate with
            var exp = 56;  // int? | The time in Unix Epoch seconds that the JWT expires. Defaults to 60 seconds in the future. The service may enforce certain time bounds on tokens depending on the requested scope. (optional) 
            var lxm = "lxm_example";  // string? | Lexicon (XRPC) method to bind the requested token to (optional) 

            try
            {
                ComAtprotoServerGetServiceAuth200Response result = apiInstance.ComAtprotoServerGetServiceAuth(aud, exp, lxm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerGetServiceAuth: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerGetServiceAuthWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoServerGetServiceAuth200Response> response = apiInstance.ComAtprotoServerGetServiceAuthWithHttpInfo(aud, exp, lxm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerGetServiceAuthWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aud** | **string** | The DID of the service that the token will be used to authenticate with |  |
| **exp** | **int?** | The time in Unix Epoch seconds that the JWT expires. Defaults to 60 seconds in the future. The service may enforce certain time bounds on tokens depending on the requested scope. | [optional]  |
| **lxm** | **string?** | Lexicon (XRPC) method to bind the requested token to | [optional]  |

### Return type

[**ComAtprotoServerGetServiceAuth200Response**](ComAtprotoServerGetServiceAuth200Response.md)

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

<a id="comatprotoservergetsession"></a>
# **ComAtprotoServerGetSession**
> ComAtprotoServerGetSession200Response ComAtprotoServerGetSession ()



Get information about the current auth session. Requires auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerGetSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoServerApi(config);

            try
            {
                ComAtprotoServerGetSession200Response result = apiInstance.ComAtprotoServerGetSession();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerGetSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerGetSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoServerGetSession200Response> response = apiInstance.ComAtprotoServerGetSessionWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerGetSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ComAtprotoServerGetSession200Response**](ComAtprotoServerGetSession200Response.md)

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

<a id="comatprotoserverlistapppasswords"></a>
# **ComAtprotoServerListAppPasswords**
> ComAtprotoServerListAppPasswords200Response ComAtprotoServerListAppPasswords ()



List all App Passwords.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerListAppPasswordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoServerApi(config);

            try
            {
                ComAtprotoServerListAppPasswords200Response result = apiInstance.ComAtprotoServerListAppPasswords();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerListAppPasswords: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerListAppPasswordsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoServerListAppPasswords200Response> response = apiInstance.ComAtprotoServerListAppPasswordsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerListAppPasswordsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ComAtprotoServerListAppPasswords200Response**](ComAtprotoServerListAppPasswords200Response.md)

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

<a id="comatprotoserverrefreshsession"></a>
# **ComAtprotoServerRefreshSession**
> ComAtprotoServerRefreshSession200Response ComAtprotoServerRefreshSession ()



Refresh an authentication session. Requires auth using the 'refreshJwt' (not the 'accessJwt').

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerRefreshSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoServerApi(config);

            try
            {
                ComAtprotoServerRefreshSession200Response result = apiInstance.ComAtprotoServerRefreshSession();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerRefreshSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerRefreshSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoServerRefreshSession200Response> response = apiInstance.ComAtprotoServerRefreshSessionWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerRefreshSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ComAtprotoServerRefreshSession200Response**](ComAtprotoServerRefreshSession200Response.md)

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

<a id="comatprotoserverrequestaccountdelete"></a>
# **ComAtprotoServerRequestAccountDelete**
> void ComAtprotoServerRequestAccountDelete ()



Initiate a user account deletion via email.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerRequestAccountDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoServerApi(config);

            try
            {
                apiInstance.ComAtprotoServerRequestAccountDelete();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerRequestAccountDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerRequestAccountDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoServerRequestAccountDeleteWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerRequestAccountDeleteWithHttpInfo: " + e.Message);
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
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotoserverrequestemailconfirmation"></a>
# **ComAtprotoServerRequestEmailConfirmation**
> void ComAtprotoServerRequestEmailConfirmation ()



Request an email with a code to confirm ownership of email.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerRequestEmailConfirmationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoServerApi(config);

            try
            {
                apiInstance.ComAtprotoServerRequestEmailConfirmation();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerRequestEmailConfirmation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerRequestEmailConfirmationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoServerRequestEmailConfirmationWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerRequestEmailConfirmationWithHttpInfo: " + e.Message);
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
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotoserverrequestemailupdate"></a>
# **ComAtprotoServerRequestEmailUpdate**
> ComAtprotoServerRequestEmailUpdate200Response ComAtprotoServerRequestEmailUpdate ()



Request a token in order to update email.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerRequestEmailUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoServerApi(config);

            try
            {
                ComAtprotoServerRequestEmailUpdate200Response result = apiInstance.ComAtprotoServerRequestEmailUpdate();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerRequestEmailUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerRequestEmailUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoServerRequestEmailUpdate200Response> response = apiInstance.ComAtprotoServerRequestEmailUpdateWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerRequestEmailUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ComAtprotoServerRequestEmailUpdate200Response**](ComAtprotoServerRequestEmailUpdate200Response.md)

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

<a id="comatprotoserverrequestpasswordreset"></a>
# **ComAtprotoServerRequestPasswordReset**
> void ComAtprotoServerRequestPasswordReset (ComAtprotoServerRequestPasswordResetRequest comAtprotoServerRequestPasswordResetRequest)



Initiate a user account password reset via email.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerRequestPasswordResetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            var apiInstance = new ComAtprotoServerApi(config);
            var comAtprotoServerRequestPasswordResetRequest = new ComAtprotoServerRequestPasswordResetRequest(); // ComAtprotoServerRequestPasswordResetRequest | 

            try
            {
                apiInstance.ComAtprotoServerRequestPasswordReset(comAtprotoServerRequestPasswordResetRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerRequestPasswordReset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerRequestPasswordResetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoServerRequestPasswordResetWithHttpInfo(comAtprotoServerRequestPasswordResetRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerRequestPasswordResetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoServerRequestPasswordResetRequest** | [**ComAtprotoServerRequestPasswordResetRequest**](ComAtprotoServerRequestPasswordResetRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotoserverreservesigningkey"></a>
# **ComAtprotoServerReserveSigningKey**
> ComAtprotoServerReserveSigningKey200Response ComAtprotoServerReserveSigningKey (ComAtprotoServerReserveSigningKeyRequest comAtprotoServerReserveSigningKeyRequest)



Reserve a repo signing key, for use with account creation. Necessary so that a DID PLC update operation can be constructed during an account migraiton. Public and does not require auth; implemented by PDS. NOTE: this endpoint may change when full account migration is implemented.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerReserveSigningKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoServerApi(config);
            var comAtprotoServerReserveSigningKeyRequest = new ComAtprotoServerReserveSigningKeyRequest(); // ComAtprotoServerReserveSigningKeyRequest | 

            try
            {
                ComAtprotoServerReserveSigningKey200Response result = apiInstance.ComAtprotoServerReserveSigningKey(comAtprotoServerReserveSigningKeyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerReserveSigningKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerReserveSigningKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoServerReserveSigningKey200Response> response = apiInstance.ComAtprotoServerReserveSigningKeyWithHttpInfo(comAtprotoServerReserveSigningKeyRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerReserveSigningKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoServerReserveSigningKeyRequest** | [**ComAtprotoServerReserveSigningKeyRequest**](ComAtprotoServerReserveSigningKeyRequest.md) |  |  |

### Return type

[**ComAtprotoServerReserveSigningKey200Response**](ComAtprotoServerReserveSigningKey200Response.md)

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

<a id="comatprotoserverresetpassword"></a>
# **ComAtprotoServerResetPassword**
> void ComAtprotoServerResetPassword (ComAtprotoServerResetPasswordRequest comAtprotoServerResetPasswordRequest)



Reset a user account password using a token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerResetPasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            var apiInstance = new ComAtprotoServerApi(config);
            var comAtprotoServerResetPasswordRequest = new ComAtprotoServerResetPasswordRequest(); // ComAtprotoServerResetPasswordRequest | 

            try
            {
                apiInstance.ComAtprotoServerResetPassword(comAtprotoServerResetPasswordRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerResetPassword: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerResetPasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoServerResetPasswordWithHttpInfo(comAtprotoServerResetPasswordRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerResetPasswordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoServerResetPasswordRequest** | [**ComAtprotoServerResetPasswordRequest**](ComAtprotoServerResetPasswordRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotoserverrevokeapppassword"></a>
# **ComAtprotoServerRevokeAppPassword**
> void ComAtprotoServerRevokeAppPassword (ComAtprotoServerRevokeAppPasswordRequest comAtprotoServerRevokeAppPasswordRequest)



Revoke an App Password by name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerRevokeAppPasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoServerApi(config);
            var comAtprotoServerRevokeAppPasswordRequest = new ComAtprotoServerRevokeAppPasswordRequest(); // ComAtprotoServerRevokeAppPasswordRequest | 

            try
            {
                apiInstance.ComAtprotoServerRevokeAppPassword(comAtprotoServerRevokeAppPasswordRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerRevokeAppPassword: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerRevokeAppPasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoServerRevokeAppPasswordWithHttpInfo(comAtprotoServerRevokeAppPasswordRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerRevokeAppPasswordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoServerRevokeAppPasswordRequest** | [**ComAtprotoServerRevokeAppPasswordRequest**](ComAtprotoServerRevokeAppPasswordRequest.md) |  |  |

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

<a id="comatprotoserverupdateemail"></a>
# **ComAtprotoServerUpdateEmail**
> void ComAtprotoServerUpdateEmail (ComAtprotoServerUpdateEmailRequest comAtprotoServerUpdateEmailRequest)



Update an account's email.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoServerUpdateEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoServerApi(config);
            var comAtprotoServerUpdateEmailRequest = new ComAtprotoServerUpdateEmailRequest(); // ComAtprotoServerUpdateEmailRequest | 

            try
            {
                apiInstance.ComAtprotoServerUpdateEmail(comAtprotoServerUpdateEmailRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerUpdateEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoServerUpdateEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoServerUpdateEmailWithHttpInfo(comAtprotoServerUpdateEmailRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoServerApi.ComAtprotoServerUpdateEmailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoServerUpdateEmailRequest** | [**ComAtprotoServerUpdateEmailRequest**](ComAtprotoServerUpdateEmailRequest.md) |  |  |

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

