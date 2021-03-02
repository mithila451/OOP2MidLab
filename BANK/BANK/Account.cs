using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;
        static int idg = 5670;

        public Account(Address address)
        {
            this.address = address;
        }

        public string AccountName
        {
            get { return this.accountName; } set { this.accountName = value; }
        }

        public double Balance
        {
            get { return this.balance; } set { this.balance = value; }
        }

        public Address Address
        {
            get { return this.address; } set { this.address = value; }
        }

        public int AccountNumber
        {
            get { return this.accountNumber; }
        }

        public void GenarateAccountNumber()
        {
            this.accountNumber = idg;
            idg++;
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance = balance - amount;
            }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance = balance + amount;
            }
        }

        public void Transfer(double amount, Account receiver)
        {
            if (amount > 0 && amount <= balance)
            {
                balance = balance - amount;
                receiver.Deposit(amount);
            }
        }



    }
}
