# Conekta.net.Model.TokenResponseCheckout

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedPaymentMethods** | **List&lt;string&gt;** |  | [optional] 
**CanNotExpire** | **bool** | Indicates if the checkout can not expire. | [optional] 
**EmailsSent** | **int** |  | [optional] 
**ExcludeCardNetworks** | **List&lt;string&gt;** |  | [optional] 
**ExpiresAt** | **long** | Date and time when the checkout expires. | [optional] 
**FailureUrl** | **string** | URL to redirect the customer to if the payment process fails. | [optional] 
**Force3dsFlow** | **bool** | Indicates if the checkout forces the 3DS flow. | [optional] 
**Id** | **string** |  | [optional] 
**Livemode** | **bool** |  | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**MonthlyInstallmentsEnabled** | **bool** | Indicates if the checkout allows monthly installments. | [optional] 
**MonthlyInstallmentsOptions** | **List&lt;int&gt;** | List of monthly installments options. | [optional] 
**Name** | **string** |  | [optional] 
**NeedsShippingContact** | **bool** |  | [optional] 
**VarObject** | **string** | Indicates the type of object, in this case checkout. | [optional] 
**OnDemandEnabled** | **bool** | Indicates if the checkout allows on demand payments. | [optional] 
**PaidPaymentsCount** | **int** | Number of payments that have been paid. | [optional] 
**Recurrent** | **bool** | Indicates if the checkout is recurrent. | [optional] 
**SmsSent** | **int** |  | [optional] 
**StartsAt** | **long** | Date and time when the checkout starts. | [optional] 
**Status** | **string** | Status of the checkout. | [optional] 
**SuccessUrl** | **string** | URL to redirect the customer to after the payment process is completed. | [optional] 
**Type** | **string** | Type of checkout. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

