using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PZ5_1
{
    interface IAnimal
    {
        void Voice();
    }
    class Dog: IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("√ав!");
        }
    }
    class Cat: IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("ћ€у!");
        }
    }
    class Owl: IAnimal
    {
        private int GetCurrentTime()
        {
            return Convert.ToInt32(File.ReadAllText("current_time.txt"));
        }
        public void Voice()
        {
            int currentTime = GetCurrentTime();
            if ((currentTime >= 8) && (currentTime <= 21))
            {
                Console.WriteLine("“ише, € спю!");
            }
            else
            {
                Console.WriteLine("”х! ”х! ”х!");
            }
        }
    }
    class Mouse: IAnimal
    {
        public void Voice()
        {
            Console.WriteLine(" р€-кр€");
        }
    }
    class Horse : IAnimal
    {
        public void Voice()
        {
            bool animalIsFree = true;
            if (animalIsFree)
            {
                Console.WriteLine(" ва-ква");
            }
            else
            {
                Console.WriteLine("я не подойду к тебе!");
            }
        }
    }
    internal class Program
    {
        static void PetAnimal(IAnimal animal)
        {
            Console.WriteLine("ћы гладим зверюшку, а она нам говорит:");
            animal.Voice();
        }
        static void Main(string[] args)
        {
            List<IAnimal> myAnimals = new List<IAnimal>();
            myAnimals.Add(new Dog());
            myAnimals.Add(new Cat());
            myAnimals.Add(new Owl());
            myAnimals.Add(new Mouse());
            myAnimals.Add(new Horse());
            foreach (IAnimal animal in myAnimals)
            {
                PetAnimal(animal);
            }
            Console.ReadKey(true);
        }
    }
}
