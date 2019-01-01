using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11 - Calcula Poupança 2");

            int mes = 12;
            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= mes; contadorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine($"Após {contadorMes} mes(es) o seu investimento renderá o valor de R$" + System.Math.Round(valorInvestido, 2));
            }

            Console.WriteLine("Execução terminou, pressione a tecla enter para finalizar...");
            Console.ReadLine();
        }
    }
}
