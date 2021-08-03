using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Letters
    {
        public static string LetReplace(string toReplace)
        {
            toReplace = toReplace.ToLower();
            toReplace = toReplace.Replace("ь", "");
            toReplace = toReplace.Replace("ы", "");
            toReplace = toReplace.Replace("э", "");
            toReplace = toReplace.Replace("ц", "");
            toReplace = toReplace.Replace("ш", "");
            toReplace = toReplace.Replace("ф", "");
            toReplace = FToUpper.ToUpper.ftoupper(toReplace);
            return toReplace;
        }
    }
}
