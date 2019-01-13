using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Model
{
    public class Curso
    {

        private IDictionary<int, Aluno> dicAlunos = new Dictionary<int, Aluno>();
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        private IList<Aula> aulas;
        private string nomeCurso;
        private string instrutor;

        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        internal void AdicionarAula(Aula aula)
        {
            this.aulas.Add(new Aula(aula.Nome, aula.Tempo));
        }

        public Curso(string nomeCurso, string instrutor)
        {
            this.nomeCurso = nomeCurso;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        public string NomeCurso
        {
            get { return nomeCurso; }
            set { nomeCurso = value; }
        }


        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        internal Aluno BuscarMatricula(int matricula)
        {
            Aluno aluno = null;
            dicAlunos.TryGetValue(matricula, out aluno);
            return aluno;
        }

        private int tempoTotal;

        public int TempoTotal
        {
            get
            {
                tempoTotal = aulas.Sum(aula => aula.Tempo);
                return tempoTotal;
            }
        }

        public void Matricular(Aluno aluno)
        {
            alunos.Add(aluno);
            dicAlunos.Add(aluno.NumeroMatricula, aluno);
        }

        public override string ToString()
        {
            return $"Curso: {NomeCurso}, Tempo: {TempoTotal}, Aulas: {string.Join(",", aulas)}";
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }
    }
}
