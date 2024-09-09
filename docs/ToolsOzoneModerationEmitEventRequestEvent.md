# BSky.Model.ToolsOzoneModerationEmitEventRequestEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Comment** | **string** | Additional comment about added/removed tags. | 
**DurationInHours** | **int** |  | 
**Sticky** | **bool** | Make the comment persistent on the subject | [optional] 
**CreateLabelVals** | **List&lt;string&gt;** |  | 
**NegateLabelVals** | **List&lt;string&gt;** |  | 
**IsReporterMuted** | **bool** | Set to true if the reporter was muted from reporting at the time of the event. These reports won&#39;t impact the reviewState of the subject. | [optional] 
**ReportType** | [**ComAtprotoModerationDefsReasonType**](ComAtprotoModerationDefsReasonType.md) |  | 
**SubjectLine** | **string** | The subject line of the email sent to the user. | 
**Content** | **string** | The content of the email sent to the user. | [optional] 
**Add** | **List&lt;string&gt;** |  | 
**Remove** | **List&lt;string&gt;** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

