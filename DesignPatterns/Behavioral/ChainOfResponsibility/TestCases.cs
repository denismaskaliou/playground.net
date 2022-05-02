using DesignPatterns.Behavioral.ChainOfResponsibility.Components;
using DesignPatterns.Behavioral.ChainOfResponsibility.Components.Handlers;
using Xunit;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    /// <summary>
    /// Цепочка Обязанностей (Chain of responsibility) - поведенческий шаблон проектирования,
    /// который позволяет избежать жесткой привязки отправителя запроса к получателю.
    /// Все возможные обработчики запроса образуют цепочку, а сам запрос перемещается по этой цепочке.
    /// Каждый объект в этой цепочке при получении запроса выбирает, либо закончить обработку запроса,
    /// либо передать запрос на обработку следующему по цепочке объекту.
    /// </summary>
    public sealed class TestCases
    {
        [Fact]
        public void SetupAndRun()
        {
            var context = new Context();
            var firstHandler = new FirstHandler();
            var secondHandler = new SecondHandler();

            // Setup next
            firstHandler.Next = secondHandler;
            
            // Run chain
            firstHandler.HandleRequest(context);
        }
    }
}