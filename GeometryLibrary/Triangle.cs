namespace GeometryLibrary
{
    public class Triangle : Shape
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentException("Стороны треугольника не могут быть отрицательными");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Треугольник с такими сторонами не существует");
            }

            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double CalculateArea()
        {
            double semiPerimeter = (a + b + c) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
        }

        public bool IsRightTriangle()
        {
            return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) ||
                   Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) ||
                   Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2);
        }
    }
}
