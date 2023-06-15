using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateAreaCorrectly()
        {
            //Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;

            Triangle triangle = new(side1, side2, side3);
            double semiPerimeter = (side1 + side2 + side3) / 2;
            var expectedArea = Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));

            //Act
            var area = triangle.CalculateArea();


        //Accert
        Assert.Equal(expectedArea, area);
        }

        [Fact]
        public void Triangle_Constructor_WithNegativeSide_ThrowsArgumentException()
        {
            // Arrange
            double side1 = -3.0;
            double side2 = 4.0;
            double side3 = 5.0;

            // Assert
            var ex = Assert.Throws<ArgumentException>(
                () => new Triangle(side1, side2, side3));
            Assert.Equal("Каждая из сторон треугольника должна быть больше нуля.", ex.Message);
        }

        [Fact]
        public void Triangle_Constructor_WithInvalidSides_ThrowsArgumentException()
        {
            // Arrange
            double side1 = 1.0;
            double side2 = 2.0;
            double side3 = 5.0;

            // Act and Assert
            var ex = Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
            Assert.Equal("Каждая из сторон треугольника должна быть меньше суммы двух других.", ex.Message);
        }

        [Fact]
        public void IsRightTriangle_WithRightTriangle_ReturnsTrue()
        {
            // Arrange
            double side1 = 3.0;
            double side2 = 4.0;
            double side3 = 5.0;
            Triangle triangle = new(side1, side2, side3);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.True(isRightTriangle);
        }

        [Fact]
        public void IsRightTriangle_WithNonRightTriangle_ReturnsFalse()
        {
            // Arrange
            double side1 = 2.0;
            double side2 = 3.0;
            double side3 = 4.0;
            Triangle triangle = new(side1, side2, side3);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.False(isRightTriangle);
        }
    }
}
