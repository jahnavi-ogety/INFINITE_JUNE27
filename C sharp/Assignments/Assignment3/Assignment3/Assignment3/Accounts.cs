using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    using System;

    public class Accounts
    {
        
        private int accountNo;
        private string customerName;
        private string accountType;
        private char transactionType;
        private double amount;
        private double balance;

        
        public Accounts(int accountNo, string customerName, string accountType, char transactionType)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;
            this.transactionType = transactionType;
            this.amount = 0; 
            this.balance = 0; 
        }

        
        public void ProcessTransaction(double transactionAmount)
        {
            amount = transactionAmount;

            if (transactionType == 'D' || transactionType == 'd')
            {
                Credit();
            }
            else if (transactionType == 'W' || transactionType == 'w')
            {
                Debit();
            }
            else
            {
                Console.WriteLine("Invalid transaction type.");
            }
        }

        
        private void Credit()
        {
            balance += amount;
        }

        
        private void Debit()
        {
            if (balance >= amount)
            
                balance -= amount;
            
            
        }

        
        public void ShowData()
        {
            Console.WriteLine("Account Details:");
            Console.WriteLine($"Account No: {accountNo}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Account Type: {accountType}");
            Console.WriteLine($"Transaction Type: {transactionType}");
            Console.WriteLine($"Amount: {amount}");
            Console.WriteLine($"Balance: {balance}");
        }

        
        public static void Main(string[] args)
        {
            
            Accounts account1 = new Accounts(123456789, "Jahnavi", "Savings", 'D');
            account1.ProcessTransaction(1000); 
            account1.ShowData(); 


            Accounts account2 = new Accounts(987654321, "latha", "Checking", 'W');
            account2.ProcessTransaction(500); 
            account2.ShowData();
            Console.ReadLine();
        }
    }
}



