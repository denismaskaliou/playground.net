namespace DesignPatterns.Command.Classic.Components
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}