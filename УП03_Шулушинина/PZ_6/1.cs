using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PZ6_1
{
    class Phone
    {
        public Phone (string model, string number)
        {
            Model = model;
            Number = number;
        }
        public string Model
        {
            get;
            set;
        }
        public string Number
        {
            get;
            set;
        }
        public void Call(string number)
        {
            Console.WriteLine($"Вызов по номеру {number}");
            WriteToLog($"Вызов {number}");
        }
        protected void WriteToLog(string text)
        {
            File.AppendAllText("log.txt", $"{Model}, {DateTime.Now}: {text}\n");
        }
    }
    class Smartphone : Phone
    {
        public Smartphone (string model, string number, double cameraResolution) : base (model, number)
        {
            CameraResolution = cameraResolution;
        }
        public double CameraResolution
        {
            get;
            set;
        }
        public void Shoot()
        {
            Console.WriteLine("Снимок сделан");
            WriteToLog($"Снимок сделан");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone myHomePhone = new Phone("HonorX7 3110", "89192284750");
            myHomePhone.Call("85672537414");
            Smartphone myWorkPhone = new Smartphone("Xiaomi Mi6", "89205701647", 80.5);
            myWorkPhone.Call("112");
            myWorkPhone.Shoot();
            Console.ReadKey(true);
        }
    }
}
