namespace DesignPatterns.Structural.Adapter.Components
{
    public sealed class Client
    {
        public void Request(Target target)
        {
            target.Request();
        }
    }
}