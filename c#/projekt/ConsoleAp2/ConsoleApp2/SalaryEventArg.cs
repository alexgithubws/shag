using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    namespace MyApp
    {
        public class SalaryEventArg:EventArgs
        {
            public string Name { get; set; }
            public float Salary { get; set; }
        }
    }
}
