# Conekta.net.Model.CheckoutOrderTemplate
It maintains the attributes with which the order will be created when receiving a new payment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Currency** | **string** | It is the currency in which the order will be created. It must be a valid ISO 4217 currency code. | 
**CustomerInfo** | [**OrderRequestCustomerInfo**](OrderRequestCustomerInfo.md) |  | [optional] 
**LineItems** | [**List&lt;Product&gt;**](Product.md) | They are the products to buy. Each contains the \&quot;unit price\&quot; and \&quot;quantity\&quot; parameters that are used to calculate the total amount of the order. | 
**Metadata** | **Dictionary&lt;string, Object&gt;** | It is a set of key-value pairs that you can attach to the order. It can be used to store additional information about the order in a structured format. | [optional] 
**TaxLines** | [**List&lt;OrderTaxRequest&gt;**](OrderTaxRequest.md) | List of [taxes](https://developers.conekta.com/v2.2.0/reference/orderscreatetaxes) that are applied to the order. | [optional] 
**DiscountLines** | [**List&lt;OrderDiscountLinesRequest&gt;**](OrderDiscountLinesRequest.md) | List of [discounts](https://developers.conekta.com/v2.2.0/reference/orderscreatediscountline) that are applied to the order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

