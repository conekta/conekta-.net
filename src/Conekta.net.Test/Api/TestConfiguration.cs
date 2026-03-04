namespace Conekta.net.Test.Api
{
    public static class TestConfiguration
    {
        public static readonly string BasePath =
            System.Environment.GetEnvironmentVariable("BASE_PATH") ?? "http://localhost:3000";
        public static readonly string AccessToken = "key_abc123";
    }
}
