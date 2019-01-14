using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_2.Model
{
    public class Aula
    {
        private string nome;
        private int tempo;

        /// <summary>
        /// Cria uma instância da classe Aula.
        /// </summary>
        /// <param name="nome">Nome da aula.</param>
        /// <param name="tempo">Tempo de duração da aula em minutos.</param>
        public Aula(string nome, int tempo)
        {
            this.nome = nome;
            this.tempo = tempo;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Tempo { get => tempo; set => tempo = value; }

        /// <summary>
        /// Sobrecarga do método usando o parâmetro <see cref="nome"/>.
        /// </summary>
        /// <param name="obj">Obj do tipo <see cref="Aula"/>.</param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            Aula that = obj as Aula;
            return this.nome.CompareTo(that.nome);
        }

        /// <summary>
        /// Sobrecarga do método ToString().
        /// </summary>
        /// <returns>Aula: <see cref="nome"/>, Tempo: <see cref="tempo"/> minutos</returns>
        public override string ToString()
        {
            return $"[Aula: {nome}, Tempo: {tempo} minutos]";
        }
    }
}
