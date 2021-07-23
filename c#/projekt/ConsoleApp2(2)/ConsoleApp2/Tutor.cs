using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    namespace MyApp
    {
        public delegate void ExamenDelegate(string tasexamTaskk);
        sealed class Tutor:Employee 
            //запечатанный класс - запрещает наследование
        {
            public event ExamenDelegate OnExamEvent; //событие екзамена

            public void Examen(string examTask)
            {
                if (OnExamEvent != null)
                {
                    OnExamEvent(examTask);
                }
            }

            private string _specialty;
            public string Specialty
            {
                get
                {
                    return _specialty;
                }
                set
                {
                    if (value.Length >= 3)
                    {
                        _specialty = value;
                    }else
                    {
                        throw new ArgumentException("");
                    }
                }
            }
            public Tutor():base()
            {
                Specialty = "pedagog";
            }
            public Tutor(string name, string surname, DateTime birthDate, Gender gender, float salary, string specialty) 
                : base(name, surname, birthDate, gender, salary)
            {
                Specialty = specialty;
            }
            public new void Show()
            {
                base.Show();
                Console.Write($"\n\tSpecialty: {Specialty}");
            }
            public override string ToString()
            {
                return base.ToString() + $"\n\tSpecialty: {Specialty}";
            }
        }
    }
}
