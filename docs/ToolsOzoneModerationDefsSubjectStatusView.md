# BSky.Model.ToolsOzoneModerationDefsSubjectStatusView

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | 
**Subject** | [**ComAtprotoModerationCreateReportRequestSubject**](ComAtprotoModerationCreateReportRequestSubject.md) |  | 
**SubjectBlobCids** | **List&lt;string&gt;** |  | [optional] 
**SubjectRepoHandle** | **string** |  | [optional] 
**UpdatedAt** | **DateTime** | Timestamp referencing when the last update was made to the moderation status of the subject | 
**CreatedAt** | **DateTime** | Timestamp referencing the first moderation status impacting event was emitted on the subject | 
**ReviewState** | **ToolsOzoneModerationDefsSubjectReviewState** |  | 
**Comment** | **string** | Sticky comment on the subject. | [optional] 
**MuteUntil** | **DateTime** |  | [optional] 
**MuteReportingUntil** | **DateTime** |  | [optional] 
**LastReviewedBy** | **string** |  | [optional] 
**LastReviewedAt** | **DateTime** |  | [optional] 
**LastReportedAt** | **DateTime** |  | [optional] 
**LastAppealedAt** | **DateTime** | Timestamp referencing when the author of the subject appealed a moderation action | [optional] 
**Takendown** | **bool** |  | [optional] 
**Appealed** | **bool** | True indicates that the a previously taken moderator action was appealed against, by the author of the content. False indicates last appeal was resolved by moderators. | [optional] 
**SuspendUntil** | **DateTime** |  | [optional] 
**Tags** | **List&lt;string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

