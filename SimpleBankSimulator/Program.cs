using System;
using System.Globalization;

namespace SimpleBankSimulator
{
    class Program
    {
        static void Main()
        {
            Account account;

            Console.Write("Entre o número da conta: ");
            int number = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com o titular da conta: ");
            string name = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char initialDeposit = char.Parse(Console.ReadLine());

            double value;

            if (initialDeposit == 's' || initialDeposit == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account = new Account(number, name, value);

            }
            else
            {
                account = new Account(number, name);
            }

            Console.WriteLine($"\nDados da conta:\n{account}\n");

            Console.Write("Entre um valor para depósito: ");
            value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            account.Deposit(value);

            Console.WriteLine($"Dados da conta atualizados:\n{account}\n");

            Console.Write("Entre um valor para saque: ");
            value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            account.Withdraw(value);

            Console.WriteLine($"Dados da conta atualizados:\n{account}");
        }
    }
}
