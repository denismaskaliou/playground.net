using System;

namespace DesignPatterns.Structural.Decorator.Components
{
    public sealed class Component : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("Do operation");
        }
    }
}