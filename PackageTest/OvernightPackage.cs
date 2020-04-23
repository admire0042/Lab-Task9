using System;

namespace PackageTest
{
    
    public class OvernightPackage : Package
    {
        private decimal overnightCharge;

         public OvernightPackage(string firstnameS, string lastnameS, string addressS, string firstnameR, string lastnameR, string addressR, double weight, double packaging, decimal overnightCh):base(firstnameS, lastnameS, addressS, firstnameR, lastnameR, addressR, weight, packaging)
        {
            OvernightCharge = overnightCh;
        }


        public decimal OvernightCharge
        {
            get{ return overnightCharge; }

            set
            {
                if(value > 0)
                {
                    overnightCharge = value;
                }
            }
        }

        public override decimal CalculateCost()
        {
            ShippingCost = OvernightCharge + (decimal)(WeightOfGood * PackagingRate);
            return ShippingCost;
        }

    }
}
