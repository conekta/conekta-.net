# Conekta.net.Model.Checkout
It is a sub-resource of the Order model that can be stipulated in order to configure its corresponding checkout

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedPaymentMethods** | **List&lt;string&gt;** | Those are the payment methods that will be available for the link | 
**ExpiresAt** | **long** | It is the time when the link will expire. It is expressed in seconds since the Unix epoch. The valid range is from 2 to 365 days (the valid range will be taken from the next day of the creation date at 00:01 hrs)  | 
**MonthlyInstallmentsEnabled** | **bool** | This flag allows you to specify if months without interest will be active. | [optional] 
**MonthlyInstallmentsOptions** | **List&lt;int&gt;** | This field allows you to specify the number of months without interest. | [optional] 
**Name** | **string** | Reason for charge | 
**NeedsShippingContact** | **bool** | This flag allows you to fill in the shipping information at checkout. | [optional] 
**OnDemandEnabled** | **bool?** |  | [optional] 
**OrderTemplate** | [**CheckoutOrderTemplate**](CheckoutOrderTemplate.md) |  | 
**PaymentsLimitCount** | **int** |  | [optional] 
**Recurrent** | **bool** | false: single use. true: multiple payments | 
**Type** | **string** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

