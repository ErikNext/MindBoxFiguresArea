namespace FigureAreaCalculator.Figures;

public class Circle : IFigure
{
    public string Title => nameof(Circle);
    public int SidesCount => 1;

    public double Radius { get; set; }

    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public void SetParameters(double[] parameters)
    {
        Radius = parameters[0];
    }
}