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
                    //myBank[i].ShowAccountInformation();
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
                //Console.WriteLine((i + 1) + ". " + myBank[i].);
            }
            
        }
    }
}
