using Calculator;

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
        
        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            // Arrange
            var calculator = new Calculator();
            
            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(5, 0));
        }
    }
}