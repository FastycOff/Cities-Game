using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CityBuilder
{
    public class MyBuilder
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
        public static string[] Build()
        {
            string ReadPath = @"C:\Users\VPYUR\source\repos\CityGame\TownList.txt";
            try
            {
                using (StreamReader file = new StreamReader(ReadPath, System.Text.Encoding.Default))
                {
                    string line;
                    string[] cities = new string[1121];
                    int counter = 0;
                    while ((line = file.ReadLine()) != null)
                    {
                        cities[counter] = line.Replace(" ", "");
                        ++counter;
                    }
                    return cities;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

    }
}
