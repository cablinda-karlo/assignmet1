using System;

class Student
{
    public string studentID;
    public string name;
    public string course;

    public Student(string studentID, string name, string course)
    {
        this.studentID = studentID;
        this.name = name;
        this.course = course;
    }

    public void displayInfo()
    {
        Console.WriteLine("Student ID: " + studentID);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Course: " + course);
        Console.WriteLine();
    }
}

class BankAccount
{
    private string accountNumber;
    private string accountHolder;
    private double balance;

    public BankAccount(string accountNumber, string accountHolder, double balance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Deposit Successful!");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawal Successful!");
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount.");
        }
    }

    public void DisplayBalance()
    {
        Console.WriteLine("Current Balance: " + balance.ToString("F2"));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("2023001", "Karl Luigi P. Cablinda", "BS Information Technology");

        student1.displayInfo();

        BankAccount account = new BankAccount("555555555", "Karl Luigi P. Cablinda", 1000000.00);

        account.Deposit(500);
        account.Withdraw(1000);
        account.DisplayBalance();
    }
}

