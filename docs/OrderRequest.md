# Conekta.net.Model.OrderRequest
a order

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Charges** | [**List&lt;ChargeRequest&gt;**](ChargeRequest.md) | List of [charges](https://developers.conekta.com/v2.1.0/reference/orderscreatecharge) that are applied to the order | [optional] 
**Checkout** | [**CheckoutRequest**](CheckoutRequest.md) |  | [optional] 
**Currency** | **string** | Currency with which the payment will be made. It uses the 3-letter code of the [International Standard ISO 4217.](https://es.wikipedia.org/wiki/ISO_4217) | 
**CustomerInfo** | [**OrderRequestCustomerInfo**](OrderRequestCustomerInfo.md) |  | 
**DiscountLines** | [**List&lt;OrderDiscountLinesRequest&gt;**](OrderDiscountLinesRequest.md) | List of [discounts](https://developers.conekta.com/v2.1.0/reference/orderscreatediscountline) that are applied to the order. You must have at least one discount. | [optional] 
**FiscalEntity** | [**OrderFiscalEntityRequest**](OrderFiscalEntityRequest.md) |  | [optional] 
**LineItems** | [**List&lt;Product&gt;**](Product.md) | List of [products](https://developers.conekta.com/v2.1.0/reference/orderscreateproduct) that are sold in the order. You must have at least one product. | 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Metadata associated with the order | [optional] 
**NeedsShippingContact** | **bool** | Allows you to fill out the shipping information at checkout | [optional] 
**PreAuthorize** | **bool** | Indicates whether the order charges must be preauthorized | [optional] [default to false]
**ProcessingMode** | **string** | Indicates the processing mode for the order, either ecommerce, recurrent or validation. | [optional] 
**ReturnUrl** | **string** | Indicates the redirection callback upon completion of the 3DS2 flow. Do not use this parameter if your order has a checkout parameter | [optional] 
**ShippingContact** | [**CustomerShippingContacts**](CustomerShippingContacts.md) |  | [optional] 
**ShippingLines** | [**List&lt;ShippingRequest&gt;**](ShippingRequest.md) | List of [shipping costs](https://developers.conekta.com/v2.1.0/reference/orderscreateshipping). If the online store offers digital products. | [optional] 
**TaxLines** | [**List&lt;OrderTaxRequest&gt;**](OrderTaxRequest.md) | List of [taxes](https://developers.conekta.com/v2.1.0/reference/orderscreatetaxes) that are applied to the order. | [optional] 
**ThreeDsMode** | **string** | Indicates the 3DS2 mode for the order, either smart or strict. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

