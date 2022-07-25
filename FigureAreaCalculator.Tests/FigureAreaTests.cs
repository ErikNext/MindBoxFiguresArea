using FigureAreaCalculator.Figures;

namespace FigureAreaCalculator.Tests
{
    public class FigureAreaTests
    {
        private FigureProcessor _figureProcessor;

        [SetUp]
        public void Setup()
        {
            _figureProcessor = new FigureProcessor();
        }

        [Test]
        public void CircleAreaTest()
        {
            var figure = _figureProcessor.GetFigure(5);

            var expectedResult = 78.539816339744831d;

            Assert.That(figure.GetArea(), Is.EqualTo(expectedResult));
        }

        [Test]
        public void TriangleAreaTest()
        {
            var figure = _figureProcessor.GetFigure(4, 7, 8);

            var expectedResult = 13.997767679169419d;

            Assert.That(figure.GetArea(), Is.EqualTo(expectedResult));
        }

        [Test]
        public void TriangleNotExistTest()
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => _figureProcessor.GetFigure(1, 3, 5));
            Assert.AreEqual("Triangle with sides 1, 3, 5 not exist", ex.Message);
        }

        [TestCase(3, 4, 5, true)]
        [TestCase(4, 7, 9, false)]
        public void TriangleIsRectangularTest(double a, double b, double c, bool result)
        {
            var figure = _figureProcessor.GetFigure(a, b, c);

            var triangle = (Triangle)figure;

            Assert.That(triangle.IsRectangular(), Is.EqualTo(result));
        }
    }
}