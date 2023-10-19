using System;
namespace workSheetOne
{
    public class Shapes
    {
        public enum ShapeType
        {
            Rectangle,
            Circle,
            Triangle
        }

        public class Shape
        {
            public ShapeType Type { get; set; }
        }

        public class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }
        }

        public class Circle : Shape
        {
            public double Radius { get; set; }
        }

        public class Triangle : Shape
        {
            public double Base { get; set; }
            public double Height { get; set; }
        }

        public static Shape CreateShape(ShapeType type, double[] parameters)
        {
            switch (type)
            {
                case ShapeType.Rectangle:
                    return new Rectangle { Type = type, Width = parameters[0], Height = parameters[1] };
                case ShapeType.Circle:
                    return new Circle { Type = type, Radius = parameters[0] };
                case ShapeType.Triangle:
                    return new Triangle { Type = type, Base = parameters[0], Height = parameters[1] };
                default:
                    throw new ArgumentException("Invalid shape type");
            }
        }
    }

}

