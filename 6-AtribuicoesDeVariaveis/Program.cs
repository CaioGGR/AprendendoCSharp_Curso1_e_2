using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 6");

            int idade = 32;
            int idadeGustavo = idade;

            idade = 20;
            //veja que mesmo após atribuir o valor 20 novamente para a variavel idade, a idadeGustavo não mudou junto, pois elas não têm conexão só foi copiada o valor uma vez

            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);

            Console.ReadLine();
        }
    }
}
