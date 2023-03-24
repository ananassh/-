using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2_3
{
    internal class Program
    {
        class CaesarCipher
        {
            private string strCipher;
            private int shift;
            public string GetCipher()
            {
                return strCipher;
            }
            public void SetCipher(string code, int shift)
            {
                this.strCipher = EncryptStr(code, shift);
                this.shift = shift;
            }
            private string EncryptStr(string code, int shift)
            {
                char[] alphabet = { 'а', 'б', 'в', 'г', 'д', 'е', 'Є', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', '€' };
                char l;
                int index;
                string stringCipher = "";
                for (int i = 0; i < code.Length; i++)
                {
                    
                    l = code[i];
                    if (l == ' ')
                    {
                        stringCipher += l;
                        continue;
                    }
                    index = Array.IndexOf(alphabet, l);
                    index += shift;
                    if (index > 32)
                    {
                        index -= 33;
                    } else if (index < 0)
                    {
                        index += 33;
                    }
                    stringCipher += alphabet[index];
                }
                return stringCipher;
            }
        }
        static void Main(string[] args)
        {
            CaesarCipher myCipher = new CaesarCipher();
            myCipher.SetCipher("Ѕлудлив как кот, труслив как за€ц", 21);
            Console.WriteLine(myCipher.GetCipher());
            myCipher.SetCipher("г м€еац мбрпшлб, б епнб шжсу", 1);
            Console.WriteLine(myCipher.GetCipher());
            Console.ReadKey(true);
        }
    }
}