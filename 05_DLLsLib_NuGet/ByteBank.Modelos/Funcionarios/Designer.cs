using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string nome, string cpf) : base(nome, cpf, 3000)
        {
            Console.WriteLine("Designer...");
        }

        public override void AumentarSalario()
        {
            Salario *= 0.11;
        }

        internal protected override double GetBonificacao()
        {
            return Salario *= 0.17;
        }
    }
}