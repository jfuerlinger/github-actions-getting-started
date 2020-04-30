using GitHubActions.Core;
using System;
using Xunit;

namespace GitHubActions.Test
{
  public class CalculatorTests
  {
    [Fact]
    public void Add_CallWith2And3_ShouldBe5()
    {
      // Arrange
      int actualValue;

      // Act
      actualValue = Calculator.Add(2, 3);

      // Assert
      Assert.Equal(5, actualValue);
    }


    [Fact]
    public void Add_CallWith0And0_ShouldBe0()
    {
      // Arrange
      int actualValue;

      // Act
      actualValue = Calculator.Add(0, 0);

      // Assert
      Assert.Equal(0, actualValue);
    }
  }
}
