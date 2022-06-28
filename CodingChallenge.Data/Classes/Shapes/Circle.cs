using System;

namespace CodingChallenge.Data.Classes.Shapes
{
    public class Circle : GeometricShape
    {
        public decimal _diameter { get; set; }

        public Circle(decimal diameter)
        {
            Key = ShapeKeys.Circle;
            _diameter = diameter;
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }


        internal override decimal CalculateArea() => (decimal)Math.PI * _diameter * _diameter / 4;

        internal override decimal CalculatePerimeter() => _diameter * (decimal)Math.PI;
    }
}
