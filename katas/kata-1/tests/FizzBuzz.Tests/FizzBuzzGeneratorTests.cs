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