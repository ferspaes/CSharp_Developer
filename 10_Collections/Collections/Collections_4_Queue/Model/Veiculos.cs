using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Collections_4_Queue.Model
{
    public class Pedagio
    {
        private Queue<string> veiculos = new Queue<string>();

        public Pedagio() { }

        public void EnfileirarVeiculo(string veiculo)
        {
            Console.WriteLine($"\n<= {veiculo} - entrou na fila.");
            veiculos.Enqueue(veiculo);
        }

        public void DesenfileirarVeiculo()
        {
            if (veiculos.Any())
            {
                string veiculo = veiculos.Dequeue();
                Console.WriteLine($"\n=> {veiculo} - saiu da fila.");
            }
        }

        public void VerificarPedagio()
        {
            if (veiculos.Any())
            {
                string veiculo = veiculos.Peek();
                Console.WriteLine();
                for (int i = 0; i <= 40; i++)
                {
                    Console.Write("=");
                    Thread.Sleep(10);
                }

                Console.WriteLine();

                Console.WriteLine($"\n== Veículos na fila: \n\n== Pagando Pedagio: {veiculo}.\n\n");
                Thread.Sleep(1000);
                Console.WriteLine("== Aguardando:");
                Thread.Sleep(500);
                int pagando = 0;
                foreach (var automovel in veiculos)
                {
                    if (pagando != 0)
                    {
                        Thread.Sleep(300);
                        Console.WriteLine($"- {automovel}");
                    }

                    pagando++;
                }
            }
            else
                Console.WriteLine("\nEMPTY QUEUE.\n");
        }
    }
}
