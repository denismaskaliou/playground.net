namespace DesignPatterns.FactoryMethod.Components.Abstractions
{
    public interface IHttpClientFactory
    {
        IHttpClient Create();
    }
}