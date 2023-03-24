using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ1-1
{
    class Car
    {
        public double maxSpeed;
        public double CalculateTime(double distance)
        {
            return distance / maxSpeed;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
