using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_3_Stack.Models
{
    public class Navegador
    {
        private string gravador;
        private string atual = "Página em branco.";
        private readonly Stack<string> anterior = new Stack<string>();
        private readonly Stack<string> proximo = new Stack<string>();
        private readonly Stack<string> historico = new Stack<string>();
        private readonly Stack<string> historicoBackup = new Stack<string>();

        public Navegador() { }

        public void Navegar(string url)
        {
            anterior.Push(atual);
            historico.Push(atual);

            if (!string.IsNullOrWhiteSpace(url))
                atual = url;
            else
                atual = "Nova Guia: Página em branco.";

            Console.WriteLine($"Navegou\n{atual}\n");
            historico.Push(atual);
        }

        public void Voltar()
        {
            if (anterior.Any())
            {
                proximo.Push(atual);
                atual = anterior.Pop();
                Console.WriteLine($"<<\n{atual}\n");
                historico.Push(atual);
            }
        }

        public void Avancar()
        {
            if (proximo.Any())
            {
                anterior.Push(atual);
                atual = proximo.Pop();
                Console.WriteLine($">>\n{atual}\n");
                historico.Push(atual);
            }
        }

        public void VerHistorico()
        {
            Console.WriteLine("\n -= Histórico - Mais Recentes =- \n");
            while (historico.Any())
            {
                gravador = historico.Pop();
                Console.WriteLine(gravador);
                historicoBackup.Push(gravador);
            }
            while (historicoBackup.Any())
            {
                historico.Push(historicoBackup.Pop());
            }
        }
    }
}
