using FizzBuzz;
using Xunit;
using FluentAssertions;

namespace FizzBuzz.Tests
{
    /// <summary>
    /// Tests completos ejecutados en el servidor para evaluación.
    /// Los estudiantes no ven estos tests - se agregan automáticamente durante la evaluación
    /// </summary>
    public class ServerTests
    {
        [Fact]
        public void Generate_WithOne_ReturnsListWithOne()
        {
            var result = FizzBuzzGenerator.Generate(1);
            result.Should().HaveCount(1);
            result[0].Should().Be("1");
        }

        [Fact] 
        public void Generate_WithTwo_ReturnsListWithOneTwo()
        {
            var result = FizzBuzzGenerator.Generate(2);
            result.Should().HaveCount(2);
            result[0].Should().Be("1");
            result[1].Should().Be("2");
        }

        [Fact]
        public void Generate_WithThree_ReturnsOneToThreeWithFizz()
        {
            var result = FizzBuzzGenerator.Generate(3);
            result.Should().HaveCount(3);
            result[0].Should().Be("1");
            result[1].Should().Be("2");
            result[2].Should().Be("Fizz");
        }

        [Fact]
        public void Generate_WithFive_ReturnsListWithBuzz()
        {
            var result = FizzBuzzGenerator.Generate(5);
            result.Should().HaveCount(5);
            result[0].Should().Be("1");
            result[1].Should().Be("2");
            result[2].Should().Be("Fizz");
            result[3].Should().Be("4");
            result[4].Should().Be("Buzz");
        }

        [Fact]
        public void Generate_WithFifteen_ReturnsListWithFizzBuzz()
        {
            var result = FizzBuzzGenerator.Generate(15);
            result.Should().HaveCount(15);
            result[14].Should().Be("FizzBuzz");
        }

        [Fact]
        public void Generate_MultipleOf3_ReturnsFizz()
        {
            var result = FizzBuzzGenerator.Generate(9);
            result[2].Should().Be("Fizz");  // 3
            result[5].Should().Be("Fizz");  // 6
            result[8].Should().Be("Fizz");  // 9
        }

        [Fact]
        public void Generate_MultipleOf5_ReturnsBuzz()
        {
            var result = FizzBuzzGenerator.Generate(10);
            result[4].Should().Be("Buzz");  // 5
            result[9].Should().Be("Buzz");  // 10
        }

        [Fact]
        public void Generate_MultipleOf15_ReturnsFizzBuzz()
        {
            var result = FizzBuzzGenerator.Generate(30);
            result[14].Should().Be("FizzBuzz"); // 15
            result[29].Should().Be("FizzBuzz"); // 30
        }

        [Fact]
        public void Generate_WithZero_ReturnsEmptyList()
        {
            var result = FizzBuzzGenerator.Generate(0);
            result.Should().BeEmpty();
        }

        [Fact]
        public void Generate_CompleteSequence_IsCorrect()
        {
            var result = FizzBuzzGenerator.Generate(15);
            var expected = new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };
            result.Should().BeEquivalentTo(expected);
        }

    }
}