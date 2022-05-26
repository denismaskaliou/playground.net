using DesignPatterns.Behavioral.Mediator.Components;
using DesignPatterns.Behavioral.Mediator.Components.Colleagues;
using Xunit;

namespace DesignPatterns.Behavioral.Mediator
{
    /// <summary>
    /// Паттерн Посредник (Mediator) представляет такой шаблон проектирования,
    /// который обеспечивает взаимодействие множества объектов без необходимости ссылаться друг на друга.
    /// Тем самым достигается слабосвязанность взаимодействующих объектов.
    /// </summary>
    public sealed class UseCases
    {
        [Fact]
        public void SetupAndRun()
        {
            var mediator = new ConcreteMediator();

            var firstColleague = new FirstColleague(mediator);
            var secondColleague = new SecondColleague(mediator);

            mediator.FirstColleague = firstColleague;
            mediator.SecondColleague = secondColleague;
            
            firstColleague.Send("Hello");
        }
    }
}