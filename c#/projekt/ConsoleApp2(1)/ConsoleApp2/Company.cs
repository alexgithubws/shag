using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    namespace MyApp
    {
        class Company
        {
            private Employee[] _workers; //10

            public void AddWorker(Employee employee)
            {
                Employee[] employees = new Employee[_workers.Length+1]; //массив сотрудников

                for (int i = 0; i < _workers.Length; i++)
                {
                    employees[i] = _workers[i];
                }
                employees[employees.Length - 1] = employee;
                _workers = employees;
            }

            public void AddWorker(Tutor tutor)
            {
                Employee[] employees = new Employee[_workers.Length + 1]; //массив сотрудников

                for (int i = 0; i < _workers.Length; i++)
                {
                    employees[i] = _workers[i];
                }
                employees[employees.Length - 1] = tutor;
                _workers = employees;
            }
            public void RemoveWorker(int index)
            {
                Employee[] employees = new Employee[_workers.Length - 1];
                for (int i = 0; i < _workers.Length; i++)
                {
                    if(i < index)
                    {
                        employees[i] = _workers[i];
                    }
                    else if(i > index)
                    {
                        employees[i - 1] = _workers[i];
                    }
                    _workers = employees;
                }
            }
            public Employee this[int index]
            {
                get
                {
                    return _workers[index];
                }
                set
                {
                    if (_workers.Length > 0)
                    {
                        if(index >= 0 && index < _workers.Length)
                        {
                            _workers[index] = value;
                        }
                    }
                }
            }
        }
    }
}
