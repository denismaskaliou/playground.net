using DesignPatterns.Creational.FactoryMethod.Components.Abstractions;

namespace DesignPatterns.Creational.FactoryMethod.Components
{
    public sealed class HttpClientFactory: IHttpClientFactory
    {
        public IHttpClient Create()
        {
            return new HttpClient();
        }
    }
}