# BSky.Model.ComAtprotoSyncSubscribeReposAccount
Represents a change to an account's status on a host (eg, PDS or Relay). The semantics of this event are that the status is at the host which emitted the event, not necessarily that at the currently active PDS. Eg, a Relay takedown would emit a takedown with active=false, even if the PDS is still active.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Seq** | **int** |  | 
**Did** | **string** |  | 
**Time** | **DateTime** |  | 
**Active** | **bool** | Indicates that the account has a repository which can be fetched from the host that emitted this event. | 
**Status** | **string** | If active&#x3D;false, this optional field indicates a reason for why the account is not active. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

