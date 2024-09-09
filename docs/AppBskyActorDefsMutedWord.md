# BSky.Model.AppBskyActorDefsMutedWord
A word that the account owner has muted.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**Value** | **string** | The muted word itself. | 
**Targets** | [**List&lt;AppBskyActorDefsMutedWordTarget&gt;**](AppBskyActorDefsMutedWordTarget.md) |  | 
**ActorTarget** | **string** | Groups of users to apply the muted word to. If undefined, applies to all users. | [optional] [default to ActorTargetEnum.All]
**ExpiresAt** | **DateTime** | The date and time at which the muted word will expire and no longer be applied. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

