using System;

namespace AccountTest
{
    public abstract class Account
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected int AccountNo { get; set; }
        private decimal balance;

        

         public Account (string firstname, string lastname, int accountno, decimal balance)
        {
            FirstName = firstname;
            LastName = lastname;
            AccountNo = accountno;
            Balance = balance;
        }

        public decimal Balance
        {
            get => balance;

            set
            {
                if(value > 0.0m)
                {
                    balance = value;

                }else{
                    throw new ArgumentOutOfRangeException("The balance must be > 0");
                }

            }
        }

        public string Debit( decimal value)
        {
             if(value > Balance)
            {
                 return "Insufficient fund";
            }

                 Balance = Balance - value;
                 return    "Account Debited Successfully";
             
        }

        // public abstract string GetDetails();

        public abstract decimal Credit( decimal value);
       
    }
}
