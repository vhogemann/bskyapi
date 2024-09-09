# BSky.Api.ComAtprotoRepoApi

All URIs are relative to *https://public.api.bsky.app/xrpc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ComAtprotoRepoApplyWrites**](ComAtprotoRepoApi.md#comatprotorepoapplywrites) | **POST** /com.atproto.repo.applyWrites |  |
| [**ComAtprotoRepoCreateRecord**](ComAtprotoRepoApi.md#comatprotorepocreaterecord) | **POST** /com.atproto.repo.createRecord |  |
| [**ComAtprotoRepoDeleteRecord**](ComAtprotoRepoApi.md#comatprotorepodeleterecord) | **POST** /com.atproto.repo.deleteRecord |  |
| [**ComAtprotoRepoDescribeRepo**](ComAtprotoRepoApi.md#comatprotorepodescriberepo) | **GET** /com.atproto.repo.describeRepo |  |
| [**ComAtprotoRepoGetRecord**](ComAtprotoRepoApi.md#comatprotorepogetrecord) | **GET** /com.atproto.repo.getRecord |  |
| [**ComAtprotoRepoImportRepo**](ComAtprotoRepoApi.md#comatprotorepoimportrepo) | **POST** /com.atproto.repo.importRepo |  |
| [**ComAtprotoRepoListMissingBlobs**](ComAtprotoRepoApi.md#comatprotorepolistmissingblobs) | **GET** /com.atproto.repo.listMissingBlobs |  |
| [**ComAtprotoRepoListRecords**](ComAtprotoRepoApi.md#comatprotorepolistrecords) | **GET** /com.atproto.repo.listRecords |  |
| [**ComAtprotoRepoPutRecord**](ComAtprotoRepoApi.md#comatprotorepoputrecord) | **POST** /com.atproto.repo.putRecord |  |
| [**ComAtprotoRepoUploadBlob**](ComAtprotoRepoApi.md#comatprotorepouploadblob) | **POST** /com.atproto.repo.uploadBlob |  |

<a id="comatprotorepoapplywrites"></a>
# **ComAtprotoRepoApplyWrites**
> ComAtprotoRepoApplyWrites200Response ComAtprotoRepoApplyWrites (ComAtprotoRepoApplyWritesRequest comAtprotoRepoApplyWritesRequest)



Apply a batch transaction of repository creates, updates, and deletes. Requires auth, implemented by PDS.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoRepoApplyWritesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoRepoApi(config);
            var comAtprotoRepoApplyWritesRequest = new ComAtprotoRepoApplyWritesRequest(); // ComAtprotoRepoApplyWritesRequest | 

            try
            {
                ComAtprotoRepoApplyWrites200Response result = apiInstance.ComAtprotoRepoApplyWrites(comAtprotoRepoApplyWritesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoRepoApi.ComAtprotoRepoApplyWrites: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoRepoApplyWritesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoRepoApplyWrites200Response> response = apiInstance.ComAtprotoRepoApplyWritesWithHttpInfo(comAtprotoRepoApplyWritesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoRepoApi.ComAtprotoRepoApplyWritesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoRepoApplyWritesRequest** | [**ComAtprotoRepoApplyWritesRequest**](ComAtprotoRepoApplyWritesRequest.md) |  |  |

### Return type

[**ComAtprotoRepoApplyWrites200Response**](ComAtprotoRepoApplyWrites200Response.md)

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

<a id="comatprotorepocreaterecord"></a>
# **ComAtprotoRepoCreateRecord**
> ComAtprotoRepoCreateRecord200Response ComAtprotoRepoCreateRecord (ComAtprotoRepoCreateRecordRequest comAtprotoRepoCreateRecordRequest)



Create a single new repository record. Requires auth, implemented by PDS.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoRepoCreateRecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoRepoApi(config);
            var comAtprotoRepoCreateRecordRequest = new ComAtprotoRepoCreateRecordRequest(); // ComAtprotoRepoCreateRecordRequest | 

            try
            {
                ComAtprotoRepoCreateRecord200Response result = apiInstance.ComAtprotoRepoCreateRecord(comAtprotoRepoCreateRecordRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoRepoApi.ComAtprotoRepoCreateRecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoRepoCreateRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoRepoCreateRecord200Response> response = apiInstance.ComAtprotoRepoCreateRecordWithHttpInfo(comAtprotoRepoCreateRecordRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoRepoApi.ComAtprotoRepoCreateRecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoRepoCreateRecordRequest** | [**ComAtprotoRepoCreateRecordRequest**](ComAtprotoRepoCreateRecordRequest.md) |  |  |

### Return type

[**ComAtprotoRepoCreateRecord200Response**](ComAtprotoRepoCreateRecord200Response.md)

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

<a id="comatprotorepodeleterecord"></a>
# **ComAtprotoRepoDeleteRecord**
> ComAtprotoRepoDeleteRecord200Response ComAtprotoRepoDeleteRecord (ComAtprotoRepoDeleteRecordRequest comAtprotoRepoDeleteRecordRequest)



Delete a repository record, or ensure it doesn't exist. Requires auth, implemented by PDS.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoRepoDeleteRecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoRepoApi(config);
            var comAtprotoRepoDeleteRecordRequest = new ComAtprotoRepoDeleteRecordRequest(); // ComAtprotoRepoDeleteRecordRequest | 

            try
            {
                ComAtprotoRepoDeleteRecord200Response result = apiInstance.ComAtprotoRepoDeleteRecord(comAtprotoRepoDeleteRecordRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoRepoApi.ComAtprotoRepoDeleteRecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoRepoDeleteRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoRepoDeleteRecord200Response> response = apiInstance.ComAtprotoRepoDeleteRecordWithHttpInfo(comAtprotoRepoDeleteRecordRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoRepoApi.ComAtprotoRepoDeleteRecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoRepoDeleteRecordRequest** | [**ComAtprotoRepoDeleteRecordRequest**](ComAtprotoRepoDeleteRecordRequest.md) |  |  |

### Return type

[**ComAtprotoRepoDeleteRecord200Response**](ComAtprotoRepoDeleteRecord200Response.md)

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

<a id="comatprotorepodescriberepo"></a>
# **ComAtprotoRepoDescribeRepo**
> ComAtprotoRepoDescribeRepo200Response ComAtprotoRepoDescribeRepo (string repo)



Get information about an account and repository, including the list of collections. Does not require auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoRepoDescribeRepoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            var apiInstance = new ComAtprotoRepoApi(config);
            var repo = "repo_example";  // string | The handle or DID of the repo.

            try
            {
                ComAtprotoRepoDescribeRepo200Response result = apiInstance.ComAtprotoRepoDescribeRepo(repo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoRepoApi.ComAtprotoRepoDescribeRepo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoRepoDescribeRepoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoRepoDescribeRepo200Response> response = apiInstance.ComAtprotoRepoDescribeRepoWithHttpInfo(repo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoRepoApi.ComAtprotoRepoDescribeRepoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | The handle or DID of the repo. |  |

### Return type

[**ComAtprotoRepoDescribeRepo200Response**](ComAtprotoRepoDescribeRepo200Response.md)

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

<a id="comatprotorepogetrecord"></a>
# **ComAtprotoRepoGetRecord**
> ComAtprotoRepoGetRecord200Response ComAtprotoRepoGetRecord (string repo, string collection, string rkey, string? cid = null)



Get a single record from a repository. Does not require auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoRepoGetRecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            var apiInstance = new ComAtprotoRepoApi(config);
            var repo = "repo_example";  // string | The handle or DID of the repo.
            var collection = "collection_example";  // string | The NSID of the record collection.
            var rkey = "rkey_example";  // string | The Record Key.
            var cid = "cid_example";  // string? | The CID of the version of the record. If not specified, then return the most recent version. (optional) 

            try
            {
                ComAtprotoRepoGetRecord200Response result = apiInstance.ComAtprotoRepoGetRecord(repo, collection, rkey, cid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoRepoApi.ComAtprotoRepoGetRecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoRepoGetRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoRepoGetRecord200Response> response = apiInstance.ComAtprotoRepoGetRecordWithHttpInfo(repo, collection, rkey, cid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoRepoApi.ComAtprotoRepoGetRecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | The handle or DID of the repo. |  |
| **collection** | **string** | The NSID of the record collection. |  |
| **rkey** | **string** | The Record Key. |  |
| **cid** | **string?** | The CID of the version of the record. If not specified, then return the most recent version. | [optional]  |

### Return type

[**ComAtprotoRepoGetRecord200Response**](ComAtprotoRepoGetRecord200Response.md)

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

<a id="comatprotorepoimportrepo"></a>
# **ComAtprotoRepoImportRepo**
> void ComAtprotoRepoImportRepo ()



Import a repo in the form of a CAR file. Requires Content-Length HTTP header to be set.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoRepoImportRepoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoRepoApi(config);

            try
            {
                apiInstance.ComAtprotoRepoImportRepo();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoRepoApi.ComAtprotoRepoImportRepo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoRepoImportRepoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoRepoImportRepoWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoRepoApi.ComAtprotoRepoImportRepoWithHttpInfo: " + e.Message);
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

 - **Content-Type**: application/vnd.ipld.car
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotorepolistmissingblobs"></a>
# **ComAtprotoRepoListMissingBlobs**
> ComAtprotoRepoListMissingBlobs200Response ComAtprotoRepoListMissingBlobs (int? limit = null, string? cursor = null)



Returns a list of missing blobs for the requesting account. Intended to be used in the account migration flow.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoRepoListMissingBlobsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoRepoApi(config);
            var limit = 500;  // int? |  (optional)  (default to 500)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                ComAtprotoRepoListMissingBlobs200Response result = apiInstance.ComAtprotoRepoListMissingBlobs(limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoRepoApi.ComAtprotoRepoListMissingBlobs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoRepoListMissingBlobsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoRepoListMissingBlobs200Response> response = apiInstance.ComAtprotoRepoListMissingBlobsWithHttpInfo(limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoRepoApi.ComAtprotoRepoListMissingBlobsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** |  | [optional] [default to 500] |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**ComAtprotoRepoListMissingBlobs200Response**](ComAtprotoRepoListMissingBlobs200Response.md)

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

<a id="comatprotorepolistrecords"></a>
# **ComAtprotoRepoListRecords**
> ComAtprotoRepoListRecords200Response ComAtprotoRepoListRecords (string repo, string collection, int? limit = null, string? cursor = null, bool? reverse = null)



List a range of records in a repository, matching a specific collection. Does not require auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoRepoListRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            var apiInstance = new ComAtprotoRepoApi(config);
            var repo = "repo_example";  // string | The handle or DID of the repo.
            var collection = "collection_example";  // string | The NSID of the record type.
            var limit = 50;  // int? | The number of records to return. (optional)  (default to 50)
            var cursor = "cursor_example";  // string? |  (optional) 
            var reverse = true;  // bool? | Flag to reverse the order of the returned records. (optional) 

            try
            {
                ComAtprotoRepoListRecords200Response result = apiInstance.ComAtprotoRepoListRecords(repo, collection, limit, cursor, reverse);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoRepoApi.ComAtprotoRepoListRecords: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoRepoListRecordsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoRepoListRecords200Response> response = apiInstance.ComAtprotoRepoListRecordsWithHttpInfo(repo, collection, limit, cursor, reverse);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoRepoApi.ComAtprotoRepoListRecordsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | The handle or DID of the repo. |  |
| **collection** | **string** | The NSID of the record type. |  |
| **limit** | **int?** | The number of records to return. | [optional] [default to 50] |
| **cursor** | **string?** |  | [optional]  |
| **reverse** | **bool?** | Flag to reverse the order of the returned records. | [optional]  |

### Return type

[**ComAtprotoRepoListRecords200Response**](ComAtprotoRepoListRecords200Response.md)

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

<a id="comatprotorepoputrecord"></a>
# **ComAtprotoRepoPutRecord**
> ComAtprotoRepoCreateRecord200Response ComAtprotoRepoPutRecord (ComAtprotoRepoPutRecordRequest comAtprotoRepoPutRecordRequest)



Write a repository record, creating or updating it as needed. Requires auth, implemented by PDS.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoRepoPutRecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoRepoApi(config);
            var comAtprotoRepoPutRecordRequest = new ComAtprotoRepoPutRecordRequest(); // ComAtprotoRepoPutRecordRequest | 

            try
            {
                ComAtprotoRepoCreateRecord200Response result = apiInstance.ComAtprotoRepoPutRecord(comAtprotoRepoPutRecordRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoRepoApi.ComAtprotoRepoPutRecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoRepoPutRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoRepoCreateRecord200Response> response = apiInstance.ComAtprotoRepoPutRecordWithHttpInfo(comAtprotoRepoPutRecordRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoRepoApi.ComAtprotoRepoPutRecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoRepoPutRecordRequest** | [**ComAtprotoRepoPutRecordRequest**](ComAtprotoRepoPutRecordRequest.md) |  |  |

### Return type

[**ComAtprotoRepoCreateRecord200Response**](ComAtprotoRepoCreateRecord200Response.md)

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

<a id="comatprotorepouploadblob"></a>
# **ComAtprotoRepoUploadBlob**
> ComAtprotoRepoUploadBlob200Response ComAtprotoRepoUploadBlob ()



Upload a new blob, to be referenced from a repository record. The blob will be deleted if it is not referenced within a time window (eg, minutes). Blob restrictions (mimetype, size, etc) are enforced when the reference is created. Requires auth, implemented by PDS.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoRepoUploadBlobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoRepoApi(config);

            try
            {
                ComAtprotoRepoUploadBlob200Response result = apiInstance.ComAtprotoRepoUploadBlob();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoRepoApi.ComAtprotoRepoUploadBlob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoRepoUploadBlobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoRepoUploadBlob200Response> response = apiInstance.ComAtprotoRepoUploadBlobWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoRepoApi.ComAtprotoRepoUploadBlobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ComAtprotoRepoUploadBlob200Response**](ComAtprotoRepoUploadBlob200Response.md)

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

