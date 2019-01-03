using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(123, 428347),
                null,
                new ContaCorrente(234, 743629),
                null,
                new ContaCorrente(345, 934872),
                new ContaCorrente(456, 834273),
                null,
                new ContaCorrente(567, 389422),
                new ContaCorrente(678, 128937),
            };

            var contasOrdenadas = contas.OrderBy(conta =>
            {
                if (conta == null)
                    return int.MaxValue;

                return conta.Agencia;
            });

            foreach (var conta in contas)
            {
                if (conta != null)
                    Console.WriteLine(conta);
            }



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
