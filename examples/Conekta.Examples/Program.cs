using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Conekta.Exceptions;
using Conekta.Models;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace Conekta.Examples
{
  /// <summary>
  /// Program.
  /// </summary>
  class Program
  {
    #region :: Static Methods ::

    /// <summary>
    /// The entry point of the program, where the program control starts and ends.
    /// </summary>
    /// <param name="args">The command-line arguments.</param>
    static async Task Main(string[] args)
    {
      try
      {
        Console.ForegroundColor = ConsoleColor.Blue;

        Console.WriteLine("::: Conekta Examples :::");

        SetupHttpRequestFactory();

        ConektaInfo.APIKey = "key_ZLy4aP2szht1HqzkCezDEA";

        var order = await CreateOrder();

        var orderFound = await FindOrder(order.Id);

        var ordersFound = await WhereOrder(new Dictionary<string, string>
        {
          { "id", orderFound.Id },
          { "amount", orderFound.Amount.ToString() }
        });

        var orderToUpdate = new OrderOperationData(order.Id)
        {
          Currency = order.Currency,
          CustomerInfo = order.CustomerInfo,
          LineItems = order.LineItemsList.Data
        };

        orderToUpdate.LineItems.Add(new LineItem
        {
          Name = "Other Item to buy",
          UnitPrice = 10000,
          Quantity = 1
        });

        orderToUpdate.CustomerInfo.Email = "gustavo@conekta.com";

        var orderUpdated = await UpdateOrder(orderToUpdate);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("[√√] All Done.");
      }
      catch (ConektaValidationException ex)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[x_x] Message: { ex.Message }");
        Console.WriteLine($"[x_x] Valition erros:");

        foreach (var item in ex.ValidationErros)
        {
          Console.WriteLine($"[x_x] -> { item }");
        }

        Console.WriteLine($"[x_x] StackTrace -> { ex.StackTrace }");
      }
      catch (ConektaHttpException ex)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[x_x] Status Code: {ex.HttpStatusCode}");
        Console.WriteLine($"[x_x] Message: { ex.Message }");
        Console.WriteLine($"[x_x] StackTrace -> { ex.StackTrace }");
      }
      catch (Exception ex)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[x_x] { ex.Message }");
        Console.WriteLine($"[x_x] StackTrace -> { ex.StackTrace }");
      }
    }

    #endregion

    #region :: Private Static Methods ::

    /// <summary>
    /// Creates the order.
    /// </summary>
    /// <returns>The order.</returns>
    private static async Task<Order> CreateOrder()
    {
      Console.ForegroundColor = ConsoleColor.DarkCyan;
      Console.WriteLine("  [-] Creating Order...");

      var orderContext = new OrderContext();

      var orderCreationData = new OrderOperationData
      {
        Currency = "MXN",
        CustomerInfo = new CustomerInfo
        {
          Name = "Gustavo Alfaro Aké",
          Phone = "+5215555555555",
          Email = "tavo@conekta.com"
        },
        LineItems = new List<LineItem>
          {
            new LineItem
            {
              Name = "My Item to buy",
              UnitPrice = 23000,
              Quantity = 2
            }
          }
      };

      var orderCreated = await orderContext.CreateAsync(orderCreationData);

      Console.WriteLine("    [√] Order created:");
      Console.WriteLine(@$"    [->] { JsonConvert.SerializeObject(orderCreated,
        Formatting.Indented) }");

      return orderCreated;
    }

    /// <summary>
    /// Finds the order.
    /// </summary>
    /// <returns>The order.</returns>
    /// <param name="orderId">Order identifier.</param>
    private static async Task<Order> FindOrder(string orderId)
    {
      Console.ForegroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine($"  [-] Searching Order {orderId}...");

      var orderContext = new OrderContext();

      var orderFound = await orderContext.FindAsync(orderId);

      Console.WriteLine("    [√] Order Found:");
      Console.WriteLine(@$"    [->] { JsonConvert.SerializeObject(orderFound,
        Formatting.Indented) }");

      return orderFound;
    }

    /// <summary>
    /// Wheres the order.
    /// </summary>
    /// <returns>The order.</returns>
    /// <param name="query">Query.</param>
    private static async Task<OrderList> WhereOrder(Dictionary<string, string> query)
    {
      Console.ForegroundColor = ConsoleColor.DarkMagenta;
      Console.WriteLine($"  [-] Searching query Order...");

      var orderContext = new OrderContext();

      var ordersFound = await orderContext.WhereAsync(query);

      Console.WriteLine("    [√] Orders Found:");
      Console.WriteLine(@$"    [->] { JsonConvert.SerializeObject(ordersFound,
        Formatting.Indented) }");

      return ordersFound;
    }

    /// <summary>
    /// Updates the order.
    /// </summary>
    /// <returns>The order.</returns>
    /// <param name="orderOperationData">Order operation data.</param>
    private static async Task<Order> UpdateOrder(OrderOperationData orderOperationData)
    {
      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine($"  [-] Updating Order {orderOperationData.Id}...");

      var orderContext = new OrderContext();

      var orderUpdated = await orderContext.UpdateAsync(orderOperationData);

      Console.WriteLine("    [√] Order Updated:");
      Console.WriteLine(@$"    [->] { JsonConvert.SerializeObject(orderUpdated,
        Formatting.Indented) }");

      return orderUpdated;
    }

    #region :: Order ::

    #endregion

    /// <summary>
    /// Setups the http request factory.
    /// </summary>
    private static void SetupHttpRequestFactory()
    {
      IServiceCollection services = new ServiceCollection();

      services.AddHttpClient();

      IHttpClientFactory factory = services
        .BuildServiceProvider()
        .GetRequiredService<IHttpClientFactory>();

      ConektaInfo.SetHttpClientFactory(factory);
    }

    #endregion

  }
}
