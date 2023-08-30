using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //posso chamar os métodos estáticos sem precisar criar objetos 

            //exercício 1
            Console.WriteLine("Digite um valor para 'a':");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para 'b':");
            int b = int.Parse(Console.ReadLine());

            int resultadosoma = Calculadora.Somar(a, b);
            Console.WriteLine("O resultado da soma é: {0}", resultadosoma);

            Console.WriteLine("__________________________________________");

            //exercício 2
            Console.WriteLine("Digite a temperatura em Celsius:");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = Conversor.CelsiusParaFahrenheit(celsius);
            Console.WriteLine("A temperatura em Fahrenheit é {0}", fahrenheit);

            Console.WriteLine("__________________________________________");

            //exercício 3
            Console.WriteLine("Digite o valor de 'x':");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de 'n':");
            int n = int.Parse(Console.ReadLine());

            double Potencia = Matematica.Potencia(x, n); //precisa ser double por causa do Math.Pow
            Console.WriteLine("O valor de x é {0}", Potencia);

            Console.WriteLine("__________________________________________");

            //exercício 4
            Console.WriteLine("Digite uma string:");
            string input = Console.ReadLine();

            string reversed = StringUtils.InverterString(input);
            Console.WriteLine("A string invertida é {0}", reversed);

            string str = Console.ReadLine();
            StringUtils.Palindromo(input);

            Console.ReadKey();
        }
    }
}
