# BSky.Model.AppBskyGraphDefsRelationship
lists the bi-directional graph relationships between one actor (not indicated in the object), and the target actors (the DID included in the object)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Did** | **string** |  | 
**Following** | **string** | if the actor follows this DID, this is the AT-URI of the follow record | [optional] 
**FollowedBy** | **string** | if the actor is followed by this DID, contains the AT-URI of the follow record | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

