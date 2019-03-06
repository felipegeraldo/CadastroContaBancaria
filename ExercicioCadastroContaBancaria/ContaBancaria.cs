using System.Globalization;

namespace ExercicioCadastroContaBancaria
{
    class ContaBancaria
    {
        public int Conta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string nome)
        {
            Conta = conta;
            Nome = nome;
            Saldo = 0;
        }

        public ContaBancaria(int conta, string nome, double depositoInicial) : this(conta, nome)
        {
            Depositar(depositoInicial);
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor + 5.00;
        }

        public override string ToString()
        {
            return "Conta: "
                + Conta
                + ", Titular: "
                + Nome
                + ", Saldo: "
                + " $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
