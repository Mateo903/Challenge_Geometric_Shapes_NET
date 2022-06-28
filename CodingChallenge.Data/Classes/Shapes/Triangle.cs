using System;

namespace CodingChallenge.Data.Classes.Shapes
{
    public class Triangle : GeometricShape
    {
        public decimal Side1 { get; set; }
        public decimal Side2 { get; set; }
        public decimal Side3 { get; set; }

        public Triangle(decimal side1, decimal side2, decimal side3)
        {
            Key = ShapeKeys.Triangle;
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        internal override decimal CalculateArea()
        {
            decimal semiPerimeter = CalculatePerimeter() / 2m;
            return (decimal)Math.Sqrt((double)(semiPerimeter * (semiPerimeter - Side1) * (semiPerimeter - Side2) * (semiPerimeter - Side3)));
        }

        internal override decimal CalculatePerimeter() => Side1 + Side2 + Side3;
    }
}
