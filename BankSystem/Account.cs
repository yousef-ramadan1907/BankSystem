using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class Account
    {
        public string AccountNumber { get; set; }
        public string HolderName { get; set; }
        public decimal Balance { get; set; }
        public string Email { get; set; }

        public Account(string accountNumber, string holderName, decimal balance, string email)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;
            Email = email;
        }

        public override string ToString()
        {
            return $"Account Number is : {AccountNumber} \n Holder Name is : {HolderName} \n The Balance is : {Balance} \n Email is : {Email}";
        }

        public override bool Equals(object obj)
        {
            Account a = (Account)obj;
            return a.AccountNumber == AccountNumber ;
        }
    }
}
