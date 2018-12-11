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
    class Program : Object
    {
        protected Program() { }

        static void Main(string[] args)
        {
            Cliente cliente_1 = new Cliente();
            cliente_1.Nome = "Nome teste";
            cliente_1.CPF = "123.456.789-00";
            cliente_1.Profissao = "Designer";

            Cliente cliente_2 = new Cliente();
            cliente_2.Nome = "Nome teste";
            cliente_2.CPF = "123.456.789-00";
            cliente_2.Profissao = "Designer";

            ContaCorrente conta2 = new ContaCorrente(123456, 123);


            if (cliente_1 == cliente_2)
                Console.WriteLine("== é igual!");
            else
                Console.WriteLine("== não é igual!");

            if (cliente_1.Equals(cliente_2))
                Console.WriteLine("Equals é igual!");
            else
                Console.WriteLine("Equals não é igual!");

            if (cliente_1.Equals(conta2))
                Console.WriteLine("Cliente equals Conta");
            else
                Console.WriteLine("Cliente não é equals Conta");

            Console.Read();

            object conta = new ContaCorrente(123456, 123);
            string contaToString = conta.ToString();
            Console.WriteLine(contaToString);
            Console.Read();
        }

        public static void TestarString()
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
