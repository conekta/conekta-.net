# Conekta.net.Model.TransactionResponse
The Transaction object represents the actions or steps of an order. Statuses can be: unprocessed, pending, available, owen, paid_out, voided, capture, capture_reversal, liquidation, liquidation_reversal, payout, payout_reversal, refund, refund_reversal, chargeback, chargeback_reversal, rounding_adjustment, won_chargeback, transferred, and transferred.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **long** | The amount of the transaction. | 
**Charge** | **string** | Randomly assigned unique order identifier associated with the charge. | 
**CreatedAt** | **long** | Date and time of creation of the transaction in Unix format. | 
**Currency** | **string** | The currency of the transaction. It uses the 3-letter code of the [International Standard ISO 4217.](https://es.wikipedia.org/wiki/ISO_4217) | 
**Fee** | **long** | The amount to be deducted for taxes and commissions. | 
**Id** | **string** | Unique identifier of the transaction. | 
**Livemode** | **bool** | Indicates whether the transaction was created in live mode or test mode. | 
**Net** | **long** | The net amount after deducting commissions and taxes. | 
**Object** | **string** | Object name, which is transaction. | 
**Status** | **string** | Code indicating transaction status. | 
**Type** | **string** | Transaction Type | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

