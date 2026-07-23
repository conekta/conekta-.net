# Conekta.net.Model.OrderResponseCheckout

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedPaymentMethods** | **List&lt;string&gt;** | Are the payment methods available for this link | [optional] 
**ExcludedPaymentMethods** | **List&lt;OrderResponseCheckout.ExcludedPaymentMethodsEnum&gt;** | Payment methods excluded from the checkout. This field is only returned when excluded_payment_methods is provided in the request. | [optional] 
**CanNotExpire** | **bool** |  | [optional] 
**EmailsSent** | **int** |  | [optional] 
**ExcludeCardNetworks** | **List&lt;OrderResponseCheckout.ExcludeCardNetworksEnum&gt;** |  | [optional] 
**ExpiresAt** | **long** |  | [optional] 
**FailureUrl** | **string** |  | [optional] 
**Force3dsFlow** | **bool** |  | [optional] 
**ForceSaveCard** | **bool** | Indicates whether the card used for the payment should be saved for future purchases. This field is only applicable for card payments. | [optional] 
**Id** | **string** |  | 
**IsRedirectOnFailure** | **bool** |  | [optional] 
**Livemode** | **bool** |  | 
**MaxFailedRetries** | **int** | Number of retries allowed before the checkout is marked as failed | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**MonthlyInstallmentsEnabled** | **bool** |  | [optional] 
**MonthlyInstallmentsOptions** | **List&lt;int&gt;** |  | [optional] 
**Name** | **string** |  | 
**NeedsShippingContact** | **bool** |  | [optional] 
**Object** | **string** |  | 
**OnDemandEnabled** | **bool** |  | [optional] 
**PaidPaymentsCount** | **int** |  | [optional] 
**Recurrent** | **bool** |  | [optional] 
**RedirectionTime** | **int** | number of seconds to wait before redirecting to the success_url | [optional] 
**Slug** | **string** |  | [optional] 
**SmsSent** | **int** |  | [optional] 
**SuccessUrl** | **string** | Redirection url back to the site in case of successful payment, applies only to HostedPayment | [optional] 
**StartsAt** | **int** |  | [optional] 
**Status** | **string** |  | [optional] 
**Type** | **string** | This field represents the type of checkout, which determines the user experience during the payment process. &#39;HostedPayment&#39; will redirect the customer to a Conekta-hosted page to complete the payment, while &#39;Integration&#39; allows the payment process to be handled entirely on your site using Conekta&#39;s APIs and SDKs. | 
**Url** | **string** | Indicate the url of the Conekta component to complete the payment. For HostedPayment, this will be a Conekta-hosted page | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

