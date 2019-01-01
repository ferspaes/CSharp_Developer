using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; protected set; }
        public double Salario { get; protected set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            Console.Write("Criando Funcionario... ");
            CPF = cpf; Nome = nome; Salario = salario;
            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();
        internal protected abstract double GetBonificacao();
    }
}
