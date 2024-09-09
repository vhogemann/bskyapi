# BSky.Model.ComAtprotoSyncSubscribeReposCommit
Represents an update of repository state. Note that empty commits are allowed, which include no repo data changes, but an update to rev and signature.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Seq** | **int** |  | 
**TooBig** | **bool** | Indicates that this commit contained too many ops, or data size was too large. Consumers will need to make a separate request to get missing data. | 
**Repo** | **string** | The repo this event comes from. | 
**Commit** | **string** |  | 
**Rev** | **string** | The rev of the emitted commit. Note that this information is also in the commit object included in blocks, unless this is a tooBig event. | 
**Since** | **string** | The rev of the last emitted commit from this repo (if any). | 
**Blocks** | **byte[]** | CAR file containing relevant blocks, as a diff since the previous repo state. | 
**Ops** | [**List&lt;ComAtprotoSyncSubscribeReposRepoOp&gt;**](ComAtprotoSyncSubscribeReposRepoOp.md) |  | 
**Blobs** | **List&lt;string&gt;** |  | 
**Time** | **DateTime** | Timestamp of when this message was originally broadcast. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

