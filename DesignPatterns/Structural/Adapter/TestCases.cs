using DesignPatterns.Structural.Adapter.Components;
using Xunit;

namespace DesignPatterns.Structural.Adapter
{
    /// <summary>
    /// Паттерн Адаптер (Adapter) предназначен для преобразования интерфейса одного класса в интерфейс другого.
    /// Благодаря реализации данного паттерна мы можем использовать вместе классы с несовместимыми интерфейсами.
    /// </summary>
    public sealed class TestCases
    {
        [Fact]
        public void SetupAndRun()
        {
            var adaptee = new Adaptee();
            var target = new TargetAdapter(adaptee);
            
            var client = new Client();
            client.Request(target);
        }
    }
}