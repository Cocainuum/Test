namespace MathLib;

public class Circle: IFigure
{
    private decimal Radius { get; set; }

    public Circle(decimal radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius cannot be zero or negative", nameof(radius));
        Radius = radius;
    }
    
    public decimal GetArea()
    {
        return (decimal)Math.PI * Radius * Radius;
    }
}