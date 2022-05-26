namespace DesignPatterns.Structural.Bridge.Components.Abstractions
{
    public sealed class SecondAbstraction : Abstraction
    {
        public SecondAbstraction(Implementor imp) : base(imp)
        {
        }

        public override void Operation()
        {
            // Do some logic
            base.Operation();
        }
    }
}