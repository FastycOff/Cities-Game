using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FToUpper
{
    public class ToUpper
    {
        static void Main(string[] args)
        {
            Console.Read();
        }
        public static string ftoupper(string city)
        {
            string subcity = "";
            subcity += Char.ToUpper(city[0]);
            for (int i = 1; i < city.Length; ++i)
            {
                subcity += city[i];
            }
            return subcity;
        }
    }
}
