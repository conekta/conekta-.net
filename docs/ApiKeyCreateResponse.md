# Conekta.net.Model.ApiKeyCreateResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool** | Indicates if the api key is active | [optional] 
**CreatedAt** | **long** | Unix timestamp in seconds of when the api key was created | [optional] 
**UpdatedAt** | **long** | Unix timestamp in seconds of when the api key was last updated | [optional] 
**DeactivatedAt** | **long?** | Unix timestamp in seconds of when the api key was deleted | [optional] 
**Description** | **string** | A name or brief explanation of what this api key is used for | [optional] 
**Id** | **string** | Unique identifier of the api key | [optional] 
**Livemode** | **bool** | Indicates if the api key is in production | [optional] 
**Deleted** | **bool** | Indicates if the api key was deleted | [optional] 
**Object** | **string** | Object name, value is &#39;api_key&#39; | [optional] 
**Prefix** | **string** | The first few characters of the authentication_token | [optional] 
**Role** | **string** | Indicates if the api key is private or public | [optional] 
**AuthenticationToken** | **string** | It is occupied as a user when authenticated with basic authentication, with a blank password. This value will only appear once, in the request to create a new key. Copy and save it in a safe place. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

