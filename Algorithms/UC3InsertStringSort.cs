using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class UC3InsertStringSort
    {
        static int MAX_CHAR = 26;
        
        public void sortString(string str)
        {
            int []charCount = new int[MAX_CHAR];
            for(int i=0;i< str.Length; i++)
            {
                charCount[str[i] - 'a']++;
            }
            for (int i = MAX_CHAR - 1; i >= 0; i--)
            {
                for (int j = 0; j < charCount[i]; j++)
                {
                    Console.Write((char)('a' + i));
                }
            }
        }
    }
}
