using Xunit;
using FluentAssertions;

namespace Calculator.Tests
{
    /// <summary>
    /// Tests completos ejecutados en el servidor para evaluación.
    /// Los estudiantes no ven estos tests - se agregan automáticamente durante la evaluación
    /// </summary>
    public class ServerTests
    {
        private readonly Calculator _calculator = new();

        // Addition Tests
        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            _calculator.Add(2, 3).Should().Be(5);
            _calculator.Add(4, 6).Should().Be(10);
            _calculator.Add(7, 8).Should().Be(15);
        }
        
        [Fact]
        public void Add_NegativeNumbers_ReturnsSum()
        {
            _calculator.Add(-2, -3).Should().Be(-5);
            _calculator.Add(-2, 3).Should().Be(1);
            _calculator.Add(-10, 3).Should().Be(-7);
        }

        [Fact]
        public void Add_WithZero_ReturnsCorrectResult()
        {
            _calculator.Add(5, 0).Should().Be(5);
            _calculator.Add(0, -3).Should().Be(-3);
            _calculator.Add(0, 0).Should().Be(0);
        }
        
        // Subtraction Tests
        [Fact]
        public void Subtract_TwoNumbers_ReturnsResult()
        {
            _calculator.Subtract(5, 2).Should().Be(3);
            _calculator.Subtract(2, 3).Should().Be(-1);
            _calculator.Subtract(15, 5).Should().Be(10);
        }
        
        [Fact]
        public void Subtract_NegativeNumbers_ReturnsResult()
        {
            _calculator.Subtract(-5, -4).Should().Be(-1);
            _calculator.Subtract(-5, 3).Should().Be(-8);
            _calculator.Subtract(5, -3).Should().Be(8);
        }

        [Fact]
        public void Subtract_WithZero_ReturnsCorrectResult()
        {
            _calculator.Subtract(5, 0).Should().Be(5);
            _calculator.Subtract(0, 3).Should().Be(-3);
        }
        
        // Multiplication Tests
        [Fact]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            _calculator.Multiply(3, 4).Should().Be(12);
            _calculator.Multiply(0, 5).Should().Be(0);
            _calculator.Multiply(4, 5).Should().Be(20);
        }
        
        [Fact]
        public void Multiply_NegativeNumbers_ReturnsProduct()
        {
            _calculator.Multiply(-2, -3).Should().Be(6);
            _calculator.Multiply(-3, 5).Should().Be(-15);
            _calculator.Multiply(4, -3).Should().Be(-12);
        }

        [Fact]
        public void Multiply_WithZero_ReturnsZero()
        {
            _calculator.Multiply(100, 0).Should().Be(0);
            _calculator.Multiply(0, -50).Should().Be(0);
        }

        [Fact]
        public void Multiply_WithOne_ReturnsOriginal()
        {
            _calculator.Multiply(5, 1).Should().Be(5);
            _calculator.Multiply(-7, 1).Should().Be(-7);
        }
        
        // Division Tests
        [Fact]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            _calculator.Divide(8, 2).Should().Be(4);
            _calculator.Divide(9, 3).Should().Be(3);
            _calculator.Divide(25, 5).Should().Be(5);
        }
        
        [Fact]
        public void Divide_NegativeNumbers_ReturnsQuotient()
        {
            _calculator.Divide(-8, 2).Should().Be(-4);
            _calculator.Divide(-9, -3).Should().Be(3);
            _calculator.Divide(21, -3).Should().Be(-7);
        }

        [Fact]
        public void Divide_ZeroByNumber_ReturnsZero()
        {
            _calculator.Divide(0, 5).Should().Be(0);
            _calculator.Divide(0, -3).Should().Be(0);
        }

        [Fact]
        public void Divide_ByOne_ReturnsOriginal()
        {
            _calculator.Divide(15, 1).Should().Be(15);
            _calculator.Divide(-7, 1).Should().Be(-7);
        }
        
        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            var act = () => _calculator.Divide(5, 0);
            act.Should().Throw<DivideByZeroException>();
        }

        [Fact]
        public void Divide_NegativeByZero_ThrowsException()
        {
            var act = () => _calculator.Divide(-5, 0);
            act.Should().Throw<DivideByZeroException>();
        }
        
        // Edge Cases
        [Fact]
        public void EdgeCases_WorkCorrectly()
        {
            _calculator.Add(0, 0).Should().Be(0);
            _calculator.Subtract(5, 5).Should().Be(0);
            _calculator.Multiply(0, 100).Should().Be(0);
            _calculator.Divide(5, 5).Should().Be(1);
        }

        [Fact]
        public void LargeNumbers_WorkCorrectly()
        {
            _calculator.Add(1000000, 1000000).Should().Be(2000000);
            _calculator.Multiply(1000, 1000).Should().Be(1000000);
            _calculator.Divide(1000000, 2000).Should().Be(500);
        }
    }
}