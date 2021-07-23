using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ghh
{
    class Program
    {
        static void Main(string[] args)
        {


            const int SIZE = 10;
            int[] elems = new int[SIZE];
            Random random = new Random();
            for (int i = 0; i < elems.Length; i++)
            {
                elems[i] = random.Next(0, 10);
                Console.WriteLine(elems[i] + " ");
            }
            Console.WriteLine();


            var query = from elem in elems select elem;
            foreach (var item in query)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();

            var queryTwo = from el in elems where el % 2 == 0 select el;

            Console.WriteLine("tolka chetnoe");
            foreach (var item in queryTwo)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var queryTwoAsc = from elasc in elems where elasc % 2 == 0 orderby elasc ascending select elasc;
            foreach (var item in queryTwoAsc)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            var queryTwoDesc = from eldesc in elems where eldesc % 2 == 0 orderby eldesc descending select eldesc;
            foreach (var item in queryTwoDesc)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            int[] bigArr = new int[SIZE*3];
            for (int i = 0; i < bigArr.Length; i++)
            {
                bigArr[i] = random.Next(10, 99);
                Console.Write(bigArr[i] + " ");
            }

            var groupQuwery = from val in bigArr group val by val % 10;
            foreach (var key in groupQuwery)
            {
                Console.WriteLine(" key grupirovaniya danyh : " + key.Key);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("sgrupirovanye danye :  ");
                foreach (var item in key)
                {
                    Console.Write(item + " ");
                }
                Console.ResetColor();
                Console.WriteLine();
            }


            var promQuery = from prmVal in bigArr group prmVal by prmVal % 10 into tmp where tmp.Count() > 3 select tmp;
            Console.WriteLine("promejutochnye rezultaty");
            foreach (var key in promQuery)
            {
                Console.WriteLine(" key grupirovaniya danyh : " + key.Key);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("sgrupirovanye danye :  ");
                foreach (var item in key)
                {
                    Console.Write(item + " ");
                }
                Console.ResetColor();
                Console.WriteLine();


                string[] text =
                {
                   "Типы записей упрощают создание неизменяемых ссылочных типов в .NET. Исторически типы .NET в основном классифицируются как ссылочные типы" +
                   " (включая классы и анонимные типы) и типы значений (включая структуры и кортежи)." +
                   " Хотя рекомендуется использовать неизменяемые типы значений, изменяемые типы значений часто не приводят к ошибке.f"
                };
                var wordQuery = from row in text let oneWord = row.Split('.', ',', '!', '?', ' ') from oW in oneWord select oW;

                foreach (var item in wordQuery)
                {
                    Console.WriteLine(item);
                }
                
                Console.ForegroundColor = ConsoleColor.Green;
                var wordQuerymin = from row in text let oneWord = row.Split('.', ',', '!', '?', ' ') from oW in oneWord where oW.Count() > 5 select oW;
                foreach (var item in wordQuerymin)
                {
                    Console.WriteLine(item);
                }
                Console.ResetColor();
            }
        }
    }
}
