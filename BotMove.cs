using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotMove
{
    public class Bot
    {
        static void Main(string[] args)
        {
        }
        public static string Move(char letter, string[] cities)
        {
            var rand = new Random();
            foreach (string city in cities)
            {
                if (city != null)
                {
                    if (city[0] == Char.ToUpper(letter) & rand.Next(1,5) == 1)
                    {
                        Console.WriteLine($"Бот: {city}");
                        return city;
                    }
                }
            }
            foreach (string city in cities)
            {
                if (city != null)
                {
                    if (city[0] == Char.ToUpper(letter))
                    {
                        Console.WriteLine($"Бот: {city}");
                        return city;
                    }
                }
            }
            return "ь";
        }
    }
}
