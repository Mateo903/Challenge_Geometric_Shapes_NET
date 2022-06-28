using CodingChallenge.Data.Classes.Shapes;
using System.Collections.Generic;

namespace CodingChallenge.Data.Tests
{
    public static class ShapeMother
    {
        public static List<GeometricShape> GetAssortedList()
        {
            return new List<GeometricShape>
            {
                new Square(5),
                new Circle(3),
                new EquilateralTriangle(4),
                new Square(2),
                new EquilateralTriangle(9),
                new Circle(2.75m),
                new EquilateralTriangle(4.2m)
            };
        }
        
        public static List<GeometricShape> GetAssortedSquareList()
        {
            return new List<GeometricShape>
            {
                new Square(5),
                new Square(1),
                new Square(3)
            };
        }

        public static List<GeometricShape> GetOneSquare()
        {
            return new List<GeometricShape>
            {
                new Square(5)
            };
        }

        public static List<GeometricShape> GetOneTrapeze()
        {
            return new List<GeometricShape>
            {
                new Trapeze(30, 16, 12,13, 15)
            };
        }

        public static List<GeometricShape> GetUnknonwShape()
        {
            return new List<GeometricShape>
            {
                new UnknownShape(1)
            };
        }
    }

    public class UnknownShape : Square
    {
        public UnknownShape(decimal side) : base(side)
        {
            Key = "Unknown";
        }
    }
}
