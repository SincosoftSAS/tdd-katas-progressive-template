using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        private readonly FizzBuzzGenerator _generator = new();

        [Fact]
        public void Generate_WithOne_ReturnsListWithOne()
        {
            var result = _generator.Generate(1);
            Assert.Equal(new[] { "1" }, result);
        }

        [Fact]
        public void Generate_WithTwo_ReturnsListWithOneTwo()
        {
            var result = _generator.Generate(2);
            Assert.Equal(new[] { "1", "2" }, result);
        }

        [Fact]
        public void Generate_WithThree_ContainsFizz()
        {
            var result = _generator.Generate(3);
            Assert.Equal("Fizz", result[2]); // 0-based index
        }

        [Fact]
        public void Generate_WithFive_ContainsBuzz()
        {
            var result = _generator.Generate(5);
            Assert.Equal("Buzz", result[4]); // 0-based index
        }
    }
}
