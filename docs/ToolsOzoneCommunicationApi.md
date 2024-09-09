# BSky.Api.ToolsOzoneCommunicationApi

All URIs are relative to *https://public.api.bsky.app/xrpc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ToolsOzoneCommunicationCreateTemplate**](ToolsOzoneCommunicationApi.md#toolsozonecommunicationcreatetemplate) | **POST** /tools.ozone.communication.createTemplate |  |
| [**ToolsOzoneCommunicationDeleteTemplate**](ToolsOzoneCommunicationApi.md#toolsozonecommunicationdeletetemplate) | **POST** /tools.ozone.communication.deleteTemplate |  |
| [**ToolsOzoneCommunicationListTemplates**](ToolsOzoneCommunicationApi.md#toolsozonecommunicationlisttemplates) | **GET** /tools.ozone.communication.listTemplates |  |
| [**ToolsOzoneCommunicationUpdateTemplate**](ToolsOzoneCommunicationApi.md#toolsozonecommunicationupdatetemplate) | **POST** /tools.ozone.communication.updateTemplate |  |

<a id="toolsozonecommunicationcreatetemplate"></a>
# **ToolsOzoneCommunicationCreateTemplate**
> ToolsOzoneCommunicationDefsTemplateView ToolsOzoneCommunicationCreateTemplate (ToolsOzoneCommunicationCreateTemplateRequest toolsOzoneCommunicationCreateTemplateRequest)



Administrative action to create a new, re-usable communication (email for now) template.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ToolsOzoneCommunicationCreateTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolsOzoneCommunicationApi(config);
            var toolsOzoneCommunicationCreateTemplateRequest = new ToolsOzoneCommunicationCreateTemplateRequest(); // ToolsOzoneCommunicationCreateTemplateRequest | 

            try
            {
                ToolsOzoneCommunicationDefsTemplateView result = apiInstance.ToolsOzoneCommunicationCreateTemplate(toolsOzoneCommunicationCreateTemplateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsOzoneCommunicationApi.ToolsOzoneCommunicationCreateTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ToolsOzoneCommunicationCreateTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ToolsOzoneCommunicationDefsTemplateView> response = apiInstance.ToolsOzoneCommunicationCreateTemplateWithHttpInfo(toolsOzoneCommunicationCreateTemplateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsOzoneCommunicationApi.ToolsOzoneCommunicationCreateTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **toolsOzoneCommunicationCreateTemplateRequest** | [**ToolsOzoneCommunicationCreateTemplateRequest**](ToolsOzoneCommunicationCreateTemplateRequest.md) |  |  |

### Return type

[**ToolsOzoneCommunicationDefsTemplateView**](ToolsOzoneCommunicationDefsTemplateView.md)

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

<a id="toolsozonecommunicationdeletetemplate"></a>
# **ToolsOzoneCommunicationDeleteTemplate**
> void ToolsOzoneCommunicationDeleteTemplate (ToolsOzoneCommunicationDeleteTemplateRequest toolsOzoneCommunicationDeleteTemplateRequest)



Delete a communication template.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ToolsOzoneCommunicationDeleteTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolsOzoneCommunicationApi(config);
            var toolsOzoneCommunicationDeleteTemplateRequest = new ToolsOzoneCommunicationDeleteTemplateRequest(); // ToolsOzoneCommunicationDeleteTemplateRequest | 

            try
            {
                apiInstance.ToolsOzoneCommunicationDeleteTemplate(toolsOzoneCommunicationDeleteTemplateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsOzoneCommunicationApi.ToolsOzoneCommunicationDeleteTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ToolsOzoneCommunicationDeleteTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ToolsOzoneCommunicationDeleteTemplateWithHttpInfo(toolsOzoneCommunicationDeleteTemplateRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsOzoneCommunicationApi.ToolsOzoneCommunicationDeleteTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **toolsOzoneCommunicationDeleteTemplateRequest** | [**ToolsOzoneCommunicationDeleteTemplateRequest**](ToolsOzoneCommunicationDeleteTemplateRequest.md) |  |  |

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

<a id="toolsozonecommunicationlisttemplates"></a>
# **ToolsOzoneCommunicationListTemplates**
> ToolsOzoneCommunicationListTemplates200Response ToolsOzoneCommunicationListTemplates ()



Get list of all communication templates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ToolsOzoneCommunicationListTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolsOzoneCommunicationApi(config);

            try
            {
                ToolsOzoneCommunicationListTemplates200Response result = apiInstance.ToolsOzoneCommunicationListTemplates();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsOzoneCommunicationApi.ToolsOzoneCommunicationListTemplates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ToolsOzoneCommunicationListTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ToolsOzoneCommunicationListTemplates200Response> response = apiInstance.ToolsOzoneCommunicationListTemplatesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsOzoneCommunicationApi.ToolsOzoneCommunicationListTemplatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ToolsOzoneCommunicationListTemplates200Response**](ToolsOzoneCommunicationListTemplates200Response.md)

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

<a id="toolsozonecommunicationupdatetemplate"></a>
# **ToolsOzoneCommunicationUpdateTemplate**
> ToolsOzoneCommunicationDefsTemplateView ToolsOzoneCommunicationUpdateTemplate (ToolsOzoneCommunicationUpdateTemplateRequest toolsOzoneCommunicationUpdateTemplateRequest)



Administrative action to update an existing communication template. Allows passing partial fields to patch specific fields only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ToolsOzoneCommunicationUpdateTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolsOzoneCommunicationApi(config);
            var toolsOzoneCommunicationUpdateTemplateRequest = new ToolsOzoneCommunicationUpdateTemplateRequest(); // ToolsOzoneCommunicationUpdateTemplateRequest | 

            try
            {
                ToolsOzoneCommunicationDefsTemplateView result = apiInstance.ToolsOzoneCommunicationUpdateTemplate(toolsOzoneCommunicationUpdateTemplateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsOzoneCommunicationApi.ToolsOzoneCommunicationUpdateTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ToolsOzoneCommunicationUpdateTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ToolsOzoneCommunicationDefsTemplateView> response = apiInstance.ToolsOzoneCommunicationUpdateTemplateWithHttpInfo(toolsOzoneCommunicationUpdateTemplateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsOzoneCommunicationApi.ToolsOzoneCommunicationUpdateTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **toolsOzoneCommunicationUpdateTemplateRequest** | [**ToolsOzoneCommunicationUpdateTemplateRequest**](ToolsOzoneCommunicationUpdateTemplateRequest.md) |  |  |

### Return type

[**ToolsOzoneCommunicationDefsTemplateView**](ToolsOzoneCommunicationDefsTemplateView.md)

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

