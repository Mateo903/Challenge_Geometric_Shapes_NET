namespace CodingChallenge.Data.Classes.Shapes
{
    public abstract class GeometricShape
    {
        public string Key { get; set; }
        public decimal Perimeter { get; set; }
        public decimal Area { get; set; }
        
        internal abstract decimal CalculateArea();

        internal abstract decimal CalculatePerimeter();
    }
}
