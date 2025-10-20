using Xunit;

namespace Calculator.Tests
{
    /// <summary>
    /// Tests completos ejecutados en el servidor para evaluación.
    /// Los estudiantes no ven estos tests - solo los 2 ejemplos en CalculatorTests.cs
    /// </summary>
    public class CalculatorServerTests
    {
        private readonly Calculator _calculator = new();

        // Addition Tests
        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            Assert.Equal(5, _calculator.Add(2, 3));
            Assert.Equal(10, _calculator.Add(4, 6));
            Assert.Equal(15, _calculator.Add(7, 8));
        }
        
        [Fact]
        public void Add_NegativeNumbers_ReturnsSum()
        {
            Assert.Equal(-5, _calculator.Add(-2, -3));
            Assert.Equal(1, _calculator.Add(-2, 3));
            Assert.Equal(-7, _calculator.Add(-10, 3));
        }

        [Fact]
        public void Add_WithZero_ReturnsCorrectResult()
        {
            Assert.Equal(5, _calculator.Add(5, 0));
            Assert.Equal(-3, _calculator.Add(0, -3));
            Assert.Equal(0, _calculator.Add(0, 0));
        }
        
        // Subtraction Tests
        [Fact]
        public void Subtract_TwoNumbers_ReturnsResult()
        {
            Assert.Equal(3, _calculator.Subtract(5, 2));
            Assert.Equal(-1, _calculator.Subtract(2, 3));
            Assert.Equal(10, _calculator.Subtract(15, 5));
        }
        
        [Fact]
        public void Subtract_NegativeNumbers_ReturnsResult()
        {
            Assert.Equal(-1, _calculator.Subtract(-5, -4));
            Assert.Equal(-8, _calculator.Subtract(-5, 3));
            Assert.Equal(8, _calculator.Subtract(5, -3));
        }

        [Fact]
        public void Subtract_WithZero_ReturnsCorrectResult()
        {
            Assert.Equal(5, _calculator.Subtract(5, 0));
            Assert.Equal(-3, _calculator.Subtract(0, 3));
        }
        
        // Multiplication Tests
        [Fact]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            Assert.Equal(12, _calculator.Multiply(3, 4));
            Assert.Equal(0, _calculator.Multiply(0, 5));
            Assert.Equal(20, _calculator.Multiply(4, 5));
        }
        
        [Fact]
        public void Multiply_NegativeNumbers_ReturnsProduct()
        {
            Assert.Equal(6, _calculator.Multiply(-2, -3));
            Assert.Equal(-15, _calculator.Multiply(-3, 5));
            Assert.Equal(-12, _calculator.Multiply(4, -3));
        }

        [Fact]
        public void Multiply_WithZero_ReturnsZero()
        {
            Assert.Equal(0, _calculator.Multiply(100, 0));
            Assert.Equal(0, _calculator.Multiply(0, -50));
        }

        [Fact]
        public void Multiply_WithOne_ReturnsOriginal()
        {
            Assert.Equal(5, _calculator.Multiply(5, 1));
            Assert.Equal(-7, _calculator.Multiply(-7, 1));
        }
        
        // Division Tests
        [Fact]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            Assert.Equal(4, _calculator.Divide(8, 2));
            Assert.Equal(3, _calculator.Divide(9, 3));
            Assert.Equal(5, _calculator.Divide(25, 5));
        }
        
        [Fact]
        public void Divide_NegativeNumbers_ReturnsQuotient()
        {
            Assert.Equal(-4, _calculator.Divide(-8, 2));
            Assert.Equal(3, _calculator.Divide(-9, -3));
            Assert.Equal(-7, _calculator.Divide(21, -3));
        }

        [Fact]
        public void Divide_ZeroByNumber_ReturnsZero()
        {
            Assert.Equal(0, _calculator.Divide(0, 5));
            Assert.Equal(0, _calculator.Divide(0, -3));
        }

        [Fact]
        public void Divide_ByOne_ReturnsOriginal()
        {
            Assert.Equal(15, _calculator.Divide(15, 1));
            Assert.Equal(-7, _calculator.Divide(-7, 1));
        }
        
        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(5, 0));
        }

        [Fact]
        public void Divide_NegativeByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(-5, 0));
        }
        
        // Edge Cases
        [Fact]
        public void EdgeCases_WorkCorrectly()
        {
            Assert.Equal(0, _calculator.Add(0, 0));
            Assert.Equal(0, _calculator.Subtract(5, 5));
            Assert.Equal(0, _calculator.Multiply(0, 100));
            Assert.Equal(1, _calculator.Divide(5, 5));
        }

        [Fact]
        public void LargeNumbers_WorkCorrectly()
        {
            Assert.Equal(2000000, _calculator.Add(1000000, 1000000));
            Assert.Equal(1000000, _calculator.Multiply(1000, 1000));
            Assert.Equal(500, _calculator.Divide(1000000, 2000));
        }
    }
}