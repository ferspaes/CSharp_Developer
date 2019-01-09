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
        static void LeitorDaConsole()
        {
            using (var fsConsole = Console.OpenStandardInput())
            using (var fs = new FileStream(DateTime.Now.ToString("hhMMss") + "_streamConsole.txt", FileMode.CreateNew))
            {
                var buffer = new byte[1024];
                int max = 6;
                int indice = 0;
                while (indice < max)
                {
                    var bytesLidos = fsConsole.Read(buffer, 0, buffer.Length);
                    fs.Write(buffer, 0, bytesLidos);
                    fs.Flush();
                    Console.WriteLine($"Bytes Lidos: {bytesLidos}");
                    indice++;
                }
            }
        }
    }
}