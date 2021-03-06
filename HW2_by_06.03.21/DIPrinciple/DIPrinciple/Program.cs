﻿using System;

namespace DIPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(new ConsolePrinter());
            book.Print();
            book.Printer = new HtmlPrinter();
            book.Print();
        }
    }
}
