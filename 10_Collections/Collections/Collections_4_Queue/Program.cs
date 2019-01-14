using Collections_4_Queue.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Collections_4_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var pedagio = new Pedagio();

            Console.WriteLine("\n -= SISTEMA DE PEDAGIO =-\n\n Seja Bem-Vindo!\n");
            Thread.Sleep(1200);

            pedagio.EnfileirarVeiculo("BMW");
            Thread.Sleep(1200);

            pedagio.EnfileirarVeiculo("Mustang");
            Thread.Sleep(1200);
            pedagio.EnfileirarVeiculo("Ferrari");
            Thread.Sleep(1200);
            pedagio.EnfileirarVeiculo("Camaro");
            Thread.Sleep(1200);
            pedagio.EnfileirarVeiculo("Audi");
            Thread.Sleep(1200);
            pedagio.EnfileirarVeiculo("Aston Martin");
            Thread.Sleep(1200);
            pedagio.EnfileirarVeiculo("Honda Civic");
            Thread.Sleep(1200);
            pedagio.EnfileirarVeiculo("Porsche");
            Thread.Sleep(1200);

            pedagio.VerificarPedagio();
            Thread.Sleep(800);
            pedagio.DesenfileirarVeiculo();
            Thread.Sleep(800);
            pedagio.VerificarPedagio();
            Thread.Sleep(800);
            pedagio.DesenfileirarVeiculo();
            Thread.Sleep(800);
            pedagio.VerificarPedagio();
            Thread.Sleep(800);
            pedagio.DesenfileirarVeiculo();
            Thread.Sleep(800);
            pedagio.VerificarPedagio();
            Thread.Sleep(800);
            pedagio.DesenfileirarVeiculo();
            Thread.Sleep(800);
            pedagio.VerificarPedagio();
            Thread.Sleep(800);
            pedagio.DesenfileirarVeiculo();
            Thread.Sleep(800);
            pedagio.VerificarPedagio();
            Thread.Sleep(800);
            pedagio.DesenfileirarVeiculo();
            Thread.Sleep(800);
            pedagio.VerificarPedagio();
            Thread.Sleep(800);
            pedagio.DesenfileirarVeiculo();
            Thread.Sleep(800);
            pedagio.VerificarPedagio();
            Thread.Sleep(800);
            pedagio.DesenfileirarVeiculo();
            Thread.Sleep(800);

            pedagio.VerificarPedagio();
            Thread.Sleep(800);
            pedagio.DesenfileirarVeiculo();
            Thread.Sleep(800);
        }
    }
}
