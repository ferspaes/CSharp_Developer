using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathTXT = "contas.txt";

            var buffer = new byte[1024];

            var fluxoArquivo = new FileStream(pathTXT, FileMode.Open); // FileStream(pathTXT, FileMode)3);

            int contadorLeitura = -1;

            while (contadorLeitura != 0)
            {
                contadorLeitura = fluxoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);
                Console.WriteLine();
                Console.WriteLine("Leu!!!");
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
    }
}
