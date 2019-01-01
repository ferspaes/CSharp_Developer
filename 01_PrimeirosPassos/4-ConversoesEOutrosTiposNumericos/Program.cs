using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            //o int é uma variável que suporta valores até 32bits
            int salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            // o long é uma variável de 64bits
            long idade = 13000000000000;
            Console.WriteLine(idade);

            //o short é uma vcariável de 16bits
            short quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.WriteLine("Execução encerrada pressione enter para finalizar");
            Console.ReadLine();
        }
    }
}
