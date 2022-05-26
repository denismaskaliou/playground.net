namespace DesignPatterns.Structural.Bridge.Components
{
    public abstract class Abstraction
    {
        protected Implementor implementor;

        public Implementor Implementor
        {
            set => implementor = value;
        }

        public Abstraction(Implementor implementor)
        {
            implementor = implementor;
        }

        public virtual void Operation()
        {
            implementor.OperationImp();
        }
    }
}