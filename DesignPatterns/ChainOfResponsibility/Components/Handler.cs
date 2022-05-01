namespace DesignPatterns.ChainOfResponsibility.Components
{
    public abstract class Handler
    {
        public Handler Next { get; set; }
        public abstract void HandleRequest(Context context);
    }
}