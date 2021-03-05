using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerBuilder
{
    class Director
    {
        public void PCBuild(IBuilder builder)
        {
            builder.SetCase("Cougar MX140", "ATX");
            builder.SetMotherboard("Asus", "AM4", 4, 2);
            builder.SetCPU("AMD Ryzen 5 1600X", 6, 12, 3.6, "AM4");
            builder.SetRAM("Corsair", 8, 4, 2);
            builder.SetFan("Corsair", 1400, "AM4");
            builder.SetGPU("NVidia GeForce GTX 1660", 1785.0, 6);
            builder.SetPowerSupply("AeroCool", 650);
        }
    }
}
