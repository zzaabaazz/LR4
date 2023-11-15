using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal class Room
    {
        double Length;
        double Width;
        double Height;
        int Windows;

        public Room(double Length, double Width, double Height, int Windows)
        {
            this.Length = Length;
            this.Width = Width;
            this.Height = Height;
            this.Windows = Windows;
        }
        /*
        public string GetInformation()
        {
            string information;
            information = "Модель: " + this.Model + "; Тактовая частота: " + this.ClockRate +
                "; Марка: " + this.Brand + "; Объем жесткого диска: " + this.HardCapacity +
                "; Объем оперативоной памяти: " + this.RamCapacity + "; Стоимость: " + this.Price;
            return information;
        }
        */
    }
}
