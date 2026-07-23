# Conekta.net.Model.Checkout
It is a sub-resource of the Order model that can be stipulated in order to configure its corresponding checkout

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedPaymentMethods** | **List&lt;string&gt;** | Those are the payment methods that will be available for the link. This field is mutually exclusive with excluded_payment_methods. | [optional] 
**ExcludedPaymentMethods** | **List&lt;Checkout.ExcludedPaymentMethodsEnum&gt;** | Payment methods to be excluded from the checkout. This field is mutually exclusive with allowed_payment_methods. | [optional] 
**ExcludeCardNetworks** | **List&lt;Checkout.ExcludeCardNetworksEnum&gt;** | List of card networks to exclude from the checkout. This field is only applicable for card payments. | [optional] 
**ExpiresAt** | **long** | It is the time when the link will expire.  It is expressed in seconds since the Unix epoch. The valid range is from 5 minutes to 365 days from the creation date.  | 
**MonthlyInstallmentsEnabled** | **bool** | This flag allows you to specify if months without interest will be active. | [optional] 
**MonthlyInstallmentsOptions** | **List&lt;int&gt;** | This field allows you to specify the number of months without interest. | [optional] 
**ThreeDsMode** | **string** | Indicates the 3DS2 mode for the order, either smart or strict. This property is only applicable when 3DS is enabled. When 3DS is disabled, this field should be null. | [optional] 
**Name** | **string** | Reason for charge | 
**NeedsShippingContact** | **bool** | This flag allows you to fill in the shipping information at checkout. | [optional] 
**OnDemandEnabled** | **bool** | This flag allows you to specify if the link will be on demand. | [optional] 
**PlanIds** | **List&lt;string&gt;** | It is a list of plan IDs that will be associated with the order. | [optional] 
**OrderTemplate** | [**CheckoutOrderTemplate**](CheckoutOrderTemplate.md) |  | 
**PaymentsLimitCount** | **int** | It is the number of payments that can be made through the link. | [optional] 
**SuccessUrl** | **string** | The URL to redirect to after a successful payment. | [optional] 
**Recurrent** | **bool** | false: single use. true: multiple payments | 
**Type** | **string** | It is the type of link that will be created. It must be a valid type. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

