# Conekta.net.Model.CheckoutResponse
checkout response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedPaymentMethods** | **List&lt;string&gt;** | Are the payment methods available for this link | [optional] 
**ExcludedPaymentMethods** | **List&lt;CheckoutResponse.ExcludedPaymentMethodsEnum&gt;** | Payment methods excluded from the checkout. This field is only returned when excluded_payment_methods is provided in the request. | [optional] 
**PlanIds** | **List&lt;string&gt;** | List of plan IDs that are available for subscription | [optional] 
**CanNotExpire** | **bool** |  | [optional] 
**EmailsSent** | **int** |  | [optional] 
**ExcludeCardNetworks** | **List&lt;CheckoutResponse.ExcludeCardNetworksEnum&gt;** |  | [optional] 
**ExpiresAt** | **long** |  | [optional] 
**FailureUrl** | **string** |  | [optional] 
**Force3dsFlow** | **bool** |  | [optional] 
**Id** | **string** |  | 
**Livemode** | **bool** |  | 
**Metadata** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**MonthlyInstallmentsEnabled** | **bool** |  | [optional] 
**MonthlyInstallmentsOptions** | **List&lt;int&gt;** |  | [optional] 
**Name** | **string** | Reason for charge | 
**NeedsShippingContact** | **bool** |  | [optional] 
**Object** | **string** |  | 
**PaidPaymentsCount** | **int** |  | [optional] 
**PaymentsLimitCount** | **int** |  | [optional] 
**Recurrent** | **bool** |  | [optional] 
**Slug** | **string** |  | [optional] 
**SmsSent** | **int** |  | [optional] 
**StartsAt** | **int** |  | [optional] 
**Status** | **string** |  | [optional] 
**SuccessUrl** | **string** | The URL to redirect to after a successful payment. | [optional] 
**Type** | **string** |  | [optional] 
**Url** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

