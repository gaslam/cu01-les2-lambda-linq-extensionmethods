using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DemoLinq.Book.Domain;
namespace DemoLinq.Book.Domain
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Uitgever { get; set; }
    } 
}
