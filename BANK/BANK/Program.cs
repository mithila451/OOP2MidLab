using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cycle = true;
            Bank bank = new Bank();
            bank.BankName = "Trustworthy";
            Console.WriteLine("Welcome To {0} Bank", bank.BankName);
            while (cycle)
            {
                Console.WriteLine("Select From-");
                Console.WriteLine("1.Add Account\n2.Delete Account\n3.Transaction\n4.Print Account Details\n5.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Account ac = new Account(new Address());
                        Console.WriteLine("account name :");
                        ac.AccountName = Console.ReadLine();
                        Console.WriteLine("balance :");
                        ac.Balance = Convert.ToInt32(Console.ReadLine());
                        bank.AddAccount(ac);
                        break;

                    case 2:
                        Console.WriteLine("delete account:");
                        int nd = Convert.ToInt32(Console.ReadLine());
                        bank.DeleteAccount(nd);
                        break;

                    case 3:
                        Console.WriteLine("1.Deposit\n2.Withdraw\n3.Transfer");
                        int c2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("amount:");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("account number:");
                        int senderNumber = Convert.ToInt32(Console.ReadLine());
                        bank.Transaction(c2, senderNumber, amount);
                        break;
                    case 4:
                        Console.WriteLine("accounts are..");
                        bank.PrintAccountDetails();
                        break;
                    case 5:
                        cycle = false;
                        break;
                    default:
                        break;



                }
            }
        }
    }
}