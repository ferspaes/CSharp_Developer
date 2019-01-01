using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("Roberta", "123.456.789-10");
            roberta.Senha = "123";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(roberta, "abc");

            GerenteDeConta camila = new GerenteDeConta("Camila", "123.456.789-10");
            camila.Senha = "123";

            sistemaInterno.Logar(camila, "123");
            sistemaInterno.Logar(camila, "abc");

            ParceiroComercial parceiroComercial = new ParceiroComercial();
            parceiroComercial.Senha = "123456";

            sistemaInterno.Logar(parceiroComercial, "123456");
            sistemaInterno.Logar(parceiroComercial, "abc");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("Pedro", "123.456.789-10");

            Diretor roberta = new Diretor("Roberta", "123.456.789-10");

            Auxiliar igor = new Auxiliar("Igor", "123.456.789-10");

            GerenteDeConta camila = new GerenteDeConta("Camila", "123.456.789-10");

            Desenvolvedor fernando = new Desenvolvedor("Fernando", "123.456.789-10");

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(fernando);

            Console.WriteLine($"Total de bonificações: {gerenciadorBonificacao.GetTotalBonificacao()}");
        }
    }
}
