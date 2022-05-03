namespace DesignPatterns.Structural.Adapter.Components
{
    public sealed class TargetAdapter: Target
    {
        private readonly Adaptee adaptee;

        public TargetAdapter(Adaptee adaptee)
        {
            adaptee = adaptee;
        }
        
        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}