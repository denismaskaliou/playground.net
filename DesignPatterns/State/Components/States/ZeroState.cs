namespace DesignPatterns.State.Components.States
{
    public class ZeroState: IState
    {
        public void Handle(Context context)
        {
            context.State = new FirstState();
        }
    }
}