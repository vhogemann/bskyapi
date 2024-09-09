# BSky.Model.ComAtprotoLabelDefsLabel
Metadata tag on an atproto resource (eg, repo or record).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ver** | **int** |  | [optional] 
**Src** | **string** | DID of the actor who created this label. | 
**Uri** | **string** | AT URI of the record, repository (account), or other resource that this label applies to. | 
**Cid** | **string** | Optionally, CID specifying the specific version of &#39;uri&#39; resource this label applies to. | [optional] 
**Val** | **string** | The short string name of the value or type of this label. | 
**Neg** | **bool** | If true, this is a negation label, overwriting a previous label. | [optional] 
**Cts** | **DateTime** | Timestamp when this label was created. | 
**Exp** | **DateTime** | Timestamp at which this label expires (no longer applies). | [optional] 
**Sig** | **byte[]** | Signature of dag-cbor encoded label. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

