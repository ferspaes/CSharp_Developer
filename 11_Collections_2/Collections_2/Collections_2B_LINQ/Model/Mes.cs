using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_2B_LINQ.Model
{
    public class Mes
    {
        private string nome;
        private int dias;

        public Mes(string nome, int dias)
        {
            this.nome = nome;
            this.dias = dias;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Dias
        {
            get { return dias; }
            set { dias = value; }
        }

        public override string ToString()
        {
            return $"{Nome.PadRight(10)} - {Dias} ";
        }
    }
}
