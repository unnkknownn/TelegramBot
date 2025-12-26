using Xunit;

public class CalculatorTests
{
private readonly Calculator

V

_calculator = new();

[Fact]
public void
Add_TwoNumbers_ReturnsSum()
{
// Arrange
int a = 5, b = 3;

// Act
int result = _calculator.Add(a,

b);

// Assert
Assert.Equal(8, result);
}
[Fact]
public void
Divide_ByZero_ThrowsException()
{
// Act & Assert

Assert.Throws<DivideByZeroException>( ()
=> _calculator.Divide(10, 0));
}
[Theory]
[InlineData(2, true) ]
[InlineData(3, true) ]
[InlineData(4, false) ]
[InlineData(17, true) ]
public void
IsPrime_VariousNumbers_ReturnsCorrect(in

V

t number, bool expected)
{
// Act
bool result =
_calculator. IsPrime (number);

// Assert
Assert.Equal(expected, result);
}
}