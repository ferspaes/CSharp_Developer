using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(500);

            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque);

            contaDoBruno.Depositar(500);
            Console.WriteLine($"Saldo do Bruno: {System.Math.Round(contaDoBruno.saldo)}");

            resultadoSaque = contaDoBruno.Sacar(500);
            Console.WriteLine($"Saldo do Bruno: {System.Math.Round(contaDoBruno.saldo, 2)}");
            Console.WriteLine(resultadoSaque);

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            contaDoBruno.Depositar(200);
            Console.WriteLine($"Saldo do Bruno antes da transferência: R${System.Math.Round(contaDoBruno.saldo, 2)}");
            Console.WriteLine($"Saldo da Gabriela antes da transferência: {System.Math.Round(contaDaGabriela.saldo, 2)}");
            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);
            Console.WriteLine($"Saldo do Bruno: R${System.Math.Round(contaDoBruno.saldo, 2)}");
            Console.WriteLine($"Saldo da Gabriela: R${System.Math.Round(contaDaGabriela.saldo, 2)}");
            Console.WriteLine(resultadoTransferencia);

            Console.ReadLine();
        }
    }
}
