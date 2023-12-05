# Conekta.net.Model.CustomerResponse
customer response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AntifraudInfo** | [**CustomerAntifraudInfoResponse**](CustomerAntifraudInfoResponse.md) |  | [optional] 
**Corporate** | **bool** | true if the customer is a company | [optional] 
**CreatedAt** | **long** | Creation date of the object | 
**CustomReference** | **string** | Custom reference | [optional] 
**DefaultFiscalEntityId** | **string** |  | [optional] 
**DefaultShippingContactId** | **string** |  | [optional] 
**DefaultPaymentSourceId** | **string** |  | [optional] 
**Email** | **string** |  | [optional] 
**FiscalEntities** | [**CustomerFiscalEntitiesResponse**](CustomerFiscalEntitiesResponse.md) |  | [optional] 
**Id** | **string** | Customer&#39;s ID | 
**Livemode** | **bool** | true if the object exists in live mode or the value false if the object exists in test mode | 
**Name** | **string** | Customer&#39;s name | 
**Metadata** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Object** | **string** |  | 
**PaymentSources** | [**CustomerPaymentMethodsResponse**](CustomerPaymentMethodsResponse.md) |  | [optional] 
**Phone** | **string** | Customer&#39;s phone number | [optional] 
**ShippingContacts** | [**CustomerResponseShippingContacts**](CustomerResponseShippingContacts.md) |  | [optional] 
**Subscription** | [**SubscriptionResponse**](SubscriptionResponse.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

