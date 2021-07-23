using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyCompany
{
    namespace MyApp
    {
        [Serializable]
        public class Employee:Human, IComparable
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

            public int CompareTo(object obj)
            {
                return this.Surname.CompareTo(((Employee)obj).Surname);
            }


            public static int CompareTwoEmployeersSurnameDESC(Employee a, Employee b)
            {
                return -a.Surname.CompareTo(b.Surname);
            }
            public static int CompareTwoEmployeersSurnameASC(Employee a, Employee b)
            {
                return a.Surname.CompareTo(b.Surname);
            }
            public static int CompareTwoEmployeersNameDESC(Employee a, Employee b)
            {
                return -a.Name.CompareTo(b.Name);
            }
            public static int CompareTwoEmployeersNameASC(Employee a, Employee b)
            {
                return a.Name.CompareTo(b.Name);
            }

            public void TakeSalary(Object sender, SalaryEventArg arg)
            {
                //Console.WriteLine(sender.ToString());
                Console.WriteLine($"Сотрудник: {Name}; Его зарплата: {arg.Salary} пфенингов");
            }

        }
    }

}