using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string nome, string cpf) : base(nome, cpf, 8000)
        {
            Console.WriteLine("Desenvolvedor...");
        }

        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }

        internal protected override double GetBonificacao()
        {
            return Salario *= 1.15;
        }
    }
}
