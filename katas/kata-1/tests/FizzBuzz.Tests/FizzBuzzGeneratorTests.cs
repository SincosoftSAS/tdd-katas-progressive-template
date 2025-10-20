using FizzBuzz;

namespace FizzBuzz.Tests
{
    public class FizzBuzzGeneratorTests
    {
        [Fact]
        public void Generate_WithOne_ReturnsListWithOne()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(1);
            
            // Assert
            Assert.Single(result);
            Assert.Equal("1", result[0]);
        }
        
        [Fact]
        public void Generate_WithThree_ReturnsOneToThreeWithFizz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(3);
            
            // Assert
            Assert.Equal(3, result.Count);
            Assert.Equal("1", result[0]);
            Assert.Equal("2", result[1]);
            Assert.Equal("Fizz", result[2]);
        }
        
        [Fact]
        public void Generate_WithFive_ReturnsListWithBuzz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(5);
            
            // Assert
            Assert.Equal(5, result.Count);
            Assert.Equal("Buzz", result[4]);
        }
        
        [Fact]
        public void Generate_WithFifteen_ReturnsListWithFizzBuzz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(15);
            
            // Assert
            Assert.Equal(15, result.Count);
            Assert.Equal("FizzBuzz", result[14]);
        }
    }
}