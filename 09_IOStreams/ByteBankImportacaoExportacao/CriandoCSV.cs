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
        static string CriadorCSV()
        {
            string path = DateTime.Now.ToString("HHmmss") + "_Conta.csv";

            using (var fs = new FileStream(path, FileMode.CreateNew))
            using (var escritor = new StreamWriter(fs))
            {
                for (int i = 0; i < 100; i++)
                {
                    escritor.Write("123,38742,1234.40,Fulano Teste");
                    escritor.Flush();  // <== Escreve imediatamente!!
                    Console.WriteLine($"Linha{i} foi escrita!");
                }
            }
            return path;
        }
    }
}