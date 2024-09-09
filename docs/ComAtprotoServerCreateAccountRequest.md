# BSky.Model.ComAtprotoServerCreateAccountRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** |  | [optional] 
**Handle** | **string** | Requested handle for the account. | 
**Did** | **string** | Pre-existing atproto DID, being imported to a new account. | [optional] 
**InviteCode** | **string** |  | [optional] 
**VerificationCode** | **string** |  | [optional] 
**VerificationPhone** | **string** |  | [optional] 
**Password** | **string** | Initial account password. May need to meet instance-specific password strength requirements. | [optional] 
**RecoveryKey** | **string** | DID PLC rotation key (aka, recovery key) to be included in PLC creation operation. | [optional] 
**PlcOp** | **Object** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

