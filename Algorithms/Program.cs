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
            Console.WriteLine("choose option 3.insertsort \t 4.bubblesort");

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
                default:
                    Console.WriteLine("enter wrong choice");
                    break;


                    Console.ReadLine();
            }
        }
    }
}
    
