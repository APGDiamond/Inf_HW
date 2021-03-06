using System;
using System.Collections.Generic;
using System.Text;

namespace DIPrinciple
{
    class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("Печать на консоли");
        }
    }
}
