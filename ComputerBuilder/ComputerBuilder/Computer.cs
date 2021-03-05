using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerBuilder
{
    class Computer
    {
        private List<string> _parts = new List<string>();
        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Комплектующие -------\n");
            foreach (string part in _parts)
                Console.WriteLine(part + "\n");
        }
    }
}
