using System;
using DesignPatterns.FactoryMethod.Components.Abstractions;

namespace DesignPatterns.FactoryMethod.Components
{
    public sealed class HttpClient : IHttpClient
    {
        public void Send()
        {
            Console.WriteLine("Send request!");
        }
    }
}