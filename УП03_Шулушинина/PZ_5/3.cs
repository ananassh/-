using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5_3
{
    interface IFilter
    {
        string Execute(string textLine);
    }
    class DigitFilter: IFilter
    {
        public string Execute(string textline)
        {
            string str = "";
            char[] symbols = {' ', ',', ':', ';', '-', '"', '(', ')', '.', '!', '?'};
            for (int i = 0; i < textline.Length; i++)
            {
                if (char.IsLetter(textline[i]) || Array.IndexOf(symbols, textline[i]) >= 0)
                {
                    str += textline[i];
                }
            }
            return str;
        }
    }
    class LetterFilter: IFilter
    {
        public string Execute(string textline)
        {
            string str = "";
            for (int i = 0; i < textline.Length; i++)
            {
                if (char.IsDigit(textline[i]))
                {
                    str += textline[i];
                }
            }
            return str;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DigitFilter stringLetters = new DigitFilter();
            Console.WriteLine(stringLetters.Execute("� ������ ��� � ������ �� �������895632."));
            LetterFilter stringDigits = new LetterFilter();
            Console.WriteLine(stringDigits.Execute("� 7�����5� 9���4 � ���7��� ��4 ��3���7��"));
            Console.ReadKey(true);
        }
    }
}