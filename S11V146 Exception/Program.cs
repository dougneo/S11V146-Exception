using System;
using System.Globalization;
using S11V146_Exception.Entities;
using S11V146_Exception.Entities.Excpetion;

namespace S11V146_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();

                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                acc.Withdraw(withdraw);

                Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }

            catch (FormatException e)
            {
                Console.WriteLine("Erro no formato: " + e.Message);
            }
            catch (DomainExcpetion e)
            {
                Console.WriteLine("Erro no saque: " + e.Message);
            }
        }
    }
}
