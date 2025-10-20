using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            // Arrange
            var calculator = new Calculator();
            
            // Act
            var result = calculator.Add(2, 3);
            
            // Assert
            Assert.Equal(5, result);
        }
        
        // TODO: Añade más tests siguiendo TDD
        // - Subtract tests
        // - Multiply tests  
        // - Divide tests
        // - División por cero
        // - Números negativos
    }
}