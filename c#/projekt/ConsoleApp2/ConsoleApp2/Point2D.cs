using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyCompany
{
    namespace MyApp
    {
        class Point2D
        {
            private int _x;
            private int _y;
            public Colors Color;
            public int X
            {
                get
                {
                    return _x;
                }
                set
                {
                    _x = value;
                }
            }
            public int Y
            {
                get
                {
                    return _y;
                }
                set
                {
                    _y = value;
                }
            }

            public override string ToString()
            {
                return $"X: {X}; Y: {Y};";
            }
            public override bool Equals(object obj)
            {
                return this.ToString() == obj.ToString();
            }

            public static bool operator == (Point2D a, Point2D b)
            {
                return a.ToString() == b.ToString();
            }
            public static bool operator != (Point2D a, Point2D b)
            {
                return !(a == b);
            }

            public static bool operator true (Point2D point)
            {
                //
                return point.X != 0 && point.Y != 0 ? true : false;
            }
            public static bool operator false(Point2D point)
            {
                //
                return point.X != 0 && point.Y != 0 ? false : true;
            }


            public Point2D()
            {
                X = 0;
                Y = 0;
                Color = Colors.RED;
            }
            public Point2D(int x, int y, Colors color)
            {
                X = x;
                Y = y;
                Color = color;
            }
            
            public static Point2D operator ++(Point2D p)
            {
                p.X++;
                p.Y++;
                return p;
            }
            public static Point2D operator --(Point2D p)
            {
                p.X--;
                p.Y--;
                return p;
            }
            public static Point2D operator -(Point2D p)
            {
                return new Point2D { X = -p.X, Y = -p.Y };
            }

            public static Point2D operator+(Point2D a, Point2D b)
            {
                return new Point2D(a.X + b.X, a.Y + b.Y, Colors.BLUE);
            }
            /*public static Point2D operator -(Point2D a, Point2D b)
            {
                return
            }
            public static Point2D operator *(Point2D a, Point2D b)
            {
                return new
            }
            public static Point2D operator *(int a, Point2D b)
            {
                return new
            }
            public static Point2D operator *(Point2D a, int b)
            {
                return new
            }
            public static Point2D operator /(Point2D a, Point2D b)
            {
                return new 
            }*/

            
        }
    }
}
