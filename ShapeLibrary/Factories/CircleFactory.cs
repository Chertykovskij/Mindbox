using ShapeLibrary.Factories.Interfaces;
using ShapeLibrary.Shapes;
using ShapeLibrary.Shapes.AbstractClass;

namespace ShapeLibrary.Factories
{
    public class CircleFactory : IShapeFactory
    {
        private readonly double _radius;

        public CircleFactory(double radius)
        {
            if (radius > 0)
                _radius = radius;
            else
                throw new Exception("Радиус не может быть меньше либо равен 0");
        }

        public AbstractShape CreateShape()
        {
            return new Circle(_radius);
        }
    }
}
