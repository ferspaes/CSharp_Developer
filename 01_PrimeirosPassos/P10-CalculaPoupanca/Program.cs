using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula Poupança");

            double valorInvestido = 1000;
            int mes = 12;
            int contadorMes = 1;

            while (contadorMes <= mes)
            {
                valorInvestido += valorInvestido * 0.0036;
                Console.WriteLine($"Após {contadorMes} meses você terá o valor de R${valorInvestido}");
                contadorMes++;
            }

            valorInvestido = 1000;
            valorInvestido = valorInvestido + valorInvestido * 0.0036;
            Console.WriteLine("Após 1 mês, você tera R$" + valorInvestido);

            valorInvestido = valorInvestido + valorInvestido * 0.0039;
            Console.WriteLine("Após 2 meses, você tera R$" + valorInvestido);


            Console.WriteLine("Execução acabou, pressione a tecla enter para finalizar...");
            Console.ReadLine();
        }
    }
}
