using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp2023
{
    public class Accounts
    {
        public static int ACCOUNT_NUM = 1;
        public string FirstName { get; set; }   
        public string LastName { get; set; }
        public double Balance { get; set; }
        public int AccNum { get; set; }

        public Accounts(string firstName, string lastName, double balance) 
        {
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
            AccNum = ACCOUNT_NUM++;
        }

        public void Deposit(double value)
        {
            Balance += value;
        }

        public void Withdraw(double value)
        {
            Balance -= value;
        }

        public override string ToString()
        {
            return $"First Name: {FirstName}\nLast Name: {LastName}\nAccount Number: {AccNum}\nBalance: {Balance}";
        }


    }
}
