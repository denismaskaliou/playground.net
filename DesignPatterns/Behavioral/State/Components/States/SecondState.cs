namespace DesignPatterns.Behavioral.State.Components.States
{
    public class SecondState: IState
    {
        public void Handle(Context context)
        {
            context.State = new ZeroState();
        }
    }
}