using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerBuilder
{
    class PCBuilder : IBuilder
    {
        private Computer _computer = new Computer();
        public void SetCase(string name, string sizetype)
        {
            _computer.Add($"Корпус {name} размера {sizetype}.");
        }

        public void SetCPU(string name, int coreCount, int threadsCount, double freq, string socket)
        {
            _computer.Add($"Процессор {name} с {coreCount} ядрами и {threadsCount} потоками. Частота - {freq}, Тип сокета - {socket}.");
        }

        public void SetFan(string name, int rpm, string socket)
        {
            _computer.Add($"Кулер {name} со скоростью оборотов {rpm} для сокета {socket}.");
        }

        public void SetGPU(string name, double freq, int ram)
        {
            _computer.Add($"Видеокарта {name} с частотой {freq} и объёмом оперативной памяти {ram}Гб.");
        }

        public void SetMotherboard(string name, string socket, int ddrType, int maxddrCount)
        {
            _computer.Add($"Материнская плата {name} для сокета {socket} и ОЗУ типа DDR{ddrType}. Макс. кол-во планок ОЗУ - {maxddrCount}.");
        }

        public void SetPowerSupply(string name, int maxPower)
        {
            _computer.Add($"Блок питания {name} с мощьностью {maxPower}W.");
        }

        public void SetRAM(string name, int capacity, int ddrType, int count)
        {
            _computer.Add($"ОЗУ {name} c типом DDR{ddrType} и объёмом {capacity}. Кол-во - {count} шт.");
        }
        public Computer GetResult()
        {
            return _computer;
        }
    }
}
