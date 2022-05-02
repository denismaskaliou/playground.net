namespace DesignPatterns.Creational.FactoryMethod.Components.Abstractions
{
    public interface IHttpClientFactory
    {
        IHttpClient Create();
    }
}