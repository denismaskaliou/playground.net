namespace DesignPatterns.Structural.Proxy.Components
{
    public sealed class SubjectProxy : ISubject
    {
        private readonly RealSubject subject;

        public SubjectProxy()
        {
            subject = new RealSubject();
        }

        public void Request()
        {
            // Do additional actions
            subject.Request();
        }
    }
}