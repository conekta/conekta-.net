# Conekta.net.Model.Customer
a customer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AntifraudInfo** | [**CustomerAntifraudInfo**](CustomerAntifraudInfo.md) |  | [optional] 
**Corporate** | **bool** | It is a value that allows identifying if the email is corporate or not. | [optional] [default to false]
**CustomReference** | **string** | It is an undefined value. | [optional] 
**DateOfBirth** | **string** | It is a parameter that allows to identify the date of birth of the client. | [optional] 
**Email** | **string** | An email address is a series of customizable characters followed by a universal Internet symbol, the at symbol (@), the name of a host server, and a web domain ending (.mx, .com, .org, . net, etc). | 
**DefaultPaymentSourceId** | **string** | It is a parameter that allows to identify in the response, the Conekta ID of a payment method (payment_id) | [optional] 
**DefaultShippingContactId** | **string** | It is a parameter that allows to identify in the response, the Conekta ID of the shipping address (shipping_contact) | [optional] 
**FiscalEntities** | [**List&lt;CustomerFiscalEntitiesRequest&gt;**](CustomerFiscalEntitiesRequest.md) |  | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Name** | **string** | Client&#39;s name | 
**NationalId** | **string** | It is a parameter that allows to identify the national identification number of the client. | [optional] 
**PaymentSources** | [**List&lt;CustomerPaymentMethodsRequest&gt;**](CustomerPaymentMethodsRequest.md) | Contains details of the payment methods that the customer has active or has used in Conekta | [optional] 
**Phone** | **string** | Is the customer&#39;s phone number | 
**PlanId** | **string** | Contains the ID of a plan, which could together with name, email and phone create a client directly to a subscription | [optional] 
**ShippingContacts** | [**List&lt;CustomerShippingContacts&gt;**](CustomerShippingContacts.md) | Contains the detail of the shipping addresses that the client has active or has used in Conekta | [optional] 
**Subscription** | [**SubscriptionRequest**](SubscriptionRequest.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

