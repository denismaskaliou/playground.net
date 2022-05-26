using System.Text;
using Xunit;

namespace DotNet.Strings
{
    public sealed class StringBuilderTests
    {
        private readonly StringBuilder stringBuilder;

        public StringBuilderTests()
        {
            stringBuilder = new StringBuilder();
        }

        [Fact]
        public void SetupAndRun()
        {
            // Arrange
            var expectedResult = "Hello denis !";

            // Act
            stringBuilder.Append("Hello");
            stringBuilder.Append(' ');
            stringBuilder.Append("denis");
            stringBuilder.Append(' ');
            stringBuilder.Append('!');
            
            // Assert
            Assert.Equal(expectedResult, stringBuilder.ToString());
        }
    }
}