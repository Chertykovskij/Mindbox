

using ShapeLibrary.Shapes.AbstractClass;

namespace ShapeLibrary.Factories.Interfaces
{
    public interface IShapeFactory
    {
        AbstractShape CreateShape();
    }
}
