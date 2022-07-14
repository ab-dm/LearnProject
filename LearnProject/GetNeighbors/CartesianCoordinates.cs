using System;
using System.Collections.Generic;

namespace LearnProject.GetNeighbors
{
    public static class CartesianCoordinates
    {
        public static Point[] GetNeighbors(Point point, int h, params Point[] points)
        {
            if (points is null)
            {
                throw new ArgumentNullException(nameof(point));
            }

            if (h <= 0)
            {
                throw new ArgumentException("Range cannot be less or equals zero.");
            }

            int minX = point.X - h;
            int maxX = point.X + h;
            int minY = point.Y - h;
            int maxY = point.Y + h;

            var list = new List<Point>();
            foreach (Point p in points)
            {
                if (p.X >= minX && p.X <= maxX && p.Y >= minY && p.Y <= maxY)
                {
                    list.Add(p);
                }
            }

            return list.ToArray();
        }
    }
}
