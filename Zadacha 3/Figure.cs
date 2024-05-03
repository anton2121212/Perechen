using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_3
{
    class Figure
    {
        Point[] points;
        public Figure (Point point, Point point1,Point point2)
        {
            points = new Point[] { point, point1, point2 };
        }

        public Figure(Point point, Point point1, Point point2, Point point3)
        {
            points = new Point[] { point, point1, point2, point3 };
        }

        public Figure(Point point, Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[] { point, point1, point2, point3, point4 };
        }
        double CalcLenghtSide(Point pointA, Point pointB) =>
           Math.Sqrt(Math.Pow(pointB.X - pointA.X, 2) + Math.Pow(pointB.Y - pointA.Y, 2));

         public double Perimeter()
        {
            double per = 0;
            for (int i = 0; i <points.Length-1; i++)
            {
                per += CalcLenghtSide(points[i + 1], points[i]);
            }
            per += CalcLenghtSide(points[0], points[points.Length - 1]);
            return per;
        }


    }
}
