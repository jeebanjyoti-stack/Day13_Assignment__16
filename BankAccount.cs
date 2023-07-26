using System;

namespace Day_13_Assignment_16
{
    public class BankAccount
    {
        private static int lastAccountNumber = 0;

        public string AccountNumber { get; }
        public string AccountHolderName { get; set; }

        private double balance;
        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance cannot be negative.");
                }
                balance = value;
            }
        }

        public BankAccount(string accountHolderName)
        {
            AccountNumber = GenerateAccountNumber();
            AccountHolderName = accountHolderName;
            Balance = 0;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }

            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance.");
            }

            Balance -= amount;
        }

        public void PrintAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder Name: {AccountHolderName}");
            Console.WriteLine($"Balance: {Balance}");
            Console.WriteLine();
        }

        private string GenerateAccountNumber()
        {
            lastAccountNumber++;
            return $"ACCT-{lastAccountNumber}";
        }
    }
}
