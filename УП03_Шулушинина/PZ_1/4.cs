using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ1_4
{
    class Car
    {
        public string name;
        public double maxSpeed;
        private double _time;
        public double time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = CalculateTime(value);
            }
        }
        public double CalculateTime(double distance)
        {
            return distance / maxSpeed;
        }
        public void InfoCar()
        {
            Console.WriteLine($"Название автомобиля: {name}, максимальная скрость: {maxSpeed}.");
        }
        public Car()
        {
            this.name = "Автомобиль";
            this.maxSpeed = 160;
            this.time = 0;
        }
        public Car(string name, double speed, double time)
        {
            this.name = name;
            this.maxSpeed = speed;
            this.time = time;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[4];
            double distance = 400;
            Car astonMartin = new Car("Volkswagen Polo", 310, distance);
            cars[0] = astonMartin;
            Car audi = new Car("Infiniti FX 35", 340, distance);
            cars[1] = audi;
            Car ford = new Car("Audi Q7", 370, distance);
            cars[2] = ford;
            Car bugatti = new Car("Ferrari F40", 450, distance);
            cars[3] = bugatti;
            double[] races = new double[4];
            for (int i = 0; i < cars.Length; i++)
            {
                races[i] = cars[i].time;
            }
            Array.Sort(races);
            for (int i = 0; i < races.Length; i++)
            {
                for (int j = 0; j < cars.Length; j++)
                {
                    if (races[i] == cars[j].time)
                    {
                        Console.WriteLine($"{i+1} место занимает автомобиль {cars[j].name} с максимальной скоростью {cars[j].maxSpeed}, преодолев {distance} км за {Math.Round(cars[j].time, 2)} ч.");
                    }
                }
            }
            Console.ReadKey(true);
        }
    }
}