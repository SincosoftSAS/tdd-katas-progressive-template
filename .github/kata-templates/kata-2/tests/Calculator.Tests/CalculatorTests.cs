using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new();

        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            // Arrange
            int a = 10;
            int b = 4;

            // Act
            int result = _calculator.Subtract(a, b);

            // Assert
            Assert.Equal(6, result);
        }

        // TODO: Implementa más tests usando TDD
        // Suggestions:
        // - Test multiply with positive numbers
        // - Test divide with positive numbers  
        // - Test edge cases (division by zero, negative numbers, etc.)
    }
}