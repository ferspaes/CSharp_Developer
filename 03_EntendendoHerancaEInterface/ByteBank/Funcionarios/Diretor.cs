using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel 
    {
        public Diretor(string nome, string cpf) : base(nome, cpf, 5000)
        {
            Console.WriteLine("Diretor...");
        }

        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.50;
        }
    }
}
