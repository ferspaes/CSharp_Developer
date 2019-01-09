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

        static string EscritorBinaryWriter()
        {
            string path = DateTime.Now.ToString("hhMMss") + "_contaBinaria.csv";

            using (var fs = new FileStream(path, FileMode.CreateNew))
            using (var bw = new BinaryWriter(fs))
            {
                bw.Write(1234);
                bw.Write(7638127);
                bw.Write("Texto Teste");
            }

            return path;
        }

        static void LeitorBinaryReader(string path)
        {
            using (var fs = new FileStream(path, FileMode.Open))
            using (var br = new BinaryReader(fs))
            {
                int agencia = br.ReadInt32();
                int conta = br.ReadInt32();
                string nome = br.ReadString();

                Console.WriteLine($"Nome: {nome}, Agência: {agencia}, Conta: {conta}");
            }

        }
    }
}