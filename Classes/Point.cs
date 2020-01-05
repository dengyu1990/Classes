#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    class Point
    {
        private int x;
        private int y;
        public Point()
        {
            this.x = -1;
            this.y = -1;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine($"x:{x},y:{y}");
        }

        public void Deconstruct(out int x, out int y)
        {
            x = this.x;
            y = this.y;
        }

        public double DistanceTo(Point other)
        {
            int xDiff = this.x - other.x;
            int yDiff = this.y - other.y;
            return Math.Sqrt(xDiff * xDiff + yDiff * yDiff);
        }

    }
}
