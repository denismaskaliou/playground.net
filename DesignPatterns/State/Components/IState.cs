namespace DesignPatterns.State.Components
{
    public interface IState
    {
        public void Handle(Context context);
    }
}