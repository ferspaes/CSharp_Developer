namespace _06_ByteBank
{
    public class ContaCorrente
    {
        
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double _saldo = 100;

        public Cliente Titular { get; set; }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                Saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this.Sacar(valor);
            contaDestino.Depositar(valor);
            return true;
        }
    }
}