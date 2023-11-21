using System;

class BankAccount
{
    private static int accountNumberSeed = 1234567890; // Initial seed for generating unique account numbers

    public int AccountNumber { get; }
    public string AccountHolderName { get; set; }
    private double balance;

    public double Balance
    {
        get { return balance; }
        private set { balance = value; }
    }

    // Constructor
    public BankAccount(string accountHolderName)
    {
        AccountNumber = GenerateAccountNumber();
        AccountHolderName = accountHolderName;
        Balance = 0;
    }

    // Method to generate a unique account number
    private int GenerateAccountNumber()
    {
        return accountNumberSeed++;
    }

    // Method to deposit money
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ${amount}. New balance: ${Balance}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    // Method to withdraw money
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn ${amount}. New balance: ${Balance}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
        }
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the BankAccount class
        BankAccount myAccount = new BankAccount("Virat");

        // Deposit and withdraw some amount
        myAccount.Deposit(30000);
        myAccount.Withdraw(2000);

        // Print account details
        Console.WriteLine($"Account Number: {myAccount.AccountNumber}");
        Console.WriteLine($"Account Holder: {myAccount.AccountHolderName}");
        Console.WriteLine($"Current Balance: ${myAccount.Balance}");
    }
}
