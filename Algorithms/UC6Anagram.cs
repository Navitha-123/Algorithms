using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class UC6Anagram
    {
        public static void AnangramDetection()
        {
            string str1 = "heart";
            string str2 = "aeearth";

            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            String val1 = new string(ch1);
            String val2 = new string(ch2);

            Console.WriteLine(val1 + "  " + val2);

            if (val1 == val2)
                Console.WriteLine("Anangram");
            else
                Console.WriteLine("not an anagram");

        }
    }
}
