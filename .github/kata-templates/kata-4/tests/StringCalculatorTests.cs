using Xunit;

namespace StringCalculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Calculate_EmptyString_ReturnsZero()
        {
            // Ejemplo: cadena vacía debe retornar 0
            var result = Calculator.Calculate("");
            Assert.Equal(0, result);
        }

        [Fact]
        public void Calculate_TwoNumbers_ReturnsSum()
        {
            // Ejemplo: "1,2" debe retornar 3
            Assert.Equal(3, Calculator.Calculate("1,2"));
        }
    }
}