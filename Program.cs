using System;
namespace BankCon
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********Welcome*************");
            int x = 0;
            while (x != 1)
            {
                UserChoices userChoice = (UserChoices)Enum.Parse(typeof(UserChoices), Console.ReadLine());
                Bank b = new Bank();
                BankService b1 = new BankService();
                int a;
                switch (userChoice)
                {
                    case UserChoices.CreateAccount:
                        {
                            b1.AddAccount( );
                            break;
                        }
                    case UserChoices.Deposit:
                        {
                            a=b1.Deposit();
                            Console.WriteLine($"Your bank balance is {a}");
                            break;
                        }
                    case UserChoices.Withdraw:
                        {
                            a = b1.Deposit();
                            Console.WriteLine($"Your bank balance is {a}");
                            break;
                        }
                    case UserChoices.Transfer:
                        {
                            break;
                        }
                    case UserChoices.Transactions:
                        {
                            break;
                        }
                }
            }
        }
            public enum UserChoices
        {
            CreateAccount = 1,
            Deposit = 2,
            Withdraw = 3,
            Transfer = 4,
            Transactions = 5
            //
        }

        }
    }
