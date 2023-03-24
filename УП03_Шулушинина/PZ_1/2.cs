using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ1_2
{
    class Car
    {
        public string name;
        public double maxSpeed;
        public double CalculateTime(double distance)
        {
            return distance / maxSpeed;

        }
        public Car()
        {
            this.name = "Автомобиль";
            this.maxSpeed = 220;
        }
        public Car(string name, double speed)
        {
            this.name = name;
            this.maxSpeed = speed;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
