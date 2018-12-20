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
            ListaDeContaCorrente lista = new ListaDeContaCorrente();
            lista.Adicionar(new ContaCorrente(1234, 123456));
            lista.Adicionar(new ContaCorrente(1234, 456789));
            lista.Adicionar(new ContaCorrente(1234, 789012));
            lista.Adicionar(new ContaCorrente(1234, 012345));
            lista.Adicionar(new ContaCorrente(5678, 123456));
            lista.Adicionar(new ContaCorrente(5678, 456789));
            lista.Adicionar(new ContaCorrente(5678, 789012));
            lista.Adicionar(new ContaCorrente(5678, 012345));
            lista.Adicionar(new ContaCorrente(9012, 012345));
            lista.Adicionar(new ContaCorrente(9012, 567890));
            lista.Adicionar(new ContaCorrente(9012, 456789));
            lista.Adicionar(new ContaCorrente(9012, 789012));

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Agencia}/{itemAtual.Numero}");
            }

            TestaArray();
            Console.ReadLine();
        }

        private static void TestaArray()
        {
            ContaCorrente[] contas = new ContaCorrente[]
                        {
                new ContaCorrente(123, 456),
                new ContaCorrente(789,0123),
                new ContaCorrente(0123,456789)
                        };

            for (int i = 0; i < contas.Length; i++)
            {
                int numeroConta = contas[i].Numero;
                Console.WriteLine($"O numero da conta de conta[{i}] = {numeroConta}");
            }

            int[] idades = null;
            idades = new int[5];

            idades[0] = 15;
            idades[1] = 30;
            idades[2] = 45;
            idades[3] = 60;
            idades[4] = 75;

            int indiceQuatro = idades[4];

            int indiceSoma = idades[2 + 2];

            int indice = 4;
            int usandoIndice = idades[indice];

            int[] outroArray = idades;

            bool[] arrayBooleans = new bool[8];

            arrayBooleans[0] = true;
            arrayBooleans[1] = false;
            arrayBooleans[2] = true;
            arrayBooleans[3] = false;
            arrayBooleans[4] = true;
            arrayBooleans[5] = false;
            arrayBooleans[6] = true;
            arrayBooleans[7] = false;

            foreach (var idade in idades)
                Console.WriteLine(idade);
        }
    }
}
