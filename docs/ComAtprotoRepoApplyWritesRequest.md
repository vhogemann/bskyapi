# BSky.Model.ComAtprotoRepoApplyWritesRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Repo** | **string** | The handle or DID of the repo (aka, current account). | 
**Validate** | **bool** | Can be set to &#39;false&#39; to skip Lexicon schema validation of record data across all operations, &#39;true&#39; to require it, or leave unset to validate only for known Lexicons. | [optional] 
**Writes** | [**List&lt;ComAtprotoRepoApplyWritesRequestWritesInner&gt;**](ComAtprotoRepoApplyWritesRequestWritesInner.md) |  | 
**SwapCommit** | **string** | If provided, the entire operation will fail if the current repo commit CID does not match this value. Used to prevent conflicting repo mutations. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

