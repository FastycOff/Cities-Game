using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanMove
{
    class addons
    {
        public static string input()
        {
            string temp = "";
            Console.Write("Вы: ");
            temp = Console.ReadLine();
            Console.WriteLine();
            while (temp == "")
            {
                Console.Write("Нет такого Города или уже было использовано\nВы: ");
                temp = Console.ReadLine();
            }
            return temp;
        }

    }
    public class Human
    {
        static void Main(string[] args)
        {
        }
        public static string Move(char letter, string[] cities)
        {
            string city = addons.input();
            while (cities.Contains(FToUpper.ToUpper.ftoupper(city).Replace(" ", "")) == false | Char.ToLower(city[0]) != letter | city == "")
            {
                Console.Write("Нет такого слова или уже было использовано\n");
                city = addons.input();
            }
            return FToUpper.ToUpper.ftoupper(city).Replace(" ", "");
        }
    }
}
