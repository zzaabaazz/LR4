using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal class Computer
    {
        string Model;
        double ClockRate;
        string Brand;
        int HardCapacity;
        int RamCapacity;
        double Price;

        public Computer(string Model, double ClockRate, string Brand, int HardCapacity, int RamCapacity, double Price)
        {
            this.Model = Model;
            this.ClockRate = ClockRate;
            this.Brand = Brand;
            this.HardCapacity = HardCapacity;
            this.RamCapacity = RamCapacity;
            this.Price = Price;
        }

        public string GetInformation()
        {
            string information;
            information = "Модель: " + this.Model + "; Возраст: " + this.ClockRate.ToString() + "; Профессия: " +
           this.Brand;
            return information;
        }

    }
}
