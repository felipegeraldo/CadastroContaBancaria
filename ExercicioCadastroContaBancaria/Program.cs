using System;
using System.Globalization;

namespace ExercicioCadastroContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número da Conta: ");
            int Conta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da Conta: ");
            string Nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)?");
            char deposito = char.Parse(Console.ReadLine());

            double ValorDeposito = 0;

            if (deposito == 'S' || deposito == 's')
            {
                Console.Write("Entre com o valor do depósito: ");
                ValorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            ContaBancaria ContaBancaria = new ContaBancaria(Conta, Nome, ValorDeposito);

            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(ContaBancaria);

            Console.Write("Entre com valor de depósito: ");
            ValorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ContaBancaria.Depositar(ValorDeposito);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(ContaBancaria);

            Console.Write("Entre com um valor para saque:");
            double Saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ContaBancaria.Sacar(Saque);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(ContaBancaria);

        }
    }
}