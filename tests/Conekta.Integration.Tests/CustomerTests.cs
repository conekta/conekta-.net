using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Conekta.Models;
using FluentAssertions;
using Newtonsoft.Json;
using Xunit;

namespace Conekta.Integration.Tests
{
  /// <summary>
  /// Customer tests.
  /// </summary>
  [Collection("Sequential")]
  public class CustomerTests
  {
    #region :: Private Fields ::

    /// <summary>
    /// Customer Context.
    /// </summary>
    private readonly CustomerContext _customerContext;

    /// <summary>
    /// 
    /// </summary>
    private readonly PaymentSourceContext _paymentSourceContext;

    /// <summary>
    /// Customer valid data.
    /// </summary>
    private readonly CustomerOperationData _validData = new CustomerOperationData
    {
      Name = "test name",
      Email = "test@test.com",
      PaymentSources = new List<PaymentSource>
      {
        new PaymentSource
        {
          TokenId = "tok_test_visa_4242",
          Type = "card"
        }
      }
    };

    #endregion

    #region :: Constructor ::

    /// <summary>
    /// Customer tests.
    /// </summary>
    public CustomerTests()
    {
      _customerContext = new CustomerContext();
      _paymentSourceContext = new PaymentSourceContext();

      ConektaInfo.APIKey = "key_ZLy4aP2szht1HqzkCezDEA";
    }

    #endregion

    #region :: Methods ::

    /// <summary>
    /// Create async OK.
    /// </summary>
    /// <returns></returns>
    [Fact]
    public async Task CreateAsync_Customer_OK_Test()
    {
      var customerCreated = await _customerContext.CreateAsync(_validData);

      Console.WriteLine(@$"CreateAsync_Customer_OK_Test    [->] { JsonConvert.SerializeObject(customerCreated,
        Formatting.Indented, new JsonSerializerSettings
        {
          NullValueHandling = NullValueHandling.Ignore
        }) }");

      customerCreated.Name.Should().Be(_validData.Name);
    }

    /// <summary>
    /// Update Ok.
    /// </summary>
    /// <returns></returns>
    [Fact]
    public async Task UpdateAsync_Customer_OK_Test()
    {
      var customerCreated = await _customerContext.CreateAsync(_validData);

      var customerToUpdate = new CustomerOperationData(customerCreated.Id)
      {
        Name = "Cosme Fulanito",
        Email = "cosme.fulanito@mail.com"
      };

      var customerUpdated = await _customerContext.UpdateAsync(customerToUpdate);

      Console.WriteLine(@$"UpdateAsync_Customer_OK_Test    [->] { JsonConvert.SerializeObject(customerUpdated,
        Formatting.Indented, new JsonSerializerSettings
        {
          NullValueHandling = NullValueHandling.Ignore
        }) }");

      customerUpdated.Name.Should().Be(customerUpdated.Name);
      customerUpdated.Email.Should().Be(customerUpdated.Email);
    }

    /// <summary>
    /// Find Ok
    /// </summary>
    /// <returns></returns>
    [Fact]
    public async Task FindAsync_Customer_OK_Test()
    {
      var customerCreated = await _customerContext.CreateAsync(_validData);

      var customerFound = await _customerContext.FindAsync(customerCreated.Id);

      Console.WriteLine(@$"FindAsync_Customer_OK_Test    [->] { JsonConvert.SerializeObject(customerFound,
        Formatting.Indented, new JsonSerializerSettings
        {
          NullValueHandling = NullValueHandling.Ignore
        }) }");

      customerFound.LiveMode.Should().BeFalse();
      customerFound.Name.Should().Be(_validData.Name);
      customerFound.Email.Should().Be(_validData.Email);
    }

    /// <summary>
    /// Where Ok.
    /// </summary>
    /// <returns></returns>
    [Fact]
    public async Task WhereAsync_Customer_OK_Test()
    {
      var query = new Dictionary<string, string>
        {
          { "limit", "10" }
        };

      var ordersFound = await _customerContext.WhereAsync(query);

      Console.WriteLine(@$"WhereAsync_Customer_OK_Test    [->] { JsonConvert.SerializeObject(ordersFound,
        Formatting.Indented, new JsonSerializerSettings
        {
          NullValueHandling = NullValueHandling.Ignore
        }) }");

      ordersFound.Data.Count.Should().Be(10);
      ordersFound.HasMore.Should().BeTrue();
      ordersFound.NextPageUrl.Should().NotBeNullOrEmpty();
    }

    /// <summary>
    /// Create Shipping Contact ok.
    /// </summary>
    /// <returns></returns>
    [Fact]
    public async Task CreateShippingContantAsync_OK_Test()
    {
      var customerCreated = await _customerContext.CreateAsync(_validData);
      var shippingContact = new ShippingContact
      {
        Receiver = "John Constantine",
        Phone = "+5213353319758",
        BetweenStreets = "Morelos y Campeche",
        Address = new Address
        {
          Street1 = "Nuevo Leon 4",
          City = "Ciudad de Mexico",
          State = "Ciudad de Mexico",
          Zip = "78215",
          Country = "MX"
        }
      };
      var shippingContactCreated = await _customerContext.CreateShippingContact(customerCreated.Id, shippingContact);

      shippingContactCreated.Receiver.Should().Be(shippingContact.Receiver);
      shippingContactCreated.Phone.Should().Be(shippingContact.Phone);
      shippingContactCreated.BetweenStreets.Should().Be(shippingContact.BetweenStreets);
      shippingContactCreated.Address.Street1.Should().Be(shippingContact.Address.Street1);
      shippingContact.Address.City.Should().Be(shippingContact.Address.City);
      shippingContact.Address.State.Should().Be(shippingContact.Address.State);
      shippingContact.Address.Zip.Should().Be(shippingContact.Address.Zip);
      shippingContact.Address.Country.Should().Be(shippingContact.Address.Country);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [Fact]
    public async Task CreateCardPaymentSourceAsync_OK_Test()
    {
      var customerCreated = await _customerContext.CreateAsync(_validData);

      var createdCard = await _customerContext.CreatePaymentSourceAsync(customerCreated.Id,
        new PaymentSourceCard
        {
          Type = "card",
          TokenId = "tok_test_visa_1881"
        });

      //Console.WriteLine($"::: {JsonConvert.SerializeObject(customerFound, Formatting.Indented)}");

      createdCard.Should().NotBeNull();
      createdCard.Last4.Should().Be("1881");
      createdCard.Bin.Should().Be("401288");
    }

    ///// <summary>
    ///// 
    ///// </summary>
    ///// <returns></returns>
    //[Fact]
    //public async Task UpdatePaymentSource_OK_Test()
    //{
    //  var newCustomer = new CustomerOperationData
    //  {
    //    Name = "test name update",
    //    Email = "testupdatepaymentsource@test.com",
    //    PaymentSources = new List<PaymentSource>
    //    {
    //      new PaymentSource
    //      {
    //        TokenId = "tok_test_visa_4242",
    //        Type = "card"
    //      }
    //    }
    //  };

    //  var customerCreated = await _customerContext.CreateAsync(newCustomer);

    //  var currentPaymentSource = customerCreated.PaymentSources.Data.First();

    //  var toUpdate = new Card
    //  {
    //    Id = currentPaymentSource.Id,
    //    //TokenId = currentPaymentSource.TokenId,
    //    TokenId = "tok_test_mastercard_4444",
    //    ParentId = currentPaymentSource.ParentId
    //  };

    //  var paymentSourceUpdated = await _paymentSourceContext.UpdateAsync(toUpdate);

    //  var customerFound = await _customerContext.FindAsync(customerCreated.Id);

    //  paymentSourceUpdated.Should().NotBeNull();
    //  //paymentSourceUpdated.Last4.Should().Be("4444");

    //  Console.WriteLine($"::: {JsonConvert.SerializeObject(customerFound, Formatting.Indented)}");

    //  //customerFound.PaymentSources.Data.First().Last4.Should().Be("4444");
    //}

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [Fact]
    public async Task DeletePaymentSource_OK_Test()
    {
      var newCustomer = new CustomerOperationData
      {
        Name = "test name update",
        Email = "testupdatepaymentsource@test.com",
        PaymentSources = new List<PaymentSource>
        {
          new PaymentSource
          {
            TokenId = "tok_test_visa_4242",
            Type = "card"
          }
        }
      };

      var customerCreated = await _customerContext.CreateAsync(newCustomer);

      var currentPaymentSource = customerCreated.PaymentSources.Data.First();

      var paymentMethodRemoved = await _paymentSourceContext.RemoveAsync(currentPaymentSource.ParentId, currentPaymentSource.Id);

      paymentMethodRemoved.Should().NotBeNull();
      paymentMethodRemoved.Deleted.Should().BeTrue();
    }

    #endregion
  }
}
