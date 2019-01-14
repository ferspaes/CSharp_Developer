using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_2
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> dias = new LinkedList<string>();

            var d4 = dias.AddFirst("Quarta-Feira");

            var d2 = dias.AddBefore(d4, "Segunda-Feira");

            var d3 = dias.AddAfter(d2, "Terça-Feira");

            var d1 = dias.AddBefore(d2, "Domingo");

            var d5 = dias.AddAfter(d4, "Quinta-Feira");

            var d6 = dias.AddAfter(d5, "Sexta-Feira");

            var d7 = dias.AddAfter(d6, "Sábado");

            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }

            dias.Remove("Quarta-Feira");

            Console.WriteLine();

            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }

            Console.WriteLine();

            d4 = dias.AddAfter(d3, "Quarta-Feira!");

            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }

            dias.Remove(d4);

            Console.WriteLine();

            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }

            Console.WriteLine();

            dias.AddAfter(d3, "Quarta-Feira");

            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }

            Console.Read();
        }
    }
}
