using DesignPatterns.Structural.Decorator.Components;
using DesignPatterns.Structural.Decorator.Components.Decorators;
using Xunit;

namespace DesignPatterns.Structural.Decorator
{
    /// <summary>
    /// Декоратор (Decorator) представляет структурный шаблон проектирования,
    /// который позволяет динамически подключать к объекту дополнительную функциональность.
    /// </summary>
    public sealed class TestCases
    {
        [Fact]
        public void SetupAndRun()
        {
            IComponent component = new Component();
            
            IComponent decoratedComponent = new FirstDecorator(component);
            decoratedComponent = new SecondDecorator(decoratedComponent);
            decoratedComponent.Operation();
        }
    }
}