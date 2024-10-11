# Conekta.net.Model.PaymentMethodGeneralRequest
Payment method used in the charge. Go to the [payment methods](https://developers.conekta.com/reference/m%C3%A9todos-de-pago) section for more details 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExpiresAt** | **long** | Method expiration date as unix timestamp | [optional] 
**MonthlyInstallments** | **int** | How many months without interest to apply, it can be 3, 6, 9, 12 or 18 | [optional] 
**Type** | **string** | Type of payment method | 
**TokenId** | **string** |  | [optional] 
**PaymentSourceId** | **string** |  | [optional] 
**Cvc** | **string** | Optional, It is a value that allows identifying the security code of the card. Only for PCI merchants | [optional] 
**ContractId** | **string** | Optional id sent to indicate the bank contract for recurrent card charges. | [optional] 
**CustomerIpAddress** | **string** | Optional field used to capture the customer&#39;s IP address for fraud prevention and security monitoring purposes | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

