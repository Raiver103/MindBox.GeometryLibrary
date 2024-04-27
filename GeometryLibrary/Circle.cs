namespace GeometryLibrary
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть отрицательным", nameof(radius));
            }

            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
