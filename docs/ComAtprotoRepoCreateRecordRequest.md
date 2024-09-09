# BSky.Model.ComAtprotoRepoCreateRecordRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Repo** | **string** | The handle or DID of the repo (aka, current account). | 
**Collection** | **string** | The NSID of the record collection. | 
**Rkey** | **string** | The Record Key. | [optional] 
**Validate** | **bool** | Can be set to &#39;false&#39; to skip Lexicon schema validation of record data, &#39;true&#39; to require it, or leave unset to validate only for known Lexicons. | [optional] 
**Record** | **Object** |  | 
**SwapCommit** | **string** | Compare and swap with the previous commit by CID. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

