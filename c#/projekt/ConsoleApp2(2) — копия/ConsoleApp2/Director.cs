using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    namespace MyApp
    {
        class Director : Employee, IManager, IWorker
        {
            public List<IWorker> ListWorkers { 
                get; 
                set; 
            }
            private bool _isWorking = true;
            private string _work;
            public bool IsWorking
            {
                get
                {
                    return _isWorking;
                }
            }
            public void Control()
            {
                Console.WriteLine("Контролирую процесс работы");
            }

            public void Organize()
            {
                Console.WriteLine("Организовываю рабочие процессы");
            }
            public Director() : base()
            {

            }
            public Director(string name, string surname, DateTime birthDate, Gender gender, float salary)
                : base(name, surname, birthDate, gender, salary)
            {
                ListWorkers = new List<IWorker>();
               
            }
            public override string ToString()
            {
                return $"Director: {base.ToString()}";
            }

            public string Work()
            {
                return _work;
            }
        }
    }
}
