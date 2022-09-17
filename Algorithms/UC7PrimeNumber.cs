using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class UC7PrimeNumber
    {
        public static void PrimeNumbers()
        {
            bool isprime = true;
            Console.WriteLine("Enter the primr numbres");
            for(int i=0;i<=1000;i++)
            {
                for (int j=0;j<=1000;j++)
                {
                   if( i != j && i % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if(isprime)
                {
                    Console.WriteLine(i);

                }
                isprime = true;
            }
        }
    }
}
