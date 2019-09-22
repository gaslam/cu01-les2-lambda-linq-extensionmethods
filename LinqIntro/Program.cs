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
            
        }

        
    }
}
