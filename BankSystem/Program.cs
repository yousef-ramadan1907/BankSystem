using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class Program
    {
        static void DisplayItems<T>(T item)
        {
            Console.WriteLine(item);
        }

        static void Main(string[] args)
        {
            Repository<SavingsAccount> savingsRepo = new Repository<SavingsAccount>(100);
            Repository<CheckingAccount> checkingRepo = new Repository<CheckingAccount>(100);
            Repository<Transaction> transactionRepo = new Repository<Transaction>(100);

            int choice;

            do
            {
                Console.Clear();
                Console.WriteLine("========== BANK SYSTEM ==========");
                Console.WriteLine("1. Add Savings Account");
                Console.WriteLine("2. Display Savings Accounts");
                Console.WriteLine("3. Add Checking Account");
                Console.WriteLine("4. Display Checking Accounts");
                Console.WriteLine("5. Add Transaction");
                Console.WriteLine("6. Display Transactions");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");

                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("\n--- Add Savings Account ---");
                    Console.Write("Enter Account Number: ");
                    string accNum = Console.ReadLine();
                    Console.Write("Enter Holder Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Balance: ");
                    decimal balance = decimal.Parse(Console.ReadLine());
                    Console.Write("Enter Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Enter Interest Rate: ");
                    decimal rate = decimal.Parse(Console.ReadLine());

                    SavingsAccount acc = new SavingsAccount(accNum, name, balance, email, rate);
                    savingsRepo.Add(acc);
                    Console.WriteLine("Added Successfully!");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\n--- Savings Accounts ---");
                    savingsRepo.Display();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("\n--- Add Checking Account ---");
                    Console.Write("Enter Account Number: ");
                    string accNum = Console.ReadLine();
                    Console.Write("Enter Holder Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Balance: ");
                    decimal balance = decimal.Parse(Console.ReadLine());
                    Console.Write("Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Enter Overdraft Limit: ");
                    decimal limit = decimal.Parse(Console.ReadLine());

                    CheckingAccount acc = new CheckingAccount(accNum, name, balance, email, limit);
                    checkingRepo.Add(acc);
                    Console.WriteLine("Added Successfully!");
                }
                else if (choice == 4)
                {
                    Console.WriteLine("\n--- Checking Accounts ---");
                    checkingRepo.Display();
                }
                else if (choice == 5)
                {
                    Console.WriteLine("\n--- Add Transaction ---");
                    Console.Write("Enter Transaction ID: ");
                    string tId = Console.ReadLine();
                    Console.Write("Enter Account Number: ");
                    string accNum = Console.ReadLine();
                    Console.Write("Enter Amount: ");
                    decimal amount = decimal.Parse(Console.ReadLine());
                    Console.Write("Enter Type (Deposit/Withdrawal): ");
                    string type = Console.ReadLine();

                    Transaction t = new Transaction(tId, accNum, amount, DateTime.Now, type);
                    transactionRepo.Add(t);
                    Console.WriteLine("Added Successfully!");
                }
                else if (choice == 6)
                {
                    Console.WriteLine("\n--- Transactions ---");
                    transactionRepo.Display();
                }
                else if (choice == 7)
                {
                    Console.WriteLine("Exiting...");
                }
                else
                {
                    Console.WriteLine("Wrong choice, try again!");
                }

                if (choice != 7)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }

            } while (choice != 7);
        }
    }
}