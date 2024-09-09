# BSky.Api.ComAtprotoIdentityApi

All URIs are relative to *https://public.api.bsky.app/xrpc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ComAtprotoIdentityGetRecommendedDidCredentials**](ComAtprotoIdentityApi.md#comatprotoidentitygetrecommendeddidcredentials) | **GET** /com.atproto.identity.getRecommendedDidCredentials |  |
| [**ComAtprotoIdentityRequestPlcOperationSignature**](ComAtprotoIdentityApi.md#comatprotoidentityrequestplcoperationsignature) | **POST** /com.atproto.identity.requestPlcOperationSignature |  |
| [**ComAtprotoIdentityResolveHandle**](ComAtprotoIdentityApi.md#comatprotoidentityresolvehandle) | **GET** /com.atproto.identity.resolveHandle |  |
| [**ComAtprotoIdentitySignPlcOperation**](ComAtprotoIdentityApi.md#comatprotoidentitysignplcoperation) | **POST** /com.atproto.identity.signPlcOperation |  |
| [**ComAtprotoIdentitySubmitPlcOperation**](ComAtprotoIdentityApi.md#comatprotoidentitysubmitplcoperation) | **POST** /com.atproto.identity.submitPlcOperation |  |
| [**ComAtprotoIdentityUpdateHandle**](ComAtprotoIdentityApi.md#comatprotoidentityupdatehandle) | **POST** /com.atproto.identity.updateHandle |  |

<a id="comatprotoidentitygetrecommendeddidcredentials"></a>
# **ComAtprotoIdentityGetRecommendedDidCredentials**
> ComAtprotoIdentityGetRecommendedDidCredentials200Response ComAtprotoIdentityGetRecommendedDidCredentials ()



Describe the credentials that should be included in the DID doc of an account that is migrating to this service.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoIdentityGetRecommendedDidCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoIdentityApi(config);

            try
            {
                ComAtprotoIdentityGetRecommendedDidCredentials200Response result = apiInstance.ComAtprotoIdentityGetRecommendedDidCredentials();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoIdentityApi.ComAtprotoIdentityGetRecommendedDidCredentials: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoIdentityGetRecommendedDidCredentialsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoIdentityGetRecommendedDidCredentials200Response> response = apiInstance.ComAtprotoIdentityGetRecommendedDidCredentialsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoIdentityApi.ComAtprotoIdentityGetRecommendedDidCredentialsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ComAtprotoIdentityGetRecommendedDidCredentials200Response**](ComAtprotoIdentityGetRecommendedDidCredentials200Response.md)

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

<a id="comatprotoidentityrequestplcoperationsignature"></a>
# **ComAtprotoIdentityRequestPlcOperationSignature**
> void ComAtprotoIdentityRequestPlcOperationSignature ()



Request an email with a code to in order to request a signed PLC operation. Requires Auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoIdentityRequestPlcOperationSignatureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoIdentityApi(config);

            try
            {
                apiInstance.ComAtprotoIdentityRequestPlcOperationSignature();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoIdentityApi.ComAtprotoIdentityRequestPlcOperationSignature: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoIdentityRequestPlcOperationSignatureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoIdentityRequestPlcOperationSignatureWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoIdentityApi.ComAtprotoIdentityRequestPlcOperationSignatureWithHttpInfo: " + e.Message);
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

<a id="comatprotoidentityresolvehandle"></a>
# **ComAtprotoIdentityResolveHandle**
> ComAtprotoAdminDeleteAccountRequest ComAtprotoIdentityResolveHandle (string handle)



Resolves a handle (domain name) to a DID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoIdentityResolveHandleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            var apiInstance = new ComAtprotoIdentityApi(config);
            var handle = "handle_example";  // string | The handle to resolve.

            try
            {
                ComAtprotoAdminDeleteAccountRequest result = apiInstance.ComAtprotoIdentityResolveHandle(handle);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoIdentityApi.ComAtprotoIdentityResolveHandle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoIdentityResolveHandleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoAdminDeleteAccountRequest> response = apiInstance.ComAtprotoIdentityResolveHandleWithHttpInfo(handle);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoIdentityApi.ComAtprotoIdentityResolveHandleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **handle** | **string** | The handle to resolve. |  |

### Return type

[**ComAtprotoAdminDeleteAccountRequest**](ComAtprotoAdminDeleteAccountRequest.md)

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

<a id="comatprotoidentitysignplcoperation"></a>
# **ComAtprotoIdentitySignPlcOperation**
> ComAtprotoIdentitySignPlcOperation200Response ComAtprotoIdentitySignPlcOperation (ComAtprotoIdentitySignPlcOperationRequest comAtprotoIdentitySignPlcOperationRequest)



Signs a PLC operation to update some value(s) in the requesting DID's document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoIdentitySignPlcOperationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoIdentityApi(config);
            var comAtprotoIdentitySignPlcOperationRequest = new ComAtprotoIdentitySignPlcOperationRequest(); // ComAtprotoIdentitySignPlcOperationRequest | 

            try
            {
                ComAtprotoIdentitySignPlcOperation200Response result = apiInstance.ComAtprotoIdentitySignPlcOperation(comAtprotoIdentitySignPlcOperationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoIdentityApi.ComAtprotoIdentitySignPlcOperation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoIdentitySignPlcOperationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoIdentitySignPlcOperation200Response> response = apiInstance.ComAtprotoIdentitySignPlcOperationWithHttpInfo(comAtprotoIdentitySignPlcOperationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoIdentityApi.ComAtprotoIdentitySignPlcOperationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoIdentitySignPlcOperationRequest** | [**ComAtprotoIdentitySignPlcOperationRequest**](ComAtprotoIdentitySignPlcOperationRequest.md) |  |  |

### Return type

[**ComAtprotoIdentitySignPlcOperation200Response**](ComAtprotoIdentitySignPlcOperation200Response.md)

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

<a id="comatprotoidentitysubmitplcoperation"></a>
# **ComAtprotoIdentitySubmitPlcOperation**
> void ComAtprotoIdentitySubmitPlcOperation (ComAtprotoIdentitySignPlcOperation200Response comAtprotoIdentitySignPlcOperation200Response)



Validates a PLC operation to ensure that it doesn't violate a service's constraints or get the identity into a bad state, then submits it to the PLC registry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoIdentitySubmitPlcOperationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoIdentityApi(config);
            var comAtprotoIdentitySignPlcOperation200Response = new ComAtprotoIdentitySignPlcOperation200Response(); // ComAtprotoIdentitySignPlcOperation200Response | 

            try
            {
                apiInstance.ComAtprotoIdentitySubmitPlcOperation(comAtprotoIdentitySignPlcOperation200Response);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoIdentityApi.ComAtprotoIdentitySubmitPlcOperation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoIdentitySubmitPlcOperationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoIdentitySubmitPlcOperationWithHttpInfo(comAtprotoIdentitySignPlcOperation200Response);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoIdentityApi.ComAtprotoIdentitySubmitPlcOperationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoIdentitySignPlcOperation200Response** | [**ComAtprotoIdentitySignPlcOperation200Response**](ComAtprotoIdentitySignPlcOperation200Response.md) |  |  |

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

<a id="comatprotoidentityupdatehandle"></a>
# **ComAtprotoIdentityUpdateHandle**
> void ComAtprotoIdentityUpdateHandle (ComAtprotoIdentityUpdateHandleRequest comAtprotoIdentityUpdateHandleRequest)



Updates the current account's handle. Verifies handle validity, and updates did:plc document if necessary. Implemented by PDS, and requires auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoIdentityUpdateHandleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoIdentityApi(config);
            var comAtprotoIdentityUpdateHandleRequest = new ComAtprotoIdentityUpdateHandleRequest(); // ComAtprotoIdentityUpdateHandleRequest | 

            try
            {
                apiInstance.ComAtprotoIdentityUpdateHandle(comAtprotoIdentityUpdateHandleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoIdentityApi.ComAtprotoIdentityUpdateHandle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoIdentityUpdateHandleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoIdentityUpdateHandleWithHttpInfo(comAtprotoIdentityUpdateHandleRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoIdentityApi.ComAtprotoIdentityUpdateHandleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoIdentityUpdateHandleRequest** | [**ComAtprotoIdentityUpdateHandleRequest**](ComAtprotoIdentityUpdateHandleRequest.md) |  |  |

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

