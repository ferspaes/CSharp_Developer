using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    /// <summary>
    /// Define uma Conta Corrente do banco ByteBank.
    /// </summary>
    public class ContaCorrente : IComparable
    {
        private static int TaxaOperacao;

        /// <summary>
        /// Armazena a quantidade de contas que foram instanciadas ao longo do projeto.
        /// </summary>
        public static int TotalDeContasCriadas { get; private set; }

        /// <summary>
        /// Armazena dados sobre o titular da conta.
        /// </summary>
        public Cliente Titular { get; set; }

        /// <summary>
        /// Armazena a quantidade de Saques não permitidos
        /// </summary>
        public int ContadorSaquesNaoPermitidos { get; private set; }

        /// <summary>
        /// Variável responsável pelo armazenamento da quantidade de transferências falhas.
        /// </summary>
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        /// <summary>
        /// Número da conta.
        /// </summary>
        public int Numero { get; }

        /// <summary>
        /// Número da agência da conta.
        /// </summary>
        public int Agencia { get; }

        private double _saldo = 100;

        /// <summary>
        /// Valor do saldo atual da conta.
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
        /// Cria uma instância de ContaCorrente com os argumentos utilizados.
        /// </summary>
        /// <param name="agencia"> Representa o valor da propriedade <see cref="Agencia"/> e deve possuir um valor maior que zero. </param>
        /// <param name="numero"> Representa o valor da propriedade <see cref="Numero"/> e deve possuir um valor maior que zero. </param>
        public ContaCorrente(int agencia, int numero)
        {
            if (numero <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        /// <summary>
        /// Realiza o saque e atualiza o valor da propriedade <see cref="Saldo"/>.
        /// </summary>
        /// <exception cref="ArgumentException"> Exceção lançada quando um valor negativo é utilizado no argumento <paramref name="valor"/>. </exception>
        /// <exception cref="SaldoInsuficienteException"> Exceção lançada quando o valor de <paramref name="valor"/> é maior que o valor da propriedade <see cref="Saldo"/>. </exception>
        /// <param name="valor"> Representa o valor do saque, deve ser maior que 0 e menor que o <see cref="Saldo"/>. </param>
        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }

            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            _saldo -= valor;
        }

        /// <summary>
        /// Deposita um valor a conta.
        /// </summary>
        /// <param name="valor">Valor a ser depositado, deve ser maior que zero.</param>
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        /// <summary>
        /// Efetua a transferencia de valor de uma conta para outra.
        /// </summary>
        /// <param name="valor">Valor a ser transferido, deve ser maior que zero.</param>
        /// <param name="contaDestino">Conta que irá receber o valor transferido, não pode ser nula.</param>
        /// <exception cref="ArgumentException">Referência lançada ao tentar depositar valor menor que zero.</exception>
        /// <exception cref="SaldoInsuficienteException">Exceção lançada ao tentar transferir um valor maior que o saldo da conta origem.</exception>
        /// <exception cref="OperacaoFinanceiraException">Exceção lançada para operações que não puderam ser concluídas com sucesso.</exception>
        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }

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

        /// <summary>
        /// Sobrecarga do método equals para comparar o número da agência e o número da conta.
        /// </summary>
        /// <param name="obj">Deve ser passado um objeto do tipo <see cref="ContaCorrente" />.</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            ContaCorrente outraConta = obj as ContaCorrente;

            if (outraConta == null)
                return false;

            return outraConta.Numero.Equals(this.Numero) && outraConta.Agencia.Equals(this.Agencia);
        }

        /// <summary>
        /// Compara o número da conta.
        /// </summary>
        /// <param name="obj">Object do tipo <c ref="ContaCorrente"></c>. </param>
        /// <returns>Retorna uma lista ordenada.</returns>
        public int CompareTo(object obj)
        {
            var conta = obj as ContaCorrente;

            if (Numero < conta.Numero)
                return -1;

            if (Numero == conta.Numero || conta == null)
                return 0;

            return 1;
        }

        /// <summary>
        /// Escreve o Número da conta e depois o número da agência.
        /// </summary>
        /// <returns>Retorna uma interpolação de string com número e agência.</returns>
        public override string ToString()
        {
            return $"Conta: {this.Numero}, Ag.: {this.Agencia}";
        }
    }

}
