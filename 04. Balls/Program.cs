using System;

namespace _04._Balls
{
    class Program
    {
        static void Main(string[] args)
        {
           // string color = "";
            double points = 0; 
            int balls = int.Parse(Console.ReadLine());
            int red = 0;
            int orange = 0;
            int yellow = 0;
            int white = 0;
            int other = 0;
            int blackDivides = 0;
            for (int i = 1; i <= balls; i++)
            {
                string colors = Console.ReadLine();
                

                if (colors == "red")
                {
                    red++;
                    points += 5;
                }
                if (colors == "orange")
                {
                    orange++;
                    points += 10;
                }
                if (colors == "yellow")
                {
                    yellow++;
                    points += 15;
                }
                if (colors == "white")
                {
                    white++;
                    points += 20;
                }
                if (colors == "black")
                {
                    double black = Math.Floor(points / 2);
                    blackDivides++;
                    points = black;
                }
                 if(colors != "red" && colors != "orange" && colors != "yellow" && colors != "white" && colors != "black")
                {
                    other++;
                }
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {red}");
            Console.WriteLine($"Orange balls: {orange}");
            Console.WriteLine($"Yellow balls: {yellow}");
            Console.WriteLine($"White balls: {white}");
            Console.WriteLine($"Other colors picked: {other}");
            Console.WriteLine($"Divides from black balls: {blackDivides}");
        }
    }
}

