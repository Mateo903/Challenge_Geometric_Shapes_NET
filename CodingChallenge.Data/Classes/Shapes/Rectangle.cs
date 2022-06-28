namespace CodingChallenge.Data.Classes.Shapes
{
    public class Rectangle : GeometricShape
    {
        public decimal Base { get; set; }
        public decimal Height { get; set; }

        public Rectangle(decimal baseValue, decimal heightValue)
        {
            Key = ShapeKeys.Rectangle;
            Base = baseValue;
            Height = heightValue;
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        internal override decimal CalculateArea() => Base * Height;
        internal override decimal CalculatePerimeter() => 2 * (Base + Height);
    }
}
