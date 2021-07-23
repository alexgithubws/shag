﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Author markTven = new Author("Марк", "Твен", new DateTime(1835, 11, 30), Gender.MALE, "Aмериканский писатель, журналист и общественный деятель");
            Console.WriteLine(markTven);

            foreach (string item in PaperStandarts.allFormats.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (Size item in PaperStandarts.allFormats.Values)
            {
                Console.WriteLine($"W: {item.Width}; H: {item.Height}");
            }

            foreach (KeyValuePair<string, Size> item in PaperStandarts.allFormats)
            {
                Console.WriteLine($"Format {item.Key}; Size: W {item.Value.Width}; H {item.Value.Height};");
            }

            Console.WriteLine(PaperStandarts.getSize("A_0"));
            Console.WriteLine(PaperStandarts.getPaperFormat("A_0"));


            string pathToBook = Environment.CurrentDirectory + "\\" + "book_01.txt";
            string[] bookRows = FileReader.ReadTxtFile(pathToBook);
            Console.WriteLine("Колиество строк: " + bookRows.Length);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(bookRows[0]);
            Console.ResetColor();
            Console.Read();*/


            /*Size sizePaper = PaperStandarts.getSize("A_4");
            Console.WriteLine($"Height: {sizePaper.Height}; Width: {sizePaper.Width}. ");*/



            /*List<Page> allPages = 
            StorageReader.getPages(Environment.CurrentDirectory + "\\" + "book_01.txt", PaperStrogeStandarts.getPaperInfo("A_4"));

            Console.WriteLine(allPages[1].Text);*/


            string pathToBook = Environment.CurrentDirectory + "\\" + "book_01.txt";
            string shortDesc = "современный российский писатель-фантаст. Родился в семье учителя и инженера. До четырнадцати лет жил в Киргизии. Потом переехал на Урал";
            Book book_01 = new Book(pathToBook, "Тайная жизнь города", Genres.FANTASY, Langs.RU, "A_5", "Noname comp*", new DateTime(2019, 05, 05));
            book_01.Authors.Add(new Author("КОНСТАНТИН", "МУРАВЬЁВ", new DateTime(1980, 01, 01), Gender.MALE, shortDesc));

            //Console.WriteLine(book_01);
            //Console.WriteLine(book_01.Authors[0]);
            

            Library library = new Library();
            library.addBook(book_01);
            Console.WriteLine(library);

            Book book_01_ref = library.getBook(book_01.Authors.First<Author>(), "Тайная жизнь города");
            Console.WriteLine(book_01_ref);


            //Library - два метода
            //реализовать book=>Iprinted
            //generic collection
        }
    }
}
