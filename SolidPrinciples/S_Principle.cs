using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates.SolidPrinciples
{

    //Single Responsibility Principle (SRP). It states that a class should have only one reason to change,meaning it should have only one responsibility or function.

    public class BankAccount
    {
        public void Deposit(decimal amount)
        {
            Console.WriteLine($"Deposited: {amount}");
        }

        public void Withdraw(decimal amount)
        {
            Console.WriteLine($"Withdrawn: {amount}");
        }

        public void PrintStatement()
        {
            Console.WriteLine("Printing bank statement...");
        }

        public void SendEmail(string emailAddress)
        {
            Console.WriteLine($"Sending email to {emailAddress}");
        }
    }




    //After apply 'S'


    public class BankAccount1
    {
        public void Deposit(decimal amount)
        {
            Console.WriteLine($"Deposited: {amount}");
        }

        public void Withdraw(decimal amount)
        {
            Console.WriteLine($"Withdrawn: {amount}");
        }
    }

    public class BankStatement
    {
        public void PrintStatement()
        {
            Console.WriteLine("Printing bank statement...");
        }
    }

    public class EmailService
    {
        public void SendEmail(string emailAddress)
        {
            Console.WriteLine($"Sending email to {emailAddress}");
        }
    }


}

