# BSky.Api.ToolsOzoneModerationApi

All URIs are relative to *https://public.api.bsky.app/xrpc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ToolsOzoneModerationEmitEvent**](ToolsOzoneModerationApi.md#toolsozonemoderationemitevent) | **POST** /tools.ozone.moderation.emitEvent |  |
| [**ToolsOzoneModerationGetEvent**](ToolsOzoneModerationApi.md#toolsozonemoderationgetevent) | **GET** /tools.ozone.moderation.getEvent |  |
| [**ToolsOzoneModerationGetRecord**](ToolsOzoneModerationApi.md#toolsozonemoderationgetrecord) | **GET** /tools.ozone.moderation.getRecord |  |
| [**ToolsOzoneModerationGetRepo**](ToolsOzoneModerationApi.md#toolsozonemoderationgetrepo) | **GET** /tools.ozone.moderation.getRepo |  |
| [**ToolsOzoneModerationQueryEvents**](ToolsOzoneModerationApi.md#toolsozonemoderationqueryevents) | **GET** /tools.ozone.moderation.queryEvents |  |
| [**ToolsOzoneModerationQueryStatuses**](ToolsOzoneModerationApi.md#toolsozonemoderationquerystatuses) | **GET** /tools.ozone.moderation.queryStatuses |  |
| [**ToolsOzoneModerationSearchRepos**](ToolsOzoneModerationApi.md#toolsozonemoderationsearchrepos) | **GET** /tools.ozone.moderation.searchRepos |  |

<a id="toolsozonemoderationemitevent"></a>
# **ToolsOzoneModerationEmitEvent**
> ToolsOzoneModerationDefsModEventView ToolsOzoneModerationEmitEvent (ToolsOzoneModerationEmitEventRequest toolsOzoneModerationEmitEventRequest)



Take a moderation action on an actor.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ToolsOzoneModerationEmitEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolsOzoneModerationApi(config);
            var toolsOzoneModerationEmitEventRequest = new ToolsOzoneModerationEmitEventRequest(); // ToolsOzoneModerationEmitEventRequest | 

            try
            {
                ToolsOzoneModerationDefsModEventView result = apiInstance.ToolsOzoneModerationEmitEvent(toolsOzoneModerationEmitEventRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsOzoneModerationApi.ToolsOzoneModerationEmitEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ToolsOzoneModerationEmitEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ToolsOzoneModerationDefsModEventView> response = apiInstance.ToolsOzoneModerationEmitEventWithHttpInfo(toolsOzoneModerationEmitEventRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsOzoneModerationApi.ToolsOzoneModerationEmitEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **toolsOzoneModerationEmitEventRequest** | [**ToolsOzoneModerationEmitEventRequest**](ToolsOzoneModerationEmitEventRequest.md) |  |  |

### Return type

[**ToolsOzoneModerationDefsModEventView**](ToolsOzoneModerationDefsModEventView.md)

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

<a id="toolsozonemoderationgetevent"></a>
# **ToolsOzoneModerationGetEvent**
> ToolsOzoneModerationDefsModEventViewDetail ToolsOzoneModerationGetEvent (int id)



Get details about a moderation event.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ToolsOzoneModerationGetEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolsOzoneModerationApi(config);
            var id = 56;  // int | 

            try
            {
                ToolsOzoneModerationDefsModEventViewDetail result = apiInstance.ToolsOzoneModerationGetEvent(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsOzoneModerationApi.ToolsOzoneModerationGetEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ToolsOzoneModerationGetEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ToolsOzoneModerationDefsModEventViewDetail> response = apiInstance.ToolsOzoneModerationGetEventWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsOzoneModerationApi.ToolsOzoneModerationGetEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**ToolsOzoneModerationDefsModEventViewDetail**](ToolsOzoneModerationDefsModEventViewDetail.md)

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

<a id="toolsozonemoderationgetrecord"></a>
# **ToolsOzoneModerationGetRecord**
> ToolsOzoneModerationDefsRecordViewDetail ToolsOzoneModerationGetRecord (string uri, string? cid = null)



Get details about a record.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ToolsOzoneModerationGetRecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolsOzoneModerationApi(config);
            var uri = "uri_example";  // string | 
            var cid = "cid_example";  // string? |  (optional) 

            try
            {
                ToolsOzoneModerationDefsRecordViewDetail result = apiInstance.ToolsOzoneModerationGetRecord(uri, cid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsOzoneModerationApi.ToolsOzoneModerationGetRecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ToolsOzoneModerationGetRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ToolsOzoneModerationDefsRecordViewDetail> response = apiInstance.ToolsOzoneModerationGetRecordWithHttpInfo(uri, cid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsOzoneModerationApi.ToolsOzoneModerationGetRecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uri** | **string** |  |  |
| **cid** | **string?** |  | [optional]  |

### Return type

[**ToolsOzoneModerationDefsRecordViewDetail**](ToolsOzoneModerationDefsRecordViewDetail.md)

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

<a id="toolsozonemoderationgetrepo"></a>
# **ToolsOzoneModerationGetRepo**
> ToolsOzoneModerationDefsRepoViewDetail ToolsOzoneModerationGetRepo (string did)



Get details about a repository.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ToolsOzoneModerationGetRepoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolsOzoneModerationApi(config);
            var did = "did_example";  // string | 

            try
            {
                ToolsOzoneModerationDefsRepoViewDetail result = apiInstance.ToolsOzoneModerationGetRepo(did);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsOzoneModerationApi.ToolsOzoneModerationGetRepo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ToolsOzoneModerationGetRepoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ToolsOzoneModerationDefsRepoViewDetail> response = apiInstance.ToolsOzoneModerationGetRepoWithHttpInfo(did);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsOzoneModerationApi.ToolsOzoneModerationGetRepoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **did** | **string** |  |  |

### Return type

[**ToolsOzoneModerationDefsRepoViewDetail**](ToolsOzoneModerationDefsRepoViewDetail.md)

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

<a id="toolsozonemoderationqueryevents"></a>
# **ToolsOzoneModerationQueryEvents**
> ToolsOzoneModerationQueryEvents200Response ToolsOzoneModerationQueryEvents (List<string>? types = null, string? createdBy = null, string? sortDirection = null, DateTime? createdAfter = null, DateTime? createdBefore = null, string? subject = null, bool? includeAllUserRecords = null, int? limit = null, bool? hasComment = null, string? comment = null, List<string>? addedLabels = null, List<string>? removedLabels = null, List<string>? addedTags = null, List<string>? removedTags = null, List<string>? reportTypes = null, string? cursor = null)



List moderation events related to a subject.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ToolsOzoneModerationQueryEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolsOzoneModerationApi(config);
            var types = new List<string>?(); // List<string>? | The types of events (fully qualified string in the format of tools.ozone.moderation.defs#modEvent<name>) to filter by. If not specified, all events are returned. (optional) 
            var createdBy = "createdBy_example";  // string? |  (optional) 
            var sortDirection = "\"desc\"";  // string? | Sort direction for the events. Defaults to descending order of created at timestamp. (optional)  (default to "desc")
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Retrieve events created after a given timestamp (optional) 
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Retrieve events created before a given timestamp (optional) 
            var subject = "subject_example";  // string? |  (optional) 
            var includeAllUserRecords = true;  // bool? | If true, events on all record types (posts, lists, profile etc.) owned by the did are returned (optional) 
            var limit = 50;  // int? |  (optional)  (default to 50)
            var hasComment = true;  // bool? | If true, only events with comments are returned (optional) 
            var comment = "comment_example";  // string? | If specified, only events with comments containing the keyword are returned (optional) 
            var addedLabels = new List<string>?(); // List<string>? | If specified, only events where all of these labels were added are returned (optional) 
            var removedLabels = new List<string>?(); // List<string>? | If specified, only events where all of these labels were removed are returned (optional) 
            var addedTags = new List<string>?(); // List<string>? | If specified, only events where all of these tags were added are returned (optional) 
            var removedTags = new List<string>?(); // List<string>? | If specified, only events where all of these tags were removed are returned (optional) 
            var reportTypes = new List<string>?(); // List<string>? |  (optional) 
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                ToolsOzoneModerationQueryEvents200Response result = apiInstance.ToolsOzoneModerationQueryEvents(types, createdBy, sortDirection, createdAfter, createdBefore, subject, includeAllUserRecords, limit, hasComment, comment, addedLabels, removedLabels, addedTags, removedTags, reportTypes, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsOzoneModerationApi.ToolsOzoneModerationQueryEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ToolsOzoneModerationQueryEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ToolsOzoneModerationQueryEvents200Response> response = apiInstance.ToolsOzoneModerationQueryEventsWithHttpInfo(types, createdBy, sortDirection, createdAfter, createdBefore, subject, includeAllUserRecords, limit, hasComment, comment, addedLabels, removedLabels, addedTags, removedTags, reportTypes, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsOzoneModerationApi.ToolsOzoneModerationQueryEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **types** | [**List&lt;string&gt;?**](string.md) | The types of events (fully qualified string in the format of tools.ozone.moderation.defs#modEvent&lt;name&gt;) to filter by. If not specified, all events are returned. | [optional]  |
| **createdBy** | **string?** |  | [optional]  |
| **sortDirection** | **string?** | Sort direction for the events. Defaults to descending order of created at timestamp. | [optional] [default to &quot;desc&quot;] |
| **createdAfter** | **DateTime?** | Retrieve events created after a given timestamp | [optional]  |
| **createdBefore** | **DateTime?** | Retrieve events created before a given timestamp | [optional]  |
| **subject** | **string?** |  | [optional]  |
| **includeAllUserRecords** | **bool?** | If true, events on all record types (posts, lists, profile etc.) owned by the did are returned | [optional]  |
| **limit** | **int?** |  | [optional] [default to 50] |
| **hasComment** | **bool?** | If true, only events with comments are returned | [optional]  |
| **comment** | **string?** | If specified, only events with comments containing the keyword are returned | [optional]  |
| **addedLabels** | [**List&lt;string&gt;?**](string.md) | If specified, only events where all of these labels were added are returned | [optional]  |
| **removedLabels** | [**List&lt;string&gt;?**](string.md) | If specified, only events where all of these labels were removed are returned | [optional]  |
| **addedTags** | [**List&lt;string&gt;?**](string.md) | If specified, only events where all of these tags were added are returned | [optional]  |
| **removedTags** | [**List&lt;string&gt;?**](string.md) | If specified, only events where all of these tags were removed are returned | [optional]  |
| **reportTypes** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**ToolsOzoneModerationQueryEvents200Response**](ToolsOzoneModerationQueryEvents200Response.md)

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

<a id="toolsozonemoderationquerystatuses"></a>
# **ToolsOzoneModerationQueryStatuses**
> ToolsOzoneModerationQueryStatuses200Response ToolsOzoneModerationQueryStatuses (string? subject = null, string? comment = null, DateTime? reportedAfter = null, DateTime? reportedBefore = null, DateTime? reviewedAfter = null, DateTime? reviewedBefore = null, bool? includeMuted = null, bool? onlyMuted = null, string? reviewState = null, List<string>? ignoreSubjects = null, string? lastReviewedBy = null, string? sortField = null, string? sortDirection = null, bool? takendown = null, bool? appealed = null, int? limit = null, List<string>? tags = null, List<string>? excludeTags = null, string? cursor = null)



View moderation statuses of subjects (record or repo).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ToolsOzoneModerationQueryStatusesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolsOzoneModerationApi(config);
            var subject = "subject_example";  // string? |  (optional) 
            var comment = "comment_example";  // string? | Search subjects by keyword from comments (optional) 
            var reportedAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Search subjects reported after a given timestamp (optional) 
            var reportedBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Search subjects reported before a given timestamp (optional) 
            var reviewedAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Search subjects reviewed after a given timestamp (optional) 
            var reviewedBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Search subjects reviewed before a given timestamp (optional) 
            var includeMuted = true;  // bool? | By default, we don't include muted subjects in the results. Set this to true to include them. (optional) 
            var onlyMuted = true;  // bool? | When set to true, only muted subjects and reporters will be returned. (optional) 
            var reviewState = "reviewState_example";  // string? | Specify when fetching subjects in a certain state (optional) 
            var ignoreSubjects = new List<string>?(); // List<string>? |  (optional) 
            var lastReviewedBy = "lastReviewedBy_example";  // string? | Get all subject statuses that were reviewed by a specific moderator (optional) 
            var sortField = "\"lastReportedAt\"";  // string? |  (optional)  (default to "lastReportedAt")
            var sortDirection = "\"desc\"";  // string? |  (optional)  (default to "desc")
            var takendown = true;  // bool? | Get subjects that were taken down (optional) 
            var appealed = true;  // bool? | Get subjects in unresolved appealed status (optional) 
            var limit = 50;  // int? |  (optional)  (default to 50)
            var tags = new List<string>?(); // List<string>? |  (optional) 
            var excludeTags = new List<string>?(); // List<string>? |  (optional) 
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                ToolsOzoneModerationQueryStatuses200Response result = apiInstance.ToolsOzoneModerationQueryStatuses(subject, comment, reportedAfter, reportedBefore, reviewedAfter, reviewedBefore, includeMuted, onlyMuted, reviewState, ignoreSubjects, lastReviewedBy, sortField, sortDirection, takendown, appealed, limit, tags, excludeTags, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsOzoneModerationApi.ToolsOzoneModerationQueryStatuses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ToolsOzoneModerationQueryStatusesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ToolsOzoneModerationQueryStatuses200Response> response = apiInstance.ToolsOzoneModerationQueryStatusesWithHttpInfo(subject, comment, reportedAfter, reportedBefore, reviewedAfter, reviewedBefore, includeMuted, onlyMuted, reviewState, ignoreSubjects, lastReviewedBy, sortField, sortDirection, takendown, appealed, limit, tags, excludeTags, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsOzoneModerationApi.ToolsOzoneModerationQueryStatusesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subject** | **string?** |  | [optional]  |
| **comment** | **string?** | Search subjects by keyword from comments | [optional]  |
| **reportedAfter** | **DateTime?** | Search subjects reported after a given timestamp | [optional]  |
| **reportedBefore** | **DateTime?** | Search subjects reported before a given timestamp | [optional]  |
| **reviewedAfter** | **DateTime?** | Search subjects reviewed after a given timestamp | [optional]  |
| **reviewedBefore** | **DateTime?** | Search subjects reviewed before a given timestamp | [optional]  |
| **includeMuted** | **bool?** | By default, we don&#39;t include muted subjects in the results. Set this to true to include them. | [optional]  |
| **onlyMuted** | **bool?** | When set to true, only muted subjects and reporters will be returned. | [optional]  |
| **reviewState** | **string?** | Specify when fetching subjects in a certain state | [optional]  |
| **ignoreSubjects** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **lastReviewedBy** | **string?** | Get all subject statuses that were reviewed by a specific moderator | [optional]  |
| **sortField** | **string?** |  | [optional] [default to &quot;lastReportedAt&quot;] |
| **sortDirection** | **string?** |  | [optional] [default to &quot;desc&quot;] |
| **takendown** | **bool?** | Get subjects that were taken down | [optional]  |
| **appealed** | **bool?** | Get subjects in unresolved appealed status | [optional]  |
| **limit** | **int?** |  | [optional] [default to 50] |
| **tags** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **excludeTags** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**ToolsOzoneModerationQueryStatuses200Response**](ToolsOzoneModerationQueryStatuses200Response.md)

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

<a id="toolsozonemoderationsearchrepos"></a>
# **ToolsOzoneModerationSearchRepos**
> ToolsOzoneModerationSearchRepos200Response ToolsOzoneModerationSearchRepos (string? q = null, int? limit = null, string? cursor = null)



Find repositories based on a search term.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ToolsOzoneModerationSearchReposExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ToolsOzoneModerationApi(config);
            var q = "q_example";  // string? |  (optional) 
            var limit = 50;  // int? |  (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                ToolsOzoneModerationSearchRepos200Response result = apiInstance.ToolsOzoneModerationSearchRepos(q, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsOzoneModerationApi.ToolsOzoneModerationSearchRepos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ToolsOzoneModerationSearchReposWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ToolsOzoneModerationSearchRepos200Response> response = apiInstance.ToolsOzoneModerationSearchReposWithHttpInfo(q, limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsOzoneModerationApi.ToolsOzoneModerationSearchReposWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **q** | **string?** |  | [optional]  |
| **limit** | **int?** |  | [optional] [default to 50] |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**ToolsOzoneModerationSearchRepos200Response**](ToolsOzoneModerationSearchRepos200Response.md)

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

