using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK
{
    class Bank
    {
        private string bankName;
        private Account[] myBank = new Account[5];

        public string BankName
        {
            get { return this.bankName; }  set { this.bankName = value; }
        }

        public void AddAccount(Account account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    myBank[i].GenarateAccountNumber();
                    Console.WriteLine("Enter Your Address_");
                    Console.WriteLine("Road No-House No-City-Country-");
                    myBank[i].Address.RoadNo = Console.ReadLine();
                    myBank[i].Address.HouseNo = Console.ReadLine();
                    myBank[i].Address.City = Console.ReadLine();
                    myBank[i].Address.Country = Console.ReadLine();
                    break;
                }
            }
        }

        public void DeleteAccount(int accountNumber)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i].AccountNumber == accountNumber)
                {
                    myBank[i] = null;
                    break;
                }
            }

        }

        public void PrintAccountDetails()
        {
            for (int i = 0; myBank[i] != null; i++)
            {
                myBank[i].ShowAccountInformation();
            }
            
        }

        public void Transaction(int choice, int sAN, int amount)
        {
            switch (choice)
            {
                case 1:

                    for (int i = 0; i < myBank.Length; i++)
                    {
                        if (myBank[i].AccountNumber == sAN)
                        {
                            myBank[i].Deposit(amount);
                            break;
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < myBank.Length; i++)
                    {
                        if (myBank[i].AccountNumber == sAN)
                        {
                            myBank[i].Withdraw(amount);
                            break;
                        }
                    }
                    break;
                case 3:

                    Console.WriteLine("receiver Account Number :");
                    int rN = Convert.ToInt32(Console.ReadLine());
                    int Nt = 0;
                    for (int i = 0; i < myBank.Length; i++)
                    {
                        if (myBank[i].AccountNumber == rN)
                        {
                            Nt = i;
                            break;
                        }

                    }

                    for (int i = 0; i < myBank.Length; i++)
                    {
                        if (myBank[i].AccountNumber == sAN)
                        {
                            myBank[i].Transfer(amount, myBank[Nt]);
                            break;
                        }
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
