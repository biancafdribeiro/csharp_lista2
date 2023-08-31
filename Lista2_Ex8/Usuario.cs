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
        public static string Nome { get; set; } //por serem estáticos, são propriedades de instância da classe;
                                                //eles pertencem à classe e podem ser acessados usando apenas
                                                //o nome dela (Usuario)

        public static int ProximaMatricula { get; set; }

    }
}
