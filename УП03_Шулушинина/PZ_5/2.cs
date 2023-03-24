using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5_2
{
    interface IHello
    {
        void SayHello();
    }
    class Russian: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Привет");
        }
    }
    class English: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
    class Deutsch: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Salve");
        }
    }
    class French: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Salut");
        }
    }
    class Latin: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Salam);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IHello> greetings = new List<IHello>();
            greetings.Add(new Russian());
            greetings.Add(new English());
            greetings.Add(new Latin());
            greetings.Add(new French());
            greetings.Add(new Latin());
            foreach (IHello hello in greetings)
            {
                hello.SayHello();
            }
            Console.ReadKey(true);
        }
    }
}