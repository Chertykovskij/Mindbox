using ShapeLibrary.Calculations;
using ShapeLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace ShapeLibraryTests
{
    public class CircleTests
    {
        [Fact]
        public async void TestGetAreaFigure()
        {
            // Arrange
            var circle = new Circle(5);

            // Act
            var area = await CalculationsGeometricShapeParameters.CalculateAreaShapeAsync(circle);

            // Assert
            Assert.Equal(Math.PI * Math.Pow(5, 2), area);
        }
    }
}
