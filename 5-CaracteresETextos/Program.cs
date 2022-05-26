using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5: Caracteres e Textos");

            char primeiraLetra = ' '; //char é só com aspas normais
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char) (primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de Tecnologia " + 2020;
            string cursosProgramacao = //o @ utilizado antes das aspas é para o C# reconhecer tudo até a proximas " como um texto da mesma string
@"- .NET 
- Java
- Javascript"; 
            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);  

            Console.ReadLine();
        }
    }
}
