/*
 * Conekta API
 *
 * Conekta sdk
 *
 * The version of the OpenAPI document: 2.1.0
 * Contact: engineering@conekta.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System.Collections.Generic;
using Xunit;

using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;


namespace Conekta.net.Test.Api
{
    /// <summary>
    ///  Class for testing CustomersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CustomersApiTests
    {
        private readonly CustomersApi _instance;

        public CustomersApiTests()
        {
            Configuration configuration = new()
            {
                BasePath = BaseTest.BasePath,
                AccessToken = "key_uMxL6X1txuxyzQzJEXt72A"
            };
            _instance = new CustomersApi(configuration);
        }

        /// <summary>
        /// Test an instance of CustomersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<CustomersApi>(_instance);
        }

        /// <summary>
        /// Test CreateCustomer
        /// </summary>
        [Fact]
        public void CreateCustomerTest()
        {
            var customer = GetFullCustomer();
            var response = _instance.CreateCustomer(customer);

            Assert.IsType<CustomerResponse>(response);
            Assert.False(string.IsNullOrEmpty(response.Id));
            Assert.Equal(customer.CustomReference, response.CustomReference);
            Assert.Single(response.FiscalEntities.Data);
            Assert.False(response.FiscalEntities.HasMore);
            Assert.True(response.Livemode);
        }

        /// <summary>
        /// Test CreateCustomerFiscalEntities
        /// </summary>
        [Fact]
        public void CreateCustomerFiscalEntitiesTest()
        {
            string id = "cus_2tXyF9BwPG14UMkkg";
            CustomerFiscalEntitiesRequest customerFiscalEntitiesRequest = new(
                address: new CustomerFiscalEntitiesRequestAddress(
                    street1: "av siem",
                    city: "mexico",
                    country: "MX",
                    postalCode: "11000",
                    externalNumber: "11544"
                )
            );
            var response = _instance.CreateCustomerFiscalEntities(id, customerFiscalEntitiesRequest);

            Assert.IsType<CreateCustomerFiscalEntitiesResponse>(response);
            Assert.NotStrictEqual(customerFiscalEntitiesRequest.Address.Country, response.Address.Country);
            Assert.Equal(id, response.ParentId);
            Assert.False(string.IsNullOrEmpty(response.Id));
        }
        /// <summary>
        /// Test DeleteCustomerById
        /// </summary>
        [Fact]
        public void DeleteCustomerByIdTest()
        {
            string id = "cus_2tXyF9BwPG14UMkkg";
            var response = _instance.DeleteCustomerById(id, "es");

            Assert.IsType<CustomerResponse>(response);
            Assert.Equal(id, response.Id);
        }

        /// <summary>
        /// Test GetCustomerCardById
        /// </summary>
        [Fact]
        public void GetCustomerCardByIdTest()
        {
            string id = "cus_2tXx8KUxw6311kEbs";

            var response = _instance.GetCustomerById(id, "es");

            Assert.IsType<CustomerResponse>(response);
            Assert.Equal(id, response.Id);
            Assert.Single(response.PaymentSources.Data);
            Assert.IsType<PaymentMethodCardResponse>(response.PaymentSources.Data[0].ActualInstance);
            Assert.Equal("card", response.PaymentSources.Data[0].GetPaymentMethodCardResponse().Type);
            Assert.Equal("credit", response.PaymentSources.Data[0].GetPaymentMethodCardResponse().CardType);
            Assert.NotNull(response.Subscription);
            Assert.Equal(id, response.Subscription.CustomerId);
        }
        /// <summary>
        /// Test GetCustomerCardById
        /// </summary>
        [Fact]
        public void GetCustomerCashByIdTest()
        {
            string id = "cus_2rGtVzg5V2KZrKXBh";

            var response = _instance.GetCustomerById(id, "es");

            Assert.IsType<CustomerResponse>(response);
            Assert.Equal(id, response.Id);
            Assert.Single(response.PaymentSources.Data);
            Assert.IsType<PaymentMethodCashResponse>(response.PaymentSources.Data[0].ActualInstance);
            Assert.Equal("oxxo_recurrent", response.PaymentSources.Data[0].GetPaymentMethodCashResponse().Type);
            Assert.Equal("Oxxo", response.PaymentSources.Data[0].GetPaymentMethodCashResponse().Provider);
            Assert.Equal("payment_source", response.PaymentSources.Data[0].GetPaymentMethodCashResponse().Object);
        }
        /// <summary>
        /// Test GetCustomerCardById
        /// </summary>
        [Fact]
        public void GetCustomerSpeiByIdTest()
        {
            string id = "cus_2tYELwYTKSB5hDXsr";

            var response = _instance.GetCustomerById(id, "es");

            Assert.IsType<CustomerResponse>(response);
            Assert.Equal(id, response.Id);
            Assert.Single(response.PaymentSources.Data);
            Assert.IsType<PaymentMethodSpeiRecurrent>(response.PaymentSources.Data[0].ActualInstance);
            Assert.Equal("spei_recurrent", response.PaymentSources.Data[0].GetPaymentMethodSpeiRecurrent().Type);
            Assert.Equal("646180111805035870", response.PaymentSources.Data[0].GetPaymentMethodSpeiRecurrent().Reference);
            Assert.Equal("payment_source", response.PaymentSources.Data[0].GetPaymentMethodSpeiRecurrent().Object);
            Assert.Equal("none", response.PaymentSources.Data[0].GetPaymentMethodSpeiRecurrent().ExpiresAt);
        }

        /// <summary>
        /// Test GetCustomers
        /// </summary>
        [Fact]
        public void GetCustomersTest()
        {
            string acceptLanguage = "es";
            int limit = 21;

            var response = _instance.GetCustomers(acceptLanguage, null, limit);

            Assert.IsType<CustomersResponse>(response);
            Assert.NotNull(response.NextPageUrl);
            Assert.Null(response.PreviousPageUrl);
            Assert.True(response.HasMore);
            Assert.Equal("list", response.Object);
            Assert.Equal(limit, response.Data.Count);
        }
        /// <summary>
        /// Test GetCustomers
        /// </summary>
        [Fact]
        public void GetCustomersNextTest()
        {
            string acceptLanguage = "es";
            int limit = 22;
            string next = "cus_2sthLBEZRLp2s6GWc";

            var response = _instance.GetCustomers(acceptLanguage, null,limit, null, next);

            Assert.IsType<CustomersResponse>(response);
            Assert.NotNull(response.NextPageUrl);
            Assert.NotNull(response.PreviousPageUrl);
            Assert.True(response.HasMore);
            Assert.Equal("list", response.Object);
            Assert.Equal(limit, response.Data.Count);
        }
        /// <summary>
        /// Test GetCustomers
        /// </summary>
        [Fact]
        public void GetCustomersPreviousTest()
        {
            string acceptLanguage = "es";
            int limit = 23;
            string previous = "cus_2ss5YAeTKuEr5M4fD";

            var response = _instance.GetCustomers(acceptLanguage, null, limit, null, null, previous);

            Assert.IsType<CustomersResponse>(response);
            Assert.NotNull(response.NextPageUrl);
            Assert.Null(response.PreviousPageUrl);
            Assert.False(response.HasMore);
            Assert.Equal("list", response.Object);
        }

        /// <summary>
        /// Test UpdateCustomer
        /// </summary>
        [Fact]
        public void UpdateCustomerTest()
        {
            string id = "cus_2tYENskzTjjgkGQLt";
            UpdateCustomer updateCustomer = new(
                email: "dotnet@test.com"
            );

            var response = _instance.UpdateCustomer(id, updateCustomer);

            Assert.IsType<CustomerResponse>(response);
            Assert.Equal(updateCustomer.Email, response.Email);
            Assert.Equal(id, response.Id);
        }

        /// <summary>
        /// Test UpdateCustomerFiscalEntities
        /// </summary>
        [Fact]
        public void UpdateCustomerFiscalEntitiesTest()
        {
            string id = "cus_2tYENskzTjjgkGQLt";
            string fiscalEntitiesId = "fis_ent_2tYENskzTjjgkGQLr";
            CustomerUpdateFiscalEntitiesRequest customerFiscalEntitiesRequest = new(
                taxId: "tax_28764234"
            );
            var response = _instance.UpdateCustomerFiscalEntities(id, fiscalEntitiesId, customerFiscalEntitiesRequest);

            Assert.IsType<UpdateCustomerFiscalEntitiesResponse>(response);
            Assert.Equal(customerFiscalEntitiesRequest.TaxId, response.TaxId);
            Assert.Equal(id, response.ParentId);
            Assert.Equal(fiscalEntitiesId, response.Id);
            Assert.True(response.Default);
            Assert.Equal("fiscal_entity", response.Object);
        }
        private static Customer GetFullCustomer()
        {
            var fiscalEntities = new List<CustomerFiscalEntitiesRequest>()
            {
                new CustomerFiscalEntitiesRequest(
                    address: new CustomerFiscalEntitiesRequestAddress(
                        street1: "av siempre viva",
                        street2: "condensa",
                        postalCode: "11011",
                        city: "cdmx mexico",
                        state: "cdmx mexico",
                        country: "mexico",
                        residential: true,
                        externalNumber: "avas3"
                    ),
                    companyName: "testing ca",
                    taxId: "tax_23432",
                    email: "test@conekta.com",
                    phone: "+573143152012",
                    metadata: new Dictionary<string, object> { { "test", "true" } }
                )
            };
            var paymentSources = new List<CustomerPaymentMethodsRequest>()
            {
                new CustomerPaymentMethodsRequest(
                    new PaymentMethodCardRequest("card", "tok_2tXyExrU6U7yiaTto")
                )
            };
            List<CustomerShippingContacts> shippingContacts = new()
            {
                new CustomerShippingContacts(
                    address: new CustomerShippingContactsAddress(
                        street1 : "avenida siempre viva",
                        country : "mexico",
                        postalCode : "11011"
                    ),
                    phone: "+54874122144"
                )
            };
            SubscriptionRequest subscription = new(
                planId: "plan_2tXx672QLQ68CkmMn",
                cardId: "card_2tXyExrU6U7yiaTto",
                trialEnd: 1679321468
            );
            Customer customer = new(
                name: "test dot",
                phone: "+573143159063",
                email: "test@conekta.com",
                corporate: true,
                planId: "plan_2tXx672QLQ68CkmMn",
                defaultShippingContactId: "",
                defaultPaymentSourceId: "",
                customReference: "dotnet_12345678",
                fiscalEntities: fiscalEntities,
                paymentSources: paymentSources,
                shippingContacts: shippingContacts,
                subscription: subscription
            );
            return customer;
        }
    }
}
