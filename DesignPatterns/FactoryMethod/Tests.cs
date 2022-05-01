using DesignPatterns.FactoryMethod.Components;
using Xunit;

namespace DesignPatterns.FactoryMethod
{
    public sealed class Tests
    {
        [Fact]
        public void SetupAndUseFactoryMethod()
        {
            // Register and inject HttpClientFactory
            var httpClientFactory = new HttpClientFactory();

            // Use instance of HttpClientFactory for create HttpClient
            var httpClient = httpClientFactory.Create();

            // User HttpClient
            httpClient.Send();
        }
    }
}