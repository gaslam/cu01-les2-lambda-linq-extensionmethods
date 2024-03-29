﻿using DemoLinq.Book.Domain;
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
            BookRepository bookRepository = new BookRepository();
            var romans = bookRepository.GetProgramming();

            //met linq
            var BooksWithC = romans.Where(b => b.Title.Contains("C"));
            
            foreach (var book in BooksWithC)
            {
                Console.WriteLine(book.Title);
            }

            int getal = 4;
            var result = getal.DivideByTwo();
            Console.WriteLine($"Resultaat: {result}");

            Worker worker = new Worker();
            worker.DoWork();
            while(!worker.WorkDone)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }
        }

        //Ander filter voorbeeld (referentie steek je in BooksWithC)
        static bool FilterWithC(Book book)
        {
            return book.Title.Contains("C");
        }

        static async void Telop()
        {

        }
        
    }
}
