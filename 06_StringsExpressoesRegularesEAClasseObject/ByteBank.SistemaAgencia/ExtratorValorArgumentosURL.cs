using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorArgumentosURL
    {
        public string URL { get; set; }
        private readonly string _argumentos = string.Empty;

        public ExtratorValorArgumentosURL(string url)
        {
            if (String.IsNullOrWhiteSpace(url))
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio.", nameof(url));

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);

            URL = url;
        }

        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper();
            string argumentosEmCaixaAlta = _argumentos.ToUpper();
            string termo = nomeParametro + "=";
            int indiceTermo = argumentosEmCaixaAlta.IndexOf(termo);
            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            int indiceEComercial = resultado.IndexOf('&');

            if (indiceEComercial == -1)
                return resultado;

            return resultado.Remove(indiceEComercial);
        }
    }
}
