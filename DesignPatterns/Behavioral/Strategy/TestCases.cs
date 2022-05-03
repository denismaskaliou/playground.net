using DesignPatterns.Behavioral.Strategy.Components;
using DesignPatterns.Behavioral.Strategy.Components.Strategies;
using Xunit;

namespace DesignPatterns.Behavioral.Strategy
{
    /// <summary>
    /// Паттерн Стратегия (Strategy) представляет шаблон проектирования,
    /// который определяет набор алгоритмов, инкапсулирует каждый из них и обеспечивает их взаимозаменяемость.
    /// В зависимости от ситуации мы можем легко заменить один используемый алгоритм другим.
    /// При этом замена алгоритма происходит независимо от объекта, который использует данный алгоритм.
    /// </summary>
    public sealed class TestCases
    {
        [Fact]
        public void SetupAndRun()
        {
            var firstStrategy = new FirstStrategy();
            var secondStrategy = new SecondStrategy();

            var context = new Context(firstStrategy);
            context.ExecuteAlgorithm();

            context.Strategy = secondStrategy;
            context.ExecuteAlgorithm();
        }
    }
}