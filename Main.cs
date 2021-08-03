using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;


namespace city
{
    public class City
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            string[] cities = CityBuilder.MyBuilder.Build(); // создание списка городов
            if (cities == null) // Если произошла ошибка
            {
                Console.WriteLine("Error #1. Creation city array error.");
            }
            string city = cities[rand.Next(0, 1122)]; // выбор рандомного города для начала игры
            char lastlet = 'А';
            int index = 0;
            while (true)
            {
                // bot move
                city = BotMove.Bot.Move(lastlet, cities);
                index = Array.IndexOf(cities, city);
           
                cities[index] = null;    

                city = Replace.Letters.LetReplace(city);
                lastlet = city[city.Length-1];
                Console.WriteLine($"Вам на букву {lastlet}\n");


                // human move
                city = HumanMove.Human.Move(lastlet, cities);

                index = Array.IndexOf(cities, city);
                cities[index] = null;

                city = Replace.Letters.LetReplace(city);
                lastlet = city[city.Length - 1];

            }
        }

    }
}
