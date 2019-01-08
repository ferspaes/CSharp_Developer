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
        static void Main(string[] args)
        {
            string path = CriadorCSV();
            Console.WriteLine($"Arquivo: {path}");
            LeitorCSV(path);
            Console.ReadLine();
        }
    }
}
