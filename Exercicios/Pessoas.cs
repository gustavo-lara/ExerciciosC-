using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Pessoas
     {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Envelhecer()
        //O método tipo void são aquelas q fazem uma ação porém não apresenta retorno na mesma
        //Só consegue declarar um método dentro de uma classe, ela só funciona se "chamarmos ela" (funcionarios3.Envelhecer();)
        {
            Idade += 1;
        }
    }

}
