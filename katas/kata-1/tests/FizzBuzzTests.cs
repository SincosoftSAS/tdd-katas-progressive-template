using Xunit;
using FluentAssertions;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        private readonly FizzBuzzGenerator _generator = new();

        [Fact]
        public void Generate_WithOne_ReturnsListWithOne()
        {
            var result = _generator.Generate(1);
            result.Should().BeEquivalentTo(new[] { "1" });
        }

        [Fact]
        public void Generate_WithTwo_ReturnsListWithOneTwo()
        {
            var result = _generator.Generate(2);
            result.Should().BeEquivalentTo(new[] { "1", "2" });
        }

        [Fact]
        public void Generate_WithThree_ContainsFizz()
        {
            var result = _generator.Generate(3);
            result[2].Should().Be("Fizz"); // 0-based index
        }

        [Fact]
        public void Generate_WithFive_ContainsBuzz()
        {
            var result = _generator.Generate(5);
            result[4].Should().Be("Buzz"); // 0-based index
        }
    }
}
