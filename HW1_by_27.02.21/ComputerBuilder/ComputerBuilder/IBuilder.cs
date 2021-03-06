using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerBuilder
{
    interface IBuilder
    {
        void SetCPU(string name, int coreCount, int threadsCount, double freq, string socket);
        void SetGPU(string name, double freq, int ram);
        void SetRAM(string name, int capacity, int ddrType, int count);
        void SetMotherboard(string name, string socket, int ddrType, int maxddrCount);
        void SetCase(string name, string sizetype);
        void SetFan(string name, int rpm, string socket);
        void SetPowerSupply(string name, int maxPower);
        Computer GetResult();
    }
}
