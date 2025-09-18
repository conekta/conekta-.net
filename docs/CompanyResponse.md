# Conekta.net.Model.CompanyResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier for the company. | 
**Name** | **string** | The name of the company. | 
**Active** | **bool** | Indicates if the company is active. | 
**AccountStatus** | **string** | The current status of the company&#39;s account. | 
**ParentCompanyId** | **string** | The identifier of the parent company, if any. | [optional] 
**OnboardingStatus** | **string** | The current status of the company&#39;s onboarding process. | 
**Documents** | [**List&lt;CompanyResponseDocumentsInner&gt;**](CompanyResponseDocumentsInner.md) | A list of documents related to the company. | 
**CreatedAt** | **long** | Timestamp of when the company was created. | 
**Object** | **string** | The type of object, typically \&quot;company\&quot;. | 
**ThreeDsEnabled** | **bool** | Indicates if 3DS authentication is enabled for the company. | [optional] 
**ThreeDsMode** | **string** | The 3DS mode for the company, either &#39;smart&#39; or &#39;strict&#39;. This property is only applicable when three_ds_enabled is true. When three_ds_enabled is false, this field will be null. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

