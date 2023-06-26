using ShapeLibrary.Shapes.AbstractClass;

namespace ShapeLibrary.Shapes
{
    public class Circle : AbstractShape
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            if (radius > 0)
                Radius = radius;
            else
                throw new Exception("Радиус не может быть меньше либо равен 0");
        }

        internal override double GetAreaFigure()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
