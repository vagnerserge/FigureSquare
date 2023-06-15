namespace Shapes.Tests
{
    public class CircleTest
    {
        [Fact]
        public void CalculateAreaCorrectly()
        {
            //Arrange
            double radius = 2;
            Circle circle = new(radius);
            var expectedArea = Math.PI * radius * radius;

            //Act
            var area = circle.CalculateArea();

            //Accert
            Assert.Equal(expectedArea, area);
        }

        [Fact]
        public void Circle_Constructor_WithNegativeRadius_ThrowsArgumentException()
        {
            // Arrange
            double radius = -1.5;

            // Assert
            var ex = Assert.Throws<ArgumentException>(
                () => new Circle(radius));
            Assert.Equal("Значение радиуса круга должно быть больше нуля.", ex.Message);
        }
    }
}