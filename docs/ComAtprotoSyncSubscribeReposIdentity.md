# BSky.Model.ComAtprotoSyncSubscribeReposIdentity
Represents a change to an account's identity. Could be an updated handle, signing key, or pds hosting endpoint. Serves as a prod to all downstream services to refresh their identity cache.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Seq** | **int** |  | 
**Did** | **string** |  | 
**Time** | **DateTime** |  | 
**Handle** | **string** | The current handle for the account, or &#39;handle.invalid&#39; if validation fails. This field is optional, might have been validated or passed-through from an upstream source. Semantics and behaviors for PDS vs Relay may evolve in the future; see atproto specs for more details. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

