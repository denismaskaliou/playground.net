namespace DesignPatterns.Structural.Decorator.Components
{
    public abstract class BaseDecorator : IComponent
    {
        private readonly IComponent component;

        public BaseDecorator(IComponent component)
        {
            this.component = component;
        }
 
        public virtual void Operation()
        {
            component?.Operation();
        }
    }
}