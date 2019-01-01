using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();
            //
            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Desenvolvedora C#";
            //gabriela.cpf = "434.562.878-20";
            //conta.titular = gabriela;
            //Console.WriteLine(gabriela.nome);

            /*
            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela Costa";
            conta.titular.cpf = "434.562.878-20";
            conta.titular.profissao = "Desenvolvedora C#";
            */

            ContaCorrente conta = new ContaCorrente();
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            if (conta.titular == null)
            {
                Console.WriteLine("Ops, não há referência para conta.titular, sendo assim ela é nula...");
            }

            Console.WriteLine(conta.titular);

            /*Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);*/

            Console.ReadLine();
        }
    }
}
