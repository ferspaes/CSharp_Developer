using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 5 - Caracteres e Textos");

            //character
            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de Tecnologia " + 2020;
            Console.WriteLine(titulo);

            string cursosProgramacao = 
 @" - .Net
 - Java
 - JavaScript";
            Console.WriteLine(cursosProgramacao);

            Console.WriteLine("Execução encerrada pressione enter para finalizar...");
            Console.ReadLine();
        }
    }
}
