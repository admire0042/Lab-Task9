using System;

namespace PackageTest
{
    public class TwoDayPackage: Package
    {
        private decimal twoDayCharge;

         public TwoDayPackage(string firstnameS, string lastnameS, string addressS, string firstnameR, string lastnameR, string addressR, double weight, double packaging, decimal twoDay):base(firstnameS, lastnameS, addressS, firstnameR, lastnameR, addressR, weight, packaging)
        {
            TwoDayCharge = twoDay;
        }


        public decimal TwoDayCharge
        {
            get{ return twoDayCharge; }

            set
            {
                if(value > 0)
                {
                    twoDayCharge = value;
                }
            }
        }

        public override decimal CalculateCost()
        {
            ShippingCost = twoDayCharge + (decimal)(WeightOfGood * PackagingRate);
            return ShippingCost;
        }

    }
}
