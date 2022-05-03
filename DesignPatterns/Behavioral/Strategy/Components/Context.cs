namespace DesignPatterns.Behavioral.Strategy.Components
{
    public sealed class Context
    {
        public IStrategy Strategy { get; set; }

        public Context(IStrategy strategy)
        {
            Strategy = strategy;
        }

        public void ExecuteAlgorithm()
        {
            Strategy.Algorithm();
        }
    }
}