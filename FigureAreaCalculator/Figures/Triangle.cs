namespace FigureAreaCalculator.Figures;

public class Triangle : IFigure
{
    public string Title => nameof(Triangle);
    public int SidesCount => 3;

    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public double GetArea()
    {
        var p = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }

    public bool IsRectangular()
    {
        return Math.Pow(SideC, 2) == Math.Pow(SideA, 2) + Math.Pow(SideB, 2);
    }

    public void SetParameters(double[] parameters)
    {
        SideA = parameters[0];
        SideB = parameters[1];
        SideC = parameters[2];

        var isTriangle = SideA + SideB >= SideC && SideA + SideC >= SideB && SideB + SideC >= SideA;

        if (!isTriangle)
            throw new ArgumentException($"Triangle with sides {SideA}, {SideB}, {SideC} not exist");
    }
}