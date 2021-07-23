using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyCompany
{
    namespace MyApp
    {
        class Employee:Human
        {
            private float _salary;
            public float Salary
            {
                get
                {
                    return _salary;
                }
                set
                {
                    if (value >= 0 && value <= float.MaxValue)
                    {
                        _salary = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Некорректный уровень зарплаты");
                    }
                }
            }
            public Employee():base()
            {
                _salary = 0.0f;
            }
            public Employee(string name, string surname, DateTime birthDate, Gender gender, float salary) 
                   : base(name, surname, birthDate, gender)
            {
                Salary = salary;
            }
            public new void  Show()
            {
                base.Show();
                Console.Write($"\n\tSalary: {Salary}");
            }
            public override string ToString()
            {
                return base.ToString() + $"\n\tSalary: {Salary}";
            }
        }
    }

}