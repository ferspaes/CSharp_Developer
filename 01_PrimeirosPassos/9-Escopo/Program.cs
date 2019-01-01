using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 9 - Escopo");

            int idadeJoao = 18;
            bool acompanhado = true;
            string mensgemAdicional;

            if (acompanhado)
            {
                mensgemAdicional = "João está acompanhado";
            }
            else
            {
                mensgemAdicional = "João não está acompanhado";
            }

            if (idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("João pode entrar.");
                Console.WriteLine(mensgemAdicional);
            }
            else
            {
                Console.WriteLine("João não possui mais de 18 anos, não pode entrar.");

            }

            Console.WriteLine("A execução terminou pressione enter para finalizar...");
            Console.ReadLine();
        }
    }
}
