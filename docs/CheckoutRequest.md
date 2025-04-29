# Conekta.net.Model.CheckoutRequest
[Checkout](https://developers.conekta.com/v2.2.0/reference/payment-link) details 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedPaymentMethods** | **List&lt;CheckoutRequest.AllowedPaymentMethodsEnum&gt;** | Are the payment methods available for this link. For subscriptions, only &#39;card&#39; is allowed due to the recurring nature of the payments. | 
**PlanIds** | **List&lt;string&gt;** | List of plan IDs that will be available for subscription. This field is required for subscription payments. | [optional] 
**ExpiresAt** | **long** | Unix timestamp of checkout expiration | [optional] 
**FailureUrl** | **string** | Redirection url back to the site in case of failed payment, applies only to HostedPayment. | [optional] 
**MonthlyInstallmentsEnabled** | **bool** |  | [optional] 
**MonthlyInstallmentsOptions** | **List&lt;int&gt;** |  | [optional] 
**MaxFailedRetries** | **int** | Number of retries allowed before the checkout is marked as failed | [optional] 
**Name** | **string** | Reason for payment | [optional] 
**OnDemandEnabled** | **bool** |  | [optional] 
**RedirectionTime** | **int** | number of seconds to wait before redirecting to the success_url | [optional] 
**SuccessUrl** | **string** | Redirection url back to the site in case of successful payment, applies only to HostedPayment | [optional] 
**Type** | **string** | This field represents the type of checkout | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

