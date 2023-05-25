# Conekta.net.Model.ApiKeyCreateResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthenticationToken** | **string** | It is occupied as a user when authenticated with basic authentication, with a blank password. This value will only appear once, in the request to create a new key | [optional] 
**Active** | **bool** | Indicates if the api key is active | [optional] 
**CreatedAt** | **long** | Unix timestamp in seconds with the creation date of the api key | [optional] 
**Description** | **string** | Detail of the use that will be given to the api key | [optional] 
**Id** | **string** | Unique identifier of the api key | [optional] 
**Livemode** | **bool** | Indicates if the api key is in live mode | [optional] 
**Object** | **string** | Object name, value is api_key | [optional] 
**Prefix** | **string** | The first few characters of the authentication_token | [optional] 
**Role** | **string** | Indicates the user account private&#x3D;owner or public&#x3D;public | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

