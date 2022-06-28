namespace CodingChallenge.Data.Classes.Shapes
{
    public class Square : GeometricShape
    {
        public decimal Side { get; set; }
        
        public Square(decimal side)
        {
            Key = ShapeKeys.Square;
            Side = side;
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        
        internal override decimal CalculateArea() => Side * Side;
        
        internal override decimal CalculatePerimeter() => Side * 4;
    }
}
