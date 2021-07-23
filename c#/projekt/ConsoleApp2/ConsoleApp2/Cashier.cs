using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    namespace MyApp
    {
        class Cashier : Employee, IWorker
        {
            public EventHandler<SalaryEventArg> OnSalaryGive;
            public void GivaSlary(SalaryEventArg arg)
            {
                if(OnSalaryGive != null)
                {
                    OnSalaryGive(this, arg);
                }
            }
             
            private string _work;
            public bool IsWorking {
                get
                {
                    return _isWorking;
                }
            }

            public string Work()
            {
                return _work;
            }

            public void stopWorking()
            {
                _isWorking = false;
            }
            public void nextTask(string task)
            {
                if(_isWorking == false)
                {
                    if(task.Length > 0)
                    {
                        _work = task;
                        _isWorking = true;
                    }
                    else
                    {
                        throw new InvalidOperationException("Невалидная задача");
                    }
                }
                else
                {
                    throw new Exception("Сотрудник уже раюотает");
                }
            }


            public Cashier() : base()
            {

            }
            public Cashier(string name, string surname, DateTime birthDate, Gender gender, float salary) 
                : base(name, surname, birthDate, gender, salary)
            {
                
            }
            public override string ToString()
            {
                return $"Cashier: {base.ToString()}";
            }
        }
    }
}
