using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class SavingsAccount : Account
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(string accountNumber, string holderName, decimal balance, string email,decimal interestRate) : base(accountNumber,holderName,balance,email)
        {
            InterestRate = interestRate;
        }

        public override string ToString()
        {
            return $"Account Number is : {AccountNumber} \n Holder Name is : {HolderName} \n The Balance is : {Balance} \n Email is : {Email} \n interestRate is {InterestRate}";

        }
        public override bool Equals(object obj)
        {
            SavingsAccount s = (SavingsAccount)obj;
            return s.AccountNumber == AccountNumber ;
        }
    }
}
