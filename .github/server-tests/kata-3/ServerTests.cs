using Xunit;
using FluentAssertions;

namespace LeapYear.Tests
{
    /// <summary>
    /// Tests completos ejecutados en el servidor para evaluación.
    /// Los estudiantes no ven estos tests - se agregan automáticamente durante la evaluación
    /// </summary>
    public class ServerTests
    {
        [Fact]
        public void Year_DivisibleBy4_ButNotBy100_IsLeapYear()
        {
            LeapYearChecker.IsLeapYear(2004).Should().BeTrue(); // 2004 % 4 == 0 && 2004 % 100 != 0
            LeapYearChecker.IsLeapYear(2008).Should().BeTrue();
            LeapYearChecker.IsLeapYear(2012).Should().BeTrue();
            LeapYearChecker.IsLeapYear(2016).Should().BeTrue();
            LeapYearChecker.IsLeapYear(2020).Should().BeTrue();
        }

        [Fact]
        public void Year_DivisibleBy100_ButNotBy400_IsNotLeapYear()
        {
            LeapYearChecker.IsLeapYear(1700).Should().BeFalse(); // 1700 % 100 == 0 && 1700 % 400 != 0
            LeapYearChecker.IsLeapYear(1800).Should().BeFalse();
            LeapYearChecker.IsLeapYear(1900).Should().BeFalse();
            LeapYearChecker.IsLeapYear(2100).Should().BeFalse();
            LeapYearChecker.IsLeapYear(2200).Should().BeFalse();
        }

        [Fact]
        public void Year_DivisibleBy400_IsLeapYear()
        {
            LeapYearChecker.IsLeapYear(1600).Should().BeTrue(); // 1600 % 400 == 0
            LeapYearChecker.IsLeapYear(2000).Should().BeTrue();
            LeapYearChecker.IsLeapYear(2400).Should().BeTrue();
        }

        [Fact]
        public void Year_NotDivisibleBy4_IsNotLeapYear()
        {
            LeapYearChecker.IsLeapYear(2001).Should().BeFalse(); // 2001 % 4 != 0
            LeapYearChecker.IsLeapYear(2002).Should().BeFalse();
            LeapYearChecker.IsLeapYear(2003).Should().BeFalse();
            LeapYearChecker.IsLeapYear(2005).Should().BeFalse();
            LeapYearChecker.IsLeapYear(2006).Should().BeFalse();
            LeapYearChecker.IsLeapYear(2007).Should().BeFalse();
        }

        [Fact]
        public void EdgeCases_SpecialYears_CorrectResults()
        {
            // Casos especiales históricos y futuros
            LeapYearChecker.IsLeapYear(4).Should().BeTrue();     // Primer año divisible por 4
            LeapYearChecker.IsLeapYear(100).Should().BeFalse();  // Primer siglo no bisiesto
            LeapYearChecker.IsLeapYear(400).Should().BeTrue();   // Primer milenio bisiesto
            LeapYearChecker.IsLeapYear(1).Should().BeFalse();    // Año 1
        }

        [Fact]
        public void RecentYears_CommonTestCases_CorrectResults()
        {
            // Casos comunes que los estudiantes podrían probar
            LeapYearChecker.IsLeapYear(2024).Should().BeTrue();  // Año actual/reciente
            LeapYearChecker.IsLeapYear(2023).Should().BeFalse();
            LeapYearChecker.IsLeapYear(2022).Should().BeFalse();
            LeapYearChecker.IsLeapYear(2021).Should().BeFalse();
        }

        [Fact]
        public void HistoricalYears_ImportantDates_CorrectResults()
        {
            // Años históricos importantes
            LeapYearChecker.IsLeapYear(1776).Should().BeTrue();  // Independencia USA
            LeapYearChecker.IsLeapYear(1492).Should().BeTrue();  // Descubrimiento América
            LeapYearChecker.IsLeapYear(1066).Should().BeFalse(); // Batalla de Hastings
            LeapYearChecker.IsLeapYear(476).Should().BeTrue();   // Caída del Imperio Romano
        }

        [Fact]
        public void CompleteLeapYearLogic_AllRules_WorkCorrectly()
        {
            // Verificar la lógica completa:
            // - Si es divisible por 400 → SÍ es bisiesto
            // - Si es divisible por 100 pero no por 400 → NO es bisiesto  
            // - Si es divisible por 4 pero no por 100 → SÍ es bisiesto
            // - Si no es divisible por 4 → NO es bisiesto
            
            var testCases = new[]
            {
                (2000, true),   // Divisible por 400
                (1900, false),  // Divisible por 100 pero no por 400
                (2004, true),   // Divisible por 4 pero no por 100
                (2001, false),  // No divisible por 4
                (2100, false),  // Divisible por 100 pero no por 400
                (2400, true),   // Divisible por 400
                (1996, true),   // Divisible por 4 pero no por 100
                (1997, false)   // No divisible por 4
            };

            foreach (var (year, expected) in testCases)
            {
                LeapYearChecker.IsLeapYear(year).Should().Be(expected, 
                    $"Year {year} should {(expected ? "" : "not ")}be a leap year");
            }
        }
    }
}