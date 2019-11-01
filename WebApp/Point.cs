using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {

            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return X + "," + Y;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Point))
            {
                return false;
            }

            else
            {
                Point that = obj as Point;

                return this.X == that.X && this.Y == that.Y;
            }
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() * 31 + Y.GetHashCode();
        }

        public int DistanceTo(int x, int y)
        {

            return (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));

        }

        public int DistanceTo(Point location)
        {
            return DistanceTo(location.X, location.Y);
        }
    }
}
