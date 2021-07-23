using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SalaryEventArg:EventArgs
    {
        public string Name { get; set; }
        public float Salary { get; set; }

    }
}
