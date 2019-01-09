using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "1 - Introdução";
            string aulaArrays = "2 - Arrays";
            string aulaColecoes = "3 - Aula sobre Coleções";

            string[] aulas = new string[]
            {
                aulaIntro,
                aulaArrays,
                aulaColecoes
            };

            EscreverArray(aulas);

            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia, 0, 2);
            Console.WriteLine("\n-= Copia =-");
            EscreverArray(copia);

            string[] clone = aulas.Clone() as string[];
            Console.WriteLine("\n-= Clone =-");
            EscreverArray(clone);

            Array.Sort(aulas);
            Console.WriteLine("\n-= Sort =-");
            EscreverArray(aulas);

            Console.WriteLine("\n-= Resize =-");
            Array.Resize(ref aulas, 2);
            EscreverArray(aulas);
            Array.Resize(ref aulas, 3);
            EscreverArray(aulas);

            aulas[aulas.Length - 1] = aulaColecoes;
            EscreverArray(aulas);

            Console.Read();
        }

        private static void EscreverArray(string[] aulas)
        {
            Console.WriteLine("\nforeach...");
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }

            Console.WriteLine("\nfor...");
            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
        }
    }
}
