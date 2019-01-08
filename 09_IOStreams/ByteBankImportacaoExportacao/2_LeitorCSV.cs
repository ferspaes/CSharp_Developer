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
        void LeitorCSV()
        {
            string path = "contas.csv";

            using (var fs = new FileStream(path, FileMode.Open))
            using (var leitor = new StreamReader(fs))
            {
                var linha = leitor.ReadLine();
                var conta = ConversorLinhaEmContaCorrente(linha);
                string msg = $"Nome: {conta.Titular.Nome}. Agência: {conta.Agencia}. Número: {conta.Numero}. Saldo: ${conta.Saldo}";
                Console.WriteLine(msg);
            }
        }
    }
}