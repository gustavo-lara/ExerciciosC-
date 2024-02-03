using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class People
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        //Método construtor padrão 
        public People()
        {}

        //Método construtor com parâmetros

        public People(string n, int i)
        {
            Nome = n;
            Idade = i;
        }
    }
}
