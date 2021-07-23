using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    namespace MyApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                //13пар
                /*bool isTrue = false;   //System.Boolean
                
                byte bit_1 = 1;  // 1байт System.SByte
                
                int age = 13;  //4байта 
                uint lenght = 15;
                short gf = 15;
                long ll = 15;  //8байт
                //long

                /*
                float 
                double 
                decimal - 
                */

                //char 

                //string

                //object Object

                /*Console.Title = "Могу первая программа";
                Console.WriteLine("Привет, меня зовут Роман");
                string name = "Alex";
                Console.WriteLine("Привет, меня зовут " + name);
                Console.WriteLine($"Привет, меня зовут {name}");

                Console.WriteLine("Укажите Ваш возраст:");
                uint age = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine($"Вам ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(age);
                Console.ResetColor();
                Console.Write("лет ");

                Random random = new Random();
                Console.WriteLine($"Псевдо случайное число: {random.Next()}");
                Console.WriteLine($"Псевдо случайное число(диапазон 0-9): {random.Next(0, 10)}");

                Console.WriteLine(age.GetType());
                Console.WriteLine(age.GetType().Name);
                */
                /*if (true)
                {

                }
                else { }
                switch (switch_on)
                {
                    default:
                }
                for (int i = 0; i < length; i++)
                {

                }
                while (true)
                {

                }
                do
                {

                } while (true);*/

                /*const uint SIZE = 10;
                int[] arr = new int[SIZE];  //System.Array
                //arr = new int[300];

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = random.Next(0, 10);
                }
                foreach (int item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();

                Array.Sort(arr);
                Console.WriteLine("Отсортировано: (default) по возрастанию");
                foreach (int item in arr)
                {
                    Console.Write(item + " ");
                }

                Array.Reverse(arr);
                Console.WriteLine("Реверс массива: ");
                foreach (int item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("Отсортировано: (default) по возрастанию: ");
                Array.Sort(arr, (x, y)=>x.CompareTo(y));
                foreach (int item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("Отсортировано: max-min: ");
                Array.Sort(arr, (x, y) => -x.CompareTo(y));
                foreach (int item in arr)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine("Компаратор - default: min-max");
                Comparer<int> defComp = Comparer<int>.Default;
                Array.Sort(arr, defComp);

                Console.WriteLine("Компаратор кастомный: max-min");
                Comparer<int> revComp = Comparer<int>.Create(new Comparison<int>((x, y) => x.CompareTo(y)));
                Array.Sort(arr, revComp); 
                foreach (int item in arr)
                {
                    Console.Write(item + " ");
                }

                //1 - читай документацию
                //2 - не изобретай велосипед

                Console.WriteLine("Самое большое число массива: ");
                Console.WriteLine(arr.Max());
                Console.WriteLine("Самое меньшее число массива: ");
                Console.WriteLine(arr.Min());
                Console.WriteLine("Среднее значение массива: ");
                Console.WriteLine(arr.Average());

                int searchValue = int.Parse(Console.ReadLine()); 
                Console.WriteLine("Встроенный алгорит бинарного поиска:");
                Console.WriteLine("Искомая позиция: " + Array.BinarySearch(arr, searchValue));*/

                /*const int SIZE = 10;
                Random random = new Random();
                int[,] twoDarray = new int[SIZE, SIZE];
                Console.WriteLine(twoDarray.Length);
                for (int row = 0; row < SIZE; row++)
                {
                    for (int cell = 0; cell < SIZE; cell++)
                    {
                        twoDarray[row, cell] = random.Next(0, 10);
                        Console.Write(twoDarray[row, cell] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Рваный массив: ");
                //рваный/зубчастый массив
                int[][] twoDHead = new int[SIZE][];
                //формируем структуру
                for (int r = 0; r < twoDHead.Length; r++)
                {
                    twoDHead[r] = new int[random.Next(0, 10)];
                }
                //заполнение данными:
                for (int r = 0; r < twoDHead.Length; r++)
                {
                    for (int c = 0; c < twoDHead[r].Length; c++)
                    {
                        twoDHead[r][c] = random.Next(0, 9);
                    }
                }
                //отображение массива:
                foreach (var row in twoDHead)
                {
                    foreach (var cell in row)
                    {
                        Console.Write(cell + " ");
                    }
                    Console.WriteLine();
                }*/

                /*Human human = new Human();
                Console.WriteLine(human.Name);
                Console.WriteLine(human.BirthDate);
                human.Surname = "Бубликов";
                Console.WriteLine(human.Surname);
                */
                Human max = new Human("Max", "Иванов", new DateTime(1995, 8, 25), Gender.MALE);
                max.Show();
                Console.WriteLine(max);

                Employee employee = new Employee("Иван", "Петрофф", new DateTime(2000, 1, 13), Gender.MALE, 3500f);
                employee.Show();
                Console.WriteLine();
                Tutor tutor = new Tutor("Юлия", "Козакова", new DateTime(2001, 12, 31), Gender.FEMALE, 4500f, "Музыка");
                tutor.Show();
                Console.WriteLine();

                Employee[] employees = {employee, tutor };

                Console.WriteLine("Сотрудники: ");
                foreach (var emp in employees)
                {
                    /*if (emp is Employee)
                    {
                        (emp as Employee).Show();
                    }*/
                    if (emp is Tutor)
                    {
                        (emp as Tutor).Show();
                    }
                    else
                    {
                        emp.Show();
                    }
                    Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++");
                }

            }
        }
    }
}
