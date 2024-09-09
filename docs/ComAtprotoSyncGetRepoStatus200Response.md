# BSky.Model.ComAtprotoSyncGetRepoStatus200Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Did** | **string** |  | 
**Active** | **bool** |  | 
**Status** | **string** | If active&#x3D;false, this optional field indicates a possible reason for why the account is not active. If active&#x3D;false and no status is supplied, then the host makes no claim for why the repository is no longer being hosted. | [optional] 
**Rev** | **string** | Optional field, the current rev of the repo, if active&#x3D;true | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

