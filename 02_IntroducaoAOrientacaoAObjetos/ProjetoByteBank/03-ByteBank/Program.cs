using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            Console.WriteLine("Igualdade de referência: " + (contaDaGabriela == contaDaGabrielaCosta));

            int numero = 100;
            int numeroMaisUmaVez = 100;

            Console.WriteLine("Igualdade de tipo de valor: " + (numero == numeroMaisUmaVez));


            contaDaGabriela = contaDaGabrielaCosta;
            contaDaGabriela.saldo = 300;

            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);


            Console.ReadLine();

        }
    }
}
