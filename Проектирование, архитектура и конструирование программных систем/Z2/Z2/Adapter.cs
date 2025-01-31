using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Z2
{
    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"({X}, {Y})";
    }

    public class Line
    {
        public Point Start { get; }
        public Point End { get; }

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }
    }

    public class LineToPointAdapter : List<Point>
    {
        public LineToPointAdapter(Line line)
        {
            int left = Math.Min(line.Start.X, line.End.X);
            int right = Math.Max(line.Start.X, line.End.X);
            int top = Math.Min(line.Start.Y, line.End.Y);
            int bottom = Math.Max(line.Start.Y, line.End.Y);

            if (left == right)
            {
                for (int y = top; y <= bottom; y++)
                {
                    Add(new Point(left, y));
                }
            }
            else if (top == bottom)
            {
                for (int x = left; x <= right; x++)
                {
                    Add(new Point(x, top));
                }
            }
        }
    }
}
