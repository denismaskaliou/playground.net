using DesignPatterns.Behavioral.Mediator.Components.Colleagues;

namespace DesignPatterns.Behavioral.Mediator.Components
{
    public sealed class ConcreteMediator: IMediator
    {
        public FirstColleague FirstColleague { get; set; }
        public SecondColleague SecondColleague { get; set; }
        
        public void Send(string msg, Colleague colleague)
        {
            if (FirstColleague == colleague)
                SecondColleague.Notify(msg);
            else
                FirstColleague.Notify(msg);
        }
    }
}