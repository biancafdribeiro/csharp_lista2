using Lista2_Ex7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Construa uma classe chamada Pessoa em C# com uma propriedade estática chamada TotalPessoas 
 que guarda o número total de instâncias da classe criadas. O valor de TotalPessoas deve ser 
 atualizado sempre que uma nova instância de Pessoa for criada.*/

namespace Lista2_Ex7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pessoa.SomarPessoas();
            Pessoa.SomarPessoas(); //chamando 2 vezes

            Console.WriteLine("O valor atual é {0}", Pessoa.TotalPessoas);
            Console.ReadKey();
        }
    }
}
