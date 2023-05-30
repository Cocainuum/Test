using MathLib;

namespace Tests;

public class TriangleTest
{
    [Theory]
    [InlineData(3, 3, 5, 4.14578098794425)]
    [InlineData(5, 7, 4, 9.79795897113271)]
    public void TriangleCreatedAndAreaCount(decimal aSide, decimal bSide, decimal cSide, decimal expected)
    {
        var triangle = new Triangle(aSide, bSide, cSide);

        var result = triangle.GetArea();
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TriangleWrongSidesValidation()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(3, 2, 5));
    }

    [Fact]
    public void RectangularTriangle()
    {
        var recTriangle = new Triangle(10,6,8);
        var notRecTriangle = new Triangle(6, 5, 2);

        var recResult = recTriangle.IsRectangular();
        var notRecResult = notRecTriangle.IsRectangular();
        
        Assert.True(recResult);
        Assert.False(notRecResult);
    }
}