using System;
using System.Collections;
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
            private string _name;
            private Director _director;
            public Company(string name, Director director)
            {
                Name = name;
                _director = director;
            }
            public String Name
            {
                get
                {
                    return _name;
                }
                set
                {
                    _name = value;
                }
            }
            public Director Director {
                get
                {
                    return _director;
                }
            }
            public void AddWorker(IWorker worker)
            {
                _director.ListWorkers.Add(worker);
            }
            public List<IWorker> Workers
            {
                get
                {
                    return _director.ListWorkers;
                }
            }
            public void RemoveWorker(IWorker worker)
            {

            }
            public override string ToString()
            {
                return $"Company:Title: {Name}; Director: {Director.Name}; Count Workers: {Director.ListWorkers.Count}";
            }

            /*public Employee this[int index]
            {
                get
                {
                    return _workers[index];
                }
                set
                {
                    if(_workers.Length > 0)
                    {
                        if(index >= 0 && index < _workers.Length)
                        {
                            _workers[index] = value;
                        }
                    }
                }
            }*/

        }
    }
}
