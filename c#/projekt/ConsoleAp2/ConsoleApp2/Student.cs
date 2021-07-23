using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    namespace MyApp
    {
        class Student:Human
        {
            private string _groupName;
            public string Group
            {
                get
                {
                    return _groupName;
                }
                set
                {
                    if(value.Length >= 3)
                    {
                        _groupName = value;
                    }
                    else
                    {
                        throw new ArgumentException("Group name incorrect value");
                    }
                }
            }
            public Student() : base()
            {
                Group = "ТК-000";
            }
            public Student(string name, string surname, DateTime birthDate, Gender gender, string groupName) 
                    : base(name, surname, birthDate, gender)
            {
                Group = groupName;
            }
            public void executeExamenTask(string task)
            {
                Console.WriteLine($"Student {Name} получил задачу:{task}");
            }
        }
    }
}
