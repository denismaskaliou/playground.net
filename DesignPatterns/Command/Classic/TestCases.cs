using DesignPatterns.Command.Classic.Components;
using DesignPatterns.Command.Classic.Components.Commands;
using Xunit;

namespace DesignPatterns.Command.Classic
{
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