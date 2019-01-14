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
            IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();
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

            Console.Read();
        }
    }
}
