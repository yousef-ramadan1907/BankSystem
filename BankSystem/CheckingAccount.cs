using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class CheckingAccount : Account
    {
        public decimal OverdraftLimit { get; set; }

        public CheckingAccount(string accountNumber, string holderName, decimal balance, string email, decimal overdraftLimit) : base(accountNumber, holderName, balance, email)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override string ToString()
        {
            return $"Account Number is : {AccountNumber} \n Holder Name is : {HolderName} \n The Balance is : {Balance} \n Email is : {Email} \n OverdraftLimit is {OverdraftLimit}";

        }
        public override bool Equals(object obj)
        {
            CheckingAccount s = (CheckingAccount)obj;
            return s.AccountNumber == AccountNumber;
        }
    }
}
