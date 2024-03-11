# Conekta.net.Model.PayoutOrderResponse
payout order model response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedPayoutMethods** | **List&lt;string&gt;** | The payout methods that are allowed for the payout order. | 
**Amount** | **int** | The amount of the payout order. | 
**CreatedAt** | **long** | The creation date of the payout order. | 
**Currency** | **string** | The currency in which the payout order is made. | [default to "MXN"]
**CustomerInfo** | [**PayoutOrderResponseCustomerInfo**](PayoutOrderResponseCustomerInfo.md) |  | 
**ExpiresAt** | **long** | The expiration date of the payout order. | [optional] 
**Id** | **string** | The id of the payout order. | 
**Livemode** | **bool** | The live mode of the payout order. | 
**VarObject** | **string** | The object of the payout order. | 
**Metadata** | **Dictionary&lt;string, Object&gt;** | The metadata of the payout order. | [optional] 
**Payouts** | [**List&lt;PayoutOrderPayoutsItem&gt;**](PayoutOrderPayoutsItem.md) | The payout information of the payout order. | 
**Reason** | **string** | The reason for the payout order. | 
**Status** | **string** | The status of the payout order. | [optional] 
**UpdatedAt** | **long** | The update date of the payout order. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

