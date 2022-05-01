using System;

namespace DesignPatterns.ChainOfResponsibility.Components.Handlers
{
    public sealed class SecondHandler : Handler
    {
        public override void HandleRequest(Context context)
        {
            // Do first action
            Console.WriteLine("Do second action");

            // Rub next
            Next?.HandleRequest(context);
        }
    }
}