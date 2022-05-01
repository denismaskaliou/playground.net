namespace DesignPatterns.TemplateMethod.Components
{
    public abstract class AbstractTemplateMethod: ITemplateMethod
    {
        public virtual void TemplateMethod()
        {
            Operation1();
            Operation2();
        }

        public abstract void Operation1();
        public abstract void Operation2();
    }
}