# Conekta.net.Model.WebhookResponse
webhooks model

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | id of the webhook | [optional] 
**Description** | **string** | A name or brief explanation of what this webhook is used for | [optional] 
**Livemode** | **bool** | Indicates if the webhook is in production | [optional] 
**Active** | **bool** | Indicates if the webhook is actived or not | [optional] 
**Object** | **string** | Object name, value is &#39;webhook&#39; | [optional] 
**Status** | **string** | Indicates if the webhook is ready to receive events or failing | [optional] 
**SubscribedEvents** | **List&lt;string&gt;** | lists the events that will be sent to the webhook | [optional] 
**Url** | **string** | url or endpoint of the webhook | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

