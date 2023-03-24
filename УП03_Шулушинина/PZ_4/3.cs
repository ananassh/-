using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4_3
{
    class Orc
    {
        private static int Counter;
        public static int amountGoldAll
        {
            get;
            private set;
        }
        public int amountGold
        {
            get;
            private set;
        }
        public Orc()
        {
            Counter++;
            amountGoldAll += 2;
            if (Counter > 5)
            {
                amountGold += 2;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Orc orc_1 = new Orc();
            Console.WriteLine(Orc.amountGoldAll);
            Orc orc_2 = new Orc();
            Orc orc_3 = new Orc();
            Console.WriteLine(Orc.amountGoldAll);
            Orc orc_4 = new Orc();
            Orc orc_5 = new Orc();
            Orc orc_6 = new Orc();
            Console.WriteLine(orc_6.amountGold);
            Console.ReadKey(true);
        }
    }
}