using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

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
                /*Human max = new Human("Max", "Иванов", new DateTime(1995, 8, 25), Gender.MALE);
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
                /*if (emp is Tutor)
                {
                    (emp as Tutor).Show();
                }
                else
                {
                    emp.Show();
                }
                Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++");*/


                /*Car запорожец = new Car();
                запорожец.Print();

                Point2D point2D = new Point2D();
                ++point2D;
                point2D++;
                Console.WriteLine(point2D);
                Console.WriteLine(-point2D);

                Point2D pnext = new Point2D(100, 100, Colors.GREEN);
                point2D = point2D + pnext;
                Console.WriteLine(point2D);*/

                /*point2D *= pnext;
                point2D = point2D - pnext;

                Console.WriteLine(point2D);

                pnext = pnext * 3;
                pnext = 3 * pnext;*/

                /*Company company = new Company("Рога и копыта", new Director("Алекс", "Рогов", new DateTime(1980, 05, 15), Gender.MALE, 500000f));
                company.AddWorker(new Cashier("Маша", "Рогова", new DateTime(), Gender.FEMALE, 5500f));*/
                //Console.WriteLine($"Название компании: {company.Name}") ;
                //Console.WriteLine("Список сотрудников: ");
                /*foreach (var item in company.Workers)
                {
                    Console.WriteLine(item.ToString());
                }*/

                /*ArrayList arrayList = new ArrayList();
                //arrayList.Add(13);
                //arrayList.Add("String");
                //arrayList.Add(company);
                arrayList.Add(new Employee("Иван", "Петрофф", new DateTime(2005, 1, 13), Gender.MALE, 3500f));
                arrayList.Add(new Employee("Петр", "Сидорофф", new DateTime(2002, 10, 13), Gender.MALE, 4520f));
                arrayList.Add(new Employee("Сергей", "Иванофф", new DateTime(2015, 11, 13), Gender.MALE, 6520f));
                arrayList.Add(new Employee("Максим", "Сергеев", new DateTime(1995, 7, 13), Gender.MALE, 3520f));
                arrayList.Add(new Employee("Евген", "Некрасов", new DateTime(1970, 9, 13), Gender.MALE, 4511f));
                /*arrayList.Add(new Employee("Евген", "Некрасов", new DateTime(1970, 9, 13), Gender.MALE, 4511f));
                arrayList.Add(new Employee("Евген", "Некрасов", new DateTime(1970, 9, 13), Gender.MALE, 4511f));
                arrayList.Add(new Employee("Евген", "Некрасов", new DateTime(1970, 9, 13), Gender.MALE, 4511f));
                arrayList.Add(new Employee("Евген", "Некрасов", new DateTime(1970, 9, 13), Gender.MALE, 4511f));*/

                //Console.WriteLine(arrayList[0]);
                /*foreach (var item in arrayList)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine(arrayList.Capacity); 
                Console.WriteLine(arrayList.Count);    


                Console.WriteLine("Name Sorted ASC: ");
                
                Comparer<Employee> nameEmployerComparerASC = Comparer<Employee>.Create(new Comparison<Employee>(delegate(Employee a, Employee b) {
                    return a.Name.CompareTo(b.Name);
                }));

                arrayList.Sort(nameEmployerComparerASC);
                foreach (var item in arrayList)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Name Sorted DESC: ");
                Comparer<Employee> nameEmployerComparerDESC = Comparer<Employee>.Create(new Comparison<Employee>(delegate (Employee a, Employee b) {
                    return b.Name.CompareTo(a.Name);
                }));
                arrayList.Sort(nameEmployerComparerDESC);
                foreach (var item in arrayList)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Salary Sorted DESC: ");
                Comparer<Employee> salaryEmployerComparerDESC = Comparer<Employee>.Create(new Comparison<Employee>(delegate (Employee a, Employee b) {
                    return b.Salary.CompareTo(a.Salary);
                }));
                arrayList.Sort(salaryEmployerComparerDESC);
                foreach (var item in arrayList)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Сортировка по умолчанию: (Фамилия)");
                arrayList.Sort();
                foreach (var item in arrayList)
                {
                    Console.WriteLine(item);
                }*/

                /*Hashtable hashtable = new Hashtable();
                hashtable.Add(
                    new Employee("Иван", "Петрофф", new DateTime(2005, 1, 13), Gender.MALE, 3500f),
                    new ArrayList { 3500f, 4500f, 6500f }
                );
                hashtable.Add(
                    new Employee("Петр", "Сидорофф", new DateTime(2002, 10, 13), Gender.MALE, 4520f),
                    new ArrayList { 3500f, 4500f, 6500f }
                );
                hashtable.Add(
                    new Employee("Сергей", "Иванофф", new DateTime(2015, 11, 13), Gender.MALE, 6520f),
                    new ArrayList { 3500f, 4500f, 6500f }
                );

                foreach (Employee emp in hashtable.Keys)
                {
                    emp.Show();
                    Console.WriteLine("\n\tЗарплата сотрудника: ");
                    foreach (float salary in (hashtable[emp] as ArrayList))
                    {
                        Console.WriteLine("\t\t" + salary);
                    }
                }

                object a = 45; //boxing
                int number = (int)a; //unboxing

                */
                /*-----------------------*/
                /* ArrayList <=> List
                 Hashtable <=> Dictionary
                 SortedList <=> SortedList*/
                /*-----------------------*/
                /*Dictionary<char, SortedList<string, List<Employee>>> dictionary =
                        new Dictionary<char, SortedList<string, List<Employee>>>();

                for (int i = 65; i < 91; i++)
                {
                    dictionary.Add((char)i, new SortedList<string, List<Employee>>());
                }
                for (int i = 1040; i < 1072; i++)
                {
                    dictionary.Add((char)i, new SortedList<string, List<Employee>>());
                }
                foreach (char letter in dictionary.Keys)
                {
                    Console.WriteLine(letter);
                }

                Employee employee_1 =  new Employee("Иван", "Петрофф", new DateTime(2005, 1, 13), Gender.MALE, 3500f);
                Employee employee_2 = new Employee("Петр", "Сидорофф", new DateTime(2002, 10, 13), Gender.MALE, 4520f);
                Employee employee_3 = new Employee("Сергей", "Иванофф", new DateTime(2015, 11, 13), Gender.MALE, 6520f);
                */


                /*Point3D<int> point3D = new Point3D<int>(50, 150, 300);
                Console.WriteLine(point3D);

                Point3D<double> point3D1 = new Point3D<double>(0.05, 0.00, 15.00);
                Console.WriteLine(point3D1);

                Point3D<char> point3DChar = new Point3D<char>('a', 'a', 'b');
                Console.WriteLine(point3DChar);

                Console.WriteLine("Массив generic точек на трехмерном пространстве: ");
                Point3D<int>[] pointsArr = new Point3D<int>[15];

                Random random = new Random();
                for (int i = 0; i < pointsArr.Length; i++)
                {
                    pointsArr[i] = new Point3D<int>(random.Next(0, 10), random.Next(0, 10), random.Next(0, 10));
                }
                foreach (Point3D<int> point in pointsArr)
                {
                    Console.WriteLine(point);
                }*/

                /*MyLibrary<char, Employee> record_1 = new MyLibrary<char, Employee>('С', new Employee("Петр", "Сидорофф", new DateTime(2002, 10, 13), Gender.MALE, 4520f));
                MyLibrary<char, Employee> record_2 = new MyLibrary<char, Employee>('И', new Employee("Сергей", "Иванофф", new DateTime(2015, 11, 13), Gender.MALE, 6520f));

                Console.WriteLine(record_1.First);
                Console.WriteLine(record_1.Second);
                MyLibrary<int, int> myLibrary = new MyLibrary<int, int>();*/


                /*Employee employee_1 = new Employee("Иван", "Петрофф", new DateTime(2005, 1, 13), Gender.MALE, 3500f);
                Employee employee_2 = new Employee("Петр", "Сидорофф", new DateTime(2002, 10, 13), Gender.MALE, 4520f);
                Employee employee_3 = new Employee("Сергей", "Иванофф", new DateTime(2015, 11, 13), Gender.MALE, 6520f);


                //Сереализация--------------------------------------------------------------------------start
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Stream fStreamBin = File.Create("Employee.bin");
                    binaryFormatter.Serialize(fStreamBin, employee_1);
                fStreamBin.Close();
                //Сереализация--------------------------------------------------------------------------end
                //Десереализация--------------------------------------------------------------------------start
                Console.WriteLine("Десереализованный обьект: ");
                Employee readedEmployeer =(Employee)binaryFormatter.Deserialize(File.OpenRead("Employee.bin"));
                Console.WriteLine(readedEmployeer);
                //Десереализация--------------------------------------------------------------------------end

                //Сереализация--------------------------------------------------------------------------start
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
                Stream fStreamXML = File.Create("Employee.xml");
                xmlSerializer.Serialize(fStreamXML, employee_2);
                fStreamXML.Close();
                //Сереализация--------------------------------------------------------------------------end
                //Десереализация--------------------------------------------------------------------------start
                Employee employee =  (Employee)xmlSerializer.Deserialize(File.OpenRead("Employee.xml"));
                Console.WriteLine(employee);
                //Десереализация--------------------------------------------------------------------------end*/




                //FileStream
                //StreamWriter
                //StreamReader
                //BinaryReader
                //BinaryWriter
                //File
                //Directory
                //FileInfo
                //DirectoryInfo



                /*string href = "https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?date=20200302";
                WebClient webClient = new WebClient();
                string currency = webClient.DownloadString(href);

                byte[] bytes = Encoding.Default.GetBytes(currency);
                currency = Encoding.UTF8.GetString(bytes);

                //Console.WriteLine(currency);

                XmlDocument currencyDocument = new XmlDocument();
                currencyDocument.LoadXml(currency);

                XmlElement xRoot = currencyDocument.DocumentElement; //доступ в корень

                foreach (XmlNode xNode in xRoot)
                {
                    foreach (XmlNode chXNode in xNode)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(chXNode.Name + " ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(chXNode.InnerText);
                        Console.WriteLine();
                    }
                }

                /*
                 * Написать класс Конвертер валют:
                 *  - получает данные на любую дату
                 *  - конвертирует гривны в любую из этих валют
                 *  
                 */


                //Делегаты - массив указателей на функцию 

                CalcInt calcInt = new CalcInt(500);
                Console.WriteLine(calcInt);
                Console.WriteLine(calcInt.Div(100));

                CalcDelegat calcDelegat = new CalcDelegat(calcInt.Div);
                Console.WriteLine(calcDelegat(15));

                calcDelegat += calcInt.Multy;
                calcDelegat += calcInt.Sub;
                calcDelegat += calcInt.Summa;
                // calcDelegat += calcInt.SummaFloat; несовпадение сигнатуры

                //будет выполняться последний элемент из списка
                Console.WriteLine(calcDelegat(5));

                foreach (CalcDelegat item in calcDelegat.GetInvocationList())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(item(5));
                }

                //generic
                CalcDelegat<float> calc = new CalcDelegat<float>(calcInt.SummaFloat);

                Console.WriteLine(calc(15.5f));


                //Анонимные функции/методы: 
                ArrayList listEmployee = new ArrayList();
                listEmployee.Add(new Employee("Иван", "Петрофф", new DateTime(2000, 1, 13), Gender.MALE, 3500f));
                listEmployee.Add(new Employee("Алексей", "Иванофф", new DateTime(1995, 10, 25), Gender.MALE, 5500f));
                listEmployee.Add(new Employee("Жанна", "Д'Aрк", new DateTime(1430, 10, 5), Gender.FEMALE, 8500f));

                Console.WriteLine("Исходное состояние: ");
                foreach (Employee emp in listEmployee)
                {
                    Console.WriteLine(emp);
                }

                listEmployee.Sort();
                Console.WriteLine("Дефолтная сортировка: ");
                foreach (Employee emp in listEmployee)
                {
                    Console.WriteLine(emp);
                }

                Comparer<Employee> comparerSurname = Comparer<Employee>.Create(new Comparison<Employee>(delegate(Employee a, Employee b) {
                    return a.Surname.CompareTo(b.Surname);
                }));

                listEmployee.Sort(comparerSurname);
                Console.WriteLine("Cортировка по фамилии сотрудников: ");
                foreach (Employee emp in listEmployee)
                {
                    Console.WriteLine(emp);
                }

                Comparer<Employee> comparerSurnameDESC = 
                    Comparer<Employee>.Create(new Comparison<Employee>(Employee.CompareTwoEmployeersSurnameDESC));
                listEmployee.Sort(comparerSurnameDESC);
                Console.WriteLine("Cортировка по ниспаданию фамилии сотрудников: ");
                foreach (Employee emp in listEmployee)
                {
                    Console.WriteLine(emp);
                }



                /*Дз №1
                 * Определить класс EmployeeComparer в котором реализовать все доступные методы по сравнению данных
                 * для сортровки: name, surname, salary, birthDate
                 */


                Tutor tutor = new Tutor("Вася", "Шниперсон", new DateTime(1990, 10, 25), Gender.MALE, 5500f, "ХимиЯ");
                List<Student> groupTK_15 = new List<Student>();
                groupTK_15.Add(new Student("Иван", "Петрофф", new DateTime(2000, 1, 13), Gender.MALE, "TK_15"));
                groupTK_15.Add(new Student("Алексей", "Иванофф", new DateTime(1995, 10, 25), Gender.MALE, "TK_15"));
                groupTK_15.Add(new Student("Жанна", "Д'Aрк", new DateTime(1430, 10, 5), Gender.FEMALE, "TK_15"));

                tutor.OnExamEvent += groupTK_15[0].executeExamenTask; //повесил обработчик

                foreach (Student stud in groupTK_15)
                {
                    tutor.OnExamEvent += stud.executeExamenTask;
                }

                tutor.Examen("Сдать в кассу помощи 1,5л белой краски");




                Cashier cashier = new Cashier("Маша", "Стоянова", new DateTime(1975, 07, 15), Gender.FEMALE, 15000f);

                List<Employee> employeers = new List<Employee>();
                employeers.Add(new Employee("Иван", "Петрофф", new DateTime(2005, 1, 13), Gender.MALE, 3500f));
                employeers.Add(new Employee("Петр", "Сидорофф", new DateTime(2002, 10, 13), Gender.MALE, 4520f));
                employeers.Add(new Employee("Сергей", "Иванофф", new DateTime(2015, 11, 13), Gender.MALE, 6520f));
                employeers.Add(new Employee("Максим", "Сергеев", new DateTime(1995, 7, 13), Gender.MALE, 3520f));
                employeers.Add(new Employee("Евген", "Некрасов", new DateTime(1970, 9, 13), Gender.MALE, 4511f));


                cashier.OnSalaryGive += employeers[0].TakeSalary;

                //один сотрудник получил зарплату
                //cashier.GiveSalary(new SalaryEventArg { Name = "Сотрудники отдела продаж", Salary = 3600f });
                
                Random random = new Random();
                foreach (Employee item in employeers)
                {
                    cashier.GiveSalary(new SalaryEventArg { Name = "Сотрудник отдела продаж", Salary = (float)(3500f + random.NextDouble()*5000f) });
                }

                //весь отдел получает зарплату:
                foreach (Employee item in employeers)
                {
                    cashier.OnSalaryGive += item.TakeSalary;
                }

            }
        }
    }
}
