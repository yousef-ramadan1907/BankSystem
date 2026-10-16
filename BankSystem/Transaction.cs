using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class Transaction
    {
        public string TransactionId { get; set; }
        public string AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.Now;
        public string Type { get; set; }

        public Transaction(string transactionId, string accountNumber, decimal amount, DateTime transactionDate, string type)
        {
            TransactionId = transactionId;
            AccountNumber = accountNumber;
            Amount = amount;
            TransactionDate = transactionDate;
            Type = type;
        }

        public override string ToString()
        {
            return $" transactionId is : {TransactionId} \n accountNumber is : {AccountNumber} \n amount is {Amount} \n transactionDate is : {TransactionDate} \n type is : {Type}";
        }

        public override bool Equals(object obj)
        {
            Transaction t = (Transaction)obj;
            return t.TransactionId == TransactionId ;
        }
         
    }
}
