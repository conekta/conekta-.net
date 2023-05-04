# Conekta.net.Model.CustomerShippingContacts
[Shipping](https://developers.conekta.com/v2.1.0/reference/createcustomershippingcontacts) details, required in case of sending a shipping. If we do not receive a shipping_contact on the order, the default shipping_contact of the customer will be used.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Phone** | **string** | Phone contact | [optional] 
**Receiver** | **string** | Name of the person who will receive the order | [optional] 
**BetweenStreets** | **string** | The street names between which the order will be delivered. | [optional] 
**Address** | [**CustomerShippingContactsAddress**](CustomerShippingContactsAddress.md) |  | 
**ParentId** | **string** |  | [optional] 
**Default** | **bool?** |  | [optional] 
**Deleted** | **bool?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

