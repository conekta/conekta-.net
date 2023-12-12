# Conekta.net.Model.TransferResponse
A transfer represents the action of sending an amount to a business bank account including the status, amount and method used to make the transfer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **long** | Amount in cents of the transfer. | [optional] 
**CreatedAt** | **long** | Date and time of creation of the transfer in Unix format. | [optional] 
**Currency** | **string** | The currency of the transfer. It uses the 3-letter code of the [International Standard ISO 4217.](https://es.wikipedia.org/wiki/ISO_4217) | [optional] 
**Id** | **string** | Unique identifier of the transfer. | [optional] 
**Livemode** | **bool** | Indicates whether the transfer was created in live mode or test mode. | [optional] 
**Destination** | [**TransferDestinationResponse**](TransferDestinationResponse.md) |  | [optional] 
**VarObject** | **string** | Object name, which is transfer. | [optional] 
**StatementDescription** | **string** | Description of the transfer. | [optional] 
**StatementReference** | **string** | Reference number of the transfer. | [optional] 
**Status** | **string** | Code indicating transfer status. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

