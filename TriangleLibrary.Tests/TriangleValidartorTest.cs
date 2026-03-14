using Xunit;
using TriangleLibrary;

namespace TriangleLibrary.Tests;

public class TriangleValidatorTest
{
    [Theory]
    [InlineData(3, 4, 5, true)]  // Escaleno válido
    [InlineData(5, 5, 5, true)]  // Equilátero válido
    [InlineData(12, 4, 5, false)] // Lados inválidos (no cumple desigualdad)
    public void IsTriangle_ValidAndInvalidSides_ReturnsExpectedResult(double a, double b, double c, bool expected)
    {
        // Act
        bool result = TriangleValidator.IsTriangle(a, b, c);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(-1, 2, 2)]
    [InlineData(0, 3, 4)]
    [InlineData(double.PositiveInfinity, 2, 2)]
    public void IsTriangle_InvalidInput_ThrowsArgumentException(double a, double b, double c)
    {
        // Assert
        Assert.Throws<ArgumentException>(() => TriangleValidator.IsTriangle(a, b, c));
    }

    [Theory]
    [InlineData(4, 4, 4, true)]  // Equilátero puro
    [InlineData(3, 4, 4, false)] // Isósceles
    [InlineData(1, 1, 3, false)] // No es triángulo
    public void IsEquilateral_Validation(double a, double b, double c, bool expected)
    {
        Assert.Equal(expected, TriangleValidator.IsEquilateral(a, b, c));
    }

    [Theory]
    [InlineData(5, 5, 3, true)]  // Isósceles puro
    [InlineData(5, 3, 5, true)]  // Isósceles (lados a y c)
    [InlineData(5, 5, 5, false)] // Equilátero
    public void IsIsosceles_Validation(double a, double b, double c, bool expected)
    {
        Assert.Equal(expected, TriangleValidator.IsIsosceles(a, b, c));
    }

    [Theory]
    [InlineData(3, 4, 5, true)]  // Escaleno puro
    [InlineData(5, 5, 4, false)] // Isósceles
    public void IsScalene_Validation(double a, double b, double c, bool expected)
    {
        Assert.Equal(expected, TriangleValidator.IsScalene(a, b, c));
    }
}