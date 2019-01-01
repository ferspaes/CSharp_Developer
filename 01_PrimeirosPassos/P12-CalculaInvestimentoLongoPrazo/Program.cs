using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12 - Calcula Investimento a Longo Prazo");
            double valorInvestido = 1000000;
            double fatorRendimento = 1.0036;
            int ano = 5;
            int mes = 12;

            for (int contadorAno = 1; contadorAno <= ano; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= mes; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                    Console.WriteLine($"No {contadorMes}º mês do {contadorAno}º ano, o valor investido rendeu R$" + System.Math.Round(valorInvestido, 2));
                }
                Console.WriteLine($"Fator de Rendimento de seu investimento no {contadorAno}º ano foi de {fatorRendimento}% ao mês, e o valor acumulado foi de R$" + System.Math.Round(valorInvestido, 2));
                fatorRendimento += 0.0010;
            }

            Console.WriteLine($"Ao termino do investimento ao longo de {ano} anos, você terá o valor de R$" + System.Math.Round(valorInvestido, 2));

            Console.WriteLine("Execução terminou, pressione a tecla enter para fechar...");
            Console.ReadLine();
        }
    }
}
