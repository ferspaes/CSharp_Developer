using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    /// <summary>
    /// Define uma Conta Corrente do banco Bytebank.
    /// </summary>
    public class ContaCorrente
    {
        /// <summary>
        /// Atributo utilizado para armazenar o número de tentativas de transferências mal sucedidas.
        /// </summary>
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        /// <summary>
        /// Atributo usado para salvar tentativas de saques mal-sucedidas.
        /// </summary>
        public int ContadorSaquesNaoPermitidos { get; private set; }

        /// <summary>
        /// Atributo que guarda a taxa de operações bancárias.
        /// </summary>
        public static double TaxaOperacao { get; private set; }

        /// <summary>
        /// Atributo que representa a classe Cliente em ContaCorrente.
        /// </summary>
        public Cliente Titular { get; set; }

        /// <summary>
        /// Atributo que guarda a quantidade de ContaCorrente instânciadas (get; private set;).
        /// </summary>
        public static int TotalDeContasCriadas { get; private set; }

        /// <summary>
        /// Numero da Agência Bancária (atributo read-only).
        /// </summary>
        public int NumeroDaAgencia { get; }

        /// <summary>
        /// Numero da Conta Bancária (atributo read-only).
        /// </summary>
        public int NumeroDaConta { get; }
        private double _saldo = 100;

        /// <summary>
        /// Define o saldo da conta bancária.
        /// </summary>
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

        /// <summary>
        /// Cria uma instância de Conta Corrente com os argumentos utilizados.
        /// </summary>
        /// <param name="numeroAgencia">Representa o valor da propriedade <see cref="NumeroDaAgencia"/> e deve possuir um valor maior que zero.</param>
        /// <param name="numeroConta">Representa o valor da propriedade <see cref="NumeroDaConta" /> e deve possuir um valor maior que zero.</param>
        public ContaCorrente(int numeroAgencia, int numeroConta)
        {
            if (numeroAgencia <= 0)
            {
                throw new ArgumentException("O argumento agência deve ser maior que zero.", nameof(numeroAgencia));
            }

            if (numeroConta <= 0)
            {
                throw new ArgumentException("O argumento número deve ser maior do que zero.", nameof(numeroConta));
            }

            NumeroDaAgencia = numeroAgencia;
            NumeroDaConta = numeroConta;
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        /// <summary>
        /// Realiza o saque e atualiza o valor da propriedade <see cref="Saldo"/>.
        /// </summary>
        /// <exception cref="ArgumentException">Exceção lançada quando um valor negativo é utilizado no argumento <paramref name="valor"/></exception>
        /// <exception cref="SaldoInsuficienteException">Exceção lançada quando o valor utilizado no argumento <paramref name="valor"/> é maior que <see cref="Saldo"/>.</exception>
        /// <param name="valor">Representa o valor do saque, deve ser maior que zero e menor que o <see cref="Saldo"/> </param>
        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor invalido para o saque", nameof(valor));
            }

            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            _saldo -= valor;
        }

        /// <summary>
        /// Deposita um valor na conta em questão.
        /// </summary>
        /// <param name="valor">Valor que será depositado na conta.</param>
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        /// <summary>
        /// Realiza uma tentativa de Transferência de uma conta bancária para outra.
        /// </summary>
        /// <exception cref="ArgumentException">Lança uma excessão caso haja uma tentativa de transferência de um valor negativo.</exception><exception cref="SaldoInsuficienteException">Lança uma excessão quando há uma tentativa de tranferir um valor maior do que o saldo atual da conta bancária.</exception>
        /// <exception cref="OperacaoFinanceiraException">Lança uma exceção genérica para quaisquer outros problemas de operação financeira não definidos.</exception>
        /// <param name="valor">Valor que deseja tranferir.</param>
        /// <param name="contaDestino">Conta para qual o <paramref name="valor"/> a ser transferido.</param>
        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0) throw new ArgumentException("Valor invalido para a transferência", nameof(valor));

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }

            contaDestino.Depositar(valor);
        }
    }
}
