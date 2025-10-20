using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests.Server
{
    /// <summary>
    /// Tests completos ejecutados en el servidor para evaluación.
    /// Los estudiantes no ven estos tests - solo los 2 ejemplos en CalculatorTests.cs
    /// </summary>
    [TestClass]
    public class CalculatorServerTests
    {
        private Calculator _calculator;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        // Addition Tests
        [TestMethod]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            Assert.AreEqual(5, _calculator.Add(2, 3));
            Assert.AreEqual(10, _calculator.Add(4, 6));
            Assert.AreEqual(15, _calculator.Add(7, 8));
        }
        
        [TestMethod]
        public void Add_NegativeNumbers_ReturnsSum()
        {
            Assert.AreEqual(-5, _calculator.Add(-2, -3));
            Assert.AreEqual(1, _calculator.Add(-2, 3));
            Assert.AreEqual(-7, _calculator.Add(-10, 3));
        }

        [TestMethod]
        public void Add_WithZero_ReturnsCorrectResult()
        {
            Assert.AreEqual(5, _calculator.Add(5, 0));
            Assert.AreEqual(-3, _calculator.Add(0, -3));
            Assert.AreEqual(0, _calculator.Add(0, 0));
        }
        
        // Subtraction Tests
        [TestMethod]
        public void Subtract_TwoNumbers_ReturnsResult()
        {
            Assert.AreEqual(3, _calculator.Subtract(5, 2));
            Assert.AreEqual(-1, _calculator.Subtract(2, 3));
            Assert.AreEqual(10, _calculator.Subtract(15, 5));
        }
        
        [TestMethod]
        public void Subtract_NegativeNumbers_ReturnsResult()
        {
            Assert.AreEqual(-1, _calculator.Subtract(-5, -4));
            Assert.AreEqual(-8, _calculator.Subtract(-5, 3));
            Assert.AreEqual(8, _calculator.Subtract(5, -3));
        }

        [TestMethod]
        public void Subtract_WithZero_ReturnsCorrectResult()
        {
            Assert.AreEqual(5, _calculator.Subtract(5, 0));
            Assert.AreEqual(-3, _calculator.Subtract(0, 3));
        }
        
        // Multiplication Tests
        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            Assert.AreEqual(12, _calculator.Multiply(3, 4));
            Assert.AreEqual(0, _calculator.Multiply(0, 5));
            Assert.AreEqual(20, _calculator.Multiply(4, 5));
        }
        
        [TestMethod]
        public void Multiply_NegativeNumbers_ReturnsProduct()
        {
            Assert.AreEqual(6, _calculator.Multiply(-2, -3));
            Assert.AreEqual(-15, _calculator.Multiply(-3, 5));
            Assert.AreEqual(-12, _calculator.Multiply(4, -3));
        }

        [TestMethod]
        public void Multiply_WithZero_ReturnsZero()
        {
            Assert.AreEqual(0, _calculator.Multiply(100, 0));
            Assert.AreEqual(0, _calculator.Multiply(0, -50));
        }

        [TestMethod]
        public void Multiply_WithOne_ReturnsOriginal()
        {
            Assert.AreEqual(5, _calculator.Multiply(5, 1));
            Assert.AreEqual(-7, _calculator.Multiply(-7, 1));
        }
        
        // Division Tests
        [TestMethod]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            Assert.AreEqual(4, _calculator.Divide(8, 2));
            Assert.AreEqual(3, _calculator.Divide(9, 3));
            Assert.AreEqual(5, _calculator.Divide(25, 5));
        }
        
        [TestMethod]
        public void Divide_NegativeNumbers_ReturnsQuotient()
        {
            Assert.AreEqual(-4, _calculator.Divide(-8, 2));
            Assert.AreEqual(3, _calculator.Divide(-9, -3));
            Assert.AreEqual(-7, _calculator.Divide(21, -3));
        }

        [TestMethod]
        public void Divide_ZeroByNumber_ReturnsZero()
        {
            Assert.AreEqual(0, _calculator.Divide(0, 5));
            Assert.AreEqual(0, _calculator.Divide(0, -3));
        }

        [TestMethod]
        public void Divide_ByOne_ReturnsOriginal()
        {
            Assert.AreEqual(15, _calculator.Divide(15, 1));
            Assert.AreEqual(-7, _calculator.Divide(-7, 1));
        }
        
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ByZero_ThrowsException()
        {
            _calculator.Divide(5, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_NegativeByZero_ThrowsException()
        {
            _calculator.Divide(-5, 0);
        }
        
        // Edge Cases
        [TestMethod]
        public void EdgeCases_WorkCorrectly()
        {
            Assert.AreEqual(0, _calculator.Add(0, 0));
            Assert.AreEqual(0, _calculator.Subtract(5, 5));
            Assert.AreEqual(0, _calculator.Multiply(0, 100));
            Assert.AreEqual(1, _calculator.Divide(5, 5));
        }

        [TestMethod]
        public void LargeNumbers_WorkCorrectly()
        {
            Assert.AreEqual(2000000, _calculator.Add(1000000, 1000000));
            Assert.AreEqual(1000000, _calculator.Multiply(1000, 1000));
            Assert.AreEqual(500, _calculator.Divide(1000000, 2000));
        }
    }
}