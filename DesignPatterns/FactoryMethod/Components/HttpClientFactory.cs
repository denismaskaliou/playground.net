using DesignPatterns.FactoryMethod.Components.Abstractions;

namespace DesignPatterns.FactoryMethod.Components
{
    public sealed class HttpClientFactory: IHttpClientFactory
    {
        public IHttpClient Create()
        {
            return new HttpClient();
        }
    }
}