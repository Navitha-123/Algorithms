using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("choose option 1.StringPermutation 3.insertsort \t 4.bubblesort \t 6.Anagram \t 7. primenumber");

            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    string str = "ABC";
                    int n = str.Length;
                    UC1_StringPermutation.Permute(str, 0, n - 1);
                    break;
                //case 2:

                //    Console.WriteLine("after sorting array:");
                //    Console.WriteLine();
                   
                //    break;
                //case 3:
                //    UC6Anagram.AnangramDetection();
                //    break;
                //case 4:
                //    UC7PrimeNumber.PrimeNumbers();
                //    break;
                default:
                    Console.WriteLine("enter wrong choice");
                    break;


                    Console.ReadLine();
            }
        }
    }
}
    
