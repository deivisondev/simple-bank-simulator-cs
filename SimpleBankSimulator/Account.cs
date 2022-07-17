using System;
using System.Globalization;

namespace SimpleBankSimulator
{
    public class Account
    {
        public int Number { get; private set; }
        public string Name { get; set; }
        private double _balance;

        public Account(int number, string name)
        {
            Number = number;
            Name = name;
        }

        public Account(int number, string name, double initialDeposit) : this(number, name)
        {
            Deposit(initialDeposit);
        }

        public void Deposit(double value)
        {
            if (value > 0) _balance += value;
            else Console.WriteLine("Valor inválido.");
        }

        public void Withdraw(double value)
        {
            if (value > 0) _balance -= value + 5.0;
            else Console.WriteLine("Valor inválido.");
        }

        public override string ToString()
        {
            return $"Conta {Number}, Titular: {Name}, Saldo: $ {_balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
