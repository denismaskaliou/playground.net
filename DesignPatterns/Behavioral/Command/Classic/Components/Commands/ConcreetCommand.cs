namespace DesignPatterns.Behavioral.Command.Classic.Components.Commands
{
    public sealed class ConcreteCommand : ICommand
    {
        private readonly Receiver receiver;
        
        public ConcreteCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }
        
        public void Execute()
        {
            receiver.DoOperation();
        }

        public void Undo()
        {
            
        }
    }
}