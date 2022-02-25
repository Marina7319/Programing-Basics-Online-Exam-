using System;

namespace _05._Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            string player = "";
            int gols = 0;
            string input = Console.ReadLine();
            int max = int.MinValue;
            int sum = 0;
            while(input != "END")
            {

                    input = Console.ReadLine();
                    gols = int.Parse(input);

                    if (gols >= 10)
                    {
                        break;
                    }
                
                input = Console.ReadLine();               
            } 
            if(input == "END")
            {             
                sum += gols;
                if (gols > max)
                {
                    max = gols;
                }
                if (max < 3)
                {
                    Console.WriteLine($"{input} is the best player!");
                    Console.WriteLine($"He has scored {max} goals.");
                }
                
                if (max >= 3)
                {
                    Console.WriteLine($"{input} is the best player!");
                    Console.WriteLine($"He has scored {gols} goals and made a hat-trick!!!");
                }
            }
            if (gols >= 10)
            {
                Console.WriteLine($"{input} is the best player!");
                Console.WriteLine($"He has scored {gols} goals and made a hat-trick!!!");
            }
        }
    }
}
