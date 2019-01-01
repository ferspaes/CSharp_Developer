using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Designer : Funcionario
    {
        public Designer(string nome, string cpf) : base(nome, cpf, 3000)
        {
            Console.WriteLine("Designer...");
        }

        public override void AumentarSalario()
        {
            Salario *= 0.11;
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.17;
        }
    }
}
