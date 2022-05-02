using DesignPatterns.Behavioral.Command.Classic.Components.Commands;

namespace DesignPatterns.Behavioral.Command.Classic.Components
{
    public sealed class Invoker
    {
        private ICommand command;
        
        public void SetupCommand(ICommand command)
        {
            this.command = command;
        }
        
        public void Run()
        {
            command.Execute();
        }
        public void Cancel()
        {
            command.Undo();
        }
    }
}