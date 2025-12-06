using Xunit;

namespace LeapYear.Tests
{
    public class LeapYearCheckerTests
    {
        [Fact]
        public void Year_DivisibleBy4_ButNotBy100_IsLeapYear()
        {
            // Ejemplo: 2004 es año bisiesto
            Assert.True(LeapYearChecker.IsLeapYear(2004));
        }

        [Fact]
        public void Year_NotDivisibleBy4_IsNotLeapYear()
        {
            // Ejemplo: 2001 no es año bisiesto
            Assert.False(LeapYearChecker.IsLeapYear(2001));
        }
    }
}
