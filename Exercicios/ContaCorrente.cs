using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class ContaCorrente : ContaGenerica
    {
        protected int Limite { get; set; }

        public ContaCorrente(string banco, int conta, int saldo, int limite, int deposito, int saque)
        {
            Banco = banco;
            Conta = conta;
            Saldo = saldo;
            Limite = limite;
            Deposito = deposito;
            Saque = saque;
        }

        public void MinhaConta()
        {
            Console.WriteLine($"- Banco: {Banco}");
            Console.WriteLine($"- Conta: {Conta}");
            Console.WriteLine($"- Saldo: {Saldo}");
            Console.WriteLine($"- Limite: {Limite}");
        }

        public void Depositar()
        {
            Console.WriteLine($"Você fez um deposito de:{Deposito}");
            Saldo += Deposito;
            Console.WriteLine($"Seu saldo agora é de:{Saldo}");
        }

        public void Sacar()
        {
            if (Saque > Limite || Saldo < Limite)
            {
                Console.WriteLine($"Saque negado!");
                Console.WriteLine($"Seu limite é de: {Limite}");
                Console.WriteLine($"Sua tentativa de saque foi de: {Saque}");
                Console.WriteLine($"Seu saldo é de: {Saldo}");

            }
            else
            {
                Console.WriteLine($"Você fez um saque de:{Saque}");
                Saldo -= Saque;
                Console.WriteLine($"Seu saldo agora é de:{Saldo}");
            }
        }
    }
}
