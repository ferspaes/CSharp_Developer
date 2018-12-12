using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idades = new int[5];

            idades[0] = 15;
            idades[1] = 30;
            idades[2] = 45;
            idades[3] = 60;
            idades[4] = 75;

            foreach (var idade in idades)
                Console.WriteLine(idade);

            Console.ReadLine();
        }
    }
}
