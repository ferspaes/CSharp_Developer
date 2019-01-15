using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_2A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] familias = new string[3][];

            familias[0] = new string[] { "Wilma", "Fred", "Dinossauro" };
            familias[1] = new string[] { "Bart", "Lisa", "Hommer", "Maggie", "Margie" };
            familias[2] = new string[] { "Dona Florinda", "Kiko"};

            foreach (var familia in familias)
            {
                Console.WriteLine(string.Join(", ", familia));
            }

            Console.Read();
            ArraysMultidimensionais();
        }

        private static void ArraysMultidimensionais()
        {
            string[,] copas = new string[4, 3];

            copas[0, 0] = "Time 1";
            copas[1, 0] = "Time 2";
            copas[2, 0] = "Time 3";
            copas[3, 0] = "Time 4";

            copas[0, 1] = "Time 1";
            copas[1, 1] = "Time 2";
            copas[2, 1] = "Time 3";
            copas[3, 1] = "Time 4";

            copas[0, 2] = "Time 1";
            copas[1, 2] = "Time 2";
            copas[2, 2] = "Time 3";
            copas[3, 2] = "Time 4";


            for (int ano = 0; ano <= copas.GetUpperBound(1); ano++)
            {
                int versao = 2006 + ano * 4;
                Console.Write(versao.ToString().PadRight(12));
            }

            Console.WriteLine();

            for (int linha = 0; linha <= copas.GetUpperBound(0); linha++)
            {
                Console.WriteLine();
                for (int coluna = 0; coluna < copas.GetUpperBound(0); coluna++)
                {
                    Console.Write(copas[linha, coluna].ToString().PadRight(12));
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            char[,] tabuleiro = new char[3, 3];
            tabuleiro[0, 0] = 'X';
            tabuleiro[1, 0] = '.';
            tabuleiro[2, 0] = 'O';
            tabuleiro[0, 1] = 'X';
            tabuleiro[1, 1] = 'X';
            tabuleiro[2, 1] = 'O';
            tabuleiro[0, 2] = '.';
            tabuleiro[1, 2] = 'O';
            tabuleiro[2, 2] = 'X';

            for (var y = 0; y < 3; y++)
            {
                for (var x = 0; x < 3; x++)
                {
                    Console.Write(tabuleiro[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}
