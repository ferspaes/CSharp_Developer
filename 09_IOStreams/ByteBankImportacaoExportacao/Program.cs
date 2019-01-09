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
            string msg = $"Hoje é dia {DateTime.Now.ToString("dd/MM/yyyy")}. \n Agora sâo {DateTime.Now.ToString("hh:mm:ss")} horas.";
            File.WriteAllText(DateTime.Now.ToString("hhMMss") + "_file.txt", msg);

            LeitorDaConsole();

            string pathB = EscritorBinaryWriter();
            LeitorBinaryReader(pathB);

            Console.Read();

            string path = CriadorCSV();
            Console.WriteLine($"Arquivo: {path}");
            LeitorCSV(path);
            Console.ReadLine();
        }
    }
}
