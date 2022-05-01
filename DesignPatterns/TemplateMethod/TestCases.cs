using DesignPatterns.TemplateMethod.Components;
using Xunit;

namespace DesignPatterns.TemplateMethod
{
    /// <summary>
    /// Шаблонный метод (Template Method) определяет общий алгоритм поведения подклассов,
    /// позволяя им переопределить отдельные шаги этого алгоритма без изменения его структуры.
    /// </summary>
    public sealed class TestCases
    {
        [Fact]
        public void SetupAndUseTemplateMethod()
        {
            var templateMethod = new ConcreteTemplateMethod();
            templateMethod.TemplateMethod();
        }
    }
}