using System;

namespace Day_13_Assignment_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the account holder's name: ");
            string accountHolderName = Console.ReadLine();

            BankAccount account = new BankAccount(accountHolderName);

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Bank Account ");
                Console.WriteLine($"\nChoose your desired option {account.AccountHolderName}:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter the amount to deposit: ");
                            if (double.TryParse(Console.ReadLine(), out double depositAmount))
                            {
                                try
                                {
                                    account.Deposit(depositAmount);
                                    Console.WriteLine($"Deposited {depositAmount} successfully.");
                                    account.PrintAccountDetails();
                                }
                                catch (ArgumentException ex)
                                {
                                    Console.WriteLine("Error: " + ex.Message);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input for deposit amount.");
                            }
                            break;

                        case 2:
                            Console.Write("Enter the amount to withdraw: ");
                            if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                            {
                                try
                                {
                                    account.Withdraw(withdrawAmount);
                                    Console.WriteLine($"Withdrawn {withdrawAmount} successfully.");
                                    account.PrintAccountDetails();
                                }
                                catch (ArgumentException ex)
                                {
                                    Console.WriteLine("Error: " + ex.Message);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input for withdrawal amount.");
                            }
                            break;

                        case 3:
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please choose a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
                }
            }

            Console.WriteLine("\nFinal Account Details:");
            account.PrintAccountDetails();
        }
    }
}
