namespace DesignPatterns.Behavioral.State.Components
{
    public sealed class Context
    {
        public IState State { get; set; }

        public Context(IState state)
        {
            State = state;
        }

        public void Request()
        {
            State.Handle(this);
        }
    }
}