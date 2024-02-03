using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Velocidade { get; set; }
        public int VelocidadeMod {  get; set; }


        public void Acelerar()
        {
            Velocidade += 100;
        }

        public void Desacelerar()
        {
            Velocidade -= 30;

            if(Velocidade <= 0) { Velocidade = 0; }
        }
    }
}
