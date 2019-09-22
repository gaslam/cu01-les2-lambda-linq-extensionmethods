using DemoLinq.Book.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LinqIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Book> Programming = new Book[]
             {
                new Book{BookId=1,Title="C# .Net Core",Uitgever="Prisma"},
                new Book{BookId=2,Title="PHP7",Uitgever="Microsoft Publishers"}
            };

            IEnumerable<Book> Romans = new List<Book>()
            {
                new Book{BookId=1,Title="De Terminator",Uitgever="Schwarzie"},
                new Book{BookId=2,Title="Rambo12",Uitgever="Stallone"}
            };
            //filteren zonder Linq
            //List<Book> booksWithC = new List<Book>();

            /*Book book = new Book();
            var work = book.DoWork();
            var books = book.GetBooks();
            print(books.Result);
            Console.WriteLine(work.Result);
            */
            Worker worker = new Worker();
            worker.DoWork();
            Console.Write("Calculating:");
            while (!worker.WorkDone)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }
    }

        static async void  callAsync()
        {
            Book book = new Book();
            var books = await book.GetBooks();
            print(books);
        }
        /*static void print(StringBuilder bookInfo)
        {
            Console.WriteLine(bookInfo.ToString());
        }*/
        static void print(IEnumerable<Book> books)
        {
            foreach(Book book in books)
            {
                Console.WriteLine(book.Title);
            }
        }

        static IEnumerable<Book> FilterBooksWithC(IEnumerable<Book> books)
        {
            foreach (var book in books)
            {
                if(book.Title.Contains("C"))
                    yield return book;
            }
        }
    }
}
