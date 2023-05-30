namespace MathLib;

public class Triangle: IFigure
{
    private decimal ASide { get; set; }
    private decimal BSide { get; set; }
    private decimal CSide { get; set; }

    public Triangle(decimal aSide, decimal bSide, decimal cSide)
    {
        if (aSide + bSide <= cSide ||
            aSide + cSide <= bSide ||
            bSide + cSide <= aSide)
            throw new ArgumentException("There is no triangle with such sides");
        ASide = aSide;
        BSide = bSide;
        CSide = cSide;
    }

    public decimal GetArea()
    {
        var halfPerimeter = (ASide + BSide + CSide) / 2;
        return (decimal)Math.Sqrt((double)(halfPerimeter * (halfPerimeter - ASide) * (halfPerimeter - BSide) * (halfPerimeter - CSide)));
    }

    public bool IsRectangular()
    {
        var result = false;
        
        if (ASide > BSide && ASide > CSide)
        {
            result = ASide * ASide == BSide * BSide + CSide * CSide;
        } 
        else if (BSide > CSide)
        {
            result = BSide * BSide == ASide * ASide + CSide * CSide;
        }
        else if (CSide > BSide)
        {
            result = CSide * CSide == BSide * BSide + ASide * ASide;
        }

        return result;
    }
}