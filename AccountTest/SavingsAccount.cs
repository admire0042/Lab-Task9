using System;

namespace AccountTest
{
    public class SavingsAccount : Account
    {
       private decimal interestRate;

       public SavingsAccount (string firstname, string lastname, int accountno, decimal balance, decimal interest) : base(firstname, lastname, accountno, balance)
        {
            InterestRate = interest;
        }
      
       public decimal InterestRate
       {
           get => interestRate;

           set 
           {
                if(value > 0.0m)
                {
                    interestRate = value;

                }else{
                    throw new ArgumentOutOfRangeException("The balance must be > 0");
                }

           }
       }
       
        public decimal CalculateInterest()
        {
            decimal interest = ((InterestRate/365) * Balance);
            return interest;
        }

         public override decimal Credit( decimal value)
        {
             Balance = Balance + value + CalculateInterest();
             return Balance;
        }

        // public override string GetDetails()
        // {
        //     return $"{FirstName}{LastName}\nAccount Number: {AccountNo}\nInterest rate: {InterestRate} Balance:{Balance}";
        // }

        // public void Credit()
        // {
        //      Balance = Balance + CalculateInterest();
        // }
    }
}
