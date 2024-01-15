using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount test1 = new BankAccount("Mustapha", 1000000);
            Console.WriteLine(test1.CustomerName);
            Console.WriteLine(test1.AccountNumber);
            Console.WriteLine(test1.Balance);
            Console.WriteLine(test1.Deposit(1000));
            Console.WriteLine(test1.Withdraw(2000));
            BankAccount test2 = new BankAccount("Jung", 2000000);
            Console.WriteLine(test2.CustomerName);
            Console.WriteLine(test2.AccountNumber);
            Console.WriteLine(test2.Balance);
            Console.WriteLine(test2.Deposit(1000));
            Console.WriteLine(test2.Withdraw(2000));
            Console.ReadLine();
        }
    }

    public class BankAccount
    {
        private string customerName;
        private int accountNumber;
        private decimal balance;

        private static int nextAccountNumber = 100000;
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        private static int GetNextAccountNumber() {
            
            return nextAccountNumber++; 
        }

        public decimal Deposit (decimal amount) {
            Balance = amount + balance;
            return balance; 
        }
        public decimal Withdraw(decimal amount)
        {
            Balance = balance - amount;
            return balance;
        }

        public BankAccount(string customerName, decimal balance)
        {
            CustomerName = customerName;
            Balance = balance;
            AccountNumber = GetNextAccountNumber();
        }
    }
}
