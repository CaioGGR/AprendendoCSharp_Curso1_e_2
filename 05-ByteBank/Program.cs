using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
     class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();

            gabriela.nome = "Gabriela";
            gabriela.profissao = "Desenvolvedora C#";
            gabriela.cpf = "152.560.237-47";

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = gabriela;
            contaDaGabriela.saldo = 500;
            contaDaGabriela.agencia = 563;
            contaDaGabriela.numero = 5634527;

            contaDaGabriela.titular.nome = "Gabriela Costa";

            Console.WriteLine(gabriela.nome);
            Console.WriteLine(contaDaGabriela.titular.nome);

            Console.ReadLine();
        }
    }
}
