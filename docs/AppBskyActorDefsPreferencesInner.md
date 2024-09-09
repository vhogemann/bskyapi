# BSky.Model.AppBskyActorDefsPreferencesInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** |  | 
**LabelerDid** | **string** | Which labeler does this preference apply to? If undefined, applies globally. | [optional] 
**Label** | **string** |  | 
**Visibility** | **string** |  | 
**Pinned** | **List&lt;string&gt;** |  | 
**Saved** | **List&lt;string&gt;** |  | 
**TimelineIndex** | **int** |  | [optional] 
**Items** | **List&lt;string&gt;** |  | 
**BirthDate** | **DateTime** | The birth date of account owner. | [optional] 
**Feed** | **string** | The URI of the feed, or an identifier which describes the feed. | 
**HideReplies** | **bool** | Hide replies in the feed. | [optional] 
**HideRepliesByUnfollowed** | **bool** | Hide replies in the feed if they are not by followed users. | [optional] [default to true]
**HideRepliesByLikeCount** | **int** |  | [optional] 
**HideReposts** | **bool** | Hide reposts in the feed. | [optional] 
**HideQuotePosts** | **bool** | Hide quote posts in the feed. | [optional] 
**Sort** | **string** | Sorting mode for threads. | [optional] 
**PrioritizeFollowedUsers** | **bool** | Show followed users at the top of all replies. | [optional] 
**Tags** | **List&lt;string&gt;** |  | 
**ActiveProgressGuide** | [**AppBskyActorDefsBskyAppProgressGuide**](AppBskyActorDefsBskyAppProgressGuide.md) |  | [optional] 
**QueuedNudges** | **List&lt;string&gt;** |  | [optional] 
**Labelers** | [**List&lt;AppBskyActorDefsLabelerPrefItem&gt;**](AppBskyActorDefsLabelerPrefItem.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

