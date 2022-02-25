using System;

namespace _01._Agency_Profit
{
    class Program
    {
        static void Main(string[] args)
        {           
            //име на авиокомпанията
            string AirCompany = Console.ReadLine();//WizzAir
            //билети за възрастни
            int ticketsAdults = int.Parse(Console.ReadLine());//15
            //детски билети 
            int ticketsKids = int.Parse(Console.ReadLine());//5
            //нетна цена на билет за възрастен
            double netpriceAdult = double.Parse(Console.ReadLine());//120
            double netpriceKids = netpriceAdult - netpriceAdult * 0.7;//120 - 120*0.7 = 36
            //цена на такса обслужване
            double priceService = double.Parse(Console.ReadLine());//40
            //цена на всички билети за възрастни
            double sumAdultsTickets = (netpriceAdult + priceService) * ticketsAdults;//180 * 15 = 2700
            //цена на всички билети за деца
            double sumKidsTickets = (netpriceKids + priceService) * ticketsKids; // 76 * 5 = 380
            //обще цена на билетите 
            double sum = sumAdultsTickets + sumKidsTickets;//2700 + 380 = 3080
            //печалба за авио кмпанията
            double profit = sum * 0.2; // 3080 * 0.2 = 616
            //отпечатане на ресултата 
            Console.WriteLine($"The profit of your agency from {AirCompany} tickets is {profit:f2} lv.");
        }
    }
}
