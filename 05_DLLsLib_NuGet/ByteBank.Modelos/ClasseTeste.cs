using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    internal class ClasseTeste
    {
        public ClasseTeste()
        {
            ModificadoresTeste teste = new ModificadoresTeste();

            teste.MetodoPublico();
            teste.MetodoInterno();
        }
    }

    internal class ClasseDerivada : ModificadoresTeste
    {
        public ClasseDerivada()
        {
            MetodoPublico();
            MetodoProtegido();
            MetodoInterno();
        }
    }

    public class ModificadoresTeste
    {
        public void MetodoPublico()
        {
            //Visivel fora da classe "Modificadores teste"
        }

        protected void MetodoProtegido()
        {
            // Visivel apenas na classe "Modificadores teste" e Derivados desta classes
        }

        private void MetodoPrivado()
        {
            // Visivel somente na classe "Modificadores teste"
        }

        internal void MetodoInterno()
        {
            // Visivel somente neste projeto atual a qual este metodo e clase pertencem!
        }
    }
}
