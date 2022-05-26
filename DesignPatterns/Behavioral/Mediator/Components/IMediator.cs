namespace DesignPatterns.Behavioral.Mediator.Components
{
    public interface IMediator
    {
        void Send(string msg, Colleague colleague);
    }
}