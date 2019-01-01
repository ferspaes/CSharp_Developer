using ByteBank.Modelos;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROJETO FINALIZADO TUDO OK!");

            DateTime dataFimPagamento = new DateTime(2018, 10, 17);
            DateTime dataCorrente = DateTime.Now;
            TimeSpan dataDiferenca = TimeSpan.FromMinutes(40);
            TimeSpan dataDiferenca2 = dataCorrente - dataFimPagamento;

            string mensagem = TimeSpanHumanizeExtensions.Humanize(dataDiferenca);
            string mensagem2 = TimeSpanHumanizeExtensions.Humanize(dataDiferenca2);

            ContaCorrente conta = new ContaCorrente(123, 123456);
            Console.WriteLine(dataFimPagamento);
            Console.WriteLine(dataCorrente);
            Console.WriteLine($"A diferenca de datas da diferença 1 é de: {mensagem}");
            Console.WriteLine($"A diferenca de datas da diferença 2 é de: {mensagem2}");
            Console.WriteLine(conta.NumeroDaConta);
            Console.ReadLine();
        }
    }
}
