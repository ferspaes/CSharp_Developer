using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Auxiliar : Funcionario
    {
        public Auxiliar (string nome, string cpf) : base (nome, cpf, 2000)
        {
            Console.WriteLine("Auxiliar...");
        }

        public override void AumentarSalario()
        {
            Salario *= 0.10;
        }

        public override double GetBonificacao()
        {
           return Salario *= 0.20;
        }
    }
}
