# BSky.Api.ComAtprotoSyncApi

All URIs are relative to *https://public.api.bsky.app/xrpc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ComAtprotoSyncGetBlob**](ComAtprotoSyncApi.md#comatprotosyncgetblob) | **GET** /com.atproto.sync.getBlob |  |
| [**ComAtprotoSyncGetBlocks**](ComAtprotoSyncApi.md#comatprotosyncgetblocks) | **GET** /com.atproto.sync.getBlocks |  |
| [**ComAtprotoSyncGetLatestCommit**](ComAtprotoSyncApi.md#comatprotosyncgetlatestcommit) | **GET** /com.atproto.sync.getLatestCommit |  |
| [**ComAtprotoSyncGetRecord**](ComAtprotoSyncApi.md#comatprotosyncgetrecord) | **GET** /com.atproto.sync.getRecord |  |
| [**ComAtprotoSyncGetRepo**](ComAtprotoSyncApi.md#comatprotosyncgetrepo) | **GET** /com.atproto.sync.getRepo |  |
| [**ComAtprotoSyncGetRepoStatus**](ComAtprotoSyncApi.md#comatprotosyncgetrepostatus) | **GET** /com.atproto.sync.getRepoStatus |  |
| [**ComAtprotoSyncListBlobs**](ComAtprotoSyncApi.md#comatprotosynclistblobs) | **GET** /com.atproto.sync.listBlobs |  |
| [**ComAtprotoSyncListRepos**](ComAtprotoSyncApi.md#comatprotosynclistrepos) | **GET** /com.atproto.sync.listRepos |  |
| [**ComAtprotoSyncNotifyOfUpdate**](ComAtprotoSyncApi.md#comatprotosyncnotifyofupdate) | **POST** /com.atproto.sync.notifyOfUpdate |  |
| [**ComAtprotoSyncRequestCrawl**](ComAtprotoSyncApi.md#comatprotosyncrequestcrawl) | **POST** /com.atproto.sync.requestCrawl |  |

<a id="comatprotosyncgetblob"></a>
# **ComAtprotoSyncGetBlob**
> void ComAtprotoSyncGetBlob (string did, string cid)



Get a blob associated with a given account. Returns the full blob as originally uploaded. Does not require auth; implemented by PDS.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoSyncGetBlobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            var apiInstance = new ComAtprotoSyncApi(config);
            var did = "did_example";  // string | The DID of the account.
            var cid = "cid_example";  // string | The CID of the blob to fetch

            try
            {
                apiInstance.ComAtprotoSyncGetBlob(did, cid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoSyncApi.ComAtprotoSyncGetBlob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoSyncGetBlobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoSyncGetBlobWithHttpInfo(did, cid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoSyncApi.ComAtprotoSyncGetBlobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **did** | **string** | The DID of the account. |  |
| **cid** | **string** | The CID of the blob to fetch |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotosyncgetblocks"></a>
# **ComAtprotoSyncGetBlocks**
> void ComAtprotoSyncGetBlocks (string did, List<string> cids)



Get data blocks from a given repo, by CID. For example, intermediate MST nodes, or records. Does not require auth; implemented by PDS.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoSyncGetBlocksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoSyncApi(config);
            var did = "did_example";  // string | The DID of the repo.
            var cids = new List<string>(); // List<string> | 

            try
            {
                apiInstance.ComAtprotoSyncGetBlocks(did, cids);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoSyncApi.ComAtprotoSyncGetBlocks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoSyncGetBlocksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoSyncGetBlocksWithHttpInfo(did, cids);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoSyncApi.ComAtprotoSyncGetBlocksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **did** | **string** | The DID of the repo. |  |
| **cids** | [**List&lt;string&gt;**](string.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.ipld.car, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotosyncgetlatestcommit"></a>
# **ComAtprotoSyncGetLatestCommit**
> ComAtprotoSyncGetLatestCommit200Response ComAtprotoSyncGetLatestCommit (string did)



Get the current commit CID & revision of the specified repo. Does not require auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoSyncGetLatestCommitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoSyncApi(config);
            var did = "did_example";  // string | The DID of the repo.

            try
            {
                ComAtprotoSyncGetLatestCommit200Response result = apiInstance.ComAtprotoSyncGetLatestCommit(did);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoSyncApi.ComAtprotoSyncGetLatestCommit: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoSyncGetLatestCommitWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoSyncGetLatestCommit200Response> response = apiInstance.ComAtprotoSyncGetLatestCommitWithHttpInfo(did);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoSyncApi.ComAtprotoSyncGetLatestCommitWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **did** | **string** | The DID of the repo. |  |

### Return type

[**ComAtprotoSyncGetLatestCommit200Response**](ComAtprotoSyncGetLatestCommit200Response.md)

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

<a id="comatprotosyncgetrecord"></a>
# **ComAtprotoSyncGetRecord**
> void ComAtprotoSyncGetRecord (string did, string collection, string rkey)



Get data blocks needed to prove the existence or non-existence of record in the current version of repo. Does not require auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoSyncGetRecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoSyncApi(config);
            var did = "did_example";  // string | The DID of the repo.
            var collection = "collection_example";  // string | 
            var rkey = "rkey_example";  // string | Record Key

            try
            {
                apiInstance.ComAtprotoSyncGetRecord(did, collection, rkey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoSyncApi.ComAtprotoSyncGetRecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoSyncGetRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoSyncGetRecordWithHttpInfo(did, collection, rkey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoSyncApi.ComAtprotoSyncGetRecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **did** | **string** | The DID of the repo. |  |
| **collection** | **string** |  |  |
| **rkey** | **string** | Record Key |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.ipld.car, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotosyncgetrepo"></a>
# **ComAtprotoSyncGetRepo**
> void ComAtprotoSyncGetRepo (string did, string? since = null)



Download a repository export as CAR file. Optionally only a 'diff' since a previous revision. Does not require auth; implemented by PDS.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoSyncGetRepoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoSyncApi(config);
            var did = "did_example";  // string | The DID of the repo.
            var since = "since_example";  // string? | The revision ('rev') of the repo to create a diff from. (optional) 

            try
            {
                apiInstance.ComAtprotoSyncGetRepo(did, since);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoSyncApi.ComAtprotoSyncGetRepo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoSyncGetRepoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoSyncGetRepoWithHttpInfo(did, since);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoSyncApi.ComAtprotoSyncGetRepoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **did** | **string** | The DID of the repo. |  |
| **since** | **string?** | The revision (&#39;rev&#39;) of the repo to create a diff from. | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.ipld.car, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="comatprotosyncgetrepostatus"></a>
# **ComAtprotoSyncGetRepoStatus**
> ComAtprotoSyncGetRepoStatus200Response ComAtprotoSyncGetRepoStatus (string did)



Get the hosting status for a repository, on this server. Expected to be implemented by PDS and Relay.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoSyncGetRepoStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoSyncApi(config);
            var did = "did_example";  // string | The DID of the repo.

            try
            {
                ComAtprotoSyncGetRepoStatus200Response result = apiInstance.ComAtprotoSyncGetRepoStatus(did);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoSyncApi.ComAtprotoSyncGetRepoStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoSyncGetRepoStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoSyncGetRepoStatus200Response> response = apiInstance.ComAtprotoSyncGetRepoStatusWithHttpInfo(did);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoSyncApi.ComAtprotoSyncGetRepoStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **did** | **string** | The DID of the repo. |  |

### Return type

[**ComAtprotoSyncGetRepoStatus200Response**](ComAtprotoSyncGetRepoStatus200Response.md)

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

<a id="comatprotosynclistblobs"></a>
# **ComAtprotoSyncListBlobs**
> ComAtprotoSyncListBlobs200Response ComAtprotoSyncListBlobs (string did, string? since = null, int? limit = null, string? cursor = null)



List blob CIDs for an account, since some repo revision. Does not require auth; implemented by PDS.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoSyncListBlobsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoSyncApi(config);
            var did = "did_example";  // string | The DID of the repo.
            var since = "since_example";  // string? | Optional revision of the repo to list blobs since. (optional) 
            var limit = 500;  // int? |  (optional)  (default to 500)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                ComAtprotoSyncListBlobs200Response result = apiInstance.ComAtprotoSyncListBlobs(did, since, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoSyncApi.ComAtprotoSyncListBlobs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoSyncListBlobsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoSyncListBlobs200Response> response = apiInstance.ComAtprotoSyncListBlobsWithHttpInfo(did, since, limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoSyncApi.ComAtprotoSyncListBlobsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **did** | **string** | The DID of the repo. |  |
| **since** | **string?** | Optional revision of the repo to list blobs since. | [optional]  |
| **limit** | **int?** |  | [optional] [default to 500] |
| **cursor** | **string?** |  | [optional]  |

### Return type

[**ComAtprotoSyncListBlobs200Response**](ComAtprotoSyncListBlobs200Response.md)

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

<a id="comatprotosynclistrepos"></a>
# **ComAtprotoSyncListRepos**
> ComAtprotoSyncListRepos200Response ComAtprotoSyncListRepos (int? limit = null, string? cursor = null)



Enumerates all the DID, rev, and commit CID for all repos hosted by this service. Does not require auth; implemented by PDS and Relay.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoSyncListReposExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoSyncApi(config);
            var limit = 500;  // int? |  (optional)  (default to 500)
            var cursor = "cursor_example";  // string? |  (optional) 

            try
            {
                ComAtprotoSyncListRepos200Response result = apiInstance.ComAtprotoSyncListRepos(limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoSyncApi.ComAtprotoSyncListRepos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoSyncListReposWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ComAtprotoSyncListRepos200Response> response = apiInstance.ComAtprotoSyncListReposWithHttpInfo(limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoSyncApi.ComAtprotoSyncListReposWithHttpInfo: " + e.Message);
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

[**ComAtprotoSyncListRepos200Response**](ComAtprotoSyncListRepos200Response.md)

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

<a id="comatprotosyncnotifyofupdate"></a>
# **ComAtprotoSyncNotifyOfUpdate**
> void ComAtprotoSyncNotifyOfUpdate (ComAtprotoSyncNotifyOfUpdateRequest comAtprotoSyncNotifyOfUpdateRequest)



Notify a crawling service of a recent update, and that crawling should resume. Intended use is after a gap between repo stream events caused the crawling service to disconnect. Does not require auth; implemented by Relay.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoSyncNotifyOfUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoSyncApi(config);
            var comAtprotoSyncNotifyOfUpdateRequest = new ComAtprotoSyncNotifyOfUpdateRequest(); // ComAtprotoSyncNotifyOfUpdateRequest | 

            try
            {
                apiInstance.ComAtprotoSyncNotifyOfUpdate(comAtprotoSyncNotifyOfUpdateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoSyncApi.ComAtprotoSyncNotifyOfUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoSyncNotifyOfUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoSyncNotifyOfUpdateWithHttpInfo(comAtprotoSyncNotifyOfUpdateRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoSyncApi.ComAtprotoSyncNotifyOfUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoSyncNotifyOfUpdateRequest** | [**ComAtprotoSyncNotifyOfUpdateRequest**](ComAtprotoSyncNotifyOfUpdateRequest.md) |  |  |

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

<a id="comatprotosyncrequestcrawl"></a>
# **ComAtprotoSyncRequestCrawl**
> void ComAtprotoSyncRequestCrawl (ComAtprotoSyncRequestCrawlRequest comAtprotoSyncRequestCrawlRequest)



Request a service to persistently crawl hosted repos. Expected use is new PDS instances declaring their existence to Relays. Does not require auth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BSky.Api;
using BSky.Client;
using BSky.Model;

namespace Example
{
    public class ComAtprotoSyncRequestCrawlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://public.api.bsky.app/xrpc";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComAtprotoSyncApi(config);
            var comAtprotoSyncRequestCrawlRequest = new ComAtprotoSyncRequestCrawlRequest(); // ComAtprotoSyncRequestCrawlRequest | 

            try
            {
                apiInstance.ComAtprotoSyncRequestCrawl(comAtprotoSyncRequestCrawlRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComAtprotoSyncApi.ComAtprotoSyncRequestCrawl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ComAtprotoSyncRequestCrawlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ComAtprotoSyncRequestCrawlWithHttpInfo(comAtprotoSyncRequestCrawlRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComAtprotoSyncApi.ComAtprotoSyncRequestCrawlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **comAtprotoSyncRequestCrawlRequest** | [**ComAtprotoSyncRequestCrawlRequest**](ComAtprotoSyncRequestCrawlRequest.md) |  |  |

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

