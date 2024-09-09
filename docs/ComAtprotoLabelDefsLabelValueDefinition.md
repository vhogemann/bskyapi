# BSky.Model.ComAtprotoLabelDefsLabelValueDefinition
Declares a label value and its expected interpretations and behaviors.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifier** | **string** | The value of the label being defined. Must only include lowercase ascii and the &#39;-&#39; character ([a-z-]+). | 
**Severity** | **string** | How should a client visually convey this label? &#39;inform&#39; means neutral and informational; &#39;alert&#39; means negative and warning; &#39;none&#39; means show nothing. | 
**Blurs** | **string** | What should this label hide in the UI, if applied? &#39;content&#39; hides all of the target; &#39;media&#39; hides the images/video/audio; &#39;none&#39; hides nothing. | 
**DefaultSetting** | **string** | The default setting for this label. | [optional] [default to DefaultSettingEnum.Warn]
**AdultOnly** | **bool** | Does the user need to have adult content enabled in order to configure this label? | [optional] 
**Locales** | [**List&lt;ComAtprotoLabelDefsLabelValueDefinitionStrings&gt;**](ComAtprotoLabelDefsLabelValueDefinitionStrings.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

