using Calculator;

namespace Calculator.Tests.Server
{
    /// <summary>
    /// Tests completos ejecutados en el servidor para evaluación.
    /// Los estudiantes no ven estos tests - solo los 2 ejemplos en CalculatorTests.cs
    /// </summary>
    public class CalculatorServerTests
    {
        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            var calculator = new Calculator();
            Assert.Equal(5, calculator.Add(2, 3));
            Assert.Equal(10, calculator.Add(4, 6));
        }
        
        [Fact]
        public void Add_NegativeNumbers_ReturnsSum()
        {
            var calculator = new Calculator();
            Assert.Equal(-5, calculator.Add(-2, -3));
            Assert.Equal(1, calculator.Add(-2, 3));
        }
        
        [Fact]
        public void Subtract_TwoNumbers_ReturnsResult()
        {
            var calculator = new Calculator();
            Assert.Equal(3, calculator.Subtract(5, 2));
            Assert.Equal(-1, calculator.Subtract(2, 3));
        }
        
        [Fact]
        public void Subtract_NegativeNumbers_ReturnsResult()
        {
            var calculator = new Calculator();
            Assert.Equal(-1, calculator.Subtract(-5, -4));
            Assert.Equal(-8, calculator.Subtract(-5, 3));
        }
        
        [Fact]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            var calculator = new Calculator();
            Assert.Equal(12, calculator.Multiply(3, 4));
            Assert.Equal(0, calculator.Multiply(0, 5));
        }
        
        [Fact]
        public void Multiply_NegativeNumbers_ReturnsProduct()
        {
            var calculator = new Calculator();
            Assert.Equal(6, calculator.Multiply(-2, -3));
            Assert.Equal(-15, calculator.Multiply(-3, 5));
        }
        
        [Fact]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            var calculator = new Calculator();
            Assert.Equal(4, calculator.Divide(8, 2));
            Assert.Equal(3, calculator.Divide(9, 3));
        }
        
        [Fact]
        public void Divide_NegativeNumbers_ReturnsQuotient()
        {
            var calculator = new Calculator();
            Assert.Equal(-4, calculator.Divide(-8, 2));
            Assert.Equal(3, calculator.Divide(-9, -3));
        }
        
        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(5, 0));
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(-5, 0));
        }
        
        [Fact]
        public void EdgeCases_WorkCorrectly()
        {
            var calculator = new Calculator();
            Assert.Equal(0, calculator.Add(0, 0));
            Assert.Equal(0, calculator.Subtract(5, 5));
            Assert.Equal(0, calculator.Multiply(0, 100));
            Assert.Equal(1, calculator.Divide(5, 5));
        }
    }
}