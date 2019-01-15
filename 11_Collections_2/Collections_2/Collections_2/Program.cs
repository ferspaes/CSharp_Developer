using Collections_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, Aluno> alunos = new SortedDictionary<string, Aluno>();
            alunos.Add("AK", new Aluno("Amanda", 4738942));
            alunos.Add("GL", new Aluno("Guilherme", 5437389));
            alunos.Add("AP", new Aluno("Ana", 34783128));
            alunos.Add("VA", new Aluno("Vanessa", 473283929));
            alunos.Add("RL", new Aluno("Rafael", 327489));
            alunos.Add("AL", new Aluno("Ana", 43268179));
            alunos.Add("WM", new Aluno("Wanderson", 394728724));

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine();

            IDictionary<string, Aluno> alunosSL = new SortedList<string, Aluno>();
            alunosSL.Add("AK", new Aluno("Amanda", 4738942));
            alunosSL.Add("GL", new Aluno("Guilherme", 5437389));
            alunosSL.Add("AP", new Aluno("Ana", 34783128));
            alunosSL.Add("VA", new Aluno("Vanessa", 473283929));
            alunosSL.Add("RL", new Aluno("Rafael", 327489));
            alunosSL.Add("AL", new Aluno("Ana", 43268179));
            alunosSL.Add("WM", new Aluno("Wanderson", 394728724));

            foreach (var aluno in alunosSL)
            {
                Console.WriteLine(aluno);
            }


            ISet<string> colecao = new SortedSet<string>(new Comparador());

            ISet<string> outroConjunto = new HashSet<string>();

            //este conjunto é subconjunto de outro? IsSubsetOf
            colecao.IsSubsetOf(outroConjunto);

            //este conjunto é superconjunto de outro? IsSupersetOf
            colecao.IsSupersetOf(outroConjunto);

            //os conjuntos contêm os mesmo elementos? SetEquals
            colecao.SetEquals(outroConjunto);

            //subtrai os elementos da outra coleção que também estão nesse? ExceptWith
            colecao.ExceptWith(outroConjunto);

            //intersecção dos conjuntos - IntersectWith
            colecao.IntersectWith(outroConjunto);

            //somente em um ou outro conjunto - SymmetricExceptWith
            colecao.SymmetricExceptWith(outroConjunto;

            //união de conjuntos - UnionWith
            colecao.UnionWith(outroConjunto);

            Console.Read();
        }
    }

    internal class Comparador : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
