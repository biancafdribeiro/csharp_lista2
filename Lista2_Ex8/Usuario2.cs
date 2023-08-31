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
    partial class Usuario
    {
        public Usuario(string nome) //construtor (depois da classe, não tem retorno explícito,
                                    //mesmo nome da classe e pode ter parâmetros). nesse caso está
                                    //passando apenas o nome como parâmetro como diz o exercício 
        {
            Nome = nome;
            ProximaMatricula++;
        }
    }
}
