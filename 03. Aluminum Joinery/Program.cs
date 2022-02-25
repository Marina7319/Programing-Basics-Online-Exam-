using System;

namespace _03._Aluminum_Joinery
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 0;
            int numberAluminum = int.Parse(Console.ReadLine());
            //брой дограми 
            string kindAluminum = Console.ReadLine();
            //вид на дограмите 
            string delivery = Console.ReadLine();
            if (numberAluminum <= 10)
            {
                Console.WriteLine("Invalid order");
                return;
            }
            switch (kindAluminum)
            {
                case "90X130":
                    int price90x130 = 110;
                    double sumprice90X130 = price90x130 * numberAluminum;
                    price = sumprice90X130;
                    if (numberAluminum >= 30)
                    {
                        double discount = sumprice90X130 - sumprice90X130 * 0.05;
                        price = discount;
                    }
                    if (numberAluminum >= 60)
                    {
                        double discount = sumprice90X130 - sumprice90X130 * 0.08;
                        price = discount;
                    }
                    break;
                case "100X150":
                    int price100x150 = 140;
                    double sumPrice100X150 = price100x150 * numberAluminum;
                    price = sumPrice100X150;
                    if (numberAluminum >= 40)
                    {
                        double discount = sumPrice100X150 - sumPrice100X150 * 0.06;
                        price = discount;
                    }
                    if (numberAluminum >= 80)
                    {
                        double discount = sumPrice100X150 - sumPrice100X150 * 0.1;
                        price = discount;
                    }
                    break;
                case "130X180":
                    int price130x180 = 190;
                    double sumPrice130X180 = price130x180 * numberAluminum;
                    price = sumPrice130X180;
                    if (numberAluminum >= 20)
                    {
                        double discount = sumPrice130X180 - sumPrice130X180 * 0.07;
                        price = discount;
                    }
                    if (numberAluminum >= 50)
                    {
                        double discount = sumPrice130X180 - sumPrice130X180 * 0.12;
                        price = discount;
                    }
                    break;
                case "200X180":
                    int price200x180 = 250;
                    double sumPrice200X180 = price200x180 * numberAluminum;
                    price = sumPrice200X180;
                    if (numberAluminum >= 25)
                    {
                        double discount = sumPrice200X180 - sumPrice200X180 * 0.09;
                        price = discount;
                    }
                    if (numberAluminum >= 50)
                    {
                        double discount = sumPrice200X180 - sumPrice200X180 * 0.14;
                        price = discount;
                    }
                    break;
            }
            if (delivery == "With delivery")
            {
                double priceWithDelivery = price + 60;
                if (numberAluminum >= 99)
                {
                    double priceMore99 = priceWithDelivery - priceWithDelivery * 0.04;
                    Console.WriteLine($"{priceMore99:f2} BGN");
                }else
                {
                    Console.WriteLine($"{priceWithDelivery:f2} BGN");
                }
            }
            else
            {                            
                if (numberAluminum >= 99)
                {
                    double priceMore99 = price - price * 0.04;
                    Console.WriteLine($"{priceMore99:f2} BGN");
                }else
                {
                    Console.WriteLine($"{price:f2} BGN");
                }
            }
        }
    }
}
