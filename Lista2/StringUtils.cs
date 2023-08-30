using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    public static class StringUtils
    {
        public static string InverterString(string str)
        {
            char[] charArray = str.ToCharArray(); //convertendo a string em um array para depois inverter
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static void Palindromo(string str)
        {
            string reversedStr = InverterString(str);

            if (str == reversedStr)
            {
                Console.WriteLine("É um palíndromo!");
            }
            else
            {
                Console.WriteLine("Não é um palíndromo!");
            }
        }
    }
}
