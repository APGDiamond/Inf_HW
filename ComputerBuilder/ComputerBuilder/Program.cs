using System;

namespace ComputerBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new PCBuilder();
            director.PCBuild(builder);
            Computer computer = builder.GetResult();
            computer.Show();
        }
    }
}
