using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);
            contaDoBruno.Sacar(50); //50 é o valor que será sacado
            Console.WriteLine(contaDoBruno.saldo);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            contaDoBruno.Transferir(200, contaDaGabriela);
            Console.WriteLine($"Bruno transferiu 200 reais para Gabriela");
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            contaDaGabriela.Transferir(100, contaDoBruno);
            Console.WriteLine($"Gabriela transferiu 100 reais para Bruno");
            Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);
            Console.WriteLine("Saldo da Bruno: " + contaDoBruno.saldo);

            Console.ReadLine();
        }
    }
}
