# Conekta.net.Model.OrderResponse
order response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **int** | The total amount to be collected in cents | [optional] 
**AmountRefunded** | **int** | The total amount refunded in cents | [optional] 
**Channel** | [**ChargeResponseChannel**](ChargeResponseChannel.md) |  | [optional] 
**Charges** | [**OrderResponseCharges**](OrderResponseCharges.md) |  | [optional] 
**Checkout** | [**OrderResponseCheckout**](OrderResponseCheckout.md) |  | [optional] 
**CreatedAt** | **long** | The time at which the object was created in seconds since the Unix epoch | [optional] 
**Currency** | **string** | The three-letter ISO 4217 currency code. The currency of the order. | [optional] 
**CustomerInfo** | [**OrderResponseCustomerInfo**](OrderResponseCustomerInfo.md) |  | [optional] 
**DiscountLines** | [**OrderResponseDiscountLines**](OrderResponseDiscountLines.md) |  | [optional] 
**FiscalEntity** | [**OrderFiscalEntityResponse**](OrderFiscalEntityResponse.md) |  | [optional] 
**Id** | **string** |  | [optional] 
**IsRefundable** | **bool** |  | [optional] 
**LineItems** | [**OrderResponseProducts**](OrderResponseProducts.md) |  | [optional] 
**Livemode** | **bool** | Whether the object exists in live mode or test mode | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Set of key-value pairs that you can attach to an object. This can be useful for storing additional information about the object in a structured format. | [optional] 
**NextAction** | [**OrderNextActionResponse**](OrderNextActionResponse.md) |  | [optional] 
**VarObject** | **string** | String representing the object’s type. Objects of the same type share the same value. | [optional] 
**PaymentStatus** | **string** | The payment status of the order. | [optional] 
**ProcessingMode** | **string** | Indicates the processing mode for the order, either ecommerce, recurrent or validation. | [optional] 
**ShippingContact** | [**OrderResponseShippingContact**](OrderResponseShippingContact.md) |  | [optional] 
**UpdatedAt** | **long** | The time at which the object was last updated in seconds since the Unix epoch | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

