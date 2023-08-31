using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_Ex7
{
    public class Pessoa
    {
        public static int TotalPessoas { get; private set; } //evita que a propriedade seja mudada
        public static int SomarPessoas()
        {
            TotalPessoas++;
            return TotalPessoas;
        }
    }
}