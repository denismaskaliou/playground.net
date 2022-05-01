namespace DesignPatterns.State.Components.States
{
    public class FirstState: IState
    {
        public void Handle(Context context)
        {
            context.State = new SecondState();
        }
    }
}