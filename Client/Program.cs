
using ShapeLibrary.Calculations;
using ShapeLibrary.Factories.Interfaces;
using ShapeLibrary.Factories;
using ShapeLibrary.Shapes.AbstractClass;
using ShapeLibrary.Shapes;

double radius = 3.5;
IShapeFactory factory;
AbstractShape shape;

try
{
    factory = new CircleFactory(radius);

    shape = factory.CreateShape();

    double areaCircle = await CalculationsGeometricShapeParameters.CalculateAreaShapeAsync(shape);

    Console.WriteLine($"Радиус круга = {radius}, его площадь = {areaCircle}");

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

double sizeA = 10;
double sizeB = 7.8;
double sizeC = 6;

try
{
    factory = new TriangleFactory(sizeA, sizeB, sizeC);

    shape = factory.CreateShape();

    double areaTriangle = await CalculationsGeometricShapeParameters.CalculateAreaShapeAsync(shape);

    Console.WriteLine($"Площадь треугольника имеющего стороны {sizeA}, {sizeB}, {sizeC} равна {areaTriangle}");

    bool isRightTriangle = await CalculationsGeometricShapeParameters.IsRightTriangleAsync((Triangle)shape);

    if (isRightTriangle)
        Console.WriteLine("Треугольник является прямоугольным");
    else
        Console.WriteLine("Треугольник не является прямоугольным");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}


Console.ReadKey();
