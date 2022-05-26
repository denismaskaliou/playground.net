namespace DesignPatterns.Structural.Bridge.Components.Abstractions
{
    public sealed class FirstAbstraction : Abstraction
    {
        public FirstAbstraction(Implementor imp) : base(imp)
        {
        }

        public override void Operation()
        {
            // Do some logic
            base.Operation();
        }
    }
}