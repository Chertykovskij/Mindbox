using ShapeLibrary.Shapes;
using ShapeLibrary.Shapes.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Calculations
{
    public static class CalculationsGeometricShapeParameters
    {
        public static async Task<double> CalculateAreaShapeAsync(AbstractShape shape)
        {
            return await Task.Run(() => shape.GetAreaFigure());
        }

        public static async Task<bool> IsRightTriangleAsync(Triangle triangle)
        {
            return await Task.Run(() => IsRightTriangle(triangle));
        }

        private static bool IsRightTriangle(Triangle triangle)
        {
            // Вычисление квадратов длин сторон.
            double a2 = Math.Pow(triangle.SideA, 2);
            double b2 = Math.Pow(triangle.SideB, 2);
            double c2 = Math.Pow(triangle.SideC, 2);

            // Проверка на соответствие теореме Пифагора.
            return a2 + b2 == c2 ||
                   a2 + c2 == b2 ||
                   b2 + c2 == a2;
        }
    }
}
