namespace FigureAreaCalculator;

public interface IFigure
{
    string Title { get; }

    int SidesCount { get; }

    double GetArea();

    void SetParameters(double[] parameters);
}