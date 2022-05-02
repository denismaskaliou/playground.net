using System;

namespace DesignPatterns.Structural.Decorator.Components.Decorators
{
    public sealed class FirstDecorator : BaseDecorator
    {
        public FirstDecorator(IComponent component) : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Add first behavior");
        }
    }
}