namespace Conekta.net.Test.Api;

using System;
using System.IO;
public class BaseTest
{
    public static readonly string BasePath = Environment.GetEnvironmentVariable("BASE_PATH") ?? "http://host.docker.internal:3000";
}