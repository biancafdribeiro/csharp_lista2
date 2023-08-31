using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /* Construa uma classe parcial chamada Usuario em C# com duas partes. A primeira
    parte contém um atributo estático chamado ProximaMatricula que guarda o
    próximo número de matrícula a ser atribuído a um novo usuário. A segunda parte
    contém um construtor que recebe o nome do usuário como parâmetro e atribui a
    ele o número de matrícula gerado a partir do atributo ProximaMatricula.*/


namespace Lista2_Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario1 = new Usuario("Bianca"); //acessando a classe; está passando argumentos pois não usa valores padrão
            Console.WriteLine("Nome do usuário: " + Usuario.Nome);
            Console.WriteLine("A matrícula do usuário é: " + Usuario.ProximaMatricula);

            Usuario usuario2 = new Usuario("Nathália");
            Console.WriteLine("Nome do usuário: " + Usuario.Nome);
            Console.WriteLine("A matrícula do usuário é: " + Usuario.ProximaMatricula);

            Console.ReadKey();
        }
    }
}
