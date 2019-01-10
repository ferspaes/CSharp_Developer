using Collections.Model;
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
            Curso cursoCollections = new Curso("C# - Collections", "Nome do Instrutor");
            cursoCollections.AdicionarAula(new Aula("Trabalhando com Collections", 20));

            ImprimirLista(cursoCollections);

            Console.Read();
            AulasListArrayOld();
        }

        private static void ImprimirLista(Curso cursoCollections)
        {
            foreach (var aula in cursoCollections.Aulas)
            {
                Console.WriteLine(aula);
            }
        }

        private static void AulasListArrayOld()
        {
            var aulaIntro = new Aula("1 - Introdução", 20);
            var aulaArrays = new Aula("2 - Arrays", 15);
            var aulaColecoes = new Aula("3 - Aula sobre Coleções", 18);

            List<Aula> aulas = new List<Aula>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaArrays);
            aulas.Add(aulaColecoes);

            aulas.ForEach(aula =>
            {
                Console.WriteLine(aula.ToString());
            });

            aulas.Sort();
            aulas.ForEach(aula => Console.WriteLine(aula.ToString()));

            aulas.Sort((aulaX, aulaY) => aulaX.Tempo.CompareTo(aulaY.Tempo));
            aulas.ForEach(aula => Console.WriteLine(aula.ToString()));

            string aulaIntroOld = "1 - Introdução";
            string aulaArraysOld = "2 - Arrays";
            string aulaColecoesOld = "3 - Aula sobre Coleções";

            TrabalhandoComListas(aulaIntroOld, aulaArraysOld, aulaColecoesOld);
            TrabalhandoComArrays(aulaIntroOld, aulaArraysOld, aulaColecoesOld);
        }

        #region Aulas Anteriores
        private static void TrabalhandoComListas(string aulaIntro, string aulaArrays, string aulaColecoes)
        {
            List<string> aulasLista = new List<string>()
            {
                aulaIntro,
                aulaArrays,
                aulaColecoes
            };

            List<string> aulas = new List<string>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaArrays);
            aulas.Add(aulaColecoes);

            // -= ESCREVER LISTA COM List.ForEach(_=>_code...);
            aulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });

            aulas.Sort();
            aulas.RemoveAt(2);
            aulas.Add(aulaIntro);
            aulas[2] = "3 - Conclusão";

            aulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });
        }

        private static void TrabalhandoComArrays(string aulaIntro, string aulaArrays, string aulaColecoes)
        {
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
        #endregion // Aulas Anteriores
    }
}
