using System;
using System.Collections.Generic;
using System.Text;
class main {
    public static void Main(){
        Dictionary<string,int> bankdata = new Dictionary<string,int>();
        List<string> transaction = new List<string>();
        int accamt=0;
        int x=0;
        int withdraw;
        int transfer;
        int deposit;
        int choice;
        string s;
        string accno;
        while(x!=1){
            Console.WriteLine("1.Create account\n2.Withdraw amount\n3.Deposit Amount\n4.Trnasfer amount\n5.Transactions\n6.Exit");
            Console.WriteLine("------------------------");
            Console.WriteLine("Choose any option");
            choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:
                    Console.WriteLine("Enter your account number");
                    accno=Console.ReadLine();
                    if(bankdata.ContainsKey(accno)){
                        Console.WriteLine("Account is already available");
                    }
                    else{
                        bankdata.Add(accno,accamt);
                        Console.WriteLine("Your account is created");
                        s=accno+" is created";
                        transaction.Add(s);
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter your account number");
                    accno=Console.ReadLine();
                    if(bankdata.ContainsKey(accno)){
                        Console.WriteLine("Enter the amount");
                        withdraw = int.Parse(Console.ReadLine());
                        if(withdraw>bankdata[accno]){
                            Console.WriteLine("No Sufficient Bank Balance");
                        }
                        else{
                            bankdata[accno]-=withdraw;
                            Console.WriteLine($"Your bank balance is {bankdata[accno]}");
                        }
                        s="Amount "+withdraw.ToString()+" is debited in your account("+accno+").Your current balance is"+bankdata[accno].ToString();
                        transaction.Add(s);
                    }
                    else{
                        Console.WriteLine("Invalid account number");
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter your account number");
                    accno=Console.ReadLine();
                    if(bankdata.ContainsKey(accno)){
                        Console.WriteLine("Enter the amount");
                        deposit = int.Parse(Console.ReadLine());
                        bankdata[accno]+=deposit;
                        Console.WriteLine($"Your bank balance is {bankdata[accno]}");
                        s="Amount "+deposit.ToString()+" is credited in your account("+accno+").Your current balance is"+bankdata[accno].ToString();
                        transaction.Add(s);
                    }
                    else{
                        Console.WriteLine("Invalid account number");
                    }
                    break;
                case 4:
                    Console.WriteLine("Enter your account number");
                    accno=Console.ReadLine();
                    Console.WriteLine("Enter account number to which money should be transfered");
                    String accno1=Console.ReadLine();
                    if(bankdata.ContainsKey(accno)==false || bankdata.ContainsKey(accno1)==false){
                        Console.WriteLine("Invalid account number");
                    }
                    else{
                        Console.WriteLine("Enter the amount");
                        transfer = int.Parse(Console.ReadLine());
                        if(transfer>bankdata[accno]){
                            Console.WriteLine("No Sufficient Bank Balance");
                        }
                        else{
                            bankdata[accno]-=transfer;
                            bankdata[accno1]+=transfer;
                            Console.WriteLine($"Your bank balance is {bankdata[accno]}");
                        }
                        s="Amount "+transfer.ToString()+" is transferd from your account("+accno+")to account("+accno1+").Your current balance is"+bankdata[accno].ToString();
                        transaction.Add(s);
                    }
                    break;
                case 5:
                    foreach(string i in transaction){
                        Console.WriteLine(i);
                    }
                    break;
                case 6:
                    x=1;
                    Console.WriteLine("Thanks :)");
                    break;
            }
                
        }
    }
}