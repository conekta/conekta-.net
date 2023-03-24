# Conekta.net.Model.OrderUpdateRequest
a order

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Charges** | [**List&lt;ChargeRequest&gt;**](ChargeRequest.md) |  | [optional] 
**Checkout** | [**CheckoutRequest**](CheckoutRequest.md) |  | [optional] 
**Currency** | **string** | Currency with which the payment will be made. It uses the 3-letter code of the [International Standard ISO 4217.](https://es.wikipedia.org/wiki/ISO_4217) | [optional] 
**CustomerInfo** | [**OrderRequestCustomerInfo**](OrderRequestCustomerInfo.md) |  | [optional] 
**DiscountLines** | [**List&lt;OrderDiscountLinesRequest&gt;**](OrderDiscountLinesRequest.md) |  | [optional] 
**LineItems** | [**List&lt;LineItems&gt;**](LineItems.md) |  | [optional] 
**Metadata** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**PreAuthorize** | **bool** | Indicates whether the order charges must be preauthorized | [optional] [default to false]
**ShippingContact** | [**CustomerShippingContacts**](CustomerShippingContacts.md) |  | [optional] 
**ShippingLines** | [**List&lt;ShippingLinesRequest&gt;**](ShippingLinesRequest.md) |  | [optional] 
**TaxLines** | [**List&lt;OrderTaxLinesRequest&gt;**](OrderTaxLinesRequest.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

