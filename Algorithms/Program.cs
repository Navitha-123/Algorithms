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
            Console.WriteLine("choose option 3.insertsort \t 4.bubblesort \t 6.Anagram \t 7. primenumber");

            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    String s = "alkasingh";

                    Console.WriteLine(s);
                    break;
                case 2:

                    Console.WriteLine("after sorting array:");
                    Console.WriteLine();
                   
                    break;
                case 3:
                    UC6Anagram.AnangramDetection();
                    break;
                case 4:
                    UC7PrimeNumber.PrimeNumbers();
                    break;
                default:
                    Console.WriteLine("enter wrong choice");
                    break;


                    Console.ReadLine();
            }
        }
    }
}
    
