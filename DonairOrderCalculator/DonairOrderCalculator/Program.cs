using System.Dynamic;

namespace DonairOrderCalculator
{
    class Program
    {
        static Main() 
        {
            bool continueOrder = true;

            while(continueOrder)
            {
                try
                {
                    Console.WriteLine("\n Donair Order Calculator");

                    // Variables for total order//
                    string size = GetDonairSize();
                    int quantity = getQuantity();
                    bool extraCheese = YesOrNo("Would You Like Extra Cheese? Y/N");
                    bool extraMeat = YesOrNo("Would You Like Extra Meat? Y/N");
                    
                    //Variables for donair price//

                    double baseDonairPrice = GetBasePrice(size);
                    double addOns = 0.0;
                    if (extraCheese) addOns = 1.25;
                    if (extraMeat) addOns = 2;

                    // Variables for total price calculations//
                    double subtotal = quantity * (baseDonairPrice + addOns)
                    double discount = Discount();
                    double discountTotal = subtotal - discount;
                    double gst = discountTotal * 0.05;
                    double total = discountTotal + gst;

                   //String interpolation for data storage and output//






                }
            }
        }
    }
}
