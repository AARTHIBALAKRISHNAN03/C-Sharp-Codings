using System;

public class BankAccount
{
    private string accountNumber{ get; set; }
    private decimal balance{get; set; }
    
       
    public BankAccount(string accountNumber, decimal initialBalance)
    {
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
    }

    
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"{amount} deposited successfully. Current balance: {balance}");
        }
        else
        {
            Console.WriteLine("Invalid amount for deposit.");
        }
    }

    
    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"{amount} withdrawn successfully. Current balance: {balance}");
        }
        else
        {
            Console.WriteLine("Invalid amount for withdrawal or insufficient funds.");
        }
    }

   
    public void DisplayAccountDetails()
    {
        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Current Balance: {balance}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        BankAccount account = new BankAccount("123456789", 1000);

       
        account.DisplayAccountDetails();

        
        account.Deposit(500);

       
        account.Withdraw(200);

        
        account.Withdraw(1500);

        
        account.DisplayAccountDetails();
    }
}