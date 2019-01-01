using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            CarregarContas();

            #region Final default
            Console.WriteLine();
            Console.WriteLine("===========================================");
            Console.WriteLine();
            Console.WriteLine("Final da execução do programa!");
            Console.ReadLine();
            #endregion 
        }

        public static void CarregarContas()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"))
            {
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
            }

            //LeitorDeArquivo leitor = null;

            //try
            //{
            //    leitor = new LeitorDeArquivo("contas.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("Exceção do tipo IOException capturada e tratada.");
            //}
            //finally
            //{
            //    if (leitor != null)
            //    {
            //        leitor.Dispose();
            //    }
            //}

        }

        public static void AulaInnerException()
        {
            try
            {
                ContaCorrente conta2 = new ContaCorrente(10, 20);
                ContaCorrente contacorrente = new ContaCorrente(100, 10);

                contacorrente.Depositar(500);
                contacorrente.Sacar(50);
                conta2.Transferir(10000, contacorrente);

                Console.WriteLine(contacorrente.Saldo);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteExcepetion!");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine();

                Console.WriteLine("Informações da InnerException");
                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no argumento: " + ex.ParamName);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine("-= OperaçãoFinanceiraExcepetion =-");
                Console.WriteLine(ex.Message);
                Console.WriteLine("=================================");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("=================================");
                Console.WriteLine("-= Informações da InnerException =-");
                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine("=================================");
                Console.WriteLine(ex.InnerException.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                Console.WriteLine();
                Console.WriteLine("Informações da InnerException.");
                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);
            }

            try
            {
                Metodo();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Não é possível dividir um número por 0");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Exeção tratada!");
            }

            ContaCorrente conta = new ContaCorrente(7480, 874150);
            try
            {
                Console.WriteLine(ContaCorrente.TaxaOperacao);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        public static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch
            {
                Console.WriteLine("Exceção com número=" + numero + " e divisor=" + divisor + ".");
                throw;
            }

        }

        static void Metodo()
        {
            TestaDivisao(2);
        }

        private static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }
    }
}
