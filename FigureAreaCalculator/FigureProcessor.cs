namespace FigureAreaCalculator;

public class FigureProcessor
{
    public IFigure GetFigure(params double[] sides)
    {
        FigureStorage.Figures.TryGetValue(sides.Length, out var figure);

        if (figure == null)
            throw new ArgumentException($"Have no figure with amount of sides: {sides}");

        figure.SetParameters(sides);

        return figure;
    }
}