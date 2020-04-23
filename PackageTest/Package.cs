using System;

namespace PackageTest
{
    public abstract class Package
    {
        protected string FirstNameSender { get; set; }
        protected string LastNameSender { get; set; }
        protected string AddressSender { get; set; }
        protected string FirstNameRecipient { get; set; }
        protected string LastNameRecipient { get; set; }
        protected string AddressRecipient { get; set; }
        protected decimal ShippingCost { get; set; }
        public double weightOfGood;
        public double packagingRate;
        
        
         public Package(string firstnameS, string lastnameS, string addressS, string firstnameR, string lastnameR, string addressR, double weight, double packaging)
        {
            FirstNameSender = firstnameS;
            LastNameSender = lastnameS;
            AddressSender = addressS;
            FirstNameRecipient = firstnameR;
            LastNameRecipient = lastnameR;
            AddressRecipient = addressR;
            WeightOfGood = weight;
            packagingRate = packaging;
        }

        // public decimal ShippingCost
        // {
        //     get{ return shippingCost; }

        //     set
        //     {
        //         if(value > 0)
        //         {
        //             shippingCost = value;
        //         }
        //     }
        // }

         public double WeightOfGood
        {
            get{ return weightOfGood; }

            set
            {
                if(value > 0)
                {
                    weightOfGood = value;
                }
            }
        }

         public double PackagingRate
        {
            get{ return packagingRate; }

            set
            {
                if(value > 0)
                {
                    packagingRate = value;
                }
            }
        }

             public abstract decimal CalculateCost();


             public override string ToString()
             {
                 return $"Name of Recipient: {FirstNameRecipient} {LastNameSender}\nAdresss of Recipient: {AddressRecipient}\n\nName of Sender: {FirstNameRecipient} {LastNameSender}\nAdresss of Sender: {AddressRecipient}";
             }
    }
}
