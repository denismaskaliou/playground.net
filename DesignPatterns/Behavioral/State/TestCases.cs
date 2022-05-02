using DesignPatterns.Behavioral.State.Components;
using DesignPatterns.Behavioral.State.Components.States;
using Xunit;

namespace DesignPatterns.Behavioral.State
{
    /// <summary>
    /// Состояние (State) - шаблон проектирования, который позволяет объекту изменять
    /// свое поведение в зависимости от внутреннего состояния.
    /// </summary>
    public sealed class TestCases
    {
        [Fact]
        public void SetupAndRun()
        {
            var context = new Context(new ZeroState());
            context.Request();
            context.Request();
        }
    }
}