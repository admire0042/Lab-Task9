using System;

namespace AccountTest
{
    public class CurrentAccount : Account
    {
         public CurrentAccount(string firstname, string lastname, int accountno, decimal balance) : base(firstname, lastname, accountno, balance)
        {
            
        }

         public override decimal Credit( decimal value)
        {
             Balance = Balance + value;
             return Balance;
        }

        // public override string GetDetails()
        // {
        //     return $"{FirstName}{LastName}\nAccount Number: {AccountNo}\nBalance:{Balance}";
        // }
    }
}
  
