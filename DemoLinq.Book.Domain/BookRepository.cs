using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLinq.Book.Domain
{
    public class BookRepository
    {
        private IEnumerable<Book> Programming;

        private IEnumerable<Book> Romans;

        public IEnumerable<Book> GetProgramming()
        {
              Programming = new Book[]
              {
                    new Book{BookId=1,Title="C# .Net Core",Uitgever="Prisma"},
                    new Book{BookId=2,Title="PHP7",Uitgever="Microsoft Publishers"}
              };
            return Programming;  

        }

        public IEnumerable<Book> GetRomans()
        {
            Romans = new List<Book>()
            {
                new Book{BookId=1,Title="De Terminator",Uitgever="Schwarzie"},
                new Book{BookId=2,Title="Rambo12",Uitgever="Stallone"}
            };
            return Romans;
        }

    }
}
