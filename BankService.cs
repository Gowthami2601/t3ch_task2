using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BankCon
{
    public class BankService
    {
        Dictionary<int, int> bankdata = new Dictionary<int, int>();
        List<string> TransactionHistory = new List<string>();
        int accountId = 1000;
        public int amount = 0;
        string s;
        Bank b = new Bank();
        public void AddAccount()
        {
            string accountName =b.GetStringInput();
            string pin =b.GetStringInput();
            accountId += 1;
            bankdata.Add(accountId, amount);
            Console.WriteLine("Your Account is created");
        }
        public int Deposit()
        {
            Console.WriteLine("Enter your account number");
            accountId =b.GetIntInput();
            if (bankdata.ContainsKey(accountId))
            {
                Console.WriteLine("Enter the amount");
                int deposit =b.GetIntInput();
                bankdata[accountId] += deposit;
                s = "Amount " + deposit+ " is credited in your account(" + accountId + ").Your current balance is" + bankdata[accountId];
                Transaction(s);
                return bankdata[accountId];
            }
            else
            {
                Console.WriteLine("Invalid account number");
                return bankdata[accountId];
            }
        }
        public int Withdraw()
        {
            Console.WriteLine("Enter your account number");
            accountId = b.GetIntInput();
            if (bankdata.ContainsKey(accountId))
            {
                Console.WriteLine("Enter the amount");
                int withdraw =b.GetIntInput();
                if (withdraw > bankdata[accountId])
                {
                    Console.WriteLine("No Sufficient Bank Balance");
                }
                else
                {
                    bankdata[accountId] -= withdraw;
                    Console.WriteLine($"Your bank balance is {bankdata[accountId]}");
                }
                s = "Amount " + withdraw+ " is debited in your account(" + accountId + ").Your current balance is" + bankdata[accountId];
                Transaction(s);
                return bankdata[accountId];
            }
            else
            {
                Console.WriteLine("Invalid account number");
                return bankdata[accountId];
            }
        }
        public void Transfer()
        {
            Console.WriteLine("Enter your account number");
            accountId =b.GetIntInput();
            Console.WriteLine("Enter account number to which money should be transfered");
            int accno1 =b.GetIntInput();
            if (bankdata.ContainsKey(accountId) == false || bankdata.ContainsKey(accno1) == false)
            {
                Console.WriteLine("Invalid account number");
            }
            else
            {
                Console.WriteLine("Enter the amount");
                int transfer = int.Parse(Console.ReadLine());
                if (transfer > bankdata[accountId])
                {
                    Console.WriteLine("No Sufficient Bank Balance");
                }
                else
                {
                    bankdata[accountId] -= transfer;
                    bankdata[accno1] += transfer;
                    Console.WriteLine($"Your bank balance is {bankdata[accountId]}");
                }
                s = "Amount " + transfer+ " is transferd from your account(" + accountId + ")to account(" + accno1 + ").Your current balance is" + bankdata[accountId];
                Transaction(s);
            }
        }
        public void Transaction(string s1)
        {
            TransactionHistory.Add(s1);
        }
        public void Transactions()
        {
            foreach(string i in TransactionHistory)
            {
                Console.WriteLine(i);
            }
        }
    }
}
