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
            bank.BankName = "Stay_Humble";
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
                        Console.WriteLine("Enter Your Account Name :");
                        ac.AccountName = Console.ReadLine();
                        Console.WriteLine("Enter Balance :");
                        ac.Balance = Convert.ToInt32(Console.ReadLine());
                        bank.AddAccount(ac);
                        break;

                    case 2:
                        Console.WriteLine("Enter Account Number To Delete :");
                        int Nd = Convert.ToInt32(Console.ReadLine());
                        bank.DeleteAccount(Nd);
                        break;



                }
    }
}
