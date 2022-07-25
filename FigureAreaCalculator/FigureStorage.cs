namespace FigureAreaCalculator;

public static class FigureStorage
{
    public static Dictionary<int, IFigure> Figures = new();

    static FigureStorage()
    {
        var type = typeof(IFigure);

        var figureTypes = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(p => type.IsAssignableFrom(p) && p.IsClass);

        foreach (var figureType in figureTypes)
        {
            IFigure figure = (IFigure)Activator.CreateInstance(figureType);
            Figures.Add(figure.SidesCount, figure);
        }
    }
}