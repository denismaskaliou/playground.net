using DesignPatterns.Behavioral.Command.Classic.Components;
using DesignPatterns.Behavioral.Command.Classic.Components.Commands;
using Xunit;

namespace DesignPatterns.Behavioral.Command.Classic
{
    /// <summary>
    /// Паттерн "Команда" (Command) позволяет инкапсулировать запрос на выполнение определенного действия в виде отдельного объекта.
    /// Этот объект запроса на действие и называется командой. При этом объекты, инициирующие запросы на выполнение действия,
    /// отделяются от объектов, которые выполняют это действие.
    /// </summary>
    public sealed class Tests
    {
        [Fact]
        public void SetupAndUseCommand()
        {
            var receiver = new Receiver();
            var invoker = new Invoker();
            
            invoker.SetupCommand(new ConcreteCommand(receiver));
            invoker.Run();
            invoker.Cancel();
        }
    }
}