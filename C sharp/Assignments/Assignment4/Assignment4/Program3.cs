using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    using System;


public class InsufficientBalance : Exception
{
    public InsufficientBalance() { }

    public InsufficientBalance(string message) 
        : base(message) { }

    public InsufficientBalance(string message, Exception innerException) 
        : base(message, innerException) { }
}


public class BankAccount
{
    private decimal balance;

    public BankAccount(decimal initialBalance)
    {
        if (initialBalance < 0)
        {
            throw new ArgumentException("Initial balance cannot be negative,Try again!!");
        }
        this.balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive.");
        }
        this.balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive.");
        }
        if (amount > this.balance)
        {
            throw new InsufficientBalance("Insufficient balance for withdrawal,Try again");
        }
        this.balance -= amount;
    }

    public decimal Balance
    {
        get { return balance; }
    }
}


public class Program3
{
    public static void Main()
    {
        try
        {
            BankAccount account = new BankAccount(2000); 
            Console.WriteLine("Current Balance: " + account.Balance);

            account.Deposit(500);
            Console.WriteLine("After Deposit, Balance: " + account.Balance);

            account.Withdraw(300);
            Console.WriteLine("After Withdrawal, Balance: " + account.Balance);

            
            account.Withdraw(1500);
            Console.WriteLine("After Withdrawal Again, Balance: " + account.Balance); 

        }
        catch (ArgumentException e)
        {
            Console.WriteLine("Argument error: " + e.Message);
        }
        catch (InsufficientBalance e)
        {
            Console.WriteLine("Insufficient balance error: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected error: " + e.Message);
        }
            Console.Read();
    }
}

}
