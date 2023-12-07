/*
 * Conekta API
 *
 * Conekta sdk
 *
 * The version of the OpenAPI document: 2.1.0
 * Contact: engineering@conekta.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;

using Conekta.net.Api;
using Conekta.net.Client;
using Conekta.net.Model;

using Xunit;
using Xunit.Sdk;

namespace Conekta.net.Test.Api;

/// <summary>
///     Class for testing OrdersApi
/// </summary>
/// <remarks>
///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
///     Please update the test case below to test the API endpoint.
/// </remarks>
public class OrdersApiTests
{
    private readonly OrdersApi _instance;

    public OrdersApiTests()
    {
        Configuration configuration = new()
        {
            BasePath = BaseTest.BasePath,
            AccessToken = "key_uMxL6X1txuxyzQzJEXt72Aaaa"
        };
        _instance = new OrdersApi(configuration);
    }

    /// <summary>
    ///     Test an instance of OrdersApi
    /// </summary>
    [Fact]
    public void InstanceTest()
    {
        Assert.IsType<OrdersApi>(_instance);
    }

    /// <summary>
    ///     Test CreateOrderCash
    /// </summary>
    [Fact]
    public void CreateOrderCashTest()
    {
        List<Product> products = new()
        {
            new(
                name: "toshiba",
                quantity: 1,
                unitPrice: 1555
            )
        };
        DateTime thirtyDaysFromNowDateTime = DateTime.Now.AddDays(30);
        var expiresAt = (Int64)thirtyDaysFromNowDateTime.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        List<ChargeRequest> charges = new()
        {
            new(
                1555,
                paymentMethod: new ChargeRequestPaymentMethod(expiresAt:expiresAt, type:"cash")
            )
        };
        OrderRequestCustomerInfo customerInfo = new(new CustomerInfoJustCustomerId("cus_2tKcHxhTz7xU5SymF"));
        OrderRequest orderRequest = new(
            currency: "MXN",
            customerInfo: customerInfo,
            lineItems: products,
            charges: charges,
            preAuthorize: false,
            shippingContact: new CustomerShippingContacts(
                address: new CustomerShippingContactsAddress(
                     street1: "test",
                     street2: "street 2",
                     postalCode: "11011",
                     city: "cdmx",
                     country: "mexico"
                    ),
                metadata: new Dictionary<string, object>()),
            fiscalEntity: new OrderFiscalEntityRequest(
                address: new FiscalEntityAddress(
                    street1: "test",
                    street2: "street 2",
                    postalCode: "11011",
                    city: "cdmx",
                    country: "mexico",
                    externalNumber: "123"
                    ),
                metadata: new Dictionary<string, object>())
        );

        OrderResponse response = _instance.CreateOrder(orderRequest, "es");

        Assert.IsType<OrderResponse>(response);
        Assert.Equal("pending_payment", response.PaymentStatus);
        Assert.Equal("MXN", response.Currency);
        Assert.Equal("cus_2tKcHxhTz7xU5SymF", response.CustomerInfo.CustomerId);
        Assert.IsType<PaymentMethodCash>(response.Charges.Data[0].PaymentMethod.ActualInstance);
        Assert.Equal("OxxoPay", response.Charges.Data[0].PaymentMethod.GetPaymentMethodCash().ServiceName);
        Assert.Equal("93000262280678", response.Charges.Data[0].PaymentMethod.GetPaymentMethodCash().Reference);
        Assert.Equal("oxxo", response.Charges.Data[0].PaymentMethod.GetPaymentMethodCash().Type);
        Assert.Equal(expiresAt, response.Charges.Data[0].PaymentMethod.GetPaymentMethodCash().ExpiresAt);
    }
    /// <summary>
    ///     Test CreateOrderDefaultErr
    /// </summary>
    [Fact]
    public void CreateOrderDefaultErrTest()
    {
        List<Product> products = new()
        {
            new(
                name: "toshiba",
                description: "Mes de Febrero.",
                quantity: 1,
                unitPrice: 1555,
                tags: new List<string> {"pago", "mensualidad"}
            )
        };
        DateTime thirtyDaysFromNowDateTime = DateTime.Now.AddDays(30);
        var expiresAt = (Int64)thirtyDaysFromNowDateTime.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        List<ChargeRequest> charges = new()
        {
            new(
                2000,
                paymentMethod: new ChargeRequestPaymentMethod(
                    type:"default",
                    expiresAt: expiresAt
                    )
            )
        };
        OrderRequestCustomerInfo customerInfo = new(new CustomerInfoJustCustomerId("cus_2tKcHxhTz7xU5SymF2"));
        OrderRequest orderRequest = new(
            currency: "MXN",
            customerInfo: customerInfo,
            lineItems: products,
            charges: charges
        );
        try
        {
            ApiResponse<OrderResponse> response = _instance.CreateOrderWithHttpInfo(orderRequest);
            throw new XunitException("Error message should return an error");
        }
        catch (ApiException e)
        {
            Assert.Equal((int)System.Net.HttpStatusCode.PaymentRequired, e.ErrorCode);
        }
    }

    /// <summary>
    ///     Test CreateOrderMsi
    /// </summary>
    [Fact]
    public void CreateOrderMsiTest()
    {
        List<Product> products = new()
        {
            new(
                name: "toshiba",
                quantity: 1,
                unitPrice: 1555
            )
        };
        CheckoutRequest checkout = new(
            expiresAt: (long)DateTime.UtcNow.AddSeconds(259200).Subtract(new DateTime(1970, 1, 1)).TotalSeconds,
            allowedPaymentMethods: new List<string> { "cash", "card", "bank_transfer" },
            monthlyInstallmentsEnabled: true,
            monthlyInstallmentsOptions: new List<int> { 3, 6, 12 }
        );
        OrderRequestCustomerInfo customerInfo = new(new CustomerInfoJustCustomerId("cus_msi_2o8jK3TDtejmz1sYd"));
        OrderRequest orderRequest = new(
            currency: "MXN",
            customerInfo: customerInfo,
            lineItems: products,
            checkout: checkout,
            metadata: new Dictionary<string, Object> { { "test", "true" } }
        );

        OrderResponse response = _instance.CreateOrder(orderRequest);

        Assert.IsType<OrderResponse>(response);
        Assert.IsType<OrderResponseCheckout>(response.Checkout);
        Assert.False(string.IsNullOrEmpty(response.Checkout.Id));
        Assert.Equal("ord_msi_2tUgccjdQJ7SdBrXb", response.Id);
        Assert.Equal("Integration", response.Checkout.Type);
        Assert.True(response.Checkout.MonthlyInstallmentsEnabled);
        Assert.Equal(new List<int> { 3, 6, 12 }, response.Checkout.MonthlyInstallmentsOptions);
    }

    /// <summary>
    ///     Test CreateOrderSavedCard
    /// </summary>
    [Fact]
    public void CreateOrderSavedCardTest()
    {
        List<Product> products = new()
        {
            new(
                name: "toshiba",
                quantity: 1,
                unitPrice: 1555
            )
        };
        CheckoutRequest checkout = new(
            expiresAt: (long)DateTime.UtcNow.AddSeconds(259200).Subtract(new DateTime(1970, 1, 1)).TotalSeconds,
            allowedPaymentMethods: new List<string> { "cash", "card", "bank_transfer" },
            onDemandEnabled: true
        );
        OrderRequestCustomerInfo customerInfo = new(new CustomerInfoJustCustomerId("cus_save_card_2o8jK3TDtejmz1sYd"));
        OrderRequest orderRequest = new(
            currency: "MXN",
            customerInfo: customerInfo,
            lineItems: products,
            checkout: checkout,
            metadata: new Dictionary<string, Object> { { "test", "true" } }
        );

        OrderResponse response = _instance.CreateOrder(orderRequest);

        Assert.IsType<OrderResponse>(response);
        Assert.IsType<OrderResponseCheckout>(response.Checkout);
        Assert.False(string.IsNullOrEmpty(response.Checkout.Id));
        Assert.Equal("ord_saved_card_2tUgccjdQJ7SdBrXb", response.Id);
        Assert.Equal("Integration", response.Checkout.Type);
        Assert.False(response.Checkout.MonthlyInstallmentsEnabled);
        Assert.Equal(new List<int>(), response.Checkout.MonthlyInstallmentsOptions);
        Assert.True(response.Checkout.OnDemandEnabled);
    }

    /// <summary>
    ///     Test CreateOrderCheckout
    /// </summary>
    [Fact]
    public void CreateOrderCheckoutTest()
    {
        List<Product> products = new()
        {
            new(
                name: "Box of Cohiba S1s",
                unitPrice: 35000,
                quantity: 1
            )
        };
        CheckoutRequest checkout = new(
            expiresAt: (long)DateTime.UtcNow.AddSeconds(259200).Subtract(new DateTime(1970, 1, 1)).TotalSeconds,
            allowedPaymentMethods: new List<string> { "cash", "card", "bank_transfer" }
        );
        OrderRequest orderRequest = new(
            currency: "MXN",
            lineItems: products,
            checkout: checkout,
            metadata: new Dictionary<string, Object> { { "test", "true" } },
            customerInfo: new OrderRequestCustomerInfo(new CustomerInfoJustCustomerId("cus_2o8jK3TDtejmz1sYc"))
        );

        OrderResponse response = _instance.CreateOrder(orderRequest);

        Assert.IsType<OrderResponse>(response);
        Assert.Equal("cus_2o8jK3TDtejmz1sYc", response.CustomerInfo.CustomerId);
        Assert.Equal("Integration", response.Channel.CheckoutRequestType);
        Assert.Equal("Integration", response.Checkout.Type);
        Assert.Equal(checkout.ExpiresAt, response.Checkout.ExpiresAt);
        Assert.Equal(products[0].UnitPrice, response.Amount);
        Assert.NotEmpty(response.Metadata);
        Assert.IsType<OrderResponseCheckout>(response.Checkout);
        Assert.NotEmpty(response.Checkout.Id);
        Assert.False(response.Checkout.MonthlyInstallmentsEnabled);
    }

    /// <summary>
    ///     Test GetOrderBankPaymentMethodBankTransferById
    /// </summary>
    [Fact]
    public void GetOrderBankPaymentMethodBankTransferByIdTest()
    {
        string id = "ord_2tUyGSk9TNWUcyvjn";

        OrderResponse response = _instance.GetOrderById(id, "es");

        Assert.IsType<OrderResponse>(response);
        Assert.Single(response.Charges.Data);
        Assert.IsType<PaymentMethodBankTransfer>(response.Charges.Data[0].PaymentMethod.ActualInstance);
        Assert.Equal(id, response.Id);
        Assert.Equal("bank_transfer_payment", response.Charges.Data[0].PaymentMethod.GetPaymentMethodBankTransfer().Object);
    }
    /// <summary>
    ///     Test GetOrderBankPaymentMethodBankTransferById
    /// </summary>
    [Fact]
    public void GetOrderByIdNoFoundErrTest()
    {
        string id = "ord_2tUhuyzqLi6UJE9D12";
        try
        {
            OrderResponse response = _instance.GetOrderById(id, "en");
            throw new XunitException("Error message should return an error GetOrderByIdNoFoundErrTest");
        }
        catch (ApiException e)
        {
            Assert.Equal((int)System.Net.HttpStatusCode.NotFound, e.ErrorCode);
        }
    }

    /// <summary>
    ///     Test GetOrders
    /// </summary>
    [Fact]
    public void GetOrdersTest()
    {
        int? limit = 20;

        GetOrdersResponse response = _instance.GetOrders("en", null, limit);

        Assert.IsType<GetOrdersResponse>(response);
        Assert.True(response.HasMore);
        Assert.Equal("https://api-core.stg.conekta.io/orders?next=ord_2tNDyQbJacvUZiyfp", response.NextPageUrl);
        Assert.Null(response.PreviousPageUrl);
        Assert.Equal("list", response.Object);
        Assert.Equal(limit, response.Data.Count);
        Assert.Equal("card_payment", response.Data[0].Charges.Data[0].PaymentMethod.GetPaymentMethodCard().Object);
        Assert.Equal("cash_payment", response.Data[9].Charges.Data[0].PaymentMethod.GetPaymentMethodCash().Object);
        Assert.IsType<PaymentMethodCard>(response.Data[0].Charges.Data[0].PaymentMethod.ActualInstance);
        Assert.IsType<PaymentMethodCash>(response.Data[9].Charges.Data[0].PaymentMethod.ActualInstance);
    }
    /// <summary>
    ///     Test GetOrdersWithNext
    /// </summary>
    [Fact]
    public void GetOrdersWithNextTest()
    {
        int? limit = 19;

        GetOrdersResponse response = _instance.GetOrders("en", null, limit, next: "ord_2tNDyQbJacvUZiyfp");

        Assert.IsType<GetOrdersResponse>(response);
        Assert.True(response.HasMore);
        Assert.Equal("https://api-core.stg.conekta.io/orders?limit=19&next=ord_2tKZmA749BLsMRgBg", response.NextPageUrl);
        Assert.Equal("https://api-core.stg.conekta.io/orders?limit=19&previous=ord_2tNDwzeMnVSU9kKHR", response.PreviousPageUrl);
        Assert.Equal("list", response.Object);
        Assert.Equal(limit, response.Data.Count);
        Assert.Equal("cus_2tKcHxhTz7xU5SymF", response.Data[0].CustomerInfo.CustomerId);
        Assert.Equal("mx", response.Data[0].ShippingContact.Address.Country);
    }
    /// <summary>
    ///     Test GetOrdersWithPrevious
    /// </summary>
    [Fact]
    public void GetOrdersWithPreviousTest()
    {
        int? limit = 21;

        GetOrdersResponse response = _instance.GetOrders("en", null, limit, previous: "ord_2tHuXwkFTkjAbMGjU");

        Assert.IsType<GetOrdersResponse>(response);
        Assert.True(response.HasMore);
        Assert.Equal("https://api-core.stg.conekta.io/orders?limit=21&next=ord_2tKZmA749BLsMRgBg", response.NextPageUrl);
        Assert.Equal("https://api-core.stg.conekta.io/orders?limit=21&previous=ord_2tNDzhA4Akmzj11AS", response.PreviousPageUrl);
        Assert.Equal("list", response.Object);
        Assert.Equal(limit, response.Data.Count);
        Assert.Equal("cus_2tKcHxhTz7xU5SymF", response.Data[0].CustomerInfo.CustomerId);
        Assert.Equal("mx", response.Data[0].ShippingContact.Address.Country);
    }
    /// <summary>
    ///     Test GetOrdersWithPrevious
    /// </summary>
    [Fact]
    public void GetOrdersWithSearchTest()
    {
        int? limit = 22;

        GetOrdersResponse response = _instance.GetOrders("en", null, limit, search: "ord_2tNDzhA4Akmzj11AS");

        Assert.IsType<GetOrdersResponse>(response);
        Assert.False(response.HasMore);
        Assert.Null(response.NextPageUrl);
        Assert.Null(response.PreviousPageUrl);
        Assert.Equal("list", response.Object);
        Assert.Single(response.Data);
        Assert.Equal("cus_2tKcHxhTz7xU5SymF", response.Data[0].CustomerInfo.CustomerId);
        Assert.Equal("ord_2tNDzhA4Akmzj11AS", response.Data[0].Id);
        Assert.Equal("06100", response.Data[0].ShippingContact.Address.PostalCode);
    }

    /// <summary>
    ///     Test OrderRefund
    /// </summary>
    [Fact]
    public void OrderRefundTest()
    {
        string id = "ord_2tV52JvSom2w3E8bX";
        OrderRefundRequest orderRefundRequest = new(
            amount: 15000,
            reason: "requested_by_client"
        );

        var response = _instance.OrderRefund(id, orderRefundRequest);

        Assert.IsType<OrderResponse>(response);
        Assert.Equal("partially_refunded", response.PaymentStatus);
        Assert.Equal("partially_refunded", response.Charges.Data[0].Status);
        Assert.Equal(orderRefundRequest.Amount, response.AmountRefunded);
        Assert.True(response.IsRefundable);
        Assert.Equal(id, response.Charges.Data[0].OrderId);
        Assert.Single(response.Charges.Data[0].Refunds.Data);
        Assert.Equal(-orderRefundRequest.Amount, response.Charges.Data[0].Refunds.Data[0].Amount);
        Assert.Equal("refund", response.Charges.Data[0].Refunds.Data[0].Object);
        Assert.IsType<PaymentMethodCard>(response.Charges.Data[0].PaymentMethod.ActualInstance);
    }
    /// <summary>
    ///     Test OrdersCreateCapture
    /// </summary>
    [Fact]
    public void OrdersCreateCaptureTest()
    {
        var response = _instance.OrdersCreateCapture("ord_2tVKoTd79XK1GqJme", "en");

        Assert.IsType<OrderResponse>(response);
        Assert.Equal("paid", response.PaymentStatus);
        Assert.Equal(40000, response.Amount);
    }
    /// <summary>
    ///     Test OrdersCreateCaptureWithBody
    /// </summary>
    [Fact]
    public void OrdersCreateCaptureWithBodyTest()
    {
        var request = new OrderCaptureRequest
        {
            Amount = 40000,
        };
        var response = _instance.OrdersCreateCapture("ord_2tVKoTd79XK1GqJmm", "en", null, request);

        Assert.IsType<OrderResponse>(response);
        Assert.Equal("paid", response.PaymentStatus);
        Assert.Equal(40000, response.Amount);
    }
    /// <summary>
    ///     Test UpdateOrder
    /// </summary>
    [Fact]
    public void UpdateOrderTest()
    {
        string id = "ord_2tVPCGRXnMXKdvcsj";
        List<Product> products = new()
        {
            new(
                name: "Pago Mensualidad enero",
                quantity: 2,
                unitPrice: 41000,
                description : "Mes de enero.",
                tags: new List<string> {"Pago", "Pago mensualidad"}
            )
        };
        OrderUpdateRequest orderUpdateRequest = new(
            lineItems: products
        );

        var response = _instance.UpdateOrder(id, orderUpdateRequest);

        Assert.IsType<OrderResponse>(response);
        Assert.Single(response.LineItems.Data);
        Assert.Equal(products[0].UnitPrice, response.LineItems.Data[0].UnitPrice);
        Assert.Equal(id, response.Id);
        Assert.Equal(products[0].Tags, response.LineItems.Data[0].Tags);
        Assert.NotEqual(response.CreatedAt, response.UpdatedAt);
    }

    /// <summary>
    ///     Test CancelOrder
    /// </summary>
    [Fact]
    public void CancelOrderTest()
    {
        const string id = "ord_2tqaGQYZyvBsMKEgs";
        
        var response =  _instance.CancelOrder(id);
          
        Assert.IsType<OrderResponse>(response);
        Assert.Equal(id, response.Id);
        Assert.Equal("canceled", response.PaymentStatus);
        Assert.Equal("canceled", response.Charges.Data[0].Status);
    }
}