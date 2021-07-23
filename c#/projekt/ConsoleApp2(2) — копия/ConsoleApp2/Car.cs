using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    namespace MyApp
    {
        enum Colors
        {
            RED,
            GREEN,
            BLUE,
            ORANGE
        }
        class Car : Vechilce
        {
            private Colors _color;
            public Colors Color
            {
                get
                {
                    return _color;
                }
            }
            public override void carryMaintenance()
            {
                throw new NotImplementedException();
            }

            public override void fillUp(object volume)
            {
                throw new NotImplementedException();
            }

            public override void move()
            {
                throw new NotImplementedException();
            }

            public override void repair()
            {
                throw new NotImplementedException();
            }
            public Car()
            {
                _color = Colors.ORANGE;
                Model = "ВАЗ 2109";
                Manufacturer = "Mersedes manufacturer";
                Power = 95;
                Weight = 1350f;
            }
            public Car(string model, string manufacturer, int power, float weight, Colors color)
            {
                Model = model;
                Manufacturer = manufacturer;
                Power = power;
                Weight = weight;
                _color = color;
            }
            public override void Print()
            {
                Console.WriteLine($"Vechilce: Model: {Model}; Manufacturer: {Manufacturer}; Weight: {Weight}; Power: {Power}; Color:{Color}");
            }
        }
    }
}
