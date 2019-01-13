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
            Curso curso = new Curso("C# Collections", "Professor Rafael");
            Aluno a1 = new Aluno("Fabiana", 123456);
            Aluno a2 = new Aluno("Marcelo", 641651);
            Aluno a3 = new Aluno("Henrique", 415415);
            Aluno a4 = new Aluno("Ana", 652646);
            Aluno a5 = new Aluno("Rodrigo", 618454);
            Aluno a6 = new Aluno("Fernando", 165441);

            curso.Matricular(a1);
            curso.Matricular(a2);
            curso.Matricular(a3);
            curso.Matricular(a4);
            curso.Matricular(a5);
            curso.Matricular(a6);

            Aluno alunoTeste = new Aluno("Teste", 123456);
            Console.WriteLine(alunoTeste.Equals(a1) ? "\nÉ igual.\n" : "\nNão é igual.\n");

            Console.WriteLine(curso.EstaMatriculado(a1) ? "\nSim.\n" : "\nNão.\n");
            Console.WriteLine(curso.EstaMatriculado(alunoTeste) ? "\nSim.\n" : "\nNão.\n");

            var retorno = curso.BuscarMatricula(123456);
            string msg = retorno != null ? $"Aluno: {retorno.ToString()}.\n" : $"Não foi encontrado aluno com a matrícula digitada.\n";
            Console.WriteLine(msg);

            retorno = curso.BuscarMatricula(18465);
            msg = retorno != null ? $"Aluno: {retorno.ToString()}.\n" : $"Não foi encontrado aluno com a matrícula digitada.\n";
            Console.WriteLine(msg);

            Console.Read();

            foreach (var aluno in curso.Alunos)
            {
                Console.WriteLine(aluno);
            }

            AulaDeSets();
            AulaCompletaListas();
            AulasListArrayOld();
        }

        private static void AulaDeSets()
        {
            ISet<string> alunos = new HashSet<string>();

            alunos.Add("Amanda");
            alunos.Add("Fernando");
            alunos.Add("Rodrigo");
            alunos.Add("Mariana");
            alunos.Add("Fabio");
            Console.WriteLine(string.Join(", ", alunos));

            // Removendo e adicionando novos valores 
            alunos.Add("Roselyn");
            alunos.Remove("Mariana");
            alunos.Add("Ana");
            Console.WriteLine("\n -= Removendo Mariana e adicionando Ana e Roselyn =-");
            Console.WriteLine(string.Join(", ", alunos));

            // Adicionando valores iguais
            alunos.Add("Fabio");
            alunos.Add("Rodrigo");
            Console.WriteLine("\n -= Adicionando valores iguais =-");
            Console.WriteLine(string.Join(", ", alunos));

            // Copiando para uma lista para poder usar Sort()
            List<string> alunosCopia = new List<string>(alunos);
            alunosCopia.Sort();
            Console.WriteLine("\n -= Imprimindo copia do tipo List<string>(); =-");
            Console.WriteLine(string.Join(", ", alunosCopia));

            // Imprimindo
            Console.WriteLine("\n -= Impressão dos valores após todas as manipulações. =-");
            Console.WriteLine(string.Join(", ", alunos));
        }

        private static void AulaCompletaListas()
        {
            Curso cursoCollections = new Curso("C# - Collections", "Nome do Instrutor");
            cursoCollections.AdicionarAula(new Aula("Trabalhando com Collections", 20));

            //Adicionar Mais Duas Aulas
            cursoCollections.AdicionarAula(new Aula("Operações com Collections", 15));
            cursoCollections.AdicionarAula(new Aula("Conclusão Listas", 36));

            // Imprimir Lista
            ImprimirLista(cursoCollections);

            // Copiar Lista
            List<Aula> aulasCopia = new List<Aula>(cursoCollections.Aulas);

            // Ordenar Lista
            aulasCopia.Sort();

            // Imprimir Curso
            Console.WriteLine(cursoCollections.ToString());
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
