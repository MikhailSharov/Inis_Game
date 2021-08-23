using System;

namespace Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Inis! How many players are playing today?");
            int numplayers = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while(i <= numplayers)
            {
              Console.WriteLine("Enter Player " + i.ToString() + " name:");
              string playername = Console.ReadLine();
              Console.WriteLine("Player " + i.ToString() + " is named: " + playername + " is this correct? (y/n)");
              string response = Console.ReadLine();
              if (response == "y") {
                i++;
              }
            }
        }
    }
}
