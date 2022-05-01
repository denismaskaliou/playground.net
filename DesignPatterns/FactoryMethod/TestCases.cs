using DesignPatterns.FactoryMethod.Components;
using Xunit;

namespace DesignPatterns.FactoryMethod
{
    /// <summary>
    /// Фабричный метод (Factory Method) - это паттерн, который определяет интерфейс для создания объектов некоторого класса,
    /// но непосредственное решение о том, объект какого класса создавать происходит в подклассах.
    /// То есть паттерн предполагает, что базовый класс делегирует создание объектов классам-наследникам.
    /// </summary>
    public sealed class TestCases
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