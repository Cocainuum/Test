using MathLib;

namespace Tests;

public class CircleTest
{
    [Fact]
    public void CircleCreatedAndAreaCount()
    {
        var circle = new Circle(2);
        
        var result = circle.GetArea();
        
        Assert.Equal(12.56637061435916M, result);
    }

    [Fact]
    public void CircleWrongRadiusValidation()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }
}