using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTIposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario;
            salario = 1200.50;
            
            int SalarioEmInteiro; // 16 bits
            SalarioEmInteiro = (int)salario; //daria erro se não forçasse a conversão para int

            Console.WriteLine(SalarioEmInteiro);

            long idade; // 64 bits
            idade = 130000000000000;
            Console.WriteLine(idade);

            short quantidadeProdutos; // 16 bits
            quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f; // o f é obrigatório para colocar no final de um número usando um float
            // o float aceita menos casas que o double depois da vírgula
            Console.WriteLine(altura);


            Console.ReadLine();
        }
    }
}
