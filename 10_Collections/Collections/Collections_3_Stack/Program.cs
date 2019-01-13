using Collections_3_Stack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_3_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var chrome = new Navegador();

            chrome.Navegar("www.google.com.br");
            chrome.Navegar("www.facebook.com.br");
            chrome.Navegar("www.outlook.com");

            chrome.Voltar();

            chrome.Avancar();

            chrome.Voltar();
            chrome.Voltar();
            chrome.Voltar();
            chrome.Voltar();

            chrome.Avancar();
            chrome.Avancar();
            chrome.Avancar();
            chrome.Avancar();

            chrome.VerHistorico();

            Console.Read();
        }
    }
}
