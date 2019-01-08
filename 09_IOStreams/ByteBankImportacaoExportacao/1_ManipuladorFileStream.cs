using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        void ManipuladorFileStream()
        {
            string pathExercicio = "teste.txt";
            string pathTXT = "contas.txt";
            var buffer = new byte[1024];
            var fluxoArquivo = new FileStream(pathTXT, FileMode.Open); // FileStream(pathTXT, FileMode)3);
            var encoding = Encoding.Default;

            using (var fsExercicio = new FileStream(pathExercicio, FileMode.Open))
            {
                int contadorLeitura = -1;

                while (contadorLeitura != 0)
                {
                    contadorLeitura = fsExercicio.Read(buffer, 0, buffer.Length);
                    string conteudoArquivo = encoding.GetString(buffer, 0, contadorLeitura);

                    if (!string.IsNullOrWhiteSpace(conteudoArquivo))
                    {
                        Console.WriteLine(conteudoArquivo);
                        Console.WriteLine("Leu!!!");
                    }
                }
            }

            Console.ReadLine();
        }

        static void EscreverBuffer(byte[] buffer)
        {
            foreach (var meuByte in buffer)
            {
                Console.Write(meuByte);
                Console.Write("");
            }
        }

        public static ContaCorrente ConversorLinhaEmContaCorrente(string linha)
        {
            var valores = linha.Split(' ');
            var agencia = int.Parse(valores[0]);
            var numeroConta = int.Parse(valores[1]);
            var saldo = double.Parse(valores[2]/*.Replace('.', ',')*/);
            var cliente = new Cliente();
            var conta = new ContaCorrente(agencia, numeroConta);
            string nome = valores[3];

            cliente.Nome = nome;
            conta.Depositar(saldo);
            conta.Titular = cliente;

            return conta;
        }

        void LendoArquivoTXT()
        {
            string pathArquivo = "teste.txt";
            using (var fs = new FileStream(pathArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fs))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    var conta = ConversorLinhaEmContaCorrente(linha);
                    string msg = $"Agência: {conta.Agencia}. Número: {conta.Numero}. Saldo: ${conta.Saldo}";
                    Console.WriteLine(msg);
                }
            }
        }
    }
}