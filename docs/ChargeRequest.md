# Conekta.net.Model.ChargeRequest
The charges to be made

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **int** |  | [optional] 
**ExpiresAt** | **long** | Method expiration date as unix timestamp | [optional] 
**MonthlyInstallments** | **int** | How many months without interest to apply, it can be 3, 6, 9, 12 or 18 | [optional] 
**PaymentMethod** | [**ChargeRequestPaymentMethod**](ChargeRequestPaymentMethod.md) |  | 
**ReferenceId** | **string** | Custom reference to add to the charge | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

