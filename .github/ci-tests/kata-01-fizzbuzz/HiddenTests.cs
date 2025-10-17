using Xunit;

namespace FizzBuzz.Tests
{
    /// <summary>
    /// Hidden tests for FizzBuzz kata.
    /// These tests are not visible to students but are executed during CI/CD.
    /// </summary>
    public class FizzBuzzHiddenTests
    {
        private readonly FizzBuzzGenerator _generator = new();

        [Fact]
        public void Generate_WithZero_ReturnsEmptyList()
        {
            var result = _generator.Generate(0);
            Assert.Empty(result);
        }

        [Fact]
        public void Generate_WithFifty_ReturnsCorrectSequence()
        {
            var result = _generator.Generate(50);
            
            Assert.Equal(50, result.Count);
            Assert.Equal("Buzz", result[49]); // 50 is multiple of 5 (index 49)
            Assert.Equal("Fizz", result[44]); // 45 is multiple of 3 (index 44)
            Assert.Equal("FizzBuzz", result[44]); // 45 is multiple of 15 (index 44)
        }

        [Fact]
        public void Generate_WithHundred_ContainsCorrectFizzBuzzCount()
        {
            var result = _generator.Generate(100);
            
            // Count occurrences
            int fizzCount = result.Count(s => s == "Fizz");
            int buzzCount = result.Count(s => s == "Buzz");
            int fizzBuzzCount = result.Count(s => s == "FizzBuzz");
            
            // Verify counts
            Assert.True(fizzBuzzCount == 6, $"Expected 6 FizzBuzz, got {fizzBuzzCount}"); // 15,30,45,60,75,90
            Assert.True(fizzCount == 27, $"Expected 27 Fizz (including in FizzBuzz), got {fizzCount}"); // Multiple of 3 but not 15
            Assert.True(buzzCount == 14, $"Expected 14 Buzz (not including FizzBuzz), got {buzzCount}"); // Multiple of 5 but not 15
        }

        [Fact]
        public void Generate_MultipleOf15_ReturnsExactlyFizzBuzz()
        {
            var result = _generator.Generate(30);
            
            // All multiples of 15 should be "FizzBuzz", not "Fizz" or "Buzz"
            Assert.Equal("FizzBuzz", result[14]); // 15 (index 14)
            Assert.Equal("FizzBuzz", result[29]); // 30 (index 29)
        }

        [Fact]
        public void Generate_VerifySpecificPositions()
        {
            var result = _generator.Generate(20);
            
            // Verify specific indices
            Assert.Equal("1", result[0]);     // 1
            Assert.Equal("2", result[1]);     // 2
            Assert.Equal("Fizz", result[2]);  // 3
            Assert.Equal("4", result[3]);     // 4
            Assert.Equal("Buzz", result[4]);  // 5
            Assert.Equal("Fizz", result[5]);  // 6
            Assert.Equal("7", result[6]);     // 7
            Assert.Equal("8", result[7]);     // 8
            Assert.Equal("Fizz", result[8]);  // 9
            Assert.Equal("Buzz", result[9]);  // 10
            Assert.Equal("FizzBuzz", result[14]); // 15
            Assert.Equal("16", result[15]);   // 16
            Assert.Equal("Buzz", result[19]); // 20
        }

        [Fact]
        public void Generate_LargeNumber_HandlesCorrectly()
        {
            var result = _generator.Generate(1000);
            
            Assert.Equal(1000, result.Count);
            Assert.Equal("Buzz", result[999]); // 1000 is multiple of 5 (index 999)
            Assert.Equal("FizzBuzz", result[899]); // 900 is multiple of 15 (index 899)
        }
    }
}
