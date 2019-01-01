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
            List<int> lista = new List<int>();

            lista.Add(0);
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);
            lista.Add(5);

            lista.AddRange(new int[]{ 123, 456, 789, 10 });

            ListExtensoes<int>.AdicionarVarios(lista, 1234, 5678, 9101112, 13);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
