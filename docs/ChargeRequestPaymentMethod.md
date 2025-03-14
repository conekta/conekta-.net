# Conekta.net.Model.ChargeRequestPaymentMethod

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of payment method | 
**CancelUrl** | **string** | URL to redirect the customer after a canceled payment | 
**CanNotExpire** | **bool** | Indicates if the payment method can not expire | 
**FailureUrl** | **string** | URL to redirect the customer after a failed payment | 
**ProductType** | **string** | Product type of the payment method, use for the payment method to know the product type | 
**SuccessUrl** | **string** | URL to redirect the customer after a successful payment | 
**Cvc** | **string** | Optional, It is a value that allows identifying the security code of the card. Only for PCI merchants | 
**ExpMonth** | **string** | Card expiration month | 
**ExpYear** | **string** | Card expiration year | 
**Name** | **string** | Cardholder name | 
**Number** | **string** | Card number | 
**CustomerIpAddress** | **string** | Optional field used to capture the customer&#39;s IP address for fraud prevention and security monitoring purposes | [optional] 
**ExpiresAt** | **long** | Method expiration date as unix timestamp | [optional] 
**MonthlyInstallments** | **int** | How many months without interest to apply, it can be 3, 6, 9, 12 or 18 | [optional] 
**TokenId** | **string** |  | [optional] 
**PaymentSourceId** | **string** |  | [optional] 
**ContractId** | **string** | Optional id sent to indicate the bank contract for recurrent card charges. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

