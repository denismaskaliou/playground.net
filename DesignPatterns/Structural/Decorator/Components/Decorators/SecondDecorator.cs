using System;

namespace DesignPatterns.Structural.Decorator.Components.Decorators
{
    public sealed class SecondDecorator : BaseDecorator
    {
        public SecondDecorator(IComponent component) : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Add second behavior");
        }
    }
}