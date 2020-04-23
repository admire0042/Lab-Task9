using System;
using System.Collections.Generic;

namespace PackageTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoDayPackage twoDayPackage = new TwoDayPackage("Akande","Olufunmi","5,Abooluwa,magodo,Lagos","Inioluwa","Okunade","8,Ebutemeta street,Lagos",20.0,3.0,300m);
            OvernightPackage overnightPackage = new OvernightPackage("Ibrahim","Babatunde","7,Idioro Street,Ibadan","Adebowale","Bolanle","5,Taiwo street,Boluwaji,Ibadan",12.0,3.0,250m);

            List<Package>  packages = new List<Package>() { twoDayPackage, overnightPackage };

                
                   decimal Total = 0m;
            foreach (var package in packages)
            {
                
                Console.WriteLine(package.ToString());
                 Total += package.CalculateCost();

                Console.WriteLine($"\nThe cost of Shipping is: {package.CalculateCost():C}");
                
            }

             Console.WriteLine($"\nThe total cost for the two shippings is: {Total}");
        }
    }
}
