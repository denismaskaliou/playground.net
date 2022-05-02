using System;
using DesignPatterns.Creational.FactoryMethod.Components.Abstractions;

namespace DesignPatterns.Creational.FactoryMethod.Components
{
    public sealed class HttpClient : IHttpClient
    {
        public void Send()
        {
            Console.WriteLine("Send request!");
        }
    }
}