using System;

namespace _02._Add_Bags
{
    class Program
    {
        static void Main(string[] args)
        {
            //цена на багажа над 20 кг.
            double priceForLuggageTwentyKilos = double.Parse(Console.ReadLine());
            //килограми на багажа 
            double leightLuggage = double.Parse(Console.ReadLine());
            // дни до пътуването
            int daysToTravel = int.Parse(Console.ReadLine());
            //брой багаж 
            int numberOfLuggage = int.Parse(Console.ReadLine());
            double price = 0;
            if (leightLuggage < 10)
            {
                double priceLuggage = priceForLuggageTwentyKilos * 0.2;
                if (daysToTravel > 30)
                {
                    price = priceLuggage + priceLuggage * 0.1;
                }
                if (daysToTravel >= 7 && daysToTravel <= 30)
                {
                    price = priceLuggage + priceLuggage * 0.15;
                }
                if (daysToTravel < 7)
                {
                    price = priceLuggage + priceLuggage * 0.4;
                }
            }
            if (leightLuggage >= 10 && leightLuggage <= 20)
            {
                double priceLuggage = priceForLuggageTwentyKilos * 0.5;
                if (daysToTravel > 30)
                {
                    price = priceLuggage + priceLuggage * 0.1;
                }
                if (daysToTravel >= 7 && daysToTravel <= 30)
                {
                    price = priceLuggage + priceLuggage * 0.15;
                }
                if (daysToTravel < 7)
                {
                    price = priceLuggage + priceLuggage * 0.4;
                }
            }
            if (leightLuggage > 20)
            {
                double priceLuggage = priceForLuggageTwentyKilos;
                if (daysToTravel > 30)
                {
                    price = priceLuggage + priceLuggage * 0.1;
                }
                if (daysToTravel >= 7 && daysToTravel <= 30)
                {
                    price = priceLuggage + priceLuggage * 0.15;
                }
                if (daysToTravel < 7)
                {
                    price = priceLuggage + priceLuggage * 0.4;
                }
            }
            //отпечатване на резултата 
            double totalPriceLuggage = price * numberOfLuggage;
            Console.WriteLine($"The total price of bags is: {totalPriceLuggage:f2} lv.");
        }
    }
}
