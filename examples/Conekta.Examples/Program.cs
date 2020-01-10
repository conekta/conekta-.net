using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Conekta.Models;
using Conekta.Exceptions;
using System.Collections.Generic;
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

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("  [-] Creating Order...");

        var orderContext = new OrderContext();

        var orderCreationData = new OrderCreationData
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
        Console.WriteLine($"    [->] { JsonConvert.SerializeObject(orderCreated) }");

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
