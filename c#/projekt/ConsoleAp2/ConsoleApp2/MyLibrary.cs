using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    namespace MyApp
    {
        class MyLibrary<Tkey, Tvalue>
        {
            private Tkey _one;
            private Tkey _two;
            private Tkey _three;

            public Tkey First
            {
                get; set;
            }
            public Tvalue Second
            {
                get; set;
            }
            public MyLibrary()
            {
                First = default;
                Second = default;
            }
            public MyLibrary(Tkey tk, Tvalue tv)
            {
                First = tk;
                Second = tv;
            }
            public override string ToString()
            {
                return $"\nMyLibrary: Key: {First}; Value:{Second};";
            }
        }
    }
}
