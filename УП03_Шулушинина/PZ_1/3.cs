using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ1_3
{
    class Car
    {
        public string name;
        public double maxSpeed;
        public double CalculateTime(double distance)
        {
            return distance / maxSpeed;
        }
        public void InfoCar()
        {
            Console.WriteLine($"Название автомобиля: {name}, максимальная скорость: {maxSpeed}.");
        }
        public Car()
        {
            this.name = "Audi";
            this.maxSpeed = 160;
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
