using Xunit;

namespace StringCalculator.Tests.CI;

/// <summary>
/// Tests adicionales que SOLO existen en el pipeline de CI
/// Los estudiantes NO tienen acceso a estos tests en su repositorio
/// </summary>
public class HiddenTests
{
    private readonly StringCalculator.StringCalculator _calculator = new();

    [Fact]
    public void Add_NewLineDelimiter_ReturnsSum()
    {
        // Números pueden estar separados por \n además de comas
        Assert.Equal(6, _calculator.Add("1\n2,3"));
        Assert.Equal(10, _calculator.Add("1\n2\n3\n4"));
    }

    [Fact]
    public void Add_CustomDelimiter_ReturnsSum()
    {
        // Formato: "//[delimiter]\n[numbers]"
        Assert.Equal(3, _calculator.Add("//;\n1;2"));
        Assert.Equal(10, _calculator.Add("//|\n1|2|3|4"));
        Assert.Equal(6, _calculator.Add("//***\n1***2***3"));
    }

    [Fact]
    public void Add_NegativeNumbers_ThrowsException()
    {
        // Debe lanzar excepción con mensaje indicando los números negativos
        var ex = Assert.Throws<ArgumentException>(() => _calculator.Add("1,-2,3"));
        Assert.Contains("-2", ex.Message);
        
        var ex2 = Assert.Throws<ArgumentException>(() => _calculator.Add("-1,-2,-3"));
        Assert.Contains("-1", ex2.Message);
        Assert.Contains("-2", ex2.Message);
        Assert.Contains("-3", ex2.Message);
    }

    [Fact]
    public void Add_NumbersGreaterThan1000_AreIgnored()
    {
        // Números > 1000 se ignoran
        Assert.Equal(2, _calculator.Add("2,1001"));
        Assert.Equal(1000, _calculator.Add("1000,1001,1002"));
        Assert.Equal(3, _calculator.Add("1,2,9999"));
    }

    [Fact]
    public void Add_MultipleDelimitersOfAnyLength_ReturnsSum()
    {
        // Formato: "//[delim1][delim2]\n[numbers]"
        Assert.Equal(6, _calculator.Add("//[*][%]\n1*2%3"));
        Assert.Equal(10, _calculator.Add("//[**][%%]\n1**2%%3**4"));
    }

    [Fact]
    public void Add_EdgeCases_HandledCorrectly()
    {
        // Casos especiales
        Assert.Equal(0, _calculator.Add("0"));
        Assert.Equal(0, _calculator.Add("0,0,0"));
        Assert.Equal(1, _calculator.Add("1,0"));
        Assert.Equal(1000, _calculator.Add("1000"));
        Assert.Equal(2000, _calculator.Add("1000,1000"));
    }

    [Fact]
    public void Add_MixedComplexScenarios_ReturnsCorrectSum()
    {
        // Combinación de reglas
        Assert.Equal(6, _calculator.Add("//;\n1;2;3;1001")); // Custom delimiter + ignore >1000
        Assert.Equal(1000, _calculator.Add("999\n1,1005")); // Newline + ignore >1000
    }
}
