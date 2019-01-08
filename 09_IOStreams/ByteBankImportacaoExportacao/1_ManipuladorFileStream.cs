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
    }
}