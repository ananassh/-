using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ3_6
{
    internal class Program1
    {
        class MyRandomList
        {
            private List<int> numbersList = new List<int>();
            Random rand = new Random();
            private int n
            {
                set
                {
                    SetLength(value);
                }
            }
            public double Average
            {
                get
                {
                    return CalculateAverage();
                }
            }
            public double Variance
            {
                get
                {
                    return CalculateVariance();
                }
            }
            public double Deviation
            {
                get
                {
                    return CalculateStandardDeviation();
                }
            }
            public double Median
            {
                get
                {
                    return CalculateMedian();
                }
            }
            private void SetLength(int n)
            {
                n = numbersList.Count;
            }
            public void AddNumber()
            {
                numbersList.Add(rand.Next(101));
            }
            public void RemoveNumber(int number)
            {
                numbersList.Remove(number);
            }
            private double CalculateAverage()
            {
                int sum = 0;
                foreach (int number in numbersList)
                {
                    sum += number;
                }
                return sum / numbersList.Count;
            }
            private double CalculateVariance()
            {
                double sum = 0;
                foreach (int number in numbersList)
                {
                    sum += Math.Pow((number - Average), 2);
                }
                return Math.Round(sum / numbersList.Count, 2);
            }
            private double CalculateStandardDeviation()
            {
                CalculateVariance();
                return Math.Round(Math.Sqrt(Variance), 2);
            }
            private double CalculateMedian()
            {
                numbersList.Sort();
                if (numbersList.Count % 2 == 0) {
                    return (numbersList[numbersList.Count / 2] + numbersList[numbersList.Count / 2 - 1]) / 2;
                } else
                {
                    double middle = numbersList.Count / 2;
                    middle = Math.Ceiling(middle);
                    return numbersList[Convert.ToInt32(middle)];
                }
            }
        }
        static void Main(string[] args)
        {
            MyRandomList numbers = new MyRandomList();
            for (int i = 0; i < 11; i++)
            {
                numbers.AddNumber();
            }
            Console.WriteLine(numbers.Variance);
            Console.WriteLine(numbers.Deviation);
            Console.WriteLine(numbers.Median);
            Console.ReadKey(true);
        }
    }
}