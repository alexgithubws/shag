using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyCompany
{
    namespace MyApp
    {
        class Point3D <T>
        {
            public T X
            {
                get; set;
            }
            public T Y
            {
                get; set;
            }
            public T Z
            {
                get; set;
            }

            public Point3D()
            {
                /*X = default;
                Y = default;
                Z = default;*/

                X = Y = Z = default;
            }
            public Point3D(T x, T y, T z)
            {
                X = x;
                Y = y;
                Z = z;
            }
            public override string ToString()
            {
                return $"\nPoint 3D: " +
                    $"\n\tX: {X};" +
                    $"\n\tY: {Y};" +
                    $"\n\tZ: {Z};";
            }
        }
    }
}
