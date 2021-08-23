using System;

namespace Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Inis! How many players are playing today?");
            string[] playernames = new string[Convert.ToInt32(Console.ReadLine())];
            int i = 0;
            while(i < playernames.Length)
            {
              Console.WriteLine("Enter Player " + (i+1).ToString() + " name:");
              playernames[i] = Console.ReadLine();
              Console.WriteLine("Player " + (i+1).ToString() + " is named: " + playernames[i] + " is this correct? (y/n)");
              if (Console.ReadLine() == "y") {
                i++;
              }
            }
        }
    }
}
