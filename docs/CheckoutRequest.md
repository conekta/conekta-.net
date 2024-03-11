# Conekta.net.Model.CheckoutRequest
[Checkout](https://developers.conekta.com/v2.1.0/reference/payment-link) details 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedPaymentMethods** | **List&lt;string&gt;** | Are the payment methods available for this link | 
**ExpiresAt** | **long** | Unix timestamp of checkout expiration | [optional] 
**FailureUrl** | **string** | Redirection url back to the site in case of failed payment, applies only to HostedPayment. | [optional] 
**MonthlyInstallmentsEnabled** | **bool** |  | [optional] 
**MonthlyInstallmentsOptions** | **List&lt;int&gt;** |  | [optional] 
**Name** | **string** | Reason for payment | [optional] 
**OnDemandEnabled** | **bool** |  | [optional] 
**RedirectionTime** | **int** | number of seconds to wait before redirecting to the success_url | [optional] 
**SuccessUrl** | **string** | Redirection url back to the site in case of successful payment, applies only to HostedPayment | [optional] 
**Type** | **string** | This field represents the type of checkout | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

