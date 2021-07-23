using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Common;
using ConsoleApp5.SQliteCore;

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


            /*string pathToBook = Environment.CurrentDirectory + "\\" + "book_01.txt";
            string shortDesc = "современный российский писатель-фантаст. Родился в семье учителя и инженера. До четырнадцати лет жил в Киргизии. Потом переехал на Урал";
            
            Book book_01 = new Book(pathToBook, "Война и мир", Genres.DRAM, Langs.RU, "A_5", "Noname comp*", new DateTime(2019, 05, 05));
            book_01.Authors.Add(new Author("Лев", "Толстой", new DateTime(1980, 01, 01), Gender.MALE, shortDesc));

            Book book_02 = new Book(pathToBook, "Зиний вечер", Genres.LOVE_STORY, Langs.RU, "A_5", "Noname comp*", new DateTime(2019, 05, 05));
            book_02.Authors.Add(new Author("Александр", "Пушкин", new DateTime(1980, 01, 01), Gender.MALE, shortDesc));

            Book book_03 = new Book(pathToBook, "Мертвые души", Genres.DRAM, Langs.RU, "A_5", "Noname comp*", new DateTime(2019, 05, 05));
            book_03.Authors.Add(new Author("Николай", "Гоголь", new DateTime(1980, 01, 01), Gender.MALE, shortDesc));

            Book book_04 = new Book(pathToBook, "Мертвые души", Genres.DRAM, Langs.RU, "A_5", "Noname comp*", new DateTime(2019, 05, 05));
            book_04.Authors.Add(new Author("Кто то", "Неизвестный", new DateTime(1980, 01, 01), Gender.MALE, shortDesc));

            Library library = new Library();
            library.addBook(book_01);
            library.addBook(book_02);
            library.addBook(book_03);
            library.addBook(book_04);
            
            
            Console.WriteLine(library);

            Book book_01_ref = library.getBook(book_01.Authors.First<Author>(), "Тайная жизнь города");
            Console.WriteLine(book_01_ref);

            Console.WriteLine("Нашли книгу: ");
            Console.WriteLine(library.getBook("Война и мир"));
            Console.WriteLine("Её жанр: ");
            Console.WriteLine(library.getBook("Война и мир").Genre);

            Console.WriteLine("Поиск нескольких книг по названию: ");
            Console.WriteLine("Найдено: " + library.getBooks("Мертвые души").Count + "книг");

            //Library - два метода
            //реализовать book=>Iprinted
            //generic collection

            Reader readerMax =
                new Reader(
                        "Максим",
                        "Читатель",
                        new DateTime(1995, 1, 15),
                        Gender.MALE,
                        "max@gmail.com",
                        "+380966156315",
                        "Украина", ReaderRate.Neitural);
            ReaderCard readerCardMax = new ReaderCard(readerMax);

            readerCardMax.AddRecord(book_01);
            readerCardMax.AddRecord(book_02);
            readerCardMax.AddRecord(book_03);

            Console.WriteLine("У Макса на руках: " + readerCardMax.Records.Count);
            Console.WriteLine("Макс раньше брал книги: " + readerCardMax.ArchiveRecords.Count + " шт");
            readerCardMax.DelRecord(book_02); //возвращает книгу

            Console.WriteLine("У Макса сейчас на руках: "  + readerCardMax.Records.Count + " шт");
            Console.WriteLine("Макс раньше брал книги: " + readerCardMax.ArchiveRecords.Count + " шт");

            Console.WriteLine(readerCardMax.ArchiveRecords[0]);

            Console.WriteLine(readerCardMax);*/


            //AppDomain.CurrentDomain.BaseDirectory

            /* string pathToDataBase = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MyDataBase.sqlite");
             //Console.WriteLine(pathToDataBase);

             if (!File.Exists(pathToDataBase))
             {

                 SQLiteConnection.CreateFile(pathToDataBase);
                 //разворачиваем структуру бд
             }

             SQLiteConnection qLiteConnection = new SQLiteConnection($"DataSource={pathToDataBase}; Version=3;");*/

            /*qLiteConnection.Open();
            string queryQT_users = "CREATE TABLE IF NOT EXISTS users(id INTEGER PRIMARY KEY, login varchar(16) NOT NULL, email varchar(128) NOT NULL , password varchar(255) NOT NULL)";
                SQLiteCommand qLiteCommandCreateTable = new SQLiteCommand(queryQT_users, qLiteConnection);
            qLiteCommandCreateTable.ExecuteNonQuery();
            qLiteConnection.Close();*/



            /*qLiteConnection.Open();
            SQLiteCommand qLiteCommandInsertUser = new SQLiteCommand("", qLiteConnection);
            Random random = new Random();
            for (int i = 1; i < 6; i++)
            {
                qLiteCommandInsertUser.CommandText = $"INSERT INTO users (login, email, password) VALUES('user_{i}', 'user_{i}@gmail.com', 'querty')";
                qLiteCommandInsertUser.ExecuteNonQuery();
            }
            qLiteConnection.Close();*/


            /*qLiteConnection.Open();
            SQLiteCommand qLiteCommandSelectUsers = new SQLiteCommand("SELECT * FROM users", qLiteConnection);

            SQLiteDataReader usersReader = qLiteCommandSelectUsers.ExecuteReader();

            Console.WriteLine(usersReader);
            foreach (DbDataRecord user in usersReader)
            {
                for (int i = 0; i < user.FieldCount; i++)
                {
                    Console.WriteLine(user.GetValue(i));
                }
            }

            qLiteConnection.Close();*/

            /* UserModel userM = new UserModel("users");

             Console.WriteLine(userM[0]);
             Console.WriteLine(userM[0]["id"]);*/

          /*  const int SIZE = 10;
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
            Console.WriteLine();*/
        }
    }
}
