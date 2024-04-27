namespace GeometryLibrary.Tests
{ 
    public class CircleTests
    {
        [Fact]
        public void CalculateArea_ValidRadius_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            Circle circle = new Circle(radius);

            // Act
            double area = circle.CalculateArea();

            // Assert
            Assert.Equal(Math.PI * Math.Pow(radius, 2), area);
        }

        [Fact]
        public void CalculateArea_ZeroRadius_ReturnsZero()
        {
            // Arrange
            double radius = 0;
            Circle circle = new Circle(radius);

            // Act
            double area = circle.CalculateArea();

            // Assert
            Assert.Equal(0, area);
        }
    }
}
