using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    namespace MyApp
    {
        abstract class Vechilce
        {
            private string _model;
            private string _manufacturer;
            private float _weight;
            private int _power;
            public string Model
            {
                get
                {
                    return _model;
                }
                set
                {
                    if (value.Length >= 2)
                    {
                        _model = value;
                    }
                    else
                    {
                        throw new ArgumentException("");
                    }
                }
            }
            public string Manufacturer
            {
                get
                {
                    return _manufacturer;
                }
                set
                {
                    if (value.Length >= 2)
                    {
                        _manufacturer = value;
                    }
                    else
                    {
                        throw new ArgumentException("");
                    }
                }
            }
            public float Weight
            {
                get
                {
                    return _weight;
                }
                set
                {
                    if(value >= 0)
                    {
                        _weight = value;
                    }
                    else
                    {
                        throw new ArgumentException("");
                    }
                }
            }
            public int Power
            {
                get
                {
                    return _power;
                }
                set
                {
                    if(value >= 0)
                    {
                        _power = value;
                    }
                    else
                    {
                        throw new ArgumentException("");
                    }
                }
            }

            public abstract void move();
            public abstract void fillUp(Object volume);
            public abstract void repair();

            public abstract void carryMaintenance();

            public virtual void Print()
            {
                Console.WriteLine($"Vechilce: Model: {Model}; Manufacturer: {Manufacturer}; Weight: {Weight}; Power: {Power}");
            }
        }
    }
}
