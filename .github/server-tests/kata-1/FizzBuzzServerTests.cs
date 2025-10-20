using FizzBuzz;

namespace FizzBuzz.Tests.Server
{
    /// <summary>
    /// Tests completos ejecutados en el servidor para evaluación.
    /// Los estudiantes no ven estos tests - solo los 2 ejemplos en FizzBuzzGeneratorTests.cs
    /// </summary>
    public class FizzBuzzServerTests
    {
        [Fact]
        public void Generate_WithOne_ReturnsListWithOne()
        {
            var result = FizzBuzzGenerator.Generate(1);
            Assert.Single(result);
            Assert.Equal("1", result[0]);
        }

        [Fact] 
        public void Generate_WithTwo_ReturnsListWithOneTwo()
        {
            var result = FizzBuzzGenerator.Generate(2);
            Assert.Equal(2, result.Count);
            Assert.Equal("1", result[0]);
            Assert.Equal("2", result[1]);
        }

        [Fact]
        public void Generate_WithThree_ReturnsOneToThreeWithFizz()
        {
            var result = FizzBuzzGenerator.Generate(3);
            Assert.Equal(3, result.Count);
            Assert.Equal("1", result[0]);
            Assert.Equal("2", result[1]);
            Assert.Equal("Fizz", result[2]);
        }

        [Fact]
        public void Generate_WithFive_ReturnsListWithBuzz()
        {
            var result = FizzBuzzGenerator.Generate(5);
            Assert.Equal(5, result.Count);
            Assert.Equal("1", result[0]);
            Assert.Equal("2", result[1]);
            Assert.Equal("Fizz", result[2]);
            Assert.Equal("4", result[3]);
            Assert.Equal("Buzz", result[4]);
        }

        [Fact]
        public void Generate_WithFifteen_ReturnsListWithFizzBuzz()
        {
            var result = FizzBuzzGenerator.Generate(15);
            Assert.Equal(15, result.Count);
            Assert.Equal("FizzBuzz", result[14]);
        }

        [Fact]
        public void Generate_MultipleOf3_ReturnsFizz()
        {
            var result = FizzBuzzGenerator.Generate(9);
            Assert.Equal("Fizz", result[2]);  // 3
            Assert.Equal("Fizz", result[5]);  // 6
            Assert.Equal("Fizz", result[8]);  // 9
        }

        [Fact]
        public void Generate_MultipleOf5_ReturnsBuzz()
        {
            var result = FizzBuzzGenerator.Generate(10);
            Assert.Equal("Buzz", result[4]);  // 5
            Assert.Equal("Buzz", result[9]);  // 10
        }

        [Fact]
        public void Generate_MultipleOf15_ReturnsFizzBuzz()
        {
            var result = FizzBuzzGenerator.Generate(30);
            Assert.Equal("FizzBuzz", result[14]); // 15
            Assert.Equal("FizzBuzz", result[29]); // 30
        }

        [Fact]
        public void Generate_WithZero_ReturnsEmptyList()
        {
            var result = FizzBuzzGenerator.Generate(0);
            Assert.Empty(result);
        }

        [Fact]
        public void Generate_CompleteSequence_IsCorrect()
        {
            var result = FizzBuzzGenerator.Generate(15);
            var expected = new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };
            Assert.Equal(expected, result);
        }
    }
}