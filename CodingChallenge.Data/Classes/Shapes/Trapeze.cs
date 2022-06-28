namespace CodingChallenge.Data.Classes.Shapes
{
    public class Trapeze : GeometricShape
    {
        public decimal Base1 { get; set; }
        public decimal Base2 { get; set; }
        public decimal Height { get; set; }
        public decimal Side1 { get; set; }
        public decimal Side2 { get; set; }

        public Trapeze(decimal base1, decimal base2, decimal height, decimal side1, decimal side2)
        {
            Key = ShapeKeys.Trapeze;
            Base1 = base1;
            Base2 = base2;
            Height = height;
            Side1 = side1;
            Side2 = side2;
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        internal override decimal CalculateArea() => (Base1 + Base2) * Height / 2;

        internal override decimal CalculatePerimeter() => Base1 + Base2 + Side1 + Side2;
    }
}
