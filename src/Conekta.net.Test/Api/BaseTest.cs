namespace Conekta.net.Test.Api
{
    public class BaseTest
    {
        public static readonly string BasePath = System.Environment.GetEnvironmentVariable("BASE_PATH") ?? "http://localhost:3000";
    }
}
