namespace DesignPatterns.Behavioral.Mediator.Components
{
    public abstract class Colleague
    {
        protected IMediator mediator;
 
        public Colleague(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}