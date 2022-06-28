namespace CodingChallenge.Data.Classes.Shapes
{
    public class EquilateralTriangle : Triangle
    {
        public decimal Side { get; set; }
        
        public EquilateralTriangle(decimal side) : base(side, side, side)
        {
            Key = ShapeKeys.EquilateralTriangle;
            Side = side;
        }
    }
}
