using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        protected Program() { }

        static void Main(string[] args)
        {

            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string testePadrao = "Olá meu telefone é 99156-7468.";
            Console.WriteLine(Regex.IsMatch(testePadrao, padrao));
            Match resultado = Regex.Match(testePadrao, padrao);
            Console.WriteLine(resultado.Value);

            Console.ReadLine();


            string urlParametros = "http://www.bytebank.com/pagina?moedaOrigem=Real&moedaDestino=Dollar";
            ExtratorValorArgumentosURL extratorValor = new ExtratorValorArgumentosURL(urlParametros);
            string valor = extratorValor.GetValor("MOEDADESTINO");

            if (valor.ToUpper().Contains("DOLLAR"))
                Console.WriteLine(valor.ToUpper().StartsWith("DOL") && valor.ToUpper().EndsWith("LAR"));

            Console.WriteLine("Valor de Moeda Destino = " + valor);

            Console.Read();



            bool testarHumanizer = false;
            if (testarHumanizer)
                UtilizandoHumanizer();
        }

        private static void UtilizandoHumanizer()
        {
            DateTime dataFimPagamento = new DateTime(2018, 6, 20);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = TimeSpan.FromMinutes(40); //dataFimPagamento - dataCorrente;

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(mensagem);

            Console.ReadLine();
        }
    }
}
