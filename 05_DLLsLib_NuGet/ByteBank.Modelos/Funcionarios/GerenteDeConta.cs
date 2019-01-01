using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string nome, string cpf) : base(nome, cpf, 4000)
        {
            Console.WriteLine("Gerente de Contas...");
        }

        public override void AumentarSalario()
        {
            Salario *= 0.05;
        }

        internal protected override double GetBonificacao()
        {
            return Salario *= 0.25;
        }
    }
}
