using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;
using System;
using System.Collections.Generic;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            var nomes = new List<string>()
            {
                "Zinin",
                "Amanda",
                "Cloud",
                "Berenice"
            };

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            var idades = new List<int>()
            {
                10,
                50,
                01,
                100,
                500,
                1000
            };

            idades.Sort();

            foreach (var idade in idades)
            {
                Console.WriteLine(idade);
            }

            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(123, 428347),
                new ContaCorrente(234, 743629),
                new ContaCorrente(345, 934872),
                new ContaCorrente(456, 834273),
                new ContaCorrente(567, 389422),
                new ContaCorrente(678, 128937),
            };

            contas.Sort();

            foreach (var conta in contas)
            {
                Console.WriteLine(conta);
            }

            contas.Sort(new ComparadorContaCorrentePorAgencia());

            foreach (var conta in contas)
            {
                Console.WriteLine(conta);
            }

            Console.Read();
            Aula01();
        }

        private static void Aula01()
        {
            List<int> lista = new List<int>();

            lista.Add(0);
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);
            lista.Add(5);

            lista.AddRange(new int[] { 123, 456, 789, 10 });

            ListExtensoes.AdicionarVarios(lista, 1234, 5678, 9101112, 13);

            lista.AdicionarVarios(1597, 3574, 4679, 3157);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
