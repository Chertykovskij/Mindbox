using ShapeLibrary.Factories.Interfaces;
using ShapeLibrary.Shapes;
using ShapeLibrary.Shapes.AbstractClass;


namespace ShapeLibrary.Factories
{
    public class TriangleFactory : IShapeFactory
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public TriangleFactory(double sideA, double sideB, double sideC)
        {
            if (sideA > 0 && sideB > 0 & sideC > 0)
            {
                _sideA = sideA;
                _sideB = sideB;
                _sideC = sideC;
            }
            else
                throw new Exception("Ни одна сторона не может иметь отрицательное значение");
        }

        public AbstractShape CreateShape()
        {
            return new Triangle(_sideA, _sideB, _sideC);
        }
    }
}
