using DesignPatterns.Structural.Bridge.Components.Abstractions;
using DesignPatterns.Structural.Bridge.Components.Implementors;
using Xunit;

namespace DesignPatterns.Structural.Bridge
{
    /// <summary>
    /// Мост (Bridge) - структурный шаблон проектирования, который позволяет отделить абстракцию от реализации таким образом,
    /// чтобы и абстракцию, и реализацию можно было изменять независимо друг от друга.
    /// </summary>
    public sealed class TestCases
    {
        [Fact]
        public void SetupAndRun()
        {
            var firstImplementor = new FirstImplementor();
            var secondImplementor = new SecondImplementor();

            var firstAbstraction = new FirstAbstraction(firstImplementor);
            firstAbstraction.Operation();
            firstAbstraction.Implementor = secondImplementor;
            firstAbstraction.Operation();

            var secondAbstraction = new SecondAbstraction(firstImplementor);
            secondAbstraction.Operation();
            secondAbstraction.Implementor = secondImplementor;
            secondAbstraction.Operation();
        }
    }
}