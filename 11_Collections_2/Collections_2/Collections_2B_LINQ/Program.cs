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

            meses.ForEach(mes => Console.WriteLine(mes));
            Console.WriteLine();

            IEnumerable<string> query =
                meses
                .Where(mes => mes.Dias.Equals(31))
                .OrderBy(mes => mes.Nome)
                .Select(mes => mes.Nome.ToUpper());

            foreach (var mes in query)
            {
                Console.WriteLine(mes);
            }

            Console.Read();
        }
    }
}
