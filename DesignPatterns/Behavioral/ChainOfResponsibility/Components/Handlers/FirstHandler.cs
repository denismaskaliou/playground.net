using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.Components.Handlers
{
    public sealed class FirstHandler : Handler
    {
        public override void HandleRequest(Context context)
        {
            // Do first action
            Console.WriteLine("Do first action");
            
            // Run next
            Next?.HandleRequest(context);
        }
    }
}