namespace DesignPatterns.Behavioral.Mediator.Components.Colleagues
{
    public sealed class FirstColleague : Colleague
    {
        public FirstColleague(IMediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
        }
    }
}