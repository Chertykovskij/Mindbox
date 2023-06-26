using ShapeLibrary.Shapes.AbstractClass;
using System.Data;

namespace ShapeLibrary.Shapes
{
    public class Triangle : AbstractShape
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA > 0 && sideB > 0 & sideC > 0)
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
            }
            else
                throw new Exception("Ни одна сторона не может иметь отрицательное значение");
        }

        internal override double GetAreaFigure()
        {
            // Полупериметр треугольника
            double triangleSemiperimeter = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(triangleSemiperimeter *
                            (triangleSemiperimeter - SideA) *
                            (triangleSemiperimeter - SideB) *
                            (triangleSemiperimeter - SideC));
        }
    }
}
