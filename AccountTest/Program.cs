using System;
using System.Collections.Generic;
namespace AccountTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SavingsAccount savingsAccount = new SavingsAccount("Ajao", "Adebola",3055,4000m, 0.04m);
            CurrentAccount currentAccount = new CurrentAccount("Olaoluwa", "Gbadamosi", 3056,2500m);
            List<Account> accounts = new List<Account>() { savingsAccount, currentAccount };
           

             Console.WriteLine("What type of transaction do you want to perform: Debit or Credit?");
             string typeOfTran = Console.ReadLine().ToUpper();

            if(typeOfTran == "DEBIT")
            {
                Console.WriteLine("Enter the type of account: Savings or Current");
                string typeOfAcct = Console.ReadLine().ToUpper();

                if(typeOfAcct == "SAVINGS")
                {
                    Console.Write("Enter the amount to debit: ");
                    decimal debit = decimal.Parse(Console.ReadLine());
                    accounts[0].Debit(debit);

                    decimal interest = accounts[0].Credit(0.0m);
                    Console.WriteLine($"\nCurrent balance is: {accounts[0].Balance:C}");
                    
                    } else if(typeOfAcct == "CURRENT"){

                        Console.WriteLine("Enter the amount to debit: ");
                        decimal debit = decimal.Parse(Console.ReadLine());
                        accounts[1].Debit(debit);
                     
                        Console.WriteLine($"\nCurrent balance is: {accounts[1].Balance:C}");
                    }

                 }else if(typeOfTran == "CREDIT"){

                    Console.WriteLine("Enter the type of account: Savings or Current");
                    string typeOfAcct = Console.ReadLine().ToUpper();

                if(typeOfAcct == "SAVINGS")
                {
                    Console.WriteLine("Enter the amount to deposit: ");
                    decimal credit = decimal.Parse(Console.ReadLine());
                    accounts[0].Credit(credit);

                    decimal interest = accounts[0].Credit(0.0m);
                    Console.WriteLine($"\nCurrent balance is: {accounts[0].Balance:C}");

                } else if(typeOfAcct == "CURRENT"){

                    Console.WriteLine("Enter the amount to deposit: ");
                    decimal credit = decimal.Parse(Console.ReadLine());
                    accounts[1].Credit(credit);

                    Console.WriteLine($"\nCurrent balance is: {accounts[1].Balance:C}");
                }
            }
        }
    }
}
