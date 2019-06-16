using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace FiguresLib
{
    public class Point : Figure, IEquatable<Point>
    {
        // fields
        public readonly double X, Y; //immutability

        // constructor
        public Point(double x = 0.0, double y = 0.0)
        {
            X = Math.Round(x, Figure.FRACTIONAL_DIGITS);
            Y = Math.Round(y, Figure.FRACTIONAL_DIGITS);
            Color = Color.Blue;
        }
        public override void Draw()
        {
            Console.WriteLine("drawing: " + $"Point({X}, {Y}), {Color}");
        }

        public bool Equals(Point other)
        {
            if (other is null)
                return false;

            return this.X == other.X && this.Y == other.Y;
        }

        public static bool operator ==(Point left, Point right)
        {
            if (left is null && right is null)
                return true;

            if (left is null && !(right is null))
                return false;

            return left.Equals(right);
        }

        public static bool operator !=(Point left, Point right) => !(left == right);

        public override string ToString() => $"Point({X}, {Y})";
    }
}