using Xunit;
using TriangleLibrary;

namespace TriangleLibrary.Tests;

public class TriangleValidatorTest
{
    [Fact]
    public void IsTriangle_ValidSides_ReturnsTrue()
    {
        // Arrange
        double a = 3, b = 4, c = 5;
        // Act
        bool result = TriangleValidator.IsTriangle(a, b, c);
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsTriangle_InvalidSides_ReturnsFalse()
    {
        // Arrange
        double a = 12, b = 4, c = 5;
        // Act
        bool result = TriangleValidator.IsTriangle(a, b, c);
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsEquilateral_ValidEquilateral_ReturnsTrue()
    {
        // Arrange
        double a = 4, b = 4, c = 4;
        // Act
        bool result = TriangleValidator.IsEquilateral(a, b, c);
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsEquilateral_ValidIsosceles_ReturnsFalse()
    {
        // Arrange
        double a = 3, b = 4, c = 4;
        // Act
        bool result = TriangleValidator.IsEquilateral(a, b, c);
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsIsosceles_ValidIsosceles_ReturnsTrue()
    {
        // Arrange
        double a = 5, b = 3, c = 5;
        // Act
        bool result = TriangleValidator.IsIsosceles(a, b, c);
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsIsosceles_ValidEquilateral_ReturnsFalse()
    {
        // Arrange
        double a = 5, b = 5, c = 5;
        // Act
        bool result = TriangleValidator.IsIsosceles(a, b, c);
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsScalene_ValidScalene_ReturnsTrue()
    {
        // Arrange
        double a = 3, b = 5, c = 4;
        // Act
        bool result = TriangleValidator.IsScalene(a, b, c);
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsScalene_ValidIsosceles_ReturnsFalse()
    {
        // Arrange
        double a = 5, b = 5, c = 4;
        // Act
        bool result = TriangleValidator.IsScalene(a, b, c);
        // Assert
        Assert.False(result);
    }
}