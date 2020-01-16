using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Conekta.Models;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Xunit;

namespace Conekta.Integration.Tests
{
  /// <summary>
  /// Customer tests.
  /// </summary>
  public class CustomerTests
  {
    #region :: Private Fields ::

    /// <summary>
    /// Customer Context.
    /// </summary>
    private readonly CustomerContext _customerContext;

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
      IServiceCollection services = new ServiceCollection();

      services.AddHttpClient();

      IHttpClientFactory factory = services
        .BuildServiceProvider()
        .GetRequiredService<IHttpClientFactory>();

      ConektaInfo.SetHttpClientFactory(factory);

      _customerContext = new CustomerContext();

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
        Formatting.Indented) }");

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

      var customerFound = await _orderContext.FindAsync(orderCreated.Id);

      orderFound.LiveMode.Should().BeFalse();
      orderFound.Amount.Should().Be(35000);
      orderFound.Currency.Should().Be(_validOrder.Currency);

      var test = (bool)orderFound.Metadata.test;

      Console.WriteLine(@$"FindAsync_OK_Test    [->] { JsonConvert.SerializeObject(orderFound,
        Formatting.Indented) }");

      test.Should().BeTrue();
    }

    #endregion
  }
}
