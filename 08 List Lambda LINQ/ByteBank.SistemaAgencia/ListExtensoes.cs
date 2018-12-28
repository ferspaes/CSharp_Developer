using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public static class ListExtensoes<T>
    {
        public static void AdicionarVarios(List<T> lista, params T[] items)
        {
            foreach (T item in items)
            {
                lista.Add(item);
            }
        }
    }
}
