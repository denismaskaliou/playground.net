using DesignPatterns.Structural.Proxy.Components;
using Xunit;

namespace DesignPatterns.Structural.Proxy
{
    public sealed class UseCases
    {
        /// <summary>
        /// Паттерн Заместитель (Proxy) предоставляет объект-заместитель, который управляет доступом к другому объекту.
        /// То есть создается объект-суррогат, который может выступать в роли другого объекта и замещать его.
        /// </summary>
        [Fact]
        public void SetupAndRun()
        {
            var subject = new SubjectProxy();
            subject.Request();
        }
    }
}