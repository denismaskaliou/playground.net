namespace DesignPatterns.Behavioral.Command.Classic.Components.Commands
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}