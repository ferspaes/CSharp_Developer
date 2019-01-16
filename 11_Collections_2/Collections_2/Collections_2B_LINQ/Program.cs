using Collections_2B_LINQ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_2B_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mes> meses = new List<Mes>
            {
                new Mes("Janeiro", 31),
                new Mes("Fevereiro", 28),
                new Mes("Março", 31),
                new Mes("Abril", 30),
                new Mes("Maio", 31),
                new Mes("Junho", 30),
                new Mes("Julho", 31),
                new Mes("Agosto", 31),
                new Mes("Setembro", 30),
                new Mes("Outubro", 31),
                new Mes("Novembro", 30),
                new Mes("Dezembro", 31)
            };

            Console.WriteLine("Lista de Meses: \n");
            meses.ForEach(mes => Console.WriteLine($"{mes}"));

            IEnumerable<string> query =
                meses
                .Where(mes => mes.Dias.Equals(31))
                .OrderBy(mes => mes.Nome)
                .Select(mes => mes.Nome.ToUpper());

            Console.WriteLine($"\n(\nmeses\n.Where(mes => mes.Dias.Equals(31))\n.OrderBy(mes => mes.Nome)\n.Select(mes => mes.Nome.ToUpper());\n)\n");
            foreach (var mes in query)
            {
                Console.WriteLine(mes);
            }

            // Pega os 3 primeiros meses da lista
            var consulta1 = meses.Take(3);

            // Pula os 3 primeiros meses da lista
            var consulta2 = meses.Skip(3);

            // Pula os 6 primeiros meses da lista e pega 3 após isto
            var consulta3 = meses.Skip(6).Take(3);

            // Pega os meses da lista até que apareça algum mes que começe com a letra "S"
            var consulta4 = meses.TakeWhile(mes => !mes.Nome.StartsWith("S"));

            // Pula os meses da lista até encontrar algum mes que começe com a letra "S"
            var consulta5 = meses.SkipWhile(mes => !mes.Nome.StartsWith("S"));

            Console.WriteLine($"\nTake(3)\n");

            foreach (var mes in consulta1)
            {
                Console.WriteLine(mes);
            }

            Console.WriteLine($"\nSkip(3)\n");

            foreach (var mes in consulta2)
            {
                Console.WriteLine(mes);
            }

            Console.WriteLine($"\nSkip(6).Take(3)\n");

            foreach (var mes in consulta3)
            {
                Console.WriteLine(mes);
            }

            Console.WriteLine($"\nTakeWhile(mes => !mes.Nome.StartsWith('S'))\n");

            foreach (var mes in consulta4)
            {
                Console.WriteLine(mes);
            }

            Console.WriteLine($"\nSkipWhile(mes => !mes.Nome.StartsWith('S'))\n");

            foreach (var mes in consulta5)
            {
                Console.WriteLine(mes);
            }

            List<string> lista1 = new List<string>
            {
                "Janeiro", "Fevereiro", "Março"
            };

            List<string> lista2 = new List<string>
            {
                "Fevereiro", "MARÇO", "Abril"
            };

            Console.WriteLine("\n -= Lista 1 =-");
            lista1.ForEach(item => Console.WriteLine(item));
            Console.WriteLine("\n -= Lista 2 =-");
            lista2.ForEach(item => Console.WriteLine(item));

            var consultaLista1 = lista1.Concat(lista2);
            Console.WriteLine("\nlista1.Concat(lista2)");
            foreach (var item in consultaLista1)
            {
                Console.WriteLine(item);
            }

            var consultaLista2 = lista1.Union(lista2);
            Console.WriteLine("\nlista1.Union(lista2)");
            foreach (var item in consultaLista2)
            {
                Console.WriteLine(item);
            }

            var consultaLista3 = lista1.Union(lista2, StringComparer.InvariantCulture);
            Console.WriteLine("\nlista1.Union(lista2, StringComparer.InvariantCulture)");
            foreach (var item in consultaLista3)
            {
                Console.WriteLine(item);
            }

            var consultaLista4 = lista1.Except(lista2);
            Console.WriteLine("\nlista1.Except(lista2)");
            foreach (var item in consultaLista4)
            {
                Console.WriteLine(item);
            }

            string[] mesesArray = new string[]
            {
                "Janeiro",
                "Fevereiro",
                "Março",
                "Abril",
                "Maio",
                "Junho",
                "Julho",
                "Agosto",
                "Setembro",
                "Outubro",
                "Novembro",
                "Dezembro"
            };

            // object[] mesesArrayObj = mesesArray; // ERRADO VAI DAR EXCEPETION AO TENTAR INSERIR VALORES DE OUTRO TIPO QUE NÃO SEJA O TIPO QUE ELE RECEBEU

            IEnumerable<object> mesesEnum = meses; // COVARIANÇiA

            Console.WriteLine($"\nCOVARIANÇIA E CONTRACOVARIANÇIA");

            foreach (var item in mesesEnum)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
