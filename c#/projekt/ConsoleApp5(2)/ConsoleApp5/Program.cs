using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
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

            Book book_02 = new Book(pathToBook, "voyna i mir", Genres.DRAM, Langs.RU, "A_5", "Noname comp*", new DateTime(2019, 05, 05));
            book_02.Authors.Add(new Author("lev", "tolstoy", new DateTime(1980, 01, 01), Gender.MALE, shortDesc));
           
            Book book_03 = new Book(pathToBook, "zimniy vecher", Genres.LOVE_STORY, Langs.RU, "A_5", "Noname comp*", new DateTime(2019, 05, 05));
            book_03.Authors.Add(new Author("aleksandr", "pushkin", new DateTime(1980, 01, 01), Gender.MALE, shortDesc));

            Book book_04 = new Book(pathToBook, "mertvye dushy", Genres.DRAM, Langs.RU, "A_5", "Noname comp*", new DateTime(2019, 05, 05));
            book_04.Authors.Add(new Author("nikolay", "gogol", new DateTime(1980, 01, 01), Gender.MALE, shortDesc));

            Book book_05 = new Book(pathToBook, "mertvye dushy", Genres.DRAM, Langs.RU, "A_5", "Noname comp*", new DateTime(2019, 05, 05));
            book_05.Authors.Add(new Author("noname", "sernoname", new DateTime(1980, 01, 01), Gender.MALE, shortDesc));

            //Console.WriteLine(book_01);
            //Console.WriteLine(book_01.Authors[0]);


            Library library = new Library();
            library.addBook(book_01);
            library.addBook(book_02);
            library.addBook(book_03);
            library.addBook(book_04);
            library.addBook(book_05);
            Console.WriteLine(library);

            Book book_01_ref = library.getBook(book_01.Authors.First<Author>(), "Тайная жизнь города");
            Console.WriteLine(book_01_ref);

            Console.WriteLine("poisk neskolkih knig");
            Console.WriteLine(" naydeno: " + library.getBooks("mertvye dushy").Count + "knig");

            //Library - два метода
            //реализовать book=>Iprinted
            //generic collection

            Reader readerMax = new Reader("Maksim", "Chitatil", new DateTime(1992, 1, 15), Gender.MALE, "max@gmail.com", "+380966156315", "ukraina", ReaderRate.Neitural);



            string pathToDataBase = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MyDataBase.sqlite");
            //Console.WriteLine(pathToDataBase);



            if (!File.Exists(pathToDataBase))
            {

                SQLiteConnection.CreateFile(pathToDataBase);
                //разворачиваем структуру бд
            }



            SQLiteConnection qLiteConnection = new SQLiteConnection($"DataSource={pathToDataBase}; Version=3;");

            /*qLiteConnection.Open();
            string queryQT_users = "CREATE TABLE IF NOT EXISTS users(id INTEGER PRIMARY KEY, login varchar(16) NOT NULL, email varchar(128) NOT NULL , password varchar(255) NOT NULL)";
                SQLiteCommand qLiteCommandCreateTable = new SQLiteCommand(queryQT_users, qLiteConnection);
            qLiteCommandCreateTable.ExecuteNonQuery();
            qLiteConnection.Close();*/





            qLiteConnection.Open();
            SQLiteCommand qLiteCommandInsertUser = new SQLiteCommand("", qLiteConnection);
            Random random = new Random();
            for (int i = 1; i < 6; i++)
            {
                qLiteCommandInsertUser.CommandText = $"INSERT INTO users (login, email, password) VALUES('user_{i}', 'user_{i}@gmail.com', 'querty')";
                qLiteCommandInsertUser.ExecuteNonQuery();
            }
            qLiteConnection.Close();
            qLiteConnection.Open();
            SQLiteCommand qLiteCommandSelectUser = new SQLiteCommand("SELECT * FROM users", qLiteConnection);
            SQLiteDataReader usersReader = qLiteCommandSelectUser.ExecuteReader();

            Console.WriteLine(usersReader);
            foreach (DbDataRecord user in usersReader)
            {
                for (int i = 0; i < user.FieldCount; i++)
                {
                    Console.WriteLine(user.GetValue(i));
                }
            }
            qLiteConnection.Close();
        }
    }
}
