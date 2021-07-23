using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    namespace MyApp
    {
        public delegate int CalcDelegat(int b);

        public delegate T CalcDelegat<T>(T b); //generic
        class CalcInt
        {
            private int _number;
            public int Number
            {
                get
                {
                    return _number;
                }
                set
                {
                    _number = value;
                }
            }
            public CalcInt(int a)
            {
                Number = a;
            }
            public int Div(int b)
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("Низзя");
                }
                return _number / b;
            }
            public int Multy(int b)
            {
                return _number * b;
            }
            public int Summa(int b)
            {
                return _number + b;
            }
            public float SummaFloat(float b)
            {
                return _number + b;
            }
            public int Sub(int b)
            {
                return _number - b;
            }
            public override string ToString()
            {
                return $"Number {_number}";
            }
        }
    }
}
